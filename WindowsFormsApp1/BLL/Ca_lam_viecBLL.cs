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
        PBL_3Entities cnn = new PBL_3Entities();
        public List<Ca_lam_viec> GetAllCLV()
        {
            var s = cnn.Ca_lam_viec.ToList();
            return s;
        }
        public Ca_lam_viec GetCLV(int ma)
        {
            var s = cnn.Ca_lam_viec.Find(ma);
            return s;
        }
        public void SaveCLV(Ca_lam_viec ca)
        {
            cnn.Ca_lam_viec.AddOrUpdate(ca);
            cnn.SaveChanges();
        }
        public void DeleteCLV(Ca_lam_viec ca)
        {
            cnn.Ca_lam_viec.Remove(ca);
            cnn.SaveChanges();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = GetAllCLV();
            dg.Columns["Phan_cong"].Visible = false;
        }
    }
}
