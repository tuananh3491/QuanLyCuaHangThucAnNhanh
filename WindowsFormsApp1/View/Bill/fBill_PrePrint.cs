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
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fBill_PrePrint : Form
    {
        private int maHD;
        private int m;
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL cthdBLL = new ChiTietHoaDonBLL();
        public fBill_PrePrint(int ma,int i)
        {
            InitializeComponent();
            maHD = ma;
            Load(maHD);
            m = i;
        }
        public void Load(int ma)
        {
            double tong = 0;
            Hoa_don hd = new Hoa_don();
            hd = hdBLL.GetHDByMaHD(maHD);
            txtNV.Text = hd.Tai_khoan.Nhan_vien.Ten_NV.ToString();
            txtMa.Text = hd.Ma_HD.ToString();
            if(hd.Khach_hang.Ten_KH == null)
            {
                txtKH.Visible = false;
                txtSDT.Visible = false;
                lblKH.Visible = false;
                lblSDT.Visible = false;
            }
            else {
                txtKH.Text = hd.Khach_hang.Ten_KH.ToString();
                txtSDT.Text = hd.Khach_hang.SDT.ToString();
            }
            txtNgay.Text = hd.Ngay_mua.ToString();
            List<Chi_tiet_hoa_don> list = new List<Chi_tiet_hoa_don>();
            list = cthdBLL.GetAllCT(maHD);
            txtThanhTien.Text = hd.Tong_tien.ToString();
            txtThanhTien.Text = string.Format("{0:#,##0} đ", hd.Tong_tien).Replace(",", ".");
            foreach (Chi_tiet_hoa_don l in list)
            {
                dgvChitietHD.Rows.Add(l.San_pham.Ten_SP.ToString(), l.Kich_thuoc.ToString(), l.Soluong_SP.ToString(), l.Gia.ToString("#,##0 đ").Replace(",", "."));
                tong += l.Soluong_SP * l.Gia;
            }
            txtTongTien.Text = string.Format("{0:#,##0} đ", tong).Replace(",", ".");
            txtGiamGia.Text = string.Format("{0:#,##0} đ", (tong - hd.Tong_tien)).Replace(",", ".");

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (m == 1) //trở về form Trang chủ
            {
                fTrangChu f=new fTrangChu();
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
            else //trở về form hóa đơn
            {
                fBill f = new fBill();
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
        }

    }
}
