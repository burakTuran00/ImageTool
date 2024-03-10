using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class GreyScale
    {
        public static Bitmap ToGrayscale(Bitmap original)
        {
            Bitmap grayscale = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    Color grayPixel = Color.FromArgb(avg, avg, avg);
                    grayscale.SetPixel(x, y, grayPixel);
                }
            }
            return grayscale;
        }
    }
}
