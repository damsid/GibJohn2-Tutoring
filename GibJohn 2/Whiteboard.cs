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
    public partial class Whiteboard : Form
    {
        public Whiteboard()
        {
            InitializeComponent();
            // Instantly allows user to draw on the whiteboard by creating graphics
            g = panel_Canvas.CreateGraphics();
        }

        // Inspiration taken from https://www.codeproject.com/Articles/16291/Very-Simple-Paint
        

        private void Whiteboard_Load(object sender, EventArgs e)
        {

        }

        // Setting default variables here
        bool startPaint = false;
        Graphics g;

        int? initX = null;
        int? initY = null;
        public int Value { get; set; }
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;

        private void button_PenColor_Click(object sender, EventArgs e)
        {
            // Opens a preset "Color Dialog" when the user requests a color palette 
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                button_PenColor.BackColor = c.Color;
            }
        }

        private void button_CanvasColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK)
            {
                panel_Canvas.BackColor = c.Color;
                button_CanvasColor.BackColor = c.Color;
            }
        }

        private void button_Square_Click(object sender, EventArgs e)
        {
            // Begins "if (drawSquare) statement
            drawSquare = true;
        }

        private void button_Circle_Click(object sender, EventArgs e)
        {
            // Begins "if (drawCircle) statement
            drawCircle = true;
        }

        private void button_Rectangle_Click(object sender, EventArgs e)
        {
            // Begins "if (drawRectangle) statement
            drawRectangle = true;
        }

        private void panel_Canvas_MouseUp_1(object sender, MouseEventArgs e)
        {
            // This stops paint from being placed on the canvas once the mousebutton isn't being held anymore
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void panel_Canvas_MouseDown_1(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
                // Use Solid Brush for filling the graphic shapes
                SolidBrush sb = new SolidBrush(button_PenColor.BackColor);
                // Grabs input from user on what size and color the shape should be
                g.FillRectangle(sb, e.X, e.Y, int.Parse(textBox_ShapeSize.Text), int.Parse(textBox_ShapeSize.Text));
                // To avoid duplicates and random drawings of paint, sets both of these variables back to false
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(button_PenColor.BackColor);
                // Unlike a square, the line below sets the width of the rectangle to be twice that of the height
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(textBox_ShapeSize.Text), int.Parse(textBox_ShapeSize.Text));
                startPaint = false;
                // Sets back to false to make sure duplicate rectangles aren't drawn
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(button_PenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(textBox_ShapeSize.Text), int.Parse(textBox_ShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void panel_Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                // This part of the code takes input from the user to decide on the color and
                // size of the pen, and starts a new line of paint if the mousebutton is pushed down
                Pen p = new Pen(button_PenColor.BackColor, float.Parse(comboBox1.Text));
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
            } 
        }

        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // When the user clicks on "File" and then "New", this code will run, and generate
            // a completely fresh canvas for the user to draw on.
            g.Clear(panel_Canvas.BackColor);
            panel_Canvas.BackColor = Color.White;
            button_CanvasColor.BackColor = Color.White;
        }

        private void panel_Canvas_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}


