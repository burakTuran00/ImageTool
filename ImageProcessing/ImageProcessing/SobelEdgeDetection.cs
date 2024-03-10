using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessing
{
    static class SobelEdgeDetection
    {
        public static Bitmap ApplySobelEdgeDetection(Bitmap inputImage)
        {
            Bitmap outputImage = new Bitmap(inputImage.Width, inputImage.Height);

            // Sobel kernels
            int[,] kernelX = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
            int[,] kernelY = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };

            // Iterate over each pixel in the image, ignoring border pixels
            for (int y = 1; y < inputImage.Height - 1; y++)
            {
                for (int x = 1; x < inputImage.Width - 1; x++)
                {
                    int pixelX = 0, pixelY = 0;

                    // Convolution with Sobel kernels
                    for (int ky = -1; ky <= 1; ky++)
                    {
                        for (int kx = -1; kx <= 1; kx++)
                        {
                            Color pixel = inputImage.GetPixel(x + kx, y + ky);
                            int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);

                            pixelX += grayValue * kernelX[ky + 1, kx + 1];
                            pixelY += grayValue * kernelY[ky + 1, kx + 1];
                        }
                    }

                    // Calculate the gradient magnitude
                    int gradientMagnitude = (int)Math.Sqrt(pixelX * pixelX + pixelY * pixelY);
                    gradientMagnitude = Math.Min(gradientMagnitude, 255); // Clamping to 255

                    // Set the pixel color in the output image
                    outputImage.SetPixel(x, y, Color.FromArgb(gradientMagnitude, gradientMagnitude, gradientMagnitude));
                }
            }

            return outputImage;
        }

    }
}
