namespace IPForms
{
    partial class ThresholdWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThresholdWindow));
            this.ThresholdtrackBar = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ThresholdDecButton = new System.Windows.Forms.Button();
            this.ThresholdIncButton = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ThresholdLabel = new System.Windows.Forms.Label();
            this.OneThpanel = new System.Windows.Forms.Panel();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdtrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.OneThpanel.SuspendLayout();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ThresholdtrackBar
            // 
            this.ThresholdtrackBar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.ThresholdtrackBar, "ThresholdtrackBar");
            this.ThresholdtrackBar.Maximum = 254;
            this.ThresholdtrackBar.Minimum = 1;
            this.ThresholdtrackBar.Name = "ThresholdtrackBar";
            this.ThresholdtrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ThresholdtrackBar.Value = 128;
            this.ThresholdtrackBar.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // OK
            // 
            resources.ApplyResources(this.OK, "OK");
            this.OK.Name = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ThresholdDecButton);
            this.panel1.Controls.Add(this.ThresholdIncButton);
            this.panel1.Controls.Add(this.ThresholdtrackBar);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // ThresholdDecButton
            // 
            this.ThresholdDecButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.ThresholdDecButton, "ThresholdDecButton");
            this.ThresholdDecButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ThresholdDecButton.Image = global::IPForms.Properties.Resources.left;
            this.ThresholdDecButton.Name = "ThresholdDecButton";
            this.ThresholdDecButton.UseVisualStyleBackColor = true;
            this.ThresholdDecButton.Click += new System.EventHandler(this.Decbutton_Click);
            // 
            // ThresholdIncButton
            // 
            this.ThresholdIncButton.BackColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.ThresholdIncButton, "ThresholdIncButton");
            this.ThresholdIncButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThresholdIncButton.Image = global::IPForms.Properties.Resources.right;
            this.ThresholdIncButton.Name = "ThresholdIncButton";
            this.ThresholdIncButton.UseVisualStyleBackColor = true;
            this.ThresholdIncButton.Click += new System.EventHandler(this.Incbutton_Click);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ThresholdLabel
            // 
            resources.ApplyResources(this.ThresholdLabel, "ThresholdLabel");
            this.ThresholdLabel.Name = "ThresholdLabel";
            // 
            // OneThpanel
            // 
            this.OneThpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OneThpanel.Controls.Add(this.panel1);
            this.OneThpanel.Controls.Add(this.Cancel);
            this.OneThpanel.Controls.Add(this.ThresholdLabel);
            this.OneThpanel.Controls.Add(this.OK);
            resources.ApplyResources(this.OneThpanel, "OneThpanel");
            this.OneThpanel.Name = "OneThpanel";
            // 
            // ImagePanel
            // 
            resources.ApplyResources(this.ImagePanel, "ImagePanel");
            this.ImagePanel.Controls.Add(this.pictureBox1);
            this.ImagePanel.Name = "ImagePanel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // ThresholdWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.OneThpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThresholdWindow";
            ((System.ComponentModel.ISupportInitialize)(this.ThresholdtrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.OneThpanel.ResumeLayout(false);
            this.OneThpanel.PerformLayout();
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar ThresholdtrackBar;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label ThresholdLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel OneThpanel;
        private System.Windows.Forms.Button ThresholdDecButton;
        private System.Windows.Forms.Button ThresholdIncButton;
        private System.Windows.Forms.Panel ImagePanel;
    }
}