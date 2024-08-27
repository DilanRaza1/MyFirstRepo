using System;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        // Variables for game mechanics
        int ballXSpeed = 6;
        int ballYSpeed = 6;
        int paddleSpeed = 15;
        int score = 0;

        // Boolean flags for paddle movement
        private bool goUpLeft;
        private bool goDownLeft;
        private bool goUpRight;
        private bool goDownRight;

        // AI paddle speed
        float aiPaddleSpeed = 5.0f;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Start();

            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            ball.Left += ballXSpeed;
            ball.Top += ballYSpeed;

            CheckBallCollision();
            UpdateAI();
            UpdatePlayerPaddle();
        }

        private void CheckBallCollision()
        {
            if (ball.Bounds.IntersectsWith(topBoundary.Bounds) || ball.Bounds.IntersectsWith(bottomBoundary.Bounds))
            {
                ballYSpeed = -ballYSpeed;
            }

            if (ball.Bounds.IntersectsWith(paddle.Bounds) || ball.Bounds.IntersectsWith(paddleRight.Bounds))
            {
                ballXSpeed = -ballXSpeed;
                score++;
            }

            if (ball.Left < 0 || ball.Right > this.ClientSize.Width)
            {
                gameTimer.Stop();
                MessageBox.Show("Game Over! Your score: " + score);
            }
        }

        private void UpdateAI()
        {
            // Predict the ball's position when it reaches the AI's x-coordinate
            float predictedBallY = ball.Top + (ball.Left - paddleRight.Left) * (ballYSpeed / ballXSpeed);

            // Move the AI paddle based on the predicted ball position
            if (predictedBallY < paddleRight.Top + paddleRight.Height / 2)
            {
                MoveAIPaddleUp();
            }
            else
            {
                MoveAIPaddleDown();
            }
        }

        // The MoveAIPaddleUp() and MoveAIPaddleDown() methods remain the same

        // The UpdatePlayerPaddle() method remains the same

        // The Form1_KeyDown() and Form1_KeyUp() methods remain the same
    }
}