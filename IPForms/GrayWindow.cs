using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{

    public partial class GrayWindow : Form
    {
        private  ImageFilters.ColorFilters Th = new ImageFilters.ColorFilters();
        private   Bitmap OrginalInputImage;
        private   Bitmap ChangedImage;

        public GrayWindow()
        {
            InitializeComponent();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
            
        }
        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            pictureBox1.Image = ChangedImage;
            if (RadioButtonAvrageCh.Checked == true)
            {
                ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone());
                pictureBox1.Image = ChangedImage;
            }
            else
            {
                if (radioButtonRedCh.Checked == true)
                {
                    ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(), 2);
                    pictureBox1.Image = ChangedImage;
                }
                else
                {
                    if (radioButtonGreenCh.Checked == true)
                    {
                        ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(), 1);
                        pictureBox1.Image = ChangedImage;
                    }
                    else
                    {
                        if (radioButtonBlueCh.Checked == true)
                        {
                            ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(), 0);
                            pictureBox1.Image = ChangedImage;
                        }
                    }
                }
            }
                
        }
        public Bitmap ReturnBitmap()
        {
            return ChangedImage;
        }
        private void RadioButtonAvrageCh_CheckedChanged(object sender, EventArgs e)
        {
            if(RadioButtonAvrageCh.Checked==true)
            {
              ChangedImage=Th.Grayscale((Bitmap)OrginalInputImage.Clone());
              pictureBox1.Image = ChangedImage;
            }
        }
        private void radioButtonRedCh_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonRedCh.Checked==true)
            {
            ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(),2);
            pictureBox1.Image = ChangedImage;
            }
        }
        private void radioButtonGreenCh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreenCh.Checked == true)
            {
                ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(), 1);
                pictureBox1.Image = ChangedImage;
            }
        }
        private void radioButtonBlueCh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlueCh.Checked == true)
            {
                ChangedImage = Th.Grayscale((Bitmap)OrginalInputImage.Clone(), 0);
                pictureBox1.Image = ChangedImage;
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
