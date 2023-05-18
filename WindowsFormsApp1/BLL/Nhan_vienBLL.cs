using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public List<Nhan_vien> GetAllNV()//ko lấy chủ, chỉ lấy nv
        {
            var s = cnn.Nhan_vien.Where(p => p.Tai_khoan.Loai_TK == true).ToList();
            return s;

        }
        public List<int> GetAllMaNV()//ko lấy chủ, chỉ lấy nv
        {
            var s = cnn.Nhan_vien.Where(p => p.Tai_khoan.Loai_TK == true).Select(p => p.Ma_NV).ToList();
            return s;

        }
        public Nhan_vien GetNVByMa(int ma)
        {
            var s = cnn.Nhan_vien.Find(ma);
            return s;
        }
        public List<Nhan_vien> SearchNV(string search)
        {
            var s = cnn.Nhan_vien.Where(p => (p.SDT.Contains(search) || p.Ten_NV.Contains(search))).ToList();
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
            dg.Columns["Luong"].Visible = false;
            dg.Columns["Tai_khoan"].Visible = false;
        }
       
    }
}
