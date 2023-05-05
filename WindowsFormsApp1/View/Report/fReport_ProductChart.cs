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
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fReport_ProductChart : Form
    {
        HoaDon hoaDonBLL = new HoaDon();
        ChiTietHoaDon chiTietHDBLL = new ChiTietHoaDon();
        SanPham sanPhamBLL = new SanPham();
        public fReport_ProductChart()
        {
            InitializeComponent();
            setCbbNam();
            cbbThang.SelectedIndex = 0;
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            Load(int.Parse(cbbThang.SelectedItem.ToString()), int.Parse(cbbNam.SelectedItem.ToString()));
        }

        private void btnSoLieu_Click(object sender, EventArgs e)
        {
            fReport_Product f = new fReport_Product();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
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
        public void Load(int thang, int nam)
        {
            bieuDoSP.Series.Clear();
            bieuDoSP.ChartAreas.Clear();
            bieuDoSP.ChartAreas.Add(new ChartArea());
            // Khởi tạo một đối tượng Series
            Series series = new Series();
            series.Name = "bdSanPham";
            series.ChartType = SeriesChartType.Pie;

            // Thêm các DataPoints vào Series
            List<int> listIDBill = hoaDonBLL.GetIDBill(thang, nam);
            Hashtable htPro = chiTietHDBLL.GetNumPro(listIDBill);
            
            foreach (DictionaryEntry entry in htPro)
            {
                series.Points.AddXY(sanPhamBLL.GetNamePro(Convert.ToInt32(entry.Key)), entry.Value);
            }
            
            // Thêm Series vào Chart
            bieuDoSP.Series.Add(series);

            // Hiển thị Chart trên form
            //this.Controls.Add(this.bieuDoSP);
            
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Load(int.Parse(cbbThang.SelectedItem.ToString()), int.Parse(cbbNam.SelectedItem.ToString()));
            
        }

       
    }
}
