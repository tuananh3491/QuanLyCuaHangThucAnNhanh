using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Phan_congBLL
    {
        Phan_cong_DAL dal;
        public Phan_congBLL()
        {
            dal=new Phan_cong_DAL();
        }
        public void ShowDGV(DataGridView dg,int Ma_ca)
        {
            dg.DataSource = dal.GetNVPC(Ma_ca);
        }
    }
}
