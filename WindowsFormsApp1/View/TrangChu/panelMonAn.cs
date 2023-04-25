using FontAwesome.Sharp;
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
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class panelMonAn : UserControl
    {
        private static San_pham MonAn;
        public panelMonAn(San_pham s)
        {
            InitializeComponent();
            MonAn = s;
            setGUI(MonAn);
        }
        void setGUI(San_pham sp)
        {          
                pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(sp.Hinh_anh));
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = sp.Ten_SP;
                tbTien.Text = sp.Don_gia.ToString()+"đ"; 
        }

        private void btnAdd_Click(object sender, EventArgs e)
            {
            if (cbbKichThuoc.Text == null)
            {
                MessageBox.Show("vui lòng chọn kích cỡ!");
                return;
            }
            else
            {
                panelOrder p = new panelOrder(MonAn);
                ((fTrangChu)Application.OpenForms["fTrangChu"]).flpnOrder.Controls.Add(p);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKichThuoc.Text == "M")
            {
                tbTien.Text= (MonAn.Don_gia*1.1).ToString() + "đ";
            }
            else if (cbbKichThuoc.Text == "L")
            {
                tbTien.Text = (MonAn.Don_gia*1.3).ToString() + "đ";
            }
            else
            {
                tbTien.Text = MonAn.Don_gia.ToString() + "đ";
            }
        }
    }
    
}
