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
    public partial class fAccount : Form
    {
        private Tai_khoanBLL tai_KhoanBLL;
        public fAccount()
        {
            InitializeComponent();
            tai_KhoanBLL=new Tai_khoanBLL();
            setGUI();
        }
        void setGUI()
        {
            List<Tai_khoan> list=new List<Tai_khoan>();
            list = tai_KhoanBLL.GetAllTK();
            foreach(Tai_khoan t in list)
            {
                DGVdsTaiKhoan.Rows.Add(t.Ma_TK,t.Ten_TK,t.Mat_khau,(t.Loai_TK==true?"Nhân viên":"Admin"));
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if(DGVdsTaiKhoan.SelectedRows.Count == 1)
            {
                int ma_tk = Convert.ToInt32(DGVdsTaiKhoan.SelectedRows[0].Cells[0].Value.ToString());
                fAccount_Edit f=new fAccount_Edit(ma_tk);
                f.TopLevel = false;
                ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Clear();
                ((fMainform)Application.OpenForms["fMainForm"]).pnForm.Controls.Add(f);
                f.Show();
                this.Dispose();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
