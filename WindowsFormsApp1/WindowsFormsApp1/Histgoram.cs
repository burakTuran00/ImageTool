using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public static class Histgoram
    {
        public static void HistogramCiz(Image input, Chart chartHistogram)
        {
            Bitmap bitmap = new Bitmap(input);

            // Histogram dizisi oluştur
            int[] histogram = new int[256];

            // Resim piksellerinin yoğunluğunu hesapla
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color renk = bitmap.GetPixel(x, y);
                    int griTonu = (int)(renk.R * 0.3 + renk.G * 0.59 + renk.B * 0.11); // Gri tonlama formülü
                    histogram[griTonu]++;
                }
            }

            // Histogramı çiz
            chartHistogram.Series["Histogram"].Points.Clear();
            for (int i = 0; i < histogram.Length; i++)
            {
                chartHistogram.Series["Histogram"].Points.AddXY(i, histogram[i]);
            }
        }

        public static void GermeUygula(PictureBox input, PictureBox output)
        {
            Bitmap bitmap = new Bitmap(input.Image);

            // Normalize edilecek en düşük ve en yüksek piksel değerlerini belirle
            int a = 50; // En düşük piksel değeri
            int b = 200; // En yüksek piksel değeri

            // Mevcut resmin en düşük ve en yüksek piksel değerlerini bul
            int c = 255; // En düşük piksel değeri
            int d = 0; // En yüksek piksel değeri

            // Görüntüyü tarayarak en düşük ve en yüksek piksel değerlerini bul
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color piksel = bitmap.GetPixel(x, y);
                    int griTonu = (int)(piksel.R * 0.3 + piksel.G * 0.59 + piksel.B * 0.11);

                    // En düşük ve en yüksek piksel değerlerini güncelle
                    if (griTonu < c)
                        c = griTonu;
                    if (griTonu > d)
                        d = griTonu;
                }
            }

            // Histogram germe işlemi
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    Color piksel = bitmap.GetPixel(x, y);
                    int griTonu = (int)(piksel.R * 0.3 + piksel.G * 0.59 + piksel.B * 0.11);

                    // Yeni piksel değerini hesapla
                    int yeniGriTonu = (int)(((griTonu - c) * (b - a) / (d - c)) + a);

                    // Yeni piksel değerini sınırla
                    if (yeniGriTonu < 0)
                        yeniGriTonu = 0;
                    else if (yeniGriTonu > 255)
                        yeniGriTonu = 255;

                    // Yeni renk değerini uygula
                    Color yeniRenk = Color.FromArgb(yeniGriTonu, yeniGriTonu, yeniGriTonu);
                    bitmap.SetPixel(x, y, yeniRenk);
                }
            }

            // PictureBox'a güncellenmiş resmi yükle
            output.Image = bitmap;
        }

        public static void HistogramGenislet(PictureBox input, PictureBox output)
        {
            // Resmi gri tonlamalı bir resim olarak alıyoruz
            Bitmap bitmap = new Bitmap(input.Image);

            // Resmin boyutlarını al
            int m = bitmap.Height;
            int n = bitmap.Width;

            // Yeni renk değerlerini tutacak matris
            int[,] yeniGriTonlari = new int[m, n];

            // Mevcut resmin en düşük ve en yüksek piksel değerlerini bul
            int minPiksel = 255;
            int maxPiksel = 0;

            // Mevcut resmin en düşük ve en yüksek piksel değerlerini bul
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color piksel = bitmap.GetPixel(j, i);
                    int griTonu = (int)(piksel.R + piksel.G + piksel.B) / 3;

                    // En düşük ve en yüksek piksel değerlerini güncelle
                    if (griTonu < minPiksel)
                        minPiksel = griTonu;
                    if (griTonu > maxPiksel)
                        maxPiksel = griTonu;
                }
            }

            // Histogram genişletme işlemi
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color piksel = bitmap.GetPixel(j, i);
                    int griTonu = (int)(piksel.R + piksel.G + piksel.B) / 3;

                    // Yeni piksel değerini hesapla
                    int yeniGriTonu = (int)(((griTonu - minPiksel) / (double)(maxPiksel - minPiksel)) * 255);

                    // Yeni piksel değerini sınırla
                    if (yeniGriTonu < 0)
                        yeniGriTonu = 0;
                    else if (yeniGriTonu > 255)
                        yeniGriTonu = 255;

                    // Yeni renk değerini uygula
                    yeniGriTonlari[i, j] = yeniGriTonu;
                }
            }

            // Yeni renk değerlerini kullanarak güncellenmiş resmi oluşturma
            Bitmap yeniBitmap = new Bitmap(n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Color yeniRenk = Color.FromArgb(yeniGriTonlari[i, j], yeniGriTonlari[i, j], yeniGriTonlari[i, j]);
                    yeniBitmap.SetPixel(j, i, yeniRenk);
                }
            }

            // PictureBox'a güncellenmiş resmi yükle
            output.Image = yeniBitmap;
        }
    }
}
