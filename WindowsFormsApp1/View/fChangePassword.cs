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
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class fChangePassword : Form
    {
        private int maTK = Const.taiKhoan.Ma_TK;
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            
        }
    }
}
