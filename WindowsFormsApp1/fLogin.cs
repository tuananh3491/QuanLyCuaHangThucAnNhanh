using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1
{
    public partial class fLogin : Form
    {
        private int maTK;
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
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

        private void ShowForm()
        {
            this.Show();
            Reset();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtPassWord.Text = "";
            txtUsername.Text = "";
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassWord.Text != "")
            {
                try
                {
                    Tai_khoanBLL tkBLL = new Tai_khoanBLL();
                    if (tkBLL.CheckLogin(int.Parse(txtUsername.Text), txtPassWord.Text))
                    {
                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fMainform fMainform = new fMainform();
                        fMainform.logout += new fMainform.Logout(this.ShowForm);
                        this.Hide();
                        fMainform.ShowDialog();
                    }
                    else MessageBox.Show("Đăng nhập không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)//chữ là không được
                {
                    MessageBox.Show("Tên đăng nhập không phù hợp");
                    errorProvider1.SetError(txtUsername, "Tên đăng nhập không phù hợp");
                    return;
                }
            }
            if(txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Tên đăng nhập không phù hợp");
            }
        }



        private void txtPassWord_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btLogIn_Click(sender, e);
            }
            
        }

        private void linkQMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                maTK = Convert.ToInt32(txtUsername.Text);
                if (tkBLL.GetTK(maTK) != null)
                {
                    fFogetPassword f = new fFogetPassword(maTK);
                    f.TopLevel = false;
                    this.pnLogIn.Controls.Add(f);
                    f.BringToFront();
                    f.Show();
                }
                else MessageBox.Show("Tài khoản không tồn tại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chưa nhập tên đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            

        }
    }
}
