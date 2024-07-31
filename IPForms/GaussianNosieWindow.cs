using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class GaussianNosieWindow : Form
    {
        ImageFilters.GaussianNosie GNoise = new ImageFilters.GaussianNosie();
        double StandardDeviation = 1;
        double Mean = 10;
        Bitmap ChangedImage;
        Bitmap OrginalInputImage;
        public GaussianNosieWindow()
        {
            InitializeComponent();
            StandardDeviationLabel.Text = "Standard Deviation : " + StandardDeviation.ToString();
            Meanlabel.Text = "Mean : " + Mean.ToString();
        }

        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ChangedImage = GNoise.Gaussian_Noise((Bitmap)OrginalInputImage.Clone(), StandardDeviation,Mean);
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
        private void StandardDeviationtrackBar_ValueChanged(object sender, EventArgs e)
        {
            StandardDeviation =StandardDeviationtrackBar.Value*0.01;
            ChangedImage = GNoise.Gaussian_Noise((Bitmap)OrginalInputImage.Clone(), StandardDeviation, Mean);
            StandardDeviationLabel.Text = "Standard Deviation : " + StandardDeviation.ToString();
            pictureBox1.Image = ChangedImage;
        }

        private void MeantrackBar_ValueChanged(object sender, EventArgs e)
        {
            Mean= MeantrackBar.Value;
            ChangedImage = GNoise.Gaussian_Noise((Bitmap)OrginalInputImage.Clone(), StandardDeviation, Mean);
             Meanlabel.Text = "Mean : " + Mean.ToString();
            pictureBox1.Image = ChangedImage;
        }

        private void StandardDeviationIncButton_Click(object sender, EventArgs e)
        {
            if (StandardDeviationtrackBar.Value < 100000)        //(StandardDeviationtrackBar.Value*0.2) more or equal 1.5
            {
                StandardDeviationtrackBar.Value++;
            }
        }

        private void StandardDeviationDecButton_Click(object sender, EventArgs e)
        {
            if (StandardDeviationtrackBar.Value >1)        //(StandardDeviationtrackBar.Value*0.2) more or equal 1.5
            {
                StandardDeviationtrackBar.Value--;
            }
        }

        private void MeanIncButton_Click(object sender, EventArgs e)
        {
            if (MeantrackBar.Value < 255)       
            {
                MeantrackBar.Value++;
            }
        }

        private void MeanDecButton_Click(object sender, EventArgs e)
        {
            if (MeantrackBar.Value > 0)        
            {
                MeantrackBar.Value--;
            }
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
