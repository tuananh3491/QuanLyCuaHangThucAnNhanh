using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;
using WindowsFormsApp1.View.Product;
using Application = System.Windows.Forms.Application;

namespace WindowsFormsApp1.View
{
    public partial class fReport_Customer : Form
    {
        Hoa_donBLL hoaDonBLL = new Hoa_donBLL();
        public fReport_Customer()
        {
            InitializeComponent();
            setCbbNam();
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            ShowDGV(int.Parse(cbbNam.SelectedItem.ToString()));
        }
        public void setCbbNam()
        {
            List<int> dsNam = hoaDonBLL.GetListNam();
            foreach (int i in dsNam)
            {
                cbbNam.Items.Add(i);
            }
        }
        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            fReport_CustomerChart f = new fReport_CustomerChart();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
        public void ShowDGV(int nam)
        {
            int thang;
            for (int i = 1; i < 13; i++)
            {
                thang = i;
                Hashtable MyHash = hoaDonBLL.GetAllMaKH(nam, thang);
                int n1 = 0, n2 = 0;

                foreach (DictionaryEntry x in MyHash)
                {
                    if (Convert.ToInt32(x.Value) == 1)
                    {
                        n2++;
                    }
                    else if (Convert.ToInt32(x.Value) > 1)
                    {
                        n1++;
                    }
                }
                dataGridView1.Rows.Add(i, "Tháng " + i + "/" + nam, n1, n2);
            }

        }
        private void iconDone_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            ShowDGV(int.Parse(cbbNam.SelectedItem.ToString()));
        }
    }
}
 