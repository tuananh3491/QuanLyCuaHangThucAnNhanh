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
    public partial class fCustomer_History : Form
    {
        private int maKH;
        Khach_hangBLL khachHangBLL = new Khach_hangBLL();
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        public fCustomer_History(int m)
        {
            InitializeComponent();
            maKH = m;
        }
        private void fCustomer_History_Load(object sender, EventArgs e)
        {
            txtName.Text = khachHangBLL.GetKHById(maKH).Ten_KH;
            txtPhone.Text = khachHangBLL.GetKHById(maKH).SDT;
            List<Hoa_don> listHD = hdBLL.GetHDsByMaKH(maKH);
            foreach(Hoa_don hd in listHD)
            {
                dataGridView1.Rows.Add(hd.Ma_HD, hd.Tai_khoan.Nhan_vien.Ten_NV, hd.Ngay_mua, hd.Tong_tien.ToString("#,##0 đ").Replace(",", "."), hd.Trang_thai == true ? "Đã thanh toán" : "Chưa thanh toán");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

    }
}
