
namespace GibJohn_2
{
    partial class GameForm
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
            this.button_Science = new System.Windows.Forms.Button();
            this.button_Maths = new System.Windows.Forms.Button();
            this.button_English = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Science
            // 
            this.button_Science.BackColor = System.Drawing.Color.Transparent;
            this.button_Science.BackgroundImage = global::GibJohn_2.Properties.Resources.science;
            this.button_Science.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Science.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Science.FlatAppearance.BorderSize = 0;
            this.button_Science.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Science.ForeColor = System.Drawing.Color.Transparent;
            this.button_Science.Location = new System.Drawing.Point(609, 136);
            this.button_Science.Name = "button_Science";
            this.button_Science.Size = new System.Drawing.Size(189, 167);
            this.button_Science.TabIndex = 8;
            this.button_Science.UseVisualStyleBackColor = false;
            this.button_Science.Click += new System.EventHandler(this.button_Science_Click);
            // 
            // button_Maths
            // 
            this.button_Maths.BackColor = System.Drawing.Color.Transparent;
            this.button_Maths.BackgroundImage = global::GibJohn_2.Properties.Resources.math;
            this.button_Maths.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Maths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Maths.FlatAppearance.BorderSize = 0;
            this.button_Maths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maths.ForeColor = System.Drawing.Color.Transparent;
            this.button_Maths.Location = new System.Drawing.Point(315, 136);
            this.button_Maths.Name = "button_Maths";
            this.button_Maths.Size = new System.Drawing.Size(189, 167);
            this.button_Maths.TabIndex = 7;
            this.button_Maths.UseVisualStyleBackColor = false;
            this.button_Maths.Click += new System.EventHandler(this.button_Maths_Click);
            // 
            // button_English
            // 
            this.button_English.BackColor = System.Drawing.Color.Transparent;
            this.button_English.BackgroundImage = global::GibJohn_2.Properties.Resources.english;
            this.button_English.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_English.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_English.FlatAppearance.BorderSize = 0;
            this.button_English.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_English.ForeColor = System.Drawing.Color.Transparent;
            this.button_English.Location = new System.Drawing.Point(34, 139);
            this.button_English.Name = "button_English";
            this.button_English.Size = new System.Drawing.Size(172, 167);
            this.button_English.TabIndex = 6;
            this.button_English.UseVisualStyleBackColor = false;
            this.button_English.Click += new System.EventHandler(this.button_English_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GibJohn_2.Properties.Resources.FINISHED_GAMES_DASHBOARD;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.button_Science);
            this.Controls.Add(this.button_Maths);
            this.Controls.Add(this.button_English);
            this.Name = "GameForm";
            this.Text = "Interactive Games";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Science;
        private System.Windows.Forms.Button button_Maths;
        private System.Windows.Forms.Button button_English;
    }
}