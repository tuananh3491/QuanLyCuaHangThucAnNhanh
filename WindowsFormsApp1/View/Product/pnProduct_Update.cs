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
    public partial class pnProduct_Update : UserControl
    {
        private int maSP;
        San_phamBLL sanPhamBLL = new San_phamBLL();
        public pnProduct_Update(int ma)
        {
            InitializeComponent();
            maSP = ma;
            Load(ma);
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if ((bool)Const.taiKhoan.Loai_TK)
            {
                txtPrice.Enabled = false;
                checkCo.Enabled = false;
                btnSave.Enabled = false;
            }
        }
        public void Load(int ma)
        {
            San_pham sp = sanPhamBLL.GetPro(ma);
            picture.BackgroundImage = Image.FromStream(new MemoryStream(sp.Hinh_anh));
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            txtName.Text = sp.Ten_SP.ToString();
            txtName.Enabled = false;
            txtPrice.Text = string.Format("{0:#,##0} đ", sp.Don_gia).Replace(",", ".");
            checkCo.Checked = (bool)sp.Trang_thai;
            if (sp.Trang_thai == false) btnDel.Enabled = false;
            else btnDel.Enabled = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                San_pham sp = sanPhamBLL.GetPro(maSP);
                sp.Don_gia = Convert.ToDouble(txtPrice.Text.ToString());
                sp.Trang_thai = checkCo.Checked;
                sanPhamBLL.SaveSP(sp);

                MessageBox.Show("Đã lưu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fProduct fProduct = new fProduct();
                Load(maSP);
            }
            catch (FormatException)// format của đơn giá
            {
                MessageBox.Show("Đơn giá không phù hợp");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm khỏi menu?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                San_pham sp = sanPhamBLL.GetPro(maSP);
                sp.Trang_thai = false;
                sanPhamBLL.SaveSP(sp);
                btnDel.Enabled = false;
                checkCo.Checked = false;
            }
        }

    }
}
