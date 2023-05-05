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
        public Khach_hang GetKHById(int m)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            //return cnn.Khach_hang.Where(p => p.Ma_KH == m).Select(p => p).FirstOrDefault();
            return cnn.Khach_hang.Find(m);
        }
        public Khach_hang GetKHByPhone(string phone)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            return cnn.Khach_hang.Where(p => p.SDT == phone).Select(p => p).FirstOrDefault();
            
        }
        public void ShowDGV(DataGridView dg)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            dg.DataSource = cnn.Khach_hang.ToList();
            dg.Columns["Hoa_don"].Visible = false;
        }
    }
}
