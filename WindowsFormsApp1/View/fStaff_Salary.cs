using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fStaff_Salary : Form
    {
        private int maNV;
        DateTime ngay;
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Phan_congBLL phanCongBLL = new Phan_congBLL();
        public fStaff_Salary(int ma)
        {
            InitializeComponent();
            maNV = ma;
            Load(maNV);
        }
        //public DateTime ChuyenNgay(string dateString)
        //{
        //    DateTime date;
        //    if (DateTime.TryParseExact(dateString, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
        //    {
        //        return date; 
        //    }

        //    else
        //    {
        //        MessageBox.Show("Invalid date string");
        //    }
        //}
        public void Load(int maNV)
        {
            txtMaNV.Text = maNV.ToString();
            txtTen.Text = nvBLL.GetNVByMa(maNV).Ten_NV.ToString();

            //showDGV
            //dgvLuong.Rows.Clear();
            DateTime time = DateTime.Now;
            int luong; int luongNhan = 0; double tongGio = 0;
            List<Phan_cong> listPC = phanCongBLL.GetPhanCong(maNV, ngay);
            foreach (Phan_cong pc in listPC)
            {
                if (pc.Ngay < DateTime.Today)
                {
                    tongGio += (double)pc.soGio;
                    luongNhan += Convert.ToInt32(pc.soGio * pc.luongGio);
                }
            }
            foreach (int nam in phanCongBLL.GetAllNamPC())
            {
                for (int thang = 1; thang < 13; thang++)
                {
                    double soGio = phanCongBLL.GetAllTime(maNV, thang, nam);
                    if (soGio > 0 && nvBLL.GetNVByMa(maNV).Luong != null)
                    {
                        luong = (int)nvBLL.GetNVByMa(maNV).Luong;
                        dgvLuong.Rows.Add(thang + "/" + nam, tongGio, (luongNhan).ToString("#,##0 đ").Replace(",", "."));
                    }
                }
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fStaff f = new fStaff();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(dgvLuong.SelectedRows.Count == 1)
            {
                string dateString = dgvLuong.SelectedRows[0].Cells[0].Value.ToString();
                DateTime ngay;
                DateTime.TryParseExact(dateString, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngay);
                int tongLuong = Convert.ToInt32(dgvLuong.SelectedRows[0].Cells[2].Value.ToString());
                fStaff_SalaryDetail f = new fStaff_SalaryDetail(maNV);
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
        }

        private void iconDone_Click(object sender, EventArgs e)
        {

        }
    }
}
