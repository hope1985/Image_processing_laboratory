namespace IPForms
{
    partial class ColorChannelsWondow
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
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.panelChannels = new System.Windows.Forms.Panel();
            this.groupBoxChannels = new System.Windows.Forms.GroupBox();
            this.ImagePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChannels.SuspendLayout();
            this.groupBoxChannels.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.AutoSize = true;
            this.checkBoxBlue.Checked = true;
            this.checkBoxBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBlue.Location = new System.Drawing.Point(11, 67);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(47, 17);
            this.checkBoxBlue.TabIndex = 2;
            this.checkBoxBlue.Text = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            this.checkBoxBlue.CheckedChanged += new System.EventHandler(this.checkBoxBlue_CheckedChanged);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.AutoSize = true;
            this.checkBoxGreen.Checked = true;
            this.checkBoxGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGreen.Location = new System.Drawing.Point(11, 44);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(55, 17);
            this.checkBoxGreen.TabIndex = 1;
            this.checkBoxGreen.Text = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            this.checkBoxGreen.CheckedChanged += new System.EventHandler(this.checkBoxGreen_CheckedChanged);
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.AutoSize = true;
            this.checkBoxRed.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRed.Checked = true;
            this.checkBoxRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRed.Location = new System.Drawing.Point(11, 21);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(46, 17);
            this.checkBoxRed.TabIndex = 0;
            this.checkBoxRed.Text = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = false;
            this.checkBoxRed.CheckedChanged += new System.EventHandler(this.checkBoxRed_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(18, 167);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(76, 23);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(19, 127);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // panelChannels
            // 
            this.panelChannels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChannels.Controls.Add(this.groupBoxChannels);
            this.panelChannels.Controls.Add(this.Cancel);
            this.panelChannels.Controls.Add(this.OK);
            this.panelChannels.Location = new System.Drawing.Point(310, 12);
            this.panelChannels.Name = "panelChannels";
            this.panelChannels.Size = new System.Drawing.Size(113, 208);
            this.panelChannels.TabIndex = 28;
            // 
            // groupBoxChannels
            // 
            this.groupBoxChannels.Controls.Add(this.checkBoxBlue);
            this.groupBoxChannels.Controls.Add(this.checkBoxGreen);
            this.groupBoxChannels.Controls.Add(this.checkBoxRed);
            this.groupBoxChannels.Location = new System.Drawing.Point(18, 3);
            this.groupBoxChannels.Name = "groupBoxChannels";
            this.groupBoxChannels.Size = new System.Drawing.Size(76, 100);
            this.groupBoxChannels.TabIndex = 29;
            this.groupBoxChannels.TabStop = false;
            this.groupBoxChannels.Text = "Channels";
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.pictureBox1);
            this.ImagePanel.Location = new System.Drawing.Point(12, 12);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(292, 208);
            this.ImagePanel.TabIndex = 29;
            // 
            // ColorChannelsWondow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 231);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.panelChannels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ColorChannelsWondow";
            this.Text = "Color Channels";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChannels.ResumeLayout(false);
            this.groupBoxChannels.ResumeLayout(false);
            this.groupBoxChannels.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel panelChannels;
        private System.Windows.Forms.GroupBox groupBoxChannels;
        private System.Windows.Forms.Panel ImagePanel;
    }
}