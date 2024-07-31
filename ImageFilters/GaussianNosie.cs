using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
   public class GaussianNosie
    {
        byte[] rgbValues;
        byte[] rgbValuesOut;
        System.Drawing.Imaging.BitmapData bitmapdata;
        int RowBytesImage;
        Random s = new Random();
        ColorFilters CF = new ColorFilters();

        public Bitmap Gaussian_Noise(Bitmap InputImage,
            double StandardDeviation, double Mean)
        {
           Bitmap InputGrayImage = CF.Grayscale((Bitmap)InputImage.Clone());
            //=============Make Gaussian Blur mask================
           double sum = 0;
            double[] GaussianNoiseArray = new double[256];
            for (int z = 0; z <256; z++)
            {

                GaussianNoiseArray[z] =
                     (1.0 / ((Math.Pow(2.0 * Math.PI, 0.5))* StandardDeviation) )*
                 (Math.Exp(-((Math.Pow(z - Mean, 2.0)) / (2.0*(Math.Pow(StandardDeviation, 2.0))))));
            }
            

            //=====================================================
            double result = 0.0;
            Generic.ImageToByteArray(InputGrayImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage *
                InputGrayImage.Height];

            //=====================Perform Convolution=============

            int rnd;
            for (int i = 0; i < rgbValues.Length; i = i + 3)
            {

                    //Blue : Offset=0
                    //Green : Offset=1
                    //Red : Offset=2 
                rnd = (s.Next(255));
                result =rnd*rnd*GaussianNoiseArray[rnd]+rgbValues[i];
                    if (result > 255.0)
                        result = 255.0;

                    rgbValuesOut[i] = Convert.ToByte(result);
                    rgbValuesOut[i+1] = Convert.ToByte(result);
                    rgbValuesOut[i+2] = Convert.ToByte(result);
            }

            Generic.ByteArrayToImage(InputGrayImage, rgbValuesOut,
                ref bitmapdata);
            return InputGrayImage;
        }
    }
}
