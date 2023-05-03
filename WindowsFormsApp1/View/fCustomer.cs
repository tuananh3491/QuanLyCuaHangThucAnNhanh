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
    public partial class fCustomer : Form
    {
        public fCustomer()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 1)
            {
                int m = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                fCustomer_Update f = new fCustomer_Update(m);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
            else MessageBox.Show("Lỗi","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void btnViewHtr_Click(object sender, EventArgs e)
        {
            //if(dataGridView.SelectedRows.Count == 1)
            //{
            //    fCustomer_History f = new fCustomer_History(int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            //    f.TopLevel = false;
            //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            //    f.Show();
            //}
        }
        private void fCustomer_Load(object sender, EventArgs e)
        {
            KhachHang khBLL = new KhachHang();
            khBLL.ShowDGV(dataGridView);    
        }

       
    }
 }

