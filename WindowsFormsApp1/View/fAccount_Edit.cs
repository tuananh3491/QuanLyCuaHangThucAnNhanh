using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fAccount_Edit : Form
    {
        private int ma_tk;
        private Tai_khoanBLL tai_KhoanBLL;
        public fAccount_Edit()
        {
            InitializeComponent();
        }
        public fAccount_Edit(int s)
        {
            InitializeComponent();
            tai_KhoanBLL=new Tai_khoanBLL();
            ma_tk = s;
            setGUI(s);
        }
        public void setGUI(int maTK)
        {
            Tai_khoan tk=new Tai_khoan();
            tk=tai_KhoanBLL.GetTK(maTK);
            txtMaTaiKhoan.Text = tk.Ma_TK.ToString();
            txtTen.Text=tk.Nhan_vien.Ten_NV;
            txtTenTK.Text=tk.Ten_TK;
            txtMatKhau.Text=tk.Mat_khau;
            txtSDT.Text=tk.Nhan_vien.SDT;
            if (tk.Loai_TK == true) { rdNhanVien.Checked = true; }
            else { rdAdmin.Checked = true; }
            chkTrangThai.Checked = tk.Nhan_vien.Trang_thai;
            if (tk.Nhan_vien.Gioi_tinh == true) { rdNam.Checked = true; }
            else { rdNam.Checked=true; }
            

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fAccount f = new fAccount();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Add(f);
            f.Show();
            this.Dispose();
        }
    }
}
