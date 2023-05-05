using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public dynamic GetHD()
        {
            {
                var s = et.Hoa_don.Select(p => new { p.Ma_HD, p.Tai_khoan.Nhan_vien.Ten_NV, p.Khach_hang.Ten_KH, p.Ngay_mua, p.Tong_tien, p.Trang_thai }).ToList();
                return s;
            }
        }
        public List<Hoa_don> GetHDs(int Ma_KH)
        {
            var s = et.Hoa_don.Where(p => p.Ma_KH == Ma_KH).ToList();
            return s;
        }
        public Hoa_don GetHDDal(int Ma_hd)
        {
            var s = et.Hoa_don.Find(Ma_hd);
            return s;
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
