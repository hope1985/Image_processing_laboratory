using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
   public class MotionBluring
    {
        byte[] rgbValues;
        byte[] rgbValuesOut;
        System.Drawing.Imaging.BitmapData bitmapdata;
        int RowBytesImage;

        public void MotionBluring_Operation(Bitmap InputImage)
        {

            //=====================================================
            double resultB = 0.0;
            double resultG = 0.0;
            double resultR = 0.0;

            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage *
                InputImage.Height];
            //=====================Perform Convolution==============
            int valuemblur=60;
            for (int i = 0; i < rgbValues.Length-valuemblur; i = i + 3)
            {

                //Blue : Offset=0
                //Green : Offset=1
                //Red : Offset=2 
               
                for (int j = 0; j <= valuemblur; j = j + 3)
                {
                    resultB = resultB + rgbValues[i + j];
                    resultG = resultG + rgbValues[i + j + 1];
                    resultR = resultR + rgbValues[i + j + 2];
                }
                resultR = (resultR / (valuemblur / 3));
                resultG = (resultG / (valuemblur / 3));
                resultB = (resultB / (valuemblur / 3));
                if (resultB > 255.0)
                    resultB = 255.0;
                if (resultG > 255.0)
                   resultG = 255.0;
                if (resultR > 255.0)
                    resultR = 255.0;


                rgbValuesOut[i] = Convert.ToByte(resultB);
                rgbValuesOut[i + 1] = Convert.ToByte(resultG);
                rgbValuesOut[i + 2] = Convert.ToByte(resultR);
            }

            Generic.ByteArrayToImage(InputImage, rgbValuesOut,
                ref bitmapdata);
           // return InputImage;
        }
    }
}
