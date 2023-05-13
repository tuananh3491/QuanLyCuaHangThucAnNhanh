using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.CustomControl;
using WindowsFormsApp1.DAL;

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
            try
            {
                int.Parse(txtSDT.Text);
                txtLuong.Visible = false;
                lblLuong.Visible = false;
                int x = nvBLL.AddNV(new Nhan_vien
                {
                    SDT = txtSDT.Text,
                    Ten_NV = txtTenNV.Text,
                    Gioi_tinh = (rdoNam.Checked),
                    Ngay_sinh = dtmNgaySinh.Value,
                    Trang_thai = (check.Checked),
                    Luong = Convert.ToInt32(txtLuong.Text),
                });

                tkBLL.SaveTK(new Tai_khoan
                {
                    Ma_TK = x,
                    Ten_TK = txtTenTK.Text,
                    Mat_khau = txtMK.Text,
                    Loai_TK = check.Checked
                });
                MessageBox.Show("Thêm nhân viên thành công.");
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(FormatException)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI HOẶC LƯƠNG KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
