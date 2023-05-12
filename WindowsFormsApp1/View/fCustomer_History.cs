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
        private int ma;
        Hoa_donBLL bll;
        Khach_hangBLL khachHangBLL = new Khach_hangBLL();
        public fCustomer_History(int m)
        {
            InitializeComponent();
            ma = m;
            bll = new Hoa_donBLL();
        }
        private void fCustomer_History_Load(object sender, EventArgs e)
        {
            //bll.ShowDGV(dataGridView1, Ma_KH);
            PBL_3Entities cnn = new PBL_3Entities();
            txtName.Text = khachHangBLL.GetKHById(ma).Ten_KH;
            txtPhone.Text = khachHangBLL.GetKHById(ma).SDT;
            dataGridView1.DataSource = cnn.Hoa_don.Where(p => p.Ma_KH == ma).Select(p => new { p.Ma_HD, p.Ma_NV, p.Trang_thai, p.Ngay_mua, p.Tong_tien }).ToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

    }
}
