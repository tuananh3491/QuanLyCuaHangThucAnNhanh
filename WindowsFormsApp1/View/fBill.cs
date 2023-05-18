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
        Hoa_donBLL hdBLL = new Hoa_donBLL();
        public fBill()
        {
            InitializeComponent();
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dg.SelectedRows.Count == 1)
            {
                int maHD = Convert.ToInt32(dg.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(maHD.ToString());
                fBill_Detail f = new fBill_Detail(maHD);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
        }
        public void ShowDGV(DataGridView dg)
        {
           
        }
        private void fBill_Load(object sender, EventArgs e)
        {
            dg.DataSource = null;
            dg.DataSource = hdBLL.GetHD();
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value;
            dg.DataSource = hdBLL.GetHDByDate(date);
        }
    }
}
