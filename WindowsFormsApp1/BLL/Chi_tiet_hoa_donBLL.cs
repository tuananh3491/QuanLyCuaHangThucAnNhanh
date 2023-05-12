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
    internal class Chi_tiet_hoa_donBLL
    {
        PBL_3Entities et;
        public Chi_tiet_hoa_donBLL()
        {
            et = new PBL_3Entities();
        }

        // viết các hàm cần dùng ở đây
        public void ShowDGV(DataGridView dg, List<Chi_tiet_hoa_don> ct)
        {
            dg.DataSource = ct;
            dg.Columns["Ma_HD"].Visible = false;
            dg.Columns["Hoa_don"].Visible = false;
            dg.Columns["San_pham"].Visible = false;
        }

        
        
        public List<Chi_tiet_hoa_don> GetAllCT(int m)
        {
            {
                var s = et.Chi_tiet_hoa_don.Where(p => p.Ma_HD == m).ToList();
                return s;
            }
        }

        public void AddCTHD(Chi_tiet_hoa_don ca)
        {
            {
                et.Chi_tiet_hoa_don.Add(ca);
                et.SaveChanges();
            }
        }
        public void UpdateNV(Chi_tiet_hoa_don ca)
        {
            {
                et.Chi_tiet_hoa_don.AddOrUpdate(ca);
                et.SaveChanges();
            }
        }
        public void DeleteNV(Chi_tiet_hoa_don ca)
        {
            {
                et.Chi_tiet_hoa_don.Remove(ca);
                et.SaveChanges();
            }
        }
    }
}
