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
    public partial class ReadingMaterial : Form
    {
        public ReadingMaterial()
        {
            InitializeComponent();
        }

        private void pictureBox_Maths_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/cgp-gsce-mathsmathematics-aqa-revision-guide-higher-17062018-e158655337.html");
        }

        private void pictureBox_English_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/work-out-english-language-o-level-gcse-e158013990.html");
        }

        private void pictureBox_Science_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/search?q=gcse+science&pagecount=&pubyear=&searchin=&em=");
        }

        private void pictureBox_Art_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/gcse-9-1-art-and-design-e19940800.html");
        }

        private void pictureBox_Business_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/aqa-business-for-gcse-applied-options-e190028868.html");
        }

        private void pictureBox_Computing_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/gcse-computer-science-2016-sample-assessment-materials-issue-2-e21338046.html");
        }

        private void pictureBox_Drama_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/drama-gcse-e51554436.html");
        }

        private void pictureBox_MFL_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/search?q=gcse+foreign+languages&pagecount=&pubyear=&searchin=&em=");
        }

        private void pictureBox_Music_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/gcse-music-e18756436.html");
        }

        private void pictureBox_History_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pdfdrive.com/aqa-gcse-history-understanding-the-modern-world-e53826839.html");
        }
    }
}
