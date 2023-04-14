using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.Product;

namespace WindowsFormsApp1.View
{
    public partial class fProduct : Form
    {
        public fProduct()
        {
            InitializeComponent();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            flpnMonAn.Controls.Clear();
            pnProduct p=new pnProduct();
            flpnMonAn.Controls.Add(p);
        }
    }
}
