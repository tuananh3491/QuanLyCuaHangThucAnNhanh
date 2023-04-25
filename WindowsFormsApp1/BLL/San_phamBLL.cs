using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class San_phamBLL
    {
        public List<San_pham> GetAllSP()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.San_pham.ToList();
                return s;
            }
        }
        public San_pham GetSP(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.San_pham.Find(m);
                return s;
            }
        }
        public void AddSP(San_pham ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.San_pham.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateSP(San_pham ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.San_pham.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteSP(San_pham ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.San_pham.Remove(ca);
                et.SaveChanges();
            }
        }
        public List<San_pham> GetSPCategory(string s)
        {

            
            using(PBL_3Entities et=new PBL_3Entities())
            {
                var sp=et.San_pham.Where(p => p.Ma_loai1.Ten == s).ToList();
                return sp;
            }
            
        }
    }
}
