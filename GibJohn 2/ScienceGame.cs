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
    public partial class ScienceGame : Form
    {
        // Creates variables, which we can store values in later
        int ElementClicked;
        int score;
        int RandomElement;

        public void GenerateQuestion()
        {
            // This method generates a new random element from the 20 different ones available
            Random rnd = new Random();
            RandomElement = rnd.Next(1, 20);

            // This part of the method assigns a name to the randomly generated element
            switch (RandomElement)
            {
                case 1:
                    lbl_ElementName.Text = ("Hydrogen");
                    break;

                case 2:
                    lbl_ElementName.Text = ("Helium");
                    break;

                case 3:
                    lbl_ElementName.Text = ("Lithium");
                    break;

                case 4:
                    lbl_ElementName.Text = ("Carbon");
                    break;

                case 5:
                    lbl_ElementName.Text = ("Nitrogen");
                    break;

                case 6:
                    lbl_ElementName.Text = ("Oxygen");
                    break;

                case 7:
                    lbl_ElementName.Text = ("Fluorine");
                    break;

                case 8:
                    lbl_ElementName.Text = ("Neon");
                    break;

                case 9:
                    lbl_ElementName.Text = ("Sodium");
                    break;

                case 10:
                    lbl_ElementName.Text = ("Magnesium");
                    break;

                case 11:
                    lbl_ElementName.Text = ("Phosphorus");
                    break;

                case 12:
                    lbl_ElementName.Text = ("Sulfur");
                    break;

                case 13:
                    lbl_ElementName.Text = ("Chlorine");
                    break;

                case 14:
                    lbl_ElementName.Text = ("Potassium");
                    break;

                case 15:
                    lbl_ElementName.Text = ("Calcium");
                    break;

                case 16:
                    lbl_ElementName.Text = ("Titanium");
                    break;

                case 17:
                    lbl_ElementName.Text = ("Iron");
                    break;

                case 18:
                    lbl_ElementName.Text = ("Cobalt");
                    break;

                case 19:
                    lbl_ElementName.Text = ("Gold");
                    break;

                case 20:
                    lbl_ElementName.Text = ("Silver");
                    break;
            }
        }

        private void CheckAnswer()
        {
            // This method checks your answer, grants you +1 score if you are correct, and restarts the whole game using GenerateQuestion
            if (ElementClicked == RandomElement)
            {
                score += 1;
                lbl_Score.Text = score.ToString();
                MessageBox.Show("Correct! +1 score :)");
                ElementClicked = 0;
                GenerateQuestion();
            }
            else
            {
                score -= 1;
                lbl_Score.Text = score.ToString();
                MessageBox.Show("Incorrect. -1 score :(");
                ElementClicked = 0;
                GenerateQuestion();
            }

        }
        public ScienceGame()
        {
            InitializeComponent();
        }
        private void ScienceGame_Load(object sender, EventArgs e)
        {
            // This makes sure that one of the very first things the form does is load a question
            GenerateQuestion();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GenerateQuestion();            
        }


        // Each of these clickable labels are used to provide input to answer
        // These integers are converted to an element using the CheckAnswer() function.
        private void label2_Click(object sender, EventArgs e)
        {
            ElementClicked = 1;
            CheckAnswer();
                      
        }

        private void label51_Click(object sender, EventArgs e)
        {
            ElementClicked = 2;
            CheckAnswer();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ElementClicked = 3;
            CheckAnswer();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            ElementClicked = 4;
            CheckAnswer();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            ElementClicked = 5;
            CheckAnswer();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            ElementClicked = 6;
            CheckAnswer();
        }

        private void label52_Click(object sender, EventArgs e)
        {
            ElementClicked = 7;
            CheckAnswer();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            ElementClicked = 8;
            CheckAnswer();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ElementClicked = 9;
            CheckAnswer();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ElementClicked = 10;
            CheckAnswer();
        }

        private void label63_Click(object sender, EventArgs e)
        {
            ElementClicked = 11;
            CheckAnswer();
        }

        private void label73_Click(object sender, EventArgs e)
        {
            ElementClicked = 12;
            CheckAnswer();
        }

        private void label90_Click(object sender, EventArgs e)
        {
            ElementClicked = 13;
            CheckAnswer();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ElementClicked = 14;
            CheckAnswer();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            ElementClicked = 15;
            CheckAnswer();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            ElementClicked = 16;
            CheckAnswer();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            ElementClicked = 17;
            CheckAnswer();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            ElementClicked = 18;
            CheckAnswer();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            ElementClicked = 19;
            CheckAnswer();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            ElementClicked = 20;
            CheckAnswer();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label25_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label31_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label33_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label34_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label35_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label36_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label37_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label58_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label62_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label64_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label65_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label67_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label68_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label69_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label70_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label71_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label72_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label74_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label75_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label76_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label77_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label78_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label79_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label80_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label81_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label82_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label83_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label84_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label85_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label86_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label87_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label88_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void label89_Click(object sender, EventArgs e)
        {
            ElementClicked = 30;
            CheckAnswer();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm f2 = new GameForm();
            f2.ShowDialog();
        }
    }
}

