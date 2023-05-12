using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Khach_hangBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();

        public List<Khach_hang> GetAllKH()
        {
            var s = cnn.Khach_hang.ToList();
            return s;
        }
        public void SaveKH(Khach_hang kh)
        {
            cnn.Khach_hang.AddOrUpdate(kh);
            cnn.SaveChanges();
        }
        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = GetAllKH();
            dg.Columns["Hoa_don"].Visible = false;
        }
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
        
    }
}
