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
        //CBBItem cBBItem = new CBBItem();
        public fReport_Customer()
        {
            InitializeComponent();
            setCbbNam();
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            //ShowDGV(nam);
           
            ShowDGV(int.Parse(cbbNam.SelectedItem.ToString()));
        }
        public void setCbbNam()
        {
            //PBL_3Entities cnn = new PBL_3Entities();
            //var dsNam = cnn.Hoa_don.Select(p => p.Ngay_mua.Year).Distinct().ToList();
            List<int> dsNam = hoaDonBLL.GetListNam();
            foreach (int i in dsNam)
            {
                cbbNam.Items.Add(i);
            }
        }
        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            fReport_CustomerChart f = new fReport_CustomerChart();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
        public void ShowDGV(int nam)
        {
            int thang;
            //nam = int.Parse(cbbNam.SelectedItem.ToString());
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

     

        private void ccbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ccbLoc.SelectedIndex)
            {
                //case 0://ngày
                //    pnTGian.Controls.Clear();
                //    pnThangNam p = new pnThangNam();
                //    pnTGian.Controls.Add(p);
                //    thang = p.getThang();
                //    nam = p.getNam();
                //    break;
                //case 1://tháng
                //case 2://quý
                    //pnTGian.Controls.Clear();
                    //pnNam p2 = new pnNam();
                    //pnTGian.Controls.Add(p2);
                    //p2.d += new pnNam.MyDel(ShowDGV);
                    //break;
                //case 3://năm
                //    pnTGian.Controls.Clear();
                //    break;
            }
             
        }

        private void iconDone_Click(object sender, EventArgs e)
        {

            //dataGridView1.SelectAll();
            for(int i = 1; i <13; i++)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            
            //panel1.Controls.Clear();
            ShowDGV(int.Parse(cbbNam.SelectedItem.ToString()));
        }
    }
}
