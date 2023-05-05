using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View.Product;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class Bill : Form
    {
        Hoa_donBLL bll;
        Chi_tiet_hoa_donBLL chi_tiet_;
        KhachHang khBLL = new KhachHang();
        HoaDon hoaDonBLL = new HoaDon();
        private List<Chi_tiet_hoa_don> ct;
        private double tongTien;
     
        public Bill()
        {
            InitializeComponent();
        }

       
        public Bill(List<Chi_tiet_hoa_don> a, double t)
        {
            InitializeComponent();
            bll = new Hoa_donBLL();
            chi_tiet_ = new Chi_tiet_hoa_donBLL();
            ct = a;

            tongTien = t;
            Load(t);
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Hoa_don hd = new Hoa_don()
                {
                    Ma_NV = Const.taiKhoan.Ma_TK,
                    Trang_thai = true,
                    Ngay_mua = Convert.ToDateTime(txtTime.Text.ToString()),
                    Ma_KH = khBLL.GetKHByPhone(txtPhone.Text).Ma_KH,
                    Tong_tien = (decimal)tongTien

                };

                Chi_tiet_hoa_don cthd = new Chi_tiet_hoa_don()
                {
                    Ma_HD = hd.Ma_HD,
                    //Ma_SP = 
                };
                using (PBL_3Entities cnn = new PBL_3Entities())
                {
                    cnn.Hoa_don.Add(hd);
                    cnn.Chi_tiet_hoa_don.Add(cthd);
                    cnn.SaveChanges();
                }
                MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtIdBill.Text = hd.Ma_KH.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fTrangChu f = new fTrangChu();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
        public void Load(double t)
        {
            txtIdBill.Enabled = false;
            txtStaff.Enabled = false;
            txtTime.Enabled = false;
            txtStaff.Text = Const.taiKhoan.Ten_TK;
            txtTime.Text = DateTime.Now.ToString();

            chi_tiet_.ShowDGV(dataGridView1, ct);
            txtTotal.Enabled = false;
            txtTotal.Text = t.ToString();

        }
        private void Bill_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            KhachHang khBLL = new KhachHang();
            Khach_hang kh = khBLL.GetKHByPhone(txtPhone.Text);
            if (kh == null)
            {
                AddNewCustomer f = new AddNewCustomer();
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
                this.Dispose();
            }
            else
            {
                txtCustomer.Text = kh.Ten_KH;
            }
        }
    }
}
