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

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
