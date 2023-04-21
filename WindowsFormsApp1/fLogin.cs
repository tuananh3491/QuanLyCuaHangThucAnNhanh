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
using WindowsFormsApp1.View;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState== FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            }
            else { WindowState = FormWindowState.Normal;}
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
            txtUsername.Text = "";
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text != "" && txtPassWord.Text != "")
            {
                DangNhapBLL dn = new DangNhapBLL();
                if (dn.checkLogin(int.Parse(txtUsername.Text), txtPassWord.Text))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    fMainform fMainform = new fMainform();
                    this.Hide();
                    fMainform.ShowDialog();
                    //this.Show();
                }
                else MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

  
    }
}
