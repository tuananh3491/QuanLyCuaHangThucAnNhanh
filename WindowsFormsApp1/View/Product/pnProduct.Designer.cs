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
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.checkCon = new System.Windows.Forms.CheckBox();
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
            this.pnPro.Controls.Add(this.button3);
            this.pnPro.Controls.Add(this.button2);
            this.pnPro.Controls.Add(this.txtPrice);
            this.pnPro.Controls.Add(this.button1);
            this.pnPro.Controls.Add(this.pic);
            this.pnPro.Location = new System.Drawing.Point(3, 3);
            this.pnPro.Name = "pnPro";
            this.pnPro.Size = new System.Drawing.Size(231, 259);
            this.pnPro.TabIndex = 0;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.button3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(133, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 27);
            this.button3.TabIndex = 12;
            this.button3.Text = "L";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.button2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(93, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "M";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.button1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(56, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 27);
            this.button1.TabIndex = 9;
            this.button1.Text = "S";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(36, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(161, 95);
            this.pic.TabIndex = 8;
            this.pic.TabStop = false;
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.CheckBox checkCon;
    }
}
