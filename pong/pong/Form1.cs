using System;
using System.Windows.Forms;

namespace pong
{
    public partial class Form1 : Form
    {
        int ballX = 6;
        int ballY = 6;

        int playerSpeed = 8;
        int cpuSpeed = 6;

        bool moveUp = false;
        bool moveDown = false;

        float speedMultiplier = 1.0f;     
        float acceleration = 0.001f;     
        float maxSpeedMultiplier = 3.0f;  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlPlayer.Left = 10;
            pnlPlayer.Top = ClientSize.Height / 2 - pnlPlayer.Height / 2;

            pnlCPU.Left = ClientSize.Width - pnlCPU.Width - 10;
            pnlCPU.Top = pnlPlayer.Top;

            picBall.Left = ClientSize.Width / 2 - picBall.Width / 2;
            picBall.Top = ClientSize.Height / 2 - picBall.Height / 2;

            gameTimer.Interval = 20; 
            gameTimer.Start();
        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
            if (moveUp && pnlPlayer.Top > 0)
                pnlPlayer.Top -= playerSpeed;

            if (moveDown && pnlPlayer.Bottom < ClientSize.Height)
                pnlPlayer.Top += playerSpeed;

            picBall.Left += (int)(ballX * speedMultiplier);
            picBall.Top += (int)(ballY * speedMultiplier);

            if (picBall.Top <= 0 || picBall.Bottom >= ClientSize.Height)
                ballY = -ballY;

            if (picBall.Bounds.IntersectsWith(pnlPlayer.Bounds))
                ballX = Math.Abs(ballX);

            if (picBall.Bounds.IntersectsWith(pnlCPU.Bounds))
                ballX = -Math.Abs(ballX);

            if (pnlCPU.Top + pnlCPU.Height / 2 < picBall.Top)
                pnlCPU.Top += cpuSpeed;
            else
                pnlCPU.Top -= cpuSpeed;

            if (picBall.Left <= 0)
                GameOver("CPU Wins!");

            if (picBall.Right >= ClientSize.Width)
                GameOver("You Win!");

            speedMultiplier += acceleration;

            if (speedMultiplier > maxSpeedMultiplier)
                speedMultiplier = maxSpeedMultiplier;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                moveUp = true;

            if (e.KeyCode == Keys.Down)
                moveDown = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                moveUp = false;

            if (e.KeyCode == Keys.Down)
                moveDown = false;
        }

        void ResetBall()
        {
            picBall.Left = ClientSize.Width / 2 - picBall.Width / 2;
            picBall.Top = ClientSize.Height / 2 - picBall.Height / 2;
            ballX = -ballX;
            speedMultiplier = 1.0f;
        }

        void GameOver(string message)
        {
            gameTimer.Stop();
            MessageBox.Show(message, "Game Over");
            this.Close();
        }
    }
}
