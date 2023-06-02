namespace WindowsFormsApp1.View
{
    partial class fReport_CustomerChart
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnSoLieu = new WindowsFormsApp1.CustomControl.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bieuDoKH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDone = new FontAwesome.Sharp.IconButton();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbLoc = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoKH)).BeginInit();
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
            this.btnSoLieu.TabIndex = 22;
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
            this.panel1.Controls.Add(this.bieuDoKH);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 412);
            this.panel1.TabIndex = 21;
            // 
            // bieuDoKH
            // 
            this.bieuDoKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            legend1.Name = "Legend1";
            this.bieuDoKH.Legends.Add(legend1);
            this.bieuDoKH.Location = new System.Drawing.Point(0, 0);
            this.bieuDoKH.Name = "bieuDoKH";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(119)))));
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.LegendText = "Khách hàng quay trở lại quán";
            series1.Name = "series1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(227)))), ((int)(((byte)(98)))));
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.Legend = "Legend1";
            series2.LegendText = "Khách hàng mua lần đầu";
            series2.Name = "series2";
            this.bieuDoKH.Series.Add(series1);
            this.bieuDoKH.Series.Add(series2);
            this.bieuDoKH.Size = new System.Drawing.Size(885, 409);
            this.bieuDoKH.TabIndex = 0;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "BIỂU ĐỒ THỐNG KÊ VỀ KHÁCH HÀNG";
            this.bieuDoKH.Titles.Add(title1);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDone);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ccbLoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 67);
            this.panel2.TabIndex = 23;
            // 
            // btnDone
            // 
            this.btnDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDone.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.btnDone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.btnDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDone.IconSize = 40;
            this.btnDone.Location = new System.Drawing.Point(837, 12);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(40, 46);
            this.btnDone.TabIndex = 21;
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.iconDone_Click);
            // 
            // cbbNam
            // 
            this.cbbNam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(719, 19);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(79, 31);
            this.cbbNam.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(653, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 73;
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
            // fReport_CustomerChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSoLieu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReport_CustomerChart";
            this.Text = "fReport_CustomerChart";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bieuDoKH)).EndInit();
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
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart bieuDoKH;
        private FontAwesome.Sharp.IconButton btnDone;
    }
}