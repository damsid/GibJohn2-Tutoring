
namespace GibJohn_2
{
    partial class MathGameOptions
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Easy = new System.Windows.Forms.Button();
            this.button_Medium = new System.Windows.Forms.Button();
            this.button_Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please choose a difficulty setting...";
            // 
            // button_Easy
            // 
            this.button_Easy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Easy.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Easy.ForeColor = System.Drawing.Color.Black;
            this.button_Easy.Location = new System.Drawing.Point(31, 110);
            this.button_Easy.Name = "button_Easy";
            this.button_Easy.Size = new System.Drawing.Size(139, 43);
            this.button_Easy.TabIndex = 8;
            this.button_Easy.Text = "Easy";
            this.button_Easy.UseVisualStyleBackColor = false;
            this.button_Easy.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Medium
            // 
            this.button_Medium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Medium.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Medium.ForeColor = System.Drawing.Color.Black;
            this.button_Medium.Location = new System.Drawing.Point(254, 110);
            this.button_Medium.Name = "button_Medium";
            this.button_Medium.Size = new System.Drawing.Size(139, 43);
            this.button_Medium.TabIndex = 9;
            this.button_Medium.Text = "Medium";
            this.button_Medium.UseVisualStyleBackColor = false;
            this.button_Medium.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_Hard
            // 
            this.button_Hard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Hard.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Hard.ForeColor = System.Drawing.Color.Black;
            this.button_Hard.Location = new System.Drawing.Point(463, 110);
            this.button_Hard.Name = "button_Hard";
            this.button_Hard.Size = new System.Drawing.Size(139, 43);
            this.button_Hard.TabIndex = 10;
            this.button_Hard.Text = "Hard";
            this.button_Hard.UseVisualStyleBackColor = false;
            this.button_Hard.Click += new System.EventHandler(this.button3_Click);
            // 
            // MathGameOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GibJohn_2.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(631, 230);
            this.Controls.Add(this.button_Hard);
            this.Controls.Add(this.button_Medium);
            this.Controls.Add(this.button_Easy);
            this.Controls.Add(this.label1);
            this.Name = "MathGameOptions";
            this.Text = "MathGameOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Easy;
        private System.Windows.Forms.Button button_Medium;
        private System.Windows.Forms.Button button_Hard;
    }
}