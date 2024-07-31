//*******************************
// ColorFilters.cs file
//*******************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
    public class ColorFilters
    {
        System.Drawing.Imaging.BitmapData bitmapdata;
        byte[] rgbValues;
        //==========================================================
        public Bitmap Grayscale(Bitmap InputImage)
        {
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);

            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                rgbValues[i] = rgbValues[i + 1] = rgbValues[i + 2] = 
                Convert.ToByte(
                (Convert.ToInt32(rgbValues[i]) + 
                Convert.ToInt32(rgbValues[i + 1]) + 
                Convert.ToInt32(rgbValues[i + 2])) / 3);
            }
            Generic.ByteArrayToImage(InputImage, rgbValues,
                ref bitmapdata);
            return InputImage;
        }
        //==========================================================
        public Bitmap Grayscale(Bitmap InputImage, int SelectColor)
        {
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);          
            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                //SelectColor=0 : Replace Blue 
                //SelectColor=1 : Replace Green
                //SelectColor=2 : Replace Red
                rgbValues[i] = rgbValues[i + 1] =
                rgbValues[i + 2] =  rgbValues[i + SelectColor];
            }
            Generic.ByteArrayToImage(InputImage, rgbValues,
                ref bitmapdata);
            return InputImage;
        }
        //==========================================================
        public Bitmap Invert(Bitmap InputImage)
        {
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            for (int i = 0; i < rgbValues.Length; i++)
            {
                //255 Xor rgbValues[i]
                rgbValues[i] = Convert.ToByte(255 ^ rgbValues[i]);   
            }
            Generic.ByteArrayToImage(InputImage, rgbValues,
                ref bitmapdata);
            return InputImage;
        }
        //==========================================================
        public Bitmap Threshold(Bitmap InputImage, int Threshold)
        {
            Grayscale(InputImage);
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            for (int i = 0; i < rgbValues.Length; i++)
            {
                if (rgbValues[i] > Threshold)
                {
                    rgbValues[i] = 255;
                }
                else
                {
                    rgbValues[i] = 0;
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValues,
                ref bitmapdata);
            return InputImage;
        }

    }
}
