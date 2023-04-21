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
        public fStaff()
        {
            InitializeComponent();
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
            Nhan_vienBLL bll = new Nhan_vienBLL();
            dataGridView1.DataSource = bll.GetAllNV();
            
            dataGridView1.Columns["Tai_khoan"].Visible = false;
        }
    }
}
