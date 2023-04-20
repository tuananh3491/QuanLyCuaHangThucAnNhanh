using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Ca_lam_viecBLL
    {
        public List<Ca_lam_viec> GetAllCLV()
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Ca_lam_viec.ToList();
                return s;
            }
        }
        public Ca_lam_viec GetCLV(int m)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                var s = et.Ca_lam_viec.Find(m);
                return s;
            }
        }
        public void AddCLV(Ca_lam_viec ca)
        {
            using(PBL_3Entities et = new PBL_3Entities())
            {
                et.Ca_lam_viec.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateCLV(Ca_lam_viec ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Ca_lam_viec.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteCLV(Ca_lam_viec ca)
        {
            using (PBL_3Entities et = new PBL_3Entities())
            {
                et.Ca_lam_viec.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
