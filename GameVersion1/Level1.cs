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

        bool moveLeft, moveRight, faceLeft, jumping;
        int jumpSpeed;
        int jumpForce;
        const int SPEED = 7;


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
                jumping = true;
            }


        }


        private void TimerEvent(object sender, EventArgs e)
        {

            pbPlayer.Top += jumpSpeed;


            if (moveLeft == true) //if player wants to move left
            {
                MoveGameParts("right"); //pass "right" to movegameparts method
            }
            if (moveRight == true) //if player wants to move right
            {
                MoveGameParts("left"); //pass "left" to movegameparts method
            }
    


            if (jumping == true) //if player is jumping
            {
                jumpSpeed = -15;
                jumpForce -= 1;
            }
            else
            {
                jumpSpeed = 15;
            }

            if (jumping == true && jumpForce < 0)
            {
                jumping = false;
            }

            foreach (Control x in this.Controls) //for each game asset
            {
                if (x is PictureBox && (string)x.Tag == "platform")//if asset is tagged as "platform"
                {
                    if (pbPlayer.Bounds.IntersectsWith(x.Bounds) && jumping == false) //if player touches game asset
                    {
                        jumpForce = 2;
                        pbPlayer.Top = x.Top - pbPlayer.Height;
                        jumpSpeed = 0;
                    }

                    x.BringToFront();

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
            if (jumping == true)
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
                if (x is PictureBox && (string)x.Tag == "platform") //if asset is tagged as "platform"
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
