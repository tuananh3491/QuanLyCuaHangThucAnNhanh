namespace WindowsFormsApp1.View
{
    partial class fCustomer
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnViewHtr = new WindowsFormsApp1.CustomControl.VBButton();
            this.btnUpdate = new WindowsFormsApp1.CustomControl.VBButton();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(23, 49);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(884, 428);
            this.dataGridView.TabIndex = 2;
            // 
            // btnViewHtr
            // 
            this.btnViewHtr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnViewHtr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnViewHtr.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewHtr.BorderRadius = 10;
            this.btnViewHtr.BorderSize = 0;
            this.btnViewHtr.FlatAppearance.BorderSize = 0;
            this.btnViewHtr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewHtr.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewHtr.ForeColor = System.Drawing.Color.White;
            this.btnViewHtr.Location = new System.Drawing.Point(649, 497);
            this.btnViewHtr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewHtr.Name = "btnViewHtr";
            this.btnViewHtr.Size = new System.Drawing.Size(220, 39);
            this.btnViewHtr.TabIndex = 3;
            this.btnViewHtr.Text = "Lịch sử mua hàng";
            this.btnViewHtr.TextColor = System.Drawing.Color.White;
            this.btnViewHtr.UseVisualStyleBackColor = false;
            this.btnViewHtr.Click += new System.EventHandler(this.btnViewHtr_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 10;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(397, 497);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 39);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật thông tin";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // column1
            // 
            this.column1.DataPropertyName = "Ma_KH";
            this.column1.HeaderText = "Mã khách hàng";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            // 
            // column2
            // 
            this.column2.DataPropertyName = "Ten_KH";
            this.column2.HeaderText = "Tên khách hàng";
            this.column2.MinimumWidth = 6;
            this.column2.Name = "column2";
            // 
            // column3
            // 
            this.column3.DataPropertyName = "SDT";
            this.column3.HeaderText = "Số điện thoại";
            this.column3.MinimumWidth = 6;
            this.column3.Name = "column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Diem_tich_luy";
            this.Column4.HeaderText = "Điểm tích lũy";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(931, 560);
            this.Controls.Add(this.btnViewHtr);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fCustomer";
            this.Text = "xxxxxxx";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.VBButton btnUpdate;
        private System.Windows.Forms.DataGridView dataGridView;
        private CustomControl.VBButton btnViewHtr;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}