//*******************************
// SpatialDomainFilters.cs file
//*******************************

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace ImageFilters
{
    public class SpatialDomainFilters
    {
        byte[] rgbValues;
        byte[] rgbValuesOut;
        System.Drawing.Imaging.BitmapData bitmapdata;
        int RowBytesImage;
        //========================================================
        public Bitmap LowPassFilter(Bitmap InputImage, 
            int[,] LowPassMask, double DivideNumber)
        {          
            double sum = 0.0;
            //===================================================  
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height]; 
            //==================Perform Convolution==============
            for (int i = RowBytesImage + 3; i <= rgbValues.Length -
                (RowBytesImage + 6); i = i + 3)
            {
                for (int Offset = 0; Offset < 3; Offset++)
                {
                    //Blue : Offset=0
                    //Green : Offset=1 
                    //Red : Offset=2 

                    sum = 0;
                    sum = sum + LowPassMask[0, 0] * 
                        rgbValues[(i - 3 - RowBytesImage) + Offset];
                    sum = sum + LowPassMask[1, 0] * 
                        rgbValues[(i - 3) + Offset];
                    sum = sum + LowPassMask[2, 0] * 
                        rgbValues[(i - 3 + RowBytesImage) + Offset];
                    sum = sum + LowPassMask[0, 1] * 
                        rgbValues[(i - RowBytesImage) + Offset];
                    //center pixel 
                    sum = sum + LowPassMask[1, 1] * 
                        rgbValues[i + Offset]; 
                    sum = sum + LowPassMask[2, 1] * 
                        rgbValues[(i + RowBytesImage) + Offset];
                    sum = sum + LowPassMask[0, 2] * 
                        rgbValues[(i - RowBytesImage + 3) + Offset];
                    sum = sum + LowPassMask[1, 2] * 
                        rgbValues[(i + 3) + Offset];
                    sum = sum + LowPassMask[2, 2] * 
                        rgbValues[(i + 3 + RowBytesImage) + Offset];
                    sum = sum / DivideNumber;
                    if (sum > 255) sum = 255;
                    if (sum < 0) sum = 0;
                    rgbValuesOut[i + Offset] = Convert.ToByte(sum);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
            return InputImage;
        }
        //=================================================== 
        public void MedianPassFilter(Bitmap InputImage,
            int SelectArea)
        {
            byte[] Area = new byte[9];
            byte med;
            //===================================================     
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //=================================================== 
            if (SelectArea == 
                (int)Generic.MedianPassArea.MedianPass3x3)
            {
                Area = new byte[9];
                for (int i = RowBytesImage + 3; i <=
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1 
                        //Red : Offset=2                   
                        Area[0] = rgbValues[
                            (i - 3 - RowBytesImage) + Offset];
                        Area[1] = rgbValues[
                            (i - 3) + Offset];
                        Area[2] = rgbValues[
                            (i - 3 + RowBytesImage) + Offset];
                        Area[3] = rgbValues[
                            (i - RowBytesImage) + Offset];
                        Area[4] = rgbValues[i + Offset];
                        Area[5] = rgbValues[
                            (i + RowBytesImage) + Offset];
                        Area[6] = rgbValues[
                            (i - RowBytesImage + 3) + Offset];
                        Area[7] = rgbValues[
                            (i + 3) + Offset];
                        Area[8] = rgbValues[
                            (i + 3 + RowBytesImage) + Offset];
                        Array.Sort(Area);
                        med = Area[4];
                        rgbValuesOut[i + Offset] = med;
                    }
                }
            }
            //=================================================== 
            else if (SelectArea == 
                (int)Generic.MedianPassArea.MedianPass5x5)
            {
                Area = new byte[25];
                for (int i = (RowBytesImage * 2 + 6); i <= 
                    rgbValues.Length - (RowBytesImage * 2 + 9);
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1 
                        //Red : Offset=2 
  
                        //Column 1
                        Area[0] = rgbValues[
                            (i - RowBytesImage * 2 - 6) + Offset];
                        Area[1] = rgbValues[
                            (i - RowBytesImage - 6) + Offset];
                        Area[2] = rgbValues[
                            (i - 6) + Offset];
                        Area[3] = rgbValues[
                            (i + RowBytesImage - 6) + Offset];
                        Area[4] = rgbValues[
                            (i + RowBytesImage * 2 - 6) + Offset];
                        //Column 2
                        Area[5] = rgbValues[
                            (i - RowBytesImage * 2 - 3) + Offset];
                        Area[6] = rgbValues[
                            (i - RowBytesImage - 3) + Offset];
                        Area[7] = rgbValues[
                            (i - 3) + Offset];
                        Area[8] = rgbValues[
                            (i + RowBytesImage - 3) + Offset];
                        Area[9] = rgbValues[
                            (i + RowBytesImage * 2 - 3) + Offset];
                        //Column 3
                        Area[10] = rgbValues[
                            (i - RowBytesImage * 2) + Offset];
                        Area[11] = rgbValues[
                            (i - RowBytesImage) + Offset];
                        Area[12] = rgbValues[i + Offset];
                        Area[13] = rgbValues[
                            (i + RowBytesImage) + Offset];
                        Area[14] = rgbValues[
                            (i + RowBytesImage * 2) + Offset];
                        //Column 4
                        Area[15] = rgbValues[
                            (i - RowBytesImage * 2 + 3) + Offset];
                        Area[16] = rgbValues[
                            (i - RowBytesImage + 3) + Offset];
                        Area[17] = rgbValues[
                            (i + 3) + Offset];
                        Area[18] = rgbValues[
                            (i + RowBytesImage + 3) + Offset];
                        Area[19] = rgbValues[
                            (i + RowBytesImage * 2 + 3) + Offset];
                        //Column 5
                        Area[20] = rgbValues[
                            (i - RowBytesImage * 2 + 6) + Offset];
                        Area[21] = rgbValues[
                            (i - RowBytesImage + 6) + Offset];
                        Area[22] = rgbValues[
                            (i + 6) + Offset];
                        Area[23] = rgbValues[
                            (i + RowBytesImage + 6) + Offset];
                        Area[24] = rgbValues[
                            (i + RowBytesImage * 2 + 6) + Offset];

                        Array.Sort(Area);
                        med = Area[12];
                        rgbValuesOut[i + Offset] = med;
                    }
                }
            }
            else if (SelectArea == 
                (int)Generic.MedianPassArea.MedianPass7x7)
            {
                Area = new byte[49];
                for (int i = (RowBytesImage * 3 + 9); 
                    i <= rgbValues.Length - (RowBytesImage * 3 + 12);
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1 
                        //Red : Offset=2 

                        //Column 1
                        Area[0] = rgbValues[
                            (i - RowBytesImage * 3 - 9) + Offset];
                        Area[1] = rgbValues[
                            (i - RowBytesImage*2 - 9) + Offset];
                        Area[2] = rgbValues[
                            (i - RowBytesImage * 2 - 9) + Offset];
                        Area[3] = rgbValues[
                            (i - 9) + Offset];
                        Area[4] = rgbValues[
                            (i + RowBytesImage - 9) + Offset];
                        Area[5] = rgbValues[
                            (i + RowBytesImage * 2 - 9) + Offset];
                        Area[6] = rgbValues[
                            (i + RowBytesImage * 3 - 9) + Offset];
                        //Column 2
                        Area[7] = rgbValues[
                            (i - RowBytesImage * 3 - 6) + Offset];
                        Area[8] = rgbValues[
                            (i - RowBytesImage * 2 - 6) + Offset];
                        Area[9] = rgbValues[
                            (i - RowBytesImage * 2 - 6) + Offset];
                        Area[10] = rgbValues[(i - 6) + Offset];
                        Area[11] = rgbValues[
                            (i + RowBytesImage - 6) + Offset];
                        Area[12] = rgbValues[
                            (i + RowBytesImage * 2 - 6) + Offset];
                        Area[13] = rgbValues[
                            (i + RowBytesImage * 3 - 6) + Offset];
                        //Column 3
                        Area[14] = rgbValues[
                            (i - RowBytesImage * 3 - 3) + Offset];
                        Area[15] = rgbValues[
                            (i - RowBytesImage * 2 - 3) + Offset];
                        Area[16] = rgbValues[
                            (i - RowBytesImage * 2 - 3) + Offset];
                        Area[17] = rgbValues[
                            (i - 3) + Offset];
                        Area[18] = rgbValues[
                            (i + RowBytesImage - 3) + Offset];
                        Area[19] = rgbValues[
                            (i + RowBytesImage * 2 - 3) + Offset];
                        Area[20] = rgbValues[
                            (i + RowBytesImage * 3 - 3) + Offset];
                        //Column 4
                        Area[21] = rgbValues[
                            (i - RowBytesImage * 3) + Offset];
                        Area[22] = rgbValues[
                            (i - RowBytesImage * 2 ) + Offset];
                        Area[23] = rgbValues[
                            (i - RowBytesImage * 2 ) + Offset];
                        Area[24] = rgbValues[(i ) + Offset];
                        Area[25] = rgbValues[
                            (i + RowBytesImage ) + Offset];
                        Area[26] = rgbValues[
                            (i + RowBytesImage * 2 ) + Offset];
                        Area[27] = rgbValues[
                            (i + RowBytesImage * 3 ) + Offset];
                        //Column 5
                        Area[28] = rgbValues[
                            (i - RowBytesImage * 3 + 3) + Offset];
                        Area[29] = rgbValues[
                            (i - RowBytesImage * 2 + 3) + Offset];
                        Area[30] = rgbValues[
                            (i - RowBytesImage * 2 + 3) + Offset];
                        Area[31] = rgbValues[(i + 3) + Offset];
                        Area[32] = rgbValues[
                            (i + RowBytesImage + 3) + Offset];
                        Area[33] = rgbValues[
                            (i + RowBytesImage * 2 + 3) + Offset];
                        Area[34] = rgbValues[
                            (i + RowBytesImage * 3 + 3) + Offset];
                        //Column 6
                        Area[35] = rgbValues[
                            (i - RowBytesImage * 3 + 6) + Offset];
                        Area[36] = rgbValues[
                            (i - RowBytesImage * 2 + 6) + Offset];
                        Area[37] = rgbValues[
                            (i - RowBytesImage * 2 + 6) + Offset];
                        Area[38] = rgbValues[(i + 6) + Offset];
                        Area[39] = rgbValues[
                            (i + RowBytesImage + 6) + Offset];
                        Area[40] = rgbValues[
                            (i + RowBytesImage * 2 + 6) + Offset];
                        Area[41] = rgbValues[
                            (i + RowBytesImage * 3 + 6) + Offset];
                        //Column 7
                        Area[42] = rgbValues[
                            (i - RowBytesImage * 3 + 9) + Offset];
                        Area[43] = rgbValues[
                            (i - RowBytesImage * 2 + 9) + Offset];
                        Area[44] = rgbValues[
                            (i - RowBytesImage * 2 + 9) + Offset];
                        Area[45] = rgbValues[
                            (i + 9) + Offset];
                        Area[46] = rgbValues[
                            (i + RowBytesImage + 9) + Offset];
                        Area[47] = rgbValues[
                            (i + RowBytesImage * 2 + 9) + Offset];
                        Area[48] = rgbValues[
                            (i + RowBytesImage * 3 + 9) + Offset];

                        Array.Sort(Area);
                        med = Area[24];
                        rgbValuesOut[i + Offset] = med;
                    }
                }
            }
            //===================================================
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
        }
        //===================================================  
        public Bitmap HighPassFilter(Bitmap InputImage,
            int[,] HighassMask)
        {
            double sum = 0.0;
            //====================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //==================Perform Convolution==============    
            for (int i = RowBytesImage + 3; i <= 
                rgbValues.Length - (RowBytesImage + 6); i = i + 3)
            {
                for (int Offset = 0; Offset < 3; Offset++)
                {
                    //Blue : Offset=0
                    //Green : Offset=1
                    //Red : Offset=2 

                    sum = 0;
                    sum = sum + HighassMask[0, 0] * 
                        rgbValues[(i - 3 - RowBytesImage) + Offset];
                    sum = sum + HighassMask[1, 0] * 
                        rgbValues[(i - 3) + Offset];
                    sum = sum + HighassMask[2, 0] *
                        rgbValues[(i - 3 + RowBytesImage) + Offset];
                    sum = sum + HighassMask[0, 1] *
                        rgbValues[(i - RowBytesImage) + Offset];
                    sum = sum + HighassMask[1, 1] * 
                        rgbValues[i + Offset];
                    sum = sum + HighassMask[2, 1] *
                        rgbValues[(i + RowBytesImage) + Offset];
                    sum = sum + HighassMask[0, 2] *
                        rgbValues[(i - RowBytesImage + 3) + Offset];
                    sum = sum + HighassMask[1, 2] *
                        rgbValues[(i + 3) + Offset];
                    sum = sum + HighassMask[2, 2] *
                        rgbValues[(i + 3 + RowBytesImage) + Offset];
                    if (sum > 255) sum = 255;
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
