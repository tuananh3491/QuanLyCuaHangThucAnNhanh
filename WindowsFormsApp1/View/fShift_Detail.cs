﻿using System;
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
        Phan_congBLL pcBLL = new Phan_congBLL();
        Nhan_vienBLL nvbll = new Nhan_vienBLL();
        int x;
        public fShift_Detail()
        {
            InitializeComponent();
        }
        public fShift_Detail(int x)
        {
            InitializeComponent();
            pcBLL = new Phan_congBLL();
            this.x = x;
            reload();
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if (Const.taiKhoan.Loai_TK)
            {
                groupBox1.Visible = false;
            }

        }
        private void fShift_Detail_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            pcBLL.ShowDGV(dataGridView1, x);
            cbbNV.Items.Clear();
            cbbNV.Items.AddRange(pcBLL.GetMaNV(x).ToArray());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker2.Value < DateTime.Today) throw new ArgumentException();
                pcBLL.SavePC(new Phan_cong
                {
                    Ma_ca = x,
                    Ma_NV = int.Parse(cbbNV.Text),
                    Ngay = dateTimePicker2.Value
                });
                reload();
            }
            catch (FormatException)
            {
                MessageBox.Show("NV BỊ TRỐNG", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("NGÀY LÀM VIỆC KHÔNG HỢP LỆ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                try
                {
                    pcBLL.DeletePC(new Phan_cong
                    {
                        Ma_ca = x,
                        Ma_NV = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()),
                    });
                    reload();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lỗi","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fShift f = new fShift();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }

        private void iconDone_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            pcBLL.ShowDGV(dataGridView1, dateTimePicker1.Value, x);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbTenNV.Text = nvbll.GetNVByMa(int.Parse(cbbNV.Text)).Ten_NV;
        }
    }
}
