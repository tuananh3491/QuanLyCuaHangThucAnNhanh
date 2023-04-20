using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fBill : Form
    {
        public fBill()
        {
            InitializeComponent();
        }


        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            fMainform tc = new fMainform();
            tc.openChildForm(new fBill_Detail() ,tc.pnForm);
            
        }
    }
}
