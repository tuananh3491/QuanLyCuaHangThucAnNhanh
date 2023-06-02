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
        Khach_hangBLL khBLL = new Khach_hangBLL();
        public fCustomer()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count == 1 )//chọn 1 ô 
            {
                if (dataGridView.SelectedRows[0].Cells[2].Value != null) //và sđt ko null(nếu null thì ko cho cập nhật thông tin)
                {
                    int m = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                    fCustomer_Update f = new fCustomer_Update(m);
                    Const.mainform.openChildForm(f, Const.mainform.pnForm);
                }
                else MessageBox.Show("Khách hàng này chưa xác minh", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Chỉ được chọn 1 khách hàng","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
        }

        private void btnViewHtr_Click(object sender, EventArgs e)
        {
            //if(dataGridView.SelectedRows.Count == 1)
            //{
            //    fCustomer_History f = new fCustomer_History(int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString()));
            //    f.TopLevel = false;
            //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            //    ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            //    f.Show();
            //}
            if (dataGridView.SelectedRows.Count == 1)
            {
                int m = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                fCustomer_History f = new fCustomer_History(m);
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
            else MessageBox.Show("Lỗi", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }
        private void fCustomer_Load(object sender, EventArgs e)
        {
            khBLL.ShowDGV(dataGridView);    
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridView.DataSource = khBLL.SearchKHByPhone(txtSearch.Text);
            }
        }

      
    }
 }

