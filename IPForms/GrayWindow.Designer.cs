namespace IPForms
{
    partial class GrayWindow
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonRedCh = new System.Windows.Forms.RadioButton();
            this.radioButtonGreenCh = new System.Windows.Forms.RadioButton();
            this.RadioButtonAvrageCh = new System.Windows.Forms.RadioButton();
            this.radioButtonBlueCh = new System.Windows.Forms.RadioButton();
            this.groupBoxChannels = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.ImagPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxChannels.SuspendLayout();
            this.ImagPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // radioButtonRedCh
            // 
            this.radioButtonRedCh.AutoSize = true;
            this.radioButtonRedCh.Location = new System.Drawing.Point(17, 42);
            this.radioButtonRedCh.Name = "radioButtonRedCh";
            this.radioButtonRedCh.Size = new System.Drawing.Size(90, 17);
            this.radioButtonRedCh.TabIndex = 2;
            this.radioButtonRedCh.Text = "Red  Channel";
            this.radioButtonRedCh.UseVisualStyleBackColor = true;
            this.radioButtonRedCh.CheckedChanged += new System.EventHandler(this.radioButtonRedCh_CheckedChanged);
            // 
            // radioButtonGreenCh
            // 
            this.radioButtonGreenCh.AutoSize = true;
            this.radioButtonGreenCh.Location = new System.Drawing.Point(17, 65);
            this.radioButtonGreenCh.Name = "radioButtonGreenCh";
            this.radioButtonGreenCh.Size = new System.Drawing.Size(96, 17);
            this.radioButtonGreenCh.TabIndex = 1;
            this.radioButtonGreenCh.Text = "Green Channel";
            this.radioButtonGreenCh.UseVisualStyleBackColor = true;
            this.radioButtonGreenCh.CheckedChanged += new System.EventHandler(this.radioButtonGreenCh_CheckedChanged);
            // 
            // RadioButtonAvrageCh
            // 
            this.RadioButtonAvrageCh.AutoSize = true;
            this.RadioButtonAvrageCh.Checked = true;
            this.RadioButtonAvrageCh.Location = new System.Drawing.Point(17, 19);
            this.RadioButtonAvrageCh.Name = "RadioButtonAvrageCh";
            this.RadioButtonAvrageCh.Size = new System.Drawing.Size(106, 17);
            this.RadioButtonAvrageCh.TabIndex = 3;
            this.RadioButtonAvrageCh.TabStop = true;
            this.RadioButtonAvrageCh.Text = "Avrage Channels";
            this.RadioButtonAvrageCh.UseVisualStyleBackColor = true;
            this.RadioButtonAvrageCh.CheckedChanged += new System.EventHandler(this.RadioButtonAvrageCh_CheckedChanged);
            // 
            // radioButtonBlueCh
            // 
            this.radioButtonBlueCh.AutoSize = true;
            this.radioButtonBlueCh.Location = new System.Drawing.Point(17, 88);
            this.radioButtonBlueCh.Name = "radioButtonBlueCh";
            this.radioButtonBlueCh.Size = new System.Drawing.Size(88, 17);
            this.radioButtonBlueCh.TabIndex = 0;
            this.radioButtonBlueCh.Text = "Blue Channel";
            this.radioButtonBlueCh.UseVisualStyleBackColor = true;
            this.radioButtonBlueCh.CheckedChanged += new System.EventHandler(this.radioButtonBlueCh_CheckedChanged);
            // 
            // groupBoxChannels
            // 
            this.groupBoxChannels.Controls.Add(this.radioButtonBlueCh);
            this.groupBoxChannels.Controls.Add(this.RadioButtonAvrageCh);
            this.groupBoxChannels.Controls.Add(this.radioButtonRedCh);
            this.groupBoxChannels.Controls.Add(this.radioButtonGreenCh);
            this.groupBoxChannels.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxChannels.Location = new System.Drawing.Point(289, 12);
            this.groupBoxChannels.Name = "groupBoxChannels";
            this.groupBoxChannels.Size = new System.Drawing.Size(127, 116);
            this.groupBoxChannels.TabIndex = 4;
            this.groupBoxChannels.TabStop = false;
            this.groupBoxChannels.Text = "Channels";
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(318, 184);
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
            this.OK.Location = new System.Drawing.Point(319, 145);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 5;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ImagPanel
            // 
            this.ImagPanel.AutoScroll = true;
            this.ImagPanel.Controls.Add(this.pictureBox1);
            this.ImagPanel.Location = new System.Drawing.Point(12, 17);
            this.ImagPanel.Name = "ImagPanel";
            this.ImagPanel.Size = new System.Drawing.Size(271, 208);
            this.ImagPanel.TabIndex = 7;
            // 
            // GrayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 237);
            this.Controls.Add(this.ImagPanel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBoxChannels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GrayWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gray Window";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxChannels.ResumeLayout(false);
            this.groupBoxChannels.PerformLayout();
            this.ImagPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButtonRedCh;
        private System.Windows.Forms.RadioButton radioButtonGreenCh;
        private System.Windows.Forms.RadioButton RadioButtonAvrageCh;
        private System.Windows.Forms.RadioButton radioButtonBlueCh;
        private System.Windows.Forms.GroupBox groupBoxChannels;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel ImagPanel;
    }
}