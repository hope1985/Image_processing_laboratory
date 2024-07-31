using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    
    public partial class ImageWindow : Form
    {

        public ImageWindow()
        {
            InitializeComponent();
           
        }
        Bitmap InputImage;
     
        public void SetBitmap(Bitmap InputBitmap)
        {
            InputImage=InputBitmap;
            pictureBox1.Height = InputBitmap.Height;
            pictureBox1.Width = InputBitmap.Width;
            pictureBox1.Image=InputBitmap;
            this.Text = InputImage.Size.Width.ToString() + "x" + InputImage.Size.Height.ToString();
        }
        bool SelectZoom = true;
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (e.Button == MouseButtons.Right && SelectZoom == true)
                {
                    pictureBox1.Dock = DockStyle.None;
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    SelectZoom = false;
                }
                else
                {
                    if (e.Button == MouseButtons.Right && SelectZoom ==false)
                    {
                        pictureBox1.Dock = DockStyle.Fill;
                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;            
                        SelectZoom =true;
                    }
                }
            }
        }

        private void ImageWindow_SizeChanged(object sender, EventArgs e)
        {
              if (!(this.WindowState == FormWindowState.Maximized))
              {
                    pictureBox1.Dock = DockStyle.None;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
              
              }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
              if (this.WindowState == FormWindowState.Maximized && !(pictureBox1.Dock == DockStyle.Fill) )
              {
                  toolTip1.Show("Double click right mouse button for fit size", pictureBox1, 0, 0, 3000);
              }
        }

    }
}
