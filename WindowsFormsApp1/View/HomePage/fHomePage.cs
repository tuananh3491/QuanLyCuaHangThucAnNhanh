using Guna.UI2.WinForms;
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
using WindowsFormsApp1.View.Product;

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class fHomePage : Form
    {

        List<Chi_tiet_hoa_don> listCTHD = new List<Chi_tiet_hoa_don>();
        Ma_loaiBLL maLoaiBLL = new Ma_loaiBLL();
        San_phamBLL spBLL = new San_phamBLL();
        double tongtien = 0;
        public fHomePage()
        {
            InitializeComponent();
            setCbb();
        }
        public void setCbb()
        {
            List<Ma_loai> list = maLoaiBLL.GetAllML();
            foreach (Ma_loai item in list)
            {
                cbbLoai.Items.Add(item.Ten);
            }
        }
        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maLoai;
            maLoai = maLoaiBLL.GetIdCategory(((ComboBox)sender).Text);
            openPanel(maLoaiBLL.GetML(maLoai).Ten);
        }
        private void AddList(Chi_tiet_hoa_don t)
        {
            Edit("add", t);
            TinhTongTien();
            flpnOrder.Controls.Clear();
            foreach (var i in listCTHD)
            {
                panelOrder pn = new panelOrder(spBLL.GetPro(i.Ma_SP), i);
                flpnOrder.Controls.Add(pn);
                pn.callback += new panelOrder.update(this.UpdateList);
            }
        }

        private void UpdateList(Chi_tiet_hoa_don t)
        {
            Edit("update", t);
            TinhTongTien();
        }

        private void Edit(string st, Chi_tiet_hoa_don t) //thêm sửa xóa đều ở đây
        {
            tongtien = 0;
            var s = listCTHD.FirstOrDefault(x => x.Ma_SP == t.Ma_SP && x.Kich_thuoc == t.Kich_thuoc);
            if (s == null) { listCTHD.Add(t); } //thêm t
            else //sửa s
            {
                if (st == "update")
                {
                    s.Soluong_SP = t.Soluong_SP;
                    s.Gia = t.Gia;
                }
                if (st == "add")
                {
                    s.Soluong_SP += 1;
                    //s.Gia += t.Gia;
                }
            }
            var r = listCTHD.SingleOrDefault(x => x.Soluong_SP == 0); //xóa các phần tử có điều kiện trên
            listCTHD.Remove(r);
        }

        private void TinhTongTien()
        {
            foreach (Chi_tiet_hoa_don i in listCTHD)
            {
                tongtien += Convert.ToDouble(i.Gia*i.Soluong_SP);
            }
            txtTongTien.Text = string.Format("{0:#,##0} đ", tongtien).Replace(",", ".");
        }
        private void btn_Click(object sender, EventArgs e)
        {
                openPanel(((Guna2Button)sender).Text);
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            listCTHD.Clear();
            tongtien = 0;
            txtTongTien.Text = "0 đ";
            flpnOrder.Controls.Clear();
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            if (listCTHD.Count >0)
            {
                Bill f = new Bill(listCTHD, tongtien);
                Const.mainform.openChildForm(f, Const.mainform.pnForm);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món ăn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void openPanel(string loai)
        {
            flpnThucDon.Controls.Clear();
            List<San_pham> listSP = spBLL.GetSPCategory(loai);
            foreach (San_pham sp in listSP)
            {
                if (sp.Trang_thai == true)
                {
                    panelMonAn pnMon = new panelMonAn(sp);
                    flpnThucDon.Controls.Add(pnMon);
                    pnMon.Add += new panelMonAn.Edit(this.AddList);
                    pnMon.Update += new panelMonAn.Edit(this.UpdateList);
                }
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flpnThucDon.Controls.Clear();
                string ten = txtSearch.Text;

                foreach (San_pham sp in spBLL.GetSPByTen(ten))
                {
                    panelMonAn pnMon = new panelMonAn(sp);
                    flpnThucDon.Controls.Add(pnMon);
                }
            }
        }
    }
}
