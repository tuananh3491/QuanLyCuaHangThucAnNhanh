namespace WindowsFormsApp1.View
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTaoCa = new WindowsFormsApp1.CustomControl.VBButton();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 466);
            this.panel1.TabIndex = 0;
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
            this.btnTaoCa.Location = new System.Drawing.Point(698, 506);
            this.btnTaoCa.Margin = new System.Windows.Forms.Padding(5);
            this.btnTaoCa.Name = "btnTaoCa";
            this.btnTaoCa.Size = new System.Drawing.Size(160, 40);
            this.btnTaoCa.TabIndex = 7;
            this.btnTaoCa.Text = "Tạo ca mới";
            this.btnTaoCa.TextColor = System.Drawing.Color.White;
            this.btnTaoCa.UseVisualStyleBackColor = false;
            this.btnTaoCa.Click += new System.EventHandler(this.btnTaoCa_Click);
            // 
            // fShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.btnTaoCa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShift";
            this.Text = "fShift";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControl.VBButton btnTaoCa;
    }
}