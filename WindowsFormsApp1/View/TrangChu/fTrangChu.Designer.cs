﻿namespace WindowsFormsApp1.View.TrangChu
{
    partial class fTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTrangChu));
            this.pnChonMon = new System.Windows.Forms.Panel();
            this.flpnOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaoDon = new WindowsFormsApp1.CustomControl.VBButton();
            this.btnHuy = new WindowsFormsApp1.CustomControl.VBButton();
            this.tbTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flpnThucDon = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnKhac = new Guna.UI2.WinForms.Guna2Button();
            this.btnCombo = new Guna.UI2.WinForms.Guna2Button();
            this.btnKem = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnBurger = new Guna.UI2.WinForms.Guna2Button();
            this.btnGa = new Guna.UI2.WinForms.Guna2Button();
            this.btnPizza = new Guna.UI2.WinForms.Guna2Button();
            this.pnChonMon.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pnChonMon
            // 
            this.pnChonMon.BackColor = System.Drawing.SystemColors.Window;
            this.pnChonMon.Controls.Add(this.flpnOrder);
            this.pnChonMon.Controls.Add(this.btnTaoDon);
            this.pnChonMon.Controls.Add(this.btnHuy);
            this.pnChonMon.Controls.Add(this.tbTongTien);
            this.pnChonMon.Controls.Add(this.label2);
            this.pnChonMon.Controls.Add(this.label1);
            this.pnChonMon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnChonMon.Location = new System.Drawing.Point(584, 0);
            this.pnChonMon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnChonMon.Name = "pnChonMon";
            this.pnChonMon.Size = new System.Drawing.Size(363, 572);
            this.pnChonMon.TabIndex = 1;
            // 
            // flpnOrder
            // 
            this.flpnOrder.Location = new System.Drawing.Point(7, 86);
            this.flpnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnOrder.Name = "flpnOrder";
            this.flpnOrder.Size = new System.Drawing.Size(345, 367);
            this.flpnOrder.TabIndex = 5;
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnTaoDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnTaoDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaoDon.BorderRadius = 10;
            this.btnTaoDon.BorderSize = 0;
            this.btnTaoDon.FlatAppearance.BorderSize = 0;
            this.btnTaoDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoDon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoDon.ForeColor = System.Drawing.Color.White;
            this.btnTaoDon.Location = new System.Drawing.Point(211, 505);
            this.btnTaoDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoDon.Name = "btnTaoDon";
            this.btnTaoDon.Size = new System.Drawing.Size(109, 41);
            this.btnTaoDon.TabIndex = 4;
            this.btnTaoDon.Text = "Tạo đơn";
            this.btnTaoDon.TextColor = System.Drawing.Color.White;
            this.btnTaoDon.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnHuy.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnHuy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderSize = 0;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(27, 505);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 41);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextColor = System.Drawing.Color.White;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // tbTongTien
            // 
            this.tbTongTien.BackColor = System.Drawing.Color.White;
            this.tbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTongTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.tbTongTien.Location = new System.Drawing.Point(221, 455);
            this.tbTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTongTien.Multiline = true;
            this.tbTongTien.Name = "tbTongTien";
            this.tbTongTien.ReadOnly = true;
            this.tbTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTongTien.Size = new System.Drawing.Size(109, 22);
            this.tbTongTien.TabIndex = 2;
            this.tbTongTien.Text = "0đ";
            this.tbTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực đơn đã chọn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.btnKhac);
            this.panel2.Controls.Add(this.btnCombo);
            this.panel2.Controls.Add(this.btnKem);
            this.panel2.Controls.Add(this.btnNuoc);
            this.panel2.Controls.Add(this.btnBurger);
            this.panel2.Controls.Add(this.btnGa);
            this.panel2.Controls.Add(this.btnPizza);
            this.panel2.Controls.Add(this.flpnThucDon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 572);
            this.panel2.TabIndex = 6;
            // 
            // flpnThucDon
            // 
            this.flpnThucDon.Location = new System.Drawing.Point(3, 154);
            this.flpnThucDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpnThucDon.Name = "flpnThucDon";
            this.flpnThucDon.Size = new System.Drawing.Size(559, 391);
            this.flpnThucDon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thực đơn";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.imageThucDon1;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 121);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // btnKhac
            // 
            this.btnKhac.BorderRadius = 15;
            this.btnKhac.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhac.FillColor = System.Drawing.Color.White;
            this.btnKhac.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.ForeColor = System.Drawing.Color.Black;
            this.btnKhac.Image = ((System.Drawing.Image)(resources.GetObject("btnKhac.Image")));
            this.btnKhac.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKhac.Location = new System.Drawing.Point(365, 86);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.PressedColor = System.Drawing.Color.Silver;
            this.btnKhac.Size = new System.Drawing.Size(99, 36);
            this.btnKhac.TabIndex = 38;
            this.btnKhac.Text = "Khác";
            this.btnKhac.Click += new System.EventHandler(this.btnKhac_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.BorderRadius = 15;
            this.btnCombo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCombo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCombo.FillColor = System.Drawing.Color.White;
            this.btnCombo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.Color.Black;
            this.btnCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCombo.Image")));
            this.btnCombo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCombo.Location = new System.Drawing.Point(463, 44);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.PressedColor = System.Drawing.Color.Silver;
            this.btnCombo.Size = new System.Drawing.Size(99, 36);
            this.btnCombo.TabIndex = 37;
            this.btnCombo.Text = "Combo";
            // 
            // btnKem
            // 
            this.btnKem.BorderRadius = 15;
            this.btnKem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKem.FillColor = System.Drawing.Color.White;
            this.btnKem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKem.ForeColor = System.Drawing.Color.Black;
            this.btnKem.Image = ((System.Drawing.Image)(resources.GetObject("btnKem.Image")));
            this.btnKem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKem.Location = new System.Drawing.Point(243, 86);
            this.btnKem.Name = "btnKem";
            this.btnKem.PressedColor = System.Drawing.Color.Silver;
            this.btnKem.Size = new System.Drawing.Size(99, 36);
            this.btnKem.TabIndex = 36;
            this.btnKem.Text = "Kem";
            // 
            // btnNuoc
            // 
            this.btnNuoc.BorderRadius = 15;
            this.btnNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuoc.FillColor = System.Drawing.Color.White;
            this.btnNuoc.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.ForeColor = System.Drawing.Color.Black;
            this.btnNuoc.Image = ((System.Drawing.Image)(resources.GetObject("btnNuoc.Image")));
            this.btnNuoc.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNuoc.Location = new System.Drawing.Point(130, 85);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.PressedColor = System.Drawing.Color.Silver;
            this.btnNuoc.Size = new System.Drawing.Size(99, 36);
            this.btnNuoc.TabIndex = 34;
            this.btnNuoc.Text = "Nước";
            // 
            // btnBurger
            // 
            this.btnBurger.BorderRadius = 15;
            this.btnBurger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBurger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBurger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBurger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBurger.FillColor = System.Drawing.Color.White;
            this.btnBurger.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.ForeColor = System.Drawing.Color.Black;
            this.btnBurger.Image = ((System.Drawing.Image)(resources.GetObject("btnBurger.Image")));
            this.btnBurger.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBurger.Location = new System.Drawing.Point(356, 44);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.PressedColor = System.Drawing.Color.Silver;
            this.btnBurger.Size = new System.Drawing.Size(99, 36);
            this.btnBurger.TabIndex = 35;
            this.btnBurger.Text = "Burger";
            this.btnBurger.Click += new System.EventHandler(this.btnBurger_Click);
            // 
            // btnGa
            // 
            this.btnGa.BorderRadius = 15;
            this.btnGa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGa.FillColor = System.Drawing.Color.White;
            this.btnGa.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGa.ForeColor = System.Drawing.Color.Black;
            this.btnGa.Image = ((System.Drawing.Image)(resources.GetObject("btnGa.Image")));
            this.btnGa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnGa.Location = new System.Drawing.Point(251, 43);
            this.btnGa.Name = "btnGa";
            this.btnGa.PressedColor = System.Drawing.Color.Silver;
            this.btnGa.Size = new System.Drawing.Size(99, 36);
            this.btnGa.TabIndex = 33;
            this.btnGa.Text = "Gà";
            this.btnGa.Click += new System.EventHandler(this.btnGa_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BorderRadius = 15;
            this.btnPizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPizza.FillColor = System.Drawing.Color.White;
            this.btnPizza.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.Color.Black;
            this.btnPizza.Image = ((System.Drawing.Image)(resources.GetObject("btnPizza.Image")));
            this.btnPizza.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPizza.Location = new System.Drawing.Point(135, 43);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.PressedColor = System.Drawing.Color.Silver;
            this.btnPizza.Size = new System.Drawing.Size(99, 36);
            this.btnPizza.TabIndex = 32;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.Click += new System.EventHandler(this.btnPizza_Click_1);
            // 
            // fTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(947, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnChonMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTrangChu";
            this.Text = "fTrangChu";
            this.pnChonMon.ResumeLayout(false);
            this.pnChonMon.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnChonMon;
        private System.Windows.Forms.TextBox tbTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnHuy;
        private CustomControl.VBButton btnTaoDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flpnThucDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.FlowLayoutPanel flpnOrder;
        private Guna.UI2.WinForms.Guna2Button btnKhac;
        private Guna.UI2.WinForms.Guna2Button btnCombo;
        private Guna.UI2.WinForms.Guna2Button btnKem;
        private Guna.UI2.WinForms.Guna2Button btnNuoc;
        private Guna.UI2.WinForms.Guna2Button btnBurger;
        private Guna.UI2.WinForms.Guna2Button btnGa;
        private Guna.UI2.WinForms.Guna2Button btnPizza;
    }
}