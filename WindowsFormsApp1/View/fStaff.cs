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
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        public fStaff()
        {
            InitializeComponent();
            setGUI();
        }
        public void setGUI()
        {
            dataGridView1.DataSource = null;
            nvBLL.ShowDGV(dataGridView1);
        }

        private void fStaff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            nvBLL.ShowDGV(dataGridView1);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                fStaff_View f = new fStaff_View(nvBLL.GetNVByMa(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
                this.Dispose();
            }
        }

    }
}
