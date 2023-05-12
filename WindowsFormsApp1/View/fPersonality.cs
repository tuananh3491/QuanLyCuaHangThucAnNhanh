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
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fPersonality : Form
    {
        private int maNV = Const.taiKhoan.Ma_TK;
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Tai_khoanBLL tkBLL = new Tai_khoanBLL();
        public fPersonality()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            Nhan_vien nv = nvBLL.GetNVByMa(maNV);
            txtID.Text = nv.Ma_NV.ToString();
            txtName.Text = nv.Ten_NV.ToString();
            dateTimePicker1.Text = nv.Ngay_sinh.ToString();
            if(nv.Gioi_tinh == true)
            {
                rdMale.Checked = true;
            }
            else
            {
                rdFemale.Checked = true;
            }
            txtPhone.Text = nv.SDT.ToString();
            if(nv.Trang_thai == false) chStatus.Checked = true;
            if(nv.Tai_khoan.Loai_TK == false) rdOwner.Checked = true;
            else rdStaff.Checked = true;
            txtTenTK.Text = nv.Tai_khoan.Ten_TK;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            Nhan_vien nv = nvBLL.GetNVByMa(maNV);
            nv.Ten_NV = txtName.Text.ToString();
            nv.Ngay_sinh = dateTimePicker1.Value;
            nv.Gioi_tinh = rdMale.Checked;
            nv.SDT = txtPhone.Text.ToString();
            nv.Trang_thai = !(chStatus.Checked);
            Tai_khoan tk = tkBLL.GetTK(maNV);
            nv.Tai_khoan.Ten_TK = txtTenTK.Text.ToString();
            nv.Tai_khoan.Loai_TK = rdStaff.Checked;
            nvBLL.SaveNV(nv);
            tkBLL.SaveTK(tk);
            MessageBox.Show("Đã lưu thay đổi", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fTrangChu f = new fTrangChu();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
