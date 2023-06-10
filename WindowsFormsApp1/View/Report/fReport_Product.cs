﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fReport_Product : Form
    {
        Hoa_donBLL hoaDonBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL chiTietHDBLL = new ChiTietHoaDonBLL();
        San_phamBLL sanPhamBLL = new San_phamBLL();
        public fReport_Product()
        {
            InitializeComponent();
            setCbbNam();
            cbbThang.SelectedIndex = 0;
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            ShowDGV(int.Parse(cbbThang.SelectedItem.ToString()),int.Parse(cbbNam.SelectedItem.ToString()));
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
        }
        public void setCbbNam()
        {
            foreach (int i in hoaDonBLL.GetListNam())
            {
                cbbNam.Items.Add(i);
            }
        }
        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            fReport_ProductChart f = new fReport_ProductChart();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
        public void ShowDGV(int thang,int nam)
        {
            List<int> listIDBill = hoaDonBLL.GetIDBill(thang,nam);
            Hashtable htPro = chiTietHDBLL.GetNumPro(listIDBill);
            
            foreach (DictionaryEntry x in htPro)
            {
                dataGridView1.Rows.Add( x.Key, sanPhamBLL.GetPro(Convert.ToInt32(x.Key)).Ten_SP, x.Value);
            }
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowDGV(int.Parse(cbbThang.SelectedItem.ToString()), int.Parse(cbbNam.SelectedItem.ToString()));
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }
    }
}
