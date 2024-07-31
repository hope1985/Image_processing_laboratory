//*******************************
// Gaussian Blur.cs file
//*******************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
   public class GaussianBlur
    {
        byte[] rgbValues;
        byte[] rgbValuesOut;
        System.Drawing.Imaging.BitmapData bitmapdata;
        int RowBytesImage;

        public Bitmap Gaussian_Blur(Bitmap InputImage,
            double StandardDeviation)
        {

            //=============Make Gaussian Blur mask================
            double[,] GaussianBlurMask = new double[5, 5];
            for (int x = -2; x <= 2; x++)
            {
                for (int y = -2; y <= 2; y++)
                {
                    GaussianBlurMask[x + 2, y + 2] = 
                        (1.0 / (2.0 * Math.PI * 
                        Math.Pow(StandardDeviation, 2))) *
                    (Math.Pow(Math.E, -((Math.Pow(x, 2) + 
                    Math.Pow(y, 2)) / 
                    (2.0 * Math.Pow(StandardDeviation, 2)))));
                }
            }
            //=====================================================
            double sum = 0.0;
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //=====================Perform Convolution==============
 
            for (int i = (RowBytesImage * 2 + 6); 
                i <= rgbValues.Length - (RowBytesImage * 2 + 9); 
                i = i + 3)

            {
                for (int Offset = 0; Offset < 3; Offset++)
                {
                    //Blue : Offset=0
                    //Green : Offset=1
                    //Red : Offset=2 

                    sum = 0;
                    //From left to right
                    //-----------------Column 1----------------------
                    sum = sum + GaussianBlurMask[0, 0] *  rgbValues[
                        (i - RowBytesImage * 2 - 6) + Offset];

                    sum = sum + GaussianBlurMask[1, 0] * rgbValues[
                        (i - RowBytesImage - 6) + Offset];

                    sum = sum + GaussianBlurMask[2, 0] * rgbValues[
                        (i - 6) + Offset];

                    sum = sum + GaussianBlurMask[3, 0] * rgbValues[
                        (i + RowBytesImage - 6) + Offset];

                    sum = sum + GaussianBlurMask[4, 0] * rgbValues[
                        (i + RowBytesImage * 2 - 6) + Offset];

                    //-----------------Column 2----------------------
                    sum = sum + GaussianBlurMask[0, 1] * rgbValues[
                        (i - RowBytesImage * 2 - 3) + Offset];

                    sum = sum + GaussianBlurMask[1, 1] * rgbValues[
                        (i - RowBytesImage - 3) + Offset];

                    sum = sum + GaussianBlurMask[2, 1] * rgbValues[
                        (i - 3) + Offset];

                    sum = sum + GaussianBlurMask[3, 1] * rgbValues[
                        (i + RowBytesImage - 3) + Offset];

                    sum = sum + GaussianBlurMask[4, 1] * rgbValues[
                        (i + RowBytesImage * 2 - 3) + Offset];

                    //-----------------Column 3----------------------
                    sum = sum + GaussianBlurMask[0, 2] * rgbValues[
                        (i - RowBytesImage * 2) + Offset];

                    sum = sum + GaussianBlurMask[1, 2] * rgbValues[
                        (i - RowBytesImage) + Offset];

                    sum = sum + GaussianBlurMask[2, 2] * 
                        rgbValues[i + Offset];

                    sum = sum + GaussianBlurMask[3, 2] * 
                        rgbValues[(i + RowBytesImage) + Offset];

                    sum = sum + GaussianBlurMask[4, 2] * 
                        rgbValues[(i + RowBytesImage * 2) + Offset];

                    //-----------------Column 4----------------------
                    sum = sum + GaussianBlurMask[0, 3] * 
                        rgbValues[
                        (i - RowBytesImage * 2 + 3) + Offset];

                    sum = sum + GaussianBlurMask[1, 3] * 
                        rgbValues[
                        (i - RowBytesImage + 3) + Offset];

                    sum = sum + GaussianBlurMask[2, 3] * rgbValues[
                        (i + 3) + Offset];
                    sum = sum + GaussianBlurMask[3, 3] * rgbValues[
                        (i + RowBytesImage + 3) + Offset];

                    sum = sum + GaussianBlurMask[4, 3] * rgbValues[
                        (i + RowBytesImage * 2 + 3) + Offset];

                    //-----------------Column 5----------------------
                    sum = sum + GaussianBlurMask[0, 4] *  rgbValues[
                        (i - RowBytesImage * 2 + 6) + Offset];

                    sum = sum + GaussianBlurMask[1, 4] * rgbValues[
                        (i - RowBytesImage + 6) + Offset];

                    sum = sum + GaussianBlurMask[2, 4] * 
                        rgbValues[(i + 6) + Offset];
                    sum = sum + GaussianBlurMask[3, 4] *  rgbValues[
                        (i + RowBytesImage + 6) + Offset];

                    sum = sum + GaussianBlurMask[4, 4] *  rgbValues[
                        (i + RowBytesImage * 2 + 6) + Offset];

                    if (sum > 255.0) sum = 255.0;
                    if (sum < 0) sum = 0;
                    rgbValuesOut[i + Offset] = Convert.ToByte(sum);
                }
            }
             
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
            return InputImage;
        }
    }
}
