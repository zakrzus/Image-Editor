using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.CustomControls;
using Emgu;

namespace WindowsFormsApp2.AdditionalForms
{
    public partial class Histogram : Form
    {
        public PictureBox _pictureBox;
        public Color _histogramColor;
        public char _colorParameter;

        public Histogram(PictureBox pictureBox, Color color, char colorParameter)
        {
            _pictureBox = pictureBox;
            _histogramColor = color;
            _colorParameter = colorParameter;
            InitializeComponent();
        }

        public long[] GetHistogram(Bitmap picture, char param)
        {
            long[] myHistogram = new long[256];

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    Color c = picture.GetPixel(i, j);
                    long Temp = 0;
                    switch (param)
                    {
                        case 'R':
                            Temp += c.R;
                            Temp = (int)Temp;
                            break;
                        case 'G':
                            Temp += c.G;
                            Temp = (int)Temp;
                            break;
                        case 'B':
                            Temp += c.B;
                            Temp = (int)Temp;
                            break;
                        case 'A':
                            Temp += c.A;
                            Temp = (int)Temp;
                            break;

                        default:
                            Temp += c.R;
                            Temp += c.G;
                            Temp += c.B;

                            Temp = (int)Temp / 3;
                            break;
                    }
                    myHistogram[Temp]++;
                }
            return myHistogram;
        }

        private async void Histogram_Load(object sender, EventArgs e)
        {           
            Bitmap image = new Bitmap(_pictureBox.Image);
            long[] data = await Task.Run(() => GetHistogram(image, _colorParameter));
            label1.Text = "";
            HistogramView histogramControl = newHistogramView(data);
            Controls.Add(histogramControl);
        }

        private HistogramView newHistogramView(long[] data)
        {
            HistogramView histogram = new HistogramView(_histogramColor);
            histogram.DrawHistogram(data);
            histogram.Dock = DockStyle.Fill;
            return histogram;
        }
    }
}
