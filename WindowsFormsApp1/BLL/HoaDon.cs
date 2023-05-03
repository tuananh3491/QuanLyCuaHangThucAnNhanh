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
        public Hashtable GetAllMaKH(int nam, int thang)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            int demLap;
            Hashtable htMaKH = new Hashtable();
            var MaKHInTime = cnn.Hoa_don.Where(p => p.Ngay_mua.Value.Year == nam && p.Ngay_mua.Value.Month == thang).Select(p => new { p.Ma_KH }).ToList();
            var MaKHByTime = cnn.Hoa_don.Where(p => p.Ngay_mua.Value.Year < nam || p.Ngay_mua.Value.Year == nam && p.Ngay_mua.Value.Month <= thang).Select(p => new { p.Ma_KH }).ToList();

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
        
    }
}
