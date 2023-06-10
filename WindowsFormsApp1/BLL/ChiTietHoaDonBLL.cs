using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class ChiTietHoaDonBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public List<Chi_tiet_hoa_don> GetAllCT(int m)
        {
            var s = cnn.Chi_tiet_hoa_don.Where(p => p.Ma_HD == m).ToList();
            return s;
        }
        public void SaveCTHD(Chi_tiet_hoa_don ct)
        {
            cnn.Chi_tiet_hoa_don.AddOrUpdate(ct);
            cnn.SaveChanges();
        }
        public void DeleteCTHD(Chi_tiet_hoa_don ct)
        {
            cnn.Chi_tiet_hoa_don.Remove(ct);
            cnn.SaveChanges();
        }
        public Hashtable GetNumPro(List<int> listIDBill)
        {
            int demLap;
            Hashtable htPro = new Hashtable();
            foreach (int id in listIDBill)
            {
                var listDetail = cnn.Chi_tiet_hoa_don.Where(p => p.Ma_HD == id).Select(p => p).ToList();
                foreach (var i in listDetail)
                {
                    if (htPro.ContainsKey(i.Ma_SP))
                    {
                        demLap = Convert.ToInt32(htPro[i.Ma_SP]);
                        demLap += i.Soluong_SP;
                        htPro[i.Ma_SP] = demLap;
                    }
                    else
                    {
                        htPro.Add(i.Ma_SP, i.Soluong_SP);
                    }
                    
                }
            }
            return htPro;
        }
        
    }
}
