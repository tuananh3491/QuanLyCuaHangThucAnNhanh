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
        San_phamBLL san_PhamBLL = new San_phamBLL();
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
            try
            {
                if (txtLink.Text == "" || txtName.Text == "" || txtPrice.Text == "")
                {
                    MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    //tạo 1 memorystream
                    var ms = new MemoryStream();//this is where we are going to deposit the bytes 
                                                //lưu bytes to ms
                    picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
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
                    san_PhamBLL.SaveSP(sp);


                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Không thể chuyển đổi giá tiền.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không thể tìm thấy file.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Không phải file hình ảnh.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            try
            {
                picture.Image.Dispose();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Select Image";
                ofd.Filter = "Image file|*.jpg; *.png|All files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picture.Image = new Bitmap(ofd.FileName);
                }
                txtLink.Text = ofd.FileName;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Không phải file hình ảnh.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Không thể tìm thấy file.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}

