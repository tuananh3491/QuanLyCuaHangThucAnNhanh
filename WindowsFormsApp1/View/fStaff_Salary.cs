using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;

namespace WindowsFormsApp1.View
{
    public partial class fStaff_Salary : Form
    {
        private int maNV;
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Phan_congBLL phanCongBLL = new Phan_congBLL();
        public fStaff_Salary(int ma)
        {
            InitializeComponent();
            maNV = ma;
            Load(maNV);
        }
        public void Load(int maNV)
        {
            txtMaNV.Text = maNV.ToString();
            txtName.Text = nvBLL.GetNVByMa(maNV).Ten_NV.ToString();
            //showDGV
            dgvLuong.Rows.Clear();
            DateTime time = DateTime.Now;
            
            foreach (int nam in phanCongBLL.GetAllNamPC())
            {
                for (int thang = 1; thang < 13; thang++)
                {
                    double soGio = phanCongBLL.GetAllTime(maNV, thang, nam);
                    if (soGio > 0)
                    {
                        dgvLuong.Rows.Add(thang + " - " + nam, soGio, nvBLL.GetNVByMa(maNV).Luong, soGio * nvBLL.GetNVByMa(maNV).Luong);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
    }
}
