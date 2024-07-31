using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class PowerWindow : Form
    {
        public PowerWindow()
        {
            InitializeComponent();
            PowerLabel.Text = "Power : " + PowerValue.ToString();
        }
        ImageFilters.Arithmetic PowerFunction = new ImageFilters.Arithmetic();
        double PowerValue=1.0;
        Bitmap ChangedImage;
        Bitmap OrginalInputImage;
        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            pictureBox1.Image = ChangedImage;
        }
        private void OK_Click(object sender, EventArgs e)
        {
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        public Bitmap ReturnBitmap()
        {
            return ChangedImage;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pictureBox1.Dock = DockStyle.None;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
            if (e.Button == MouseButtons.Left)
            {
                pictureBox1.Dock = DockStyle.Fill;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void PowertrackBar_ValueChanged(object sender, EventArgs e)
        {
            PowerValue=(double)(PowertrackBar.Value)*0.05;
            ChangedImage = (Bitmap)OrginalInputImage.Clone();
            PowerFunction.Power(ChangedImage, PowerValue);
            PowerLabel.Text = "Power : " + PowerValue.ToString();
            pictureBox1.Image = ChangedImage;
        }

        private void PowerIncButton_Click(object sender, EventArgs e)
        {
            if(PowertrackBar.Value<80)
            {
                PowertrackBar.Value++;
            }
            PowerValue = (double)(PowertrackBar.Value) * 0.05;
            ChangedImage = (Bitmap)OrginalInputImage.Clone();
            PowerLabel.Text = "Power : " + PowerValue.ToString();
            PowerFunction.Power(ChangedImage, PowerValue);
            pictureBox1.Image = ChangedImage;
        }

        private void PowerDecButton_Click(object sender, EventArgs e)
        {
            if (PowertrackBar.Value > 1)
            {
                PowertrackBar.Value--;
            }
            PowerValue = (double)(PowertrackBar.Value) * 0.05;
            ChangedImage = (Bitmap)OrginalInputImage.Clone();
            PowerLabel.Text = "Power : " + PowerValue.ToString();
            PowerFunction.Power(ChangedImage, PowerValue);
            pictureBox1.Image = ChangedImage;
        }

    }
}
