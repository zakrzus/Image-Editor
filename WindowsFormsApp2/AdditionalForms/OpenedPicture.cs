using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.HelperClasses;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using ImageMagick;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace WindowsFormsApp2.AdditionalForms
{
    public partial class OpenedPicture : Form
    {
        public string _path;
        public string _name;
        public Form _parent;
        public Image _inputImg;
        public OpenedPicture(string path, string fileName, Form parent)
        {
            _name = fileName;
            _parent = parent;
            _path = path;       
            InitializeComponent();
            loading.Visible = false;
            this.Text = _name;
            picture.Image = Image.FromFile(_path);
        }

        public OpenedPicture(Image img, string fileName, Form parent)
        {
            _name = fileName;
            _parent = parent;
            _inputImg = img;
            InitializeComponent();
            this.Text = _name;
            picture.Image = _inputImg;
        }

        private void negacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenedPicture neg = new OpenedPicture(picture.Image, "Negation of " + _name, _parent);
            neg.MdiParent = _parent;
            Bitmap img = new Bitmap(picture.Image);
            Image<Bgr, Byte> negation = new Image<Bgr, byte>(img);
            negation = negation.Not();
            neg.picture.Image = negation.Bitmap;
            neg.Show();            
        }

        private void usualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThresholdRGB thresholdRGB = new ThresholdRGB(picture.Image, _parent);
            thresholdRGB.Show();
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Threshold threshold = new Threshold(picture.Image, _parent);           
            threshold.Show();
        }

        private void posteryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Posterize posterize = new Posterize(picture.Image, _parent);
            posterize.Show();
        }

        private void fitContentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.AutoScroll = false;
        }

        private void autoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picture.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private async void skeletonizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenedPicture postProc = new OpenedPicture(picture.Image, "Skletonize of " + _name, _parent);
            postProc.MdiParent = _parent;
            postProc.picture.Visible = false;
            postProc.loading.Visible = true;
            postProc.Show();
            Bitmap img = new Bitmap(picture.Image);
            img = await Task.Run(() => Methods.Skelatanize(img));
            postProc.loading.Visible = false;
            postProc.picture.Visible = true;
            postProc.picture.Image = img;                     
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_path != null)
            {
                string ext = System.IO.Path.GetExtension(_path);
                string newName = _path.Replace(ext, "") + "_copied" + ext;
                try
                {
                    picture.Image.Save(newName);
                }catch(Exception ex)
                {
                    MessageBox.Show("Lack of permisions. " + ex.Message);
                }
            }
            else
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\Documents";
                saveFileDialog.Filter = "bmp (*.bmp)|*.bmp|jpeg (*.jpeg)|*.jpeg|png (*.png)|*.png|tiff (*.tiff)|*.tiff";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                ImageFormat format = ImageFormat.Bmp;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    switch (saveFileDialog.FilterIndex)
                    {
                        case 1:
                            format = ImageFormat.Bmp;
                            break;
                        case 2:
                            format = ImageFormat.Jpeg;
                            break;
                        case 3:
                            format = ImageFormat.Png;
                            break;
                        case 4:
                            format = ImageFormat.Tiff;
                            break;
                    }
                    this.picture.Image.Save(saveFileDialog.FileName, format);
                    _path = saveFileDialog.FileName;
                }
            }
        }

        private void equaliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenedPicture eq = new OpenedPicture(picture.Image, "Eqalization of " + _name, _parent);
            eq.MdiParent = _parent;
            Bitmap img = new Bitmap(picture.Image);
            Image<Gray, Byte> equalize = new Image<Gray, byte>(img);
            equalize._EqualizeHist();
            eq.picture.Image = equalize.Bitmap;
            eq.Show();
            eq.histogramToolStripMenuItem1_Click(sender, e);
        }

        private void stretchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenedPicture st = new OpenedPicture(picture.Image, "Stretch of " + _name, _parent);
            st.MdiParent = _parent;
            Bitmap img = new Bitmap(picture.Image);
            Image<Gray, Byte> strech = new Image<Gray, byte>(img);
            double[] minValue, maxValue;
            Point[] minLocation;
            Point[] maxLocation;
            strech.Mat.MinMax(out minValue, out maxValue, out minLocation, out maxLocation);
            for (int i = strech.Rows - 1; i >= 0; i--)
            {
                for (int j = strech.Cols - 1; j >= 0; j--)
                {
                    double newVal = (strech[i, j].Intensity - minValue.First()) * ((255 / maxValue.First()) - minValue.First());
                    strech[i, j] = new Gray(newVal);
                }
            }

            st.picture.Image = strech.Bitmap;
            st.Show();
            st.histogramToolStripMenuItem1_Click(sender, e);
        }

        private void histogramToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(picture.Image);
            if (Methods.isGrayScale(image))
            {
                Histogram alphaHistogram = new Histogram(picture, Color.Black, 'X');
                alphaHistogram.MdiParent = _parent;
                alphaHistogram.Show();
            }
            else
            {
                Histogram redHistogram = new Histogram(picture, Color.Red, 'R');
                Histogram greenHistogram = new Histogram(picture, Color.Green, 'G');
                Histogram blueHistogram = new Histogram(picture, Color.Blue, 'B');
                redHistogram.MdiParent = _parent;
                greenHistogram.MdiParent = _parent;
                blueHistogram.MdiParent = _parent;
                redHistogram.Show();
                greenHistogram.Show();
                blueHistogram.Show();
            }
        }
    }
}
