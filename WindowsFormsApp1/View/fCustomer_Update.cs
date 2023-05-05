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

namespace WindowsFormsApp1.View
{
    public partial class fCustomer_Update : Form
    {
        public int maKH;
        //KhachHang khBLL = new KhachHang();
        public fCustomer_Update(int m = -1)
        {
            InitializeComponent();
            maKH = m;
            Load(m);
        }
        public void Load(int m)
        {
            KhachHang khBLL = new KhachHang();
            var kh = khBLL.GetKHById(m);
            txtMaKH.Text = kh.Ma_KH.ToString();
            txtMaKH.Enabled = false;
            txtTenKH.Text = kh.Ten_KH.ToString();
            txtTenKH.Enabled = false;
            txtSDT.Text = kh.SDT.ToString();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           // maKH = int.Parse(txtMaKH.Text.ToString());//? cần có ko
            PBL_3Entities cnn = new PBL_3Entities();
            //KhachHang khBLL = new KhachHang();
            Khach_hang kh = cnn.Khach_hang.Find(maKH);
           
            if (kh.SDT != txtSDT.Text)
            {
                kh.SDT = txtSDT.Text.ToString();
                cnn.SaveChanges();
                MessageBox.Show("Cập nhật thành công");
                fCustomer f = new fCustomer();
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                f.Show();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn muốn giữ số điện thoại cũ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    fCustomer f = new fCustomer();
                    f.TopLevel = false;
                    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
                    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
                    f.Show();
                }
                
                
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            Khach_hang kh = cnn.Khach_hang.Find(maKH);
            txtSDT.Text = "";
            //fCustomer f = new fCustomer();
            //f.TopLevel = false;
            //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            //((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            //f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.TopLevel = false;
            //f.Show();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
