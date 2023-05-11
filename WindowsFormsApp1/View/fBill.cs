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
        Hoa_donBLL bll;
        public fBill()
        {
            InitializeComponent();
            bll = new Hoa_donBLL();
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int maHD = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(maHD.ToString());
                fBill_Detail f = new fBill_Detail(maHD);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
        }
        
        private void fBill_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            bll.ShowDGV(dataGridView1);
        }

    }
}
