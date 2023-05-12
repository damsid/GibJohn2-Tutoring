
namespace GibJohn_2
{
    partial class Form1
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
            this.button3 = new System.Windows.Forms.Button();
            this.button_Collabtools = new System.Windows.Forms.Button();
            this.button_Games = new System.Windows.Forms.Button();
            this.button_Learning = new System.Windows.Forms.Button();
            this.panel_NewForm = new System.Windows.Forms.Panel();
            this.panel_NewForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::GibJohn_2.Properties.Resources.Capture4;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 90);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button_Collabtools
            // 
            this.button_Collabtools.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Collabtools.BackgroundImage = global::GibJohn_2.Properties.Resources.Capture2;
            this.button_Collabtools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Collabtools.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Collabtools.FlatAppearance.BorderSize = 0;
            this.button_Collabtools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Collabtools.ForeColor = System.Drawing.Color.Transparent;
            this.button_Collabtools.Location = new System.Drawing.Point(629, 145);
            this.button_Collabtools.Name = "button_Collabtools";
            this.button_Collabtools.Size = new System.Drawing.Size(161, 156);
            this.button_Collabtools.TabIndex = 0;
            this.button_Collabtools.UseVisualStyleBackColor = false;
            this.button_Collabtools.Click += new System.EventHandler(this.button_Collabtools_Click);
            // 
            // button_Games
            // 
            this.button_Games.BackColor = System.Drawing.Color.Transparent;
            this.button_Games.BackgroundImage = global::GibJohn_2.Properties.Resources.Capture;
            this.button_Games.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Games.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Games.FlatAppearance.BorderSize = 0;
            this.button_Games.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Games.ForeColor = System.Drawing.Color.Transparent;
            this.button_Games.Location = new System.Drawing.Point(326, 145);
            this.button_Games.Name = "button_Games";
            this.button_Games.Size = new System.Drawing.Size(161, 156);
            this.button_Games.TabIndex = 1;
            this.button_Games.UseVisualStyleBackColor = false;
            this.button_Games.Click += new System.EventHandler(this.button_Games_Click);
            // 
            // button_Learning
            // 
            this.button_Learning.BackColor = System.Drawing.Color.Transparent;
            this.button_Learning.BackgroundImage = global::GibJohn_2.Properties.Resources.Capture3;
            this.button_Learning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Learning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Learning.FlatAppearance.BorderSize = 0;
            this.button_Learning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Learning.ForeColor = System.Drawing.Color.Transparent;
            this.button_Learning.Location = new System.Drawing.Point(41, 144);
            this.button_Learning.Name = "button_Learning";
            this.button_Learning.Size = new System.Drawing.Size(161, 156);
            this.button_Learning.TabIndex = 2;
            this.button_Learning.UseVisualStyleBackColor = false;
            this.button_Learning.Click += new System.EventHandler(this.button_Learning_Click);
            // 
            // panel_NewForm
            // 
            this.panel_NewForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_NewForm.Controls.Add(this.button_Learning);
            this.panel_NewForm.Controls.Add(this.button_Games);
            this.panel_NewForm.Controls.Add(this.button_Collabtools);
            this.panel_NewForm.Location = new System.Drawing.Point(1, -3);
            this.panel_NewForm.Name = "panel_NewForm";
            this.panel_NewForm.Size = new System.Drawing.Size(816, 453);
            this.panel_NewForm.TabIndex = 4;
            this.panel_NewForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_NewForm_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GibJohn_2.Properties.Resources.FINISHED_STUDENT_DASHBOARD;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.panel_NewForm);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "GibJohn Tutoring";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_NewForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_Collabtools;
        private System.Windows.Forms.Button button_Games;
        private System.Windows.Forms.Button button_Learning;
        private System.Windows.Forms.Panel panel_NewForm;
    }
}

