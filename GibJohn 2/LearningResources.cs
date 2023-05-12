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
    public partial class LearningResources : Form
    {
        public LearningResources()
        {
            InitializeComponent();
        }
      


        // Each button will take the user to the respective Form.
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            Videos f2 = new Videos();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            ReadingMaterial f2 = new ReadingMaterial();
            f2.ShowDialog();
        }

        private void button_Learning_Click(object sender, EventArgs e)
        {
            
            RevisionResources f2 = new RevisionResources();
            f2.ShowDialog();
        }

        private void LearningResources_Load(object sender, EventArgs e)
        {

        }
    }
}
