using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();      
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = this.Opacity - 0.01;
                timer1.Interval =15;
            }
            else
            {
                this.Opacity = this.Opacity - 0.01;
            }
            if (Opacity < 0.01)
            {
                timer1.Enabled = false;
                this.DialogResult = DialogResult.OK;      
            }
        }
    }
}
