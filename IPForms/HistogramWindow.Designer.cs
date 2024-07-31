namespace IPForms
{
    partial class HistogramWindow
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
            this.histogramControl1 = new IPControls.HistogramControl();
            this.SuspendLayout();
            // 
            // histogramControl1
            // 
            this.histogramControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.histogramControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.histogramControl1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.histogramControl1.Location = new System.Drawing.Point(-5, 1);
            this.histogramControl1.Name = "histogramControl1";
            this.histogramControl1.Size = new System.Drawing.Size(293, 479);
            this.histogramControl1.TabIndex = 0;
            // 
            // HistogramWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 492);
            this.Controls.Add(this.histogramControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistogramWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Histogram";
            this.ResumeLayout(false);

        }

        #endregion

        private IPControls.HistogramControl histogramControl1;









    }
}