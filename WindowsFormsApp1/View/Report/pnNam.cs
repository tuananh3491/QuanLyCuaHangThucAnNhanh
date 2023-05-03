using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View.Report
{
    public partial class pnNam : UserControl
    {
        public delegate void MyDel(int nam);
        public MyDel d {  get; set; }
        public pnNam()
        {
            InitializeComponent();
            setCbbNam();
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
        public int getNam()
        {
            
            return Convert.ToInt32(cbbNam.SelectedItem);
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            d(getNam());
        }
    }
}
