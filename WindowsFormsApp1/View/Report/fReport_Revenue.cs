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
    public partial class fReport_Revenue : Form
    {
        Hoa_donBLL hoadonBLL = new Hoa_donBLL();
        public fReport_Revenue()
        {
            InitializeComponent();
            SetCbbNam();
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            Load(int.Parse(cbbNam.SelectedItem.ToString()));
        }
        public void SetCbbNam()
        {
            foreach (int i in hoadonBLL.GetListNam())
            {
                cbbNam.Items.Add(i);
            }
        }
        public void Load(int nam)
        {
            // Tạo các loại dữ liệu trên biểu đồ
            Series series1 = new Series();
            series1.Name = "Doanh thu";

            // Thêm dữ liệu vào biểu đồ
            int thang;
            for (int i = 1; i < 13; i++)
            {
                thang = i;                
                series1.Points.AddXY(i, hoadonBLL.GetTotalMoney(thang, nam));
                
                if (hoadonBLL.GetTotalMoney(thang, nam) != 0) series1.Points[i - 1].Label = string.Format("{0:#,##0}", hoadonBLL.GetTotalMoney(thang, nam)).Replace(",", ".");
            }
            // Thiết lập kiểu biểu đồ và dữ liệu
            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            chart1.ChartAreas.Add(new ChartArea());
            chart1.Series.Add(series1);
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 3;
            chart1.Series[0].Color = Color.Goldenrod;

            // Thiết lập các thuộc tính
           // chart1.Titles.Add("Doanh số bán hàng theo từng quý trong năm");
            chart1.ChartAreas[0].AxisX.Title = "Tháng";
            chart1.ChartAreas[0].AxisY.Title = "Doanh thu (đồng)";
            // Định dạng hiển thị cho trục Y là tiền tệ
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:N0}".Replace(",",".");

            //
        }

        private void iconDone_Click(object sender, EventArgs e)
        {
            Load(int.Parse(cbbNam.SelectedItem.ToString()));
        }

    }
}
