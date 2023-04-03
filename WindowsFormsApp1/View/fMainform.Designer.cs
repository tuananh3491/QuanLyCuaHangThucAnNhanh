namespace WindowsFormsApp1.View
{
    partial class fMainform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panelbutton = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnBaoCao = new FontAwesome.Sharp.IconButton();
            this.btnHoaDon = new FontAwesome.Sharp.IconButton();
            this.btnSanPham = new FontAwesome.Sharp.IconButton();
            this.btnKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnCaLamViec = new FontAwesome.Sharp.IconButton();
            this.btnNhanVien = new FontAwesome.Sharp.IconButton();
            this.btnTrangChu = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTimKiem = new System.Windows.Forms.Panel();
            this.pcbTimKiem = new FontAwesome.Sharp.IconPictureBox();
            this.rjTextBox1 = new WindowsFormsApp1.CustomControl.RJTextBox();
            this.panel1.SuspendLayout();
            this.panelbutton.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 26);
            this.panel1.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(1035, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(52, 26);
            this.btnMinimize.TabIndex = 22;
            this.btnMinimize.Text = " ";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.DimGray;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(1090, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(52, 26);
            this.btnMaximize.TabIndex = 21;
            this.btnMaximize.Text = " ";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(33)))));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.DimGray;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1144, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 26);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = " ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelbutton
            // 
            this.panelbutton.BackColor = System.Drawing.Color.White;
            this.panelbutton.Controls.Add(this.btnSetting);
            this.panelbutton.Controls.Add(this.btnBaoCao);
            this.panelbutton.Controls.Add(this.btnHoaDon);
            this.panelbutton.Controls.Add(this.btnSanPham);
            this.panelbutton.Controls.Add(this.btnKhachHang);
            this.panelbutton.Controls.Add(this.btnCaLamViec);
            this.panelbutton.Controls.Add(this.btnNhanVien);
            this.panelbutton.Controls.Add(this.btnTrangChu);
            this.panelbutton.Controls.Add(this.panelLogo);
            this.panelbutton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelbutton.Location = new System.Drawing.Point(0, 26);
            this.panelbutton.Name = "panelbutton";
            this.panelbutton.Size = new System.Drawing.Size(200, 674);
            this.panelbutton.TabIndex = 5;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.Black;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 555);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 65);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "Cài đặt";
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnBaoCao.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCao.FlatAppearance.BorderSize = 0;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.btnBaoCao.IconColor = System.Drawing.Color.Black;
            this.btnBaoCao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(0, 490);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBaoCao.Size = new System.Drawing.Size(200, 65);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.White;
            this.btnHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            this.btnHoaDon.IconColor = System.Drawing.Color.Black;
            this.btnHoaDon.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 425);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHoaDon.Size = new System.Drawing.Size(200, 65);
            this.btnHoaDon.TabIndex = 6;
            this.btnHoaDon.Text = "Hóa đơn";
            this.btnHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSanPham.FlatAppearance.BorderSize = 0;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnSanPham.IconColor = System.Drawing.Color.Black;
            this.btnSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(0, 360);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSanPham.Size = new System.Drawing.Size(200, 65);
            this.btnSanPham.TabIndex = 5;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.White;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnKhachHang.IconColor = System.Drawing.Color.Black;
            this.btnKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 295);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(200, 65);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnCaLamViec
            // 
            this.btnCaLamViec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnCaLamViec.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaLamViec.FlatAppearance.BorderSize = 0;
            this.btnCaLamViec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaLamViec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaLamViec.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnCaLamViec.IconColor = System.Drawing.Color.Black;
            this.btnCaLamViec.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCaLamViec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaLamViec.Location = new System.Drawing.Point(0, 230);
            this.btnCaLamViec.Name = "btnCaLamViec";
            this.btnCaLamViec.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCaLamViec.Size = new System.Drawing.Size(200, 65);
            this.btnCaLamViec.TabIndex = 3;
            this.btnCaLamViec.Text = "Ca làm việc";
            this.btnCaLamViec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaLamViec.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.White;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnNhanVien.IconColor = System.Drawing.Color.Black;
            this.btnNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 165);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanVien.Size = new System.Drawing.Size(200, 65);
            this.btnNhanVien.TabIndex = 2;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnTrangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrangChu.FlatAppearance.BorderSize = 0;
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangChu.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnTrangChu.IconColor = System.Drawing.Color.Black;
            this.btnTrangChu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTrangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.Location = new System.Drawing.Point(0, 100);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTrangChu.Size = new System.Drawing.Size(200, 65);
            this.btnTrangChu.TabIndex = 1;
            this.btnTrangChu.Text = "Trang chủ";
            this.btnTrangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelTimKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 100);
            this.panel2.TabIndex = 6;
            // 
            // panelTimKiem
            // 
            this.panelTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.panelTimKiem.Controls.Add(this.rjTextBox1);
            this.panelTimKiem.Controls.Add(this.pcbTimKiem);
            this.panelTimKiem.Location = new System.Drawing.Point(371, 19);
            this.panelTimKiem.Name = "panelTimKiem";
            this.panelTimKiem.Size = new System.Drawing.Size(251, 40);
            this.panelTimKiem.TabIndex = 0;
            // 
            // pcbTimKiem
            // 
            this.pcbTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.pcbTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(101)))), ((int)(((byte)(111)))));
            this.pcbTimKiem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.pcbTimKiem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(101)))), ((int)(((byte)(111)))));
            this.pcbTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pcbTimKiem.Location = new System.Drawing.Point(10, 5);
            this.pcbTimKiem.Name = "pcbTimKiem";
            this.pcbTimKiem.Size = new System.Drawing.Size(32, 32);
            this.pcbTimKiem.TabIndex = 0;
            this.pcbTimKiem.TabStop = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.rjTextBox1.BorderRadius = 0;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(101)))), ((int)(((byte)(111)))));
            this.rjTextBox1.Location = new System.Drawing.Point(53, 3);
            this.rjTextBox1.Multiline = true;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(101)))), ((int)(((byte)(111)))));
            this.rjTextBox1.PlaceholderText = "Tìm kiếm";
            this.rjTextBox1.Size = new System.Drawing.Size(175, 35);
            this.rjTextBox1.TabIndex = 1;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // fMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelbutton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMainform";
            this.panel1.ResumeLayout(false);
            this.panelbutton.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTimKiem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbTimKiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private System.Windows.Forms.Panel panelbutton;
        private FontAwesome.Sharp.IconButton btnTrangChu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnBaoCao;
        private FontAwesome.Sharp.IconButton btnHoaDon;
        private FontAwesome.Sharp.IconButton btnSanPham;
        private FontAwesome.Sharp.IconButton btnKhachHang;
        private FontAwesome.Sharp.IconButton btnCaLamViec;
        private FontAwesome.Sharp.IconButton btnNhanVien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTimKiem;
        private FontAwesome.Sharp.IconPictureBox pcbTimKiem;
        private CustomControl.RJTextBox rjTextBox1;
    }
}