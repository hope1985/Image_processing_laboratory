namespace ImageProcessingLaboratory
{
    partial class MainWindowImageProcessing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowImageProcessing));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FiltersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ThresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramEqualizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logarithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpatialDomainFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.area3x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.area5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.area7x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.robetsOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prewittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kirschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homogeneityOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianOperatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian4NeighborsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Laplacian8NeighborsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplacianOfGussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SetOrginalImagetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.HistogramStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.motionBluringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All Supported filess (*.JPG;*.JPEG;*.bmp)| *.jpg;*.jpeg;*.bmp|JPEG files (*.JPG;*" +
                ".JPEG)|*.jpg;*.jpeg|Bitmap files (*.bmp)|*.bmp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPEG files(*.JPG;*.JPEG)|*.jpg|Bitmap files (*.bmp)|*.bmp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.FiltersMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 20;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.ToolTipText = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.openFileToolStripMenuItem.Text = " Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem.Text = "Save as";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FiltersMenuItem
            // 
            this.FiltersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem1,
            this.histogramEqualizationToolStripMenuItem,
            this.logarithmToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.SpatialDomainFiltersToolStripMenuItem,
            this.edgeDetectorsToolStripMenuItem,
            this.NoisesToolStripMenuItem,
            this.motionBluringToolStripMenuItem});
            this.FiltersMenuItem.Enabled = false;
            this.FiltersMenuItem.Name = "FiltersMenuItem";
            this.FiltersMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FiltersMenuItem.Text = "Filters";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayscaleToolStripMenuItem,
            this.channelsToolStripMenuItem,
            this.InvertToolStripMenuItem,
            this.ThresholdToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // grayscaleToolStripMenuItem
            // 
            this.grayscaleToolStripMenuItem.Name = "grayscaleToolStripMenuItem";
            this.grayscaleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.grayscaleToolStripMenuItem.Text = "Grayscale";
            this.grayscaleToolStripMenuItem.Click += new System.EventHandler(this.grayscaleToolStripMenuItem_Click);
            // 
            // channelsToolStripMenuItem
            // 
            this.channelsToolStripMenuItem.Name = "channelsToolStripMenuItem";
            this.channelsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.channelsToolStripMenuItem.Text = "Color Channels";
            this.channelsToolStripMenuItem.Click += new System.EventHandler(this.channelsToolStripMenuItem_Click);
            // 
            // InvertToolStripMenuItem
            // 
            this.InvertToolStripMenuItem.Name = "InvertToolStripMenuItem";
            this.InvertToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.InvertToolStripMenuItem.Text = "Invert";
            this.InvertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // ThresholdToolStripMenuItem
            // 
            this.ThresholdToolStripMenuItem.Name = "ThresholdToolStripMenuItem";
            this.ThresholdToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.ThresholdToolStripMenuItem.Text = "Threshold";
            this.ThresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem1
            // 
            this.gaussianBlurToolStripMenuItem1.Name = "gaussianBlurToolStripMenuItem1";
            this.gaussianBlurToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.gaussianBlurToolStripMenuItem1.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem1.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem1_Click);
            // 
            // histogramEqualizationToolStripMenuItem
            // 
            this.histogramEqualizationToolStripMenuItem.Name = "histogramEqualizationToolStripMenuItem";
            this.histogramEqualizationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.histogramEqualizationToolStripMenuItem.Text = "Histogram Equalization";
            this.histogramEqualizationToolStripMenuItem.Click += new System.EventHandler(this.histogramEqualizationToolStripMenuItem_Click);
            // 
            // logarithmToolStripMenuItem
            // 
            this.logarithmToolStripMenuItem.Name = "logarithmToolStripMenuItem";
            this.logarithmToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.logarithmToolStripMenuItem.Text = "Logarithm";
            this.logarithmToolStripMenuItem.Click += new System.EventHandler(this.logarithmToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // SpatialDomainFiltersToolStripMenuItem
            // 
            this.SpatialDomainFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowPassToolStripMenuItem,
            this.medianPassToolStripMenuItem,
            this.highPassToolStripMenuItem});
            this.SpatialDomainFiltersToolStripMenuItem.Name = "SpatialDomainFiltersToolStripMenuItem";
            this.SpatialDomainFiltersToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.SpatialDomainFiltersToolStripMenuItem.Text = "Spatial Domain Filters";
            // 
            // lowPassToolStripMenuItem
            // 
            this.lowPassToolStripMenuItem.Name = "lowPassToolStripMenuItem";
            this.lowPassToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.lowPassToolStripMenuItem.Text = "Low pass";
            this.lowPassToolStripMenuItem.Click += new System.EventHandler(this.lowPassToolStripMenuItem_Click);
            // 
            // medianPassToolStripMenuItem
            // 
            this.medianPassToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.area3x3ToolStripMenuItem,
            this.area5x5ToolStripMenuItem,
            this.area7x7ToolStripMenuItem});
            this.medianPassToolStripMenuItem.Name = "medianPassToolStripMenuItem";
            this.medianPassToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.medianPassToolStripMenuItem.Text = "Median pass";
            // 
            // area3x3ToolStripMenuItem
            // 
            this.area3x3ToolStripMenuItem.Name = "area3x3ToolStripMenuItem";
            this.area3x3ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.area3x3ToolStripMenuItem.Text = "Area 3x3";
            this.area3x3ToolStripMenuItem.Click += new System.EventHandler(this.area3x3ToolStripMenuItem_Click);
            // 
            // area5x5ToolStripMenuItem
            // 
            this.area5x5ToolStripMenuItem.Name = "area5x5ToolStripMenuItem";
            this.area5x5ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.area5x5ToolStripMenuItem.Text = "Area 5x5";
            this.area5x5ToolStripMenuItem.Click += new System.EventHandler(this.area5x5ToolStripMenuItem_Click);
            // 
            // area7x7ToolStripMenuItem
            // 
            this.area7x7ToolStripMenuItem.Name = "area7x7ToolStripMenuItem";
            this.area7x7ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.area7x7ToolStripMenuItem.Text = "Area 7x7";
            this.area7x7ToolStripMenuItem.Click += new System.EventHandler(this.area7x7ToolStripMenuItem_Click);
            // 
            // highPassToolStripMenuItem
            // 
            this.highPassToolStripMenuItem.Name = "highPassToolStripMenuItem";
            this.highPassToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.highPassToolStripMenuItem.Text = "High pass";
            this.highPassToolStripMenuItem.Click += new System.EventHandler(this.highPassToolStripMenuItem_Click);
            // 
            // edgeDetectorsToolStripMenuItem
            // 
            this.edgeDetectorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.robetsOperatorToolStripMenuItem,
            this.sobelToolStripMenuItem,
            this.prewittToolStripMenuItem,
            this.kirschToolStripMenuItem,
            this.differenceOperatorToolStripMenuItem,
            this.homogeneityOperatorToolStripMenuItem,
            this.laplacianOperatorToolStripMenuItem,
            this.laplacianOfGussianToolStripMenuItem});
            this.edgeDetectorsToolStripMenuItem.Name = "edgeDetectorsToolStripMenuItem";
            this.edgeDetectorsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.edgeDetectorsToolStripMenuItem.Text = "Edge Detectors";
            // 
            // robetsOperatorToolStripMenuItem
            // 
            this.robetsOperatorToolStripMenuItem.Name = "robetsOperatorToolStripMenuItem";
            this.robetsOperatorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.robetsOperatorToolStripMenuItem.Text = "Roberts Operator";
            this.robetsOperatorToolStripMenuItem.Click += new System.EventHandler(this.robetsOperatorToolStripMenuItem_Click);
            // 
            // sobelToolStripMenuItem
            // 
            this.sobelToolStripMenuItem.Name = "sobelToolStripMenuItem";
            this.sobelToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.sobelToolStripMenuItem.Text = "Sobel";
            this.sobelToolStripMenuItem.Click += new System.EventHandler(this.sobelToolStripMenuItem_Click);
            // 
            // prewittToolStripMenuItem
            // 
            this.prewittToolStripMenuItem.Name = "prewittToolStripMenuItem";
            this.prewittToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.prewittToolStripMenuItem.Text = "Prewitt";
            this.prewittToolStripMenuItem.Click += new System.EventHandler(this.prewittToolStripMenuItem_Click);
            // 
            // kirschToolStripMenuItem
            // 
            this.kirschToolStripMenuItem.Name = "kirschToolStripMenuItem";
            this.kirschToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.kirschToolStripMenuItem.Text = "Kirsch";
            this.kirschToolStripMenuItem.Click += new System.EventHandler(this.kirschToolStripMenuItem_Click);
            // 
            // differenceOperatorToolStripMenuItem
            // 
            this.differenceOperatorToolStripMenuItem.Name = "differenceOperatorToolStripMenuItem";
            this.differenceOperatorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.differenceOperatorToolStripMenuItem.Text = "Difference Operator ";
            this.differenceOperatorToolStripMenuItem.Click += new System.EventHandler(this.differenceOperatorToolStripMenuItem_Click);
            // 
            // homogeneityOperatorToolStripMenuItem
            // 
            this.homogeneityOperatorToolStripMenuItem.Name = "homogeneityOperatorToolStripMenuItem";
            this.homogeneityOperatorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.homogeneityOperatorToolStripMenuItem.Text = "Homogeneity Operator \t ";
            this.homogeneityOperatorToolStripMenuItem.Click += new System.EventHandler(this.homogeneityOperatorToolStripMenuItem_Click);
            // 
            // laplacianOperatorToolStripMenuItem
            // 
            this.laplacianOperatorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Laplacian4NeighborsToolStripMenuItem,
            this.Laplacian8NeighborsToolStripMenuItem});
            this.laplacianOperatorToolStripMenuItem.Name = "laplacianOperatorToolStripMenuItem";
            this.laplacianOperatorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.laplacianOperatorToolStripMenuItem.Text = "Laplacian Operator";
            // 
            // Laplacian4NeighborsToolStripMenuItem
            // 
            this.Laplacian4NeighborsToolStripMenuItem.Name = "Laplacian4NeighborsToolStripMenuItem";
            this.Laplacian4NeighborsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.Laplacian4NeighborsToolStripMenuItem.Text = "Four neighbors";
            this.Laplacian4NeighborsToolStripMenuItem.Click += new System.EventHandler(this.Laplacian4NeighborsToolStripMenuItem_Click);
            // 
            // Laplacian8NeighborsToolStripMenuItem
            // 
            this.Laplacian8NeighborsToolStripMenuItem.Name = "Laplacian8NeighborsToolStripMenuItem";
            this.Laplacian8NeighborsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.Laplacian8NeighborsToolStripMenuItem.Text = "Eight neighbors";
            this.Laplacian8NeighborsToolStripMenuItem.Click += new System.EventHandler(this.Laplace8NeighborsToolStripMenuItem_Click);
            // 
            // laplacianOfGussianToolStripMenuItem
            // 
            this.laplacianOfGussianToolStripMenuItem.Name = "laplacianOfGussianToolStripMenuItem";
            this.laplacianOfGussianToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.laplacianOfGussianToolStripMenuItem.Text = "Laplacian Of Gussian (LOG)";
            this.laplacianOfGussianToolStripMenuItem.Click += new System.EventHandler(this.laplacianOfGussianToolStripMenuItem_Click);
            // 
            // NoisesToolStripMenuItem
            // 
            this.NoisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianNoiseToolStripMenuItem});
            this.NoisesToolStripMenuItem.Name = "NoisesToolStripMenuItem";
            this.NoisesToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.NoisesToolStripMenuItem.Text = "Noises";
            // 
            // gaussianNoiseToolStripMenuItem
            // 
            this.gaussianNoiseToolStripMenuItem.Name = "gaussianNoiseToolStripMenuItem";
            this.gaussianNoiseToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.gaussianNoiseToolStripMenuItem.Text = "Gaussian Noise";
            this.gaussianNoiseToolStripMenuItem.Click += new System.EventHandler(this.gaussianNoiseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.SetOrginalImagetoolStripButton,
            this.UndoToolStripButton,
            this.HistogramStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(873, 25);
            this.toolStrip1.TabIndex = 31;
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Enabled = false;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save as";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SetOrginalImagetoolStripButton
            // 
            this.SetOrginalImagetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SetOrginalImagetoolStripButton.Enabled = false;
            this.SetOrginalImagetoolStripButton.Image = global::ImageProcessingLaboratory.Properties.Resources.OrginalImage;
            this.SetOrginalImagetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetOrginalImagetoolStripButton.Name = "SetOrginalImagetoolStripButton";
            this.SetOrginalImagetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SetOrginalImagetoolStripButton.Text = "Orginal Image";
            this.SetOrginalImagetoolStripButton.Click += new System.EventHandler(this.SetOrginalImagetoolStripButton_Click);
            // 
            // UndoToolStripButton
            // 
            this.UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UndoToolStripButton.Enabled = false;
            this.UndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoToolStripButton.Image")));
            this.UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UndoToolStripButton.Name = "UndoToolStripButton";
            this.UndoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UndoToolStripButton.Text = "Undo";
            this.UndoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // HistogramStripButton1
            // 
            this.HistogramStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HistogramStripButton1.Image = global::ImageProcessingLaboratory.Properties.Resources.Histogram;
            this.HistogramStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistogramStripButton1.Name = "HistogramStripButton1";
            this.HistogramStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HistogramStripButton1.Size = new System.Drawing.Size(23, 22);
            this.HistogramStripButton1.Text = "Histogram";
            this.HistogramStripButton1.Click += new System.EventHandler(this.HistogramStripButton1_Click);
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ImagePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImagePanel.Location = new System.Drawing.Point(12, 52);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(212, 144);
            this.ImagePanel.TabIndex = 35;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Location = new System.Drawing.Point(0, 635);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(873, 22);
            this.statusStrip1.TabIndex = 31;
            // 
            // motionBluringToolStripMenuItem
            // 
            this.motionBluringToolStripMenuItem.Name = "motionBluringToolStripMenuItem";
            this.motionBluringToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.motionBluringToolStripMenuItem.Text = "Motion Bluring";
            this.motionBluringToolStripMenuItem.Click += new System.EventHandler(this.motionBluringToolStripMenuItem_Click);
            // 
            // MainWindowImageProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindowImageProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Processing Laboratory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FiltersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ThresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton UndoToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem SpatialDomainFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton SetOrginalImagetoolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.ToolStripMenuItem differenceOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homogeneityOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramEqualizationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kirschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prewittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem robetsOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianOperatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Laplacian4NeighborsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Laplacian8NeighborsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplacianOfGussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem area3x3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem area5x5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem area7x7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem channelsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton HistogramStripButton1;
        private System.Windows.Forms.ToolStripMenuItem logarithmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem InvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoisesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motionBluringToolStripMenuItem;
    }
}

