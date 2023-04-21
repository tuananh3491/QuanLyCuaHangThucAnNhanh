using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    public class DangNhapDAL
    {
        public List<Tai_khoan> getDsTaiKhoan()
        {

            List<Tai_khoan> dstk = new List<Tai_khoan>();
            using (var db = new PBL_3Entities())
            {
                var tb = from tk in db.Tai_khoan
                         select tk;
                foreach (var i in tb)
                {
                    Tai_khoan tk = new Tai_khoan();
                    tk.Ma_TK = i.Ma_TK;
                    tk.Ten_TK = i.Ten_TK;
                    tk.Mat_khau = i.Mat_khau;
                    tk.Loai_TK = i.Loai_TK;

                    dstk.Add(tk);
                }
            }
            return dstk;
        }
    }
}
