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

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class AddNewCustomer : Form
    {
        Khach_hangBLL khBLL = new Khach_hangBLL();
        public AddNewCustomer()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Khach_hang kh = new Khach_hang()
                {
                    Ten_KH = txtName.Text,
                    SDT = txtPhone.Text,
                    Diem_tich_luy = Convert.ToInt32(txtDiemTL.Text)
                };
                //using (PBL_3Entities cnn = new PBL_3Entities())
                //{
                //    cnn.Khach_hang.Add(kh);
                //    cnn.SaveChanges();
                //}
                khBLL.SaveKH(kh);
                txtMa.Text = kh.Ma_KH.ToString();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
            //this.Close();
        }

    }
}
