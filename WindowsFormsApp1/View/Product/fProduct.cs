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
        }
        public void PhanQuyen()
        {
            if ((bool)Const.taiKhoan.Loai_TK)
            {
                btnAddCategory.Visible = false;
                btnAddPro.Visible = false;
            }
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
            flpnMonAn.Controls.Clear();
            int idType;
            idType = maLoaiBLL.GetIdCategory(((Guna2Button)sender).Text);
            List<San_pham> listSP = sanPhamBLL.GetProOfType(idType);

            foreach (San_pham sp in listSP)
            {
                pnProduct p = new pnProduct(sp.Ma_SP);
                flpnMonAn.Controls.Add(p);
            }
        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            fProduct_Add f = new fProduct_Add();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
            this.Dispose();
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
