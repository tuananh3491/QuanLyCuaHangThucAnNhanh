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
            var s = cnn.Khach_hang.Where(p => p.Ten_KH != null || p.SDT != null).ToList();
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
            return cnn.Khach_hang.Find(m);
        }
        public Khach_hang GetKHByPhone(string phone)
        {
            return cnn.Khach_hang.Where(p => p.SDT == phone).Select(p => p).FirstOrDefault();
        }
        public List<Khach_hang> SearchKHByPhone(string phone)
        {
            return cnn.Khach_hang.Where(p => p.SDT.Contains(phone)).Select(p => p).ToList();
        }
    }
}
