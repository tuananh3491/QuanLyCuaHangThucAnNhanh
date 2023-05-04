using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class ChiTietHoaDon
    {
        public Hashtable GetNumPro(List<int> listIDBill)
        {
            PBL_3Entities cnn = new PBL_3Entities();
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
