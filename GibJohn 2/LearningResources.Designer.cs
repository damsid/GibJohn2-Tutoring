
namespace GibJohn_2
{
    partial class LearningResources
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
            this.button_Learning = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Learning
            // 
            this.button_Learning.BackColor = System.Drawing.Color.Transparent;
            this.button_Learning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Learning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Learning.FlatAppearance.BorderSize = 0;
            this.button_Learning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Learning.ForeColor = System.Drawing.Color.Transparent;
            this.button_Learning.Location = new System.Drawing.Point(613, 132);
            this.button_Learning.Name = "button_Learning";
            this.button_Learning.Size = new System.Drawing.Size(193, 173);
            this.button_Learning.TabIndex = 3;
            this.button_Learning.UseVisualStyleBackColor = false;
            this.button_Learning.Click += new System.EventHandler(this.button_Learning_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GibJohn_2.Properties.Resources.reading_material_2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(315, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 173);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::GibJohn_2.Properties.Resources.reading_material;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(35, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 165);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LearningResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GibJohn_2.Properties.Resources.FINISHED_LEARNING_RESOURCES;
            this.ClientSize = new System.Drawing.Size(818, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Learning);
            this.Name = "LearningResources";
            this.Text = "Learning Resources";
            this.Load += new System.EventHandler(this.LearningResources_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Learning;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}