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
      

        public fStaff_View(Nhan_vien x)
        {
            InitializeComponent();
            this.x = x;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
        private void fStaff_Add_Load(object sender, EventArgs e)
        {
            txtMaNV.Text = x.Ma_NV.ToString();
            txtSDT.Text = x.SDT;
            txtTen.Text = x.Ten_NV;
            txtLuong.Text = string.Format("{0:#,##0} đ", x.Luong).Replace(",", ".");
            dateTimePicker1.Value = x.Ngay_sinh;
            txtTenTK.Text = x.Tai_khoan.Ten_TK;
            if (x.Email != null)
            {
                txtEmail.Text = x.Email.ToString();
            }
            else
            {
                txtEmail.Text = "";
            }
            
            if(x.Gioi_tinh == true) radioButton1.Checked = true;
            else radioButton2.Checked = true;
            if (x.Tai_khoan.Loai_TK == true) radioButton4.Checked = true;
            else radioButton3.Checked = true;
            checkBox1.Checked = (x.Trang_thai == true);
        }

        private void btnCTLuong_Click(object sender, EventArgs e)
        {
            fStaff_SalaryDetail f = new fStaff_SalaryDetail(x.Ma_NV);
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

      
    }
}
