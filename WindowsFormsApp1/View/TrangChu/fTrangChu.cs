using Guna.UI2.WinForms;
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
        //List<Chi_tiet_hoa_don> listCTHD = new List<Chi_tiet_hoa_don>();
        //San_phamBLL bll = new San_phamBLL();
        //double tongtien = 0;
        //public fTrangChu()
        //{
        //    InitializeComponent();
        //}

        ////public void Tao_Hoa_Don()
        ////{
        ////    hoa_Don = new Hoa_don(Convert.ToDouble(tbTongTien.Text));
        ////}
        //private void AddList(Chi_tiet_hoa_don t)
        //{
        //    Edit("add", t);
        //    TinhTongTien();
        //    flpnOrder.Controls.Clear();
        //    foreach (var i in listCTHD)
        //    {
        //        panelOrder pn = new panelOrder(bll.GetPro(i.Ma_SP), i);
        //        flpnOrder.Controls.Add(pn);
        //        pn.callback += new panelOrder.update(this.UpdateList);
        //    }
        //}

        //private void UpdateList(Chi_tiet_hoa_don t)
        //{
        //    Edit("update", t);
        //    TinhTongTien();
        //}

        //private void Edit(string st, Chi_tiet_hoa_don t) //thêm sửa xóa đều ở đây
        //{
        //    tongtien = 0;
        //    var s = listCTHD.FirstOrDefault(x => x.Ma_SP == t.Ma_SP && x.Kich_thuoc == t.Kich_thuoc);
        //    if (s == null) { listCTHD.Add(t); } //thêm t
        //    else //sửa s
        //    {
        //        if (st == "update")
        //        {
        //            s.Soluong_SP = t.Soluong_SP;
        //            s.Gia = t.Gia;
        //        }
        //        if (st == "add")
        //        {
        //            s.Soluong_SP += 1;
        //            s.Gia += t.Gia;
        //        }
        //    }
        //    var r = listCTHD.SingleOrDefault(x => x.Soluong_SP == 0); //xóa các phần tử có điều kiện trên
        //    listCTHD.Remove(r);
        //}

        //private void TinhTongTien()
        //{
        //    foreach (Chi_tiet_hoa_don i in listCTHD)
        //    {
        //        tongtien += Convert.ToDouble(i.Gia);
        //    }
        //    tbTongTien.Text = tongtien.ToString();
        //}
        //private void btn_Click(object sender, EventArgs e)
        //{
        //    openPanel(((Guna2Button)sender).Text);
        //}
        

        //private void btnHuy_Click(object sender, EventArgs e)
        //{   
        //    flpnOrder.Controls.Clear();
        //    Button p=new Button();
        //    flpnOrder.Controls.Add(p);
        //}

        //private void btnTaoDon_Click(object sender, EventArgs e)
        //{
        //    Bill f = new Bill(listCTHD, Convert.ToDouble(tbTongTien.Text));
        //    f.TopLevel = false;
        //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
        //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
        //    f.Show();
        //    this.Dispose();
        //}
        //private void fTrangChu_Load(object sender, EventArgs e)
        //{
            
        //}
        //private void openPanel(string s)
        //{
        //    flpnThucDon.Controls.Clear();
        //    San_phamBLL san_PhamBLL = new San_phamBLL();
        //    List<San_pham> l = new List<San_pham>();
        //    l = san_PhamBLL.GetSPCategory(s);
        //    foreach (San_pham i in l)
        //    {
        //        panelMonAn a = new panelMonAn(i);
        //        flpnThucDon.Controls.Add(a);
        //        a.Add += new panelMonAn.Edit(this.AddList);
        //        a.Update += new panelMonAn.Edit(this.UpdateList);
        //    }
        //}
        //===========================================================================
        //==============================================================================================
        List<Chi_tiet_hoa_don> listCTHD = new List<Chi_tiet_hoa_don>();

        San_phamBLL spBLL = new San_phamBLL();
        double tongtien = 0;
        public fTrangChu()
        {
            InitializeComponent();
        }

        //public void Tao_Hoa_Don()
        //{
        //    hoa_Don = new Hoa_don(Convert.ToDouble(tbTongTien.Text));
        //}
        private void AddList(Chi_tiet_hoa_don t)
        {
            Edit("add", t);
            TinhTongTien();
            flpnOrder.Controls.Clear();
            foreach (var i in listCTHD)
            {
                panelOrder pn = new panelOrder(spBLL.GetPro(i.Ma_SP), i);
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
            var s = listCTHD.FirstOrDefault(x => x.Ma_SP == t.Ma_SP && x.Kich_thuoc == t.Kich_thuoc);
            if (s == null) { listCTHD.Add(t); } //thêm t
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
                    //s.Gia += t.Gia;
                }
            }
            var r = listCTHD.SingleOrDefault(x => x.Soluong_SP == 0); //xóa các phần tử có điều kiện trên
            listCTHD.Remove(r);
        }

        private void TinhTongTien()
        {
            foreach (Chi_tiet_hoa_don i in listCTHD)
            {
                tongtien += Convert.ToDouble(i.Gia*i.Soluong_SP);
            }
            tbTongTien.Text = tongtien.ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
                openPanel(((Guna2Button)sender).Text);
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            flpnOrder.Controls.Clear();
            Button p = new Button();
            flpnOrder.Controls.Add(p);
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            Bill f = new Bill(listCTHD, Convert.ToDouble(tbTongTien.Text));
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
            this.Dispose();
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {

        }
        private void openPanel(string loai)
        {
            flpnThucDon.Controls.Clear();
            List<San_pham> listSP = spBLL.GetSPCategory(loai);
            foreach (San_pham sp in listSP)
            {
                if (sp.Trang_thai == true)
                {
                    panelMonAn pnMon = new panelMonAn(sp);
                    flpnThucDon.Controls.Add(pnMon);
                    pnMon.Add += new panelMonAn.Edit(this.AddList);
                    pnMon.Update += new panelMonAn.Edit(this.UpdateList);
                }
            }
        }
    }
}
