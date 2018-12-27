using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Show : Form
    {
        int height;
        int width;
        string desktopPath;
        int frameC;
        string[] imges = null;
        int counter = 0;

        public Show(string desktopPath , int height , int width,int frameC)
        {
            InitializeComponent();
            this.height = height;
            this.width = width;
            this.desktopPath = desktopPath;
            this.frameC = frameC;
            
            
        }

        private void Show_Load(object sender, EventArgs e)
        {
                this.Size = new Size((width + 10), (height + 50));
                imges = Directory.GetFiles(desktopPath + "\\");
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 60;
                timer.Tick += new EventHandler(PlayTime);
                timer.Start();
        }

        void PlayTime(object sender, EventArgs e)
        {
             pictureBox1.Image = Image.FromFile(desktopPath + $"\\{counter++}.bmp");
             if (counter >= frameC) counter = 0; // Handling out of Bounds
        }
    }
}
