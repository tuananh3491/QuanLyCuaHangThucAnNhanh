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
        Hoa_donBLL hoaDonBLL = new Hoa_donBLL();
        ChiTietHoaDonBLL chiTietHDBLL = new ChiTietHoaDonBLL();
        San_phamBLL sanPhamBLL = new San_phamBLL();
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
            foreach (int i in hoaDonBLL.GetListNam())
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
            int i = 0;
            foreach (DictionaryEntry entry in htPro)
            {
                //series.Points.AddXY(sanPhamBLL.GetNamePro(Convert.ToInt32(entry.Key)), entry.Value);
                //// Thêm các giá trị và tỉ lệ vào biểu đồ
                series.Points.Add(Convert.ToDouble(entry.Value));
                //// Đặt tên cho các phần trên biểu đồ
                series.Points[i].LegendText = sanPhamBLL.GetNamePro(Convert.ToInt32(entry.Key));
                i++;

            }
            series.Label = "#PERCENT{P0}";// Định dạng để hiển thị phần trăm

            // Thêm Series vào Chart
            bieuDoSP.Series.Add(series);
            
            // Hiển thị Chart trên form
            //this.Controls.Add(this.bieuDoSP);

        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            Load(int.Parse(cbbThang.SelectedItem.ToString()), int.Parse(cbbNam.SelectedItem.ToString()));
            
        }

       
    }
}
