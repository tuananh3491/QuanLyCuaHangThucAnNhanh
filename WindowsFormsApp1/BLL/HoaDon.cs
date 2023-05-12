using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class HoaDon
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public Hashtable GetAllMaKH(int nam, int thang)
        {
            
            int demLap;
            Hashtable htMaKH = new Hashtable();
            var MaKHInTime = cnn.Hoa_don.Where(p => p.Ngay_mua.Year == nam && p.Ngay_mua.Month == thang).Select(p => new { p.Ma_KH }).ToList();
            var MaKHByTime = cnn.Hoa_don.Where(p => p.Ngay_mua.Year < nam || p.Ngay_mua.Year == nam && p.Ngay_mua.Month <= thang).Select(p => new { p.Ma_KH }).ToList();

            foreach (var d in MaKHByTime)
            {
                if (MaKHInTime.Contains(d))
                {
                    if (htMaKH.ContainsKey(d))
                    {
                        demLap = Convert.ToInt32(htMaKH[d]);
                        demLap += 1;
                        htMaKH[d] = demLap;
                    }
                    else
                    {
                        htMaKH.Add(d, 1);
                    }
                }
            }
            return htMaKH;
        }
        public double GetTotalMoney(int thang, int nam)
        {
            double total = 0;
            
            var list = cnn.Hoa_don.Where(p => p.Ngay_mua.Year == nam && p.Ngay_mua.Month == thang);
            foreach(var i in list) 
            { 
                total += i.Tong_tien; 
            }   
            return total;
        }
        public List<int> GetIDBill(int thang, int nam)
        {
            List<int> listIDBill = new List<int>();
            
            var listBill = cnn.Hoa_don.Where(p => p.Ngay_mua.Year == nam && p.Ngay_mua.Month == thang).ToList();
            foreach(var i in listBill)
            {
                listIDBill.Add(Convert.ToInt32(i.Ma_HD));
            }
            return listIDBill;
        }
        
    }
}
