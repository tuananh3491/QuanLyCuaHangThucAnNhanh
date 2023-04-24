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
    public partial class fShift : Form
    {
        Ca_lam_viecBLL bll;
        public fShift()
        {
            InitializeComponent();
            bll = new Ca_lam_viecBLL();
        }

        private void btnTaoCa_Click(object sender, EventArgs e)
        {
            fShift_Create f = new fShift_Create();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fShift_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            bll.ShowDGV(dataGridView1);
        }
    }
}
