namespace IPForms
{
    partial class PowerWindow
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
            this.Imagepanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PowerDecButton = new System.Windows.Forms.Button();
            this.PowerIncButton = new System.Windows.Forms.Button();
            this.PowertrackBar = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Imagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowertrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagepanel
            // 
            this.Imagepanel.AutoScroll = true;
            this.Imagepanel.Controls.Add(this.pictureBox1);
            this.Imagepanel.Location = new System.Drawing.Point(12, 12);
            this.Imagepanel.Name = "Imagepanel";
            this.Imagepanel.Size = new System.Drawing.Size(371, 208);
            this.Imagepanel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.OK);
            this.panel3.Controls.Add(this.PowerLabel);
            this.panel3.Controls.Add(this.Cancel);
            this.panel3.Location = new System.Drawing.Point(12, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 63);
            this.panel3.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PowerDecButton);
            this.panel1.Controls.Add(this.PowerIncButton);
            this.panel1.Controls.Add(this.PowertrackBar);
            this.panel1.Location = new System.Drawing.Point(13, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 25);
            this.panel1.TabIndex = 15;
            // 
            // PowerDecButton
            // 
            this.PowerDecButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.PowerDecButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PowerDecButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PowerDecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerDecButton.Image = global::IPForms.Properties.Resources.left;
            this.PowerDecButton.Location = new System.Drawing.Point(0, 0);
            this.PowerDecButton.Name = "PowerDecButton";
            this.PowerDecButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PowerDecButton.Size = new System.Drawing.Size(24, 21);
            this.PowerDecButton.TabIndex = 9;
            this.PowerDecButton.UseVisualStyleBackColor = true;
            this.PowerDecButton.Click += new System.EventHandler(this.PowerDecButton_Click);
            // 
            // PowerIncButton
            // 
            this.PowerIncButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.PowerIncButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PowerIncButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PowerIncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerIncButton.Image = global::IPForms.Properties.Resources.right;
            this.PowerIncButton.Location = new System.Drawing.Point(135, 0);
            this.PowerIncButton.Name = "PowerIncButton";
            this.PowerIncButton.Size = new System.Drawing.Size(24, 21);
            this.PowerIncButton.TabIndex = 8;
            this.PowerIncButton.UseVisualStyleBackColor = true;
            this.PowerIncButton.Click += new System.EventHandler(this.PowerIncButton_Click);
            // 
            // PowertrackBar
            // 
            this.PowertrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.PowertrackBar.Location = new System.Drawing.Point(15, -2);
            this.PowertrackBar.Maximum = 80;
            this.PowertrackBar.Minimum = 1;
            this.PowertrackBar.Name = "PowertrackBar";
            this.PowertrackBar.Size = new System.Drawing.Size(129, 45);
            this.PowertrackBar.TabIndex = 0;
            this.PowertrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.PowertrackBar.Value = 20;
            this.PowertrackBar.ValueChanged += new System.EventHandler(this.PowertrackBar_ValueChanged);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(202, 23);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // PowerLabel
            // 
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Location = new System.Drawing.Point(12, 7);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(43, 13);
            this.PowerLabel.TabIndex = 5;
            this.PowerLabel.Text = "Power :";
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(283, 23);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(76, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // PowerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 300);
            this.Controls.Add(this.Imagepanel);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PowerWindow";
            this.Text = "Power Window";
            this.Imagepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PowertrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Imagepanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PowerDecButton;
        private System.Windows.Forms.Button PowerIncButton;
        private System.Windows.Forms.TrackBar PowertrackBar;
    }
}