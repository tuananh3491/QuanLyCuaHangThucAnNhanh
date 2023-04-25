using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Ma_loaiBLL
    {
        public List<Ma_loai> GetAllML()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Ma_loai.ToList();
                return s;
            }
        }
        public Ma_loai GetML(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Ma_loai.Find(m);
                return s;
            }
        }
        public Ma_loai GetML_Category(string m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Ma_loai.Find(m);
                return s;
            }
        }
        public void AddML(Ma_loai ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Ma_loai.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateML(Ma_loai ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Ma_loai.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteCLV(Ma_loai ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Ma_loai.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
