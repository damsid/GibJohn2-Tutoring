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

    class Difficulty
    {
        public int gamemode;

    }

    public partial class MathGameOptions : Form
    {
        public MathGameOptions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Difficulty chosen_difficulty = new Difficulty();
            chosen_difficulty.gamemode = 1;

            // load form after accepting difficulty
            this.Hide();
            MathGame f2 = new MathGame();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Difficulty chosen_difficulty = new Difficulty();
            chosen_difficulty.gamemode = 2;

            // load form after accepting difficulty
            this.Hide();
            MathGame f2 = new MathGame();
            f2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Difficulty chosen_difficulty = new Difficulty();
            chosen_difficulty.gamemode = 3;

            // load form after accepting difficulty
            this.Hide();
            MathGame f2 = new MathGame();
            f2.ShowDialog();
        }
    }
}
