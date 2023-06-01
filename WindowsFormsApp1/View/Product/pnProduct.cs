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

namespace WindowsFormsApp1.View.Product
{
    public partial class pnProduct : UserControl
    {
        San_phamBLL sanPhamBLL = new San_phamBLL();
        private int maSP;
        public pnProduct(int m )
        {
            InitializeComponent();
            maSP = m;
            Load(m);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnProduct_Update p = new pnProduct_Update(maSP);
           
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Clear();
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Add(p);
         
        }
        public void Load(int m)
        {
            San_pham sp = sanPhamBLL.GetPro(maSP);
            pic.BackgroundImage = Image.FromStream(new MemoryStream(sp.Hinh_anh));
            pic.BackgroundImageLayout = ImageLayout.Stretch;
            txtName.Text = sp.Ten_SP.ToString();
            //txtPrice.Text = sp.Don_gia.ToString();
            txtPrice.Text = string.Format("{0:#,##0} đ", sp.Don_gia).Replace(",", ".");
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            San_pham sp = sanPhamBLL.GetPro(maSP);
            //txtPrice.Text = sp.Don_gia.ToString();
            txtPrice.Text = string.Format("{0:#,##0} đ", sp.Don_gia).Replace(",", ".");
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            San_pham sp = sanPhamBLL.GetPro(maSP);
            //txtPrice.Text = (sp.Don_gia*1.2).ToString();
            txtPrice.Text = string.Format("{0:#,##0} đ", sp.Don_gia*1.2).Replace(",", ".");
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            San_pham sp = sanPhamBLL.GetPro(maSP);
            //txtPrice.Text = (sp.Don_gia*1.4).ToString();
            txtPrice.Text = string.Format("{0:#,##0} đ", sp.Don_gia*1.4).Replace(",", ".");
        }
    }
}
