using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DAL
{
    internal class Hoa_don_DAL
    {
        PBL_3Entities et;
        public Hoa_don_DAL()
        {
            et = new PBL_3Entities();
        }
        public List<Hoa_don> GetAllHD()
        {
            {
                var s = et.Hoa_don.ToList();
                return s;
            }
        }
        public Hoa_don GetHD(int m)
        {
            {
                var s = et.Hoa_don.Find(m);
                return s;
            }
        }
        public void AddHD(Hoa_don ca)
        {
            {
                et.Hoa_don.Add(ca);
                et.SaveChanges();
            }
        }
        // lấy mã hóa đơn sau khi adđ cái sản phẩm ca vào
        public int Add_HD(Hoa_don ca)
        {
            {
                et.Hoa_don.Add(ca);
                et.SaveChanges();
                int i = ca.Ma_HD;
                return i;
            }
        }

        public void UpdateHD(Hoa_don ca)
        {
            {
                et.Hoa_don.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteHD(Hoa_don ca)
        {
            {
                et.Hoa_don.Remove(ca);
                et.SaveChanges();
            }
        }

    }
}
