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
            var dsNam = cnn.Hoa_don.Select(p => p.Ngay_mua.Value.Year).Distinct().ToList();
            foreach (int i in dsNam)
            {
                cbbNam.Items.Add(i);
            }
        }
        public void Load(int nam)
        {
            bieuDoKH.Series.Clear();
            bieuDoKH.ChartAreas.Clear();
            bieuDoKH.ChartAreas.Add(new ChartArea());
            Series series1 = new Series();
            Series series2 = new Series();
            series1.Name = "Số khách hàng quay trở lại quán";
            series2.Name = "Số khách hàng mua lần đầu";


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

            bieuDoKH.ChartAreas[0].AxisX.Title = "Tháng";
            bieuDoKH.ChartAreas[0].AxisY.Title = "Số lượng";
        }

        
        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            Load(int.Parse(cbbNam.SelectedItem.ToString()));
        }
    }
}
