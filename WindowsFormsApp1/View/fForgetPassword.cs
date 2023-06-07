using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fForgetPassword : Form
    {
        private int maTK;
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        Random randomOTP = new Random();
        int otp;
       
        public fForgetPassword(int ma)
        {
            InitializeComponent();
            maTK = ma;
            Load(maTK);
        }
        public void Load(int maTK)
        {
            txtEmail.Text = tkBLL.GetTK(maTK).Nhan_vien.Email;
            txtEmail.Enabled = false;
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text != "")//có email để tránh nhân viên chưa có email
            {
                try
                {
                    //tạo mã otp random 6 số:
                    otp = randomOTP.Next(100000, 1000000);

                    var fromAddress = new MailAddress("slowlyfastfoodstore03@gmail.com"); //mail dùng để gửi mã otp
                    var toAddress = new MailAddress(txtEmail.ToString());//mail dùng để nhận otp
                    const string frompass = "wgubounrayryjfpq";//mật khẩu ứng dụng
                    const string subject = "OTP code";
                    string body = otp.ToString();

                    var stmp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, frompass),
                        Timeout = 200000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        stmp.Send(message);
                    }
                    MessageBox.Show("OTP đã được gửi qua mail");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chưa có email. Nếu bạn muốn reset mật khẩu hãy liên hệ chủ cửa hàng!","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }



        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if (otp.ToString().Equals(txtOTP.Text))
            {
                //resset lại mật khẩu
                Tai_khoan x = tkBLL.GetTK(maTK);
                string salt = BCrypt.Net.BCrypt.GenerateSalt();
                string hash = BCrypt.Net.BCrypt.HashPassword("1", salt);
                x.Mat_khau = hash;
                tkBLL.SaveTK(x);
                //MessageBox.Show("Đặt lại mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MessageBox.Show("Mật khẩu đã reset = 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("OTP không chính xác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
