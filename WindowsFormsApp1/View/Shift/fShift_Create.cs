using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using WindowsFormsApp1.DAL;

namespace WindowsFormsApp1.View
{
    public partial class fShift_Create : Form
    {
        Ca_lam_viecBLL clvBLL = new Ca_lam_viecBLL();
        public fShift_Create()
        {
            InitializeComponent();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan batdau = TimeSpan.Parse(dateTimePicker1.Text);
                TimeSpan ketthuc = TimeSpan.Parse(dateTimePicker2.Text);
                if (txtName.Text == "") throw new SqlNullValueException();
                if (ketthuc.TotalSeconds - batdau.TotalSeconds > 0)
                {
                    Ca_lam_viec clv = new Ca_lam_viec()
                    {
                        Ten_ca = txtName.Text,
                        Thoigianbatdau = batdau,
                        Thoigianketthuc = ketthuc,
                    };
                    clvBLL.SaveCLV(clv);
                    MessageBox.Show("Tạo ca thành công");
                    fShift f = new fShift();
                    Const.mainform.openChildForm(f, Const.mainform.pnForm);
                }
                else MessageBox.Show("Thời gian không phù hợp.", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("TÊN RỖNG KHÔNG HỢP LỆ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            fShift f = new fShift();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }
    }
}