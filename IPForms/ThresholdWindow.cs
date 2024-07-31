using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class ThresholdWindow : Form
    {
        private ImageFilters.ColorFilters Th = new ImageFilters.ColorFilters();
        private  Bitmap OrginalInputImage;
        private  Bitmap ChangedImage;

        public ThresholdWindow()
        {
            InitializeComponent();
            ThresholdLabel.Text = "Threshold : " + ThresholdtrackBar.Value.ToString();
        }
        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage =(Bitmap) InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ChangedImage = Th.Threshold((Bitmap)OrginalInputImage.Clone(), ThresholdtrackBar.Value);
            pictureBox1.Image = ChangedImage;
        }
        public Bitmap ReturnBitmap()
        {
            return ChangedImage;
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
        //=======================================================================
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
           
            ChangedImage = Th.Threshold((Bitmap)OrginalInputImage.Clone(), ThresholdtrackBar.Value);
            ThresholdLabel.Text = "Threshold : " + ThresholdtrackBar.Value.ToString();
            pictureBox1.Image = ChangedImage;
        }
        private void Incbutton_Click(object sender, EventArgs e)
        {
            if (ThresholdtrackBar.Value < 254)
            {
                ThresholdtrackBar.Value++;
            }
        }
        private void Decbutton_Click(object sender, EventArgs e)
        {
            if (ThresholdtrackBar.Value > 1)
            {
                ThresholdtrackBar.Value--;
            }
        }
        //=======================================================================
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
