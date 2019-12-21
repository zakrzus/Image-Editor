using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class Threshold : Form
    {
        Image<Gray, Byte> postProcImg;       
        Image _pic;
        Form _parent;
        public Threshold(Image pic, Form parent)
        {
            _parent = parent;
            _pic = pic;
            InitializeComponent();
            pictureBox1.Image = _pic;
            Bitmap img = new Bitmap(pictureBox1.Image);
            postProcImg = new Image<Gray, byte>(img);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int trackbar = trackBar1.Value;
            label3.Text = trackbar.ToString();
            if (postProcImg != null)
            {
                using (Image<Gray, byte> Gray = postProcImg.ThresholdBinary(new Gray(trackbar), new Gray(255)))
                {
                    pictureBox1.Image = Gray.ToBitmap();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenedPicture postProc = new OpenedPicture(pictureBox1.Image, "Threshold", _parent);
            postProc.MdiParent = _parent;
            Bitmap img = new Bitmap(pictureBox1.Image);         
            postProc.picture.Image = img;
            postProc.Show();
        }
    }
}
