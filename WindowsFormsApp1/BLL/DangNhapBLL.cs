using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    public class DangNhapBLL
    {
        public bool checkLogin(int ten, string mk)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mk);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);
            //            var list = hasData.ToList();
            List<Tai_khoan> list = new List<Tai_khoan>();
            DangNhapDAL dn = new DangNhapDAL();
            list = dn.getDsTaiKhoan();
            foreach (var i in list)
            {
                if (i.Ma_TK == ten && i.Mat_khau == mk)
                    return true;
            }
            return false;
        }
    }
}
