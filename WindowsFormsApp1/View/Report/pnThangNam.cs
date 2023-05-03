using System;
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

namespace WindowsFormsApp1
{
    public partial class pnThangNam : UserControl
    {
        
        
       
        public pnThangNam()
        {
            InitializeComponent();
            setCbbNam();
        }
        public void setCbbNam()
        {
            PBL_3Entities cnn = new PBL_3Entities();
            var dsNam = cnn.Hoa_don.Select(p => p.Ngay_mua.Value.Year).Distinct().ToList();
            foreach( int i in dsNam )
            {
                cbbNam.Items.Add(i);
            }
        }
        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public int getThang()
        {
            return Convert.ToInt32(cbbThang.SelectedItem);
        }
        public int getNam()
        {
            return Convert.ToInt32(cbbNam.SelectedItem);
        }
    }
}
