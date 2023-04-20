using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Hoa_donBLL
    {
        public List<Hoa_don> GetAllHD()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Hoa_don.ToList();
                return s;
            }
        }
        public Hoa_don GetHD(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Hoa_don.Find(m);
                return s;
            }
        }
        public void AddHD(Hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Hoa_don.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateHD(Hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Hoa_don.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteHD(Hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Hoa_don.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
