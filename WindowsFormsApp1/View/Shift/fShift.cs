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
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if(Const.taiKhoan.Loai_TK) btnTaoCa.Visible = false;
        }
        private void btnTaoCa_Click(object sender, EventArgs e)
        {
            fShift_Create f = new fShift_Create();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
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
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
        }

        private void datagridview1_RowHeaderMouseClicked(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1) btnDetail.Enabled = true;
            else btnDetail.Enabled = false;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = clvBLL.GetCLV(Convert.ToInt32(txtSearch.Text));
            }
        }
    }
}
