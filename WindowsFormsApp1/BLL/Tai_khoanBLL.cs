using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Tai_khoanBLL
    {
        PBL_3Entities et = new PBL_3Entities();

        public List<Tai_khoan> GetAllTK()
        {
            var s = et.Tai_khoan.ToList();
            return s;
        }
        public Tai_khoan GetTK(int m)
        {
            var s = et.Tai_khoan.Find(m);
            return s;
        }
        public dynamic Search(string search)
        {
            
            var tk = et.Tai_khoan.Where(p => (p.Ten_TK.Contains(search))).Select(p => new { p.Ma_TK, p.Ten_TK, p.Mat_khau, p.Loai_TK }).ToList();
            return tk;
        }

        public void SaveTK(Tai_khoan ca)
        {
            et.Tai_khoan.AddOrUpdate(ca);
            et.SaveChanges();
        }
        public void DeleteTK(Tai_khoan ca)
        {
            et.Tai_khoan.Remove(ca);
            et.SaveChanges();
        }
        public bool CheckLogin(int ten, string matKhau)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(matKhau);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //List<Tai_khoan> list = new List<Tai_khoan>();
            var dstk = et.Tai_khoan.Select(p => p);
            foreach (var i in dstk)
            {
                if (i.Ma_TK == ten && i.Mat_khau == matKhau)
                {
                    if (i.Nhan_vien.Trang_thai)
                    {
                        Const.taiKhoan = i;
                        Const.taiKhoan.Loai_TK = i.Loai_TK;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã bị vô hiệu hóa", "Cảnh báo", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
