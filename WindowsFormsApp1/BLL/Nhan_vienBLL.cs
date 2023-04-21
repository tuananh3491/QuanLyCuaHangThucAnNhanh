using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Nhan_vienBLL
    {
        public List<Nhan_vien> GetAllNV()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Nhan_vien.ToList();
                return s;
            }
        }
        public Nhan_vien GetNV(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Nhan_vien.Find(m);
                return s;
            }
        }
        public void AddNV(Nhan_vien ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Nhan_vien.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateNV(Nhan_vien ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Nhan_vien.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteNV(Nhan_vien ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Nhan_vien.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
