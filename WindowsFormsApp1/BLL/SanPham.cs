using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class SanPham
    {
        public string GetNamePro(int idPro)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.San_pham.Where(p => p.Ma_SP == idPro).FirstOrDefault();
            return x.Ten_SP;
        }
    }
}
