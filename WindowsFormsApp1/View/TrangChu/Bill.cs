using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
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

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Khach_hang kh;
                if (txtCustomer.Enabled)
                {
                    kh = new Khach_hang()
                      {
                        Ten_KH = txtCustomer.Text,
                        SDT = txtPhone.Text,
                        Diem_tich_luy = Convert.ToInt32(txtDiemTL.Text)
                       };
                    khBLL.SaveKH(kh);
                }
                else
                {
                    kh = khBLL.GetKHByPhone(txtPhone.Text);
                }
                double thanhTien;
                if (chkSD_Diem.Checked)
                {
                    thanhTien = tongTien - Convert.ToInt32(txtDiemTL.Text) * 1000;
                    kh.Diem_tich_luy = 0;
                    khBLL.SaveKH(kh);
                }
                else
                {
                    thanhTien = tongTien;
                }
                Hoa_don hd = new Hoa_don()
                {
                    Ma_NV = Const.taiKhoan.Ma_TK,
                    Trang_thai = true,
                    Ngay_mua = Convert.ToDateTime(txtTime.Text.ToString()),
                    Ma_KH = khBLL.GetKHByPhone(txtPhone.Text).Ma_KH,
                    Tong_tien = thanhTien,
                };

                //using (PBL_3Entities cnn = new PBL_3Entities())
                //{
                //    cnn.Hoa_don.Add(hd);
                //    cnn.Chi_tiet_hoa_don.AddRange(listCTHD);
                //    cnn.SaveChanges();
                //}
                hdBLL.SaveHD(hd);
                txtIdBill.Text = hd.Ma_KH.ToString();
                if (hd.Tong_tien > 100000)
                {
                    kh.Diem_tich_luy += Convert.ToInt32(0.00001 * hd.Tong_tien);
                    khBLL.SaveKH(kh);
                }
                
                foreach (Chi_tiet_hoa_don ct in listCTHD)
                {
                    Chi_tiet_hoa_don cthd = new Chi_tiet_hoa_don()
                    {
                        Ma_HD = hd.Ma_HD,
                        Ma_SP = ct.Ma_SP,
                        Kich_thuoc = ct.Kich_thuoc,
                        Soluong_SP = ct.Soluong_SP,
                        Gia = ct.Gia,
                    };
                    cthdBLL.SaveCTHD(cthd);
                }
                //if (listCTHD.Count > 1)
                //{
                //    cthdBLL.AddList(listCTHD);
                //}
                //else if(listCTHD.Count == 1)
                //{
                //    cthdBLL.SaveCTHD(listCTHD.FirstOrDefault());
                //}
                
               
                MessageBox.Show("Đã thanh toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                fBill_PrePrint f = new fBill_PrePrint(hd.Ma_HD);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fTrangChu f = new fTrangChu();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
            //f.ShowDialog();
            //f = null;
            //this.TopLevel = false;
            ////((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(this);
            //this.Show();
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
                //AddNewCustomer f = new AddNewCustomer();
                //f.TopLevel = false;
                //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                //f.Show();
                //this.Dispose();
                txtDiemTL.Text = "0";
            }
            else
            {
                txtCustomer.Text = kh.Ten_KH;
                txtDiemTL.Text = kh.Diem_tich_luy.ToString();
                txtCustomer.Enabled = false;
                txtDiemTL.Enabled = false;
            }
        }

        private void chkSD_Diem_CheckedChanged(object sender, EventArgs e)
        {
            if(txtDiemTL.Text == "0") 
            {
                MessageBox.Show("Điểm tích lũy = 0", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
