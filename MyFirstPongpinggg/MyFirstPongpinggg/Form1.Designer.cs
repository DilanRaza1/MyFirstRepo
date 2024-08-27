namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.paddle = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.bottomBoundary = new System.Windows.Forms.Panel();
            this.topBoundary = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.paddleRight = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // paddle
            // 
            this.paddle.BackColor = System.Drawing.SystemColors.Menu;
            this.paddle.Location = new System.Drawing.Point(12, 153);
            this.paddle.Name = "paddle";
            this.paddle.Size = new System.Drawing.Size(15, 100);
            this.paddle.TabIndex = 0;
            this.paddle.Paint += new System.Windows.Forms.PaintEventHandler(this.paddle_Paint);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ball.Location = new System.Drawing.Point(341, 193);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.TabIndex = 1;
            // 
            // bottomBoundary
            // 
            this.bottomBoundary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bottomBoundary.Location = new System.Drawing.Point(0, 401);
            this.bottomBoundary.Name = "bottomBoundary";
            this.bottomBoundary.Size = new System.Drawing.Size(800, 10);
            this.bottomBoundary.TabIndex = 2;
            // 
            // topBoundary
            // 
            this.topBoundary.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.topBoundary.Location = new System.Drawing.Point(0, 0);
            this.topBoundary.Name = "topBoundary";
            this.topBoundary.Size = new System.Drawing.Size(800, 10);
            this.topBoundary.TabIndex = 3;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // paddleRight
            // 
            this.paddleRight.BackColor = System.Drawing.SystemColors.Menu;
            this.paddleRight.Location = new System.Drawing.Point(750, 175);
            this.paddleRight.Name = "paddleRight";
            this.paddleRight.Size = new System.Drawing.Size(15, 100);
            this.paddleRight.TabIndex = 4;
            // 
            // Form1
            // 
            this.AccessibleName = "Ping Pong Game";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.paddleRight);
            this.Controls.Add(this.topBoundary);
            this.Controls.Add(this.bottomBoundary);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.paddle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paddle;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Panel bottomBoundary;
        private System.Windows.Forms.Panel topBoundary;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel paddleRight; // Add this line
    }
}