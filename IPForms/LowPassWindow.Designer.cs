namespace IPForms
{
    partial class LowPassWindow
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
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxSelectMask = new System.Windows.Forms.GroupBox();
            this.radioButtonMask3 = new System.Windows.Forms.RadioButton();
            this.radioButtonMask2 = new System.Windows.Forms.RadioButton();
            this.radioButtonMask1 = new System.Windows.Forms.RadioButton();
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3.SuspendLayout();
            this.groupBoxSelectMask.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.groupBoxSelectMask);
            this.panel3.Controls.Add(this.Cancel);
            this.panel3.Controls.Add(this.OK);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 107);
            this.panel3.TabIndex = 11;
            // 
            // groupBoxSelectMask
            // 
            this.groupBoxSelectMask.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxSelectMask.Controls.Add(this.radioButtonMask3);
            this.groupBoxSelectMask.Controls.Add(this.radioButtonMask2);
            this.groupBoxSelectMask.Controls.Add(this.radioButtonMask1);
            this.groupBoxSelectMask.Location = new System.Drawing.Point(15, 13);
            this.groupBoxSelectMask.Name = "groupBoxSelectMask";
            this.groupBoxSelectMask.Size = new System.Drawing.Size(264, 42);
            this.groupBoxSelectMask.TabIndex = 7;
            this.groupBoxSelectMask.TabStop = false;
            this.groupBoxSelectMask.Text = "Select Mask";
            // 
            // radioButtonMask3
            // 
            this.radioButtonMask3.AutoSize = true;
            this.radioButtonMask3.Location = new System.Drawing.Point(180, 19);
            this.radioButtonMask3.Name = "radioButtonMask3";
            this.radioButtonMask3.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMask3.TabIndex = 8;
            this.radioButtonMask3.Text = "Mask 3";
            this.radioButtonMask3.UseVisualStyleBackColor = true;
            this.radioButtonMask3.MouseLeave += new System.EventHandler(this.radioButtonMask3_MouseLeave);
            this.radioButtonMask3.MouseEnter += new System.EventHandler(this.radioButtonMask3_MouseEnter);
            this.radioButtonMask3.CheckedChanged += new System.EventHandler(this.radioButtonMask3_CheckedChanged);
            // 
            // radioButtonMask2
            // 
            this.radioButtonMask2.AutoSize = true;
            this.radioButtonMask2.Location = new System.Drawing.Point(103, 19);
            this.radioButtonMask2.Name = "radioButtonMask2";
            this.radioButtonMask2.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMask2.TabIndex = 7;
            this.radioButtonMask2.Text = "Mask 2";
            this.radioButtonMask2.UseVisualStyleBackColor = true;
            this.radioButtonMask2.MouseLeave += new System.EventHandler(this.radioButtonMask2_MouseLeave);
            this.radioButtonMask2.MouseEnter += new System.EventHandler(this.radioButtonMask2_MouseEnter);
            this.radioButtonMask2.CheckedChanged += new System.EventHandler(this.radioButtonMask2_CheckedChanged);
            // 
            // radioButtonMask1
            // 
            this.radioButtonMask1.AutoSize = true;
            this.radioButtonMask1.Checked = true;
            this.radioButtonMask1.Location = new System.Drawing.Point(22, 19);
            this.radioButtonMask1.Name = "radioButtonMask1";
            this.radioButtonMask1.Size = new System.Drawing.Size(60, 17);
            this.radioButtonMask1.TabIndex = 6;
            this.radioButtonMask1.TabStop = true;
            this.radioButtonMask1.Text = "Mask 1";
            this.radioButtonMask1.UseVisualStyleBackColor = true;
            this.radioButtonMask1.MouseLeave += new System.EventHandler(this.radioButtonMask1_MouseLeave);
            this.radioButtonMask1.MouseEnter += new System.EventHandler(this.radioButtonMask1_MouseEnter);
            this.radioButtonMask1.CheckedChanged += new System.EventHandler(this.radioButtonMask1_CheckedChanged);
            // 
            // Cancel
            // 
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Location = new System.Drawing.Point(161, 72);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(76, 23);
            this.Cancel.TabIndex = 4;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // OK
            // 
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.Location = new System.Drawing.Point(63, 72);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // LowPassWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 131);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LowPassWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Low Pass Window";
            this.panel3.ResumeLayout(false);
            this.groupBoxSelectMask.ResumeLayout(false);
            this.groupBoxSelectMask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxSelectMask;
        private System.Windows.Forms.RadioButton radioButtonMask3;
        private System.Windows.Forms.RadioButton radioButtonMask2;
        private System.Windows.Forms.RadioButton radioButtonMask1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}