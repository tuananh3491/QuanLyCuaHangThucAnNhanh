namespace WindowsFormsApp1.View.TrangChu
{
    partial class panelOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLoai = new System.Windows.Forms.Label();
            this.lbKichThuoc = new System.Windows.Forms.Label();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnSub = new FontAwesome.Sharp.IconButton();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.pcbMonAn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbLoai);
            this.panel1.Controls.Add(this.lbKichThuoc);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.tbSoLuong);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.tbTien);
            this.panel1.Controls.Add(this.lbTenMonAn);
            this.panel1.Controls.Add(this.pcbMonAn);
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 94);
            this.panel1.TabIndex = 1;
            // 
            // lbLoai
            // 
            this.lbLoai.AutoSize = true;
            this.lbLoai.Location = new System.Drawing.Point(197, 36);
            this.lbLoai.Name = "lbLoai";
            this.lbLoai.Size = new System.Drawing.Size(16, 16);
            this.lbLoai.TabIndex = 10;
            this.lbLoai.Text = "S";
            // 
            // lbKichThuoc
            // 
            this.lbKichThuoc.AutoSize = true;
            this.lbKichThuoc.Location = new System.Drawing.Point(103, 36);
            this.lbKichThuoc.Name = "lbKichThuoc";
            this.lbKichThuoc.Size = new System.Drawing.Size(70, 16);
            this.lbKichThuoc.TabIndex = 9;
            this.lbKichThuoc.Text = "Kích thước:";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 15;
            this.btnDelete.Location = new System.Drawing.Point(305, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 24);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BackColor = System.Drawing.Color.White;
            this.tbSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.tbSoLuong.Location = new System.Drawing.Point(256, 60);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSoLuong.Multiline = true;
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSoLuong.Size = new System.Drawing.Size(37, 27);
            this.tbSoLuong.TabIndex = 7;
            this.tbSoLuong.Text = "1";
            this.tbSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(296, 58);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(43, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnSub.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnSub.IconColor = System.Drawing.Color.Black;
            this.btnSub.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSub.IconSize = 30;
            this.btnSub.Location = new System.Drawing.Point(210, 57);
            this.btnSub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(43, 30);
            this.btnSub.TabIndex = 5;
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // tbTien
            // 
            this.tbTien.BackColor = System.Drawing.Color.White;
            this.tbTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.tbTien.Location = new System.Drawing.Point(99, 60);
            this.tbTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTien.Multiline = true;
            this.tbTien.Name = "tbTien";
            this.tbTien.ReadOnly = true;
            this.tbTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTien.Size = new System.Drawing.Size(93, 22);
            this.tbTien.TabIndex = 4;
            this.tbTien.Text = "0đ";
            this.tbTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.Location = new System.Drawing.Point(100, 12);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(121, 24);
            this.lbTenMonAn.TabIndex = 2;
            this.lbTenMonAn.Text = "Tên món ăn";
            // 
            // pcbMonAn
            // 
            this.pcbMonAn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbMonAn.Location = new System.Drawing.Point(3, 2);
            this.pcbMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbMonAn.Name = "pcbMonAn";
            this.pcbMonAn.Size = new System.Drawing.Size(91, 89);
            this.pcbMonAn.TabIndex = 0;
            this.pcbMonAn.TabStop = false;
            // 
            // panelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panelOrder";
            this.Size = new System.Drawing.Size(348, 100);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbMonAn;
        private System.Windows.Forms.Label lbTenMonAn;
        private FontAwesome.Sharp.IconButton btnSub;
        private System.Windows.Forms.TextBox tbTien;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.TextBox tbSoLuong;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label lbKichThuoc;
        private System.Windows.Forms.Label lbLoai;
    }
}
