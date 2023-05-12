using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Ma_loaiBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public List<Ma_loai> GetAllML()//GetListCategory
        {
            var s = cnn.Ma_loai.ToList();
            return s;
        }
        public Ma_loai GetML(int m)
        {
            var s = cnn.Ma_loai.Find(m);
            return s;
        }
        public void SaveML(Ma_loai loai)
        {
            cnn.Ma_loai.AddOrUpdate(loai);
            cnn.SaveChanges();
        }
        public void DeleteCLV(Ma_loai loai)
        {
            cnn.Ma_loai.Remove(loai);
            cnn.SaveChanges();
        }
        public int GetIdCategory(string name)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.Ma_loai.Where(p => p.Ten.Contains(name)).FirstOrDefault();
            return x.Ma_loai1;
        }
    }
}
