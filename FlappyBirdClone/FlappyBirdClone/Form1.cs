using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdClone
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5;
        int gravity = 8;
        int score = 0;
        int cloudSpeed = 9;
        Random rand = new Random();
       

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            birdPb.Top += gravity;
            pipeBottomPb.Left -= pipeSpeed;
            pipeTopPb.Left -= pipeSpeed;
            lbScore.Text = "Rezultat: " + score;
            cloud.Left -= cloudSpeed;
            grass1.Left -= pipeSpeed;
            grass4.Left -= pipeSpeed;
            grass5.Left -= pipeSpeed;

            if(grass1.Left < -100)
            {
                grass1.Left = 600;
            }

           

            if (grass4.Left < -100)
            {
                grass4.Left = 600;
            }

            if (grass5.Left < -100)
            {
                grass5.Left = 600;
            }
            if (cloud.Left < -200)
            {
                cloud.Left = 700;
            }
            if(pipeBottomPb.Left < -100)
            {
                pipeBottomPb.Left = 600;
                score++;
            }
            if (pipeTopPb.Left < -120)
            {
                pipeTopPb.Left = 700;
                score++;
            }
            if(birdPb.Bounds.IntersectsWith(pipeBottomPb.Bounds) || birdPb.Bounds.IntersectsWith(pipeTopPb.Bounds) || birdPb.Bounds.IntersectsWith(groundPb.Bounds) || birdPb.Top < -40)
            {
                gameOver();
            }
            

            if(score % 5 == 0 && score != 0)
            {
                pipeSpeed = rand.Next(5, 20);
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -13;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void gameOver()
        {
            gameTimer.Stop();
            lbGameOver.Text = "Kraj na igrata :(";
        }
    }
}
