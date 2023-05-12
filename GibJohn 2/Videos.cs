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
    public partial class Videos : Form
    {
        public Videos()
        {
            InitializeComponent();
        }

        private void Videos_Load(object sender, EventArgs e)
        {
            
        }


        // This segment of code opens different video material based on the user's input choice
        // This time I didn't hide the previous form, so that the user can easily return to the previous form
        private void button_English_Click(object sender, EventArgs e)
        {
            EnglishVideos f2 = new EnglishVideos();
            f2.ShowDialog();
        }

        private void button_Maths_Click(object sender, EventArgs e)
        {
            MathsVideos f2 = new MathsVideos();
            f2.ShowDialog();
        }

        private void button_Science_Click(object sender, EventArgs e)
        {
            ScienceVideos f2 = new ScienceVideos();
            f2.ShowDialog();
        }
    }
}
