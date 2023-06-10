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
        
        public List<int> GetAllNamPC()//lấy tất cả năm có nhân viên làm việc
        {
            var s = cnn.Phan_cong.Select(p => p.Ngay.Year).Distinct().ToList();
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
        //để tính lương
        public double GetAllTime(int maNV, int thang, int nam)
        {
            double soGio = 0;
            var listCLV = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Month == thang && p.Ngay.Year == nam).Select(p => p.Ca_lam_viec).ToList();//lấy ra tất cả ca làm việc của nhân viên óc maNV trong thời gian time
            foreach(var ca in listCLV)
            {
                soGio += (ca.Thoigianketthuc - ca.Thoigianbatdau).TotalMinutes / 60 ;
            }
            return soGio;
        }
        public List<Phan_cong> GetPhanCong(int maNV, int thang, int nam)
        {
            var listPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Month == thang && p.Ngay.Year == nam).ToList();//lấy ra tất cả ca làm việc của nhân viên óc maNV trong thời gian time
            //foreach (var ca in listCLV)
            //{
            //    soGio += (ca.Thoigianketthuc - ca.Thoigianbatdau).TotalMinutes / 60;
            //}
            return listPhanCong;
        }
        public List<Phan_cong> GetPhanCong(int maNV, DateTime ngay)
        {
            var listPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year).ToList();
            //foreach (var ca in listCLV)
            //{
            //    soGio += (ca.Thoigianketthuc - ca.Thoigianbatdau).TotalMinutes / 60;
            //}
            return listPhanCong;
        }
        public dynamic GetPhanCong(int maCa, int maNV, DateTime ngay)////////////////? dynamic
        {
            var maPhanCong = cnn.Phan_cong.Where(p => p.Ma_NV == maNV && p.Ngay.Day == ngay.Day && p.Ngay.Month == ngay.Month && p.Ngay.Year == ngay.Year && p.Ma_ca == maCa).Select(p => p).FirstOrDefault();
            //{
            //    soGio += (ca.Thoigianketthuc - ca.Thoigianbatdau).TotalMinutes / 60;
            //}
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
