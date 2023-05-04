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
    public partial class fProduct_Add : Form
    {
        MaLoai maLoaiBLL = new MaLoai();
        public fProduct_Add()
        {
            InitializeComponent();
            setCbb();
        }
        public void setCbb()
        {
            List<Ma_loai> list = maLoaiBLL.GetListCategory();
            foreach(Ma_loai item in list)
            {
                cbbCategory.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            San_pham sp = new San_pham();
            sp.Ten_SP = txtName.Text.ToString();
            sp.Don_gia = Convert.ToDouble(txtPrice.Text.ToString());
            sp.Ma_loai = int.Parse(cbbCategory.SelectedItem.ToString());
            sp.Trang_thai = true;

            //ảnh
            //byte[] image = (byte[])txtLink.Text.ToString();
            //MemoryStream ms = new MemoryStream(image);
            //sp.Hinh_anh = Image.FromStream(ms);

            using (PBL_3Entities cnn = new PBL_3Entities())
            {
                cnn.San_pham.Add(sp);
                cnn.SaveChanges();
            }
                
            MessageBox.Show("Thêm thành công","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtPrice.Text = null;
            cbbCategory.SelectedIndex = -1;
            txtName.Text = null;
            cbL.Checked=false; 
            cbM.Checked = false;
            cbS.Checked=false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fProduct f = new fProduct();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All file (*.*)|*.*";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picture.Image = new Bitmap(ofd.FileName);
            }
            txtLink.Text = ofd.FileName;
            //ofd.ShowDialog();
        }
    }
}

