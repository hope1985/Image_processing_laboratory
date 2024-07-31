using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPForms
{
    public partial class HighPassWindow : Form
    {
        public HighPassWindow()
        {
            InitializeComponent();
        }

        private ImageFilters.SpatialDomainFilters spf = new ImageFilters.SpatialDomainFilters();
        private Bitmap OrginalInputImage;
        private Bitmap ChangedImage;

        public void SetBitmap(Bitmap InputImage)
        {
            OrginalInputImage = (Bitmap)InputImage.Clone();
            ChangedImage = (Bitmap)InputImage.Clone();
            ChangedImage = spf.HighPassFilter((Bitmap)OrginalInputImage.Clone(),ImageFilters.Generic.HighPassMask1);
        }
        public Bitmap ReturnBitmap()
        {
            return ChangedImage;
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

        private void radioButtonMask1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask1.Checked == true)
            {
                spf.HighPassFilter((Bitmap)OrginalInputImage.Clone(),ImageFilters.Generic.HighPassMask1);
            }

        }
        private void radioButtonMask2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask2.Checked == true)
            {

                spf.HighPassFilter((Bitmap)OrginalInputImage.Clone(), ImageFilters.Generic.HighPassMask2);
            }
        }
        private void radioButtonMask3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMask3.Checked == true)
            {
                spf.HighPassFilter((Bitmap)OrginalInputImage.Clone(), ImageFilters.Generic.HighPassMask3);
            }
        }
        private void radioButtonMask1_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("| 0 ,-1 , 0  |" + "\n" +"|-1 , 5 ,-1 |" + "\n" + "| 0 ,-1 , 0  |",radioButtonMask1, 2000);
        }
        private void radioButtonMask2_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("|-1 ,-1 ,-1 |" + "\n" + "|-1 , 9 ,-1  |" + "\n" + "|-1 ,-1 ,-1 |", radioButtonMask2, 2000);
        }
        private void radioButtonMask3_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("| 1 ,-2 , 1  |" + "\n" + "|-2 , 5 ,-2 |" + "\n" + "| 1 ,-2 , 1  |", radioButtonMask3, 2000);
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
