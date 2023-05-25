using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1
{
    public partial class fChangePassword : Form
    {
        private int maTK = Const.taiKhoan.Ma_TK;
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Tai_khoan tk=new Tai_khoan();
            tk = tkBLL.GetTK(maTK);
            if (BCrypt.Net.BCrypt.Verify(txtMKCu.Text, tk.Mat_khau))
            {
                if(txtMKMoi.Text == txtXacNhanMK.Text) 
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
