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
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fCustomer_Update : Form
    {
        public int maKH;
        Khach_hangBLL khBLL = new Khach_hangBLL();
        public fCustomer_Update(int m)
        {
            InitializeComponent();
            maKH = m;
            Load(m);
        }
        public void Load(int m)
        {
            var kh = khBLL.GetKHById(m);
            txtMaKH.Text = kh.Ma_KH.ToString();
            txtMaKH.Enabled = false;
            txtTenKH.Text = kh.Ten_KH.ToString();
            txtTenKH.Enabled = false;
            txtSDT.Text = kh.SDT.ToString();
            txtDiemTL.Text = kh.Diem_tich_luy.ToString();
            txtDiemTL.Enabled = false;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(txtSDT.Text);
                Khach_hang kh = khBLL.GetKHById(maKH);
                if (kh.SDT != txtSDT.Text)
                {
                    kh.SDT = txtSDT.Text.ToString();
                    khBLL.SaveKH(kh);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn muốn giữ số điện thoại cũ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("SỐ ĐIỆN THOẠI HOẶC LƯƠNG KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

    }
}
