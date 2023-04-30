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
        Ma_loai_DAL dal;
        public Ma_loaiBLL()
        {
            dal = new Ma_loai_DAL();
        }
        public List<Ma_loai> GetAllML()
        {

            {
                var s = dal.GetAllML();
                return s;
            }
        }
        public Ma_loai GetML(int m)
        {
            {
                var s = dal.GetML(m);
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
            {
                dal.AddML(ca);
            }
        }
        public void UpdateML(Ma_loai ca)
        {
            {
                dal.UpdateML(ca);
            }
        }
        public void DeleteCLV(Ma_loai ca)
        {
            {
                dal.DeleteCLV(ca);
            }
        }
    }
}
