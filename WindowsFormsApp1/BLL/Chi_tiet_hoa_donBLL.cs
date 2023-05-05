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
    internal class Chi_tiet_hoa_donBLL
    {
        Chi_tiet_hoa_don_DAL dal;
        public Chi_tiet_hoa_donBLL()
        {
            dal = new Chi_tiet_hoa_don_DAL();
        }

        // viết các hàm cần dùng ở đây
        public void ShowDGV(DataGridView dg, List<Chi_tiet_hoa_don> ct)
        {
            dg.DataSource = ct;
            dg.Columns["Ma_HD"].Visible = false;
            dg.Columns["Hoa_don"].Visible = false;
            dg.Columns["San_pham"].Visible = false;
        }
    }
}
