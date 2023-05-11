﻿using System;
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
    public partial class Bill : Form
    {
        Hoa_donBLL bll;
        Nhan_vienBLL bll1;
        Khach_hangBLL khach_hangBLL;
        Chi_tiet_hoa_donBLL chi_tiet_;
        private Hoa_don hd;
        private List<Chi_tiet_hoa_don> ct;
        public Bill()
        {
            InitializeComponent();
        }
        public Bill(List<Chi_tiet_hoa_don> a)
        {
            InitializeComponent();
            bll = new Hoa_donBLL();
            bll1 = new Nhan_vienBLL();
            khach_hangBLL=new Khach_hangBLL();
            chi_tiet_ = new Chi_tiet_hoa_donBLL();
            ct = a;
            setGUI();
        }
        void setGUI()
        {
            Nhan_vien nv=new Nhan_vien();
            nv = bll1.GetNV(fLogin.maTK);
            tbNhanVien.Text = nv.Ten_NV;
            tbThoiGian.Text = DateTime.Now.ToString();
            Double TongTien=0;
            foreach(Chi_tiet_hoa_don i in ct)
            {
                TongTien += (i.Gia * Convert.ToInt32(i.Soluong_SP));
            }
            tbTongCong.Text = TongTien.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            hd = new Hoa_don 
            {

            }; 
            MessageBox.Show("In thành công");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fTrangChu f = new fTrangChu();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            chi_tiet_.ShowDGV(dataGridView1, ct);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Khach_hang kh = new Khach_hang();
            kh = khach_hangBLL.getKH(tbSDT.Text);
            if (kh == null)
            {
                AddCustomer f=new AddCustomer(tbSDT.Text);
                f.ShowDialog();
            }
            else
            {
                tbKhachHang.Text = kh.Ten_KH;
            }
        }
    }
}
