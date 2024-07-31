using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace IPControls
{
    public partial class HistogramControl : UserControl
    {
        ImageFilters.Histogram Hist = new ImageFilters.Histogram();
        int max;
        int []rh=new int[256];
        int []gh=new int[256];
        int []bh=new int[256];
        int[]SumHist = new int[256];
        int DivideHeight;
        int FixHeight;
        Bitmap histImage;
        Bitmap InBitmap;


        public HistogramControl()
        {
            InitializeComponent();
            histImage = new Bitmap(256, pictureBoxHist.Height);
            Clear();       
        }
        public void Clear()
        {
            rh = new int[256];
            gh = new int[256];
            bh = new int[256];
            histImage = new Bitmap(256, pictureBoxHist.Height);
            for (int i = 0; i < histImage.Width; i++)
            {
                for (int j = 0; j < histImage.Height; j++)
                {
                    histImage.SetPixel(i, j, Color.White);
                }
            }
            if (GridcheckBox.Checked == true)
            {
                MakeGride();
            }
            pictureBoxHist.Image = histImage;
        }

        private void MakeGride()
        {

            for (int j = 0; j < histImage.Height; j = j + 15)  //Row Lines
            {
                for (int i = 0; i < histImage.Width; i = i + 2)
                {

                    histImage.SetPixel(i, j, Color.Gray);
                }
            }
            //=====================================================================
            for (int i = 0; i < histImage.Width ; i = i + 15)
            {
                for (int j = 0; j < histImage.Height; j = j + 2)  //Column Lines
                {

                    histImage.SetPixel(i, j, Color.Gray);
                }
            }
           
            //=====================================================================
            pictureBoxHist.Update();
        }
        public  void SetBitmap(Bitmap InputImage)
        {
            InBitmap = InputImage;
            rh = new int[256];
            gh = new int[256];
            bh = new int[256];
            Hist.MakeHistogramData(InputImage, ref rh, ref gh, ref bh);
            SetArrays(rh, gh, bh);
        }
        private  void SetArrays(int[] r,int [] g, int[] b)
        {
            rh = new int[256];
            gh = new int[256];
            bh = new int[256];
            rh = r;
            gh = g;
            bh = b;
            if (radioButtonRed.Checked == true)
            {
                MakeHistogram(rh, Color.Red);
            }
            else if (radioButtonGreen.Checked == true)
            {
                MakeHistogram(gh, Color.Green);
            }
            else if (radioButtonBlue.Checked == true)
            {
                MakeHistogram(bh, Color.Blue);

            }
        }
        private void MakeHistogram(int []select_channel ,Color select_color)
        {

            max = select_channel[0];
            for (int i = 1; i < 256; i++)
            {
                if (select_channel[i] > max)
                    max = select_channel[i];
            }
            DivideHeight = (max / pictureBoxHist.Height);
            if (DivideHeight == 0)
                DivideHeight = 1;
            histImage = new Bitmap(256, pictureBoxHist.Height);
            
            for (int i = 0; i < 256; i++)
            {
                
                FixHeight = select_channel[i] / DivideHeight;
                for (int k = 0; k <FixHeight; k++)
                {
                    histImage.SetPixel(i, Math.Abs(k - (histImage.Height - 1)), select_color);
                }
            }

            if (GridcheckBox.Checked==true)
            {
                MakeGride();
            }
            pictureBoxHist.Image = histImage;
        }
        private void radioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            MakeHistogram(rh,Color.Red);
        }
        private void radioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            MakeHistogram(gh,Color.Green);
        }
        private void radioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            MakeHistogram(bh,Color.Blue);
        }
        private void pictureBoxHist_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X <= 260 && e.X >= 5)
            {
                if (radioButtonRed.Checked == true)
                {
                    labelLevel.Text = "Color level      :   " + (e.X - 5).ToString();

                    labelCount.Text = "Count             :   " + rh[(e.X - 5)].ToString();

                }
                else if (radioButtonGreen.Checked == true)
                {

                    labelLevel.Text = "Color level      :   " + e.X.ToString();

                    labelCount.Text = "Count             :   " + gh[(e.X - 5)].ToString().ToString();

                }
                else if (radioButtonBlue.Checked == true)
                {

                       labelLevel.Text = "Color level      :   " + (e.X - 5).ToString();

                       labelCount.Text = "Count             :   " + bh[(e.X - 5)].ToString().ToString();
                }
            }
        }
        private void textBoxSelectLevel_TextChanged(object sender, EventArgs e)
        {
                try
                {
                if (radioButtonRed.Checked == true)
                {
                    labelCount.Text = "Pixels           : " + rh[Convert.ToInt32(textBoxSelectIntensity.Text)];
                }
                else if (radioButtonGreen.Checked == true)
                {
                    labelCount.Text = "Pixels           : " + gh[Convert.ToInt32(textBoxSelectIntensity.Text)];
                }
                else if (radioButtonBlue.Checked == true)
                {
                   labelCount.Text = "Pixels           : " + bh[Convert.ToInt32(textBoxSelectIntensity.Text)];
                }
               labelLevel.Text ="Color level : "+ textBoxSelectIntensity.Text;
            }
            catch (System.Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void Grid_CheckedChanged(object sender, EventArgs e)
        {
            SetArrays(rh, gh, bh);
        }
    }
}

