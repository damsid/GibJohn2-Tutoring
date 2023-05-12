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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Each of these buttons will take the user to the respesctive Form
        private void button_Games_Click(object sender, EventArgs e)
        {
            
            GameForm f2 = new GameForm();
            f2.ShowDialog();
        }

        private void button_Learning_Click(object sender, EventArgs e)
        {
            
            LearningResources f2 = new LearningResources();
            f2.ShowDialog();
        }

        private void button_Collabtools_Click(object sender, EventArgs e)
        {
            
            Whiteboard f2 = new Whiteboard();
            f2.ShowDialog();
        }

        private void panel_NewForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
