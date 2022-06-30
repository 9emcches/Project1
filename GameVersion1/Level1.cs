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
    public partial class Level1 : Form
    {

        bool moveLeft, moveRight, faceLeft, jumping, jumpComplete;
        int force;
        const int SPEED = 7;
        const int  F= 10;
        const int G = 5;

        /// <summary>
        /// sets true state for movement states when a key is down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) //if key is left
            {
                moveLeft = true;              
            }
            if (e.KeyCode == Keys.Right) //if key is right
            {
                moveRight = true;
            }
                if (e.KeyCode == Keys.Up && jumping == false) //if key is up
                {
                    jumpComplete = false;
                    jumping = true;
                    force = F;
                }


        }


        private void TimerEvent(object sender, EventArgs e)
        {
            if (moveLeft == true) //if player wants to move left
            {
                MoveGameParts("right"); //pass "right" to movegameparts method
            }
            if (moveRight == true) //if player wants to move right
            {
                MoveGameParts("left"); //pass "left" to movegameparts method
            }
    

            if (pbPlayer.Bounds.IntersectsWith(pbPortal.Bounds))
            {
                this.Close();
                MainMenu test = new MainMenu();
                test.Show();

            }


            if (jumping == true) //if player is jumping
            {
                pbPlayer.Top -= force;
                force -= 1;
            }
            else
            {
                pbPlayer.Top += G;
            }

   

            foreach (Control x in this.Controls) //for each game asset
            {
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "movable")//if asset is tagged as "platform" or "movable"
                {
                    if (pbPlayer.Left + pbPlayer.Width - 1 > x.Left && pbPlayer.Left + pbPlayer.Width + 5 < x.Left + x.Width + pbPlayer.Width && pbPlayer.Top + pbPlayer.Height >= x.Top && pbPlayer.Top < x.Top) //if player touches game asset
                    {
                        force = 0;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        jumping = false;
                    }

                    if (jumping == true && pbPlayer.Left + pbPlayer.Width - 1 > x.Left && pbPlayer.Left + pbPlayer.Width + 5 < x.Left + x.Width + pbPlayer.Width && pbPlayer.Top + pbPlayer.Height >= x.Top && pbPlayer.Top < x.Top)
                    {
                        jumping = false;
                        jumpComplete = true;
                    }

                }

                if (x is PictureBox && (string)x.Tag == "platform")
                {

                    if (pbPlayer.Right > x.Left && pbPlayer.Left < x.Right - pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top)
                    {
                        moveRight = false;
                        
                    }
                    if (pbPlayer.Left < x.Right && pbPlayer.Right > x.Left + pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top)
                    {
                        moveLeft = false;
                        
                    }
                } 
                    
                if (x is PictureBox && (string)x.Tag == "movable")
                {

                    if (pbPlayer.Right > x.Left && pbPlayer.Left < x.Right - pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top)
                    {
                        x.Left -= SPEED;
                    }
                    if (pbPlayer.Right < x.Left && pbPlayer.Left > x.Right - pbPlayer.Width / 2 && pbPlayer.Bottom > x.Top)
                    {
                        x.Left += SPEED;
                    }
                }


            }

        }

      

        /// <summary>
        /// sets false state for movement states when a key is up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                moveRight = false;
            }
            if (jumping == true && jumpComplete == true)
            {
                jumping = false;
            }
        }

        public Level1()
        {
            InitializeComponent();
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
                if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "movable") //if asset is tagged as "platform" or "movable"
                {
                    if(direction == "left") //if player wants to move left
                    {
                        x.Left -= SPEED; //change relative position by - speed
                    }
                    if(direction == "right") //if player wants to move right
                    {
                        x.Left += SPEED; //change relative position by + speed
                    }
                }
            }

        }
    }
}
