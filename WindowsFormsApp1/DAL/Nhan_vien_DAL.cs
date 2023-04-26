using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Nhan_vien_DAL
    {
        PBL_3Entities et;
        public Nhan_vien_DAL()
        {
            et = new PBL_3Entities();
        }

        public List<Nhan_vien> GetAllNV()
        {
            
                var s = et.Nhan_vien.ToList();
                return s;
            
        }
        public Nhan_vien GetNV(int m)
        {
           
                var s = et.Nhan_vien.Find(m);
                return s;
            
        }
        public void AddNV(Nhan_vien ca)
        {
            
                et.Nhan_vien.Add(ca);
                et.SaveChanges();
            
        }
        public void UpdateNV(Nhan_vien ca)
        {
            
                et.Nhan_vien.AddOrUpdate(ca);
                et.SaveChanges();
            
        }
        public void DeleteNV(Nhan_vien ca)
        {
            
                et.Nhan_vien.Remove(ca);
                et.SaveChanges();
           
        }
    }
}
