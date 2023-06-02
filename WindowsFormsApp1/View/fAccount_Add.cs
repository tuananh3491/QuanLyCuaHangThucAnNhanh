using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.CustomControl;
using WindowsFormsApp1.DAL;
using System.Text.RegularExpressions;

namespace WindowsFormsApp1.View
{
    public partial class fAccount_Add : Form
    {
        
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fAccount_Add()
        {
            InitializeComponent();
            
        }
        public bool CheckEmail()
        {
            string email = txtEmail.Text; 
            Regex regex = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$");

            if (regex.IsMatch(email))
            {
                return true;
            }
            else {
                if (email != "")
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(CheckEmail())
            {
                try
                {
                    if (txtTenNV.Text == "") throw new SqlNullValueException();
                    int.Parse(txtSDT.Text);
                    int x = nvBLL.AddNV(new Nhan_vien
                    {
                        SDT = txtSDT.Text,
                        Ten_NV = txtTenNV.Text,
                        Gioi_tinh = (rdoNam.Checked),
                        Ngay_sinh = dtmNgaySinh.Value,
                        Trang_thai = (check.Checked),
                        Luong = Convert.ToInt32(txtLuong.Text),
                        Email = txtEmail.Text,
                    });
                    txtLuong.Text = string.Format("{0:#,##0} đ", Convert.ToInt32(txtLuong.Text)).Replace(",", ".");
                    txtLuong.Visible = false;
                    lblLuong.Visible = false;
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hash = BCrypt.Net.BCrypt.HashPassword(txtMK.Text, salt);
                    tkBLL.SaveTK(new Tai_khoan
                    {
                        Ma_TK = x,
                        Ten_TK = txtTenTK.Text,
                        Loai_TK = check.Checked,
                        Mat_khau = hash
                    });
                    MessageBox.Show("Thêm nhân viên thành công.");
                }
                catch (DbEntityValidationException)
                {
                    MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("SỐ ĐIỆN THOẠI HOẶC LƯƠNG KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlNullValueException)
                {
                    MessageBox.Show("TÊN RỖNG KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void Check_Changed(object sender, EventArgs e)
        {
            if (rdoNV.Checked)
            {
                lblLuong.Visible = true;
                txtLuong.Visible = true;
            }
            else
            {
                lblLuong.Visible = false;
                txtLuong.Visible = false;
            }
        }

    }   
}
