namespace LibraryMSWF {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.HBtnAdminArea = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.HBrnClose = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.HBtnSignUp = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.HBtnLogin = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.HBtnAdminArea);
            this.themeForm1.Controls.Add(this.HBrnClose);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.HBtnSignUp);
            this.themeForm1.Controls.Add(this.HBtnLogin);
            this.themeForm1.Controls.Add(this.hopePictureBox1);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel4);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.MinimumSize = new System.Drawing.Size(126, 50);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1007, 639);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            this.themeForm1.Click += new System.EventHandler(this.themeForm1_Click);
            // 
            // HBtnAdminArea
            // 
            this.HBtnAdminArea.BackColor = System.Drawing.Color.Transparent;
            this.HBtnAdminArea.BaseColor = System.Drawing.Color.Crimson;
            this.HBtnAdminArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HBtnAdminArea.Font = new System.Drawing.Font("Microsoft YaHei Light", 20F, System.Drawing.FontStyle.Bold);
            this.HBtnAdminArea.Location = new System.Drawing.Point(301, 485);
            this.HBtnAdminArea.Name = "HBtnAdminArea";
            this.HBtnAdminArea.Rounded = false;
            this.HBtnAdminArea.Size = new System.Drawing.Size(233, 60);
            this.HBtnAdminArea.TabIndex = 61;
            this.HBtnAdminArea.Text = "Admin Area";
            this.HBtnAdminArea.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.HBtnAdminArea.Click += new System.EventHandler(this.HBtnAdminArea_Click_1);
            // 
            // HBrnClose
            // 
            this.HBrnClose.BackColor = System.Drawing.Color.Transparent;
            this.HBrnClose.BaseColor = System.Drawing.Color.SlateGray;
            this.HBrnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HBrnClose.Font = new System.Drawing.Font("monofur for Powerline", 20F, System.Drawing.FontStyle.Bold);
            this.HBrnClose.ForeColor = System.Drawing.Color.Black;
            this.HBrnClose.Location = new System.Drawing.Point(936, 0);
            this.HBrnClose.Name = "HBrnClose";
            this.HBrnClose.Rounded = false;
            this.HBrnClose.Size = new System.Drawing.Size(71, 57);
            this.HBrnClose.TabIndex = 60;
            this.HBrnClose.Text = "X";
            this.HBrnClose.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.HBrnClose.Click += new System.EventHandler(this.foreverButtonSticky1_Click);
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(318, 446);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(199, 36);
            this.foreverLabel3.TabIndex = 59;
            this.foreverLabel3.Text = "Administrator?";
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(413, 272);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(262, 36);
            this.foreverLabel4.TabIndex = 58;
            this.foreverLabel4.Text = "Already a member?";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 21F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(196, 272);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(113, 36);
            this.foreverLabel2.TabIndex = 57;
            this.foreverLabel2.Text = "Join Us!";
            // 
            // HBtnSignUp
            // 
            this.HBtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.HBtnSignUp.BaseColor = System.Drawing.Color.Chocolate;
            this.HBtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HBtnSignUp.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.HBtnSignUp.Location = new System.Drawing.Point(149, 311);
            this.HBtnSignUp.Name = "HBtnSignUp";
            this.HBtnSignUp.Rounded = false;
            this.HBtnSignUp.Size = new System.Drawing.Size(160, 60);
            this.HBtnSignUp.TabIndex = 55;
            this.HBtnSignUp.Text = "Sign Up";
            this.HBtnSignUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.HBtnSignUp.Click += new System.EventHandler(this.HBtnLogin_Click);
            // 
            // HBtnLogin
            // 
            this.HBtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.HBtnLogin.BaseColor = System.Drawing.Color.Chocolate;
            this.HBtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HBtnLogin.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Bold);
            this.HBtnLogin.Location = new System.Drawing.Point(516, 311);
            this.HBtnLogin.Name = "HBtnLogin";
            this.HBtnLogin.Rounded = false;
            this.HBtnLogin.Size = new System.Drawing.Size(159, 60);
            this.HBtnLogin.TabIndex = 54;
            this.HBtnLogin.Text = "Log In";
            this.HBtnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.HBtnLogin.Click += new System.EventHandler(this.HBtnSignUp_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(697, 58);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.Size = new System.Drawing.Size(310, 333);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.TabIndex = 51;
            this.hopePictureBox1.TabStop = false;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Matura MT Script Capitals", 39F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.foreverLabel1.Location = new System.Drawing.Point(52, 146);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(221, 70);
            this.foreverLabel1.TabIndex = 50;
            this.foreverLabel1.Text = "Library";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("hooge 05_55", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel4.Location = new System.Drawing.Point(33, 87);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(276, 75);
            this.bigLabel4.TabIndex = 48;
            this.bigLabel4.Text = "Newman";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 639);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Home";
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverButtonSticky HBtnSignUp;
        private ReaLTaiizor.Controls.ForeverButtonSticky HBtnLogin;
        private ReaLTaiizor.Controls.ForeverButtonSticky HBrnClose;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverButtonSticky HBtnAdminArea;
    }
}