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
    public partial class fReport_CustomerChart : Form
    {
        HoaDon hoaDonBLL = new HoaDon();
        public fReport_CustomerChart()
        {
            InitializeComponent();
            setCbbNam();
            cbbNam.SelectedIndex = cbbNam.Items.Count - 1;
            //cbbNam.SelectedIndex = 0;
            Load(int.Parse(cbbNam.SelectedItem.ToString()));
        }

        private void btnSoLieu_Click(object sender, EventArgs e)
        {
            fReport_Customer f = new fReport_Customer();
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
        public void Load(int nam)
        {
            //int thang;

            //for (int i = 1; i < 13; i++)
            //{
            //    thang = i;
            //    Hashtable MyHash = hoaDonBLL.GetAllMaKH(nam, thang);
            //    int n1 = 0, n2 = 0;

            //    foreach (DictionaryEntry x in MyHash)
            //    {
            //        if (Convert.ToInt32(x.Value) == 1)
            //        {
            //            n2++;
            //        }
            //        else if (Convert.ToInt32(x.Value) > 1)
            //        {
            //            n1++;
            //        }
            //    }
            //    bieuDoKH.Series[0].Points.Add(n1);
            //    bieuDoKH.Series[0].Points[0].Label = n1.ToString();
            //    bieuDoKH.Series[0].Points[0].AxisLabel = i.ToString();

            //    bieuDoKH.Series[1].Points.Add(n2);
            //    bieuDoKH.Series[1].Points[0].Label = n2.ToString();
            //    bieuDoKH.Series[1].Points[0].AxisLabel = i.ToString();
            //}

            //bieuDoKH.Series.Clear();
            //bieuDoKH.ChartAreas.Clear();
            //bieuDoKH.ChartAreas.Add(new ChartArea());
            //Series series1 = new Series();
            //Series series2 = new Series();
            //series1.Name = "Số khách hàng quay trở lại quán";
            //series2.Name = "Số khách hàng mua lần đầu";


            //int thang;

            //for (int i = 1; i < 13; i++)
            //{
            //    thang = i;
            //    Hashtable MyHash = hoaDonBLL.GetAllMaKH(nam, thang);
            //    int n1 = 0, n2 = 0;

            //    foreach (DictionaryEntry x in MyHash)
            //    {
            //        if (Convert.ToInt32(x.Value) == 1)
            //        {
            //            n2++;
            //        }
            //        else if (Convert.ToInt32(x.Value) > 1)
            //        {
            //            n1++;
            //        }
            //    }
            //    series1.Points.AddXY(i, n1);
            //    series1.Points[i].Label = n1.ToString();
            //    series2.Points.AddXY(i, n2);
            //    series1.Points[i].Label = n1.ToString();
            //}
            //// Thiết lập kiểu biểu đồ và dữ liệu
            //bieuDoKH.Series.Add(series1);
            //bieuDoKH.Series.Add(series2);
            //bieuDoKH.Series[0].ChartType = SeriesChartType.Column;
            //bieuDoKH.Series[0].CustomProperties = "DrawSideBySide=True";
            //bieuDoKH.Series[1].ChartType = SeriesChartType.Column;
            //bieuDoKH.Series[1].CustomProperties = "DrawSideBySide=True";
            //// Thiết lập các thuộc tính
            ////bieuDoKH.Titles.Add("BIỂU ĐỒ BÁO CÁO VỀ KHÁCH HÀNG");
            //bieuDoKH.ChartAreas[0].AxisX.Title = "Tháng";
            //bieuDoKH.ChartAreas[0].AxisY.Title = "Số lượng";

            bieuDoKH.Series.Clear();
            bieuDoKH.ChartAreas.Clear();
            bieuDoKH.ChartAreas.Add(new ChartArea());
            Series series1 = new Series();
            Series series2 = new Series();
            series1.Name = "Số khách hàng quay trở lại quán";
            series2.Name = "Số khách hàng mua lần đầu";
            series1.Color = Color.Goldenrod; series2.Color = Color.YellowGreen;


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
                series1.Points.AddXY(i, n1);
              
                series2.Points.AddXY(i, n2);
            }
            // Thiết lập kiểu biểu đồ và dữ liệu
            bieuDoKH.Series.Add(series1);
            bieuDoKH.Series.Add(series2);
            bieuDoKH.Series[0].ChartType = SeriesChartType.Column;
            bieuDoKH.Series[0].CustomProperties = "DrawSideBySide=True";
            bieuDoKH.Series[1].ChartType = SeriesChartType.Column;
            bieuDoKH.Series[1].CustomProperties = "DrawSideBySide=True";
            // Thiết lập các thuộc tính
            //bieuDoKH.Titles.Add("BIỂU ĐỒ BÁO CÁO VỀ KHÁCH HÀNG");
            bieuDoKH.ChartAreas[0].AxisX.Title = "Tháng";
            bieuDoKH.ChartAreas[0].AxisY.Title = "Số lượng";
        }

    
        private void iconPictureBox1_Click_1(object sender, EventArgs e)
        {
            Load(int.Parse(cbbNam.SelectedItem.ToString()));
        }
    }
}
