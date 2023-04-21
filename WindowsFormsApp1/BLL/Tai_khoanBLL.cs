using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Tai_khoanBLL
    {
        public List<Tai_khoan> GetAllTK()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Tai_khoan.ToList();
                return s;
            }
        }
        public Tai_khoan GetTK(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Tai_khoan.Find(m);
                return s;
            }
        }
        public void AddNV(Tai_khoan ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Tai_khoan.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateNV(Tai_khoan ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Tai_khoan.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteNV(Tai_khoan ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Tai_khoan.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
