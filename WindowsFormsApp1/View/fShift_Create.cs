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
    public partial class fShift_Create : Form
    {
        Ca_lam_viecBLL bll;
        public fShift_Create()
        {
            InitializeComponent();
            bll = new Ca_lam_viecBLL();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Ca_lam_viec t = new Ca_lam_viec()
            {
                Ten_ca = txtName.Text,
                Thoigianbatdau = TimeSpan.Parse(dateTimePicker1.Text),
                Thoigianketthuc = TimeSpan.Parse(dateTimePicker2.Text),
            };
            bll.AddCLV(t);
            MessageBox.Show("Tạo ca thành công");
            fShift f = new fShift();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            fShift f = new fShift();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
