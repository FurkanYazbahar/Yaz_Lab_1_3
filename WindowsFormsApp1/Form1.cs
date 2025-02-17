﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int height, width;
        Byte[] fileArray;
        string desktopPath;
        double yuvSize;
        int frameC;

        public Form1()
        {
            InitializeComponent();
        }

        // Aç butonuna tıklandığı zaman seçili özellik atamaları yapılıp dosyaAc fonksiyonu çalıştırılır...
        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "";

            if (radioButton1.Checked == true)
            {
                fileName = "4 4 4";
                dosyaAc(fileName);
                this.yuvSize = 3;
            }
            else if (radioButton2.Checked == true)
            {
                fileName = "4 2 2";
                dosyaAc(fileName);
                this.yuvSize = 2;
            }
            else if (radioButton3.Checked == true)
            {
                fileName = "4 2 0";
                dosyaAc(fileName);
                this.yuvSize = 1.5;
            }
            else
            {
                MessageBox.Show("Format Türü Seçilmelidir !!");
                linkLabel1.Focus();
            }
        }

        //kaydet butonuna basıldığı zaman Masaüstüne gerekli klasör oluşturulup arrayParse fonksiyonu çalıştırılır...
        private void button2_Click(object sender, EventArgs e)
        {
            if (desktopPath != null)
            {
                if (System.IO.Directory.Exists(desktopPath))
                {
                    Directory.Delete(desktopPath,true);
                }
                Directory.CreateDirectory(desktopPath);

                arrayParse(this.fileArray, yuvSize);
            }
            else
            {
                MessageBox.Show("İşlenecek dosya seçilmeden kayıt işlemi yapılamaz !!");
            }
        }

        // Kayıtlı resimlerin sırasıyla oynatılacak forma yönlendiğimiz kısım
        private void button3_Click(object sender, EventArgs e)
        {
            if (desktopPath != null)
            {
                Show sh = new Show(desktopPath,height,width,frameC);
                sh.Show();
            }
            else
            {
                MessageBox.Show("Dosya ve Özellikleri girilmeden oynatma gerçekleştirilemez !!");
            }
        }

        // YUV formatındaki dosyaları seçer ve fileArray dizisine atar
        public void dosyaAc (string fileName)
        {
            FileStream fileS;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "YUV files (*.yuv)|*.yuv";
            file.InitialDirectory = "C:\\Users\\Furkan\\Desktop\\GitHub repo\\yuv Formatları";
            
            int i = 0;
            int sayac = 0;

            try
            {
                try
                {
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        this.width = int.Parse(textBox1.Text);
                        this.height = int.Parse(textBox2.Text);

                        fileS = File.Open(file.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                        fileArray = new Byte[fileS.Length];
                        while (i > -1)
                        {
                            i = fileS.ReadByte();
                            if (i != -1)
                            {
                                fileArray[sayac] = (Byte)i;
                            }
                            sayac++;
                        }
                    }
                    if (fileArray != null)
                    {
                        MessageBox.Show("Dosya açma işlemi başarılı !!");
                    }
                    desktopPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + fileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("En ve Boy Değerleri Sayısal Olarak Girilmelidir !!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya açma işlemi başarısız !!");
            }
        }

        // Elimizdeki Byte dizisini istenilen yuv formatında bölümleme ve ayrıştırma yapıp nesne dizimize atıyoruz.
        public void arrayParse(Byte[] arrFile , double yuvFormat)
        {
            int frames = Convert.ToInt32(width * height * yuvFormat);
            int ySize = width * height;
            this.frameC = arrFile.Length / frames;
            Byte[] arrY = new Byte[ySize];
            Bitmap bmp = null;
            for (int frameCount = 0; frameCount < (arrFile.Length / frames); frameCount++)
            {
                int tmp = 0;
                for (int j = frameCount * frames; j < arrFile.Length; j++)
                {
                    if (tmp < ySize)
                    {
                        arrY[tmp] = arrFile[j];
                        tmp++;
                    }
                    else
                    {
                        break;
                    }
                }
                bmp = Convert2Bitmap(arrY, width, height);
                bmp.Save($"{desktopPath}\\{frameCount}.bmp");
            }
        }

        // Byte dizisini bitmap e dönüştürme
        public Bitmap Convert2Bitmap(byte[] DATA, int width, int height)
        {
            Bitmap Bm = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            var b = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            ColorPalette ncp = b.Palette;
            for (int i = 0; i < 256; i++)
                ncp.Entries[i] = Color.FromArgb(255, i, i, i);
            b.Palette = ncp;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int Value = DATA[x + (y * width)];
                    Color C = ncp.Entries[Value];
                    Bm.SetPixel(x, y, C);
                }
            }
            return Bm;
        }
    }
}

