namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "AÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "KAYDET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(587, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 20);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ayarlar";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(516, 62);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 24);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "4:4:4";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(591, 62);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "4:2:2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(685, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 24);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "4:2:0";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 26);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(607, 158);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 26);
            this.textBox2.TabIndex = 7;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(489, 119);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 20);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "En";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(489, 164);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(36, 20);
            this.linkLabel3.TabIndex = 9;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Boy";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(37, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 222);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(550, 199);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(238, 69);
            this.trackBar1.TabIndex = 11;
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(489, 209);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(20, 20);
            this.linkLabel4.TabIndex = 12;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Y";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(544, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 13;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(409, 246);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

