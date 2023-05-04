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
        public static List<Chi_tiet_hoa_don> listChiTiet=new List<Chi_tiet_hoa_don>();
        public static Hoa_don hoa_Don;
        public delegate void update(Chi_tiet_hoa_don chitiet);
        public update callback;
        public panelOrder(San_pham s,string kich_co)
        {
            InitializeComponent();
            san_Pham = s;
            KichCo = kich_co;
            setGUI();
            addChiTietHoaDon(san_Pham,KichCo);
        }
        public void setGUI()
        {
            pcbMonAn.BackgroundImage = Image.FromStream(new MemoryStream(san_Pham.Hinh_anh));
            lbTenMonAn.Text = san_Pham.Ten_SP;
            tbTien.Text = san_Pham.Don_gia.ToString() + "đ";
            lbLoai.Text = KichCo;
        }
        public void addChiTietHoaDon(San_pham s,string kich_co)
        {
            /*Chi_tiet_hoa_don chi_Tiet_Hoa_Don =new Chi_tiet_hoa_don
            {
                Ma_SP = s.Ma_SP,
                Kich_thuoc = kich_co,
                Soluong_SP = Convert.ToInt32(tbSoLuong.Text),
                Gia = s.Don_gia
            };*/
            /*chi_Tiet_Hoa_Don.Ma_SP = s.Ma_SP;
            chi_Tiet_Hoa_Don.Kich_thuoc = kich_co;
            chi_Tiet_Hoa_Don.Soluong_SP = Convert.ToInt32(tbSoLuong.Text);
            chi_Tiet_Hoa_Don.Gia = s.Don_gia;
            if (CheckSanPham(chi_Tiet_Hoa_Don))
            {
                listChiTiet.Add(chi_Tiet_Hoa_Don);
            }*/

        }
        public bool CheckSanPham(Chi_tiet_hoa_don chi_Tiet)
        {
            /*if (listChiTiet == null) return true;
            foreach(Chi_tiet_hoa_don i in listChiTiet)
            {
                if(chi_Tiet.Ma_SP==i.Ma_SP&&chi_Tiet.Kich_thuoc==i.Kich_thuoc)
                {
                    MessageBox.Show("Trùng sàn phẩm trong order");
                    this.Visible = false;
                    return false;
                }
            }
            */return true;
        }



        private void btnSub_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            if (count == 0) return;
            else count--;
            foreach (Chi_tiet_hoa_don i in listChiTiet)
            {
                if (i.Kich_thuoc == KichCo && i.Ma_SP == san_Pham.Ma_SP)
                {
                    i.Soluong_SP -= 1;
                }
            }
            tbSoLuong.Text = count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int count;
            count = Convert.ToInt32(tbSoLuong.Text);
            count++;
            /*foreach (Chi_tiet_hoa_don i in listChiTiet)
            {
                if (i.Kich_thuoc == KichCo && i.Ma_SP == san_Pham.Ma_SP)
                {
                    i.Soluong_SP += 1;
                }
            cái ni l
            }*/
            Chi_tiet_hoa_don chi_Tiet_Hoa_Don = new Chi_tiet_hoa_don
            {
                Ma_SP = san_Pham.Ma_SP,
                Kich_thuoc = KichCo,
                Soluong_SP = count,
                Gia = san_Pham.Don_gia * count
            };
            callback(chi_Tiet_Hoa_Don);
            tbSoLuong.Text = count.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach(Chi_tiet_hoa_don i in listChiTiet)
            {
                if(i.Kich_thuoc==KichCo&&i.Ma_SP==san_Pham.Ma_SP)
                {
                    listChiTiet.Remove(i);
                }
            }
            this.Dispose();
        }
    }
}
