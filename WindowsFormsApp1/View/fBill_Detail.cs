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

namespace WindowsFormsApp1.View
{
    public partial class fBill_Detail : Form
    {
        private int MaHD;
        private Hoa_donBLL hoa_DonBLL;
        public fBill_Detail(int s)
        {
            InitializeComponent();
            hoa_DonBLL = new Hoa_donBLL();
            MaHD = s;
            setGUI(MaHD);
        }
        public fBill_Detail()
        {
            InitializeComponent();
        }
        void setGUI(int i)
        {        
            Hoa_don hd = new Hoa_don();
            hd = hoa_DonBLL.getHDBll(i);
            tbNhanVien.Text = hd.Tai_khoan.Nhan_vien.Ten_NV.ToString();
            tbMaHD.Text = hd.Ma_HD.ToString();
            tbKhachHang.Text = hd.Khach_hang.Ten_KH.ToString();
            tbSDT.Text = hd.Khach_hang.SDT.ToString();
            tbNgayMua.Text=hd.Ngay_mua.ToString();
            List<Chi_tiet_hoa_don> list = new List<Chi_tiet_hoa_don>();
            list = hoa_DonBLL.getALLCT(hd.Ma_HD);
            tbTongTien.Text=hd.Tong_tien.ToString()+"đ";
            foreach (Chi_tiet_hoa_don l in list)
            {
                dataGridView1.Rows.Add(l.San_pham.Ten_SP.ToString(), l.Kich_thuoc.ToString(), l.Soluong_SP.ToString(),l.Gia.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fBill f=new fBill();
            f.TopLevel = false;
            f.Show();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show(); 
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            //fBill_Print f=new fBill_Print();
            //f.TopLevel = false;
            //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            //f.Show(); 
        }
    }
}
