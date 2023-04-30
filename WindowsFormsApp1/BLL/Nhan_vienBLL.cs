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
    internal class Nhan_vienBLL
    {
        Nhan_vien_DAL dal;
        public Nhan_vienBLL()
        {
            dal = new Nhan_vien_DAL();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = dal.GetAllNV();
            dg.Columns["Tai_khoan"].Visible = false;
        }
        public Nhan_vien GetNV(int NV)
        {
            return dal.GetNV(NV);
        }
        public Nhan_vien GetNV(string s)
        {
            return dal.GetNV(s);
        }
        public void AddNV(Nhan_vien nv)
        {
            dal.AddNV(nv);
        }
        public int addNV(Nhan_vien nv)
        {
            return dal.addNV(nv);
        }
        public void UpdateNV(Nhan_vien nv)
        {
            dal.UpdateNV(nv);
        }
        public void DeleteNV(Nhan_vien nv)
        {
            dal.DeleteNV(nv);
        }
    }
}
