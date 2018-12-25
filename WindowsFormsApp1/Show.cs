using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public Show(int height , int width)
        {
            InitializeComponent();
            this.height = height;
            this.width = width;
            pictureBox1.Height = height;
            pictureBox1.Width = width;
            
        }

        private void Show_Load(object sender, EventArgs e)
        {
            this.Size = new Size((pictureBox1.Width + 100), (pictureBox1.Height + 100));
        }
    }
}
