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



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       
      

        static long GetFileSize(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                return new FileInfo(FilePath).Length;
            }
            return 0;
        }



        private void button1_Click(object sender, EventArgs e)//kullanıcı aç butonuna bastığı zaman öncelikle eğer 4:2:0 seçili ise 
                                                              //.yuv uzantılı dosyamızı açıyoruz en boyy değerlerini textbox içerisinden alıyoruz ve frame denilen yerdeçerçeve sayısını tutuyor
        {
            if (radioButton3.Checked == true)
            {
                OpenFileDialog myOpenFileDlg = new OpenFileDialog();
                myOpenFileDlg.Filter = "YUV files (*.yuv)|*.yuv";
                pictureBox1.Width = int.Parse(textBox1.Text);
                pictureBox1.Height = int.Parse(textBox2.Text);
                int nSize = pictureBox1.Width * pictureBox1.Height;
                int frameSize = Convert.ToInt32((pictureBox1.Width * pictureBox1.Height) * 1.5);
                int input;
                int[,] y = new int[pictureBox1.Width, pictureBox1.Height];
                int[,] u = new int[pictureBox1.Width/2, pictureBox1.Height/2];
                int[,] v = new int[pictureBox1.Width/2, pictureBox1.Height/2];

                if (myOpenFileDlg.ShowDialog() == DialogResult.OK)
                {


                    FileStream infile = File.Open(myOpenFileDlg.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    pictureBox1.ImageLocation = myOpenFileDlg.FileName;


                    while (infile.Position != infile.Length)
                    {
                        input = infile.ReadByte();
                        for (int i = 0; i < pictureBox1.Height; i++)
                            for (int j = 0; j < pictureBox1.Width; j++)
                                y[j, i] = input;
                        for (int i = 0; i <pictureBox1.Height / 2; i++)
                            for (int j = 0; j <  pictureBox1.Width / 2; j++)
                                u[j, i] = input;
                        for (int i = 0; i < pictureBox1.Height/ 2; i++)
                            for (int j = 0; j < pictureBox1.Width  / 2; j++)
                                v[j, i] = input;
                        frameSize++;
                    }

                    for (int i = 0; i <  pictureBox1.Height; i++)
                        for (int j = 0; j <pictureBox1.Width; j++)
                            richTextBox1.AppendText(y[j, i].ToString() + "," + u[j / 2, i / 2].ToString() + "," + v[j / 2, i / 2].ToString());
                    textBox3.Text = frameSize.ToString();
                }

                /*0





                FileStream fs = new FileStream(dosyaAdi, FileMode.Open, FileAccess.Read);





                int y = pictureBox1.Width * pictureBox1.Height;
                int u = pictureBox1.Width * pictureBox1.Height/4;
                int v= pictureBox1.Width * pictureBox1.Height/4;
              //yuv dan rgb ye dönüşüm
              int R = Convert.ToInt32((y + 1.139837398373983740 * v) * 255);
             int G = Convert.ToInt32((y - 0.3946517043589703515 * u - 0.5805986066674976801 * v) * 255);
              int B = Convert.ToInt32((y + 2.032110091743119266 * u) * 255);
              int frame = (int)GetFileSize(sec.ToString()) / frameSize;

                Image img = pictureBox1.Image;
                Bitmap bmp = new Bitmap(img);
                int[] kirmizi = new int[Convert.ToInt32((y + 1.139837398373983740 * v) * 255)];
                int[] yesil = new int[Convert.ToInt32((y - 0.3946517043589703515 * u - 0.5805986066674976801 * v) * 255)];
                int[] mavi = new int[Convert.ToInt32((y + 2.032110091743119266 * u) * 255)];

                for (int i = 0; i < bmp.Size.Height; i++)
                    for (int j = 0; j < bmp.Size.Width; j++)
                    {
                        Color renk = bmp.GetPixel(i, j);

                        kirmizi[renk.R]++;

                        yesil[renk.G]++;
                        mavi[renk.B]++;
                        byte[] yuv = new byte[(int)frameSize];
                    }
                //Bir file stream nesnesi oluşturuyoruz. 1.parametre dosya yolunu,
                //2.parametre dosyanın açılacağını,
                //3.parametre dosyaya erişimin veri okumak için olacağını gösterir.
               StreamReader sw = new StreamReader(fs);
                //Okuma işlemi için bir StreamReader nesnesi oluşturduk.

                pictureBox1.ImageLocation = sec.FileName;
                //Satır satır okuma işlemini gerçekleştirdik ve ekrana yazdırdık
                //Son satır okunduktan sonra okuma işlemini bitirdik

                fs.Close();
                //İşimiz bitince kullandığımız nesneleri iade ettik.
            }

        }
        public static Bitmap GetPictureFromData(int w, int h, byte[] data, byte[][] palette)
        {
            Bitmap pic = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Color c;

            for (int i = 0; i < data.Length; i++)
            {
                byte[] color_bytes = palette[data[i]];
                c = Color.FromArgb(color_bytes[0], color_bytes[1], color_bytes[2]);
                pic.SetPixel(i,i, c);
            }

            return pic;
        }




    */
            }
            if (radioButton1.Checked == true)
            {
                OpenFileDialog myOpenFileDlg = new OpenFileDialog();
                myOpenFileDlg.Filter = "YUV files (*.yuv)|*.yuv";
                pictureBox1.Height = int.Parse(textBox1.Text);
                pictureBox1.Width = int.Parse(textBox2.Text);
                int nSize = pictureBox1.Width * pictureBox1.Height;
                int frameSize = pictureBox1.Width * pictureBox1.Height;
                int input;
                int[,] y = new int[pictureBox1.Width,pictureBox1.Height];
                int[,] u = new int[pictureBox1.Width, pictureBox1.Height];
                int[,] v = new int[pictureBox1.Width, pictureBox1.Height];
             

                if (myOpenFileDlg.ShowDialog() == DialogResult.OK)
                {


                    FileStream infile = File.Open(myOpenFileDlg.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    pictureBox1.ImageLocation = myOpenFileDlg.FileName;


                    while (infile.Position != infile.Length)
                    {
                        input = infile.ReadByte();
                        for (int i = 0; i < pictureBox1.Width; i++)
                            for (int j = 0; j < pictureBox1.Height; j++)
                                y[j, i] = input;
                        for (int i = 0; i < pictureBox1.Width; i++)
                            for (int j = 0; j < pictureBox1.Height; j++)
                                u[j, i] = input;
                        for (int i = 0; i < pictureBox1.Width; i++)
                            for (int j = 0; j < pictureBox1.Height; j++)
                                v[j, i] = input;
                        frameSize++;
                    }

                    for (int i = 0; i < pictureBox1.Width; i++)
                        for (int j = 0; j < pictureBox1.Height; j++)
                            richTextBox1.AppendText(y[j, i].ToString() + "," + u[j, i ].ToString() + "," + v[j , i].ToString());
                    textBox3.Text = frameSize.ToString();
                }

            }
        }
                    private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)//kaydt butonuna basıldığı zaman
        {


            SaveFileDialog sfd = new SaveFileDialog();//yeni bir kaydetme diyaloğu oluşturuyoruz.

            sfd.Filter = "Bitmap(*.bmp)|*.bmp";//.bmp  olarak kayıt imkanı sağlıyoruz.

            sfd.Title = "Kayıt";//diğaloğumuzun başlığını belirliyoruz.

            sfd.FileName = "yuvfotograf";//kaydedilen resmimizin adını 'resim' olarak belirliyoruz.

            DialogResult sonuç = sfd.ShowDialog();

            if (sonuç == DialogResult.OK)
            {
                pictureBox1.Image.Save(sfd.FileName);//Böylelikle resmi istediğimiz yere kaydediyoruz.

            }
        }
       
    } }

