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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens help page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            InstructionsPage help = new InstructionsPage();
            help.Show();
            this.Hide();
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            LevelSelect select = new LevelSelect();
            select.Show();
            this.Hide();
        }

        private void lblVersionInfo_Click(object sender, EventArgs e)
        {

        }


    }
}
