using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Phan_cong_DAL
    {
        PBL_3Entities et;
        public Phan_cong_DAL() 
        {
            et = new PBL_3Entities();
        }
        public List<Phan_cong> GetAllPC()
        {
            {
                var s = et.Phan_cong.ToList();
                return s;
            }
        }
        public List<Phan_cong> GetAllPC(int Ma_NV)
        {
            {
                var s = et.Phan_cong.Where(p => p.Ma_NV == Ma_NV).ToList();
                return s;
            }
        }
        public List<int> getMaNV(int Ma_ca)
        {
            var s = et.Phan_cong.Where(p => p.Ma_ca == Ma_ca).Select(p => p.Ma_NV).Distinct().ToList();
            return s;
        }
        public List<int> getMaCa()
        {
            var s = et.Phan_cong.Select(p => p.Ma_ca).Distinct().ToList();
            return s;
        }
        public dynamic GetNVPC(int Ma_ca)
        {
            {
                var s = et.Phan_cong.Where(p => p.Ma_ca == Ma_ca).Select(p => new {p.Ma_NV, p.Tai_khoan.Nhan_vien.Ten_NV}).ToList();
                return s;
            }
        }
        public void AddPC(Phan_cong pc)
        {
            {
                et.Phan_cong.Add(pc);
                et.SaveChanges();
            }
        }
        public void UpdatePC(Phan_cong pc)
        {
            {
                var p = et.Phan_cong.Find(pc);
                p.Ma_ca = pc.Ma_ca;
                p.Ma_NV = pc.Ma_NV;
                p.Ngay = DateTime.Today;
                et.SaveChanges();
            }
        }
        public void DeletePC(Phan_cong pc)
        {
            {
                var p = et.Phan_cong.Find(pc.Ma_NV, pc.Ma_ca);
                et.Phan_cong.Remove(p);
                et.SaveChanges();
            }
        }
    }
}
