namespace WindowsFormsApp1.View.TrangChu
{
    partial class panelMonAn
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.lbTenMonAn = new System.Windows.Forms.Label();
            this.pcbMonAn = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.tbTien);
            this.panel4.Controls.Add(this.lbTenMonAn);
            this.panel4.Controls.Add(this.pcbMonAn);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 89);
            this.panel4.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(160, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 24);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbTien
            // 
            this.tbTien.BackColor = System.Drawing.Color.White;
            this.tbTien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTien.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(197)))), ((int)(((byte)(80)))));
            this.tbTien.Location = new System.Drawing.Point(80, 57);
            this.tbTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTien.Multiline = true;
            this.tbTien.Name = "tbTien";
            this.tbTien.ReadOnly = true;
            this.tbTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTien.Size = new System.Drawing.Size(70, 18);
            this.tbTien.TabIndex = 3;
            this.tbTien.Text = "0đ";
            this.tbTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.Location = new System.Drawing.Point(83, 7);
            this.lbTenMonAn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(91, 20);
            this.lbTenMonAn.TabIndex = 1;
            this.lbTenMonAn.Text = "label6";
            // 
            // pcbMonAn
            // 
            this.pcbMonAn.Location = new System.Drawing.Point(2, 2);
            this.pcbMonAn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pcbMonAn.Name = "pcbMonAn";
            this.pcbMonAn.Size = new System.Drawing.Size(73, 83);
            this.pcbMonAn.TabIndex = 0;
            this.pcbMonAn.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panelMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "panelMonAn";
            this.Size = new System.Drawing.Size(196, 95);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMonAn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbTenMonAn;
        private System.Windows.Forms.PictureBox pcbMonAn;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}