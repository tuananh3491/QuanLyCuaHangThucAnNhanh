using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Khach_hangBLL
    {
        Khack_hang_DAL dal;
        public Khach_hangBLL() 
        {
            dal = new Khack_hang_DAL();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = dal.GetAllKH();
            dg.Columns["Hoa_don"].Visible = false;
        }
        public Khach_hang getKH(string m)
        {
            return dal.GetKH(m);
        } 
    }
}
