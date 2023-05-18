using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.CustomControl;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fStaff_View : Form
    {
        private Nhan_vien x;
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        public fStaff_View()
        {
            InitializeComponent();
        }

        public fStaff_View(Nhan_vien x)
        {
            InitializeComponent();
            this.x = x;
        }

        //private void changeForm()
        //{
        //    fStaff f = new fStaff();
        //    f.TopLevel = false;
        //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
        //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
        //    f.Show();
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            f.TopLevel = false;
            f.Show();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fStaff_Add_Load(object sender, EventArgs e)
        {
            textBox1.Text = x.Ma_NV.ToString();
            textBox2.Text = x.SDT;
            textBox3.Text = x.Ten_NV;
            textBox4.Text = x.Luong.ToString();
            dateTimePicker1.Value = x.Ngay_sinh;
            textBox5.Text = x.Tai_khoan.Ten_TK;
            textBox6.Text = x.Tai_khoan.Mat_khau;
            if(x.Gioi_tinh == true) radioButton1.Checked = true;
            else radioButton2.Checked = true;
            if (x.Tai_khoan.Loai_TK == true) radioButton4.Checked = true;
            else radioButton3.Checked = true;
            checkBox1.Checked = (x.Trang_thai == true);
        }

        private void btnCTLuong_Click(object sender, EventArgs e)
        {
            fStaff_Salary f = new fStaff_Salary(x.Ma_NV);
            f.TopLevel = false;
            f.Show();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
