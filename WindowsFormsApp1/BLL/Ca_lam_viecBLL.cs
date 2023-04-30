using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Ca_lam_viecBLL
    {
        Ca_lam_viec_DAL dal;
        public Ca_lam_viecBLL()
        {
            dal = new Ca_lam_viec_DAL();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = dal.GetAllCLV();
            dg.Columns["Phan_cong"].Visible = false;
        }
        public Ca_lam_viec GetCLV(int m)
        {

            var s = dal.GetCLV(m);
            return s;

        }
        public void AddCLV(Ca_lam_viec ca)
        {

            dal.AddCLV(ca);

        }
        public void UpdateCLV(Ca_lam_viec ca)
        {

            dal.UpdateCLV(ca);

        }
        public void DeleteCLV(Ca_lam_viec ca)
        {
            dal.DeleteCLV(ca);
        }
    }
}
