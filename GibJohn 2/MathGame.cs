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
    public partial class MathGame : Form
    {
        Random rnd = new Random();
        int score;
        int total;
        string[] Maths = { "Add", "Subtract", "Multiply" };
        private bool HarderDifficulty;

        public MathGame()
        {
            InitializeComponent();

            DialogResult dialogResult = MessageBox.Show("Would you like to enable Hard difficulty?", "Difficulty", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                HarderDifficulty = true;
                StartGame2();
            }
            else if (dialogResult == DialogResult.No)
            {
                HarderDifficulty = false;
                StartGame1();
            }

            
        }

        private void MathGame_Load(object sender, EventArgs e)
        {
            
            
        }
   
        private void CheckInput(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAnswer.Text, "[^0-9]"))
            {
                MessageBox.Show("Incorrect input - please enter a number");
                txtAnswer.Text = txtAnswer.Text.Remove(txtAnswer.Text.Length - 1);
            }
        }

        private void CheckButtonClickEvent(object sender, EventArgs e)
        {

            int userEntered = Convert.ToInt32(txtAnswer.Text);

            if (userEntered == total)
            {
                lblAnswer.Text = "Correct";
                lblAnswer.ForeColor = Color.Green;
                score += 1;
                lblScore.Text = "Score: " + score;
                StartGame1();
            }
            else
            {
                lblAnswer.Text = "Incorrect";
                lblAnswer.ForeColor = Color.Red;
                score -= 1;
                lblScore.Text = "Score: " + score;
            }
            if (HarderDifficulty == true)
            {
                StartGame2();
            }
            else if (HarderDifficulty == false) 
            {
                StartGame1();
            }

            

        }

        private void StartGame1()
        {
            lblDifficulty.Text = "Easy";
            int numA = rnd.Next(10, 20);
            int numB = rnd.Next(0, 9);
       
            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    lblCheat.Text = total.ToString();
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    lblCheat.Text = total.ToString();
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    lblCheat.Text = total.ToString();
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }



        private void StartGame2()
        {
            lblDifficulty.Text = "Hard";
            int numA = rnd.Next(51, 100);
            int numB = rnd.Next(10, 50);

            txtAnswer.Text = null;

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    total = numA + numB;
                    lblSymbol.Text = "+";
                    lblSymbol.ForeColor = Color.DarkGreen;
                    lblCheat.Text = total.ToString();
                    break;

                case "Subtract":
                    total = numA - numB;
                    lblSymbol.Text = "-";
                    lblSymbol.ForeColor = Color.Maroon;
                    lblCheat.Text = total.ToString();
                    break;

                case "Multiply":
                    total = numA * numB;
                    lblSymbol.Text = "x";
                    lblSymbol.ForeColor = Color.Purple;
                    lblCheat.Text = total.ToString();
                    break;
            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            DialogResult dialogResult2 = MessageBox.Show("Would you like to enable developer settings?", "Developer settings", MessageBoxButtons.YesNo);

            if (dialogResult2 == DialogResult.Yes)
            {
                lblCheat.Visible = true;
                lblDifficulty.Visible = true;
                

            }
            else if (dialogResult2 == DialogResult.No)
            {
                lblCheat.Visible = false;
                lblDifficulty.Visible = false;
            }
        }

        private void BackToMainMenu(object sender, EventArgs e)
        {
            this.Hide();
            GameForm f2 = new GameForm();
            f2.ShowDialog();
        }
    }
}

