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
    public partial class fShift_Staff : Form
    {
        Nhan_vienBLL nvBLL = new Nhan_vienBLL();
        Phan_congBLL pcBLL = new Phan_congBLL();
        int maNV = Const.taiKhoan.Ma_TK;
         int thang, nam;
        public fShift_Staff()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            thang = dtpLich.Value.Month;
            nam = dtpLich.Value.Year;
            txtTen.Text = nvBLL.GetNVByMa(maNV).Ten_NV;
            txtMaNV.Text = nvBLL.GetNVByMa(maNV).Ma_NV.ToString();
            ShowDGV();
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            dgv.Rows.Clear();
            Load();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fPersonality f = new fPersonality();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

        public void ShowDGV()
        {
            List<Phan_cong> listPC = pcBLL.GetPhanCong(maNV, thang, nam);
            foreach (Phan_cong pc in listPC)
            {
                if(pc.Ngay > DateTime.Today)
                {
                    dgv.Rows.Add(pc.Ngay, pc.Ca_lam_viec.Ma_ca, pc.Ca_lam_viec.Ten_ca, pc.Ca_lam_viec.Thoigianbatdau, pc.Ca_lam_viec.Thoigianketthuc, "Chưa làm");
                }
                else if (pc.Ngay == DateTime.Today)
                {
                    dgv.Rows.Add(pc.Ngay, pc.Ca_lam_viec.Ma_ca, pc.Ca_lam_viec.Ten_ca, pc.Ca_lam_viec.Thoigianbatdau, pc.Ca_lam_viec.Thoigianketthuc, "Đang cập nhật");
                }
                 else if (pc.Ngay < DateTime.Today)
                {
                    dgv.Rows.Add(pc.Ngay, pc.Ca_lam_viec.Ma_ca, pc.Ca_lam_viec.Ten_ca, pc.Ca_lam_viec.Thoigianbatdau, pc.Ca_lam_viec.Thoigianketthuc, pc.soGio);
                }
            }
        }
    }
}
