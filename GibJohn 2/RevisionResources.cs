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
    public partial class RevisionResources : Form
    {
        public RevisionResources()
        {
            InitializeComponent();
        }


        // Each of these picture boxes will take the user to the respective third-party website.
        private void box_Memrise_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.memrise.com/"); 
        }

        private void box_Seneca_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://senecalearning.com/en-GB/");
        }

        private void box_KhanAcademy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.khanacademy.org/");
        }

        private void lbl_Memrise_Click(object sender, EventArgs e)
        {
            WhyMemrise f2 = new WhyMemrise();
            f2.ShowDialog();
        }

        private void lbl_Seneca_Click(object sender, EventArgs e)
        {
            WhySeneca f2 = new WhySeneca();
            f2.ShowDialog();
        }

        private void lbl_KhanAcademy_Click(object sender, EventArgs e)
        {
            WhyKhanAcademy f2 = new WhyKhanAcademy();
            f2.ShowDialog();
        }

        private void RevisionResources_Load(object sender, EventArgs e)
        {

        }
    }
}
