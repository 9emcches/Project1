﻿using System;
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
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void btnRespawn_Click(object sender, EventArgs e)
        {
            if (LevelSelect.selectedLevel == 1)
            {
                Level1 game = new Level1();
                game.Show();
                this.Close();
            }
            if (LevelSelect.selectedLevel == 2)
            {
                Level2 game = new Level2();
                game.Show();
                this.Close();
            }
            if (LevelSelect.selectedLevel == 3)
            {
                Level3 game = new Level3();
                game.Show();
                this.Close();
            }
            if (LevelSelect.selectedLevel == 4)
            {
                Level4 game = new Level4();
                game.Show(); //display game
                this.Close();
            }
        }
    }
}
