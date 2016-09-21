//Created by Sahil Patel on September/21/2016
//Purpose to create this greeting card is to inform the reader about constellations 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Summative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen drawPen = new Pen(Color.White, 5);
            formGraphics.Clear(Color.Black);
            formGraphics.FillEllipse(whiteBrush, 438, 376, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 593, 398, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 632, 299, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 431, 283, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 340, 225, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 271, 174, 10, 10);
            Thread.Sleep(70);
            formGraphics.FillEllipse(whiteBrush, 140, 180, 10, 10);
            Thread.Sleep(70);

            formGraphics.DrawLine(drawPen, 438, 376, 600, 400);
            formGraphics.DrawLine(drawPen, 600, 400, 632, 299);
            formGraphics.DrawLine(drawPen, 645, 299, 431, 283);
            formGraphics.DrawLine(drawPen, 431, 283, 340, 225);
            formGraphics.DrawLine(drawPen, 340, 225, 271, 174);
            formGraphics.DrawLine(drawPen, 271, 174, 140, 180);
            formGraphics.DrawLine(drawPen, 438, 376, 431, 283);
        }
    }
}
