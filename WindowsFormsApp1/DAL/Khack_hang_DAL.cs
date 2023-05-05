using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Khack_hang_DAL
    {
        PBL_3Entities et;
        public Khack_hang_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Khach_hang> GetAllKH()
        {
            {
                var s = et.Khach_hang.ToList();
                return s;
            }
        }
        public Khach_hang GetKH(int m)
        {
            {
                var s = et.Khach_hang.Find(m);
                return s;
            }
        }
        public Khach_hang GetKH(string m)
        {
            {
                var s = et.Khach_hang.Where(p=>p.SDT==m).FirstOrDefault();
                return s;
            }
        }
        public void AddKH(Khach_hang ca)
        {
            {
                et.Khach_hang.Add(ca);
                et.SaveChanges();
            }
        }
        public void Updatekh(Khach_hang ca)
        {
            {
                et.Khach_hang.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
    }
}
