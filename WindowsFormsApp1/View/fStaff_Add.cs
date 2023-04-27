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
using WindowsFormsApp1.CustomControl;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fStaff_Add : Form
    {
        private Nhan_vien x;
        Nhan_vienBLL bll;
        public fStaff_Add()
        {
            InitializeComponent();
            bll = new Nhan_vienBLL();
        }

        public fStaff_Add(Nhan_vien x)
        {
            InitializeComponent();
            bll = new Nhan_vienBLL();
            this.x = x;
        }

        private void changeForm()
        {
            fStaff f = new fStaff();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            changeForm();
        }

        private void fStaff_Add_Load(object sender, EventArgs e)
        {
            
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            x.SDT = textBox2.Text;
            x.Ten_NV = textBox3.Text;
            x.Ngay_sinh = dateTimePicker1.Value;
            if (radioButton1.Checked) x.Gioi_tinh = true;
            else x.Gioi_tinh = false;
            x.Luong = int.Parse(textBox1.Text);

            Tai_khoan t = new Tai_khoan()
            {
                Ten_TK = textBox5.Text,
                Mat_khau = textBox6.Text,
                Loai_TK = (radioButton4.Checked) ? true : false,
            };      

            bll.AddNV(x);
            changeForm();
        }
    }   
}
