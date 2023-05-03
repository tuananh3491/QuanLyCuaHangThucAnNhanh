using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class Phan_congBLL
    {
        Phan_cong_DAL dal;
        Nhan_vien_DAL bll;
        public Phan_congBLL()
        {
            dal = new Phan_cong_DAL();
            bll = new Nhan_vien_DAL();
        }
        public void ShowDGV(DataGridView dg,int Ma_ca)
        {
            dg.DataSource = dal.GetNVPC(Ma_ca);
        }
        public void AddPC(Phan_cong p)
        {
            dal.AddPC(p);
        }
        public void DeletePC(Phan_cong p)
        {
            dal.DeletePC(p);
        }
        public List<string> GetMaNV(int Ma_ca)
        {
            int t;
            List<string> list = new List<string>();
            foreach(var i in bll.GetAllNV())
            {
                t = 0;
                foreach (var j in dal.GetNVPC(Ma_ca))
                {
                    if (i.Ma_NV == j.Ma_NV) break;
                    else t++;
                }
                if (t >= dal.GetNVPC(Ma_ca).Count)
                {
                    list.Add(i.Ma_NV.ToString());
                }
            }
            return list;
        }
    }
}
