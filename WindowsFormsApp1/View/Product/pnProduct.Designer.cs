namespace WindowsFormsApp1.View.Product
{
    partial class pnProduct
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
            this.pnPro = new System.Windows.Forms.Panel();
            this.checkCon = new System.Windows.Forms.CheckBox();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnL = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnS = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pnPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPro
            // 
            this.pnPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.pnPro.Controls.Add(this.checkCon);
            this.pnPro.Controls.Add(this.btnEdit);
            this.pnPro.Controls.Add(this.txtName);
            this.pnPro.Controls.Add(this.btnL);
            this.pnPro.Controls.Add(this.btnM);
            this.pnPro.Controls.Add(this.txtPrice);
            this.pnPro.Controls.Add(this.btnS);
            this.pnPro.Controls.Add(this.pic);
            this.pnPro.Location = new System.Drawing.Point(3, 3);
            this.pnPro.Name = "pnPro";
            this.pnPro.Size = new System.Drawing.Size(231, 259);
            this.pnPro.TabIndex = 0;
            // 
            // checkCon
            // 
            this.checkCon.AutoSize = true;
            this.checkCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCon.Location = new System.Drawing.Point(210, 3);
            this.checkCon.Name = "checkCon";
            this.checkCon.Size = new System.Drawing.Size(18, 17);
            this.checkCon.TabIndex = 25;
            this.checkCon.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 20;
            this.btnEdit.Location = new System.Drawing.Point(191, 126);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(37, 30);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(46, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 23);
            this.txtName.TabIndex = 13;
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnL.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(133, 168);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(32, 27);
            this.btnL.TabIndex = 12;
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.btnL_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnM.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(93, 168);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(32, 27);
            this.btnM.TabIndex = 11;
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.btnM_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(46, 210);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(136, 25);
            this.txtPrice.TabIndex = 10;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnS
            // 
            this.btnS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnS.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnS.Location = new System.Drawing.Point(56, 168);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(32, 27);
            this.btnS.TabIndex = 9;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = false;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(36, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(161, 95);
            this.pic.TabIndex = 8;
            this.pic.TabStop = false;
            // 
            // pnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnPro);
            this.Name = "pnProduct";
            this.Size = new System.Drawing.Size(237, 265);
            this.pnPro.ResumeLayout(false);
            this.pnPro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPro;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnL;
        private System.Windows.Forms.Button btnM;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.PictureBox pic;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.CheckBox checkCon;
    }
}
