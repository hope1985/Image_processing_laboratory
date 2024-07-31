//*******************************
// Arithmetic.cs file
//*******************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
   public class Arithmetic
    {
        System.Drawing.Imaging.BitmapData bitmapdata;
        byte[] rgbValues;

        public void Logarithm(Bitmap InputImage)
        {
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            //======================================================
            double Constant = 255.0 / Math.Log10(256.0);
            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                rgbValues[i] = (byte)(Constant * Math.Log10(1
                    + rgbValues[i]));
                rgbValues[i + 1] = (byte)(Constant * Math.Log10(1
                    + rgbValues[i + 1]));
                rgbValues[i + 2] = (byte)(Constant * Math.Log10(1
                    + rgbValues[i + 2]));
            }
            //======================================================
            Generic.ByteArrayToImage(InputImage, rgbValues, 
                ref bitmapdata);
        }
            //======================================================
        public void Power(Bitmap InputImage, double PowerValue)
        {

            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            //======================================================
            double Constant = 255.0 / Math.Pow(255.0, PowerValue);
            for (int i = 0; i <= rgbValues.Length - 3; i = i + 3)
            {
                rgbValues[i] = (byte)(Constant * Math.Pow(
                    rgbValues[i], PowerValue));
                rgbValues[i + 1] = (byte)(Constant * Math.Pow(
                    rgbValues[i + 1], PowerValue));
                rgbValues[i + 2] = (byte)(Constant * Math.Pow(
                    rgbValues[i + 2], PowerValue));
            }
            //======================================================
            Generic.ByteArrayToImage(InputImage, rgbValues, 
                ref bitmapdata); 
        }
    }
}
