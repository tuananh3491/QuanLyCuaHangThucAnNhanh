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

        PBL_3Entities cnn = new PBL_3Entities();
        public List<Nhan_vien> GetAllNV()
        {
            var s = cnn.Nhan_vien.ToList();
            return s;

        }
        public Nhan_vien GetNVByMa(int ma)
        {
            var s = cnn.Nhan_vien.Find(ma);
            return s;
        }
        public Nhan_vien GetNVBySDT(string sdt)
        {
            var s = cnn.Nhan_vien.Where(p => p.SDT == sdt).FirstOrDefault();
            return s;
        }
        public int AddNV(Nhan_vien nv)
        {
            cnn.Nhan_vien.Add(nv);
            cnn.SaveChanges();
            return nv.Ma_NV;
        }
        public void SaveNV(Nhan_vien nv)
        {
            cnn.Nhan_vien.AddOrUpdate(nv);
            cnn.SaveChanges();
        }
        public void DeleteNV(Nhan_vien ca)
        {
            cnn.Nhan_vien.Remove(ca);
            cnn.SaveChanges();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = GetAllNV();
            dg.Columns["Tai_khoan"].Visible = false;
        }
    }
}
