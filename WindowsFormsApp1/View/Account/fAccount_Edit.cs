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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fAccount_Edit : Form
    {
        private int ma_tk;
        private Tai_khoanBLL tai_KhoanBLL;
        public fAccount_Edit(int s)
        {
            InitializeComponent();
            tai_KhoanBLL=new Tai_khoanBLL();
            ma_tk = s;
            setGUI(s);
        }
        public bool CheckEmail()
        {
            string email = txtEmail.Text;
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");

            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                if(email != "")
                {
                    MessageBox.Show("Email không đúng định dạng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public void setGUI(int maTK)
        {
            Tai_khoan tk=new Tai_khoan();
            tk=tai_KhoanBLL.GetTK(maTK);
            txtMaTaiKhoan.Text = tk.Ma_TK.ToString();
            txtTen.Text=tk.Nhan_vien.Ten_NV;
            txtTenTK.Text=tk.Ten_TK;
            txtSDT.Text=tk.Nhan_vien.SDT;
            if (tk.Loai_TK == true) 
            {   rdNhanVien.Checked = true;
                lblLuong.Visible = true;
                txtLuong.Visible = true;
                txtLuong.Text = string.Format("{0:#,##0} đ", tk.Nhan_vien.Luong).Replace(",", ".");
            }
            else { rdAdmin.Checked = true; }
            chkTrangThai.Checked = tk.Nhan_vien.Trang_thai;
            if (tk.Nhan_vien.Gioi_tinh == true) { rdNam.Checked = true; }
            else { rdNu.Checked=true; }
            dtpkNgaySinh.Value = tk.Nhan_vien.Ngay_sinh;
            txtEmail.Text = tk.Nhan_vien.Email;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fAccount f=new fAccount();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
        public int ChangeFormatCurrency(string tien)
        {
            // Xóa ký tự đơn vị tiền tệ
            tien = tien.Replace(" đ", "");
            // Xóa dấu phân cách hàng nghìn
            tien = tien.Replace(".", "");
            // Chuyển đổi chuỗi tiền thành kiểu integer
            int giatriTien = int.Parse(tien);
            // giá trị tiền kiểu integer
            return giatriTien;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmail())
            {
                try
                {
                    int i;int luong;
                    if (txtTen.Text == "") throw new SqlNullValueException();
                    if (!int.TryParse(txtSDT.Text, out i)) throw new DbEntityValidationException();
                    if (txtSDT.Text.Length < 10) throw new DbEntityValidationException();
                    Tai_khoan x = tai_KhoanBLL.GetTK(ma_tk);
                    x.Nhan_vien.SDT = txtSDT.Text;
                    x.Nhan_vien.Ten_NV = txtTen.Text;
                    x.Nhan_vien.Ngay_sinh = dtpkNgaySinh.Value;
                    x.Ten_TK = txtTenTK.Text;
                    luong = ChangeFormatCurrency(txtLuong.Text);
                    x.Nhan_vien.Luong = luong;
                    x.Nhan_vien.Email = txtEmail.Text;

                    if (rdNam.Checked) x.Nhan_vien.Gioi_tinh = true;
                    else x.Nhan_vien.Gioi_tinh = false;
                    if (rdNhanVien.Checked) x.Loai_TK = true;
                    else x.Loai_TK = false;
                    x.Nhan_vien.Trang_thai = chkTrangThai.Checked;

                    tai_KhoanBLL.SaveTK(x);
                    txtLuong.Text = string.Format("{0:#,##0} đ", x.Nhan_vien.Luong).Replace(",", ".");
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
}
