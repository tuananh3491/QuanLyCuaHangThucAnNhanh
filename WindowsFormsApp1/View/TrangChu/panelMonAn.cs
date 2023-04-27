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
        private static string TenMon;
        private static San_pham sp;
        public panelMonAn(string s)
        {
            InitializeComponent();
            TenMon = s;
            setGUI(TenMon);
        }
        public panelMonAn(San_pham x)
        {
            InitializeComponent();
            sp = x;
            SetGUI(sp);
        }
        
        void setGUI(string s)
        {
            if (s == "Pizza xúc xích")
            {
                pcbMonAn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\pizza xúc xích.jpg");
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = "Pizza xúc xích";
                tbTien.Text = "50.000đ";
            }

            if (s == "Pizza nấm")
            {
                pcbMonAn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\pizzanam.jpg");
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = "Pizza nấm";
                tbTien.Text = "50.000đ";
            }

            if (s == "Hamburger")
            {
                pcbMonAn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\hamburger gà.png");
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = "Hamburger";
                tbTien.Text = "40.000đ";
            }
            if (s == "Xúc xích")
            {
                pcbMonAn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\hotdog.jpg");
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = "Xúc xích";
                tbTien.Text = "20.000đ";
            }
            if (s == "Khoai tây chiên")
            {
                pcbMonAn.BackgroundImage = Image.FromFile(Application.StartupPath + "\\Resources\\khoaitaychien.jpg");
                pcbMonAn.BackgroundImageLayout = ImageLayout.Stretch;
                lbTenMonAn.Text = "Khoai tây chiên";
                tbTien.Text = "20.000đ";
            }

        }

        public void SetGUI(San_pham x)
        {
            if (x != null)
            {
                pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(x.Hinh_anh));
                lbTenMonAn.Text = x.Ten_SP;
                tbTien.Text = x.Don_gia.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelOrder p = new panelOrder();
            ((fTrangChu)Application.OpenForms["fTrangChu"]).flpnOrder.Controls.Add(p);
            
        }
        
    }
}
