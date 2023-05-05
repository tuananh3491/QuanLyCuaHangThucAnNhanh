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
        SanPham sanPhamBLL = new SanPham();
        public pnProduct_Update(int ma)
        {
            InitializeComponent();
            maSP = ma;
            Load(ma);
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if (Const.loaiTaiKhoan)
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
            txtPrice.Text = sp.Don_gia.ToString();
            checkCo.Checked = (bool)sp.Trang_thai;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            San_pham sp = cnn.San_pham.Find(maSP);
            sp.Don_gia = Convert.ToDouble(txtPrice.Text.ToString());
            sp.Trang_thai = checkCo.Checked;
            cnn.SaveChanges();
            MessageBox.Show("Đã lưu","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
            fProduct fProduct = new fProduct();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm khỏi menu?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                PBL_3Entities cnn = new PBL_3Entities();
                San_pham sp = cnn.San_pham.Find(maSP);
                sp.Trang_thai = false;
                cnn.SaveChanges();
            }
        }
    }
}
