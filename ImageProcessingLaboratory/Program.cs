using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ImageProcessingLaboratory;

namespace ImageProcessingProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IPForms.StartForm startForm = new IPForms.StartForm();
            if (startForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ImageProcessingLaboratory.MainWindowImageProcessing());
                startForm.Close();
            }
        }
    }
}
