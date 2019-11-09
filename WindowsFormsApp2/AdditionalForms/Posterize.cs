using Emgu.CV;
using Emgu.CV.Structure;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.AdditionalForms
{
    public partial class Posterize : Form
    {
        Image _pic;
        Form _parent;
        public Posterize(Image pic, Form parent)
        {
            _parent = parent;
            _pic = pic;
            InitializeComponent();
            pictureBox1.Image = _pic;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackbar = trackBar1.Value;
            label3.Text = trackbar.ToString();
            if (pictureBox1.Image != null)
            {
                Bitmap img = new Bitmap(_pic);
                MagickImage image = new MagickImage(img);
                image.Posterize(trackbar);
                pictureBox1.Image = image.ToBitmap();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenedPicture postProc = new OpenedPicture(pictureBox1.Image, "Posterize", _parent);
            postProc.MdiParent = _parent;
            Bitmap img = new Bitmap(pictureBox1.Image);
            MagickImage image = new MagickImage(img);
            postProc.picture.Image = image.ToBitmap();
            postProc.Show();
        }
    }
}
