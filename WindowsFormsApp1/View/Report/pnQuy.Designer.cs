namespace WindowsFormsApp1.View.Report
{
    partial class pnQuy
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
            this.ccbQuy = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ccbQuy
            // 
            this.ccbQuy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbQuy.FormattingEnabled = true;
            this.ccbQuy.Items.AddRange(new object[] {
            "Ngày",
            "Tháng",
            "Quý",
            "Năm"});
            this.ccbQuy.Location = new System.Drawing.Point(3, 10);
            this.ccbQuy.Name = "ccbQuy";
            this.ccbQuy.Size = new System.Drawing.Size(47, 31);
            this.ccbQuy.TabIndex = 59;
            // 
            // pnQuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ccbQuy);
            this.Name = "pnQuy";
            this.Size = new System.Drawing.Size(57, 49);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ccbQuy;
    }
}
