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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbKichThuoc = new System.Windows.Forms.ComboBox();
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbbKichThuoc);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.tbTien);
            this.panel4.Controls.Add(this.lbTenMonAn);
            this.panel4.Controls.Add(this.pcbMonAn);
            this.panel4.Location = new System.Drawing.Point(4, 4);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 110);
            this.panel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kích thước:";
            // 
            // cbbKichThuoc
            // 
            this.cbbKichThuoc.FormattingEnabled = true;
            this.cbbKichThuoc.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cbbKichThuoc.Location = new System.Drawing.Point(203, 37);
            this.cbbKichThuoc.Name = "cbbKichThuoc";
            this.cbbKichThuoc.Size = new System.Drawing.Size(45, 24);
            this.cbbKichThuoc.TabIndex = 5;
            this.cbbKichThuoc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 20;
            this.btnAdd.Location = new System.Drawing.Point(213, 66);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(29, 30);
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
            this.tbTien.Location = new System.Drawing.Point(107, 70);
            this.tbTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTien.Multiline = true;
            this.tbTien.Name = "tbTien";
            this.tbTien.ReadOnly = true;
            this.tbTien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTien.Size = new System.Drawing.Size(93, 22);
            this.tbTien.TabIndex = 3;
            this.tbTien.Text = "0đ";
            this.tbTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbTenMonAn
            // 
            this.lbTenMonAn.Location = new System.Drawing.Point(107, 9);
            this.lbTenMonAn.Name = "lbTenMonAn";
            this.lbTenMonAn.Size = new System.Drawing.Size(121, 25);
            this.lbTenMonAn.TabIndex = 1;
            this.lbTenMonAn.Text = "label6";
            // 
            // pcbMonAn
            // 
            this.pcbMonAn.Location = new System.Drawing.Point(3, 2);
            this.pcbMonAn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbMonAn.Name = "pcbMonAn";
            this.pcbMonAn.Size = new System.Drawing.Size(97, 102);
            this.pcbMonAn.TabIndex = 0;
            this.pcbMonAn.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panelMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "panelMonAn";
            this.Size = new System.Drawing.Size(261, 117);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbKichThuoc;
    }
}