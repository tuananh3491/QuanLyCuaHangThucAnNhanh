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
        
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fStaff_Add()
        {
            InitializeComponent();
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
            textBox1.Visible = false;
            label1.Visible = false;
            int x = nvBLL.AddNV(new Nhan_vien
            {
                //Luong = Convert.ToInt32(textBox1.Text),
                
                SDT = textBox2.Text,
                Ten_NV = textBox3.Text,
                Gioi_tinh = (radioButton1.Checked),
                Ngay_sinh = dateTimePicker1.Value,
                Trang_thai = (checkBox1.Checked),
            });

            tkBLL.SaveTK(new Tai_khoan
            {
                Ma_TK = x,
                Ten_TK = textBox5.Text,
                Mat_khau = textBox6.Text,
                Loai_TK = radioButton4.Checked
            });
            MessageBox.Show("Thêm nhân viên thành công.");
            changeForm();
        }
    }   
}
