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
    public partial class fStaff : Form
    {
        Nhan_vienBLL bll;
        public fStaff()
        {
            InitializeComponent();
            bll = new Nhan_vienBLL();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            fStaff_Salary f = new fStaff_Salary();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            bll.ShowDGV(dataGridView1);
        }
    }
}
