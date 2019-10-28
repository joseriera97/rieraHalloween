namespace sakila
{
    partial class DetailFilm
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
            this.filmAnimation = new System.Windows.Forms.Label();
            this.filmLanguage = new System.Windows.Forms.Label();
            this.filmTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filmDescription = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmAnimation
            // 
            this.filmAnimation.AutoSize = true;
            this.filmAnimation.Location = new System.Drawing.Point(72, 113);
            this.filmAnimation.Name = "filmAnimation";
            this.filmAnimation.Size = new System.Drawing.Size(53, 13);
            this.filmAnimation.TabIndex = 1;
            this.filmAnimation.Text = "Animation";
            // 
            // filmLanguage
            // 
            this.filmLanguage.AutoSize = true;
            this.filmLanguage.BackColor = System.Drawing.SystemColors.Highlight;
            this.filmLanguage.Location = new System.Drawing.Point(157, 113);
            this.filmLanguage.Name = "filmLanguage";
            this.filmLanguage.Size = new System.Drawing.Size(10, 13);
            this.filmLanguage.TabIndex = 2;
            this.filmLanguage.Text = ".";
            // 
            // filmTitle
            // 
            this.filmTitle.AutoSize = true;
            this.filmTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filmTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.filmTitle.Location = new System.Drawing.Point(106, 58);
            this.filmTitle.Name = "filmTitle";
            this.filmTitle.Size = new System.Drawing.Size(51, 16);
            this.filmTitle.TabIndex = 3;
            this.filmTitle.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sakila.Properties.Resources.MV5BMTY2Njk3MTAzM15BMl5BanBnXkFtZTgwMTY5Mzk4NjE___V1_SY1000_CR0_0_669_1000_AL_;
            this.pictureBox1.Location = new System.Drawing.Point(253, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // filmDescription
            // 
            this.filmDescription.Location = new System.Drawing.Point(12, 164);
            this.filmDescription.Name = "filmDescription";
            this.filmDescription.Size = new System.Drawing.Size(200, 100);
            this.filmDescription.TabIndex = 5;
            this.filmDescription.TabStop = false;
            this.filmDescription.Text = "groupBox1";
            // 
            // DetailFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 450);
            this.Controls.Add(this.filmDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filmTitle);
            this.Controls.Add(this.filmLanguage);
            this.Controls.Add(this.filmAnimation);
            this.Name = "DetailFilm";
            this.Text = "DetailFilm";
            this.Load += new System.EventHandler(this.DetailFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label filmAnimation;
        private System.Windows.Forms.Label filmLanguage;
        private System.Windows.Forms.Label filmTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox filmDescription;
    }
}