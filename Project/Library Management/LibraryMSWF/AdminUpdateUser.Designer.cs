namespace LibraryMSWF {
    partial class AdminUpdateUser {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUpdateUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.themeForm1 = new ReaLTaiizor.Forms.ThemeForm();
            this.ADatagridUpdateUser = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new LibraryMSWF.LibraryManagementDataSet();
            this.ABtnClearField = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.AUSuccessNotify = new ReaLTaiizor.Controls.ForeverNotification();
            this.AUErrorEmptyNotification = new ReaLTaiizor.Controls.ForeverNotification();
            this.AUTxtUserAdno = new ReaLTaiizor.Controls.NightTextBox();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.AUBtnUpdateUser = new ReaLTaiizor.Controls.ForeverButtonSticky();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.AUTxtUserPassword = new ReaLTaiizor.Controls.NightTextBox();
            this.AUTxtUserEmail = new ReaLTaiizor.Controls.NightTextBox();
            this.AUTxtUserName = new ReaLTaiizor.Controls.NightTextBox();
            this.usersTableAdapter = new LibraryMSWF.LibraryManagementDataSetTableAdapters.UsersTableAdapter();
            this.AUBtnGoBack = new ReaLTaiizor.Controls.NightButton();
            this.themeForm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADatagridUpdateUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // themeForm1
            // 
            this.themeForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.themeForm1.Controls.Add(this.AUBtnGoBack);
            this.themeForm1.Controls.Add(this.ADatagridUpdateUser);
            this.themeForm1.Controls.Add(this.ABtnClearField);
            this.themeForm1.Controls.Add(this.AUSuccessNotify);
            this.themeForm1.Controls.Add(this.AUErrorEmptyNotification);
            this.themeForm1.Controls.Add(this.AUTxtUserAdno);
            this.themeForm1.Controls.Add(this.foreverLabel5);
            this.themeForm1.Controls.Add(this.AUBtnUpdateUser);
            this.themeForm1.Controls.Add(this.foreverLabel4);
            this.themeForm1.Controls.Add(this.foreverLabel3);
            this.themeForm1.Controls.Add(this.foreverLabel2);
            this.themeForm1.Controls.Add(this.foreverLabel1);
            this.themeForm1.Controls.Add(this.bigLabel1);
            this.themeForm1.Controls.Add(this.AUTxtUserPassword);
            this.themeForm1.Controls.Add(this.AUTxtUserEmail);
            this.themeForm1.Controls.Add(this.AUTxtUserName);
            this.themeForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themeForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.themeForm1.Image = ((System.Drawing.Image)(resources.GetObject("themeForm1.Image")));
            this.themeForm1.Location = new System.Drawing.Point(0, 0);
            this.themeForm1.MinimumSize = new System.Drawing.Size(126, 50);
            this.themeForm1.Name = "themeForm1";
            this.themeForm1.Padding = new System.Windows.Forms.Padding(10, 70, 10, 9);
            this.themeForm1.RoundCorners = true;
            this.themeForm1.Sizable = true;
            this.themeForm1.Size = new System.Drawing.Size(1334, 852);
            this.themeForm1.SmartBounds = true;
            this.themeForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.themeForm1.TabIndex = 0;
            this.themeForm1.Text = "Newman Library Management System";
            // 
            // ADatagridUpdateUser
            // 
            this.ADatagridUpdateUser.AllowUserToAddRows = false;
            this.ADatagridUpdateUser.AllowUserToDeleteRows = false;
            this.ADatagridUpdateUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ADatagridUpdateUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ADatagridUpdateUser.AutoGenerateColumns = false;
            this.ADatagridUpdateUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ADatagridUpdateUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ADatagridUpdateUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ADatagridUpdateUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ADatagridUpdateUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ADatagridUpdateUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADatagridUpdateUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ADatagridUpdateUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ADatagridUpdateUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.admissionNumberDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.ADatagridUpdateUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.ADatagridUpdateUser.DataSource = this.usersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ADatagridUpdateUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.ADatagridUpdateUser.EnableHeadersVisualStyles = false;
            this.ADatagridUpdateUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ADatagridUpdateUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ADatagridUpdateUser.Location = new System.Drawing.Point(539, 337);
            this.ADatagridUpdateUser.Name = "ADatagridUpdateUser";
            this.ADatagridUpdateUser.ReadOnly = true;
            this.ADatagridUpdateUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ADatagridUpdateUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ADatagridUpdateUser.RowHeadersWidth = 51;
            this.ADatagridUpdateUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ADatagridUpdateUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ADatagridUpdateUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ADatagridUpdateUser.Size = new System.Drawing.Size(769, 492);
            this.ADatagridUpdateUser.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Orange;
            this.ADatagridUpdateUser.TabIndex = 68;
            this.ADatagridUpdateUser.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            this.ADatagridUpdateUser.UseCustomBackColor = true;
            this.ADatagridUpdateUser.UseStyleColors = true;
            this.ADatagridUpdateUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADatagridUpdateUser_CellClick);
            this.ADatagridUpdateUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ADatagridUpdateUser_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 109;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 110;
            // 
            // admissionNumberDataGridViewTextBoxColumn
            // 
            this.admissionNumberDataGridViewTextBoxColumn.DataPropertyName = "AdmissionNumber";
            this.admissionNumberDataGridViewTextBoxColumn.HeaderText = "AdmissionNumber";
            this.admissionNumberDataGridViewTextBoxColumn.Name = "admissionNumberDataGridViewTextBoxColumn";
            this.admissionNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.admissionNumberDataGridViewTextBoxColumn.Width = 252;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 101;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 145;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ABtnClearField
            // 
            this.ABtnClearField.BackColor = System.Drawing.Color.Transparent;
            this.ABtnClearField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ABtnClearField.BaseColor = System.Drawing.Color.Gainsboro;
            this.ABtnClearField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ABtnClearField.Font = new System.Drawing.Font("NovaMono for Powerline", 16F, System.Drawing.FontStyle.Bold);
            this.ABtnClearField.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ABtnClearField.Location = new System.Drawing.Point(342, 584);
            this.ABtnClearField.Name = "ABtnClearField";
            this.ABtnClearField.Rounded = false;
            this.ABtnClearField.Size = new System.Drawing.Size(164, 50);
            this.ABtnClearField.TabIndex = 67;
            this.ABtnClearField.Text = "Clear";
            this.ABtnClearField.TextColor = System.Drawing.Color.OrangeRed;
            this.ABtnClearField.Click += new System.EventHandler(this.ABtnClearField_Click);
            // 
            // AUSuccessNotify
            // 
            this.AUSuccessNotify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AUSuccessNotify.Close = true;
            this.AUSuccessNotify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AUSuccessNotify.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.AUSuccessNotify.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Success;
            this.AUSuccessNotify.Location = new System.Drawing.Point(414, 230);
            this.AUSuccessNotify.Name = "AUSuccessNotify";
            this.AUSuccessNotify.Size = new System.Drawing.Size(510, 42);
            this.AUSuccessNotify.TabIndex = 59;
            this.AUSuccessNotify.Text = "User has been added to database successfully.";
            this.AUSuccessNotify.Visible = false;
            // 
            // AUErrorEmptyNotification
            // 
            this.AUErrorEmptyNotification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.AUErrorEmptyNotification.Close = true;
            this.AUErrorEmptyNotification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AUErrorEmptyNotification.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.AUErrorEmptyNotification.Kind = ReaLTaiizor.Controls.ForeverNotification._Kind.Error;
            this.AUErrorEmptyNotification.Location = new System.Drawing.Point(373, 230);
            this.AUErrorEmptyNotification.Name = "AUErrorEmptyNotification";
            this.AUErrorEmptyNotification.Size = new System.Drawing.Size(588, 42);
            this.AUErrorEmptyNotification.TabIndex = 58;
            this.AUErrorEmptyNotification.Text = "Please select any row containing record of user before proceeding.";
            this.AUErrorEmptyNotification.Visible = false;
            // 
            // AUTxtUserAdno
            // 
            this.AUTxtUserAdno.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.AUTxtUserAdno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserAdno.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserAdno.ColorBordersOnEnter = true;
            this.AUTxtUserAdno.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.AUTxtUserAdno.Font = new System.Drawing.Font("Roboto", 12F);
            this.AUTxtUserAdno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.AUTxtUserAdno.Image = null;
            this.AUTxtUserAdno.Location = new System.Drawing.Point(342, 460);
            this.AUTxtUserAdno.MaxLength = 25;
            this.AUTxtUserAdno.Multiline = false;
            this.AUTxtUserAdno.Name = "AUTxtUserAdno";
            this.AUTxtUserAdno.ReadOnly = false;
            this.AUTxtUserAdno.ShortcutsEnabled = true;
            this.AUTxtUserAdno.ShowBottomBorder = true;
            this.AUTxtUserAdno.ShowTopBorder = false;
            this.AUTxtUserAdno.Size = new System.Drawing.Size(164, 52);
            this.AUTxtUserAdno.TabIndex = 56;
            this.AUTxtUserAdno.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AUTxtUserAdno.UseSystemPasswordChar = false;
            this.AUTxtUserAdno.Watermark = "";
            this.AUTxtUserAdno.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel5.Location = new System.Drawing.Point(337, 413);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(159, 30);
            this.foreverLabel5.TabIndex = 55;
            this.foreverLabel5.Text = "Admission No";
            // 
            // AUBtnUpdateUser
            // 
            this.AUBtnUpdateUser.BackColor = System.Drawing.Color.Transparent;
            this.AUBtnUpdateUser.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnUpdateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AUBtnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.AUBtnUpdateUser.Location = new System.Drawing.Point(52, 680);
            this.AUBtnUpdateUser.Name = "AUBtnUpdateUser";
            this.AUBtnUpdateUser.Rounded = true;
            this.AUBtnUpdateUser.Size = new System.Drawing.Size(247, 58);
            this.AUBtnUpdateUser.TabIndex = 54;
            this.AUBtnUpdateUser.Text = "Update User";
            this.AUBtnUpdateUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.AUBtnUpdateUser.Click += new System.EventHandler(this.AUBtnUpdateUser_Click);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel4.Location = new System.Drawing.Point(47, 542);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(112, 30);
            this.foreverLabel4.TabIndex = 53;
            this.foreverLabel4.Text = "Password";
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel3.Location = new System.Drawing.Point(47, 413);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(118, 30);
            this.foreverLabel3.TabIndex = 52;
            this.foreverLabel3.Text = "Full Name";
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel2.Location = new System.Drawing.Point(47, 293);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(67, 30);
            this.foreverLabel2.TabIndex = 51;
            this.foreverLabel2.Text = "Email";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 11F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(183)))), ((int)(((byte)(185)))));
            this.foreverLabel1.Location = new System.Drawing.Point(462, 173);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(353, 20);
            this.foreverLabel1.TabIndex = 50;
            this.foreverLabel1.Text = "You can add update existing user data to database.";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("hooge 05_53", 45F, System.Drawing.FontStyle.Bold);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(62)))), ((int)(((byte)(14)))));
            this.bigLabel1.Location = new System.Drawing.Point(453, 98);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(523, 75);
            this.bigLabel1.TabIndex = 49;
            this.bigLabel1.Text = "User details";
            // 
            // AUTxtUserPassword
            // 
            this.AUTxtUserPassword.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.AUTxtUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserPassword.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserPassword.ColorBordersOnEnter = true;
            this.AUTxtUserPassword.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.AUTxtUserPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.AUTxtUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.AUTxtUserPassword.Image = null;
            this.AUTxtUserPassword.Location = new System.Drawing.Point(52, 584);
            this.AUTxtUserPassword.MaxLength = 32767;
            this.AUTxtUserPassword.Multiline = false;
            this.AUTxtUserPassword.Name = "AUTxtUserPassword";
            this.AUTxtUserPassword.ReadOnly = false;
            this.AUTxtUserPassword.ShortcutsEnabled = true;
            this.AUTxtUserPassword.ShowBottomBorder = true;
            this.AUTxtUserPassword.ShowTopBorder = false;
            this.AUTxtUserPassword.Size = new System.Drawing.Size(247, 50);
            this.AUTxtUserPassword.TabIndex = 48;
            this.AUTxtUserPassword.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AUTxtUserPassword.UseSystemPasswordChar = true;
            this.AUTxtUserPassword.Watermark = "";
            this.AUTxtUserPassword.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // AUTxtUserEmail
            // 
            this.AUTxtUserEmail.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.AUTxtUserEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserEmail.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserEmail.ColorBordersOnEnter = true;
            this.AUTxtUserEmail.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.AUTxtUserEmail.Font = new System.Drawing.Font("Roboto", 13F);
            this.AUTxtUserEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.AUTxtUserEmail.Image = null;
            this.AUTxtUserEmail.Location = new System.Drawing.Point(52, 337);
            this.AUTxtUserEmail.MaxLength = 32767;
            this.AUTxtUserEmail.Multiline = false;
            this.AUTxtUserEmail.Name = "AUTxtUserEmail";
            this.AUTxtUserEmail.ReadOnly = false;
            this.AUTxtUserEmail.ShortcutsEnabled = true;
            this.AUTxtUserEmail.ShowBottomBorder = true;
            this.AUTxtUserEmail.ShowTopBorder = false;
            this.AUTxtUserEmail.Size = new System.Drawing.Size(454, 53);
            this.AUTxtUserEmail.TabIndex = 47;
            this.AUTxtUserEmail.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AUTxtUserEmail.UseSystemPasswordChar = false;
            this.AUTxtUserEmail.Watermark = "";
            this.AUTxtUserEmail.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // AUTxtUserName
            // 
            this.AUTxtUserName.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(42)))), ((int)(((byte)(32)))));
            this.AUTxtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserName.BaseBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(67)))));
            this.AUTxtUserName.ColorBordersOnEnter = true;
            this.AUTxtUserName.DisableBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.AUTxtUserName.Font = new System.Drawing.Font("Roboto", 12F);
            this.AUTxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(131)))), ((int)(((byte)(140)))));
            this.AUTxtUserName.Image = null;
            this.AUTxtUserName.Location = new System.Drawing.Point(52, 460);
            this.AUTxtUserName.MaxLength = 32767;
            this.AUTxtUserName.Multiline = false;
            this.AUTxtUserName.Name = "AUTxtUserName";
            this.AUTxtUserName.ReadOnly = false;
            this.AUTxtUserName.ShortcutsEnabled = true;
            this.AUTxtUserName.ShowBottomBorder = true;
            this.AUTxtUserName.ShowTopBorder = false;
            this.AUTxtUserName.Size = new System.Drawing.Size(247, 52);
            this.AUTxtUserName.TabIndex = 46;
            this.AUTxtUserName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.AUTxtUserName.UseSystemPasswordChar = false;
            this.AUTxtUserName.Watermark = "";
            this.AUTxtUserName.WatermarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(120)))), ((int)(((byte)(129)))));
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            this.AUBtnGoBack.Location = new System.Drawing.Point(342, 680);
            this.AUBtnGoBack.MinimumSize = new System.Drawing.Size(144, 47);
            this.AUBtnGoBack.Name = "AUBtnGoBack";
            this.AUBtnGoBack.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.AUBtnGoBack.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(242)))), ((int)(((byte)(93)))), ((int)(((byte)(89)))));
            this.AUBtnGoBack.PressedForeColor = System.Drawing.Color.White;
            this.AUBtnGoBack.Radius = 5;
            this.AUBtnGoBack.Size = new System.Drawing.Size(164, 58);
            this.AUBtnGoBack.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.AUBtnGoBack.TabIndex = 69;
            this.AUBtnGoBack.Text = "Go Back";
            this.AUBtnGoBack.Click += new System.EventHandler(this.AUBtnGoBack_Click);
            // 
            // AdminUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 852);
            this.Controls.Add(this.themeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(261, 61);
            this.Name = "AdminUpdateUser";
            this.Text = "Newman Library Management System";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.AdminUpdateUser_Load);
            this.themeForm1.ResumeLayout(false);
            this.themeForm1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ADatagridUpdateUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ThemeForm themeForm1;
        private ReaLTaiizor.Controls.ForeverNotification AUSuccessNotify;
        private ReaLTaiizor.Controls.ForeverNotification AUErrorEmptyNotification;
        private ReaLTaiizor.Controls.NightTextBox AUTxtUserAdno;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverButtonSticky AUBtnUpdateUser;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightTextBox AUTxtUserPassword;
        private ReaLTaiizor.Controls.NightTextBox AUTxtUserEmail;
        private ReaLTaiizor.Controls.NightTextBox AUTxtUserName;
        private ReaLTaiizor.Controls.ForeverButtonSticky ABtnClearField;
        private ReaLTaiizor.Controls.PoisonDataGridView ADatagridUpdateUser;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private LibraryManagementDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private ReaLTaiizor.Controls.NightButton AUBtnGoBack;
    }
}