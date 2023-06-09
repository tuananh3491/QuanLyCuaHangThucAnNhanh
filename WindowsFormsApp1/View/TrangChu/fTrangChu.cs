﻿using Guna.UI2.WinForms;
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
        List<Chi_tiet_hoa_don> listCTHD = new List<Chi_tiet_hoa_don>();
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
            tongtien = 0;
            var s = listCTHD.FirstOrDefault(x => x.Ma_SP == t.Ma_SP && x.Kich_thuoc == t.Kich_thuoc);
            if (s == null) { listCTHD.Add(t); }
            else
            {
                s.Soluong_SP = t.Soluong_SP;
                s.Gia = t.Gia;
            }
            var r = listCTHD.SingleOrDefault(x => x.Soluong_SP == 0);
            listCTHD.Remove(r);
            TinhTongTien();
        }
        private void TinhTongTien()
        {
            foreach (Chi_tiet_hoa_don i in listCTHD)
            {
                tongtien += Convert.ToDouble(i.Gia);
            }
            tbTongTien.Text = tongtien.ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            openPanel(((Guna2Button)sender).Text);
        }
        //private void btnPizza_Click_1(object sender, EventArgs e)
        //{
        //    openPanel(btnPizza.Text);
        //}

        //private void btnGa_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnGa.Text);
        //}
        //private void btnKhac_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnKhac.Text);
        //}

        //private void btnBurger_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnBurger.Text);
        //}

        private void btnHuy_Click(object sender, EventArgs e)
        {   
            flpnOrder.Controls.Clear();
            Button p=new Button();
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
                a.callbackMonAn += new panelMonAn.Add(this.AddList);
            }
        }

        //private void btnKem_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnKem.Text);
        //}

        //private void btnCombo_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnCombo.Text);
        //}

        //private void btnNuoc_Click(object sender, EventArgs e)
        //{
        //    openPanel(btnNuoc.Text);
        //}
    }
}
