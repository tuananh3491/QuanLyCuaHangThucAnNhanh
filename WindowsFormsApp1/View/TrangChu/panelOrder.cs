using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class panelOrder : UserControl
    {
        private static San_pham san_Pham;
        public panelOrder(San_pham s)
        {
            InitializeComponent();
            san_Pham = s;
            setGUI();

        }
        public void setGUI()
        {
            pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(san_Pham.Hinh_anh));
            lbTenMonAn.Text = san_Pham.Ten_SP;
            tbTien.Text = san_Pham.Don_gia.ToString() + "đ";
            
        }





        private void btnSub_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            if (count == 0) return;
            else count--;
            tbSoLuong.Text = count.ToString();
            tbTien.Text = san_Pham.Don_gia.ToString()+"đ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            count++;
            tbSoLuong.Text = count.ToString();
            tbTien.Text = san_Pham.Don_gia.ToString()+"đ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
