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
        private San_pham MonAn;
        public delegate void Edit(Chi_tiet_hoa_don t);
        public Edit Add;
        public Edit Update;
        public double gia;
        double gia_M;
        double gia_L;
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
            cbbSize.SelectedIndex = 0;
            lbTenMonAn.Text = sp.Ten_SP;
            tbTien.Text = sp.Don_gia.ToString() + "đ";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbbSize.Text == "")
            {
                MessageBox.Show("vui lòng chọn kích cỡ!");
                return;
            }
            else
            {
                MonAn.Don_gia = gia;
                Chi_tiet_hoa_don ct = new Chi_tiet_hoa_don
                {
                    Ma_SP = MonAn.Ma_SP,
                    Kich_thuoc = cbbSize.Text,
                    Soluong_SP = 1,
                    Gia = (cbbSize.Text == "S") ? gia : (cbbSize.Text == "M") ? gia_M : gia_L,
                };
                Add(ct);
                panelOrder p = new panelOrder(MonAn, ct);
                p.callback += new panelOrder.update(this.Update);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gia = MonAn.Don_gia;
            gia_M = gia * 1.2;
            gia_L = gia * 1.4;


            if (cbbSize.Text == "M")
            {
                tbTien.Text = gia_M.ToString() + "đ";
                gia = gia_M;

            }
            else if (cbbSize.Text == "L")
            {
                tbTien.Text = gia_L.ToString() + "đ";
                gia = gia_L;
            }
            else
            {
                tbTien.Text = gia.ToString() + "đ";
            }
        }

    }
}
