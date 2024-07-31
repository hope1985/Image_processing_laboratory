namespace IPControls
{
    partial class HistogramControl
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
            this.groupBoxChannel = new System.Windows.Forms.GroupBox();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.textBoxSelectIntensity = new System.Windows.Forms.TextBox();
            this.labelSelectLevel = new System.Windows.Forms.Label();
            this.pictureBoxHist = new System.Windows.Forms.PictureBox();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.groupBoxColorIntensity = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridcheckBox = new System.Windows.Forms.CheckBox();
            this.groupBoxChannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHist)).BeginInit();
            this.groupBoxColorIntensity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxChannel
            // 
            this.groupBoxChannel.Controls.Add(this.radioButtonRed);
            this.groupBoxChannel.Controls.Add(this.radioButtonBlue);
            this.groupBoxChannel.Controls.Add(this.radioButtonGreen);
            this.groupBoxChannel.Location = new System.Drawing.Point(12, 344);
            this.groupBoxChannel.Name = "groupBoxChannel";
            this.groupBoxChannel.Size = new System.Drawing.Size(85, 88);
            this.groupBoxChannel.TabIndex = 1;
            this.groupBoxChannel.TabStop = false;
            this.groupBoxChannel.Text = "Channels";
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Checked = true;
            this.radioButtonRed.Location = new System.Drawing.Point(15, 20);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonRed.TabIndex = 0;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            this.radioButtonRed.CheckedChanged += new System.EventHandler(this.radioButtonRed_CheckedChanged);
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(14, 66);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(46, 17);
            this.radioButtonBlue.TabIndex = 1;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            this.radioButtonBlue.CheckedChanged += new System.EventHandler(this.radioButtonBlue_CheckedChanged);
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(14, 43);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            this.radioButtonGreen.CheckedChanged += new System.EventHandler(this.radioButtonGreen_CheckedChanged);
            // 
            // textBoxSelectIntensity
            // 
            this.textBoxSelectIntensity.Location = new System.Drawing.Point(90, 20);
            this.textBoxSelectIntensity.Name = "textBoxSelectIntensity";
            this.textBoxSelectIntensity.Size = new System.Drawing.Size(41, 20);
            this.textBoxSelectIntensity.TabIndex = 5;
            this.textBoxSelectIntensity.TextChanged += new System.EventHandler(this.textBoxSelectLevel_TextChanged);
            // 
            // labelSelectLevel
            // 
            this.labelSelectLevel.AutoSize = true;
            this.labelSelectLevel.Location = new System.Drawing.Point(7, 23);
            this.labelSelectLevel.Name = "labelSelectLevel";
            this.labelSelectLevel.Size = new System.Drawing.Size(77, 13);
            this.labelSelectLevel.TabIndex = 6;
            this.labelSelectLevel.Text = "Select level    :";
            // 
            // pictureBoxHist
            // 
            this.pictureBoxHist.BackColor = System.Drawing.Color.White;
            this.pictureBoxHist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxHist.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.pictureBoxHist.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHist.Name = "pictureBoxHist";
            this.pictureBoxHist.Size = new System.Drawing.Size(270, 300);
            this.pictureBoxHist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxHist.TabIndex = 0;
            this.pictureBoxHist.TabStop = false;
            this.pictureBoxHist.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxHist_MouseMove);
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Location = new System.Drawing.Point(8, 43);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(77, 13);
            this.labelLevel.TabIndex = 9;
            this.labelLevel.Text = "Color level      :";
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(8, 61);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(77, 13);
            this.labelCount.TabIndex = 10;
            this.labelCount.Text = "Count             :";
            // 
            // groupBoxColorIntensity
            // 
            this.groupBoxColorIntensity.Controls.Add(this.labelCount);
            this.groupBoxColorIntensity.Controls.Add(this.labelLevel);
            this.groupBoxColorIntensity.Controls.Add(this.labelSelectLevel);
            this.groupBoxColorIntensity.Controls.Add(this.textBoxSelectIntensity);
            this.groupBoxColorIntensity.Location = new System.Drawing.Point(124, 344);
            this.groupBoxColorIntensity.Name = "groupBoxColorIntensity";
            this.groupBoxColorIntensity.Size = new System.Drawing.Size(158, 88);
            this.groupBoxColorIntensity.TabIndex = 11;
            this.groupBoxColorIntensity.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 9);
            this.label1.TabIndex = 12;
            this.label1.Text = " 0   15    30   45    60   75    90  105  120 135 150  165  180 195  210  225  24" +
                "0 255";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GridcheckBox
            // 
            this.GridcheckBox.AutoSize = true;
            this.GridcheckBox.Checked = true;
            this.GridcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GridcheckBox.Location = new System.Drawing.Point(237, 327);
            this.GridcheckBox.Name = "GridcheckBox";
            this.GridcheckBox.Size = new System.Drawing.Size(45, 17);
            this.GridcheckBox.TabIndex = 15;
            this.GridcheckBox.Text = "Grid";
            this.GridcheckBox.UseVisualStyleBackColor = true;
            this.GridcheckBox.CheckedChanged += new System.EventHandler(this.Grid_CheckedChanged);
            // 
            // HistogramControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.GridcheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxColorIntensity);
            this.Controls.Add(this.pictureBoxHist);
            this.Controls.Add(this.groupBoxChannel);
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.Name = "HistogramControl";
            this.Size = new System.Drawing.Size(305, 474);
            this.groupBoxChannel.ResumeLayout(false);
            this.groupBoxChannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHist)).EndInit();
            this.groupBoxColorIntensity.ResumeLayout(false);
            this.groupBoxColorIntensity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.GroupBox groupBoxChannel;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Label labelSelectLevel;
        private System.Windows.Forms.PictureBox pictureBoxHist;
        private System.Windows.Forms.TextBox textBoxSelectIntensity;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.GroupBox groupBoxColorIntensity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox GridcheckBox;
    }
}
