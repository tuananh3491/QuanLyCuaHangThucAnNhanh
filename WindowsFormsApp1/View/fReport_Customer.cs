using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class fReport_Customer : Form
    {
        public fReport_Customer()
        {
            InitializeComponent();
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            fReport_CustomerChart f = new fReport_CustomerChart();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
