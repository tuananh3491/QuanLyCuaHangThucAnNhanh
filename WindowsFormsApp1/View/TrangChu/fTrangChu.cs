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

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class fTrangChu : Form
    {
        Hoa_don hoa_Don;
        List<Chi_tiet_hoa_don> ct;
        San_phamBLL bll = new San_phamBLL();
        double tongtien = 0;
        public fTrangChu()
        {
            InitializeComponent();
            
            ct =  new List<Chi_tiet_hoa_don>();
        }
        
        private void AddList(Chi_tiet_hoa_don t)
        {
            Edit("add", t);
            TinhTongTien();
            flpnOrder.Controls.Clear();
            foreach (var i in ct)
            {
                panelOrder pn = new panelOrder(bll.FindSp(i.Ma_SP), i);
                flpnOrder.Controls.Add(pn);
                pn.callback += new panelOrder.update(this.UpdateList);
            }
        }

        private void UpdateList(Chi_tiet_hoa_don t)
        {
            Edit("update", t);
            TinhTongTien();
        }

        private void Edit(string st, Chi_tiet_hoa_don t) //thêm sửa xóa đều ở đây
        {
            tongtien = 0;
            var s = ct.FirstOrDefault(x => x.Ma_SP == t.Ma_SP && x.Kich_thuoc == t.Kich_thuoc);
            if (s == null) { ct.Add(t); } //thêm t
            else //sửa s
            {
                if (st == "update") 
                { 
                    s.Soluong_SP = t.Soluong_SP;
                    s.Gia = t.Gia;
                }
                if (st == "add")
                {
                    s.Soluong_SP += 1;
                    s.Gia += t.Gia;
                }
            }
            var r = ct.SingleOrDefault(x => x.Soluong_SP == 0); //xóa các phần tử có điều kiện trên
            ct.Remove(r);
        }

        private void TinhTongTien()
        {
            foreach (Chi_tiet_hoa_don i in ct)
            {
                tongtien += Convert.ToDouble(i.Gia);
            }
            tbTongTien.Text = tongtien.ToString();
        }
        private void btnPizza_Click_1(object sender, EventArgs e)
        {
            openPanel(btnPizza.Text);
        }

        private void btnGa_Click(object sender, EventArgs e)
        {
            openPanel(btnGa.Text);
        }
        private void btnKhac_Click(object sender, EventArgs e)
        {
            openPanel(btnKhac.Text);
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            openPanel(btnBurger.Text);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {   
            flpnOrder.Controls.Clear();
            ct.Clear();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            Hoa_don a = new Hoa_don
            {
                Ma_NV = Const.taiKhoan.Ma_TK,
                Ngay_mua = DateTime.Now,
                Tong_tien = double.Parse(tbTongTien.Text)
            };
            Bill f = new Bill(ct, a);
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
            this.Dispose();
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {
            
        }
        private void openPanel(string s)
        {
            flpnThucDon.Controls.Clear();
            San_phamBLL san_PhamBLL = new San_phamBLL();
            List<San_pham> l = new List<San_pham>();
            l = san_PhamBLL.GetSPCategory(s);
            foreach (San_pham i in l)
            {
                panelMonAn a = new panelMonAn(i);
                flpnThucDon.Controls.Add(a);
                a.Add += new panelMonAn.Edit(this.AddList);
                a.Update += new panelMonAn.Edit(this.UpdateList);
            }
        }
    }
}
