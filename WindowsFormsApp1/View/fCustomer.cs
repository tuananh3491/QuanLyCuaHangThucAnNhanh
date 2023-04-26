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

namespace WindowsFormsApp1.View
{
    public partial class fCustomer : Form
    {
        Khach_hangBLL bll;
        public fCustomer()
        {
            InitializeComponent();
            bll = new Khach_hangBLL();
        }



        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            fCustomer_Update f = new fCustomer_Update();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void btnViewHtr_Click(object sender, EventArgs e)
        {
            fCustomer_History f = new fCustomer_History();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();

        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            bll.ShowDGV(dataGridView);
        }
    }
 }

