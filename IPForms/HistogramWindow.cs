using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class HistogramWindow : Form
    {
        public HistogramWindow()
        {
            InitializeComponent();
            ClearHistogram();
            
        }
        public void SetBitmap(Bitmap inputImage)
        {
            histogramControl1.SetBitmap(inputImage);

        }
        public void ClearHistogram()
        {
            histogramControl1.Clear();

        }
    }
}
