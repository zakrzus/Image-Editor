using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.AdditionalForms;

namespace WindowsFormsApp2
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileNameSafe = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Documents";
                openFileDialog.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    fileNameSafe = openFileDialog.SafeFileName;
                    filePath = openFileDialog.FileName;
                    OpenedPicture picture = new OpenedPicture(filePath, fileNameSafe, this);                  
                    picture.MdiParent = this;
                    picture.Show();
                }
            }
        }
    }
}
