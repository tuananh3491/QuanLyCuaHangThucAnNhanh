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
        Ma_loaiBLL maLoaiBLL = new Ma_loaiBLL();
        public fProduct_Add()
        {
            InitializeComponent();
            setCbb();
        }
        public void setCbb()
        {
            List<Ma_loai> list = maLoaiBLL.GetAllML();
            foreach(Ma_loai item in list)
            {
                cbbCategory.Items.Add(item.Ten);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtLink.Text == "" || txtName.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Lỗi","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                //Tạo 1 đối tượng image từ file
                Image image = Image.FromFile(txtLink.Text.ToString());
                //tạo 1 memorystream
                var ms = new MemoryStream();//this is where we are going to deposit the bytes 
                                            //lưu bytes to ms
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                //to get the bytes we type
                var bytes = ms.ToArray();
                //
                var sp = new San_pham()
                {
                    Ten_SP = txtName.Text.ToString(),
                    Don_gia = Convert.ToDouble(txtPrice.Text.ToString()),
                    Ma_loai = maLoaiBLL.GetIdCategory(cbbCategory.SelectedItem.ToString()),
                    Trang_thai = true,
                    Hinh_anh = bytes
                };
                using (PBL_3Entities cnn = new PBL_3Entities())
                {
                    cnn.San_pham.Add(sp);
                    cnn.SaveChanges();
                }

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            

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

