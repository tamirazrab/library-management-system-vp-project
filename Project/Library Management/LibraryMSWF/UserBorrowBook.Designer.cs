namespace LibraryMSWF {
    partial class UserBorrowBook {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBorrowBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.UErrorNotifySelectBook = new ReaLTaiizor.Controls.ForeverNotification();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.UTxtDurationNumber = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.UTxtDurationPeriod = new ReaLTaiizor.Controls.MaterialComboBox();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.UDatagridBorrowSection = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.AUBtnGoBack = new ReaLTaiizor.Controls.NightButton();
            this.USuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.UErrorEmptyNotification = new ReaLTaiizor.Controls.ForeverNotification();
            this.UTxtBorrowerName = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.UBtnBorrowBook = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDatagridBorrowSection)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.UErrorNotifySelectBook);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.UTxtDurationNumber);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.UTxtDurationPeriod);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.UDatagridBorrowSection);
            this.themeForm1.Controls.Add(this.AUBtnGoBack);
            this.themeForm1.Controls.Add(this.USuccessNotify);
            this.themeForm1.Controls.Add(this.UErrorEmptyNotification);
            this.themeForm1.Controls.Add(this.UTxtBorrowerName);
            this.themeForm1.Controls.Add(this.foreverLabel5);
            this.themeForm1.Controls.Add(this.UBtnBorrowBook);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel1);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1318, 813);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            // 
            // UErrorNotifySelectBook
            // 
            this.UErrorNotifySelectBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.UErrorNotifySelectBook.Close = true;
            this.UErrorNotifySelectBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UErrorNotifySelectBook.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.UErrorNotifySelectBook.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.UErrorNotifySelectBook.Location = new System.Drawing.Point(406, 176);
            this.UErrorNotifySelectBook.Name = "UErrorNotifySelectBook";
            this.UErrorNotifySelectBook.Size = new System.Drawing.Size(631, 42);
            this.UErrorNotifySelectBook.TabIndex = 108;
            this.UErrorNotifySelectBook.Text = "You must first select the book which you want to borrow.";
            this.UErrorNotifySelectBook.Visible = false;
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(52, 521);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(120, 40);
            this.foreverLabel4.TabIndex = 107;
            this.foreverLabel4.Text = "Add duration \r\n3 days / 1 month";
            // 
            // UTxtDurationNumber
            // 
            this.UTxtDurationNumber.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.UTxtDurationNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtDurationNumber.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtDurationNumber.ColorBordersOnEnter = true;
            this.UTxtDurationNumber.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.UTxtDurationNumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.UTxtDurationNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.UTxtDurationNumber.Image = null;
            this.UTxtDurationNumber.Location = new System.Drawing.Point(56, 575);
            this.UTxtDurationNumber.MaxLength = 25;
            this.UTxtDurationNumber.Multiline = false;
            this.UTxtDurationNumber.Name = "UTxtDurationNumber";
            this.UTxtDurationNumber.ReadOnly = false;
            this.UTxtDurationNumber.ShortcutsEnabled = true;
            this.UTxtDurationNumber.ShowBottomBorder = true;
            this.UTxtDurationNumber.ShowTopBorder = false;
            this.UTxtDurationNumber.Size = new System.Drawing.Size(116, 52);
            this.UTxtDurationNumber.TabIndex = 106;
            this.UTxtDurationNumber.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UTxtDurationNumber.UseSystemPasswordChar = false;
            this.UTxtDurationNumber.Watermark = "";
            this.UTxtDurationNumber.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(203, 555);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(95, 20);
            this.foreverLabel3.TabIndex = 105;
            this.foreverLabel3.Text = "Select Period";
            // 
            // UTxtDurationPeriod
            // 
            this.UTxtDurationPeriod.AutoResize = false;
            this.UTxtDurationPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.UTxtDurationPeriod.Depth = 0;
            this.UTxtDurationPeriod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.UTxtDurationPeriod.DropDownHeight = 174;
            this.UTxtDurationPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UTxtDurationPeriod.DropDownWidth = 121;
            this.UTxtDurationPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.UTxtDurationPeriod.ForeColor = System.Drawing.Color.White;
            this.UTxtDurationPeriod.FormattingEnabled = true;
            this.UTxtDurationPeriod.IntegralHeight = false;
            this.UTxtDurationPeriod.ItemHeight = 43;
            this.UTxtDurationPeriod.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months"});
            this.UTxtDurationPeriod.Location = new System.Drawing.Point(207, 578);
            this.UTxtDurationPeriod.MaxDropDownItems = 4;
            this.UTxtDurationPeriod.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.UTxtDurationPeriod.Name = "UTxtDurationPeriod";
            this.UTxtDurationPeriod.Size = new System.Drawing.Size(121, 49);
            this.UTxtDurationPeriod.TabIndex = 104;
            this.UTxtDurationPeriod.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(51, 479);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(257, 30);
            this.foreverLabel2.TabIndex = 101;
            this.foreverLabel2.Text = "When you will return it?";
            // 
            // UDatagridBorrowSection
            // 
            this.UDatagridBorrowSection.AllowUserToAddRows = false;
            this.UDatagridBorrowSection.AllowUserToDeleteRows = false;
            this.UDatagridBorrowSection.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.UDatagridBorrowSection.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UDatagridBorrowSection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UDatagridBorrowSection.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UDatagridBorrowSection.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UDatagridBorrowSection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UDatagridBorrowSection.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UDatagridBorrowSection.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UDatagridBorrowSection.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UDatagridBorrowSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UDatagridBorrowSection.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UDatagridBorrowSection.DefaultCellStyle = dataGridViewCellStyle3;
            this.UDatagridBorrowSection.EnableHeadersVisualStyles = false;
            this.UDatagridBorrowSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UDatagridBorrowSection.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.UDatagridBorrowSection.Location = new System.Drawing.Point(497, 301);
            this.UDatagridBorrowSection.Name = "UDatagridBorrowSection";
            this.UDatagridBorrowSection.ReadOnly = true;
            this.UDatagridBorrowSection.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UDatagridBorrowSection.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UDatagridBorrowSection.RowHeadersWidth = 51;
            this.UDatagridBorrowSection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.UDatagridBorrowSection.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.UDatagridBorrowSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UDatagridBorrowSection.Size = new System.Drawing.Size(787, 495);
            this.UDatagridBorrowSection.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Orange;
            this.UDatagridBorrowSection.TabIndex = 100;
            this.UDatagridBorrowSection.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.UDatagridBorrowSection.UseCustomBackColor = true;
            this.UDatagridBorrowSection.UseStyleColors = true;
            this.UDatagridBorrowSection.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UDatagridBorrowSection_CellClick);
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
            this.AUBtnGoBack.Location = new System.Drawing.Point(334, 663);
            this.AUBtnGoBack.MinimumSize = new System.Drawing.Size(144, 47);
            this.AUBtnGoBack.Name = "AUBtnGoBack";
            this.AUBtnGoBack.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.AUBtnGoBack.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PressedForeColor = System.Drawing.Color.White;
            this.AUBtnGoBack.Radius = 5;
            this.AUBtnGoBack.Size = new System.Drawing.Size(144, 58);
            this.AUBtnGoBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.AUBtnGoBack.TabIndex = 99;
            this.AUBtnGoBack.Text = "Go Back";
            this.AUBtnGoBack.Click += new System.EventHandler(this.AUBtnGoBack_Click);
            // 
            // USuccessNotify
            // 
            this.USuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.USuccessNotify.Close = true;
            this.USuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.USuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.USuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.USuccessNotify.Location = new System.Drawing.Point(497, 253);
            this.USuccessNotify.Name = "USuccessNotify";
            this.USuccessNotify.Size = new System.Drawing.Size(787, 42);
            this.USuccessNotify.TabIndex = 93;
            this.USuccessNotify.Text = "You\'ve borrowed this book successfully.";
            this.USuccessNotify.Visible = false;
            // 
            // UErrorEmptyNotification
            // 
            this.UErrorEmptyNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.UErrorEmptyNotification.Close = true;
            this.UErrorEmptyNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UErrorEmptyNotification.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.UErrorEmptyNotification.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.UErrorEmptyNotification.Location = new System.Drawing.Point(406, 176);
            this.UErrorEmptyNotification.Name = "UErrorEmptyNotification";
            this.UErrorEmptyNotification.Size = new System.Drawing.Size(588, 42);
            this.UErrorEmptyNotification.TabIndex = 92;
            this.UErrorEmptyNotification.Text = "Please make sure you fill all the fields, all are required.";
            this.UErrorEmptyNotification.Visible = false;
            // 
            // UTxtBorrowerName
            // 
            this.UTxtBorrowerName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.UTxtBorrowerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtBorrowerName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.UTxtBorrowerName.ColorBordersOnEnter = true;
            this.UTxtBorrowerName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.UTxtBorrowerName.Font = new System.Drawing.Font("Roboto", 12F);
            this.UTxtBorrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.UTxtBorrowerName.Image = null;
            this.UTxtBorrowerName.Location = new System.Drawing.Point(56, 403);
            this.UTxtBorrowerName.MaxLength = 25;
            this.UTxtBorrowerName.Multiline = false;
            this.UTxtBorrowerName.Name = "UTxtBorrowerName";
            this.UTxtBorrowerName.ReadOnly = false;
            this.UTxtBorrowerName.ShortcutsEnabled = true;
            this.UTxtBorrowerName.ShowBottomBorder = true;
            this.UTxtBorrowerName.ShowTopBorder = false;
            this.UTxtBorrowerName.Size = new System.Drawing.Size(408, 52);
            this.UTxtBorrowerName.TabIndex = 91;
            this.UTxtBorrowerName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UTxtBorrowerName.UseSystemPasswordChar = false;
            this.UTxtBorrowerName.Watermark = "";
            this.UTxtBorrowerName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel5.Location = new System.Drawing.Point(51, 370);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(131, 30);
            this.foreverLabel5.TabIndex = 90;
            this.foreverLabel5.Text = "Your Name";
            // 
            // UBtnBorrowBook
            // 
            this.UBtnBorrowBook.BackColor = System.Drawing.Color.Transparent;
            this.UBtnBorrowBook.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.UBtnBorrowBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UBtnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.UBtnBorrowBook.Location = new System.Drawing.Point(56, 663);
            this.UBtnBorrowBook.Name = "UBtnBorrowBook";
            this.UBtnBorrowBook.Rounded = true;
            this.UBtnBorrowBook.Size = new System.Drawing.Size(272, 58);
            this.UBtnBorrowBook.TabIndex = 89;
            this.UBtnBorrowBook.Text = "Borrow Book";
            this.UBtnBorrowBook.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.UBtnBorrowBook.Click += new System.EventHandler(this.UBtnBorrowBook_Click);
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(437, 136);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(335, 20);
            this.foreverLabel1.TabIndex = 85;
            this.foreverLabel1.Text = "You can update existing books data to database.";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("hooge 05_53", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel1.Location = new System.Drawing.Point(428, 70);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(523, 75);
            this.bigLabel1.TabIndex = 84;
            this.bigLabel1.Text = "Book details";
            // 
            // UserBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 813);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "UserBorrowBook";
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UDatagridBorrowSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.NightButton AUBtnGoBack;
        private ReaLTaiizor.Controls.ForeverNotification USuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification UErrorEmptyNotification;
        private ReaLTaiizor.Controls.NightTextBox UTxtBorrowerName;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverButtonSticky UBtnBorrowBook;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView UDatagridBorrowSection;
        private ReaLTaiizor.Controls.MaterialComboBox UTxtDurationPeriod;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.NightTextBox UTxtDurationNumber;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverNotification UErrorNotifySelectBook;
    }
}