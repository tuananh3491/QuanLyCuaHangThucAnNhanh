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
        
        
        public dynamic GetNVsByCa_Date(int maCa, DateTime date) //lấy tất cả nhân viên làm trong ca và ngày đã cho
        {
            var s = cnn.Phan_cong.Where(p => p.Ma_ca == maCa && DbFunctions.TruncateTime(p.Ngay) == date.Date).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV }).ToList();
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
        public dynamic GetNVPC(DateTime ngay, int Ma_ca)// để hiển thị lên dgv nhân viên làm ca x và ngày y
        {
            var s = cnn.Phan_cong.Where(p => p.Ngay.Day == ngay.Day && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year && p.Ma_ca == Ma_ca).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV, p.Ngay }).ToList();
            return s;
        }
        public void SavePC(Phan_cong pc)
        {
            cnn.Phan_cong.AddOrUpdate(pc);
            cnn.SaveChanges();
        }
        public void DeletePC(int maCa, int maNV, DateTime ngay )
        {
            var p = cnn.Phan_cong.Find(maNV, maCa, ngay);
            cnn.Phan_cong.Remove(p);
            cnn.SaveChanges();
        }

        public List<Phan_cong> GetPhanCong(int maNV, int thang, int nam)
        {
            var listPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Month == thang && p.Ngay.Year == nam).ToList();//lấy ra tất cả ca làm việc của nhân viên óc maNV trong thời gian time
            return listPhanCong;
        }
        public List<Phan_cong> GetPhanCong(int maNV, DateTime ngay)
        {
            var listPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year).ToList();
            return listPhanCong;
        }
        public dynamic GetPhanCong(int maCa, int maNV, DateTime ngay)
        {
            var maPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Day == ngay.Day && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year && p.Ma_ca == maCa).Select(p => p).FirstOrDefault();
            return maPhanCong;
        }
        public dynamic ShowSearch(int maCa, string NV, DateTime ngay)
        {
            try
            {
                int maNV = Convert.ToInt32(NV);
                var s = cnn.Phan_cong.Where(p => p.Ma_ca == maCa && p.Ngay.Day == ngay.Day && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year && p.Ma_NV == maNV).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV }).ToList();
                return s;
            }
            catch (FormatException)
            {
                var s = cnn.Phan_cong.Where(p => p.Ma_ca == maCa && p.Ngay.Day == ngay.Day && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year && p.Tai_khoan.Nhan_vien.Ten_NV.Contains(NV)).Select(p => new { p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV }).ToList();
                return s;
            }
        }
    }
}
