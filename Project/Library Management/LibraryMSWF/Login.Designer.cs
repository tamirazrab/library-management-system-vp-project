namespace LibraryMSWF {
    partial class Login {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.LErrorInvalidDetailsNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.LSuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.LBtnAdminArea = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBtnSignIn = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.LBtnSignUp = new ReaLTaiizor.Controls.NightButton();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.LTxtUserPassword = new ReaLTaiizor.Controls.NightTextBox();
            this.LTxtUserEmail = new ReaLTaiizor.Controls.NightTextBox();
            this.UErrorNotifyEmptyFields = new ReaLTaiizor.Controls.ForeverNotification();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.UErrorNotifyEmptyFields);
            this.themeForm1.Controls.Add(this.hopePictureBox1);
            this.themeForm1.Controls.Add(this.LErrorInvalidDetailsNotify);
            this.themeForm1.Controls.Add(this.LSuccessNotify);
            this.themeForm1.Controls.Add(this.LBtnAdminArea);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.pictureBox1);
            this.themeForm1.Controls.Add(this.LBtnSignIn);
            this.themeForm1.Controls.Add(this.LBtnSignUp);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel1);
            this.themeForm1.Controls.Add(this.LTxtUserPassword);
            this.themeForm1.Controls.Add(this.LTxtUserEmail);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1056, 657);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            this.themeForm1.Click += new System.EventHandler(this.themeForm1_Click);
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(513, 100);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.Size = new System.Drawing.Size(117, 70);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.TabIndex = 56;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.Click += new System.EventHandler(this.hopePictureBox1_Click);
            // 
            // LErrorInvalidDetailsNotify
            // 
            this.LErrorInvalidDetailsNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LErrorInvalidDetailsNotify.Close = true;
            this.LErrorInvalidDetailsNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LErrorInvalidDetailsNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.LErrorInvalidDetailsNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.LErrorInvalidDetailsNotify.Location = new System.Drawing.Point(97, 212);
            this.LErrorInvalidDetailsNotify.Name = "LErrorInvalidDetailsNotify";
            this.LErrorInvalidDetailsNotify.Size = new System.Drawing.Size(533, 42);
            this.LErrorInvalidDetailsNotify.TabIndex = 42;
            this.LErrorInvalidDetailsNotify.Text = "Password must be greater than 6 cbaracters.";
            this.LErrorInvalidDetailsNotify.Visible = false;
            // 
            // LSuccessNotify
            // 
            this.LSuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.LSuccessNotify.Close = true;
            this.LSuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LSuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.LSuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.LSuccessNotify.Location = new System.Drawing.Point(97, 212);
            this.LSuccessNotify.Name = "LSuccessNotify";
            this.LSuccessNotify.Size = new System.Drawing.Size(435, 42);
            this.LSuccessNotify.TabIndex = 41;
            this.LSuccessNotify.Text = "You\'ve Logged In successfully.";
            this.LSuccessNotify.Visible = false;
            // 
            // LBtnAdminArea
            // 
            this.LBtnAdminArea.BackColor = System.Drawing.Color.Transparent;
            this.LBtnAdminArea.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnAdminArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBtnAdminArea.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LBtnAdminArea.Location = new System.Drawing.Point(97, 558);
            this.LBtnAdminArea.Name = "LBtnAdminArea";
            this.LBtnAdminArea.Rounded = true;
            this.LBtnAdminArea.Size = new System.Drawing.Size(198, 49);
            this.LBtnAdminArea.TabIndex = 40;
            this.LBtnAdminArea.Text = "Admin Area";
            this.LBtnAdminArea.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LBtnAdminArea.Click += new System.EventHandler(this.LBtnAdminArea_Click);
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(93, 535);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(202, 20);
            this.foreverLabel3.TabIndex = 39;
            this.foreverLabel3.Text = "Are you administrator? Go to";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 605);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // LBtnSignIn
            // 
            this.LBtnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.LBtnSignIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBtnSignIn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LBtnSignIn.Location = new System.Drawing.Point(97, 443);
            this.LBtnSignIn.Name = "LBtnSignIn";
            this.LBtnSignIn.Rounded = true;
            this.LBtnSignIn.Size = new System.Drawing.Size(203, 68);
            this.LBtnSignIn.TabIndex = 35;
            this.LBtnSignIn.Text = "Sgin In";
            this.LBtnSignIn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.LBtnSignIn.Click += new System.EventHandler(this.LBtnSignIn_Click);
            // 
            // LBtnSignUp
            // 
            this.LBtnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LBtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.LBtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBtnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LBtnSignUp.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.LBtnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnSignUp.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnSignUp.HoverForeColor = System.Drawing.Color.White;
            this.LBtnSignUp.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.LBtnSignUp.Location = new System.Drawing.Point(322, 443);
            this.LBtnSignUp.MinimumSize = new System.Drawing.Size(144, 47);
            this.LBtnSignUp.Name = "LBtnSignUp";
            this.LBtnSignUp.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnSignUp.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.LBtnSignUp.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.LBtnSignUp.PressedForeColor = System.Drawing.Color.White;
            this.LBtnSignUp.Radius = 5;
            this.LBtnSignUp.Size = new System.Drawing.Size(210, 68);
            this.LBtnSignUp.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.LBtnSignUp.TabIndex = 34;
            this.LBtnSignUp.Text = "Sign Up";
            this.LBtnSignUp.Click += new System.EventHandler(this.LBtnSignUp_Click);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(92, 334);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(112, 30);
            this.foreverLabel4.TabIndex = 33;
            this.foreverLabel4.Text = "Password";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(92, 227);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(67, 30);
            this.foreverLabel2.TabIndex = 31;
            this.foreverLabel2.Text = "Email";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(93, 160);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(282, 40);
            this.foreverLabel1.TabIndex = 30;
            this.foreverLabel1.Text = "Explore and request your favourite books\r\nto be added, after log in.";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("hooge 05_53", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel1.Location = new System.Drawing.Point(84, 95);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(309, 75);
            this.bigLabel1.TabIndex = 29;
            this.bigLabel1.Text = "Login In";
            // 
            // LTxtUserPassword
            // 
            this.LTxtUserPassword.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.LTxtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.LTxtUserPassword.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.LTxtUserPassword.ColorBordersOnEnter = true;
            this.LTxtUserPassword.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.LTxtUserPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.LTxtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.LTxtUserPassword.Image = null;
            this.LTxtUserPassword.Location = new System.Drawing.Point(97, 367);
            this.LTxtUserPassword.MaxLength = 32767;
            this.LTxtUserPassword.Multiline = false;
            this.LTxtUserPassword.Name = "LTxtUserPassword";
            this.LTxtUserPassword.ReadOnly = false;
            this.LTxtUserPassword.ShortcutsEnabled = true;
            this.LTxtUserPassword.ShowBottomBorder = true;
            this.LTxtUserPassword.ShowTopBorder = false;
            this.LTxtUserPassword.Size = new System.Drawing.Size(435, 50);
            this.LTxtUserPassword.TabIndex = 28;
            this.LTxtUserPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.LTxtUserPassword.UseSystemPasswordChar = true;
            this.LTxtUserPassword.Watermark = "";
            this.LTxtUserPassword.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // LTxtUserEmail
            // 
            this.LTxtUserEmail.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.LTxtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.LTxtUserEmail.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.LTxtUserEmail.ColorBordersOnEnter = true;
            this.LTxtUserEmail.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.LTxtUserEmail.Font = new System.Drawing.Font("Roboto", 13F);
            this.LTxtUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.LTxtUserEmail.Image = null;
            this.LTxtUserEmail.Location = new System.Drawing.Point(97, 260);
            this.LTxtUserEmail.MaxLength = 32767;
            this.LTxtUserEmail.Multiline = false;
            this.LTxtUserEmail.Name = "LTxtUserEmail";
            this.LTxtUserEmail.ReadOnly = false;
            this.LTxtUserEmail.ShortcutsEnabled = true;
            this.LTxtUserEmail.ShowBottomBorder = true;
            this.LTxtUserEmail.ShowTopBorder = false;
            this.LTxtUserEmail.Size = new System.Drawing.Size(435, 53);
            this.LTxtUserEmail.TabIndex = 27;
            this.LTxtUserEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.LTxtUserEmail.UseSystemPasswordChar = false;
            this.LTxtUserEmail.Watermark = "";
            this.LTxtUserEmail.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // UErrorNotifyEmptyFields
            // 
            this.UErrorNotifyEmptyFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.UErrorNotifyEmptyFields.Close = true;
            this.UErrorNotifyEmptyFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UErrorNotifyEmptyFields.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.UErrorNotifyEmptyFields.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.UErrorNotifyEmptyFields.Location = new System.Drawing.Point(97, 215);
            this.UErrorNotifyEmptyFields.Name = "UErrorNotifyEmptyFields";
            this.UErrorNotifyEmptyFields.Size = new System.Drawing.Size(435, 42);
            this.UErrorNotifyEmptyFields.TabIndex = 57;
            this.UErrorNotifyEmptyFields.Text = "Please fill the required fields.";
            this.UErrorNotifyEmptyFields.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 657);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ForeverButtonSticky LBtnSignIn;
        private ReaLTaiizor.Controls.NightButton LBtnSignUp;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightTextBox LTxtUserPassword;
        private ReaLTaiizor.Controls.NightTextBox LTxtUserEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverButtonSticky LBtnAdminArea;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverNotification LSuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification LErrorInvalidDetailsNotify;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.ForeverNotification UErrorNotifyEmptyFields;
    }
}