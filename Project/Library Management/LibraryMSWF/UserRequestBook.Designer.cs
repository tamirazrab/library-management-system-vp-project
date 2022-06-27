namespace LibraryMSWF {
    partial class UserRequestBook {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRequestBook));
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.UBtnClearField = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.URSErrorNotifySelectBook = new ReaLTaiizor.Controls.ForeverNotification();
            this.URSSuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.AUBtnGoBack = new ReaLTaiizor.Controls.NightButton();
            this.UTxtRequestSectionUserName = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.UTxtRequestSectionAuthorName = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.URBtnRequestBook = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.UTxtRequestSectionBookName = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.UBtnClearField);
            this.themeForm1.Controls.Add(this.URSErrorNotifySelectBook);
            this.themeForm1.Controls.Add(this.URSSuccessNotify);
            this.themeForm1.Controls.Add(this.AUBtnGoBack);
            this.themeForm1.Controls.Add(this.UTxtRequestSectionUserName);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.UTxtRequestSectionAuthorName);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.pictureBox1);
            this.themeForm1.Controls.Add(this.URBtnRequestBook);
            this.themeForm1.Controls.Add(this.UTxtRequestSectionBookName);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.bigLabel4);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1024, 601);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            // 
            // UBtnClearField
            // 
            this.UBtnClearField.BackColor = System.Drawing.Color.Transparent;
            this.UBtnClearField.BaseColor = System.Drawing.Color.Gainsboro;
            this.UBtnClearField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UBtnClearField.Font = new System.Drawing.Font("NovaMono for Powerline", 16F, System.Drawing.FontStyle.Bold);
            this.UBtnClearField.Location = new System.Drawing.Point(402, 444);
            this.UBtnClearField.Name = "UBtnClearField";
            this.UBtnClearField.Rounded = false;
            this.UBtnClearField.Size = new System.Drawing.Size(144, 50);
            this.UBtnClearField.TabIndex = 110;
            this.UBtnClearField.Text = "Clear";
            this.UBtnClearField.TextColor = System.Drawing.Color.OrangeRed;
            this.UBtnClearField.Click += new System.EventHandler(this.UBtnClearField_Click);
            // 
            // URSErrorNotifySelectBook
            // 
            this.URSErrorNotifySelectBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.URSErrorNotifySelectBook.Close = true;
            this.URSErrorNotifySelectBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.URSErrorNotifySelectBook.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.URSErrorNotifySelectBook.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.URSErrorNotifySelectBook.Location = new System.Drawing.Point(37, 169);
            this.URSErrorNotifySelectBook.Name = "URSErrorNotifySelectBook";
            this.URSErrorNotifySelectBook.Size = new System.Drawing.Size(509, 42);
            this.URSErrorNotifySelectBook.TabIndex = 109;
            this.URSErrorNotifySelectBook.Text = "All fields are required. Please fill them all.";
            this.URSErrorNotifySelectBook.Visible = false;
            // 
            // URSSuccessNotify
            // 
            this.URSSuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.URSSuccessNotify.Close = true;
            this.URSSuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.URSSuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.URSSuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.URSSuccessNotify.Location = new System.Drawing.Point(37, 169);
            this.URSSuccessNotify.Name = "URSSuccessNotify";
            this.URSSuccessNotify.Size = new System.Drawing.Size(538, 42);
            this.URSSuccessNotify.TabIndex = 101;
            this.URSSuccessNotify.Text = "Your request has been successfully sent to library.";
            this.URSSuccessNotify.Visible = false;
            // 
            // AUBtnGoBack
            // 
            this.AUBtnGoBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AUBtnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.AUBtnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AUBtnGoBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AUBtnGoBack.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AUBtnGoBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.HoverForeColor = System.Drawing.Color.White;
            this.AUBtnGoBack.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.AUBtnGoBack.Location = new System.Drawing.Point(402, 514);
            this.AUBtnGoBack.MinimumSize = new System.Drawing.Size(144, 47);
            this.AUBtnGoBack.Name = "AUBtnGoBack";
            this.AUBtnGoBack.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.AUBtnGoBack.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PressedForeColor = System.Drawing.Color.White;
            this.AUBtnGoBack.Radius = 5;
            this.AUBtnGoBack.Size = new System.Drawing.Size(144, 58);
            this.AUBtnGoBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.AUBtnGoBack.TabIndex = 100;
            this.AUBtnGoBack.Text = "Go Back";
            this.AUBtnGoBack.Click += new System.EventHandler(this.AUBtnGoBack_Click);
            // 
            // UTxtRequestSectionUserName
            // 
            this.UTxtRequestSectionUserName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.UTxtRequestSectionUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionUserName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionUserName.ColorBordersOnEnter = true;
            this.UTxtRequestSectionUserName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.UTxtRequestSectionUserName.Font = new System.Drawing.Font("Roboto", 11F);
            this.UTxtRequestSectionUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.UTxtRequestSectionUserName.Image = null;
            this.UTxtRequestSectionUserName.Location = new System.Drawing.Point(37, 444);
            this.UTxtRequestSectionUserName.MaxLength = 32767;
            this.UTxtRequestSectionUserName.Multiline = false;
            this.UTxtRequestSectionUserName.Name = "UTxtRequestSectionUserName";
            this.UTxtRequestSectionUserName.ReadOnly = false;
            this.UTxtRequestSectionUserName.ShortcutsEnabled = true;
            this.UTxtRequestSectionUserName.ShowBottomBorder = true;
            this.UTxtRequestSectionUserName.ShowTopBorder = false;
            this.UTxtRequestSectionUserName.Size = new System.Drawing.Size(328, 50);
            this.UTxtRequestSectionUserName.TabIndex = 57;
            this.UTxtRequestSectionUserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UTxtRequestSectionUserName.UseSystemPasswordChar = false;
            this.UTxtRequestSectionUserName.Watermark = "";
            this.UTxtRequestSectionUserName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(32, 402);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(131, 30);
            this.foreverLabel2.TabIndex = 58;
            this.foreverLabel2.Text = "Your Name";
            this.foreverLabel2.UseMnemonic = false;
            // 
            // UTxtRequestSectionAuthorName
            // 
            this.UTxtRequestSectionAuthorName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.UTxtRequestSectionAuthorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionAuthorName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionAuthorName.ColorBordersOnEnter = true;
            this.UTxtRequestSectionAuthorName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.UTxtRequestSectionAuthorName.Font = new System.Drawing.Font("Roboto", 11F);
            this.UTxtRequestSectionAuthorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.UTxtRequestSectionAuthorName.Image = null;
            this.UTxtRequestSectionAuthorName.Location = new System.Drawing.Point(37, 326);
            this.UTxtRequestSectionAuthorName.MaxLength = 32767;
            this.UTxtRequestSectionAuthorName.Multiline = false;
            this.UTxtRequestSectionAuthorName.Name = "UTxtRequestSectionAuthorName";
            this.UTxtRequestSectionAuthorName.ReadOnly = false;
            this.UTxtRequestSectionAuthorName.ShortcutsEnabled = true;
            this.UTxtRequestSectionAuthorName.ShowBottomBorder = true;
            this.UTxtRequestSectionAuthorName.ShowTopBorder = false;
            this.UTxtRequestSectionAuthorName.Size = new System.Drawing.Size(509, 50);
            this.UTxtRequestSectionAuthorName.TabIndex = 55;
            this.UTxtRequestSectionAuthorName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UTxtRequestSectionAuthorName.UseSystemPasswordChar = false;
            this.UTxtRequestSectionAuthorName.Watermark = "";
            this.UTxtRequestSectionAuthorName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(32, 284);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(154, 30);
            this.foreverLabel1.TabIndex = 56;
            this.foreverLabel1.Text = "Author Name";
            this.foreverLabel1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(644, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(416, 541);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // URBtnRequestBook
            // 
            this.URBtnRequestBook.BackColor = System.Drawing.Color.Transparent;
            this.URBtnRequestBook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.URBtnRequestBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.URBtnRequestBook.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.URBtnRequestBook.Location = new System.Drawing.Point(37, 512);
            this.URBtnRequestBook.Name = "URBtnRequestBook";
            this.URBtnRequestBook.Rounded = true;
            this.URBtnRequestBook.Size = new System.Drawing.Size(328, 60);
            this.URBtnRequestBook.TabIndex = 53;
            this.URBtnRequestBook.Text = "Request Book";
            this.URBtnRequestBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.URBtnRequestBook.Click += new System.EventHandler(this.URBtnRequestBook_Click);
            // 
            // UTxtRequestSectionBookName
            // 
            this.UTxtRequestSectionBookName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.UTxtRequestSectionBookName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionBookName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtRequestSectionBookName.ColorBordersOnEnter = true;
            this.UTxtRequestSectionBookName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.UTxtRequestSectionBookName.Font = new System.Drawing.Font("Roboto", 11F);
            this.UTxtRequestSectionBookName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.UTxtRequestSectionBookName.Image = null;
            this.UTxtRequestSectionBookName.Location = new System.Drawing.Point(37, 217);
            this.UTxtRequestSectionBookName.MaxLength = 32767;
            this.UTxtRequestSectionBookName.Multiline = false;
            this.UTxtRequestSectionBookName.Name = "UTxtRequestSectionBookName";
            this.UTxtRequestSectionBookName.ReadOnly = false;
            this.UTxtRequestSectionBookName.ShortcutsEnabled = true;
            this.UTxtRequestSectionBookName.ShowBottomBorder = true;
            this.UTxtRequestSectionBookName.ShowTopBorder = false;
            this.UTxtRequestSectionBookName.Size = new System.Drawing.Size(509, 50);
            this.UTxtRequestSectionBookName.TabIndex = 51;
            this.UTxtRequestSectionBookName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UTxtRequestSectionBookName.UseSystemPasswordChar = false;
            this.UTxtRequestSectionBookName.Watermark = "";
            this.UTxtRequestSectionBookName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(32, 175);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(196, 30);
            this.foreverLabel4.TabIndex = 52;
            this.foreverLabel4.Text = "Enter Book Name";
            this.foreverLabel4.UseMnemonic = false;
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(33, 125);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(450, 20);
            this.foreverLabel3.TabIndex = 48;
            this.foreverLabel3.Text = "Here you can request your favourite book to be added into library.";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("hooge 05_55", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel4.Location = new System.Drawing.Point(24, 60);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(551, 75);
            this.bigLabel4.TabIndex = 47;
            this.bigLabel4.Text = "Request Section";
            // 
            // UserRequestBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 601);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "UserRequestBook";
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.ForeverButtonSticky URBtnRequestBook;
        private ReaLTaiizor.Controls.NightTextBox UTxtRequestSectionBookName;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.NightTextBox UTxtRequestSectionUserName;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.NightTextBox UTxtRequestSectionAuthorName;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightButton AUBtnGoBack;
        private ReaLTaiizor.Controls.ForeverNotification URSSuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification URSErrorNotifySelectBook;
        private ReaLTaiizor.Controls.ForeverButtonSticky UBtnClearField;
    }
}