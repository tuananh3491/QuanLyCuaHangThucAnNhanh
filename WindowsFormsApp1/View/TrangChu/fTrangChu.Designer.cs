namespace WindowsFormsApp1.View.TrangChu
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
            this.pnChonMon = new System.Windows.Forms.Panel();
            this.flpnOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaoDon = new WindowsFormsApp1.CustomControl.VBButton();
            this.btnHuy = new WindowsFormsApp1.CustomControl.VBButton();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCombo = new Guna.UI2.WinForms.Guna2Button();
            this.btnPizza = new Guna.UI2.WinForms.Guna2Button();
            this.btnGa = new Guna.UI2.WinForms.Guna2Button();
            this.btnBurger = new Guna.UI2.WinForms.Guna2Button();
            this.btnNuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnKem = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhac = new Guna.UI2.WinForms.Guna2Button();
            this.flpnThucDon = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
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
            this.pnChonMon.Controls.Add(this.txtTongTien);
            this.pnChonMon.Controls.Add(this.label2);
            this.pnChonMon.Controls.Add(this.label1);
            this.pnChonMon.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnChonMon.Location = new System.Drawing.Point(572, 0);
            this.pnChonMon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pnChonMon.Name = "pnChonMon";
            this.pnChonMon.Size = new System.Drawing.Size(375, 572);
            this.pnChonMon.TabIndex = 1;
            // 
            // flpnOrder
            // 
            this.flpnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.flpnOrder.AutoScroll = true;
            this.flpnOrder.BackColor = System.Drawing.Color.Transparent;
            this.flpnOrder.Location = new System.Drawing.Point(7, 54);
            this.flpnOrder.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flpnOrder.Name = "flpnOrder";
            this.flpnOrder.Size = new System.Drawing.Size(352, 385);
            this.flpnOrder.TabIndex = 5;
            // 
            // btnTaoDon
            // 
            this.btnTaoDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnTaoDon.Click += new System.EventHandler(this.btnTaoDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.BackColor = System.Drawing.Color.White;
            this.txtTongTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.txtTongTien.Location = new System.Drawing.Point(211, 455);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTongTien.Size = new System.Drawing.Size(109, 22);
            this.txtTongTien.TabIndex = 2;
            this.txtTongTien.Text = "0";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
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
            this.label1.Location = new System.Drawing.Point(21, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thực đơn đã chọn";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.panel2.Controls.Add(this.cbbLoai);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnCombo);
            this.panel2.Controls.Add(this.btnPizza);
            this.panel2.Controls.Add(this.btnGa);
            this.panel2.Controls.Add(this.btnBurger);
            this.panel2.Controls.Add(this.btnNuoc);
            this.panel2.Controls.Add(this.btnKem);
            this.panel2.Controls.Add(this.btnKhac);
            this.panel2.Controls.Add(this.flpnThucDon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 572);
            this.panel2.TabIndex = 6;
            // 
            // cbbLoai
            // 
            this.cbbLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(433, 85);
            this.cbbLoai.Margin = new System.Windows.Forms.Padding(0);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(112, 30);
            this.cbbLoai.TabIndex = 51;
            this.cbbLoai.Text = "Xem tất cả";
            this.cbbLoai.SelectedIndexChanged += new System.EventHandler(this.cbbLoai_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = global::WindowsFormsApp1.Properties.Resources.search;
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(4, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txtSearch.Location = new System.Drawing.Point(300, 136);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Tìm kiếm";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(225, 36);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnCombo
            // 
            this.btnCombo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCombo.BorderRadius = 10;
            this.btnCombo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCombo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCombo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCombo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCombo.FillColor = System.Drawing.Color.White;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.ForeColor = System.Drawing.Color.Black;
            this.btnCombo.Image = global::WindowsFormsApp1.Properties.Resources.SP_Combo;
            this.btnCombo.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCombo.Location = new System.Drawing.Point(325, 81);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(0);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(107, 34);
            this.btnCombo.TabIndex = 23;
            this.btnCombo.Text = "Combo";
            this.btnCombo.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.BorderRadius = 10;
            this.btnPizza.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPizza.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPizza.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPizza.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPizza.FillColor = System.Drawing.Color.White;
            this.btnPizza.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizza.ForeColor = System.Drawing.Color.Black;
            this.btnPizza.Image = global::WindowsFormsApp1.Properties.Resources.SP_Pizza;
            this.btnPizza.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPizza.Location = new System.Drawing.Point(140, 28);
            this.btnPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(87, 34);
            this.btnPizza.TabIndex = 22;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGa
            // 
            this.btnGa.BorderRadius = 10;
            this.btnGa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGa.FillColor = System.Drawing.Color.White;
            this.btnGa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGa.ForeColor = System.Drawing.Color.Black;
            this.btnGa.Image = global::WindowsFormsApp1.Properties.Resources.SP_chicken;
            this.btnGa.ImageSize = new System.Drawing.Size(25, 25);
            this.btnGa.Location = new System.Drawing.Point(231, 28);
            this.btnGa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGa.Name = "btnGa";
            this.btnGa.Size = new System.Drawing.Size(87, 34);
            this.btnGa.TabIndex = 21;
            this.btnGa.Text = "Gà";
            this.btnGa.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnBurger
            // 
            this.btnBurger.BorderRadius = 10;
            this.btnBurger.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBurger.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBurger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBurger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBurger.FillColor = System.Drawing.Color.White;
            this.btnBurger.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurger.ForeColor = System.Drawing.Color.Black;
            this.btnBurger.Image = global::WindowsFormsApp1.Properties.Resources.SP_burger;
            this.btnBurger.ImageSize = new System.Drawing.Size(25, 25);
            this.btnBurger.Location = new System.Drawing.Point(325, 28);
            this.btnBurger.Margin = new System.Windows.Forms.Padding(4);
            this.btnBurger.Name = "btnBurger";
            this.btnBurger.Size = new System.Drawing.Size(116, 34);
            this.btnBurger.TabIndex = 20;
            this.btnBurger.Text = "Burger";
            this.btnBurger.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNuoc
            // 
            this.btnNuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNuoc.BorderRadius = 10;
            this.btnNuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNuoc.FillColor = System.Drawing.Color.White;
            this.btnNuoc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.ForeColor = System.Drawing.Color.Black;
            this.btnNuoc.Image = global::WindowsFormsApp1.Properties.Resources.SP_drink;
            this.btnNuoc.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNuoc.Location = new System.Drawing.Point(140, 81);
            this.btnNuoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(87, 34);
            this.btnNuoc.TabIndex = 19;
            this.btnNuoc.Text = "Nước";
            this.btnNuoc.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnKem
            // 
            this.btnKem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKem.BorderRadius = 10;
            this.btnKem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKem.FillColor = System.Drawing.Color.White;
            this.btnKem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKem.ForeColor = System.Drawing.Color.Black;
            this.btnKem.Image = global::WindowsFormsApp1.Properties.Resources.SP_Icream;
            this.btnKem.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKem.Location = new System.Drawing.Point(232, 81);
            this.btnKem.Margin = new System.Windows.Forms.Padding(0);
            this.btnKem.Name = "btnKem";
            this.btnKem.Size = new System.Drawing.Size(87, 34);
            this.btnKem.TabIndex = 18;
            this.btnKem.Text = "Kem";
            this.btnKem.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnKhac
            // 
            this.btnKhac.BorderRadius = 10;
            this.btnKhac.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhac.FillColor = System.Drawing.Color.White;
            this.btnKhac.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhac.ForeColor = System.Drawing.Color.Black;
            this.btnKhac.Image = global::WindowsFormsApp1.Properties.Resources.iconDots;
            this.btnKhac.ImageSize = new System.Drawing.Size(25, 25);
            this.btnKhac.Location = new System.Drawing.Point(448, 28);
            this.btnKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhac.Name = "btnKhac";
            this.btnKhac.Size = new System.Drawing.Size(87, 34);
            this.btnKhac.TabIndex = 17;
            this.btnKhac.Text = "Khác";
            this.btnKhac.Click += new System.EventHandler(this.btn_Click);
            // 
            // flpnThucDon
            // 
            this.flpnThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpnThucDon.AutoScroll = true;
            this.flpnThucDon.Location = new System.Drawing.Point(0, 179);
            this.flpnThucDon.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.flpnThucDon.Name = "flpnThucDon";
            this.flpnThucDon.Size = new System.Drawing.Size(554, 394);
            this.flpnThucDon.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.Load += new System.EventHandler(this.fTrangChu_Load);
            this.pnChonMon.ResumeLayout(false);
            this.pnChonMon.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnChonMon;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnHuy;
        private CustomControl.VBButton btnTaoDon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.FlowLayoutPanel flpnOrder;
        private Guna.UI2.WinForms.Guna2Button btnKhac;
        private Guna.UI2.WinForms.Guna2Button btnCombo;
        private Guna.UI2.WinForms.Guna2Button btnPizza;
        private Guna.UI2.WinForms.Guna2Button btnGa;
        private Guna.UI2.WinForms.Guna2Button btnBurger;
        private Guna.UI2.WinForms.Guna2Button btnNuoc;
        private Guna.UI2.WinForms.Guna2Button btnKem;
        public System.Windows.Forms.FlowLayoutPanel flpnThucDon;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbbLoai;
    }
}