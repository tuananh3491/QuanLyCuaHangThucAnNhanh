using System;
using System.IO;
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
using WindowsFormsApp1.View.Product;
using Guna;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1.View
{
    public partial class fProduct : Form
    {
        San_phamBLL sanPhamBLL = new San_phamBLL();
        Ma_loaiBLL maLoaiBLL = new Ma_loaiBLL();    
        public fProduct()
        {
            InitializeComponent();
            PhanQuyen();
            SetCBB();
        }
        public void PhanQuyen()
        {
            if (Const.taiKhoan.Loai_TK)
            {
                btnAddCategory.Visible = false;
                btnAddPro.Visible = false;
            }
        }
        public void SetCBB()
        {
            List<Ma_loai> list = maLoaiBLL.GetAllML();
            foreach (Ma_loai item in list)
            {
                cbbLoai.Items.Add(item.Ten);
            }
        }
        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maLoai;
            flpnMonAn.Controls.Clear();
            maLoai = maLoaiBLL.GetIdCategory(((ComboBox)sender).Text);
            ShowMonAn(maLoai);
        }
        private void btnAddCate_Click(object sender, EventArgs e)
        {
            flpnMonAn.Controls.Clear();
            fAddCategory f = new fAddCategory();
            f.TopLevel = false;
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Clear();
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Add(f);
            f.Show();
         
        }

        private void btn_Click(object sender, EventArgs e)
        {
            cbbLoai.SelectedItem = null;
            int maLoai;
            flpnMonAn.Controls.Clear();
            maLoai = maLoaiBLL.GetIdCategory(((Guna2Button)sender).Text);
            ShowMonAn(maLoai);
        }
        public void ShowMonAn(int maLoai)
        {
            List<San_pham> listSP = sanPhamBLL.GetProOfType(maLoai);

            foreach (San_pham sp in listSP)
            {
                pnProduct p = new pnProduct(sp.Ma_SP);
                flpnMonAn.Controls.Add(p);
                p.add += new pnProduct.AddPanel(ShowChinhSua);
            }
        }

        public void ShowChinhSua(UserControl p)
        {
            pnChinhSua.Controls.Clear();
            pnChinhSua.Controls.Add(p);
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            fProduct_Add f = new fProduct_Add();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
            SetCBB();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flpnMonAn.Controls.Clear();
                string ten = txtSearch.Text;
               

                foreach (San_pham sp in sanPhamBLL.GetSPByTen(ten))
                {
                    pnProduct p = new pnProduct(sp.Ma_SP);
                    flpnMonAn.Controls.Add(p);
                }
            }
        }
    }
}
