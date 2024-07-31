using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class LowPassWindow : Form
    {
        public LowPassWindow()
        {
            InitializeComponent();
        }
        private Bitmap OrginalInputImage;
        private Bitmap ChangedImage;
        private double DivideNumber = 9.0;
        ImageFilters.SpatialDomainFilters LowPass = new ImageFilters.SpatialDomainFilters();

        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ChangedImage = LowPass.LowPassFilter((Bitmap)OrginalInputImage.Clone(),ImageFilters.Generic.LowPassMask1,DivideNumber);
        }
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
        public Bitmap ReturnBitmap()
        {
            return ChangedImage;
        }

        private void radioButtonMask1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask1.Checked == true )
            {
                DivideNumber = 9.0;
                ChangedImage =LowPass.LowPassFilter((Bitmap)OrginalInputImage.Clone(),ImageFilters.Generic.LowPassMask1,DivideNumber);
            }
        }
        private void radioButtonMask2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask2.Checked == true)
            {
                DivideNumber =10.0;
                ChangedImage = LowPass.LowPassFilter((Bitmap)OrginalInputImage.Clone(), ImageFilters.Generic.LowPassMask2, DivideNumber);

            }
        }
        private void radioButtonMask3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask3.Checked == true)
            {
                DivideNumber =  16.0;
                ChangedImage = LowPass.LowPassFilter((Bitmap)OrginalInputImage.Clone(), ImageFilters.Generic.LowPassMask3, DivideNumber);

            }
        }
        private void radioButtonMask1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("         | 1 , 1 , 1 |" + "\n" + "1/9 * | 1 , 1 , 1 |" + "\n" + "         | 1 , 1 , 1 |", radioButtonMask1, 2000);
        }
        private void radioButtonMask2_MouseEnter(object sender, EventArgs e)
        {

            toolTip1.Show("           | 1 , 1 , 1 |" + "\n" + "1/10 * | 1 , 2 , 1 |" + "\n" + "           | 1 , 1 , 1 |", radioButtonMask2, 2000);
        }
        private void radioButtonMask3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("           | 1 , 2 , 1 |" + "\n" + "1/16 * | 2 , 4 , 2 |" + "\n" + "           | 1 , 2 , 1 |", radioButtonMask3, 2000);
        }

        private void radioButtonMask1_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(radioButtonMask1);
        }
        private void radioButtonMask2_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(radioButtonMask2);
        }
        private void radioButtonMask3_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(radioButtonMask3);
        }
    }
}
