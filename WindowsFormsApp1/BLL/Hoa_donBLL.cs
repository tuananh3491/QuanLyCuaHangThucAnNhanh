using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Hoa_donBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();
        //public List<Hoa_don> GetAllHD()
        //{
        //    var s = cnn.Hoa_don.ToList();
        //    return s;
        //}
        public List<int> GetListNam()
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var dsNam = cnn.Hoa_don.Select(p => p.Ngay_mua.Year).Distinct().ToList();
            return dsNam;
        }
        public List<Hoa_don> GetHD()
        {
            var s = cnn.Hoa_don.ToList();
            return s;
        }
        public dynamic GetHDsByMaKH(int Ma_KH)
        {
            var s = cnn.Hoa_don.Where(p => p.Ma_KH == Ma_KH).Select(p => new { p.Ma_HD, p.Tai_khoan.Nhan_vien.Ten_NV, p.Ngay_mua, p.Tong_tien, p.Trang_thai }).ToList();
            return s;
        }
        
        public dynamic GetHDByDate(DateTime date)
        {
            var s = cnn.Hoa_don.Where(p => DbFunctions.TruncateTime(p.Ngay_mua) == date.Date).Select(p => new { p.Ma_HD, p.Tai_khoan.Nhan_vien.Ten_NV, p.Khach_hang.Ten_KH, p.Ngay_mua, p.Tong_tien, p.Trang_thai }).ToList();
            return s;
        }
        public Hoa_don GetHDByMaHD(int Ma_hd)
        {
            var s = cnn.Hoa_don.Find(Ma_hd);
            return s;
        }
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
            PBL_3Entities cnn = new PBL_3Entities();
            var list = cnn.Hoa_don.Where(p => p.Ngay_mua.Year == nam && p.Ngay_mua.Month == thang);
            foreach (var i in list)
            {
                total += i.Tong_tien;
            }
            return total;
        }
        public List<int> GetIDBill(int thang, int nam)
        {
            List<int> listIDBill = new List<int>();
            PBL_3Entities cnn = new PBL_3Entities();
            var listBill = cnn.Hoa_don.Where(p => p.Ngay_mua.Year == nam && p.Ngay_mua.Month == thang).ToList();
            foreach (var i in listBill)
            {
                listIDBill.Add(Convert.ToInt32(i.Ma_HD));
            }
            return listIDBill;
        }
        //public int Add_HD(Hoa_don ca)// trả về mã hóa đơn sau khi add hóa đơn vào
        //{
        //    {
        //        cnn.Hoa_don.Add(ca);
        //        cnn.SaveChanges();
        //        int i = ca.Ma_HD;
        //        return i;
        //    }
        //}

        public void SaveHD(Hoa_don hd)
        {
            cnn.Hoa_don.AddOrUpdate(hd);
            cnn.SaveChanges();
        }
        public void DeleteHD(Hoa_don hd)
        {
            cnn.Hoa_don.Remove(hd);
            cnn.SaveChanges();
        }
       

        //public void ShowDGV(DataGridView dg, int maKH)
        //{
        //    dg.DataSource = GetHDsByMaKH(maKH);
        //    dg.Columns["Chi_tiet_hoa_don"].Visible = false;
        //    dg.Columns["Khach_hang"].Visible = false;
        //    dg.Columns["Tai_khoan"].Visible = false;
        //}
    }
}
