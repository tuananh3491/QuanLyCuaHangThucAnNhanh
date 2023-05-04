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
        private string KichCo;
        
        public static Hoa_don hoa_Don;
        public delegate void update(Chi_tiet_hoa_don chitiet);
        public delegate void clear();
        public update callback;
        public Chi_tiet_hoa_don a;
        public panelOrder(San_pham s,string kich_co)
        {
            InitializeComponent();
            san_Pham = s;
            KichCo = kich_co;
            setGUI();
        }
        public void setGUI()
        {
            pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(san_Pham.Hinh_anh));
            lbTenMonAn.Text = san_Pham.Ten_SP;
            tbTien.Text = san_Pham.Don_gia.ToString() + "đ";
            lbLoai.Text = KichCo;
        }
        
        private void btnSub_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            if (count == 0) return;
            else count--;
            setPanel(count);
            tbSoLuong.Text = count.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            count++;

            setPanel(count);
            tbSoLuong.Text = count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            setPanel(0);   
            this.Dispose();
        }
        private void setPanel(int x)
        {
            Chi_tiet_hoa_don chi_Tiet_Hoa_Don = new Chi_tiet_hoa_don
            {
                Ma_SP = san_Pham.Ma_SP,
                Kich_thuoc = KichCo,
                Soluong_SP = x,
                Gia = san_Pham.Don_gia * x
            };
            callback(chi_Tiet_Hoa_Don);
        }
    }
}
