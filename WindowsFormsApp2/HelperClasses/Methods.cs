using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.HelperClasses
{
    public static class Methods
    {
        public static Boolean isGrayScale(Bitmap img)
        {
            Boolean result = true;
            for (Int32 h = 0; h < img.Height; h++)
                for (Int32 w = 0; w < img.Width; w++)
                {
                    Color color = img.GetPixel(w, h);
                    if ((color.R != color.G || color.G != color.B || color.R != color.B) && color.A != 0)
                    {
                        result = false;
                        return result;
                    }
                }
            return result;
        }
    }
}
