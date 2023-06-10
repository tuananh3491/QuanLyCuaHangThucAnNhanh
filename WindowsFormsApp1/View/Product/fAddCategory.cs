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

namespace WindowsFormsApp1.View.Product
{
    public partial class fAddCategory : Form
    {
        Ma_loaiBLL maLoaiBLL;    
        public fAddCategory()
        {
            InitializeComponent();
            maLoaiBLL = new Ma_loaiBLL();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "" || txtUnit.Text == "")
            {
                MessageBox.Show("Lỗi","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {
                Ma_loai loai = new Ma_loai() 
                { 
                    Ten = txtName.Text,
                    DVT = txtUnit.Text,
                };
                maLoaiBLL.SaveML(loai);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtMa.Text = loai.Ma_loai1.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMa.Text = "";
            txtName.Text = "";
            txtUnit.Text = "";
        }
    }
}
