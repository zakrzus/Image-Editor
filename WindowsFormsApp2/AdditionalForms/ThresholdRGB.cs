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
    public partial class ThresholdRGB : Form
    {
        Image<Bgr, Byte> postProcImg;
        Image _pic;
        Form _parent;
        public ThresholdRGB(Image pic, Form parent)
        {
            _parent = parent;
            _pic = pic;
            InitializeComponent();
            pictureBox1.Image = _pic;
            Bitmap img = new Bitmap(pictureBox1.Image);
            postProcImg = new Image<Bgr, Byte>(img);
            redTrackBar.Scroll += Scroll;
            blueTrackBar.Scroll += Scroll;
            greenTrackBar.Scroll += Scroll;          
        }

        private new void Scroll(object sender, EventArgs e)
        {
            int R = redTrackBar.Value;
            int G = greenTrackBar.Value;
            int B = blueTrackBar.Value;
            if (postProcImg != null)
            {
                using (Image<Bgr, Byte> Color = postProcImg.ThresholdBinary(new Bgr(B, G, R), new Bgr(255, 255, 255)))
                {
                    pictureBox1.Image = Color.ToBitmap();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenedPicture postProc = new OpenedPicture(pictureBox1.Image, "Threshold RGB", _parent);
            postProc.MdiParent = _parent;
            Bitmap img = new Bitmap(pictureBox1.Image);
            postProc.picture.Image = img;
            postProc.Show();
        } 
    
    }
    
}

