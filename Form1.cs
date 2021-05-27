using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Sinewavy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height, PixelFormat.Format32bppArgb);
            //Graphics to be able to draw on screen
            Graphics g = Graphics.FromImage(bitmap);
            
            //Pen to draw the sinewave
            Pen pen = new Pen(Color.Black, 2);
            
            double x1 = 10;
            double y1 = 0;
            int Frequency = 10;
            int Amplitude = 60;
            for (double x = 1; x < pictureBox1.Width; x++)
            {
                
                double y = Math.Sin(x / 180 * Math.PI * 2 * Frequency) * Amplitude;
                // y(t) = A * sin(2 * PI * f * t + shift)

                g.DrawLine(pen, (float)x1, (float)y1 + 60, (float)(x / 0.46) + 10, (float)y + 60);
                x1 = x / 0.46 + 10;
                y1 = y;
            }
            pictureBox1.Image = bitmap;


        }


    }
}