//*******************************
// Histogram.cs file
//*******************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
    public class Histogram
    {
        System.Drawing.Imaging.BitmapData bitmapdata;
        byte[] rgbValues;
        int[] Hr = new int[256];
        int[] Hg = new int[256];
        int[] Hb = new int[256];
        int[] HsR = new int[256];
        int[] HsG = new int[256];
        int[] HsB = new int[256];
        byte[] EqHistR = new byte[256];
        byte[] EqHistG = new byte[256];
        byte[] EqHistB = new byte[256];
        double pixels;

        public void HistogramEqualization(Bitmap InputImage)
        {
            Hr = new int[256];
            Hg = new int[256];
            Hb = new int[256];
            MakeHistogramData(InputImage, ref Hr, ref Hg, ref Hb);
            //=======================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            //=======================================================
            HsR[0] = Hr[0];
            HsG[0] = Hg[0];
            HsB[0] = Hb[0];      
            for (int j = 1; j < 256; j++)
            {
                HsR[j] = Hr[j] + HsR[j - 1];
                HsG[j] = Hg[j] + HsG[j - 1];
                HsB[j] = Hb[j] + HsB[j - 1];
            }
            //=======================================================
            pixels = InputImage.Height * InputImage.Width;
            for (int k = 0; k < 256; k++)
            {
                EqHistR[k] = (byte)Math.Floor(
                    (256.0 / pixels) * (double)HsR[k]);
                EqHistG[k] = (byte)Math.Floor(
                    (256.0 / pixels) * (double)HsG[k]);
                EqHistB[k] = (byte)Math.Floor(
                    (256.0 / pixels) * (double)HsB[k]);
            }
            //=======================================================
            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                rgbValues[i]     = EqHistB[rgbValues[i]];
                rgbValues[i + 1] = EqHistG[rgbValues[i+1]];
                rgbValues[i + 2] = EqHistR[rgbValues[i+2]];
            }
            //=======================================================
            Generic.ByteArrayToImage(InputImage, rgbValues,
                ref bitmapdata);

        }
        //=========================================================
        public void MakeHistogramData(Bitmap InputBitmap, 
            ref int[] r, ref int[] g, ref int[] b)
        {
            int red, green, blue;
            Generic.ImageToByteArray(InputBitmap, out bitmapdata,
                out rgbValues);

            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                red   = rgbValues[i + 2];
                green = rgbValues[i + 1];
                blue  = rgbValues[i];
                r[red]   = r[red]   + 1;
                g[green] = g[green] + 1;
                b[blue]  = b[blue]  + 1;
            }

            InputBitmap.UnlockBits(bitmapdata);
        }
    }
}
