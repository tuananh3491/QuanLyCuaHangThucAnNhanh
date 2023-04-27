using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Tai_khoanBLL
    {
        Tai_khoan_DAL dal;
        public Tai_khoanBLL() 
        {
            dal = new Tai_khoan_DAL();
        }
        public Tai_khoan GetTK(int m)
        {
            return dal.GetTK(m);
        }
        public void AddTK(Tai_khoan a)
        {
            dal.AddTK(a);
        }
        public void UpdateTK(Tai_khoan a)
        {
            dal.UpdateTK(a);
        }
        public void DeleteTK(Tai_khoan a)
        {
            dal.DeleteTK(a);
        }
    }
}
