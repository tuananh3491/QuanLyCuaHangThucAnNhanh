using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Phan_congBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();

        public List<Phan_cong> GetAllPC()
        {
            var s = cnn.Phan_cong.ToList();
            return s;
        }
        public dynamic GetNVsByCa_Date(int maCa, DateTime date) //lấy tất cả nhân viên làm trong ca và ngày đã cho
        {
            var s = cnn.Phan_cong.Where(p => p.Ma_ca == maCa && DbFunctions.TruncateTime(p.Ngay) == date.Date).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV }).ToList();
            return s;
        }
        public List<int> getMaNV(int Ma_ca)
        {
            var s = cnn.Phan_cong.Where(p => p.Ma_ca == Ma_ca).Select(p => p.Ma_NV).Distinct().ToList();
            return s;
        }
        public List<int> getMaCa()
        {
            var s = cnn.Phan_cong.Select(p => p.Ma_ca).Distinct().ToList();
            return s;
        }
        public dynamic GetNVPC(int Ma_ca)
        {
            var s = cnn.Phan_cong.Where(p => p.Ma_ca == Ma_ca).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV, p.Ngay }).ToList();
            return s;
        }

        public List<int> GetMaNVPC(int Ma_ca, DateTime date)//lấy tất cả mã nhân viên làm trong ca và ngày đã cho
        {
            var s = cnn.Phan_cong.Where(p => p.Ma_ca == Ma_ca && DbFunctions.TruncateTime(p.Ngay) == date.Date).Select(p => p.Ma_NV).ToList();
            return s;
        }
        public dynamic GetNVPC(DateTime ngay, int Ma_ca)
        {
            var s = cnn.Phan_cong.Where(p => p.Ngay.Value.Day == ngay.Day && p.Ngay.Value.Month == ngay.Month && p.Ngay.Value.Year == ngay.Year && p.Ma_ca == Ma_ca).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV, p.Ngay }).ToList();
            return s;
        }
        public void SavePC(Phan_cong pc)
        {
            cnn.Phan_cong.AddOrUpdate(pc);
            cnn.SaveChanges();
        }
        public void DeletePC(Phan_cong pc)
        {
            var p = cnn.Phan_cong.Find(pc.Ma_NV, pc.Ma_ca);
            cnn.Phan_cong.Remove(p);
            cnn.SaveChanges();
        }
        public void ShowDGV(DataGridView dg,int Ma_ca)
        {
            dg.DataSource = GetNVPC(Ma_ca);
        }

        public void ShowDGV(DataGridView dg, DateTime ngay, int Ma_ca)
        {
            dg.DataSource = GetNVPC(ngay, Ma_ca);
        }

        public List<string> GetMaNV(int Ma_ca)
        {
            Nhan_vienBLL nvBLL = new Nhan_vienBLL();
            int t;
            List<string> list = new List<string>();
            foreach(var i in nvBLL.GetAllNV())
            {
                t = 0;
                foreach (var j in GetNVPC(Ma_ca))
                {
                    if (i.Ma_NV == j.Ma_NV) break;
                    else t++;
                }
                if (t >= GetNVPC(Ma_ca).Count)
                {
                    list.Add(i.Ma_NV.ToString());
                }
            }
            return list;
        }
    }
}
