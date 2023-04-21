using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Khach_hangBLL
    {
        public List<Khach_hang> GetAllKH()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Khach_hang.ToList();
                return s;
            }
        }
        public Khach_hang GetKH(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Khach_hang.Find(m);
                return s;
            }
        }
        public void AddKH(Khach_hang ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Khach_hang.Add(ca);
                et.SaveChanges();
            }
        }
        public void Updatekh(Khach_hang ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Khach_hang.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
    }
}
