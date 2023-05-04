using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    class SanPham
    {
        public string GetNamePro(int idPro)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.San_pham.Where(p => p.Ma_SP == idPro).FirstOrDefault();
            return x.Ten_SP;
        }

        public San_pham GetPro(int idPro)//lấy sản phẩm dựa vào mã sản phẩm
        {
            PBL_3Entities cnn = new PBL_3Entities();
            San_pham l;
            l = cnn.San_pham.Where(p => p.Ma_SP == idPro).FirstOrDefault();
            return l;

        }
        public List<San_pham> GetProOfType(int idType)//lấy danh sách sản phẩm dựa vào mã loại
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var l = cnn.San_pham.Where(p => p.Ma_loai == idType).ToList();
            return l;

        }
    }
}
