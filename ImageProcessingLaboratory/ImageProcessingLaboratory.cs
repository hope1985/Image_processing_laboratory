using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ImageFilters;
using IPForms;


namespace ImageProcessingLaboratory
{


    public partial class MainWindowImageProcessing : Form
    {
        public MainWindowImageProcessing()
        {
            InitializeComponent();
            HW.MdiParent = this;
            HW.Dock = DockStyle.Right;
            HW.Show();


        }
        
        static Stack<Bitmap> StackBitmap = new Stack<Bitmap>();
        static Bitmap InputImage;
        static Bitmap ImageChanged;
        static HistogramWindow HW = new HistogramWindow();

        int WidthHistogram;

        //-------------------------Declare Form classes-------------------------

        ImageWindow IW = new ImageWindow();
        About AW;
        ThresholdWindow THW;
        GrayWindow GW;
        LowPassWindow LPW;
        HighPassWindow HPW;
        GaussianBlurWindow GBW;
        ColorChannelsWondow CCW;
        GaussianNosieWindow GNW;
        PowerWindow PW;

        //-------------------------Declare Filter classes-------------------------

        SpatialDomainFilters DF = new SpatialDomainFilters();
        EdgeDetectors ED = new EdgeDetectors();
        ColorFilters CF = new ColorFilters();
        Histogram HST = new Histogram();
        Arithmetic ARIT = new Arithmetic();
        MotionBluring MB = new MotionBluring();

