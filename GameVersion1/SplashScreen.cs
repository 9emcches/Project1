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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }


        const int MAX = 11; //number of facts + 1
        const int MIN = 0;
        const int LOADTIME = 500; //1000 times how many seconds to load game
        Timer tmr;  //Use timer class

        void tmr_Tick(object sender, EventArgs e)
        {            

            tmr.Stop(); //when loading complete stop timer

            if (LevelSelect.selectedLevel == 1)
            {
                Level1 game = new Level1();
                game.Show(); //display game
                this.Close();
            }
            if (LevelSelect.selectedLevel == 2)
            {
                Level2 game = new Level2();
                game.Show(); //display game
                this.Close();
            }
            if (LevelSelect.selectedLevel == 3)
            {
                Level3 game = new Level3();
                game.Show(); //display game
                this.Close();
            }
        }

        private void SplashScreen_Shown_1(object sender, EventArgs e)
        {

            tmr = new Timer(); //creates timer
            LoadFact(); //calls method
            tmr.Interval = LOADTIME; //set time interval
            tmr.Start(); //starts the timer
            tmr.Tick += tmr_Tick;

        }

        public void LoadFact()
        {
            Random rand = new Random();
            int factNum = rand.Next(MIN, MAX);
            if (factNum == 0)
            {
                lblFact.Text = "Some cats are allergic to humans.";
            }
            else if (factNum == 1)
            {
                lblFact.Text = "Oranges aren't naturally occurring fruits.";
            }
            else if (factNum == 2)
            {
                lblFact.Text = "The hottest inhabited place on Earth is in Ethiopia.";
            }
            else if (factNum == 3)
            {
                lblFact.Text = "Hot water freezes faster than cold water.";
            }
            else if (factNum == 4)
            {
                lblFact.Text = "Pigs don't sweat.";
            }
            else if (factNum == 5)
            {
                lblFact.Text = "In ancient times spider webs were used as bandages.";
            }
            else if (factNum == 6)
            {
                lblFact.Text = "It would only take one hour to drive to space.";
            }
            else if (factNum == 7)
            {
                lblFact.Text = "Clouds can weigh more than 500 thousand kilograms.";
            }
            else if (factNum == 8)
            {
                lblFact.Text = "Sloths can hold their breath longer than dolphins can.";    
            }
            else if (factNum == 9)
            {
                lblFact.Text = "Flamingos bend their legs at the ankle rather than their knee.";
            }
            else if (factNum == 10)
            {
                lblFact.Text = "Octopuses have three hearts.";
            }


        }


    }
}
