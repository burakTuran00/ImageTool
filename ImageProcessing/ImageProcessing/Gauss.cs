using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    
    static class Gauss
    {
        public static float sigmaValue = 1;

        public static Bitmap ApplyGaussianFilter(Bitmap originalImage)
        {
            sigmaValue += 2f;

            int width = originalImage.Width;
            int height = originalImage.Height;
            Bitmap filteredImage = new Bitmap(width, height);

            // Gauss filtresi kernelini oluştur
            double[,] gaussianKernel = GenerateGaussianKernel(3, sigmaValue); // Örnek: 3x3 boyutunda, sigma = 1.4

            // Görüntü üzerinde Gauss filtresini uygula
            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    double red = 0, green = 0, blue = 0;
                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = originalImage.GetPixel(x + i, y + j);
                            red += pixel.R * gaussianKernel[i + 1, j + 1];
                            green += pixel.G * gaussianKernel[i + 1, j + 1];
                            blue += pixel.B * gaussianKernel[i + 1, j + 1];
                        }
                    }
                    filteredImage.SetPixel(x, y, Color.FromArgb((int)red, (int)green, (int)blue));
                }
            }

            return filteredImage;
        }

        // Gauss filtresi kernelini oluşturan fonksiyon
        static double[,] GenerateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            double sum = 0;
            int halfSize = size / 2;

            for (int x = -halfSize; x <= halfSize; x++)
            {
                for (int y = -halfSize; y <= halfSize; y++)
                {
                    double exponent = -(x * x + y * y) / (2 * sigma * sigma);
                    kernel[x + halfSize, y + halfSize] = Math.Exp(exponent) / (2 * Math.PI * sigma * sigma);
                    sum += kernel[x + halfSize, y + halfSize];
                }
            }

            // Normalizasyon
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    kernel[x, y] /= sum;
                }
            }

            return kernel;
        }
    }
}
