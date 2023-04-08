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
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbSoLuong);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.tbTien);
            this.panel1.Controls.Add(this.lbTenMonAn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 76);
            this.panel1.TabIndex = 1;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.BackColor = System.Drawing.Color.White;
            this.tbSoLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSoLuong.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoLuong.ForeColor = System.Drawing.Color.Black;
            this.tbSoLuong.Location = new System.Drawing.Point(194, 46);
            this.tbSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSoLuong.Multiline = true;
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.ReadOnly = true;
            this.tbSoLuong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSoLuong.Size = new System.Drawing.Size(28, 24);
            this.tbSoLuong.TabIndex = 7;
            this.tbSoLuong.Text = "01";
            this.tbSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconButton2
            // 
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(224, 47);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(32, 24);
            this.iconButton2.TabIndex = 6;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(160, 46);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 24);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // tbTien
            // 
            this.tbTien.BackColor = System.Drawing.Color.White;
            this.tbTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.tbTien.Location = new System.Drawing.Point(76, 49);
            this.tbTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTien.Multiline = true;
            this.tbTien.Name = "tbTien";
            this.tbTien.ReadOnly = true;
            this.tbTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTien.Size = new System.Drawing.Size(70, 18);
            this.tbTien.TabIndex = 4;
            this.tbTien.Text = "0đ";
            this.tbTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.Location = new System.Drawing.Point(75, 11);
            this.lbTenMonAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(91, 20);
            this.lbTenMonAn.TabIndex = 2;
            this.lbTenMonAn.Text = "label6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "panelOrder";
            this.Size = new System.Drawing.Size(262, 81);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTenMonAn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox tbTien;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.TextBox tbSoLuong;
    }
}
