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
    public partial class DeathScreen : Form
    {
        public DeathScreen()
        {
            InitializeComponent();
            btnMenu.TabStop = false;
        }

        private void DeathScreen_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space) //if key is space
            {
                if (LevelSelect.selectedLevel == 1)
                {
                    Level1 game = new Level1();
                    game.Show(); //display game
                    this.Close();
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Close();
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
    }
}
