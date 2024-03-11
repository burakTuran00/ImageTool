using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    public static class BinaryScale
    {
        public static Bitmap ToBinary(Bitmap original)
        {
            Bitmap binary = new Bitmap(original.Width, original.Height);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;

                    Color binaryPixel = avg < 128 ? Color.Black : Color.White;

                    binary.SetPixel(x, y, binaryPixel);
                }
            }

            return binary;
        }
    }
}
