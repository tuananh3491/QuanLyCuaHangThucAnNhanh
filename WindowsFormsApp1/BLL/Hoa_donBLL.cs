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
    internal class Hoa_donBLL
    {
        Hoa_don_DAL dal;
        Chi_tiet_hoa_don_DAL dal1;
        public Hoa_donBLL()
        {
            dal = new Hoa_don_DAL();
            dal1 = new Chi_tiet_hoa_don_DAL();
        }

        public void ShowDGV(DataGridView dg)
        {
            dg.DataSource = dal.GetHD();
            
        }

        public void ShowDGV(DataGridView dg, int index)
        {
            dg.DataSource = dal.GetHDs(index);
            dg.Columns["Chi_tiet_hoa_don"].Visible = false;
            dg.Columns["Khach_hang"].Visible = false;
            dg.Columns["Tai_khoan"].Visible = false;
        }

        public Hoa_don getHDBll(int s)
        {
            Hoa_don hd= new Hoa_don();
            hd=dal.GetHDDal(s);
            return hd;
        }
        public List<Chi_tiet_hoa_don> getALLCT(int s)
        {
            return dal1.GetAllCT(s);
        }
        
        public int Add_HD(Hoa_don x)
        {
            return dal.Add_HD(x);

        }
    }
}
