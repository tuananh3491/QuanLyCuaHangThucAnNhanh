using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class San_pham_DAL
    {
        PBL_3Entities et;
        public San_pham_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<San_pham> GetAllSP()
        {
            {
                var s = et.San_pham.ToList();
                return s;
            }
        }
        public San_pham GetSP(int m)
        {
            {
                var s = et.San_pham.Find(m);
                return s;
            }
        }
        public void AddSP(San_pham ca)
        {
            {
                et.San_pham.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateSP(San_pham ca)
        {
            {
                et.San_pham.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteSP(San_pham ca)
        {
            {
                et.San_pham.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
