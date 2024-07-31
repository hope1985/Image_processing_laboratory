using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class ColorChannelsWondow : Form
    {
        public ColorChannelsWondow()
        {
            InitializeComponent();
        }
        Bitmap OrginalInputImage;
        Bitmap ChangedImage;
        byte[] rgbValuesOrginalStore;
        System.Drawing.Imaging.BitmapData bitmapdata;
        byte[] rgbValues;
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
        private void checkBoxBlue_CheckedChanged(object sender, EventArgs e)
        {
            DoOperation();
        }
        private void checkBoxGreen_CheckedChanged(object sender, EventArgs e)
        {
            DoOperation();
        }
        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            DoOperation();
        }
        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ImageFilters.Generic.ImageToByteArray(ChangedImage, out bitmapdata, out  rgbValuesOrginalStore);
            ImageFilters.Generic.ByteArrayToImage(ChangedImage, rgbValuesOrginalStore,ref bitmapdata);
            pictureBox1.Image = ChangedImage;
        }
        private void DoOperation()
        {
            ChangedImage = (Bitmap)OrginalInputImage.Clone();
            ImageFilters.Generic.ImageToByteArray(ChangedImage, out bitmapdata, out rgbValues);
            //=========================================
            if (checkBoxBlue.Checked == true)
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i] = rgbValuesOrginalStore[i];

                }
            }
            else    
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i] = 0;

                }
            }
            //=========================================
            if (checkBoxGreen.Checked == true)
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i + 1] = rgbValuesOrginalStore[i + 1];

                }
            }
            else
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i + 1] = 0;

                }
            }
            //=========================================
            if (checkBoxRed.Checked == true)
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i + 2] = rgbValuesOrginalStore[i + 2];

                }
            }
            else
            {
                for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
                {
                    rgbValues[i + 2] = 0;

                }
            }
            //=========================================
            ImageFilters.Generic.ByteArrayToImage(ChangedImage, rgbValues, ref bitmapdata);
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
