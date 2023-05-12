using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GibJohn_2
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }


        // Each button will take the user to the respective game.
        private void button_Maths_Click(object sender, EventArgs e)
        {
            this.Hide();
            MathGame f2 = new MathGame();
            f2.ShowDialog();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Science_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScienceGame f2 = new ScienceGame();
            f2.ShowDialog();
        }

        private void button_English_Click(object sender, EventArgs e)
        {
            this.Hide();
            EnglishGame f2 = new EnglishGame();
            f2.ShowDialog();
        }
    }
}
