using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fStaff_SalaryDetail : Form
    {
         Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Phan_congBLL pcBLL = new Phan_congBLL();
        int maNV;int tongLuong;
        public fStaff_SalaryDetail(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            DateTime ngay = dtpLich.Value;
            Load(ngay);
        }
        public void Load(DateTime ngay)
        {
            tongLuong = 0;
            txtMaNV.Text = maNV.ToString();
            txtTen.Text = nvBLL.GetNVByMa(maNV).Ten_NV;
            List<Phan_cong> listPC = pcBLL.GetPhanCong(maNV, ngay);
            foreach(Phan_cong pc in listPC)
            {
                if (pc.Ngay < DateTime.Today)
                {
                    {
                        tongLuong += Convert.ToInt32(pc.soGio * pc.luongGio);
                        dgv.Rows.Add(pc.Ngay, pc.Ma_ca, pc.Ca_lam_viec.Ten_ca, pc.Ca_lam_viec.Thoigianbatdau, pc.Ca_lam_viec.Thoigianketthuc, pc.soGio, Convert.ToInt32(pc.luongGio).ToString("#,##0 đ").Replace(",", "."), Convert.ToInt32(pc.soGio * pc.luongGio).ToString("#,##0 đ").Replace(",", "."));
                    }
                }
            }
            txtTongLuong.Text = tongLuong.ToString();   
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Const.taiKhoan.Loai_TK)
            {
                fStaff_View f = new fStaff_View(nvBLL.GetNVByMa(maNV));
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
            else
            {
                fPersonality f = new fPersonality();
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            DateTime ngay = dtpLich.Value;
            Load(ngay);
        }
    }
}
