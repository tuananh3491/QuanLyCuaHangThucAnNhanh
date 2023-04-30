using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Hoa_don_DAL
    {
        PBL_3Entities et;
        public Hoa_don_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Hoa_don> GetAllHD()
        {
            {
                var s = et.Hoa_don.ToList();
                return s;
            }
        }
        public List<Hoa_don> GetHDs(int Ma_KH)
        {
            var s = et.Hoa_don.Where(p => p.Ma_KH == Ma_KH).ToList();
            return s;
        }
        public Hoa_don GetHD(int Ma_hd)
        {
            {
                var s = et.Hoa_don.Find(Ma_hd);
                return s;
            }
        }
        public void AddHD(Hoa_don ca)
        {
            {
                et.Hoa_don.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateHD(Hoa_don ca)
        {
            {
                et.Hoa_don.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteHD(Hoa_don ca)
        {
            {
                et.Hoa_don.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
