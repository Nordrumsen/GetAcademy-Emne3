using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class MainForm : Form
    {
        private const int BirdJumpForce = 8;
        private const int Gravity = 1;

        private int birdPositionY;
        private int birdVelocity;
        private bool gameOver;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Set up the initial state of the game
            birdPositionY = 200;
            birdVelocity = 0;
            gameOver = false;

            // Set up event handlers
            this.KeyDown += MainForm_KeyDown;
            gameTimer.Tick += GameTimer_Tick;
            gameTimer.Interval = 20;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Make the bird jump when the spacebar is pressed
            if (e.KeyCode == Keys.Space)
                birdVelocity = -BirdJumpForce;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Update the bird's position
            birdPositionY += birdVelocity;
            birdVelocity += Gravity;

            // Detect collisions
            if (birdPictureBox.Bounds.IntersectsWith(pipePictureBox.Bounds))
            {
                gameOver = true;
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
            }

            // Move the pipes
            pipePictureBox.Left -= 5;

            // Check if the bird is out of bounds
            if (birdPositionY < 0 || birdPositionY > this.Height)
            {
                gameOver = true;
                gameTimer.Stop();
                MessageBox.Show("Game Over!");
            }

            // Refresh the form to update the game state
            this.Refresh();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Draw the bird at its current position
            e.Graphics.FillEllipse(Brushes.Yellow, 100, birdPositionY, 30, 30);
        }
    }
}