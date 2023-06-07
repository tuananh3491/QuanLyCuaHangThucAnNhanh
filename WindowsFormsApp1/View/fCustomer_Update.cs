﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
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
    public partial class fCustomer_Update : Form
    {
        public int maKH;
        Khach_hangBLL khBLL = new Khach_hangBLL();
        public fCustomer_Update(int m)
        {
            InitializeComponent();
            maKH = m;
            Load(m);
        }
        public void Load(int m)
        {
            var kh = khBLL.GetKHById(m);
            txtMaKH.Text = kh.Ma_KH.ToString();
            txtMaKH.Enabled = false;
            txtTenKH.Text = kh.Ten_KH.ToString();
            txtTenKH.Enabled = false;
            txtSDT.Text = kh.SDT.ToString();
            txtDiemTL.Text = kh.Diem_tich_luy.ToString();
            txtDiemTL.Enabled = false;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKH.Text == "") throw new SqlNullValueException();
                int.Parse(txtSDT.Text);
                Khach_hang kh = khBLL.GetKHById(maKH);
                if (kh.SDT != txtSDT.Text)
                {
                    kh.SDT = txtSDT.Text.ToString();
                    khBLL.SaveKH(kh);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn muốn giữ số điện thoại cũ?", "Hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
            }
            catch (DbEntityValidationException)
            {
                MessageBox.Show("Số điện thoại không hơp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số điện thọa không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlNullValueException)
            {
                MessageBox.Show("Tên rộng không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSDT.Text = "";
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fCustomer f = new fCustomer();
            Const.mainform.openChildForm(f, Const.mainform.pnForm);
        }

    }
}
