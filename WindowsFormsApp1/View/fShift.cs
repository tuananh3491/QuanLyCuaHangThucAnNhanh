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
        Ca_lam_viecBLL clvBLL;
        public fShift()
        {
            InitializeComponent();
            clvBLL = new Ca_lam_viecBLL();
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
            clvBLL.ShowDGV(dataGridView1);
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                fShift_Detail f = new fShift_Detail(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
        }

        private void datagridview1_RowHeaderMouseClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) btnDetail.Enabled = true;
            else btnDetail.Enabled = false;
        }
    }
}
