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

namespace WindowsFormsApp1.View
{
    public partial class fShift_Detail : Form
    {
        Phan_congBLL bll; int x;
        public fShift_Detail()
        {
            InitializeComponent();
            bll = new Phan_congBLL();
        }
        public fShift_Detail(int x)
        {
            InitializeComponent();
            bll = new Phan_congBLL();
            this.x = x;
            reload();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            fShift f = new fShift();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void fShift_Detail_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            bll.ShowDGV(dataGridView1, x);
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(bll.GetMaNV(x).ToArray());
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bll.AddPC(new Phan_cong
                {
                    Ma_ca = x,
                    Ma_NV = int.Parse(comboBox1.Text),
                    Ngay = DateTime.Today
                });
                reload();
            }
            catch (FormatException)
            {
                MessageBox.Show("NV BỊ TRỐNG");
            }
        }

        private void vbButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    bll.DeletePC(new Phan_cong
                    {
                        Ma_ca = x,
                        Ma_NV = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    });
                    reload();
                }
                catch (FormatException)
                {
                    MessageBox.Show("KKK");
                }
            }
        }
    }
}
