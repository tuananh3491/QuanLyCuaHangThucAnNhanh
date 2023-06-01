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
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class panelOrder : UserControl
    {
        San_pham san_Pham;
        public int Soluongsp;
        public string kickthuoc
        {
            get
            {
                return lbLoai.Text;
            }
        }
        public double gia;
        public string KichCo;

        public static Hoa_don hoa_Don;
        public delegate void update(Chi_tiet_hoa_don chitiet);
        public delegate void clear();
        public update callback;
        public Chi_tiet_hoa_don a;

        public panelOrder(San_pham s, Chi_tiet_hoa_don ct)
        {
            InitializeComponent();
            san_Pham = s;
            KichCo = ct.Kich_thuoc;
            Soluongsp = Convert.ToInt32(ct.Soluong_SP);

            gia = ct.Gia;
            setGUI();
        }
        public void setGUI()
        {
            pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(san_Pham.Hinh_anh));
            lbTenMonAn.Text = san_Pham.Ten_SP;
            lbLoai.Text = KichCo;
            txtTien.Text = string.Format("{0:#,##0} đ", gia).Replace(",", ".");
            tbSoLuong.Text = Soluongsp.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            Edit("sub");

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Edit("add");
        }

        public void Edit(string s)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            if (s == "add") count++;
            if (s == "sub") count--;
            setPanel(count);
            tbSoLuong.Text = count.ToString();
            if (count == 0) this.Dispose();
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
                Gia = gia
            };
            callback(chi_Tiet_Hoa_Don);
        }
    }
}
