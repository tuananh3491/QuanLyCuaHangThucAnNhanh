using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Nhan_vien_DAL
    {
        PBL_3Entities et;
        public Nhan_vien_DAL()
        {
            et = new PBL_3Entities();
        }

        public List<Nhan_vien> GetAllNV()
        {
            
                var s = et.Nhan_vien.ToList();
                return s;
            
        }
        public Nhan_vien GetNV(int m)
        {
           
                var s = et.Nhan_vien.Find(m);
                return s;
            
        }
        public Nhan_vien GetNV(string sdt)
        {
            var s = et.Nhan_vien.Where(p => p.SDT == sdt).FirstOrDefault();
            return s;
        }
        public void AddNV(Nhan_vien ca)
        {

            et.Nhan_vien.Add(ca);
            et.SaveChanges();
        }
        public int addNV(Nhan_vien ca)
        {
            et.Nhan_vien.Add(ca);
            et.SaveChanges();
            int i = ca.Ma_NV;
            return i;
        }
        public void UpdateNV(Nhan_vien ca)
        {
            var s = et.Nhan_vien.Find(ca.Ma_NV);
            s.Ten_NV = ca.Ten_NV;
            s.SDT = ca.SDT;
            s.Gioi_tinh = ca.Gioi_tinh;
            s.Ngay_sinh = ca.Ngay_sinh;
            s.SDT = ca.SDT;
            s.Luong = ca.Luong;
            s.Trang_thai = ca.Trang_thai;
            s.Tai_khoan.Ten_TK = ca.Tai_khoan.Ten_TK;
            s.Tai_khoan.Mat_khau = ca.Tai_khoan .Mat_khau;
            et.SaveChanges();
        }
        public void DeleteNV(Nhan_vien ca)
        {
            
                et.Nhan_vien.Remove(ca);
            
                et.SaveChanges();
           
        }
    }
}
