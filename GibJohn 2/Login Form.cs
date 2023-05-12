using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static test.Account;

namespace GibJohn_2
{

    public partial class Loginform : Form
    {


        ClassDB call = new ClassDB();

        public Loginform()
        {
            InitializeComponent();

        }

        // This is the actual "LOGIN" button, which matches the inputted data to the database.
        // If the inputted data is correct, allow user to pass through to 2nd form
        // If the inputted data is incorrect, leave user at login screen to try again
        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (call.login(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("You have successfully logged in.");
                    Form1 frm = new Form1();

                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failure to log in - please try again.");
                }
            }
    }

        private void Loginform_Load(object sender, EventArgs e)
        {

        }
    }
}
