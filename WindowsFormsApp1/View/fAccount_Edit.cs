using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fAccount_Edit : Form
    {
        private int ma_tk;
        private Tai_khoanBLL tai_KhoanBLL;
        public fAccount_Edit()
        {
            InitializeComponent();
        }
        public fAccount_Edit(int s)
        {
            InitializeComponent();
            tai_KhoanBLL=new Tai_khoanBLL();
            ma_tk = s;
            setGUI(s);
        }
        public void setGUI(int maTK)
        {
            Tai_khoan tk=new Tai_khoan();
            tk=tai_KhoanBLL.GetTK(maTK);
            txtMaTaiKhoan.Text = tk.Ma_TK.ToString();
            txtTen.Text=tk.Nhan_vien.Ten_NV;
            txtTenTK.Text=tk.Ten_TK;
            txtMatKhau.Text=tk.Mat_khau;
            txtSDT.Text=tk.Nhan_vien.SDT;
            if (tk.Loai_TK == true) 
            {   rdNhanVien.Checked = true;
                lblLuong.Visible = true;
                txtLuong.Visible = true;
                txtLuong.Text = tk.Nhan_vien.Luong.ToString();
            }
            else { rdAdmin.Checked = true; }
            chkTrangThai.Checked = tk.Nhan_vien.Trang_thai;
            if (tk.Nhan_vien.Gioi_tinh == true) { rdNam.Checked = true; }
            else { rdNam.Checked=true; }
            dtpkNgaySinh.Value = tk.Nhan_vien.Ngay_sinh;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Add(f);
            f.Show();
            this.Dispose();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int i;
                if (txtTen.Text == "") throw new SqlNullValueException();
                if(!int.TryParse(txtSDT.Text, out i)) throw new DbEntityValidationException();
                if (txtTen.Text.Length < 10) throw new DbEntityValidationException();
                Tai_khoan x = tai_KhoanBLL.GetTK(ma_tk);
                x.Nhan_vien.SDT = txtSDT.Text;
                x.Nhan_vien.Ten_NV = txtTen.Text;
                x.Nhan_vien.Ngay_sinh = dtpkNgaySinh.Value;
                x.Ten_TK = txtTenTK.Text;
                x.Mat_khau = txtMatKhau.Text;
                x.Nhan_vien.Luong = Convert.ToInt32(txtLuong.Text);

                if (rdNam.Checked) x.Nhan_vien.Gioi_tinh = true;
                else x.Nhan_vien.Gioi_tinh = false;
                if (rdNhanVien.Checked) x.Loai_TK = true;
                else x.Loai_TK = false;
                x.Nhan_vien.Trang_thai = chkTrangThai.Checked;

                tai_KhoanBLL.SaveTK(x);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Số điện thoại không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lương không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Tên rỗng không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
