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
            Graphics g = Graphics.FromImage(bitmap);
            Pen pen = new Pen(Color.Red, 2);
            double x1 = 10;
            double y1 = 0;
            for (double x = 1; x < pictureBox1.Width; x++)
            {
                double y = Math.Sin(x / 180 * Math.PI) * 60;

                g.DrawLine(pen, (float)x1, (float)y1 + 60, (float)(x / 0.46) + 10, (float)y + 60);
                x1 = x / 0.46 + 10;
                y1 = y;
            }
            pictureBox1.Image = bitmap;

            Bitmap bitmap2 = new Bitmap(pictureBox2.Width, pictureBox2.Height, PixelFormat.Format32bppArgb);
            Graphics g2 = Graphics.FromImage(bitmap2);
            Pen pen2 = new Pen(Color.Red, 2);
            double x2 = 10;
            double y2 = 0;
            for (double x = 1; x < pictureBox2.Width * 8; x++)
            {
                double y = Math.Sin(x / 180 * Math.PI) * 100;

                g2.DrawLine(pen2, (float)x2, (float)y2 + 120, (float)(x / 3.68) + 10, (float)y + 120);
                x2 = x / 3.68 + 10;
                y2 = y;
            }
            pictureBox2.Image = bitmap2;
        }
    }
}