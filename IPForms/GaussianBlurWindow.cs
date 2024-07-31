using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class GaussianBlurWindow : Form
    {
        ImageFilters.GaussianBlur GBlur = new ImageFilters.GaussianBlur();
        double StandardDeviation=1.0;         
        Bitmap ChangedImage;
        Bitmap OrginalInputImage;
        public GaussianBlurWindow()
        {
            InitializeComponent();
            StandardDeviationLabel.Text = "Standard Deviation : " + StandardDeviation.ToString();
        }

        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ChangedImage =GBlur.Gaussian_Blur((Bitmap)OrginalInputImage.Clone(),StandardDeviation);
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

        private void StandardDeviationIncButton_Click(object sender, EventArgs e)
        {
            if (StandardDeviationtrackBar.Value < 30)        //(StandardDeviationtrackBar.Value*0.05) more or equal 1.5
            {
                StandardDeviationtrackBar.Value++;
            }
        }

        private void StandardDeviationDecButton_Click(object sender, EventArgs e)  // (StandardDeviationtrackBar.Value*0.07)  less or equal 0.5
        {
            if (StandardDeviationtrackBar.Value > 14)
            {
                StandardDeviationtrackBar.Value--;
            }
        }

        private void StandardDeviationtrackBar_ValueChanged(object sender, EventArgs e)
        {
            StandardDeviation = 0.05 * StandardDeviationtrackBar.Value;
            ChangedImage = GBlur.Gaussian_Blur((Bitmap)OrginalInputImage.Clone(), StandardDeviation);      
            StandardDeviationLabel.Text = "Standard Deviation : " + StandardDeviation.ToString();
            pictureBox1.Image = ChangedImage;
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


    }
}
