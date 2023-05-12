using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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
            PBL_3Entities cnn = new PBL_3Entities();
            var dstk = cnn.Tai_khoan.Select(p => p);
            foreach (var i in dstk)
            {
                if (i.Ma_TK == ten && i.Mat_khau == matKhau)
                {
                    Const.taiKhoan = i;
                    Const.taiKhoan.Loai_TK = i.Loai_TK;
                    return true;
                }
            }
            return false;
        }
    }
}
