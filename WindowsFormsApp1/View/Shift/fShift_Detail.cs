using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fShift_Detail : Form
    {
        Phan_congBLL pcBLL = new Phan_congBLL(); 
        Ca_lam_viecBLL caBLL = new Ca_lam_viecBLL();
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();  
        int x;// mã ca
        TimeSpan ketThucCa; TimeSpan batDauca;
       
        public fShift_Detail(int x)
        {
            InitializeComponent();
            pcBLL = new Phan_congBLL();
            this.x = x;
            reload();
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if (Const.taiKhoan.Loai_TK)
            {
                groupBox1.Visible = false;
            }

        }
        public void SetCBBNV(DateTime ngay)
        {
            cbbNV.Items.Clear();
            List<int> maNVLam = pcBLL.GetMaNVPC(x, ngay);
            List<int> maAll = nvBLL.GetAllMaNV();
            foreach (int ma in maNVLam)
            {
                maAll.Remove(ma);
            }
            foreach(int ma in maAll)
            {
                cbbNV.Items.Add(ma);
            }
        }
        private void fShift_Detail_Load(object sender, EventArgs e)
        {
            lblCa.Text = caBLL.GetCLV(x).Ten_ca;
            txtTGBD.Text = caBLL.GetCLV(x).Thoigianbatdau.ToString();
            txtTGKT.Text = caBLL.GetCLV(x).Thoigianketthuc.ToString();
        }
        private void reload()
        {
            dataGridView1.DataSource = pcBLL.GetNVsByCa_Date(x, dtpLich.Value);
            SetCBBNV(dtpLich.Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pcBLL.GetNVsByCa_Date(x, dtpLich.Value);
            try
            {
                if (dtpLich.Value < DateTime.Today) throw new ArgumentException();
                pcBLL.SavePC(new Phan_cong
                {
                    Ma_ca = x,
                    Ma_NV = int.Parse(cbbNV.Text),
                    Ngay = dtpLich.Value,
                    luongGio = nvBLL.GetNVByMa(int.Parse(cbbNV.Text)).Luong,
                    soGio = (ketThucCa - batDauca).TotalMinutes / 60,
                });
                reload();
            }
            catch (FormatException)
            {
                MessageBox.Show("NV KHÔNG HỢP LỆ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("NGÀY LÀM VIỆC KHÔNG HỢP LỆ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dtpLich.Value >= DateTime.Today)
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    try
                    {
                        int maNV = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        DateTime ngay = pcBLL.GetPhanCong(x, maNV, dtpLich.Value.Date);
                        pcBLL.DeletePC(x, maNV, ngay);
                        reload();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn không thể xóa nhân việc trong ca làm việc này", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fShift f = new fShift();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            reload();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenNV.Text = nvBLL.GetNVByMa(int.Parse(cbbNV.Text)).Ten_NV;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dtpLich.Value >= DateTime.Today)
            {
                TimeSpan tgBatDau = TimeSpan.Parse(dtpBatDau.Text);
                TimeSpan tgKetThuc = TimeSpan.Parse(dtpKetThuc.Text);
                double thoiGianDuyTri = tgKetThuc.TotalSeconds - tgBatDau.TotalSeconds;
                double ssBatDau = tgBatDau.TotalSeconds - TimeSpan.Parse(txtTGBD.Text).TotalSeconds;
                double ssKetThuc = TimeSpan.Parse(txtTGKT.Text).TotalSeconds - tgKetThuc.TotalSeconds;


                if (dataGridView1.SelectedRows.Count == 1)
                {
                    if (thoiGianDuyTri > 0 && ssBatDau > 0 && ssKetThuc > 0)
                    {
                        int maNV = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        Phan_cong pc = pcBLL.GetPhanCong(x, maNV, dtpLich.Value);
                        pc.soGio -= (tgKetThuc - tgBatDau).TotalMinutes / 60;
                        pcBLL.SavePC(pc);
                        MessageBox.Show("Duyệt thành công", "Thông báo");
                    }
                    else MessageBox.Show("Khoảng thời gian bạn chọn không phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Chọn nhân viên cần phê duyệt", "Lỗi");
                }
            }
            else MessageBox.Show("Ngày không phù hợp", "Lỗi");
        }
       
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = pcBLL.ShowSearch(x, txtSearch.Text, dtpLich.Value);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label10.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
