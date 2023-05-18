using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class San_phamBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public List<San_pham> GetAllSP()
        {
            var s = cnn.San_pham.ToList();
            return s;
        }
        public San_pham GetPro(int maSP)
        {
            var s = cnn.San_pham.Find(maSP);
            return s;
        }
        public void SaveSP(San_pham sp)
        {
            cnn.San_pham.AddOrUpdate(sp);
            cnn.SaveChanges();
        }
        public void DeleteSP(San_pham sp)
        {
            cnn.San_pham.Remove(sp);
            cnn.SaveChanges();
        }

        public List<San_pham> GetSPCategory(string s)//lấy sp theo tên loại
        {
            List<San_pham> lt = new List<San_pham>();
            foreach (var i in GetAllSP())
            {
                if (i.Ma_loai1.Ten == s) lt.Add(i);
            }
            return lt;
        }

        public string GetNamePro(int idPro)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var x = cnn.San_pham.Where(p => p.Ma_SP == idPro).FirstOrDefault();
            return x.Ten_SP;
        }

        public List<San_pham> GetProOfType(int idType)//lấy danh sách sản phẩm dựa vào mã loại
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var l = cnn.San_pham.Where(p => p.Ma_loai == idType).ToList();
            return l;

        }
        public List<San_pham> GetSPByTen(string ten)
        {
            List<San_pham> listSP = cnn.San_pham.Where(p => p.Ten_SP.Contains(ten)).ToList();
            return listSP;  
        }
    }
}
