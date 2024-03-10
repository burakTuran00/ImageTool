using System.Windows.Forms;
using System.Drawing;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private float zoomFactor = 1.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void ImageOpenerButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void ToRotateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Load the original image
                Bitmap originalImage = new Bitmap(pictureBox1.Image);

                // Convert the image to binary
                Bitmap rotatedImage = RotateImage(originalImage, int.Parse(textBoxRotationAngle.Text));

                // Display rotated image in PictureBox
                pictureBox2.Image = rotatedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }

        private void ToCropImage_Click(object sender, EventArgs e)
        {
            try
            {
                // Load the original image
                Bitmap originalImage = new Bitmap(pictureBox1.Image);

                // Crop the image
                int x = int.Parse(textBoxX.Text);
                int y = int.Parse(textBoxY.Text);
                int width = int.Parse(textBoxWidth.Text);
                int height = int.Parse(textBoxHeight.Text);
                Rectangle cropArea = new Rectangle(x, y, width, height);
                Bitmap croppedImage = CropImage(originalImage, cropArea);
                pictureBox2.Image = croppedImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading/cropping image: " + ex.Message);
            }
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            zoomFactor += 0.1f;
            ApplyZoom();
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            zoomFactor -= 0.1f;
            ApplyZoom();
        }

        private Bitmap ToBinary(Bitmap original)
        {
            Bitmap binary = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;

                    // Apply threshold (e.g., 128)
                    Color binaryPixel = avg < 128 ? Color.Black : Color.White;

                    binary.SetPixel(x, y, binaryPixel);
                }
            }

            return binary;
        }

        private Bitmap RotateImage(Bitmap original, float angle)
        {
            Bitmap rotated = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(rotated))
            {
                // Set the rotation point to the center of the image
                g.TranslateTransform(original.Width / 2, original.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-original.Width / 2, -original.Height / 2);

                // Draw the image onto the rotated graphics
                g.DrawImage(original, new Point(0, 0));
            }

            return rotated;
        }

        private Bitmap CropImage(Bitmap original, Rectangle cropArea)
        {
            Bitmap cropped = original.Clone(cropArea, original.PixelFormat);
            return cropped;
        }

        private void ApplyZoom()
        {
            if (pictureBox1 != null)
            {
                int newWidth = (int)(pictureBox1.Width * zoomFactor);
                int newHeight = (int)(pictureBox1.Height * zoomFactor);

                Bitmap zoomedImage = new Bitmap(newWidth, newHeight);
                using (Graphics g = Graphics.FromImage(zoomedImage))
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    g.DrawImage(pictureBox1.Image, 0, 0, newWidth, newHeight);
                }

                pictureBox2.Image = zoomedImage;
            }
        }

        private Bitmap EnhanceBrightness(Bitmap original, int brightness)
        {
            Bitmap enhanced = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color pixel = original.GetPixel(x, y);

                    int newRed = Clamp(pixel.R + brightness, 0, 255);
                    int newGreen = Clamp(pixel.G + brightness, 0, 255);
                    int newBlue = Clamp(pixel.B + brightness, 0, 255);

                    Color newPixel = Color.FromArgb(newRed, newGreen, newBlue);
                    enhanced.SetPixel(x, y, newPixel);
                }
            }

            return enhanced;
        }

        private int Clamp(int value, int min, int max)
        {
            return Math.Max(min, Math.Min(value, max));
        }

        private void bightnessEnhancementButton_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap enhancedImage = EnhanceBrightness(new Bitmap(pictureBox1.Image), int.Parse(textBoxBrightness.Text)); // You can adjust the brightness enhancement level here
                pictureBox2.Image = enhancedImage;
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            {
                if (pictureBox1.Image != null)
                {
                    Bitmap enhancedImage = EnhanceBrightness(new Bitmap(pictureBox1.Image), hScrollBar1.Value); // You can adjust the brightness enhancement level here
                    pictureBox2.Image = enhancedImage;
                }

            }
        }

        private void ToEdgeButton_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                Bitmap imageWithEdgeDetection = SobelEdgeDetection.ApplySobelEdgeDetection(originalImage);
                pictureBox2.Image = imageWithEdgeDetection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void selectImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void convertGreyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                Bitmap grayscaleImage = GreyScale.ToGrayscale(originalImage);
                pictureBox2.Image = grayscaleImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void convertBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                Bitmap grayscaleImage = ToBinary(originalImage);
                pictureBox2.Image = grayscaleImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void edgeDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                Bitmap imageWithEdgeDetection = SobelEdgeDetection.ApplySobelEdgeDetection(originalImage);
                pictureBox2.Image = imageWithEdgeDetection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}