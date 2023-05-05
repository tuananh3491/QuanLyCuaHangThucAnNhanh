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

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class AddCustomer : Form
    {
        Khack_hang_DAL dal;
        public AddCustomer(string sdt)
        {
            InitializeComponent();
            dal = new Khack_hang_DAL();
            tbSdt.Text = sdt;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Khach_hang kh=new Khach_hang();
            kh.Ten_KH = tbTenKhachHang.Text;
            kh.SDT = tbSdt.Text;
            dal.AddKH(kh);
            MessageBox.Show("Thêm thành công");
            this.Dispose();
        }
    }
}
