namespace WindowsFormsApp1.View
{
    partial class fStaff_Salary
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvLuong = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new WindowsFormsApp1.CustomControl.VBButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.dtpLich = new System.Windows.Forms.DateTimePicker();
            this.iconDone = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(163, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(327, 34);
            this.txtTen.TabIndex = 17;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(585, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(148, 34);
            this.txtMaNV.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.txtTen);
            this.panel1.Controls.Add(this.txtMaNV);
            this.panel1.Location = new System.Drawing.Point(21, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 80);
            this.panel1.TabIndex = 19;
            // 
            // dgvLuong
            // 
            this.dgvLuong.AllowUserToAddRows = false;
            this.dgvLuong.AllowUserToDeleteRows = false;
            this.dgvLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLuong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.dgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4});
            this.dgvLuong.Location = new System.Drawing.Point(21, 140);
            this.dgvLuong.Name = "dgvLuong";
            this.dgvLuong.ReadOnly = true;
            this.dgvLuong.RowHeadersWidth = 51;
            this.dgvLuong.RowTemplate.Height = 24;
            this.dgvLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuong.Size = new System.Drawing.Size(885, 362);
            this.dgvLuong.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Thời gian";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tổng số giờ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lương nhận";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 26;
            this.label1.Text = "LƯƠNG NHÂN VIÊN";
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
            this.btnXem.Location = new System.Drawing.Point(727, 512);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(153, 39);
            this.btnXem.TabIndex = 28;
            this.btnXem.Text = "Chi tiết";
            this.btnXem.TextColor = System.Drawing.Color.White;
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            this.btnBack.Location = new System.Drawing.Point(12, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Rotation = 90D;
            this.btnBack.Size = new System.Drawing.Size(61, 39);
            this.btnBack.TabIndex = 21;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dtpLich
            // 
            this.dtpLich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpLich.CustomFormat = "MM/yyyy";
            this.dtpLich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLich.Location = new System.Drawing.Point(704, 14);
            this.dtpLich.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpLich.Name = "dtpLich";
            this.dtpLich.Size = new System.Drawing.Size(127, 30);
            this.dtpLich.TabIndex = 53;
            // 
            // iconDone
            // 
            this.iconDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconDone.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            this.iconDone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(67)))));
            this.iconDone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDone.IconSize = 40;
            this.iconDone.Location = new System.Drawing.Point(837, 6);
            this.iconDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconDone.Name = "iconDone";
            this.iconDone.Size = new System.Drawing.Size(40, 46);
            this.iconDone.TabIndex = 52;
            this.iconDone.UseVisualStyleBackColor = true;
            this.iconDone.Click += new System.EventHandler(this.iconDone_Click);
            // 
            // fStaff_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.dtpLich);
            this.Controls.Add(this.iconDone);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvLuong);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStaff_Salary";
            this.Text = "fStaff_Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvLuong;
        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label label1;
        private CustomControl.VBButton btnXem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DateTimePicker dtpLich;
        private FontAwesome.Sharp.IconButton iconDone;
    }
}