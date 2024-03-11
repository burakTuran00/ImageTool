using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap resultImage = SumImages(new Bitmap(pictureBox1.Image), new Bitmap(pictureBox2.Image));
                pictureBox3.Image = resultImage;
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        static Bitmap SumImages(Bitmap image1, Bitmap image2)
        {
            // Resimlerin boyutlarını kontrol et
            if (image1.Size != image2.Size)
            {
                throw new ArgumentException("Images must have the same dimensions.");
            }

            Bitmap resultImage = new Bitmap(image1.Width, image1.Height);

            // Her piksel için işlemi uygula
            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    Color color1 = image1.GetPixel(x, y);
                    Color color2 = image2.GetPixel(x, y);

                    int newRed = Math.Min(color1.R + color2.R, 255);
                    int newGreen = Math.Min(color1.G + color2.G, 255);
                    int newBlue = Math.Min(color1.B + color2.B, 255);

                    resultImage.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
                }
            }

            return resultImage;
        }

        private void ımage1ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ımage2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
