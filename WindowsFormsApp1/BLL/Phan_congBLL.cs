using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Phan_congBLL
    {
        public List<Phan_cong> GetAllPC()
        {
            using (PBL_3Entities et =  new PBL_3Entities())
            {
                var s = et.Phan_cong.ToList();
                return s;
            }
        }
        public List<Phan_cong> GetAllPC(int Ma_NV)
        {
            using(PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Phan_cong.Where(p => p.Ma_NV == Ma_NV).ToList();
                return s;
            }
        }
        public void AddPC(Phan_cong pc)
        {
            using(PBL_3Entities et = new PBL_3Entities())
            {
                et.Phan_cong.Add(pc);
                et.SaveChanges();
            }
        }
        public void UpdatePC(Phan_cong pc)
        {
            using(PBL_3Entities et = new PBL_3Entities())
            {
                et.Phan_cong.AddOrUpdate(pc);
                et.SaveChanges();
            }
        }
        public void DeletePC(Phan_cong pc)
        {
            using(PBL_3Entities et = new PBL_3Entities())
            {
                et.Phan_cong.Remove(pc);
                et.SaveChanges();
            }
        }
    }
}
