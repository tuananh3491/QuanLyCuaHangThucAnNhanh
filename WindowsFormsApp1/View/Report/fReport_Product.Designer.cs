﻿namespace WindowsFormsApp1.View
{
    partial class fReport_Product
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
            this.btnBieuDo = new WindowsFormsApp1.CustomControl.VBButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ccbLoc = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.lbThang = new System.Windows.Forms.Label();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBieuDo
            // 
            this.btnBieuDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnBieuDo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnBieuDo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnBieuDo.BorderRadius = 10;
            this.btnBieuDo.BorderSize = 0;
            this.btnBieuDo.FlatAppearance.BorderSize = 0;
            this.btnBieuDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBieuDo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieuDo.ForeColor = System.Drawing.Color.White;
            this.btnBieuDo.Location = new System.Drawing.Point(751, 506);
            this.btnBieuDo.Margin = new System.Windows.Forms.Padding(5);
            this.btnBieuDo.Name = "btnBieuDo";
            this.btnBieuDo.Size = new System.Drawing.Size(115, 40);
            this.btnBieuDo.TabIndex = 44;
            this.btnBieuDo.Text = "Biểu đồ";
            this.btnBieuDo.TextColor = System.Drawing.Color.White;
            this.btnBieuDo.UseVisualStyleBackColor = false;
            this.btnBieuDo.Click += new System.EventHandler(this.btnBieuDo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(23, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 412);
            this.panel1.TabIndex = 43;
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbThang);
            this.panel2.Controls.Add(this.lbThang);
            this.panel2.Controls.Add(this.cbbNam);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ccbLoc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 67);
            this.panel2.TabIndex = 0;
            // 
            // cbbThang
            // 
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
            this.cbbThang.Location = new System.Drawing.Point(613, 19);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(79, 31);
            this.cbbThang.TabIndex = 74;
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.Location = new System.Drawing.Point(549, 24);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 75;
            this.lbThang.Text = "Tháng";
            // 
            // cbbNam
            // 
            this.cbbNam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(745, 19);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(79, 31);
            this.cbbNam.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(695, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 73;
            this.label4.Text = "Năm";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(830, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 38);
            this.iconPictureBox1.TabIndex = 65;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(885, 412);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã sản phẩm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // fReport_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBieuDo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReport_Product";
            this.Text = "fReport_Product";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.VBButton btnBieuDo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbLoc;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}