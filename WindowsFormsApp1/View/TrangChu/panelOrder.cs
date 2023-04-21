using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class panelOrder : UserControl
    {
        public panelOrder()
        {
            InitializeComponent();
        }





        private void btnSub_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            if (count == 0) return;
            else count--;
            tbSoLuong.Text = count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            count++;
            tbSoLuong.Text = count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
