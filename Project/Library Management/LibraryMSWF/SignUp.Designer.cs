namespace LibraryMSWF {
    partial class SignUp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.sErrorInvalidDetailsNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.sSuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.sErrorEmptyNotification = new ReaLTaiizor.Controls.ForeverNotification();
            this.sErrorPasswordNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.sTxtUserAdno = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.sBtnSignUp = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.sBtnSignIn = new ReaLTaiizor.Controls.NightButton();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.sTxtUserPassword = new ReaLTaiizor.Controls.NightTextBox();
            this.sTxtUserEmail = new ReaLTaiizor.Controls.NightTextBox();
            this.sTxtUserName = new ReaLTaiizor.Controls.NightTextBox();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.sErrorInvalidDetailsNotify);
            this.themeForm1.Controls.Add(this.sSuccessNotify);
            this.themeForm1.Controls.Add(this.sErrorEmptyNotification);
            this.themeForm1.Controls.Add(this.sErrorPasswordNotify);
            this.themeForm1.Controls.Add(this.sTxtUserAdno);
            this.themeForm1.Controls.Add(this.foreverLabel5);
            this.themeForm1.Controls.Add(this.sBtnSignUp);
            this.themeForm1.Controls.Add(this.sBtnSignIn);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.pictureBox1);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel1);
            this.themeForm1.Controls.Add(this.sTxtUserPassword);
            this.themeForm1.Controls.Add(this.sTxtUserEmail);
            this.themeForm1.Controls.Add(this.sTxtUserName);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.MinimumSize = new System.Drawing.Size(126, 50);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1072, 696);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            this.themeForm1.Click += new System.EventHandler(this.themeForm1_Click);
            // 
            // sErrorInvalidDetailsNotify
            // 
            this.sErrorInvalidDetailsNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.sErrorInvalidDetailsNotify.Close = true;
            this.sErrorInvalidDetailsNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sErrorInvalidDetailsNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.sErrorInvalidDetailsNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.sErrorInvalidDetailsNotify.Location = new System.Drawing.Point(81, 122);
            this.sErrorInvalidDetailsNotify.Name = "sErrorInvalidDetailsNotify";
            this.sErrorInvalidDetailsNotify.Size = new System.Drawing.Size(475, 42);
            this.sErrorInvalidDetailsNotify.TabIndex = 29;
            this.sErrorInvalidDetailsNotify.Text = "Invalid Email or Password. Please try again.";
            this.sErrorInvalidDetailsNotify.Visible = false;
            // 
            // sSuccessNotify
            // 
            this.sSuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.sSuccessNotify.Close = true;
            this.sSuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sSuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.sSuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.sSuccessNotify.Location = new System.Drawing.Point(81, 219);
            this.sSuccessNotify.Name = "sSuccessNotify";
            this.sSuccessNotify.Size = new System.Drawing.Size(435, 42);
            this.sSuccessNotify.TabIndex = 28;
            this.sSuccessNotify.Text = "You\'ve signed up, you can now sign in.";
            this.sSuccessNotify.Visible = false;
            // 
            // sErrorEmptyNotification
            // 
            this.sErrorEmptyNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.sErrorEmptyNotification.Close = true;
            this.sErrorEmptyNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sErrorEmptyNotification.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.sErrorEmptyNotification.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.sErrorEmptyNotification.Location = new System.Drawing.Point(19, 122);
            this.sErrorEmptyNotification.Name = "sErrorEmptyNotification";
            this.sErrorEmptyNotification.Size = new System.Drawing.Size(588, 42);
            this.sErrorEmptyNotification.TabIndex = 27;
            this.sErrorEmptyNotification.Text = "Please make sure you fill all the fields, all are required.";
            this.sErrorEmptyNotification.Visible = false;
            // 
            // sErrorPasswordNotify
            // 
            this.sErrorPasswordNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.sErrorPasswordNotify.Close = true;
            this.sErrorPasswordNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sErrorPasswordNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.sErrorPasswordNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.sErrorPasswordNotify.Location = new System.Drawing.Point(19, 122);
            this.sErrorPasswordNotify.Name = "sErrorPasswordNotify";
            this.sErrorPasswordNotify.Size = new System.Drawing.Size(854, 42);
            this.sErrorPasswordNotify.TabIndex = 26;
            this.sErrorPasswordNotify.Text = "Email or password are incorrect, make sure your password has more than 6 characte" +
    "rs.";
            this.sErrorPasswordNotify.Visible = false;
            // 
            // sTxtUserAdno
            // 
            this.sTxtUserAdno.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.sTxtUserAdno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserAdno.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserAdno.ColorBordersOnEnter = true;
            this.sTxtUserAdno.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.sTxtUserAdno.Font = new System.Drawing.Font("Roboto", 12F);
            this.sTxtUserAdno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.sTxtUserAdno.Image = null;
            this.sTxtUserAdno.Location = new System.Drawing.Point(352, 367);
            this.sTxtUserAdno.MaxLength = 25;
            this.sTxtUserAdno.Multiline = false;
            this.sTxtUserAdno.Name = "sTxtUserAdno";
            this.sTxtUserAdno.ReadOnly = false;
            this.sTxtUserAdno.ShortcutsEnabled = true;
            this.sTxtUserAdno.ShowBottomBorder = true;
            this.sTxtUserAdno.ShowTopBorder = false;
            this.sTxtUserAdno.Size = new System.Drawing.Size(164, 52);
            this.sTxtUserAdno.TabIndex = 25;
            this.sTxtUserAdno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sTxtUserAdno.UseSystemPasswordChar = false;
            this.sTxtUserAdno.Watermark = "";
            this.sTxtUserAdno.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel5.Location = new System.Drawing.Point(347, 334);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(159, 30);
            this.foreverLabel5.TabIndex = 24;
            this.foreverLabel5.Text = "Admission No";
            // 
            // sBtnSignUp
            // 
            this.sBtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.sBtnSignUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.sBtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sBtnSignUp.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.sBtnSignUp.Location = new System.Drawing.Point(81, 555);
            this.sBtnSignUp.Name = "sBtnSignUp";
            this.sBtnSignUp.Rounded = true;
            this.sBtnSignUp.Size = new System.Drawing.Size(138, 68);
            this.sBtnSignUp.TabIndex = 23;
            this.sBtnSignUp.Text = "Sign Up";
            this.sBtnSignUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.sBtnSignUp.Click += new System.EventHandler(this.sBtnSignUp_Click);
            // 
            // sBtnSignIn
            // 
            this.sBtnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sBtnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.sBtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sBtnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sBtnSignIn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.sBtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.sBtnSignIn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.sBtnSignIn.HoverForeColor = System.Drawing.Color.White;
            this.sBtnSignIn.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.sBtnSignIn.Location = new System.Drawing.Point(352, 555);
            this.sBtnSignIn.MinimumSize = new System.Drawing.Size(144, 47);
            this.sBtnSignIn.Name = "sBtnSignIn";
            this.sBtnSignIn.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.sBtnSignIn.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.sBtnSignIn.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.sBtnSignIn.PressedForeColor = System.Drawing.Color.White;
            this.sBtnSignIn.Radius = 5;
            this.sBtnSignIn.Size = new System.Drawing.Size(164, 68);
            this.sBtnSignIn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.sBtnSignIn.TabIndex = 22;
            this.sBtnSignIn.Text = "Sign In";
            this.sBtnSignIn.Click += new System.EventHandler(this.sBtnSignIn_Click);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(76, 444);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(112, 30);
            this.foreverLabel4.TabIndex = 17;
            this.foreverLabel4.Text = "Password";
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(76, 334);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(118, 30);
            this.foreverLabel3.TabIndex = 16;
            this.foreverLabel3.Text = "Full Name";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(76, 234);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(67, 30);
            this.foreverLabel2.TabIndex = 15;
            this.foreverLabel2.Text = "Email";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 645);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(77, 167);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(286, 40);
            this.foreverLabel1.TabIndex = 13;
            this.foreverLabel1.Text = "Explore and request your favourite books \r\nto be added, after signing up.";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("hooge 05_53", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel1.Location = new System.Drawing.Point(68, 102);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(301, 75);
            this.bigLabel1.TabIndex = 12;
            this.bigLabel1.Text = "Sign Up";
            this.bigLabel1.Click += new System.EventHandler(this.bigLabel1_Click);
            // 
            // sTxtUserPassword
            // 
            this.sTxtUserPassword.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.sTxtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserPassword.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserPassword.ColorBordersOnEnter = true;
            this.sTxtUserPassword.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.sTxtUserPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.sTxtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.sTxtUserPassword.Image = null;
            this.sTxtUserPassword.Location = new System.Drawing.Point(81, 477);
            this.sTxtUserPassword.MaxLength = 32767;
            this.sTxtUserPassword.Multiline = false;
            this.sTxtUserPassword.Name = "sTxtUserPassword";
            this.sTxtUserPassword.ReadOnly = false;
            this.sTxtUserPassword.ShortcutsEnabled = true;
            this.sTxtUserPassword.ShowBottomBorder = true;
            this.sTxtUserPassword.ShowTopBorder = false;
            this.sTxtUserPassword.Size = new System.Drawing.Size(247, 50);
            this.sTxtUserPassword.TabIndex = 7;
            this.sTxtUserPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sTxtUserPassword.UseSystemPasswordChar = true;
            this.sTxtUserPassword.Watermark = "";
            this.sTxtUserPassword.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // sTxtUserEmail
            // 
            this.sTxtUserEmail.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.sTxtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserEmail.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserEmail.ColorBordersOnEnter = true;
            this.sTxtUserEmail.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.sTxtUserEmail.Font = new System.Drawing.Font("Roboto", 13F);
            this.sTxtUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.sTxtUserEmail.Image = null;
            this.sTxtUserEmail.Location = new System.Drawing.Point(81, 267);
            this.sTxtUserEmail.MaxLength = 32767;
            this.sTxtUserEmail.Multiline = false;
            this.sTxtUserEmail.Name = "sTxtUserEmail";
            this.sTxtUserEmail.ReadOnly = false;
            this.sTxtUserEmail.ShortcutsEnabled = true;
            this.sTxtUserEmail.ShowBottomBorder = true;
            this.sTxtUserEmail.ShowTopBorder = false;
            this.sTxtUserEmail.Size = new System.Drawing.Size(435, 53);
            this.sTxtUserEmail.TabIndex = 6;
            this.sTxtUserEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sTxtUserEmail.UseSystemPasswordChar = false;
            this.sTxtUserEmail.Watermark = "";
            this.sTxtUserEmail.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // sTxtUserName
            // 
            this.sTxtUserName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.sTxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.sTxtUserName.ColorBordersOnEnter = true;
            this.sTxtUserName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.sTxtUserName.Font = new System.Drawing.Font("Roboto", 12F);
            this.sTxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.sTxtUserName.Image = null;
            this.sTxtUserName.Location = new System.Drawing.Point(81, 367);
            this.sTxtUserName.MaxLength = 32767;
            this.sTxtUserName.Multiline = false;
            this.sTxtUserName.Name = "sTxtUserName";
            this.sTxtUserName.ReadOnly = false;
            this.sTxtUserName.ShortcutsEnabled = true;
            this.sTxtUserName.ShowBottomBorder = true;
            this.sTxtUserName.ShowTopBorder = false;
            this.sTxtUserName.Size = new System.Drawing.Size(247, 52);
            this.sTxtUserName.TabIndex = 5;
            this.sTxtUserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.sTxtUserName.UseSystemPasswordChar = false;
            this.sTxtUserName.Watermark = "";
            this.sTxtUserName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 696);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.NightTextBox sTxtUserName;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightTextBox sTxtUserPassword;
        private ReaLTaiizor.Controls.NightTextBox sTxtUserEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.NightButton sBtnSignIn;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverButtonSticky sBtnSignUp;
        private ReaLTaiizor.Controls.NightTextBox sTxtUserAdno;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverNotification sErrorPasswordNotify;
        private ReaLTaiizor.Controls.ForeverNotification sErrorEmptyNotification;
        private ReaLTaiizor.Controls.ForeverNotification sSuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification sErrorInvalidDetailsNotify;
    }
}