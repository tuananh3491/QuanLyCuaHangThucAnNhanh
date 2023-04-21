using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Product
{
    public partial class fProduct_Add : Form
    {
        public fProduct_Add()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thành công");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbDonGia.Text = null;
            tbLoaiSP.Text = null;
            tbTenSP .Text = null;
            cbL.Checked=false; 
            cbM.Checked = false;
            cbS.Checked=false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fProduct f = new fProduct();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}

