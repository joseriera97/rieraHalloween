namespace sakila
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlMenu = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.tabFilms = new System.Windows.Forms.TabPage();
            this.tabStaff = new System.Windows.Forms.TabPage();
            this.labelSearch = new System.Windows.Forms.Label();
            this.FilmsBox = new System.Windows.Forms.TextBox();
            this.FilmsFind = new System.Windows.Forms.Button();
            this.FilmsCheck = new System.Windows.Forms.CheckBox();
            this.FilmsList = new System.Windows.Forms.ListBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLog = new System.Windows.Forms.Button();
            this.errorSesion = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControlMenu.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabFilms.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAKILA FILMS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControlMenu
            // 
            this.tabControlMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMenu.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlMenu.Controls.Add(this.tabLogin);
            this.tabControlMenu.Controls.Add(this.tabFilms);
            this.tabControlMenu.Controls.Add(this.tabStaff);
            this.tabControlMenu.Location = new System.Drawing.Point(12, 98);
            this.tabControlMenu.Multiline = true;
            this.tabControlMenu.Name = "tabControlMenu";
            this.tabControlMenu.SelectedIndex = 0;
            this.tabControlMenu.Size = new System.Drawing.Size(776, 320);
            this.tabControlMenu.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.errorSesion);
            this.tabLogin.Controls.Add(this.buttonLog);
            this.tabLogin.Controls.Add(this.textPassword);
            this.tabLogin.Controls.Add(this.textUser);
            this.tabLogin.Controls.Add(this.labelPassword);
            this.tabLogin.Controls.Add(this.labelUser);
            this.tabLogin.Location = new System.Drawing.Point(136, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(636, 312);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            this.tabLogin.UseVisualStyleBackColor = true;
            this.tabLogin.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabFilms
            // 
            this.tabFilms.Controls.Add(this.FilmsList);
            this.tabFilms.Controls.Add(this.FilmsCheck);
            this.tabFilms.Controls.Add(this.FilmsFind);
            this.tabFilms.Controls.Add(this.FilmsBox);
            this.tabFilms.Controls.Add(this.labelSearch);
            this.tabFilms.Location = new System.Drawing.Point(136, 4);
            this.tabFilms.Name = "tabFilms";
            this.tabFilms.Padding = new System.Windows.Forms.Padding(3);
            this.tabFilms.Size = new System.Drawing.Size(636, 312);
            this.tabFilms.TabIndex = 1;
            this.tabFilms.Text = "Films";
            this.tabFilms.UseVisualStyleBackColor = true;
            // 
            // tabStaff
            // 
            this.tabStaff.BackgroundImage = global::sakila.Properties.Resources._71QIwIAtQGL__SX425_;
            this.tabStaff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabStaff.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabStaff.Location = new System.Drawing.Point(136, 4);
            this.tabStaff.Name = "tabStaff";
            this.tabStaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabStaff.Size = new System.Drawing.Size(636, 312);
            this.tabStaff.TabIndex = 2;
            this.tabStaff.Text = "Staff";
            this.tabStaff.UseVisualStyleBackColor = true;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(112, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search: ";
            // 
            // FilmsBox
            // 
            this.FilmsBox.Location = new System.Drawing.Point(166, 24);
            this.FilmsBox.Name = "FilmsBox";
            this.FilmsBox.Size = new System.Drawing.Size(261, 20);
            this.FilmsBox.TabIndex = 1;
            // 
            // FilmsFind
            // 
            this.FilmsFind.Location = new System.Drawing.Point(448, 24);
            this.FilmsFind.Name = "FilmsFind";
            this.FilmsFind.Size = new System.Drawing.Size(75, 23);
            this.FilmsFind.TabIndex = 3;
            this.FilmsFind.Text = "Find";
            this.FilmsFind.UseVisualStyleBackColor = true;
            this.FilmsFind.Click += new System.EventHandler(this.FilmsFind_Click);
            // 
            // FilmsCheck
            // 
            this.FilmsCheck.AutoSize = true;
            this.FilmsCheck.Location = new System.Drawing.Point(410, 53);
            this.FilmsCheck.Name = "FilmsCheck";
            this.FilmsCheck.Size = new System.Drawing.Size(113, 17);
            this.FilmsCheck.TabIndex = 4;
            this.FilmsCheck.Text = "Match whole word";
            this.FilmsCheck.UseVisualStyleBackColor = true;
            // 
            // FilmsList
            // 
            this.FilmsList.FormattingEnabled = true;
            this.FilmsList.Location = new System.Drawing.Point(115, 85);
            this.FilmsList.Name = "FilmsList";
            this.FilmsList.Size = new System.Drawing.Size(408, 147);
            this.FilmsList.TabIndex = 5;
            this.FilmsList.SelectedIndexChanged += new System.EventHandler(this.FilmsList_SelectedIndexChanged);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(125, 58);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(68, 29);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(125, 105);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(128, 29);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.Location = new System.Drawing.Point(263, 58);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(179, 31);
            this.textUser.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPassword.Location = new System.Drawing.Point(264, 105);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(179, 31);
            this.textPassword.TabIndex = 3;
            // 
            // buttonLog
            // 
            this.buttonLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLog.Location = new System.Drawing.Point(264, 167);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(178, 38);
            this.buttonLog.TabIndex = 4;
            this.buttonLog.Text = "Log In";
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // errorSesion
            // 
            this.errorSesion.AutoSize = true;
            this.errorSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorSesion.ForeColor = System.Drawing.Color.DarkRed;
            this.errorSesion.Location = new System.Drawing.Point(277, 234);
            this.errorSesion.Name = "errorSesion";
            this.errorSesion.Size = new System.Drawing.Size(154, 20);
            this.errorSesion.TabIndex = 5;
            this.errorSesion.Text = "Error al iniciar sesión";
            this.errorSesion.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sakila";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControlMenu.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabFilms.ResumeLayout(false);
            this.tabFilms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlMenu;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabFilms;
        private System.Windows.Forms.TabPage tabStaff;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.ListBox FilmsList;
        private System.Windows.Forms.CheckBox FilmsCheck;
        private System.Windows.Forms.Button FilmsFind;
        private System.Windows.Forms.TextBox FilmsBox;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label errorSesion;
    }
}

