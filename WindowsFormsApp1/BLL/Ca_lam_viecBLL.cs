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
        PBL_3Entities et;
        public Ca_lam_viecBLL()
        {
            et = new PBL_3Entities();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = GetAllCLV();
            dg.Columns["Phan_cong"].Visible = false;
        }
        
        public List<Ca_lam_viec> GetAllCLV()
        {

            var s = et.Ca_lam_viec.ToList();
            return s;

        }
        public Ca_lam_viec GetCLV(int m)
        {

            var s = et.Ca_lam_viec.Find(m);
            return s;

        }
        public void AddCLV(Ca_lam_viec ca)
        {

            et.Ca_lam_viec.AddOrUpdate(ca);
            et.SaveChanges();

        }
        public void UpdateCLV(Ca_lam_viec ca)
        {
            var s = et.Ca_lam_viec.Find(ca);
            s.Ma_ca = ca.Ma_ca;
            s.Ten_ca = ca.Ten_ca;
            s.Thoigianbatdau = ca.Thoigianbatdau;
            s.Thoigianketthuc = ca.Thoigianketthuc;
            et.SaveChanges();
        }
        public void DeleteCLV(Ca_lam_viec ca)
        {

            et.Ca_lam_viec.Remove(ca);
            et.SaveChanges();

        }
    }
}
