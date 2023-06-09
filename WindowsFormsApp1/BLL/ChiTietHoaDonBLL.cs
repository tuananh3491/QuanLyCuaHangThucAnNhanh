﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.BLL
{
    internal class ChiTietHoaDonBLL
    {
        PBL_3Entities cnn = new PBL_3Entities();
        public List<Chi_tiet_hoa_don> GetAllCT(int m)
        {
            var s = cnn.Chi_tiet_hoa_don.Where(p => p.Ma_HD == m).ToList();
            return s;
        }
        public void AddList(List<Chi_tiet_hoa_don> list)
        {
            cnn.Chi_tiet_hoa_don.AddRange(list);
            cnn.SaveChanges();
        }
        public void SaveNV(Chi_tiet_hoa_don ct)
        {
            cnn.Chi_tiet_hoa_don.AddOrUpdate(ct);
            cnn.SaveChanges();
        }
        public void DeleteNV(Chi_tiet_hoa_don ca)
        {
            cnn.Chi_tiet_hoa_don.Remove(ca);
            cnn.SaveChanges();
        }
        public Hashtable GetNumPro(List<int> listIDBill)
        {
            PBL_3Entities cnn = new PBL_3Entities();
            int demLap;
            Hashtable htPro = new Hashtable();
            foreach (int id in listIDBill)
            {
                var listDetail = cnn.Chi_tiet_hoa_don.Where(p => p.Ma_HD == id).Select(p => p).ToList();
                foreach (var i in listDetail)
                {
                    if (htPro.ContainsKey(i.Ma_SP))
                    {
                        demLap = Convert.ToInt32(htPro[i.Ma_SP]);
                        demLap += i.Soluong_SP;
                        htPro[i.Ma_SP] = demLap;
                    }
                    else
                    {
                        htPro.Add(i.Ma_SP, i.Soluong_SP);
                    }
                    
                }
            }
            return htPro;
        }
        public void ShowDGV(DataGridView dg, List<Chi_tiet_hoa_don> ct)
        {
            dg.DataSource = ct;
            dg.Columns["Ma_HD"].Visible = false;
            dg.Columns["Hoa_don"].Visible = false;
            dg.Columns["San_pham"].Visible = false;
        }
    }
}
