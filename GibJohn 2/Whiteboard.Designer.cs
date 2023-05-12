namespace GibJohn_2
{
    partial class Whiteboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_ShapeSize = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Square = new System.Windows.Forms.Button();
            this.button_CanvasColor = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_PenColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Canvas = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip_File = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GibJohn_2.Properties.Resources.background;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox_ShapeSize);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.button_Rectangle);
            this.panel1.Controls.Add(this.button_Circle);
            this.panel1.Controls.Add(this.button_Square);
            this.panel1.Controls.Add(this.button_CanvasColor);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button_PenColor);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 421);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(2, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // textBox_ShapeSize
            // 
            this.textBox_ShapeSize.Location = new System.Drawing.Point(5, 387);
            this.textBox_ShapeSize.Name = "textBox_ShapeSize";
            this.textBox_ShapeSize.Size = new System.Drawing.Size(100, 20);
            this.textBox_ShapeSize.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.HotPink;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(0, 342);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(111, 34);
            this.panel5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Shape Size";
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.Location = new System.Drawing.Point(3, 310);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(104, 28);
            this.button_Rectangle.TabIndex = 7;
            this.button_Rectangle.Text = "Rectangle";
            this.button_Rectangle.UseVisualStyleBackColor = true;
            this.button_Rectangle.Click += new System.EventHandler(this.button_Rectangle_Click);
            // 
            // button_Circle
            // 
            this.button_Circle.Location = new System.Drawing.Point(3, 276);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.Size = new System.Drawing.Size(104, 28);
            this.button_Circle.TabIndex = 6;
            this.button_Circle.Text = "Circle";
            this.button_Circle.UseVisualStyleBackColor = true;
            this.button_Circle.Click += new System.EventHandler(this.button_Circle_Click);
            // 
            // button_Square
            // 
            this.button_Square.Location = new System.Drawing.Point(3, 242);
            this.button_Square.Name = "button_Square";
            this.button_Square.Size = new System.Drawing.Size(104, 28);
            this.button_Square.TabIndex = 5;
            this.button_Square.Text = "Square";
            this.button_Square.UseVisualStyleBackColor = true;
            this.button_Square.Click += new System.EventHandler(this.button_Square_Click);
            // 
            // button_CanvasColor
            // 
            this.button_CanvasColor.Location = new System.Drawing.Point(4, 158);
            this.button_CanvasColor.Name = "button_CanvasColor";
            this.button_CanvasColor.Size = new System.Drawing.Size(104, 38);
            this.button_CanvasColor.TabIndex = 4;
            this.button_CanvasColor.UseVisualStyleBackColor = true;
            this.button_CanvasColor.Click += new System.EventHandler(this.button_CanvasColor_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.HotPink;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(111, 34);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Shapes";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.HotPink;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 34);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Canvas";
            // 
            // button_PenColor
            // 
            this.button_PenColor.Location = new System.Drawing.Point(4, 84);
            this.button_PenColor.Name = "button_PenColor";
            this.button_PenColor.Size = new System.Drawing.Size(104, 28);
            this.button_PenColor.TabIndex = 2;
            this.button_PenColor.UseVisualStyleBackColor = true;
            this.button_PenColor.Click += new System.EventHandler(this.button_PenColor_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(111, 34);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pen";
            // 
            // panel_Canvas
            // 
            this.panel_Canvas.Location = new System.Drawing.Point(111, -2);
            this.panel_Canvas.Name = "panel_Canvas";
            this.panel_Canvas.Size = new System.Drawing.Size(691, 451);
            this.panel_Canvas.TabIndex = 3;
            this.panel_Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Canvas_Paint);
            this.panel_Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Canvas_MouseDown_1);
            this.panel_Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Canvas_MouseMove);
            this.panel_Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_Canvas_MouseUp_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_File});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip_File
            // 
            this.toolStrip_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStrip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.toolStrip_File.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_File.Name = "toolStrip_File";
            this.toolStrip_File.Size = new System.Drawing.Size(38, 22);
            this.toolStrip_File.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // Whiteboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel_Canvas);
            this.Controls.Add(this.panel1);
            this.Name = "Whiteboard";
            this.Text = "Whiteboard";
            this.Load += new System.EventHandler(this.Whiteboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.Button button_Circle;
        private System.Windows.Forms.Button button_Square;
        private System.Windows.Forms.Button button_CanvasColor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_PenColor;
        private System.Windows.Forms.Panel panel_Canvas;
        private System.Windows.Forms.TextBox textBox_ShapeSize;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStrip_File;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    }
}