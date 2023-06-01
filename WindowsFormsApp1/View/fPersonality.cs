using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fPersonality : Form
    {
        private int maNV = Const.taiKhoan.Ma_TK;
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fPersonality()
        {
            InitializeComponent();
            Load();
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if (!(bool)Const.taiKhoan.Loai_TK)
            {
                btnCTLuong.Visible = false;
            }
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
                MessageBox.Show("Email không đúng định dạng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
        public void Load()
        {
            Nhan_vien nv = nvBLL.GetNVByMa(maNV);
            txtID.Text = nv.Ma_NV.ToString();
            txtName.Text = nv.Ten_NV.ToString();
            dateTimePicker1.Text = nv.Ngay_sinh.ToString();
            if (nv.Email != null)
            {
                txtEmail.Text = nv.Email.ToString();
            }
            else
            {
                txtEmail.Text = "";
            }
            if(nv.Gioi_tinh == true)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            txtPhone.Text = nv.SDT.ToString();
            if(nv.Trang_thai == false) chStatus.Checked = true;
            if(nv.Tai_khoan.Loai_TK == false) rdOwner.Checked = true;
            else rdStaff.Checked = true;
            txtTenTK.Text = nv.Tai_khoan.Ten_TK;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (CheckEmail())
            {
                try
                {
                    if (txtName.Text == "" || txtTenTK.Text == "" || txtPhone.Text == "") throw new ArgumentNullException();
                    int.Parse(txtPhone.Text);
                    txtID.Enabled = false;
                    Nhan_vien nv = nvBLL.GetNVByMa(maNV);
                    nv.Ten_NV = txtName.Text.ToString();
                    nv.Ngay_sinh = dateTimePicker1.Value;
                    nv.Gioi_tinh = rdMale.Checked;
                    nv.SDT = txtPhone.Text.ToString();
                    nv.Trang_thai = !(chStatus.Checked);
                    nv.Email = txtEmail.Text;
                    Tai_khoan tk = tkBLL.GetTK(maNV);
                    nv.Tai_khoan.Ten_TK = txtTenTK.Text.ToString();
                    nv.Tai_khoan.Loai_TK = rdStaff.Checked;
                    nvBLL.SaveNV(nv);
                    tkBLL.SaveTK(tk);
                    MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Tên nhân viên, tên tài khoản, SĐT không thể để trống.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("SĐT không thể để trống.", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fTrangChu f = new fTrangChu();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnCTLuong_Click(object sender, EventArgs e)
        {
            fStaff_Salary f = new fStaff_Salary(maNV);
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            Tai_khoan tk = new Tai_khoan();
            tk = tkBLL.GetTK(maNV);
            if (BCrypt.Net.BCrypt.Verify(txtMKCu.Text, tk.Mat_khau))
            {
                if (txtMKMoi.Text == txtXacNhanMK.Text)
                {
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hash = BCrypt.Net.BCrypt.HashPassword(txtMKMoi.Text, salt);
                    tk.Mat_khau = hash;
                    tkBLL.SaveTK(tk);
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Xác nhận mật khẩu không khớp");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ nhập vào không đúng!");
            }
        }

    }
}
