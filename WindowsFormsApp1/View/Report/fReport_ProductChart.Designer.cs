namespace WindowsFormsApp1.View
{
    partial class fReport_ProductChart
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnSoLieu = new WindowsFormsApp1.CustomControl.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bieuDoSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDone = new FontAwesome.Sharp.IconButton();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbLoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoSP)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSoLieu
            // 
            this.btnSoLieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSoLieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnSoLieu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnSoLieu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSoLieu.BorderRadius = 10;
            this.btnSoLieu.BorderSize = 0;
            this.btnSoLieu.FlatAppearance.BorderSize = 0;
            this.btnSoLieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoLieu.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoLieu.ForeColor = System.Drawing.Color.White;
            this.btnSoLieu.Location = new System.Drawing.Point(751, 506);
            this.btnSoLieu.Margin = new System.Windows.Forms.Padding(5);
            this.btnSoLieu.Name = "btnSoLieu";
            this.btnSoLieu.Size = new System.Drawing.Size(115, 40);
            this.btnSoLieu.TabIndex = 27;
            this.btnSoLieu.Text = "Số liệu";
            this.btnSoLieu.TextColor = System.Drawing.Color.White;
            this.btnSoLieu.UseVisualStyleBackColor = false;
            this.btnSoLieu.Click += new System.EventHandler(this.btnSoLieu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.bieuDoSP);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 412);
            this.panel1.TabIndex = 26;
            // 
            // bieuDoSP
            // 
            this.bieuDoSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend2.Name = "Legend1";
            this.bieuDoSP.Legends.Add(legend2);
            this.bieuDoSP.Location = new System.Drawing.Point(0, 4);
            this.bieuDoSP.Name = "bieuDoSP";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.bieuDoSP.Series.Add(series2);
            this.bieuDoSP.Size = new System.Drawing.Size(882, 405);
            this.bieuDoSP.TabIndex = 0;
            this.bieuDoSP.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "BIỂU ĐỒ TỈ TRỌNG SẢN PHẨM ĐÃ BÁN";
            this.bieuDoSP.Titles.Add(title2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Controls.Add(this.cbbThang);
            this.panel2.Controls.Add(this.lbThang);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ccbLoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 67);
            this.panel2.TabIndex = 28;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnDone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.btnDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDone.IconSize = 40;
            this.btnDone.Location = new System.Drawing.Point(865, 11);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(40, 46);
            this.btnDone.TabIndex = 22;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.iconDone_Click);
            // 
            // cbbThang
            // 
            this.cbbThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbThang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(637, 19);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(79, 31);
            this.cbbThang.TabIndex = 79;
            // 
            // lbThang
            // 
            this.lbThang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(573, 24);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 80;
            this.lbThang.Text = "Tháng";
            // 
            // cbbNam
            // 
            this.cbbNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(769, 19);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(79, 31);
            this.cbbNam.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Năm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Lọc";
            this.label1.Visible = false;
            // 
            // ccbLoc
            // 
            this.ccbLoc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbLoc.FormattingEnabled = true;
            this.ccbLoc.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.ccbLoc.Location = new System.Drawing.Point(90, 19);
            this.ccbLoc.Name = "ccbLoc";
            this.ccbLoc.Size = new System.Drawing.Size(87, 31);
            this.ccbLoc.TabIndex = 58;
            this.ccbLoc.Visible = false;
            // 
            // fReport_ProductChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSoLieu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReport_ProductChart";
            this.Text = "fReport_ProductChart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoSP)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControl.VBButton btnSoLieu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbLoc;
        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDoSP;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btnDone;
    }
}