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
    public partial class fShift_Detail : Form
    {
        Phan_congBLL bll; int x;
        public fShift_Detail()
        {
            InitializeComponent();
            bll = new Phan_congBLL();
        }
        public fShift_Detail(int x)
        {
            InitializeComponent();
            bll = new Phan_congBLL();
            this.x = x;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fShift f = new fShift();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fShift_Detail_Load(object sender, EventArgs e)
        {
            bll.ShowDGV(dataGridView1, x);
        }
    }
}
