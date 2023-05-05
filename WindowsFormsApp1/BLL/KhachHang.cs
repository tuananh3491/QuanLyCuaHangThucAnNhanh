using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class KhachHang
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public Khach_hang GetKHById(int m)
        {
            
            //return cnn.Khach_hang.Where(p => p.Ma_KH == m).Select(p => p).FirstOrDefault();
            return cnn.Khach_hang.Find(m);
        }
        public int GetMaKHBySdt(string x)
        {
            var s = cnn.Khach_hang.Where(i => i.SDT == x).FirstOrDefault();
            return s.Ma_KH;
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = cnn.Khach_hang.ToList();
            dg.Columns["Hoa_don"].Visible = false;
        }
    }
}
