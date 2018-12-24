using System;
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
        FileStream fs;
        Byte[] fileArray , yArray;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //kullanıcı aç butonuna bastığı zaman 
             dosyaAc();
        }
        
        private void button2_Click(object sender, EventArgs e)//kaydt butonuna basıldığı zaman
        {
            Object[] parseFile;

            if (radioButton1.Checked == true)
            {
                try
                {
                    width = int.Parse(textBox1.Text);
                    height = int.Parse(textBox2.Text);
                    parseFile = arrayParse(fileArray, 3);
                }
                catch (Exception)
                {
                    MessageBox.Show("En ve Boy bilgilerinin girilmesi gerek !!");
                }
            }
            if (radioButton2.Checked == true)
            {
                try
                {
                    width = int.Parse(textBox1.Text);
                    height = int.Parse(textBox2.Text);
                    parseFile = arrayParse(fileArray, 2);
                }
                catch (Exception)
                {
                    MessageBox.Show("En ve Boy bilgilerinin girilmesi gerek !!");
                }
            }
            if (radioButton3.Checked == true)
            {
                try
                {
                    width = int.Parse(textBox1.Text);
                    height = int.Parse(textBox2.Text);
                    parseFile = arrayParse(fileArray, 1.5);
                }
                catch (Exception)
                {
                    MessageBox.Show("En ve Boy bilgilerinin girilmesi gerek !!");
                }
                
            }
            //if (bmpSave())
            //{
            //    MessageBox.Show("Kayıt işlemi başarılı !");
            //}
            //else
            //    MessageBox.Show("Kayıt işlemi başarısız !");
        }

        private Boolean bmpSave(Bitmap[] bmp)
        {
            return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Show sh = new Show(height,width);
            sh.Show();
        }

        // YUV formatındaki dosyaları seçer ve fileArray dizisine atar
        public void dosyaAc ()
        {
            FileStream fileS;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "YUV files (*.yuv)|*.yuv";
            file.InitialDirectory = "C:\\Users\\Furkan\\Desktop\\GitHub repo\\yuv Formatları";
            int i = 0;
            int sayac = 0;
            try
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    fileS = File.Open(file.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    fileArray = new Byte[fileS.Length];
                    while (i > -1)
                    {
                        i = fileS.ReadByte();
                        if (i != -1)
                        {
                            fileArray[sayac] = (Byte)i;

                            //MessageBox.Show($"{sayac}. indis :{ToHex(arr[sayac])}");
                        }
                        sayac++;
                    }
                }
                if(fileArray != null)
                {
                MessageBox.Show("Dosya açma işlemi başarılı !!");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Dosya açma işlemi başarısız !!");
            }
    
        }

        // Elimizdeki Byte dizisini istenilen yuv formatında bölümleme ve ayrıştırma yapıp nesne dizimize atıyoruz.
        public Object[] arrayParse(Byte[] array , double yuvSize)
        {
            //TODO: yuv formatına göre bölümlencek 
            ulong frameSize;
            int ySize = height * width;
            double frameS = height * width * yuvSize;
            frameSize = Convert.ToUInt64(frameS);
            MessageBox.Show($" frameCount :{array.Length/frameS}");
            Object[] obj = null;
            MessageBox.Show($"ySize : {ySize} frameSize :{frameSize}");

            //Bitmap bmp;
            //for (int frameCount = 0; frameCount < (arr.Length / frameSize); frameCount++)
            //{
            //    int tmp = 0;
            //    for (int j = frameCount * frameSize; j < arr.Length; j++)
            //    {
            //        if (tmp < ySize)
            //        {
            //            arry[tmp] = arr[j];
            //            tmp++;
            //        }
            //        else
            //        {
            //            break;
            //        }
            //    }
            //    bmp = Convert2Bitmap(arry, 720, 576);
            //    bmp.Save($"C:\\Users\\Furkan\\Desktop\\GitHub repo\\yuv Formatları\\4 4 4\\{frameCount}.bmp");
            //}

            return obj;
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

