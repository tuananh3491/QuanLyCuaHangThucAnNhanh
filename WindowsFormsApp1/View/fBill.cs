using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fBill : Form
    {
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        public fBill()
        {
            InitializeComponent();
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count == 1)
            {
                int maHD = Convert.ToInt32(dg.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(maHD.ToString());
                fBill_Detail f = new fBill_Detail(maHD);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
        }
        public void ShowDGV(DataGridView dg)
        {
           
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            List<Hoa_don> l=new List<Hoa_don>();
            l = hdBLL.GetHD();
            foreach(Hoa_don p in l)
            {
                dg.Rows.Add(p.Ma_HD, p.Tai_khoan.Nhan_vien.Ten_NV, p.Khach_hang.Ten_KH, p.Ngay_mua, p.Tong_tien, p.Trang_thai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            dg.DataSource = hdBLL.GetHDByDate(date);
        }
    }
}
