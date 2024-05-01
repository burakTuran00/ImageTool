using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Chart[] charts = new Chart[2];

        private void AdjustCharts()
        {
            charts[0] = chartHistogram;
            charts[1] = chartOutput;

            foreach (var chart in charts)
            {
                chart.Series.Clear();
                chart.Series.Add("Histogram");
                chart.Series["Histogram"].ChartType = SeriesChartType.Column;
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = 255;
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Title = "Frekans";
                chart.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            }
        }

        public Form1()
        {
            InitializeComponent();

            AdjustCharts();
        }

        private void görüntüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyaları|*.bmp;*.jpg;*.jpeg;*.png|Tüm Dosyalar|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string dosyaYolu = openFileDialog.FileName;

                // Resmi PictureBox'a yükle
                pictureBox1.Image = new Bitmap(dosyaYolu);
            }
        }

        private void histogramÇizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Histgoram.HistogramCiz(pictureBox1.Image, chartHistogram);
        }

        private void histogramGermeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            // Resmi germe işlemine tabi tut
            Histgoram.GermeUygula(pictureBox1, pictureBox2);

            // Histogramı yeniden hesapla ve çiz
            Histgoram.HistogramCiz(pictureBox2.Image, chartOutput);
        }

        private void histogramGenişletmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            // Resmi histogram genişletme işlemine tabi tut
            Histgoram.HistogramGenislet(pictureBox1, pictureBox2);

            // Histogramı yeniden hesapla ve çiz
            Histgoram.HistogramCiz(pictureBox2.Image, chartOutput);
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void temizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(var chart in charts)
            {
                chart.Series.Clear();
                chart.Series.Add("Histogram");
                chart.Series["Histogram"].ChartType = SeriesChartType.Column;
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = 255;
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Title = "Frekans";
                chart.ChartAreas[0].AxisX.Title = "Piksel Değeri";
            }

            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // pictureBox2.Image = RGB.AdjustImage(new Bitmap(pictureBox1.Image), -150, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void arimtatikİşlemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}



