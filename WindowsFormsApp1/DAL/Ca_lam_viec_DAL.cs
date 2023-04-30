using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Ca_lam_viec_DAL
    {
        PBL_3Entities et;
        public Ca_lam_viec_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Ca_lam_viec> GetAllCLV()
        {
            
                var s = et.Ca_lam_viec.ToList();
                return s;
            
        }
        public Ca_lam_viec GetCLV(int m)
        {
            
                var s = et.Ca_lam_viec.Find(m);
                return s;
            
        }
        public void AddCLV(Ca_lam_viec ca)
        {
           
                et.Ca_lam_viec.Add(ca);
                et.SaveChanges();
           
        }
        public void UpdateCLV(Ca_lam_viec ca)
        {
            
                et.Ca_lam_viec.AddOrUpdate(ca);
                et.SaveChanges();
            
        }
        public void DeleteCLV(Ca_lam_viec ca)
        {
            
            
                et.Ca_lam_viec.Remove(ca);
                et.SaveChanges();
            
        }
    }
}
