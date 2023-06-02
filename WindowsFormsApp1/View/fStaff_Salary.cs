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
            int luong;
            
            foreach (int nam in phanCongBLL.GetAllNamPC())
            {
                for (int thang = 1; thang < 13; thang++)
                {
                    double soGio = phanCongBLL.GetAllTime(maNV, thang, nam);
                    if (soGio > 0 && nvBLL.GetNVByMa(maNV).Luong != null)
                    {
                        luong = (int)nvBLL.GetNVByMa(maNV).Luong;
                        dgvLuong.Rows.Add(thang + " - " + nam, soGio, luong.ToString("#,##0 đ").Replace(",", "."), (soGio*luong).ToString("#,##0 đ").Replace(",", "."));
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
    }
}
