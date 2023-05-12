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
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        Khach_hangBLL khBLL = new Khach_hangBLL();  
        private List<Chi_tiet_hoa_don> listCTHD;
        private double tongTien;
     
        public Bill()
        {
            InitializeComponent();
        }

       
        public Bill(List<Chi_tiet_hoa_don> list, double t)
        {
            InitializeComponent(); 
            listCTHD = list;
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
                    Tong_tien = tongTien

                };

                //using (PBL_3Entities cnn = new PBL_3Entities())
                //{
                //    cnn.Hoa_don.Add(hd);
                //    cnn.Chi_tiet_hoa_don.AddRange(listCTHD);
                //    cnn.SaveChanges();
                //}
                hdBLL.SaveHD(hd);
                cthdBLL.AddList(listCTHD);
                txtIdBill.Text = hd.Ma_KH.ToString();
                MessageBox.Show("In thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                
                this.Hide();
                fBill_PrePrint f = new fBill_PrePrint(hd.Ma_HD);
                f.ShowDialog();
                f = null;
                this.Show();
                this.btnInHoaDon.Enabled = false;

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
            cthdBLL.ShowDGV(dataGridView1, listCTHD);
            txtTotal.Enabled = false;
            txtTotal.Text = t.ToString();

        }
        private void Bill_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
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
