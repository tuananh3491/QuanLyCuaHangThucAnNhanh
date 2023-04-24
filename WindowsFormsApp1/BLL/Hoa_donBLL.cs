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
    internal class Hoa_donBLL
    {
        Hoa_don_DAL dal;
        public Hoa_donBLL()
        {
            dal = new Hoa_don_DAL();
        }

        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = dal.GetAllHD();
            dg.Columns["Chi_tiet_hoa_don"].Visible = false;
            dg.Columns["Khach_hang"].Visible = false;
            dg.Columns["Tai_khoan"].Visible = false;
        }
    }
}
