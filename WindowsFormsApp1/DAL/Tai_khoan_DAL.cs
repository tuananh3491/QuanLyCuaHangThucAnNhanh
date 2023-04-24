using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Tai_khoan_DAL
    {
        PBL_3Entities et;
        public Tai_khoan_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Tai_khoan> GetAllTK()
        {
            {
                var s = et.Tai_khoan.ToList();
                return s;
            }
        }
        public Tai_khoan GetTK(int m)
        {
            {
                var s = et.Tai_khoan.Find(m);
                return s;
            }
        }
        public void AddNV(Tai_khoan ca)
        {
            {
                et.Tai_khoan.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateNV(Tai_khoan ca)
        {
            {
                et.Tai_khoan.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteNV(Tai_khoan ca)
        {
            {
                et.Tai_khoan.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
