using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public static class RGB
    {
        public static Bitmap AdjustImage(Bitmap originalImage, int redAdjustment, int greenAdjustment, int blueAdjustment)
        {
            Bitmap adjustedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color originalPixel = originalImage.GetPixel(x, y);

                    int newR = Clamp(originalPixel.R + redAdjustment, 0, 255);
                    int newG = Clamp(originalPixel.G + greenAdjustment, 0, 255);
                    int newB = Clamp(originalPixel.B + blueAdjustment, 0, 255);

                    Color adjustedPixel = Color.FromArgb(newR, newG, newB);

                    adjustedImage.SetPixel(x, y, adjustedPixel);
                }
            }

            return adjustedImage;
        }

        public static int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(max, value));
        }
    }
}
