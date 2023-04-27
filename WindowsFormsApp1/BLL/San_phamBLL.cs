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
        public List<San_pham> GetListSP()
        {
            return dal.GetAllSP();
        }
    }
}
