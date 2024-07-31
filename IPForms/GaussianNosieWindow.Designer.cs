namespace IPForms
{
    partial class GaussianNosieWindow
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.MeanDecButton = new System.Windows.Forms.Button();
            this.MeanIncButton = new System.Windows.Forms.Button();
            this.MeantrackBar = new System.Windows.Forms.TrackBar();
            this.Meanlabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StandardDeviationDecButton = new System.Windows.Forms.Button();
            this.StandardDeviationIncButton = new System.Windows.Forms.Button();
            this.StandardDeviationtrackBar = new System.Windows.Forms.TrackBar();
            this.OK = new System.Windows.Forms.Button();
            this.StandardDeviationLabel = new System.Windows.Forms.Label();
            this.Imagepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeantrackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StandardDeviationtrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Imagepanel
            // 
            this.Imagepanel.AutoScroll = true;
            this.Imagepanel.Controls.Add(this.pictureBox1);
            this.Imagepanel.Location = new System.Drawing.Point(12, 12);
            this.Imagepanel.Name = "Imagepanel";
            this.Imagepanel.Size = new System.Drawing.Size(364, 208);
            this.Imagepanel.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.Meanlabel);
            this.panel3.Controls.Add(this.Cancel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.OK);
            this.panel3.Controls.Add(this.StandardDeviationLabel);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 115);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.MeanDecButton);
            this.panel2.Controls.Add(this.MeanIncButton);
            this.panel2.Controls.Add(this.MeantrackBar);
            this.panel2.Location = new System.Drawing.Point(18, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 25);
            this.panel2.TabIndex = 6;
            // 
            // MeanDecButton
            // 
            this.MeanDecButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.MeanDecButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeanDecButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MeanDecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeanDecButton.Image = global::IPForms.Properties.Resources.left;
            this.MeanDecButton.Location = new System.Drawing.Point(0, 0);
            this.MeanDecButton.Name = "MeanDecButton";
            this.MeanDecButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MeanDecButton.Size = new System.Drawing.Size(24, 21);
            this.MeanDecButton.TabIndex = 9;
            this.MeanDecButton.UseVisualStyleBackColor = true;
            this.MeanDecButton.Click += new System.EventHandler(this.MeanDecButton_Click);
            // 
            // MeanIncButton
            // 
            this.MeanIncButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.MeanIncButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeanIncButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MeanIncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeanIncButton.Image = global::IPForms.Properties.Resources.right;
            this.MeanIncButton.Location = new System.Drawing.Point(135, 0);
            this.MeanIncButton.Name = "MeanIncButton";
            this.MeanIncButton.Size = new System.Drawing.Size(24, 21);
            this.MeanIncButton.TabIndex = 8;
            this.MeanIncButton.UseVisualStyleBackColor = true;
            this.MeanIncButton.Click += new System.EventHandler(this.MeanIncButton_Click);
            // 
            // MeantrackBar
            // 
            this.MeantrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.MeantrackBar.Location = new System.Drawing.Point(15, -2);
            this.MeantrackBar.Maximum = 255;
            this.MeantrackBar.Name = "MeantrackBar";
            this.MeantrackBar.Size = new System.Drawing.Size(129, 45);
            this.MeantrackBar.TabIndex = 0;
            this.MeantrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MeantrackBar.Value = 80;
            this.MeantrackBar.ValueChanged += new System.EventHandler(this.MeantrackBar_ValueChanged);
            // 
            // Meanlabel
            // 
            this.Meanlabel.AutoSize = true;
            this.Meanlabel.Location = new System.Drawing.Point(15, 56);
            this.Meanlabel.Name = "Meanlabel";
            this.Meanlabel.Size = new System.Drawing.Size(40, 13);
            this.Meanlabel.TabIndex = 7;
            this.Meanlabel.Text = "Mean :";
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(262, 72);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(76, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.StandardDeviationDecButton);
            this.panel1.Controls.Add(this.StandardDeviationIncButton);
            this.panel1.Controls.Add(this.StandardDeviationtrackBar);
            this.panel1.Location = new System.Drawing.Point(16, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 25);
            this.panel1.TabIndex = 3;
            // 
            // StandardDeviationDecButton
            // 
            this.StandardDeviationDecButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.StandardDeviationDecButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StandardDeviationDecButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.StandardDeviationDecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardDeviationDecButton.Image = global::IPForms.Properties.Resources.left;
            this.StandardDeviationDecButton.Location = new System.Drawing.Point(0, 0);
            this.StandardDeviationDecButton.Name = "StandardDeviationDecButton";
            this.StandardDeviationDecButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StandardDeviationDecButton.Size = new System.Drawing.Size(24, 21);
            this.StandardDeviationDecButton.TabIndex = 9;
            this.StandardDeviationDecButton.UseVisualStyleBackColor = true;
            this.StandardDeviationDecButton.Click += new System.EventHandler(this.StandardDeviationDecButton_Click);
            // 
            // StandardDeviationIncButton
            // 
            this.StandardDeviationIncButton.BackColor = System.Drawing.SystemColors.ControlText;
            this.StandardDeviationIncButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StandardDeviationIncButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.StandardDeviationIncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardDeviationIncButton.Image = global::IPForms.Properties.Resources.right;
            this.StandardDeviationIncButton.Location = new System.Drawing.Point(135, 0);
            this.StandardDeviationIncButton.Name = "StandardDeviationIncButton";
            this.StandardDeviationIncButton.Size = new System.Drawing.Size(24, 21);
            this.StandardDeviationIncButton.TabIndex = 8;
            this.StandardDeviationIncButton.UseVisualStyleBackColor = true;
            this.StandardDeviationIncButton.Click += new System.EventHandler(this.StandardDeviationIncButton_Click);
            // 
            // StandardDeviationtrackBar
            // 
            this.StandardDeviationtrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.StandardDeviationtrackBar.Location = new System.Drawing.Point(15, -2);
            this.StandardDeviationtrackBar.Maximum = 100000;
            this.StandardDeviationtrackBar.Minimum = 1;
            this.StandardDeviationtrackBar.Name = "StandardDeviationtrackBar";
            this.StandardDeviationtrackBar.Size = new System.Drawing.Size(129, 45);
            this.StandardDeviationtrackBar.TabIndex = 0;
            this.StandardDeviationtrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.StandardDeviationtrackBar.Value = 5;
            this.StandardDeviationtrackBar.ValueChanged += new System.EventHandler(this.StandardDeviationtrackBar_ValueChanged);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(263, 21);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // StandardDeviationLabel
            // 
            this.StandardDeviationLabel.AutoSize = true;
            this.StandardDeviationLabel.Location = new System.Drawing.Point(13, 5);
            this.StandardDeviationLabel.Name = "StandardDeviationLabel";
            this.StandardDeviationLabel.Size = new System.Drawing.Size(104, 13);
            this.StandardDeviationLabel.TabIndex = 5;
            this.StandardDeviationLabel.Text = "Standard Deviation :";
            // 
            // GaussianNosieWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 347);
            this.Controls.Add(this.Imagepanel);
            this.Controls.Add(this.panel3);
            this.Name = "GaussianNosieWindow";
            this.Text = "GaussianNosieWindow";
            this.Imagepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MeantrackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StandardDeviationtrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Imagepanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StandardDeviationDecButton;
        private System.Windows.Forms.Button StandardDeviationIncButton;
        private System.Windows.Forms.TrackBar StandardDeviationtrackBar;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label StandardDeviationLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MeanDecButton;
        private System.Windows.Forms.Button MeanIncButton;
        private System.Windows.Forms.TrackBar MeantrackBar;
        private System.Windows.Forms.Label Meanlabel;

    }
}