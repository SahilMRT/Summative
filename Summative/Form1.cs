//Created by Sahil Patel on September/21/2016
//Purpose to create this greeting card is to inform the reader about constellations 
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Media;
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
            //Puts downloaded image on the background of the start screen
            var bmp = new Bitmap(Summative.Properties.Resources.lake_and_sahil);
            Bitmap starsCover = new Bitmap(bmp, new Size(2000, 800));
            this.BackgroundImage = starsCover;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //Makes the labels invisible 
            lake.Visible = false;
            sahil.Visible = false;

            //Declares all graphics objects
            Graphics formGraphics = this.CreateGraphics();
            Font tnr16 = new Font("Times New Roman", 20, FontStyle.Bold);
            Font tnr6 = new Font("Times New Roman", 12, FontStyle.Bold);
            SolidBrush whiteBrush = new SolidBrush(Color.DeepPink);
            Pen drawPen = new Pen(Color.Red, 5);
            SolidBrush blueBrush = new SolidBrush(Color.BlueViolet);
            SolidBrush orangeBrush = new SolidBrush(Color.Orange);

            //Declares all the sounds 
            SoundPlayer pewPew = new SoundPlayer(Properties.Resources.Pew_Pew_DKnight556_1379997159);
            SoundPlayer eleVat = new SoundPlayer(Properties.Resources.Elevator_Ding_SoundBible_com_685385892);

            //Creates the constellation dots
            formGraphics.Clear(Color.Black);
            formGraphics.FillEllipse(whiteBrush, 398, 376, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 553, 398, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            pewPew.Play();
            formGraphics.FillEllipse(whiteBrush, 592, 299, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            pewPew.Play();
            formGraphics.FillEllipse(whiteBrush, 391, 283, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            pewPew.Play();
            formGraphics.FillEllipse(whiteBrush, 300, 225, 10, 10);
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 231, 174, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            formGraphics.FillEllipse(whiteBrush, 100, 180, 10, 10);
            pewPew.Play();
            Thread.Sleep(1000);
            


            //Creates lines to connect the dots of the constellation 
            formGraphics.DrawLine(drawPen, 400, 380, 555, 402);
            eleVat.Play();
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 560, 400, 597, 303);
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 597, 303, 400, 290);
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 395, 290, 300, 227);
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 300, 225, 230, 174);
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 231, 174, 100, 185);
            Thread.Sleep(1000);
            eleVat.Play();
            formGraphics.DrawLine(drawPen, 465, 376, 400, 283);
            eleVat.Play();

            //Displays who has created the constellation and what constellation it is 
            formGraphics.DrawString("Constellation: The Big Dipper",tnr16, orangeBrush, 50, 40);
            formGraphics.DrawString("By: Sahil Patel", tnr16, orangeBrush, 90, 90);

            //Creates informational paragraph about the constellation 
            formGraphics.DrawString("Since the Big Dipper is part of the constellation Ursa Major(The Great Bear),", tnr6, blueBrush, 650, 150);
            formGraphics.DrawString("It's what is called an asterism, which is the name given to interesting star patterns.", tnr6, blueBrush, 650, 200);
            formGraphics.DrawString("that are easily recognizable, but not one of the official constellations.", tnr6, blueBrush, 650, 250);
            formGraphics.DrawString("Be that as it may, the Big Dipper is probably one of the first objects", tnr6, blueBrush, 650, 300);
            formGraphics.DrawString("in the sky that we learn to find and identify. It's distinctive position at the top", tnr6, blueBrush, 650, 350);
            formGraphics.DrawString("of the summer night sky and the graceful curve of its handle make it easy for almost", tnr6, blueBrush, 650, 400);
            formGraphics.DrawString("anyone to find.", tnr6, blueBrush, 650, 450);
        }

        private void lake_Click(object sender, EventArgs e)
        {

        }
    }
}
