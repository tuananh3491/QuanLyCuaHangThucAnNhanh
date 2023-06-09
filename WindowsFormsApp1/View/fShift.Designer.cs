﻿namespace WindowsFormsApp1.View
{
    partial class fShift
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDetail = new WindowsFormsApp1.CustomControl.VBButton();
            this.btnTaoCa = new WindowsFormsApp1.CustomControl.VBButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(35, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(618, 341);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.datagridview1_RowHeaderMouseClicked);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma_ca";
            this.Column1.HeaderText = "Mã ca";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Ten_ca";
            this.Column2.HeaderText = "Tên ca";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Thoigianbatdau";
            this.Column3.HeaderText = "Thời gian bắt đầu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Thoigianketthuc";
            this.Column4.HeaderText = "Thời gian kết thúc";
            this.Column4.Name = "Column4";
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnDetail.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnDetail.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDetail.BorderRadius = 10;
            this.btnDetail.BorderSize = 0;
            this.btnDetail.Enabled = false;
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(375, 410);
            this.btnDetail.Margin = new System.Windows.Forms.Padding(4);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(120, 32);
            this.btnDetail.TabIndex = 9;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.TextColor = System.Drawing.Color.White;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnTaoCa
            // 
            this.btnTaoCa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnTaoCa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(138)))), ((int)(((byte)(0)))));
            this.btnTaoCa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaoCa.BorderRadius = 10;
            this.btnTaoCa.BorderSize = 0;
            this.btnTaoCa.FlatAppearance.BorderSize = 0;
            this.btnTaoCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoCa.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoCa.ForeColor = System.Drawing.Color.White;
            this.btnTaoCa.Location = new System.Drawing.Point(524, 411);
            this.btnTaoCa.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoCa.Name = "btnTaoCa";
            this.btnTaoCa.Size = new System.Drawing.Size(120, 32);
            this.btnTaoCa.TabIndex = 7;
            this.btnTaoCa.Text = "Tạo ca mới";
            this.btnTaoCa.TextColor = System.Drawing.Color.White;
            this.btnTaoCa.UseVisualStyleBackColor = false;
            this.btnTaoCa.Click += new System.EventHandler(this.btnTaoCa_Click);
            // 
            // fShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(698, 455);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTaoCa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fShift";
            this.Text = "fShift";
            this.Load += new System.EventHandler(this.fShift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControl.VBButton btnTaoCa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CustomControl.VBButton btnDetail;
    }
}