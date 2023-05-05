using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class MaLoai
    {
        public int GetIdCategory(string name)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.Ma_loai.Where(p => p.Ten.Contains(name)).FirstOrDefault();
            return x.Ma_loai1;
        }
        public List<Ma_loai> GetListCategory()
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.Ma_loai.Select(p => p).ToList();
            return x;
        }
    }
}
