namespace LibraryMSWF {
    partial class AdminSignUp {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSignUp));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.ASuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.AErrorEmptyNotification = new ReaLTaiizor.Controls.ForeverNotification();
            this.ABtnSignUp = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.ABtnSignIn = new ReaLTaiizor.Controls.NightButton();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.ATxtUserPassword = new ReaLTaiizor.Controls.NightTextBox();
            this.ATxtUserEmail = new ReaLTaiizor.Controls.NightTextBox();
            this.ATxtInvitedBy = new ReaLTaiizor.Controls.NightTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AErrorPasswordNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.AErrorPasswordNotify);
            this.themeForm1.Controls.Add(this.pictureBox1);
            this.themeForm1.Controls.Add(this.ASuccessNotify);
            this.themeForm1.Controls.Add(this.AErrorEmptyNotification);
            this.themeForm1.Controls.Add(this.ABtnSignUp);
            this.themeForm1.Controls.Add(this.ABtnSignIn);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel1);
            this.themeForm1.Controls.Add(this.ATxtUserPassword);
            this.themeForm1.Controls.Add(this.ATxtUserEmail);
            this.themeForm1.Controls.Add(this.ATxtInvitedBy);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.MinimumSize = new System.Drawing.Size(126, 50);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1024, 579);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            // 
            // ASuccessNotify
            // 
            this.ASuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ASuccessNotify.Close = true;
            this.ASuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ASuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.ASuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.ASuccessNotify.Location = new System.Drawing.Point(69, 168);
            this.ASuccessNotify.Name = "ASuccessNotify";
            this.ASuccessNotify.Size = new System.Drawing.Size(435, 42);
            this.ASuccessNotify.TabIndex = 44;
            this.ASuccessNotify.Text = "You\'ve signed up, you can now sign in.";
            this.ASuccessNotify.Visible = false;
            // 
            // AErrorEmptyNotification
            // 
            this.AErrorEmptyNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AErrorEmptyNotification.Close = true;
            this.AErrorEmptyNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AErrorEmptyNotification.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.AErrorEmptyNotification.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.AErrorEmptyNotification.Location = new System.Drawing.Point(48, 91);
            this.AErrorEmptyNotification.Name = "AErrorEmptyNotification";
            this.AErrorEmptyNotification.Size = new System.Drawing.Size(582, 42);
            this.AErrorEmptyNotification.TabIndex = 43;
            this.AErrorEmptyNotification.Text = "Please make sure you fill all the fields, all are required.";
            this.AErrorEmptyNotification.Visible = false;
            // 
            // ABtnSignUp
            // 
            this.ABtnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.ABtnSignUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ABtnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ABtnSignUp.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ABtnSignUp.Location = new System.Drawing.Point(69, 481);
            this.ABtnSignUp.Name = "ABtnSignUp";
            this.ABtnSignUp.Rounded = true;
            this.ABtnSignUp.Size = new System.Drawing.Size(212, 53);
            this.ABtnSignUp.TabIndex = 39;
            this.ABtnSignUp.Text = "Sign Up";
            this.ABtnSignUp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ABtnSignUp.Click += new System.EventHandler(this.ABtnSignUp_Click);
            // 
            // ABtnSignIn
            // 
            this.ABtnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ABtnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.ABtnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ABtnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ABtnSignIn.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.ABtnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ABtnSignIn.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ABtnSignIn.HoverForeColor = System.Drawing.Color.White;
            this.ABtnSignIn.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.ABtnSignIn.Location = new System.Drawing.Point(305, 481);
            this.ABtnSignIn.MinimumSize = new System.Drawing.Size(144, 47);
            this.ABtnSignIn.Name = "ABtnSignIn";
            this.ABtnSignIn.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ABtnSignIn.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ABtnSignIn.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.ABtnSignIn.PressedForeColor = System.Drawing.Color.White;
            this.ABtnSignIn.Radius = 5;
            this.ABtnSignIn.Size = new System.Drawing.Size(199, 53);
            this.ABtnSignIn.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.ABtnSignIn.TabIndex = 38;
            this.ABtnSignIn.Text = "Sign In";
            this.ABtnSignIn.Click += new System.EventHandler(this.ABtnSignIn_Click);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(64, 284);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(112, 30);
            this.foreverLabel4.TabIndex = 37;
            this.foreverLabel4.Text = "Password";
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(64, 380);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(114, 30);
            this.foreverLabel3.TabIndex = 36;
            this.foreverLabel3.Text = "Invited By";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(64, 183);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(67, 30);
            this.foreverLabel2.TabIndex = 35;
            this.foreverLabel2.Text = "Email";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(65, 136);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(346, 20);
            this.foreverLabel1.TabIndex = 34;
            this.foreverLabel1.Text = "Start managing library users, and books catalogue.";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("hooge 05_53", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel1.Location = new System.Drawing.Point(56, 70);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(301, 75);
            this.bigLabel1.TabIndex = 33;
            this.bigLabel1.Text = "Sign Up";
            // 
            // ATxtUserPassword
            // 
            this.ATxtUserPassword.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.ATxtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtUserPassword.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtUserPassword.ColorBordersOnEnter = true;
            this.ATxtUserPassword.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.ATxtUserPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.ATxtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.ATxtUserPassword.Image = null;
            this.ATxtUserPassword.Location = new System.Drawing.Point(69, 317);
            this.ATxtUserPassword.MaxLength = 32767;
            this.ATxtUserPassword.Multiline = false;
            this.ATxtUserPassword.Name = "ATxtUserPassword";
            this.ATxtUserPassword.ReadOnly = false;
            this.ATxtUserPassword.ShortcutsEnabled = true;
            this.ATxtUserPassword.ShowBottomBorder = true;
            this.ATxtUserPassword.ShowTopBorder = false;
            this.ATxtUserPassword.Size = new System.Drawing.Size(435, 50);
            this.ATxtUserPassword.TabIndex = 32;
            this.ATxtUserPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ATxtUserPassword.UseSystemPasswordChar = true;
            this.ATxtUserPassword.Watermark = "";
            this.ATxtUserPassword.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // ATxtUserEmail
            // 
            this.ATxtUserEmail.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.ATxtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtUserEmail.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtUserEmail.ColorBordersOnEnter = true;
            this.ATxtUserEmail.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.ATxtUserEmail.Font = new System.Drawing.Font("Roboto", 13F);
            this.ATxtUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.ATxtUserEmail.Image = null;
            this.ATxtUserEmail.Location = new System.Drawing.Point(69, 216);
            this.ATxtUserEmail.MaxLength = 32767;
            this.ATxtUserEmail.Multiline = false;
            this.ATxtUserEmail.Name = "ATxtUserEmail";
            this.ATxtUserEmail.ReadOnly = false;
            this.ATxtUserEmail.ShortcutsEnabled = true;
            this.ATxtUserEmail.ShowBottomBorder = true;
            this.ATxtUserEmail.ShowTopBorder = false;
            this.ATxtUserEmail.Size = new System.Drawing.Size(435, 53);
            this.ATxtUserEmail.TabIndex = 31;
            this.ATxtUserEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ATxtUserEmail.UseSystemPasswordChar = false;
            this.ATxtUserEmail.Watermark = "";
            this.ATxtUserEmail.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // ATxtInvitedBy
            // 
            this.ATxtInvitedBy.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.ATxtInvitedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtInvitedBy.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.ATxtInvitedBy.ColorBordersOnEnter = true;
            this.ATxtInvitedBy.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.ATxtInvitedBy.Font = new System.Drawing.Font("Roboto", 12F);
            this.ATxtInvitedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.ATxtInvitedBy.Image = null;
            this.ATxtInvitedBy.Location = new System.Drawing.Point(69, 413);
            this.ATxtInvitedBy.MaxLength = 32767;
            this.ATxtInvitedBy.Multiline = false;
            this.ATxtInvitedBy.Name = "ATxtInvitedBy";
            this.ATxtInvitedBy.ReadOnly = false;
            this.ATxtInvitedBy.ShortcutsEnabled = true;
            this.ATxtInvitedBy.ShowBottomBorder = true;
            this.ATxtInvitedBy.ShowTopBorder = false;
            this.ATxtInvitedBy.Size = new System.Drawing.Size(435, 52);
            this.ATxtInvitedBy.TabIndex = 30;
            this.ATxtInvitedBy.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.ATxtInvitedBy.UseSystemPasswordChar = false;
            this.ATxtInvitedBy.Watermark = "";
            this.ATxtInvitedBy.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(636, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 533);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AErrorPasswordNotify
            // 
            this.AErrorPasswordNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AErrorPasswordNotify.Close = true;
            this.AErrorPasswordNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AErrorPasswordNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.AErrorPasswordNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.AErrorPasswordNotify.Location = new System.Drawing.Point(69, 91);
            this.AErrorPasswordNotify.Name = "AErrorPasswordNotify";
            this.AErrorPasswordNotify.Size = new System.Drawing.Size(851, 42);
            this.AErrorPasswordNotify.TabIndex = 46;
            this.AErrorPasswordNotify.Text = "Email or password are incorrect, make sure your password has more than 6 characte" +
    "rs.";
            this.AErrorPasswordNotify.Visible = false;
            // 
            // AdminSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 579);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "AdminSignUp";
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ForeverNotification ASuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification AErrorEmptyNotification;
        private ReaLTaiizor.Controls.ForeverButtonSticky ABtnSignUp;
        private ReaLTaiizor.Controls.NightButton ABtnSignIn;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightTextBox ATxtUserPassword;
        private ReaLTaiizor.Controls.NightTextBox ATxtUserEmail;
        private ReaLTaiizor.Controls.NightTextBox ATxtInvitedBy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverNotification AErrorPasswordNotify;
    }
}