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
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            fBill_Detail f=new fBill_Detail();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            Hoa_donBLL bll = new Hoa_donBLL();
            dataGridView1.DataSource = bll.GetAllHD();
            dataGridView1.Columns["Chi_tiet_hoa_don"].Visible = false;
            dataGridView1.Columns["Khach_hang"].Visible = false;
            dataGridView1.Columns["Tai_khoan"].Visible = false;
        }
    }
}
