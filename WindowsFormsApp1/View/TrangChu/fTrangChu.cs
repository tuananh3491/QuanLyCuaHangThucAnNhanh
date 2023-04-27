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

namespace WindowsFormsApp1.View.TrangChu
{
    public partial class fTrangChu : Form
    {
        San_phamBLL bll;
        public fTrangChu()
        {
            InitializeComponent();
            bll = new San_phamBLL();
        }

        private void btnPizza_Click_1(object sender, EventArgs e)
        {
            flpnThucDon.Controls.Clear();
            San_phamBLL san_PhamBLL = new San_phamBLL();
            List<San_pham> l=new List<San_pham>();
            l=san_PhamBLL.GetSPCategory(btnPizza.Text);
            foreach(San_pham i in l)
            {
                flpnThucDon.Controls.Add(new panelMonAn(i));
            }
        }

        private void btnGa_Click(object sender, EventArgs e)
        {
            flpnThucDon.Controls.Clear();
            San_phamBLL san_PhamBLL = new San_phamBLL();
            List<San_pham> l = new List<San_pham>();
            l = san_PhamBLL.GetSPCategory(btnGa.Text);
            foreach (San_pham i in l)
            {
                flpnThucDon.Controls.Add(new panelMonAn(i));
            }
        }

        private void btnKhac_Click(object sender, EventArgs e)
        {
            flpnThucDon.Controls.Clear();
            San_phamBLL san_PhamBLL = new San_phamBLL();
            List<San_pham> l = new List<San_pham>();
            l = san_PhamBLL.GetSPCategory(btnKhac.Text);
            foreach (San_pham i in l)
            {
                flpnThucDon.Controls.Add(new panelMonAn(i));
            }
        }

        private void btnBurger_Click(object sender, EventArgs e)
        {
            flpnThucDon.Controls.Clear();
            San_phamBLL san_PhamBLL = new San_phamBLL();
            List<San_pham> l = new List<San_pham>();
            l = san_PhamBLL.GetSPCategory(btnBurger.Text);
            foreach (San_pham i in l)
            {
                flpnThucDon.Controls.Add(new panelMonAn(i));
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {   
            flpnOrder.Controls.Clear();
            Button p=new Button();
            flpnOrder.Controls.Add(p);
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            Bill f = new Bill();
            f.TopLevel = false;
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Clear();
            ((fMainform)Application.OpenForms["fMainform"]).pnForm.Controls.Add(f);
            f.Show();
        }
        private void fTrangChu_Load(object sender, EventArgs e)
        {
            foreach(var i in bll.GetListSP())
            {
                flpnThucDon.Controls.Add(new panelMonAn(i));
            }
        }
    }
}
