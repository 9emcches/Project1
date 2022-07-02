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
    public partial class LevelSelect : Form
    {

        public static int selectedLevel;
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            selectedLevel = 1;
            SplashScreen loading = new SplashScreen();
            loading.Show();
            this.Hide();
        }
    }
}
