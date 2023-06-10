namespace WindowsFormsApp1.View
{
    partial class fShift_Staff
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new WindowsFormsApp1.CustomControl.VBButton();
            this.dtpLich = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTGKT = new System.Windows.Forms.TextBox();
            this.txtTGBD = new System.Windows.Forms.TextBox();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.ngayNghi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.iconDone = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(23, 123);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(884, 268);
            this.dgv.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnXem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnXem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXem.BorderRadius = 10;
            this.btnXem.BorderSize = 0;
            this.btnXem.FlatAppearance.BorderSize = 0;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(738, 72);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(126, 39);
            this.btnXem.TabIndex = 27;
            this.btnXem.Text = "Xin nghỉ";
            this.btnXem.TextColor = System.Drawing.Color.White;
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // dtpLich
            // 
            this.dtpLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLich.CustomFormat = "MM/yyyy";
            this.dtpLich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLich.Location = new System.Drawing.Point(714, 22);
            this.dtpLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpLich.Name = "dtpLich";
            this.dtpLich.Size = new System.Drawing.Size(127, 30);
            this.dtpLich.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Location = new System.Drawing.Point(23, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 62);
            this.panel1.TabIndex = 32;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(169, 15);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(327, 34);
            this.txtTen.TabIndex = 17;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(583, 14);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(148, 34);
            this.txtMaNV.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTGKT);
            this.panel2.Controls.Add(this.txtTGBD);
            this.panel2.Controls.Add(this.cbbNV);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Controls.Add(this.ngayNghi);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnXem);
            this.panel2.Location = new System.Drawing.Point(23, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 122);
            this.panel2.TabIndex = 33;
            this.panel2.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Thời gian nghỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Đến:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Từ:";
            // 
            // txtTGKT
            // 
            this.txtTGKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGKT.Location = new System.Drawing.Point(535, 80);
            this.txtTGKT.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTGKT.Name = "txtTGKT";
            this.txtTGKT.Size = new System.Drawing.Size(163, 28);
            this.txtTGKT.TabIndex = 33;
            // 
            // txtTGBD
            // 
            this.txtTGBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTGBD.Location = new System.Drawing.Point(333, 80);
            this.txtTGBD.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtTGBD.Name = "txtTGBD";
            this.txtTGBD.Size = new System.Drawing.Size(163, 28);
            this.txtTGBD.TabIndex = 32;
            // 
            // cbbNV
            // 
            this.cbbNV.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(131, 82);
            this.cbbNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(157, 26);
            this.cbbNV.TabIndex = 31;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(11, 82);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(87, 25);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "Ca làm:";
            // 
            // ngayNghi
            // 
            this.ngayNghi.CustomFormat = "dd/MM/yyyy";
            this.ngayNghi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayNghi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayNghi.Location = new System.Drawing.Point(131, 37);
            this.ngayNghi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ngayNghi.Name = "ngayNghi";
            this.ngayNghi.Size = new System.Drawing.Size(157, 30);
            this.ngayNghi.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ngày nghỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 404);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Thông tin xin nghỉ làm";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnBack.IconColor = System.Drawing.Color.Black;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 30;
            this.btnBack.Location = new System.Drawing.Point(14, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 90D;
            this.btnBack.Size = new System.Drawing.Size(61, 39);
            this.btnBack.TabIndex = 33;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // iconDone
            // 
            this.iconDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconDone.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconDone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.iconDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDone.IconSize = 40;
            this.iconDone.Location = new System.Drawing.Point(847, 12);
            this.iconDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconDone.Name = "iconDone";
            this.iconDone.Size = new System.Drawing.Size(40, 46);
            this.iconDone.TabIndex = 31;
            this.iconDone.UseVisualStyleBackColor = true;
            this.iconDone.Click += new System.EventHandler(this.iconDone_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ngày";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã ca làm việc";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên ca";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thời gian bắt đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Thời gian kết thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số giờ đã làm";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // fShift_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(931, 560);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.iconDone);
            this.Controls.Add(this.dtpLich);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShift_Staff";
            this.Text = "fShift_Staff";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnXem;
        private FontAwesome.Sharp.IconButton iconDone;
        private System.Windows.Forms.DateTimePicker dtpLich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.DateTimePicker ngayNghi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTGKT;
        private System.Windows.Forms.TextBox txtTGBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}