        //=========================================================================

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            ImagePanel.Location = new System.Drawing.Point(3, 50);
            ImagePanel.Height = this.Height - 110;
            ImagePanel.Width = this.Width - HW.Width - 15;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ImagePanel.Location = new System.Drawing.Point(3, 50);
            ImagePanel.Height = this.Height - 110;
            ImagePanel.Width = this.Width - HW.Width - 15;
            HW.BackColor = System.Drawing.SystemColors.ButtonShadow;
            WidthHistogram = HW.Size.Width;
        }
        private void OpenFile()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (InputImage != null)
                {
                    IW.Close();
                    InputImage.Dispose();
                    ImageChanged.Dispose();
                    StackBitmap.Clear();
                }
                InputImage = new Bitmap(openFileDialog1.FileName, true);
                ImageChanged = (Bitmap)InputImage.Clone();
                IW = new ImageWindow();
                IW.FormClosed += IW_FormClosed;
                IW.MdiParent = this;
                IW.SetBitmap(ImageChanged);
                ImagePanel.Controls.Add(IW);
                IW.Show();
                IW.SetBitmap(ImageChanged);
                HW.SetBitmap(ImageChanged);
                //====================================enable item============================
                FiltersMenuItem.Enabled = true;
                saveToolStripMenuItem.Enabled = true;
                UndoToolStripButton.Enabled = true;
                saveToolStripButton.Enabled = true;
                SetOrginalImagetoolStripButton.Enabled = true;
            }
        }

        private void IW_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindowImageProcessing.FreeResources();
        }

        private void SaveFile()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FilterIndex == 1)
                {
                    ImageChanged.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                if (saveFileDialog1.FilterIndex == 2)
                {

                    ImageChanged.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
        }
        public static void FreeResources()
        {
            ImageChanged.Dispose();
            InputImage.Dispose();
            StackBitmap.Clear();
            HW.ClearHistogram();
        }

        //=========================================================================
        #region    MenuItems
        //---------------------------ToolStripButton-------------------------------
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void UndoToolStripButton_Click(object sender, EventArgs e)
        {
            if (StackBitmap.Count != 0)
            {
                ImageChanged = StackBitmap.Pop();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void SetOrginalImagetoolStripButton_Click(object sender, EventArgs e)
        {
            StackBitmap.Push(ImageChanged);
            ImageChanged = (Bitmap)InputImage.Clone();
            IW.SetBitmap(ImageChanged);
            HW.SetBitmap(ImageChanged);
        }
        private void HistogramStripButton1_Click(object sender, EventArgs e)
        {

            if (HW.Size.Width > 0)
            {
                while (HW.Size.Width > 0)
                {
                    HW.Size = new Size((HW.Size.Width) - 5, HW.Size.Height);
                    ImagePanel.Size = new Size(ImagePanel.Size.Width + 5, HW.Size.Height);


                }
                if (IW.WindowState == FormWindowState.Maximized)
                    IW.WindowState = FormWindowState.Normal;
            }
            else
            {
                while (HW.Size.Width <= WidthHistogram)
                {
                    HW.Size = new Size((HW.Size.Width) + 5, HW.Size.Height);
                    ImagePanel.Size = new Size(ImagePanel.Size.Width - 5, HW.Size.Height);

                }
                if (IW.WindowState == FormWindowState.Maximized)
                    IW.WindowState = FormWindowState.Normal;
            }
        }
        //---------------------------ToolStripMenu---------------------------------
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AW = new About();
            AW.Show();

        }
        #region     Filter Menu
        //--------------------Color menu---------------------------------------------
        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            THW = new ThresholdWindow();
            StackBitmap.Push(ImageChanged);
            THW.SetBitmap(ImageChanged);
            if (THW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = THW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        private void grayscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GW = new GrayWindow();
            StackBitmap.Push(ImageChanged);
            GW.SetBitmap(ImageChanged);
            if (GW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = GW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            CF.Invert(ImageChanged);
            IW.SetBitmap(ImageChanged);
            HW.SetBitmap(ImageChanged);

        }

        private void channelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CCW = new ColorChannelsWondow();
            StackBitmap.Push(ImageChanged);
            CCW.SetBitmap(ImageChanged);
            if (CCW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = CCW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        //-------------------Spatial Frequency Filtering menu------------------------
        private void lowPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LPW = new LowPassWindow();
            StackBitmap.Push(ImageChanged);
            LPW.SetBitmap(ImageChanged);
            if (LPW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = LPW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        private void area3x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            DF.MedianPassFilter(ImageChanged, (int)Generic.MedianPassArea.MedianPass3x3);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void area5x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            DF.MedianPassFilter(ImageChanged, (int)Generic.MedianPassArea.MedianPass5x5);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void area7x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            DF.MedianPassFilter(ImageChanged, (int)Generic.MedianPassArea.MedianPass7x7);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void highPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HPW = new HighPassWindow();
            StackBitmap.Push(ImageChanged);
            HPW.SetBitmap(ImageChanged);
            if (HPW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = HPW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        //---------------------------Edge Detectors----------------------------------
        private void differenceOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.DifferenceOperator(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);

        }
        private void homogeneityOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.HomogeneityOperator(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void kirschToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.KirschOperator(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.Sobel_Prewitt_Operator(ImageChanged, (int)Generic.Mask.Sobel);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void prewittToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.Sobel_Prewitt_Operator(ImageChanged, (int)Generic.Mask.Prewitt);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void robetsOperatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.RobertsOperator(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void Laplace8NeighborsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.LaplacianOperator(ImageChanged, (int)Generic.Mask.Laplacian8Neighbors);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void Laplacian4NeighborsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.LaplacianOperator(ImageChanged, (int)Generic.Mask.Laplacian4Neighbors);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        private void laplacianOfGussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ED.LaplacianOfGaussian(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        //---------------------------Other-------------------------------------------
        private void gaussianBlurToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GBW = new GaussianBlurWindow();
            StackBitmap.Push(ImageChanged);
            GBW.SetBitmap(ImageChanged);
            if (GBW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = GBW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }
        private void histogramEqualizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            HST.HistogramEqualization(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }

        #endregion

        private void logarithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            ARIT.Logarithm(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }
        #endregion


        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PW = new PowerWindow();
            StackBitmap.Push(ImageChanged);
            PW.SetBitmap(ImageChanged);
            if (PW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = PW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }

        private void gaussianNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GNW = new GaussianNosieWindow();
            StackBitmap.Push(ImageChanged);
            GNW.SetBitmap(ImageChanged);
            if (GNW.ShowDialog() == DialogResult.OK)
            {
                ImageChanged = GNW.ReturnBitmap();
                HW.SetBitmap(ImageChanged);
                IW.SetBitmap(ImageChanged);
            }
            else
            {
                StackBitmap.Pop();
            }
        }

        private void motionBluringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StackBitmap.Push((Bitmap)ImageChanged.Clone());
            MB.MotionBluring_Operation(ImageChanged);
            HW.SetBitmap(ImageChanged);
            IW.SetBitmap(ImageChanged);
        }



        //==============================================================================
    } 
}
