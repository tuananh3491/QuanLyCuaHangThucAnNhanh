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
                et.Phan_cong.AddOrUpdate(pc);
                et.SaveChanges();
            }
        }
        public void DeletePC(Phan_cong pc)
        {
            {
                et.Phan_cong.Remove(pc);
                et.SaveChanges();
            }
        }
    }
}
