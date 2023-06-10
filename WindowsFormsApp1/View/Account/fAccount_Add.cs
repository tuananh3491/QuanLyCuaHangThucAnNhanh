﻿using System;
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int luong;
            if(CheckEmail())
            {
                try
                {
                    if (txtTenNV.Text == "") throw new SqlNullValueException();
                    if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 10) throw new DbEntityValidationException();
                    luong = ChangeFormatCurrency(txtLuong.Text);
                    int x ;

                    if (txtLuong.Visible)
                    {
                        x = nvBLL.AddNV(new Nhan_vien
                        {
                            SDT = txtSDT.Text,
                            Ten_NV = txtTenNV.Text,
                            Gioi_tinh = (rdoNam.Checked),
                            Ngay_sinh = dtmNgaySinh.Value,
                            Trang_thai = (check.Checked),
                            Luong = luong,
                            Email = txtEmail.Text,
                        });
                    }
                    else
                    {
                        x = nvBLL.AddNV(new Nhan_vien
                        {
                            SDT = txtSDT.Text,
                            Ten_NV = txtTenNV.Text,
                            Gioi_tinh = (rdoNam.Checked),
                            Ngay_sinh = dtmNgaySinh.Value,
                            Trang_thai = (check.Checked),
                            Luong = null,
                            Email = txtEmail.Text,
                        });
                    }
                    txtLuong.Text = string.Format("{0:#,##0} đ", luong).Replace(",", ".");
                    string salt = BCrypt.Net.BCrypt.GenerateSalt();
                    string hash = BCrypt.Net.BCrypt.HashPassword(txtMK.Text, salt);
                    tkBLL.SaveTK(new Tai_khoan
                    {
                        Ma_TK = x,
                        Ten_TK = txtTenTK.Text,
                        Loai_TK = rdoNV.Checked,
                        Mat_khau = hash
                    });
                    MessageBox.Show("Thêm nhân viên thành công.");
                }
                catch (DbEntityValidationException)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Số điện thoại hoặ lương không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (SqlNullValueException)
                {
                    MessageBox.Show("Tên rỗng không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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