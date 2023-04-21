using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Chi_tiet_hoa_donBLL
    {
        public List<Chi_tiet_hoa_don> GetAllCT(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Chi_tiet_hoa_don.Where(p=> p.Ma_HD == m).ToList();
                return s;
            }
        }
        
        public void AddCTHD(Chi_tiet_hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Chi_tiet_hoa_don.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateNV(Chi_tiet_hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Chi_tiet_hoa_don.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteNV(Chi_tiet_hoa_don ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Chi_tiet_hoa_don.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
