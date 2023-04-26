using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Ma_loai_DAL
    {
        PBL_3Entities et;
        public Ma_loai_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Ma_loai> GetAllML()
        {
          
            {
                var s = et.Ma_loai.ToList();
                return s;
            }
        }
        public Ma_loai GetML(int m)
        {
            {
                var s = et.Ma_loai.Find(m);
                return s;
            }
        }
        public void AddML(Ma_loai ca)
        {
            {
                et.Ma_loai.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateML(Ma_loai ca)
        {
            {
                et.Ma_loai.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteCLV(Ma_loai ca)
        {
            {
                et.Ma_loai.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
