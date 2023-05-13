using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fBill_PrePrint : Form
    {
        private int maHD;
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        public fBill_PrePrint(int ma)
        {
            InitializeComponent();
            maHD = ma;
            Load(maHD);
        }
        public void Load(int ma)
        {
            //double tong = 0;
            //Hoa_don hd = new Hoa_don();
            //hd = hdBLL.GetHDByMaHD(maHD);
            //txtNV.Text = hd.Tai_khoan.Nhan_vien.Ten_NV.ToString();
            //txtMa.Text = hd.Ma_HD.ToString();
            //txtKH.Text = hd.Khach_hang.Ten_KH.ToString();
            //txtSDT.Text = hd.Khach_hang.SDT.ToString();
            //txtNgay.Text = hd.Ngay_mua.ToString();
            //List<Chi_tiet_hoa_don> list = new List<Chi_tiet_hoa_don>();
            //list = cthdBLL.GetAllCT(maHD);
            //txtThanhTien.Text = hd.Tong_tien.ToString();
            //foreach (Chi_tiet_hoa_don l in list)
            //{
            //    dgvChitietHD.Rows.Add(l.San_pham.Ten_SP.ToString(), l.Kich_thuoc.ToString(), l.Soluong_SP.ToString(), l.Gia.ToString());
            //    tong += l.Soluong_SP * l.Gia;
            //}
            //txtTongTien.Text = tong.ToString();
            //txtGiamGia.Text = (tong - hd.Tong_tien).ToString();
            double tong = 0;
            Hoa_don hd = new Hoa_don();
            hd = hdBLL.GetHDByMaHD(maHD);
            txtNV.Text = hd.Tai_khoan.Nhan_vien.Ten_NV.ToString();
            txtMa.Text = hd.Ma_HD.ToString();
            txtKH.Text = hd.Khach_hang.Ten_KH.ToString();
            txtSDT.Text = hd.Khach_hang.SDT.ToString();
            txtNgay.Text = hd.Ngay_mua.ToString();
            List<Chi_tiet_hoa_don> list = new List<Chi_tiet_hoa_don>();
            list = cthdBLL.GetAllCT(maHD);
            txtThanhTien.Text = hd.Tong_tien.ToString();
            foreach (Chi_tiet_hoa_don l in list)
            {
                dgvChitietHD.Rows.Add(l.San_pham.Ten_SP.ToString(), l.Kich_thuoc.ToString(), l.Soluong_SP.ToString(), l.Gia.ToString());
                tong += l.Soluong_SP * l.Gia;
            }
            txtTongTien.Text = tong.ToString();
            txtGiamGia.Text = (tong - hd.Tong_tien).ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

    }
}
