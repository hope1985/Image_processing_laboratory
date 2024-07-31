//*******************************
// Generic.cs file
//*******************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace ImageFilters
{
  public  class Generic
    {
        public static bool IsGray(Bitmap InputImage) 
        {
          byte[] rgbValues;
          System.Drawing.Imaging.BitmapData bitmapdata;
          ImageToByteArray(InputImage,out bitmapdata ,out rgbValues);
          for (int i = 0; i <= (rgbValues.Length - 3); i = i + 3)
          {
              if ( !( (rgbValues[i] == rgbValues[i + 1] ) && 
                  (rgbValues[i + 1] == rgbValues[i + 2]) ) )
              {
                  InputImage.UnlockBits(bitmapdata);
                  return false;
              }
          } 
          InputImage.UnlockBits(bitmapdata);
          return true;
        }
        //==========================================================
        public static void SetMaxColor(ref byte[] rgbValuesOut, 
            int Position)
        {
            byte MaxColor = rgbValuesOut[Position];
            for (int i = 1; i <= 2; i++)
            {
                if (rgbValuesOut[Position + i] > MaxColor)
                {
                    MaxColor = rgbValuesOut[Position + i];
                }
            }
            rgbValuesOut[Position]   = MaxColor;
            rgbValuesOut[Position+1] = MaxColor;
            rgbValuesOut[Position+2] = MaxColor;
        }
        //==========================================================
        public static void ImageToByteArray(Bitmap InputImage, 
            out System.Drawing.Imaging.BitmapData bitmapdata, 
            out byte[] rgbValues)
        {
            Rectangle rect = new Rectangle(0, 0, InputImage.Width, 
                InputImage.Height);

            bitmapdata = InputImage.LockBits(rect, 
                System.Drawing.Imaging.ImageLockMode.ReadWrite,
                System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            IntPtr ptr = bitmapdata.Scan0;
            int bytes = bitmapdata.Stride * InputImage.Height;
            rgbValues = new byte[bytes];
            System.Runtime.InteropServices.Marshal.Copy(
                ptr, rgbValues, 0, bytes);
        }
        //==========================================================
        public static void ByteArrayToImage(Bitmap InputImage, 
            byte[] rgbValuesOut, 
            ref System.Drawing.Imaging.BitmapData bitmapdata)
        {
            IntPtr ptr = bitmapdata.Scan0;
            int bytes = bitmapdata.Stride * InputImage.Height;
            System.Runtime.InteropServices.Marshal.Copy(
                rgbValuesOut, 0, ptr, bytes);
            InputImage.UnlockBits(bitmapdata);
        }
        public enum Mask { Sobel, Prewitt, Laplacian4Neighbors, 
            Laplacian8Neighbors };
        public enum MedianPassArea{ MedianPass3x3, MedianPass5x5, 
            MedianPass7x7 };
        //==========================================================
        #region Masks

        public static int[,] HighPassMask1 = { 
                                    { 0 ,-1 , 0 },
                                    {-1 , 5 ,-1 },
                                    { 0 ,-1 , 0 }         
                                  };
        public static int[,] HighPassMask2 = { 
                                    {-1 ,-1 ,-1 },
                                    {-1 , 9 ,-1 },
                                    {-1 ,-1 ,-1 }         
                                  };
        public static int[,] HighPassMask3 = { 
                                    { 1 ,-2 , 1 },
                                    {-2 , 5 ,-2 },
                                    { 1 ,-2 , 1 }         
                                  };
        //==========================================================
        public static int[,] LowPassMask1 ={
                                  { 1 , 1 , 1},
                                  { 1 , 1 , 1},
                                  { 1 , 1 , 1} 
                                };
        public static int[,] LowPassMask2 ={
                                  { 1 , 1 , 1},
                                  { 1 , 2 , 1},
                                  { 1 , 1 , 1} 
                                };
        public static int[,] LowPassMask3 ={
                                  { 1 , 2 , 1},
                                  { 2 , 4 , 2},
                                  { 1 , 2 , 1} 
                                };
        //==========================================================
        public static int[,] LaplacianOfGaussianMask=  { 
                                      { 0, 0,-1, 0, 0},
                                      { 0,-1,-2,-1, 0},
                                      {-1,-2,16,-2,-1},
                                      { 0,-1,-2,-1, 0},
                                      { 0, 0,-1, 0, 0},
                                     };
        //==========================================================
        public static int[,] LaplacianMask4Neighbors ={ 
                                       { 0 , 1 , 0},
                                       { 1 ,-4 , 1},
                                       { 0 , 1 , 0} 
                                                    };
        public static int[,] LaplacianMask8Neighbors ={  
                                       { 1 , 1 , 1},
                                       { 1 ,-8 , 1},
                                       { 1 , 1 , 1} 
                                                     };
        //==========================================================
        public static int[,] SobelMaskV =  {
                                              { 1 , 2 , 1 },
                                              { 0 , 0 , 0 },
                                              {-1 ,-2 ,-1 } 
                                            };
        public static int[,] SobelMaskH =  {   
                                            {-1 , 0 , 1 },
                                            {-2 , 0 , 2 },
                                            {-1 , 0 , 1 } 
                                            };
        //==========================================================
        public static int[, ] PrewittMaskV ={  
                                                { 1 , 1 , 1 },
                                                { 0 , 0 , 0 },
                                                {-1 ,-1 ,-1 } 
                                             };

        public static int[,] PrewittMaskH = {  
                                                {-1 , 0 , 1 },
                                                {-1 , 0 , 1 },
                                                {-1 , 0 , 1 } 
                                              };
        //==========================================================
       public static int[,,] KirschMask ={
            {  
                                  { 5 , 5, 5 },
                                  {-3 , 0,-3 },
                                  {-3 ,-3,-3 } 
                               },
                               {  
                                  {-3 , 5, 5 },
                                  {-3 , 0, 5 },
                                  {-3 ,-3,-3 }  
                               },
                               {  
                                  {-3 ,-3, 5 },
                                  {-3 , 0, 5 },
                                  {-3 ,-3, 5 } 
                               },
                               {  
                                  {-3 ,-3,-3 },
                                  {-3 , 0, 5 },
                                  {-3 , 5, 5 } 
                               },
                               {  
                                  {-3 ,-3,-3 },
                                  {-3 , 0,-3 },
                                  { 5 , 5, 5 } 
                               },
                                {  
                                  {-3 ,-3,-3 },
                                  { 5 , 0,-3 },
                                  { 5 , 5,-3 } 
                               },
                                {  
                                  { 5 ,-3,-3 },
                                  { 5 , 0,-3 },
                                  { 5 ,-3,-3 } 
                               },
                               {  
                                  { 5 , 5,-3 },
                                  { 5 , 0,-3 },
                                  {-3 ,-3,-3 } 
                               }
                            };
  
        #endregion
    }         
}
