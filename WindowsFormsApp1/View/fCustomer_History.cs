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
            //bll.ShowDGV(dataGridView1, Ma_KH);
            PBL_3Entities cnn = new PBL_3Entities();
            txtName.Text = khachHangBLL.GetKHById(maKH).Ten_KH;
            txtPhone.Text = khachHangBLL.GetKHById(maKH).SDT;
            dataGridView1.DataSource = hdBLL.GetHDsByMaKH(maKH);
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
