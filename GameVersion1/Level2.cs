using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameVersion1
{
    public partial class Level2 : Form
    {
        bool moveLeft, moveRight, jumping, jumpComplete, doubleJumpReady, doubleJumpComplete;
        int force;
        const int SPEED = 7;
        const int JUMPFORCE = 10;
        const int GRAVITY = 5;


        /// <summary>
        /// sets true state for movement states when a key is down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //if key is left
            {
                moveLeft = true; //moving left
                pbPlayer.Image = Image.FromFile("playerLeft1.png"); //player face left
            }
            if (e.KeyCode == Keys.Right) //if key is right
            {
                moveRight = true; //moving right
                pbPlayer.Image = Image.FromFile("playerRight1.png"); //player face right
            }
            if (e.KeyCode == Keys.Up && jumping == false) //if key is up
            {
                jumpComplete = false; //set jump to incomplete
                jumping = true; //set jumping to true
                force = JUMPFORCE; //set force value to JUMPFORCE
                doubleJumpReady = false; //set double jump ready false
                doubleJumpComplete = false; //set double jump to incomplete
            }
            if (e.KeyCode == Keys.Up && doubleJumpReady == true) //if double jump ready and key is up
            {
                doubleJumpReady = false;
                force = JUMPFORCE; //set force value to JUMPFORCE
                doubleJumpComplete = true;
            }
            if (e.KeyCode == Keys.R) //if key is left
            {
                this.Close(); //close this level
                DeathScreen dead = new DeathScreen(); //set next form
                dead.Show(); //show next form
            }

        }


        private void TimerEvent(object sender, EventArgs e)
        {


            if (jumping == true) //if player is jumping
            {
                pbPlayer.Top -= force; //-force amount from player top value
                force -= 1; //decrease force by -1
            }
            else
            {
                pbPlayer.Top += GRAVITY; //player pulled by gravity
            }


            foreach (Control x in this.Controls) //for each game asset
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "movable")//if asset is tagged as "platform" or "movable"
                {
                    if (pbPlayer.Left + pbPlayer.Width - 1 > x.Left && pbPlayer.Left + pbPlayer.Width + 5 < x.Left + x.Width + pbPlayer.Width && pbPlayer.Top + pbPlayer.Height >= x.Top && pbPlayer.Top < x.Top) //if player touches game asset top
                    {
                        force = 0; //force set to 0 
                        pbPlayer.Top = x.Top - pbPlayer.Height; //player position set on top of object
                        jumping = false;
                    }

                    if (jumping == true && pbPlayer.Left + pbPlayer.Width - 1 > x.Left && pbPlayer.Left + pbPlayer.Width + 5 < x.Left + x.Width + pbPlayer.Width && pbPlayer.Top + pbPlayer.Height >= x.Top && pbPlayer.Top < x.Top) //if player touches game asset top and is jumping
                    {
                        jumping = false;
                        jumpComplete = true;
                        doubleJumpReady = true;
                        doubleJumpComplete = false;
                    }

                }

                if (x is PictureBox && (string)x.Tag == "platform")
                {
                    if (pbPlayer.Right > x.Left && pbPlayer.Left < x.Right - pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top && pbPlayer.Top < x.Bottom) //if player touching platform side
                    {
                        moveRight = false;
                    }
                    if (pbPlayer.Left < x.Right && pbPlayer.Right > x.Left + pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top && pbPlayer.Top < x.Bottom) //if player touching platform side
                    {
                        moveLeft = false;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "movable")
                {

                    if (pbPlayer.Right > x.Left && pbPlayer.Left < x.Right - pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top && pbPlayer.Top < x.Bottom) //if player touching movable side
                    {
                        x.Left = pbPlayer.Right; //player pushes movable object
                    }
                    if (pbPlayer.Left < x.Right && pbPlayer.Right > x.Left + pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top && pbPlayer.Top < x.Bottom) //if player touching movable side
                    {
                        x.Left = pbPlayer.Left - x.Width; //player pushes movable object
                    }

                    x.BringToFront();
                }

                if (x is PictureBox && (string)x.Tag == "danger")
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds)) //if player touches spike
                    {
                        this.Close(); //close this level
                        DeathScreen dead = new DeathScreen(); //set next form
                        dead.Show(); //show next form
                    }

                    x.SendToBack();
                }

            }

            if (moveLeft == true) //if player wants to move left
            {
                MoveGameParts("right"); //pass "right" to movegameparts method
            }
            if (moveRight == true) //if player wants to move right
            {
                MoveGameParts("left"); //pass "left" to movegameparts method
            }







            if (pbPlayer.Bounds.IntersectsWith(pbPortal.Bounds)) //if player touches portal
            {
                this.Close(); //close this level
                Level2 game = new Level2(); //set next form
                game.Show(); //show next form

            }

        }



        /// <summary>
        /// sets false state for movement states when a key is up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) // if key up is left arrow
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right) // if key up is right arrow 
            {
                moveRight = false;
            }
            if (jumping == true && doubleJumpComplete == false) // if jump key up and double jump action has not been performed
            {
                doubleJumpReady = true; //double jump ready set ready
            }
            if (jumping == true && jumpComplete == true) // if jumping is still set true but jump complete
            {
                jumping = false;
            }

        }

        public Level2()
        {
            InitializeComponent();
            pbPlayer.SendToBack();
        }


        /// <summary>
        /// Moving game assets relative to player
        /// passes string variable to show what direction the player is moving
        /// </summary>
        /// <param name="direction"></param>
        private void MoveGameParts(string direction)
        {

            foreach (Control x in this.Controls) //for each game asset
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "movable" || x is PictureBox && (string)x.Tag == "danger" || x is Label) //if asset is tagged as "platform" or "movable" or "spike" or is a label
                {
                    if (direction == "left") //if player wants to move left
                    {
                        x.Left -= SPEED; //change relative position by - speed
                    }
                    if (direction == "right") //if player wants to move right
                    {
                        x.Left += SPEED; //change relative position by + speed
                    }
                }
            }

        }
    }
}
