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
    public partial class fStaff : Form
    {
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        public fStaff()
        {
            InitializeComponent();
            Load();
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if(Const.taiKhoan.Loai_TK)
            {
                btnXem.Visible = false;
            }
        }


        public void Load()
        {
            List<Nhan_vien> l=new List<Nhan_vien>();
            l = nvBLL.GetAllNV();
            foreach(Nhan_vien v in l)
            {
                dataGridView1.Rows.Add(v.Ma_NV, v.Ten_NV, v.Ngay_sinh, v.Gioi_tinh == true ? "Nam" : "Nữ", v.SDT, v.Trang_thai == true ? "Còn làm" : "Nghỉ việc ",v.Email);
            }
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                fStaff_View f = new fStaff_View(nvBLL.GetNVByMa(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString())));
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
                this.Dispose();

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView1.DataSource = nvBLL.SearchNV(txtSearch.Text);
            }
        }
    }
}
