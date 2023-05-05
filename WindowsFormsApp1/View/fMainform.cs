    using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.View.TrangChu;

namespace WindowsFormsApp1.View
{
    public partial class fMainform : Form
    {
        private IconButton currentBtn;
        private IconButton BtnChild;
        private Form activeForm;
        public fMainform()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            customizeDesig();
            ActivateButton(btnTrangChu);
            openChildForm(new fTrangChu(),pnForm);
            PhanQuyen();
        }
        public void PhanQuyen()
        {
            if ((bool)Const.taiKhoan.Loai_TK)
            {
                btnBaoCao.Enabled = false;
            }
        }
        //custom panelBaoCao
        private void customizeDesig()
        {
            panelBaoCao.Visible = false;
        }
        private void HidepanelBaoCao()
        {
            if (panelBaoCao.Visible == true)
            {
                panelBaoCao.Visible = false;
            }

        }
        private void showSubPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HidepanelBaoCao();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //btnExit,btnMinimize,btnMaximize
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else { WindowState = FormWindowState.Normal; }
        }
        //changeColor
        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(255, 138, 0);
            public static Color color2 = Color.FromArgb(255, 175, 81);

        }
        private void ActivateButtonPanel(object sender)
        {
            if (sender != null)
            {
                DisableButton(BtnChild);
                BtnChild = (IconButton)sender;
                BtnChild.BackColor = Color.FromArgb(255, 175, 81);
            }
        }
        private void ActivateButton(object sender)
        {
            if (sender != null)
            {
                DisableButton(currentBtn);
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(255, 138, 0);
            }
        }
        private void DisableButton(IconButton btn)
        {
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(255, 249, 242);
            }
        }
        //open form
        public void openChildForm(Form active, Panel p )
        {
            if (activeForm != null) { activeForm.Close(); }
            activeForm = active;
            active.TopLevel = false;
            active.FormBorderStyle = FormBorderStyle.None;
            active.Dock = DockStyle.Fill;
            p.Controls.Add(active);
            p.Tag = active;
            active.BringToFront();
            active.Show();
        }
        public void openChildForm1(Form active, Panel p)
        {
            p.Dispose();
            active.TopLevel = false;
            active.FormBorderStyle = FormBorderStyle.None;
            active.Dock = DockStyle.Fill;
            p.Controls.Add(active);
            p.Tag = active;
            active.BringToFront();
            active.Show();
        }



        //evenclick

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new TrangChu.fTrangChu(), pnForm);
            panelBaoCao.Visible = false;
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fStaff(), pnForm);
            panelBaoCao.Visible = false;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            showSubPanel(panelBaoCao);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fCustomer(), pnForm);
            panelBaoCao.Visible = false;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            panelBaoCao.Visible = false;
        }

        private void btnCaLamViec_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fShift(), pnForm);
            panelBaoCao.Visible = false;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fBill(), pnForm);
            panelBaoCao.Visible = false;
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new fProduct(), pnForm);
            panelBaoCao.Visible = false;
        }
        //btn cua panel bao cao

        private void btnBCKhachHang_Click(object sender, EventArgs e)
        {
            openChildForm(new fReport_Customer(), pnForm);
            ActivateButtonPanel(sender);
        }

        private void btnBCSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new fReport_Product(), pnForm);
            ActivateButtonPanel(sender);
        }

        private void btnBCDoanhThu_Click(object sender, EventArgs e)
        {
            openChildForm(new fReport_Revenue(), pnForm);
            ActivateButtonPanel(sender);
        }


    }
}
