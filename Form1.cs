using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace Game1
{
    public partial class Form1 : Form
    {
        int speed = 3;
        int gravity = 5;
        int score = 0;
        int topVal = 0;
        int state = 1;
        int setScore = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void TransparetBackground(Control C)
        {
            C.Visible = false;

            C.Refresh();
            Application.DoEvents();

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleHeight = screenRectangle.Top - this.Top;
            int Right = screenRectangle.Left - this.Left;

            Bitmap bmp = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;

            C.Visible = true;
        }
        private void tekanAtas(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                gravity =5;
            }
            if (e.KeyCode == Keys.Escape)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                    pauseAct.Visible = true;
                }
                else
                {
                    timer1.Start();
                    pauseAct.Visible = false;
                }
            }

        }

        private void tekanBawah(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void timerku(object sender, EventArgs e)
        {
            topVal = burung.Top;
            burung.Top += gravity;
            pipaAtas.Left -= speed;
            pipaBawah2.Left -= speed;
            pipaAtas2.Left -= speed;
            pipaBawah.Left -= speed;
            pipaAtas3.Left -= speed;
            pipaBawah3.Left -= speed;
            pipaAtas4.Left -= speed;
            pipaBawah4.Left -= speed;
            pipaAtas5.Left -= speed;
            pipaBawah5.Left -= speed;
            if(burung.Top < 0)
            {
                burung.Top = 0;
            }
        

            if (pipaAtas.Left < -100)
            {
                int posisi = 480;
                pipaAtas.Left = 1500;
                pipaBawah.Left = 1500;
                Random r = new Random();
                int rInt = r.Next(100, 400);
                pipaAtas.Height = rInt;
                if (rInt > 250)
                {
                    int kadal = rInt - 250;
                    pipaBawah.Height = 250 - kadal;
                    pipaBawah.Top = 480 + kadal;
                }
                if (rInt < 250)
                {
                    int kadal = 250 - rInt;
                    pipaBawah.Height = 250 + kadal;
                    pipaBawah.Top = 480 - kadal;
                }
            }
            if (pipaAtas2.Left < -100)
            {
               
                int posisi = 480;
                pipaAtas2.Left = 1500;
                pipaBawah2.Left = 1500;
                Random r = new Random();
                int rInt = r.Next(50, 450);
                pipaAtas2.Height = rInt;
                if (rInt >250)
                {
                    int kadal = rInt - 250;
                    pipaBawah2.Height = 250 - kadal;
                    pipaBawah2.Top = 480 + kadal;
                }
                if (rInt <250)
                {
                    int kadal = 250 - rInt;
                    pipaBawah2.Height = 250 + kadal;
                    pipaBawah2.Top = 480 - kadal;
                }

            }
            if (pipaAtas3.Left < -100)
            {
               
                int posisi = 480;
                pipaAtas3.Left = 1500;
                pipaBawah3.Left = 1500;
                Random r = new Random();
                int rInt = r.Next(50, 450);
                pipaAtas3.Height = rInt;
                if (rInt > 250)
                {
                    int kadal = rInt - 250;
                    pipaBawah3.Height = 250 - kadal;
                    pipaBawah3.Top = 480 + kadal;
                }
                if (rInt < 250)
                {
                    int kadal = 250 - rInt;
                    pipaBawah3.Height = 250 + kadal;
                    pipaBawah3.Top = 480 - kadal;
                }
            }
            if (pipaAtas4.Left < -100)
            {
               
                int posisi = 480;
                pipaAtas4.Left = 1500;
                pipaBawah4.Left = 1500;
                Random r = new Random();
                int rInt = r.Next(50, 450);
                pipaAtas4.Height = rInt;
                if (rInt > 250)
                {
                    int kadal = rInt - 250;
                    pipaBawah4.Height = 250 - kadal;
                    pipaBawah4.Top = 480 + kadal;
                }
                if (rInt < 250)
                {
                    int kadal = 250 - rInt;
                    pipaBawah4.Height = 250 + kadal;
                    pipaBawah4.Top = 480 - kadal;
                }
            }
            if (pipaAtas5.Left < -100)
            {
               
                int posisi = 480;
                pipaAtas5.Left = 1500;
                pipaBawah5.Left = 1500;
                Random r = new Random();
                int rInt = r.Next(50, 450);
                pipaAtas5.Height = rInt;
                if (rInt > 250)
                {
                    int kadal = rInt - 250;
                    pipaBawah5.Height = 250 - kadal;
                    pipaBawah5.Top = 480 + kadal;
                }
                if (rInt < 250)
                {
                    int kadal = 250 - rInt;
                    pipaBawah5.Height = 250 + kadal;
                    pipaBawah5.Top = 480 - kadal;
                }
            }
           if(pipaAtas.Left == 300 && setScore == 0)
            {
                score++;

            }
            if (pipaAtas2.Left == 300 && setScore == 0)
            {
                score++;

            }
            if (pipaAtas3.Left == 300 && setScore == 0)
            {
                score++;

            }
            if (pipaAtas4.Left == 300 && setScore == 0)
            {
                score++;

            }
            if (pipaAtas5.Left == 300 && setScore == 0)
            {
                score++;

            }

            string skorUpdate = score.ToString();
            skor.Text =skorUpdate;

            // EndGame

            if(burung.Bounds.IntersectsWith(pipaAtas.Bounds) ||
                burung.Bounds.IntersectsWith(pipaAtas2.Bounds) ||
                burung.Bounds.IntersectsWith(pipaAtas3.Bounds) ||
                burung.Bounds.IntersectsWith(pipaAtas4.Bounds) ||
                burung.Bounds.IntersectsWith(pipaAtas5.Bounds) ||
                burung.Bounds.IntersectsWith(pipaBawah.Bounds) ||
                burung.Bounds.IntersectsWith(pipaBawah2.Bounds) ||
                burung.Bounds.IntersectsWith(pipaBawah3.Bounds) ||
                burung.Bounds.IntersectsWith(pipaBawah4.Bounds) ||
                burung.Bounds.IntersectsWith(pipaBawah5.Bounds) ||
                burung.Bounds.IntersectsWith(tanah.Bounds)

                )
            {
                
                timer1.Stop();
                skor.Text += "Game Over";
                restartBtn.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int pipaAtas2Val = r.Next(200, 300);
            int pipaAtas3Val = r.Next(200, 300);
            int pipaAtas4Val = r.Next(200, 300);
            int pipaAtas5Val = r.Next(200, 300);
            pipaAtas2.Height = pipaAtas2Val;
            pipaAtas3.Height = pipaAtas3Val;
            pipaAtas4.Height = pipaAtas4Val;
            pipaAtas5.Height = pipaAtas5Val;
            if (pipaAtas2Val > 250)
            {
                int kadal = pipaAtas2Val - 250;
                pipaBawah2.Height = 250 - kadal;
                pipaBawah2.Top = 480 + kadal;
            }
            if(pipaAtas2Val < 250 )
            {
                int kadal = 250 - pipaAtas2Val;
                pipaBawah2.Height = 250 + kadal;
                pipaBawah2.Top = 480 - kadal;
            }
            if (pipaAtas3Val > 250)
            {
                int kadal = pipaAtas3Val - 250;
                pipaBawah3.Height = 250 - kadal;
                pipaBawah3.Top = 480 + kadal;
            }
            if (pipaAtas3Val < 250)
            {
                int kadal = 250 - pipaAtas3Val;
                pipaBawah3.Height = 250 + kadal;
                pipaBawah3.Top = 480 - kadal;
            }
            if (pipaAtas4Val > 250)
            {
                int kadal = pipaAtas4Val - 250;
                pipaBawah4.Height = 250 - kadal;
                pipaBawah4.Top = 480 + kadal;
            }
            if (pipaAtas4Val < 250)
            {
                int kadal = 250 - pipaAtas4Val;
                pipaBawah4.Height = 250 + kadal;
                pipaBawah4.Top = 480 - kadal;
            }
            if (pipaAtas5Val > 250)
            {
                int kadal = pipaAtas5Val - 250;
                pipaBawah5.Height = 250 - kadal;
                pipaBawah5.Top = 480 + kadal;
            }
            if (pipaAtas5Val < 250)
            {
                int kadal = 250 - pipaAtas5Val;
                pipaBawah5.Height = 250 + kadal;
                pipaBawah5.Top = 480 - kadal;
            }

            var pos = this.PointToScreen(skor.Location);
            pos = tanah.PointToClient(pos);
            skor.Location = pos;
            skor.Parent = tanah;
            skor.BackColor = Color.Transparent;
        }

        private void testKlik(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.D)
            {
                burung.Top +=   20;
            }
        }

  
        private void restartBtn_Click(object sender, EventArgs e)
        {
            pipaAtas.Left = 1500;
            pipaBawah.Left = 1500;
            pipaAtas2.Left = 1800;
            pipaBawah2.Left = 1800;
            pipaAtas3.Left = 2100;
            pipaBawah3.Left = 2100;
            pipaAtas4.Left = 2400;
            pipaBawah4.Left = 2400;
            pipaAtas5.Left = 2700;
            pipaBawah5.Left = 2700;
            burung.Top = 300;
             score = 0;
            restartBtn.Visible = false;
            timer1.Start();
        }
    }
}
