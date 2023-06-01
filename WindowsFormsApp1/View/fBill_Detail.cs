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

namespace WindowsFormsApp1.View
{
    public partial class fBill_Detail : Form
    {
        private int maHD;
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        public fBill_Detail(int s)
        {
            InitializeComponent();
            maHD = s;
            setGUI(maHD);
        }
        void setGUI(int maHD)
        {
            double tong = 0;
            Hoa_don hd = new Hoa_don();
            hd = hdBLL.GetHDByMaHD(maHD);
            txtNV.Text = hd.Tai_khoan.Nhan_vien.Ten_NV.ToString();
            txtMa.Text = hd.Ma_HD.ToString();
            if (hd.Khach_hang.Ten_KH == null)
            {
                txtKH.Visible = false;
                txtSDT.Visible = false;
                lblKH.Visible = false;
                lblSDT.Visible = false;
            }
            else
            {
                txtKH.Text = hd.Khach_hang.Ten_KH.ToString();
                txtSDT.Text = hd.Khach_hang.SDT.ToString();
            }
            txtNgay.Text = hd.Ngay_mua.ToString();
            List<Chi_tiet_hoa_don> list = new List<Chi_tiet_hoa_don>();
            list = cthdBLL.GetAllCT(maHD);
            
            foreach (Chi_tiet_hoa_don l in list)
            {
                dgvCTHD.Rows.Add(l.San_pham.Ten_SP.ToString(), l.Kich_thuoc.ToString(), l.Soluong_SP.ToString(),l.Gia.ToString());
                tong += l.Gia * l.Soluong_SP;
            }
            txtTongTien.Text = tong.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fBill f=new fBill();
            f.TopLevel = false;
            f.Show();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show(); 
        }


        private void btInHD_Click(object sender, EventArgs e)
        {
            fBill_PrePrint f = new fBill_PrePrint(maHD);
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
