using System;
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
            PBL_3Entities cnn = new PBL_3Entities();
            var dsNam = cnn.Hoa_don.Select(p => p.Ngay_mua.Year).Distinct().ToList();
            foreach (int i in dsNam)
            {
                cbbNam.Items.Add(i);
            }
        }

        private void btnBieuDo_Click(object sender, EventArgs e)
        {
            fReport_ProductChart f = new fReport_ProductChart();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
        public void ShowDGV(int thang,int nam)
        {
            List<int> listIDBill = hoaDonBLL.GetIDBill(thang,nam);
            Hashtable htPro = chiTietHDBLL.GetNumPro(listIDBill);
            
            int i = 1;
            foreach (DictionaryEntry x in htPro)
            {
                dataGridView1.Rows.Add(i, x.Key, sanPhamBLL.GetNamePro(Convert.ToInt32(x.Key)), x.Value);
                i++;
            }
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            while(dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(0);
            }

            //panel1.Controls.Clear();
            ShowDGV(int.Parse(cbbThang.SelectedItem.ToString()), int.Parse(cbbNam.SelectedItem.ToString()));
            dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Descending);
        }
    }
}
