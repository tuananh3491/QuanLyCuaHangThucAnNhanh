using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View.Product
{
    public partial class pnProduct : UserControl
    {
        public pnProduct()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnProduct_Update p=new pnProduct_Update();
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Clear();
            ((fProduct)Application.OpenForms["fProduct"]).pnChinhSua.Controls.Add(p);
         
        }
    }
}
