//*******************************
// EdgeDetectors.cs file
//*******************************


using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;


namespace ImageFilters
{

    public class EdgeDetectors
    {
        System.Drawing.Imaging.BitmapData bitmapdata;
        byte[] rgbValues;
        byte[] rgbValuesOut;
        int RowBytesImage;
        //======================================================
        public void HomogeneityOperator(Bitmap InputImage)
        {
            int[] arrayOperator = new int[8];
            int Max;
            bool IsGray = Generic.IsGray(InputImage);
            //====================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //====================================================
            if (IsGray == true)
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6);
                    i = i + 3)
                {
                    Max = 0;
                    arrayOperator[0] = 
                        Math.Abs(rgbValues[i] -
                        rgbValues[i - 3 - RowBytesImage]);
                    arrayOperator[1] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i - 3]);
                    arrayOperator[2] =
                        Math.Abs(rgbValues[i] -
                        rgbValues[i - 3 + RowBytesImage]);
                    arrayOperator[3] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i - RowBytesImage]);
                    arrayOperator[4] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i + RowBytesImage]);
                    arrayOperator[5] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i - RowBytesImage + 3]);
                    arrayOperator[6] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i + 3]);
                    arrayOperator[7] = 
                        Math.Abs(rgbValues[i] - 
                        rgbValues[i + 3 + RowBytesImage]);
                    Max = arrayOperator[0];
                    for (int j = 1; i < 8; j++)
                    {
                        if (arrayOperator[j] > Max)
                        {
                            Max = arrayOperator[j];
                        }
                    }
                    rgbValuesOut[i] = rgbValuesOut[i + 1] =
                        rgbValuesOut[i + 2] = Convert.ToByte(Max);
                }
            }
            //=====================================================
            else
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2 

                        Max = 0;
                        arrayOperator[0] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i - 3 - RowBytesImage) + Offset]);
                        arrayOperator[1] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i - 3) + Offset]);
                        arrayOperator[2] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i - 3 + RowBytesImage) + Offset]);
                        arrayOperator[3] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i - RowBytesImage) + Offset]);
                        arrayOperator[4] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i + RowBytesImage) + Offset]);
                        arrayOperator[5] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i - RowBytesImage + 3) + Offset]);
                        arrayOperator[6] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i + 3) + Offset]);
                        arrayOperator[7] = Math.Abs(
                            rgbValues[i + Offset] - rgbValues[
                            (i + 3 + RowBytesImage) + Offset]);
                        Max = arrayOperator[0];
                        for (int j = 1; i < 8; j++)
                        {
                            if (arrayOperator[j] > Max)
                            {
                                Max = arrayOperator[j];
                            }
                        }
                        rgbValuesOut[i + Offset] = (byte)Max;
                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }

            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
        }
        //======================================================
        public void DifferenceOperator(Bitmap InputImage)
        {
            int[] arrayOperator = new int[4];
            int Max;
            bool IsGray = Generic.IsGray(InputImage);
            //====================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //====================================================
            if (IsGray == true)
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6);
                    i = i + 3)
                {

                    Max = 0;
                    //LeftUp-RightDown
                    arrayOperator[0] = Math.Abs(rgbValues[i - 
                        (RowBytesImage + 3)] -
                        rgbValues[i + (RowBytesImage + 3)]);
                    //RightUp-LeftDown
                    arrayOperator[1] = Math.Abs(rgbValues[i - 
                        (RowBytesImage + 3) + 6] -
                        rgbValues[i + (RowBytesImage + 3) - 6]);
                    //MiddleLeft-MiddleRight
                    arrayOperator[2] = Math.Abs(rgbValues[i - 3] -
                        rgbValues[i + 3]);
                    //MiddleUp-MiddleDown
                    arrayOperator[3] = Math.Abs(rgbValues[i -
                        (RowBytesImage + 3) + 3] -
                        rgbValues[i + (RowBytesImage + 3) - 3]); 

                    Max = arrayOperator[0];
                    for (int j = 1; j < 4; j++)
                    {
                        if (arrayOperator[j] > Max)
                        {
                            Max = arrayOperator[j];
                        }
                    }
                    rgbValuesOut[i] = rgbValuesOut[i + 1] = 
                        rgbValuesOut[i + 2] = Convert.ToByte(Max);
                }
            }
            else
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6);
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2 
                        Max = 0;
                        arrayOperator[0] = Math.Abs(rgbValues[(i - 
                            (RowBytesImage + 3)) + Offset] -
                            rgbValues[(i + (RowBytesImage + 3))
                            + Offset]);          //LeftUp-RightDown

                        arrayOperator[1] = Math.Abs(rgbValues[(i - 
                            (RowBytesImage + 3) + 6) + Offset] -
                            rgbValues[(i + (RowBytesImage + 3) - 6)
                            + Offset]);   //RightUp-LeftDown

                        arrayOperator[2] = Math.Abs(rgbValues[(i -
                            3) + Offset] - rgbValues[(i + 3)
                            + Offset]); //MiddleLeft-MiddleRight

                        arrayOperator[3] = Math.Abs(rgbValues[(i
                            - (RowBytesImage + 3) + 3) + Offset] -
                            rgbValues[(i + (RowBytesImage + 3) - 3) 
                            + Offset]);   //MiddleUp-MiddleDown

                        Max = arrayOperator[0];
                        for (int j = 1; j < 4; j++)
                        {
                            if (arrayOperator[j] > Max)
                            {
                                Max = arrayOperator[j];
                            }
                        }
                        rgbValuesOut[i + Offset] = (byte)Max;

                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
        }
        //======================================================
        public void KirschOperator(Bitmap InputImage)
        {
            int sum = 0;
            int[, ,] Mask = Generic.KirschMask;
            int[,] MaskDirection = new int[3, 3];
            bool IsGray = Generic.IsGray(InputImage);
            //==================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage *
                InputImage.Height];
            //==================================================
            if (IsGray == true)
            {
                byte MaxGray;
                byte[] Gray = new byte[8];
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    for (int Direction = 0; Direction < 8; 
                        Direction++)
                    {
                        //===========Set direction mask=========

                        for (int a = 0; a < 3; a++)
                        {
                            for (int b = 0; b < 3; b++)
                            {
                                MaskDirection[a, b] = 
                                    Mask[Direction, a, b];
                            }
                        }
                        //==========Perform Convolution=========

                        sum = 0;
                        sum = sum + MaskDirection[0, 0] * 
                            rgbValues[(i - 3 - RowBytesImage)];
                        sum = sum + MaskDirection[1, 0] * 
                            rgbValues[(i - 3)];
                        sum = sum + MaskDirection[2, 0] *
                            rgbValues[(i - 3 + RowBytesImage)];
                        sum = sum + MaskDirection[0, 1] *
                            rgbValues[(i - RowBytesImage)];
                        sum = sum + MaskDirection[1, 1] *
                            rgbValues[i];
                        sum = sum + MaskDirection[2, 1] * 
                            rgbValues[(i + RowBytesImage)];
                        sum = sum + MaskDirection[0, 2] *
                            rgbValues[(i - RowBytesImage + 3)];
                        sum = sum + MaskDirection[1, 2] *
                            rgbValues[(i + 3)];
                        sum = sum + MaskDirection[2, 2] *
                            rgbValues[(i + 3 + RowBytesImage)];
                        sum = Math.Abs(sum);
                        if (sum > 255) sum = 255;
                        Gray[Direction] = Convert.ToByte(sum);
                    }

                    //=============find maximum diference==========
                    MaxGray = Gray[0];
                    for (int c = 1; c < 8; c++)
                    {
                       if (Gray[c] > MaxGray) { MaxGray = Gray[c];}
                    }
                    rgbValuesOut[i] = rgbValuesOut[i + 1] =
                        rgbValuesOut[i + 2] = MaxGray;
                    //=============================================
                }
            }
            else
            {
                byte[] Red = new byte[8];
                byte[] Green = new byte[8];
                byte[] Blue = new byte[8];
                byte MaxR, MaxG, MaxB;
                for (int i = RowBytesImage + 3; i <=
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    //===============Set direction mask============
                    for (int Direction = 0; Direction < 8; 
                        Direction++)
                    {
                        for (int a = 0; a < 3; a++)
                        {
                            for (int b = 0; b < 3; b++)
                            {
                                MaskDirection[a, b] = 
                                    Mask[Direction, a, b];
                            }
                        }
                        //==========Perform Convolution===========
                        for (int Offset = 0; Offset < 3; Offset++)
                        {
                            //Blue : Offset=0
                            //Green : Offset=1
                            //Red : Offset=2 
                            sum = 0;
                            sum = sum + MaskDirection[0, 0] * 
                                rgbValues[(i - 3 - RowBytesImage)
                                + Offset];
                            sum = sum + MaskDirection[1, 0] * 
                                rgbValues[(i - 3) + Offset];
                            sum = sum + MaskDirection[2, 0] * 
                                rgbValues[(i - 3 + RowBytesImage)
                                + Offset];
                            sum = sum + MaskDirection[0, 1] *
                                rgbValues[(i - RowBytesImage)
                                + Offset];
                            sum = sum + MaskDirection[1, 1] *
                                rgbValues[i + Offset];
                            sum = sum + MaskDirection[2, 1] * 
                                rgbValues[(i + RowBytesImage)
                                + Offset];
                            sum = sum + MaskDirection[0, 2] *
                                rgbValues[(i - RowBytesImage + 3) 
                                + Offset];
                            sum = sum + MaskDirection[1, 2] *
                                rgbValues[(i + 3) + Offset];
                            sum = sum + MaskDirection[2, 2] *
                                rgbValues[(i + 3 + RowBytesImage)
                                + Offset];
                            sum = Math.Abs(sum);
                            if (sum > 255) sum = 255;

                            if (Offset == 0) { Blue[Direction] = 
                                Convert.ToByte(sum); }
                            else if (Offset == 1) {Green[Direction]=
                                Convert.ToByte(sum); }
                            else if (Offset == 2) {Red[Direction] =
                                Convert.ToByte(sum); }
                        }
                    }
                    //==============find maximum diference=========
                    MaxR = Red[0];
                    MaxG = Green[0];
                    MaxB = Blue[0];
                    for (int c = 1; c < 8; c++)
                    {
                        if (Red[c] > MaxR) { MaxR = Red[c]; }
                        if (Green[c] > MaxG) { MaxG = Green[c]; }
                        if (Blue[c] > MaxB) { MaxB = Blue[c]; }
                    }
                    rgbValuesOut[i] = MaxB;
                    rgbValuesOut[i + 1] = MaxG;
                    rgbValuesOut[i + 2] = MaxR;
                    //=============================================
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
        }
        //======================================================
        public void Sobel_Prewitt_Operator(Bitmap InputImage, 
            int SelectMask)
        {

            int HorizonalSum = 0;
            int VerticalSum = 0;
            int Resultant = 0;
            int[,] HorizonalMask = new int[3, 3];
            int[,] VerticalMask = new int[3, 3];
            bool IsGray = Generic.IsGray(InputImage);
            //====================================================
            if (SelectMask == (int)Generic.Mask.Sobel)
            {
                VerticalMask = Generic.SobelMaskV;
                HorizonalMask = Generic.SobelMaskH;
            }
            if (SelectMask == (int)Generic.Mask.Prewitt)
            {
                VerticalMask = Generic.PrewittMaskV;
                HorizonalMask = Generic.PrewittMaskH;
            }
            //======================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //==============Perform Convolution====================
            if (IsGray == true)
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    HorizonalSum = 0;
                    HorizonalSum = HorizonalSum + HorizonalMask[0, 0]
                        * rgbValues[(i - 3 - RowBytesImage)];
                    HorizonalSum = HorizonalSum + HorizonalMask[0, 1]
                        * rgbValues[(i - RowBytesImage)];
                    HorizonalSum = HorizonalSum + HorizonalMask[0, 2]
                        * rgbValues[(i - RowBytesImage + 3)];
                    HorizonalSum = HorizonalSum + HorizonalMask[1, 0]
                        * rgbValues[(i - 3)];
                    HorizonalSum = HorizonalSum + HorizonalMask[1, 1]
                        * rgbValues[i];
                    HorizonalSum = HorizonalSum + HorizonalMask[1, 2]
                        * rgbValues[(i + 3)];
                    HorizonalSum = HorizonalSum + HorizonalMask[2, 0]
                        * rgbValues[(i - 3 + RowBytesImage)];
                    HorizonalSum = HorizonalSum + HorizonalMask[2, 1]
                        * rgbValues[(i + RowBytesImage)];
                    HorizonalSum = HorizonalSum + HorizonalMask[2, 2]
                        * rgbValues[(i + 3 + RowBytesImage)];

                    VerticalSum = 0;
                    VerticalSum = VerticalSum + VerticalMask[0, 0]
                        * rgbValues[(i - 3 - RowBytesImage)];
                    VerticalSum = VerticalSum + VerticalMask[0, 1]
                        * rgbValues[(i - RowBytesImage)];
                    VerticalSum = VerticalSum + VerticalMask[0, 2]
                        * rgbValues[(i - RowBytesImage + 3)];
                    VerticalSum = VerticalSum + VerticalMask[1, 0]
                        * rgbValues[(i - 3)];
                    VerticalSum = VerticalSum + VerticalMask[1, 1]
                        * rgbValues[i];
                    VerticalSum = VerticalSum + VerticalMask[1, 2]
                        * rgbValues[(i + 3)];
                    VerticalSum = VerticalSum + VerticalMask[2, 0]
                        * rgbValues[(i - 3 + RowBytesImage)];
                    VerticalSum = VerticalSum + VerticalMask[2, 1]
                        * rgbValues[(i + RowBytesImage)];
                    VerticalSum = VerticalSum + VerticalMask[2, 2]
                        * rgbValues[(i + 3 + RowBytesImage)];

                    Resultant = Math.Abs(VerticalSum) + 
                        Math.Abs(HorizonalSum);
                    if (Resultant > 255) Resultant = 255;
                    rgbValuesOut[i] = rgbValuesOut[i + 1] = 
                        rgbValuesOut[i + 2] = 
                        Convert.ToByte(Resultant);
                }
            }
            //======================================================
            else
            {
                for (int i = RowBytesImage + 3; i <=
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2 
                        HorizonalSum = 0;
                        HorizonalSum = HorizonalSum + 
                            HorizonalMask[0, 0] * 
                            rgbValues[(i - 3 - RowBytesImage) 
                            + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[0, 1] * 
                            rgbValues[(i - RowBytesImage)
                            + Offset];
                        HorizonalSum = HorizonalSum + 
                            HorizonalMask[0, 2] * 
                            rgbValues[(i - RowBytesImage + 3) 
                            + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[1, 0] *
                            rgbValues[(i - 3) + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[1, 1] *
                            rgbValues[i + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[1, 2] * 
                            rgbValues[(i + 3) + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[2, 0] *
                            rgbValues[(i - 3 + RowBytesImage) 
                            + Offset];
                        HorizonalSum = HorizonalSum +
                            HorizonalMask[2, 1] * 
                            rgbValues[(i + RowBytesImage) 
                            + Offset];
                        HorizonalSum = HorizonalSum + 
                            HorizonalMask[2, 2] * 
                            rgbValues[(i + 3 + RowBytesImage)
                            + Offset];

                        VerticalSum = 0;
                        VerticalSum = VerticalSum +
                            VerticalMask[0, 0] *
                            rgbValues[(i - 3 - RowBytesImage)
                            + Offset];
                        VerticalSum = VerticalSum + 
                            VerticalMask[0, 1] * 
                            rgbValues[(i - RowBytesImage)
                            + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[0, 2] * 
                            rgbValues[(i - RowBytesImage + 3) 
                            + Offset];
                        VerticalSum = VerticalSum + 
                            VerticalMask[1, 0] *
                            rgbValues[(i - 3) 
                            + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[1, 1] *
                            rgbValues[i + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[1, 2] * 
                            rgbValues[(i + 3) 
                            + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[2, 0] * 
                            rgbValues[(i - 3 + RowBytesImage) 
                            + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[2, 1] *
                            rgbValues[(i + RowBytesImage) 
                            + Offset];
                        VerticalSum = VerticalSum +
                            VerticalMask[2, 2] * 
                            rgbValues[(i + 3 + RowBytesImage) 
                            + Offset];

                        Resultant = Math.Abs(VerticalSum) 
                            + Math.Abs(HorizonalSum);
                        if (Resultant > 255) Resultant = 255;
                        rgbValuesOut[i + Offset] =
                            Convert.ToByte(Resultant);
                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut, 
                ref bitmapdata);
        }
        //======================================================
        public void RobertsOperator(Bitmap InputImage)
        {
            int sum = 0;
            bool IsGray = Generic.IsGray(InputImage);
            //===================================================  
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //====================================================
            if (IsGray == true)
            {
                for (int i = 0; i <= rgbValues.Length - 
                    (RowBytesImage + 6); i = i + 3)
                {
                    sum = 0;
                    sum = Math.Abs(rgbValues[i] - 
                        rgbValues[(i + RowBytesImage + 3)])
                        + Math.Abs(rgbValues[(i + 3)] -
                        rgbValues[(i + RowBytesImage)]);
                    if (sum > 255) sum = 255;
                    rgbValuesOut[i] = rgbValuesOut[i + 1] =
                        rgbValuesOut[i + 2] = Convert.ToByte(sum);
                }
            }
            else
            {
                for (int i = 0; i <= 
                    rgbValues.Length - (RowBytesImage + 6);
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2 
                        sum = 0;
                        sum = Math.Abs(rgbValues[i + Offset]
                            - rgbValues[(i + RowBytesImage + 3)
                            + Offset])
                            + Math.Abs(rgbValues[(i + 3) + Offset]
                            - rgbValues[(i + RowBytesImage)
                            + Offset]);
                        if (sum > 255) sum = 255;
                        rgbValuesOut[i + Offset] = 
                            Convert.ToByte(sum);
                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut,
                ref bitmapdata);
        }
        //======================================================
        public void LaplacianOperator(Bitmap InputImage, 
            int SelectMask)
        {
            int sum = 0;
            int[,] LaplaceMask = new int[3, 3];
            bool IsGray = Generic.IsGray(InputImage);
            //================ Select Mask =====================
            if (SelectMask == 
                (int)Generic.Mask.Laplacian4Neighbors)
            {
                LaplaceMask = Generic.LaplacianMask4Neighbors;
            }
            else if (SelectMask == 
                (int)Generic.Mask.Laplacian8Neighbors)
            {
                LaplaceMask = Generic.LaplacianMask8Neighbors;
            }
            //==================================================
            Generic.ImageToByteArray(InputImage, out bitmapdata, 
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage *
                InputImage.Height];
           //==============Perform Convolution====================
            if (IsGray == true)
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6);
                    i = i + 3)
                {

                    sum = 0;
                    sum = sum + LaplaceMask[0, 0] *
                        rgbValues[(i - 3 - RowBytesImage)];
                    sum = sum + LaplaceMask[0, 1] *
                        rgbValues[(i - RowBytesImage)];
                    sum = sum + LaplaceMask[0, 2] *
                        rgbValues[(i - RowBytesImage + 3)];
                    sum = sum + LaplaceMask[1, 0] *
                        rgbValues[(i - 3) + 1];
                    sum = sum + LaplaceMask[1, 1] *
                        rgbValues[i + 1];
                    sum = sum + LaplaceMask[1, 2] * 
                        rgbValues[(i + 3) + 1];
                    sum = sum + LaplaceMask[2, 0] * 
                        rgbValues[(i - 3 + RowBytesImage)];
                    sum = sum + LaplaceMask[2, 1] * 
                        rgbValues[(i + RowBytesImage)];
                    sum = sum + LaplaceMask[2, 2] * 
                        rgbValues[(i + 3 + RowBytesImage)];
                    if (sum > 255) sum = 255;
                    if (sum < 0) sum = 0;
                    rgbValuesOut[i] = rgbValuesOut[i + 1] = 
                        rgbValuesOut[i + 2] = Convert.ToByte(sum);
                }
            }
            //=====================================================
            else
            {
                for (int i = RowBytesImage + 3; i <= 
                    rgbValues.Length - (RowBytesImage + 6); 
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2 
                        sum = 0;
                        sum = sum + LaplaceMask[0, 0] * 
                            rgbValues[(i - 3 - RowBytesImage) 
                            + Offset];
                        sum = sum + LaplaceMask[0, 1] * 
                            rgbValues[(i - RowBytesImage) 
                            + Offset];
                        sum = sum + LaplaceMask[0, 2] *
                            rgbValues[(i - RowBytesImage + 3) 
                            + Offset];
                        sum = sum + LaplaceMask[1, 0] * 
                            rgbValues[(i - 3) + Offset];
                        sum = sum + LaplaceMask[1, 1] *
                            rgbValues[i + Offset];
                        sum = sum + LaplaceMask[1, 2] *
                            rgbValues[(i + 3) + Offset];
                        sum = sum + LaplaceMask[2, 0] * 
                            rgbValues[(i - 3 + RowBytesImage) 
                            + Offset];
                        sum = sum + LaplaceMask[2, 1] * 
                            rgbValues[(i + RowBytesImage) 
                            + Offset];
                        sum = sum + LaplaceMask[2, 2] * 
                            rgbValues[(i + 3 + RowBytesImage) 
                            + Offset];
                        if (sum > 255) sum = 255;
                        if (sum < 0) sum = 0;
                        rgbValuesOut[i + Offset] = 
                            Convert.ToByte(sum);
                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut,
                ref bitmapdata);
        }
        //=====================================================
        public void LaplacianOfGaussian(Bitmap InputImage)
        {
            int[,] LOGMask =Generic.LaplacianOfGaussianMask;
            bool IsGray = Generic.IsGray(InputImage);
            //=================================================
            int sum ;
            Generic.ImageToByteArray(InputImage, out bitmapdata,
                out rgbValues);
            RowBytesImage = bitmapdata.Stride;
            rgbValuesOut = new byte[RowBytesImage * 
                InputImage.Height];
            //==================Perform Convolution============
            if (IsGray == true)
            {
                for (int i = (RowBytesImage * 2 + 6); i <= 
                    rgbValues.Length - (RowBytesImage * 2 + 9);
                    i = i + 3)
                {
                        sum = 0;
                        //From left to right
                        //Column 1  
                        sum = sum + LOGMask[0, 0] *
                            rgbValues[(i - RowBytesImage * 2 - 6)];
                        sum = sum + LOGMask[1, 0] *
                            rgbValues[(i - RowBytesImage - 6)];
                        sum = sum + LOGMask[2, 0] *
                            rgbValues[(i - 6)];
                        sum = sum + LOGMask[3, 0] *
                            rgbValues[(i + RowBytesImage - 6)];
                        sum = sum + LOGMask[4, 0] *
                            rgbValues[(i + RowBytesImage * 2 - 6)];
                        //Column 2
                        sum = sum + LOGMask[0, 1] *
                            rgbValues[(i - RowBytesImage * 2 - 3)];
                        sum = sum + LOGMask[1, 1] *
                            rgbValues[(i - RowBytesImage - 3)];
                        sum = sum + LOGMask[2, 1] *
                            rgbValues[(i - 3)];
                        sum = sum + LOGMask[3, 1] *
                            rgbValues[(i + RowBytesImage - 3)];
                        sum = sum + LOGMask[4, 1] *
                            rgbValues[(i + RowBytesImage * 2 - 3)];
                        //Column 3
                        sum = sum + LOGMask[0, 2] *
                            rgbValues[(i - RowBytesImage * 2)];
                        sum = sum + LOGMask[1, 2] *
                            rgbValues[(i - RowBytesImage)];
                        sum = sum + LOGMask[2, 2] *
                            rgbValues[i];
                        sum = sum + LOGMask[3, 2] *
                            rgbValues[(i + RowBytesImage)];
                        sum = sum + LOGMask[4, 2] *
                            rgbValues[(i + RowBytesImage * 2)];
                        //Column 4
                        sum = sum + LOGMask[0, 3] *
                            rgbValues[(i - RowBytesImage * 2 + 3)];
                        sum = sum + LOGMask[1, 3] *
                            rgbValues[(i - RowBytesImage + 3)];
                        sum = sum + LOGMask[2, 3] *
                            rgbValues[(i + 3)];
                        sum = sum + LOGMask[3, 3] *
                            rgbValues[(i + RowBytesImage + 3)];
                        sum = sum + LOGMask[4, 3] *
                            rgbValues[(i + RowBytesImage * 2 + 3)];
                        //Column 5
                        sum = sum + LOGMask[0, 4] *
                            rgbValues[(i - RowBytesImage * 2 + 6)];
                        sum = sum + LOGMask[1, 4] *
                            rgbValues[(i - RowBytesImage + 6)];
                        sum = sum + LOGMask[2, 4] *
                            rgbValues[(i + 6)];
                        sum = sum + LOGMask[3, 4] *
                            rgbValues[(i + RowBytesImage + 6)];
                        sum = sum + LOGMask[4, 4] *
                            rgbValues[(i + RowBytesImage * 2 + 6)];

                        if (sum > 255) sum = 255;
                        if (sum < 0) sum = 0;
                        rgbValuesOut[i] = rgbValuesOut[i + 1] = 
                           rgbValuesOut[i + 2] = Convert.ToByte(sum);
                }
            }
            //======================================================
            else
            {
                for (int i = (RowBytesImage * 2 + 6); i <=
                    rgbValues.Length - (RowBytesImage * 2 + 9);
                    i = i + 3)
                {
                    for (int Offset = 0; Offset < 3; Offset++)
                    {
                        //Blue : Offset=0
                        //Green : Offset=1
                        //Red : Offset=2
                        sum = 0;
                        //From left to right
                        //Column 1  
                        sum = sum + LOGMask[0, 0]
                            * rgbValues[(i - RowBytesImage * 2 - 6) 
                            + Offset];
                        sum = sum + LOGMask[1, 0] *
                            rgbValues[(i - RowBytesImage - 6) 
                            + Offset];
                        sum = sum + LOGMask[2, 0] *
                            rgbValues[(i - 6) + Offset];
                        sum = sum + LOGMask[3, 0] *
                            rgbValues[(i + RowBytesImage - 6) 
                            + Offset];
                        sum = sum + LOGMask[4, 0] *
                            rgbValues[(i + RowBytesImage * 2 - 6)
                            + Offset];
                        //Column 2
                        sum = sum + LOGMask[0, 1] *
                            rgbValues[(i - RowBytesImage * 2 - 3)
                            + Offset];
                        sum = sum + LOGMask[1, 1] *
                            rgbValues[(i - RowBytesImage - 3)
                            + Offset];
                        sum = sum + LOGMask[2, 1] *
                            rgbValues[(i - 3)
                            + Offset];
                        sum = sum + LOGMask[3, 1] *
                            rgbValues[(i + RowBytesImage - 3) 
                            + Offset];
                        sum = sum + LOGMask[4, 1] *
                            rgbValues[(i + RowBytesImage * 2 - 3) 
                            + Offset];
                        //Column 3
                        sum = sum + LOGMask[0, 2] *
                            rgbValues[(i - RowBytesImage * 2) 
                            + Offset];
                        sum = sum + LOGMask[1, 2] *
                            rgbValues[(i - RowBytesImage)
                            + Offset];
                        sum = sum + LOGMask[2, 2] *
                            rgbValues[i + Offset];
                        sum = sum + LOGMask[3, 2] *
                            rgbValues[(i + RowBytesImage) 
                            + Offset];
                        sum = sum + LOGMask[4, 2] *
                            rgbValues[(i + RowBytesImage * 2) 
                            + Offset];
                        //Column 4
                        sum = sum + LOGMask[0, 3] *
                            rgbValues[(i - RowBytesImage * 2 + 3)
                            + Offset];
                        sum = sum + LOGMask[1, 3] *
                            rgbValues[(i - RowBytesImage + 3) 
                            + Offset];
                        sum = sum + LOGMask[2, 3] *
                            rgbValues[(i + 3) + Offset];
                        sum = sum + LOGMask[3, 3] *
                            rgbValues[(i + RowBytesImage + 3) 
                            + Offset];
                        sum = sum + LOGMask[4, 3] *
                            rgbValues[(i + RowBytesImage * 2 + 3) 
                            + Offset];
                        //Column 5
                        sum = sum + LOGMask[0, 4] *
                            rgbValues[(i - RowBytesImage * 2 + 6)
                            + Offset];
                        sum = sum + LOGMask[1, 4] *
                            rgbValues[(i - RowBytesImage + 6) 
                            + Offset];
                        sum = sum + LOGMask[2, 4] *
                            rgbValues[(i + 6) + Offset];
                        sum = sum + LOGMask[3, 4] *
                            rgbValues[(i + RowBytesImage + 6) 
                            + Offset];
                        sum = sum + LOGMask[4, 4] *
                            rgbValues[(i + RowBytesImage * 2 + 6)
                            + Offset];
                        if (sum > 255.0) sum = 255;
                        if (sum < 0) sum = 0;
                        rgbValuesOut[i + Offset] = 
                            Convert.ToByte(sum);
                    }
                    Generic.SetMaxColor(ref rgbValuesOut, i);
                }
            }
            Generic.ByteArrayToImage(InputImage, rgbValuesOut,
                ref bitmapdata);
        }
    }
}
