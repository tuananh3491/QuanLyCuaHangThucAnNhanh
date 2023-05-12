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
        San_pham_DAL dal; 
        public San_phamBLL()
        {
            dal = new San_pham_DAL();
        }

        public List<San_pham> GetSPCategory(string s)
        {
            List<San_pham> lt = new List<San_pham>();
            foreach (var i in dal.GetAllSP())
            {
                if (i.Ma_loai1.Ten == s) lt.Add(i);
            }
            return lt;
        }
        public List<San_pham> GetListSP()
        {
            return dal.GetAllSP();

        }

        public San_pham FindSp(int MaSP)
        {
            var s = new PBL_3Entities().San_pham.Find(MaSP);
            if (s == null) return null;
            else return s;
        }
    }
}
