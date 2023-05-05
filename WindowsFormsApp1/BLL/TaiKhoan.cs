using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    public class TaiKhoan
    {
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
