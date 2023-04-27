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

namespace WindowsFormsApp1.View
{
    public partial class fCustomer_History : Form
    {
        private int Ma_KH;
        Hoa_donBLL bll;
        public fCustomer_History()
        {
            InitializeComponent();
        }
        public fCustomer_History(int Ma_kh)
        {
            InitializeComponent();
            bll = new Hoa_donBLL();
            Ma_KH = Ma_kh;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fCustomer_History_Load(object sender, EventArgs e)
        {
            bll.ShowDGV(dataGridView1, Ma_KH);
        }
    }
}
