namespace Assignment
{
    partial class AdminDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboardForm));
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnExitAdmin = new System.Windows.Forms.Button();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.pictureBoxAdmin = new System.Windows.Forms.PictureBox();
            this.tabAddorRemoveUsers = new System.Windows.Forms.TabPage();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblNameProfile = new System.Windows.Forms.Label();
            this.lblPhoneNumProfile = new System.Windows.Forms.Label();
            this.lblAddorRemoveUsers = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblUpdateRole = new System.Windows.Forms.Label();
            this.cbUpdateRole = new System.Windows.Forms.ComboBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.lblNewEmail = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.lblUpdateProfile = new System.Windows.Forms.Label();
            this.txtSearchEmail = new System.Windows.Forms.TextBox();
            this.tabSalesReport = new System.Windows.Forms.TabPage();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.cbChef = new System.Windows.Forms.ComboBox();
            this.lblSelectChef = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lblSelectCategory = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblSalesReport = new System.Windows.Forms.Label();
            this.tabEWallet = new System.Windows.Forms.TabPage();
            this.lblTotalRefund = new System.Windows.Forms.Label();
            this.txtCustomerEmailEWallet = new System.Windows.Forms.TextBox();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.lblTotalTopUps = new System.Windows.Forms.Label();
            this.dgvEWalletReport = new System.Windows.Forms.DataGridView();
            this.btnViewEWalletReport = new System.Windows.Forms.Button();
            this.lblCustomerEmail = new System.Windows.Forms.Label();
            this.lblYearEWallet = new System.Windows.Forms.Label();
            this.lblMonthEWallet = new System.Windows.Forms.Label();
            this.cbEWalletYear = new System.Windows.Forms.ComboBox();
            this.cbEWalletMonth = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEWallet = new System.Windows.Forms.Label();
            this.tabControlAdmin.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).BeginInit();
            this.tabAddorRemoveUsers.SuspendLayout();
            this.tabSalesReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.tabEWallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWalletReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabHome);
            this.tabControlAdmin.Controls.Add(this.tabAddorRemoveUsers);
            this.tabControlAdmin.Controls.Add(this.tabSalesReport);
            this.tabControlAdmin.Controls.Add(this.tabEWallet);
            this.tabControlAdmin.Location = new System.Drawing.Point(12, 12);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(638, 558);
            this.tabControlAdmin.TabIndex = 22;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.Moccasin;
            this.tabHome.Controls.Add(this.btnExitAdmin);
            this.tabHome.Controls.Add(this.lblWelcomeAdmin);
            this.tabHome.Controls.Add(this.pictureBoxAdmin);
            this.tabHome.Location = new System.Drawing.Point(4, 25);
            this.tabHome.Name = "tabHome";
            this.tabHome.Size = new System.Drawing.Size(630, 529);
            this.tabHome.TabIndex = 4;
            this.tabHome.Text = "Home";
            // 
            // btnExitAdmin
            // 
            this.btnExitAdmin.Location = new System.Drawing.Point(499, 482);
            this.btnExitAdmin.Name = "btnExitAdmin";
            this.btnExitAdmin.Size = new System.Drawing.Size(81, 40);
            this.btnExitAdmin.TabIndex = 24;
            this.btnExitAdmin.Text = "Exit";
            this.btnExitAdmin.UseVisualStyleBackColor = true;
            this.btnExitAdmin.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(12, 12);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(386, 28);
            this.lblWelcomeAdmin.TabIndex = 22;
            this.lblWelcomeAdmin.Text = "Admin Dashboard";
            // 
            // pictureBoxAdmin
            // 
            this.pictureBoxAdmin.BackColor = System.Drawing.Color.Moccasin;
            this.pictureBoxAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAdmin.Image")));
            this.pictureBoxAdmin.Location = new System.Drawing.Point(17, 43);
            this.pictureBoxAdmin.Name = "pictureBoxAdmin";
            this.pictureBoxAdmin.Size = new System.Drawing.Size(544, 422);
            this.pictureBoxAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAdmin.TabIndex = 23;
            this.pictureBoxAdmin.TabStop = false;
            // 
            // tabAddorRemoveUsers
            // 
            this.tabAddorRemoveUsers.BackColor = System.Drawing.Color.Moccasin;
            this.tabAddorRemoveUsers.Controls.Add(this.txtUsername);
            this.tabAddorRemoveUsers.Controls.Add(this.lblUsername);
            this.tabAddorRemoveUsers.Controls.Add(this.txtName);
            this.tabAddorRemoveUsers.Controls.Add(this.txtPhoneNum);
            this.tabAddorRemoveUsers.Controls.Add(this.lblNameProfile);
            this.tabAddorRemoveUsers.Controls.Add(this.lblPhoneNumProfile);
            this.tabAddorRemoveUsers.Controls.Add(this.lblAddorRemoveUsers);
            this.tabAddorRemoveUsers.Controls.Add(this.btnRemoveUser);
            this.tabAddorRemoveUsers.Controls.Add(this.btnAddUser);
            this.tabAddorRemoveUsers.Controls.Add(this.txtEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.txtPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.cbRole);
            this.tabAddorRemoveUsers.Controls.Add(this.lblEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.lblPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.lblRole);
            this.tabAddorRemoveUsers.Controls.Add(this.lblCurrentPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.txtCurrentPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.lblNewPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.txtNewPassword);
            this.tabAddorRemoveUsers.Controls.Add(this.lblUpdateRole);
            this.tabAddorRemoveUsers.Controls.Add(this.cbUpdateRole);
            this.tabAddorRemoveUsers.Controls.Add(this.btnUpdateUser);
            this.tabAddorRemoveUsers.Controls.Add(this.lblNewEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.txtNewEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.btnSearchUser);
            this.tabAddorRemoveUsers.Controls.Add(this.lblCurrentEmail);
            this.tabAddorRemoveUsers.Controls.Add(this.lblUpdateProfile);
            this.tabAddorRemoveUsers.Controls.Add(this.txtSearchEmail);
            this.tabAddorRemoveUsers.Location = new System.Drawing.Point(4, 25);
            this.tabAddorRemoveUsers.Name = "tabAddorRemoveUsers";
            this.tabAddorRemoveUsers.Size = new System.Drawing.Size(630, 529);
            this.tabAddorRemoveUsers.TabIndex = 0;
            this.tabAddorRemoveUsers.Text = "Profile";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(244, 122);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 22);
            this.txtUsername.TabIndex = 72;
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(31, 120);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(198, 27);
            this.lblUsername.TabIndex = 71;
            this.lblUsername.Text = "Username:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 22);
            this.txtName.TabIndex = 70;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(244, 182);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(271, 22);
            this.txtPhoneNum.TabIndex = 69;
            // 
            // lblNameProfile
            // 
            this.lblNameProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProfile.Location = new System.Drawing.Point(31, 150);
            this.lblNameProfile.Name = "lblNameProfile";
            this.lblNameProfile.Size = new System.Drawing.Size(198, 27);
            this.lblNameProfile.TabIndex = 67;
            this.lblNameProfile.Text = "Name:";
            // 
            // lblPhoneNumProfile
            // 
            this.lblPhoneNumProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumProfile.Location = new System.Drawing.Point(31, 180);
            this.lblPhoneNumProfile.Name = "lblPhoneNumProfile";
            this.lblPhoneNumProfile.Size = new System.Drawing.Size(198, 27);
            this.lblPhoneNumProfile.TabIndex = 68;
            this.lblPhoneNumProfile.Text = "Telephone No.:";
            // 
            // lblAddorRemoveUsers
            // 
            this.lblAddorRemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddorRemoveUsers.Location = new System.Drawing.Point(26, 29);
            this.lblAddorRemoveUsers.Name = "lblAddorRemoveUsers";
            this.lblAddorRemoveUsers.Size = new System.Drawing.Size(492, 28);
            this.lblAddorRemoveUsers.TabIndex = 66;
            this.lblAddorRemoveUsers.Text = "Add/Remove Users";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Location = new System.Drawing.Point(381, 248);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(134, 24);
            this.btnRemoveUser.TabIndex = 65;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(244, 248);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(134, 24);
            this.btnAddUser.TabIndex = 63;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(244, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 22);
            this.txtEmail.TabIndex = 64;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(244, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 22);
            this.txtPassword.TabIndex = 60;
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "SystemAdmin",
            "Manager",
            "Chef",
            "Customer"});
            this.cbRole.Location = new System.Drawing.Point(244, 210);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(271, 24);
            this.cbRole.TabIndex = 61;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(198, 27);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(31, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(198, 27);
            this.lblPassword.TabIndex = 59;
            this.lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRole.Location = new System.Drawing.Point(31, 210);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(198, 27);
            this.lblRole.TabIndex = 62;
            this.lblRole.Text = "Role:";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(31, 390);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(207, 23);
            this.lblCurrentPassword.TabIndex = 44;
            this.lblCurrentPassword.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(264, 391);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(208, 22);
            this.txtCurrentPassword.TabIndex = 43;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(31, 420);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(198, 23);
            this.lblNewPassword.TabIndex = 42;
            this.lblNewPassword.Text = "New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(264, 421);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(208, 22);
            this.txtNewPassword.TabIndex = 41;
            // 
            // lblUpdateRole
            // 
            this.lblUpdateRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateRole.Location = new System.Drawing.Point(31, 450);
            this.lblUpdateRole.Name = "lblUpdateRole";
            this.lblUpdateRole.Size = new System.Drawing.Size(198, 23);
            this.lblUpdateRole.TabIndex = 40;
            this.lblUpdateRole.Text = "Change Role:";
            // 
            // cbUpdateRole
            // 
            this.cbUpdateRole.FormattingEnabled = true;
            this.cbUpdateRole.Items.AddRange(new object[] {
            "System Admin",
            "Manager",
            "Chef",
            "Customer"});
            this.cbUpdateRole.Location = new System.Drawing.Point(264, 450);
            this.cbUpdateRole.Name = "cbUpdateRole";
            this.cbUpdateRole.Size = new System.Drawing.Size(208, 24);
            this.cbUpdateRole.TabIndex = 39;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(478, 451);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 38;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblNewEmail
            // 
            this.lblNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmail.Location = new System.Drawing.Point(31, 360);
            this.lblNewEmail.Name = "lblNewEmail";
            this.lblNewEmail.Size = new System.Drawing.Size(198, 23);
            this.lblNewEmail.TabIndex = 37;
            this.lblNewEmail.Text = "New Email:";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(264, 360);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(208, 22);
            this.txtNewEmail.TabIndex = 36;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Location = new System.Drawing.Point(478, 327);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUser.TabIndex = 35;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEmail.Location = new System.Drawing.Point(31, 330);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(201, 23);
            this.lblCurrentEmail.TabIndex = 34;
            this.lblCurrentEmail.Text = "Search User Email:";
            // 
            // lblUpdateProfile
            // 
            this.lblUpdateProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblUpdateProfile.Location = new System.Drawing.Point(26, 288);
            this.lblUpdateProfile.Name = "lblUpdateProfile";
            this.lblUpdateProfile.Size = new System.Drawing.Size(472, 23);
            this.lblUpdateProfile.TabIndex = 33;
            this.lblUpdateProfile.Text = "Update User Profile or Update Your Profile";
            // 
            // txtSearchEmail
            // 
            this.txtSearchEmail.Location = new System.Drawing.Point(264, 328);
            this.txtSearchEmail.Name = "txtSearchEmail";
            this.txtSearchEmail.Size = new System.Drawing.Size(208, 22);
            this.txtSearchEmail.TabIndex = 32;
            // 
            // tabSalesReport
            // 
            this.tabSalesReport.BackColor = System.Drawing.Color.Moccasin;
            this.tabSalesReport.Controls.Add(this.lblTotalSales);
            this.tabSalesReport.Controls.Add(this.dgvSalesReport);
            this.tabSalesReport.Controls.Add(this.btnViewReport);
            this.tabSalesReport.Controls.Add(this.cbChef);
            this.tabSalesReport.Controls.Add(this.lblSelectChef);
            this.tabSalesReport.Controls.Add(this.cbCategory);
            this.tabSalesReport.Controls.Add(this.lblSelectCategory);
            this.tabSalesReport.Controls.Add(this.lblYear);
            this.tabSalesReport.Controls.Add(this.lblMonth);
            this.tabSalesReport.Controls.Add(this.cbYear);
            this.tabSalesReport.Controls.Add(this.cbMonth);
            this.tabSalesReport.Controls.Add(this.lblSelectDate);
            this.tabSalesReport.Controls.Add(this.lblSalesReport);
            this.tabSalesReport.Location = new System.Drawing.Point(4, 25);
            this.tabSalesReport.Name = "tabSalesReport";
            this.tabSalesReport.Size = new System.Drawing.Size(630, 529);
            this.tabSalesReport.TabIndex = 1;
            this.tabSalesReport.Text = "Sales Report";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.Location = new System.Drawing.Point(16, 488);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(438, 23);
            this.lblTotalSales.TabIndex = 15;
            this.lblTotalSales.Text = "Total Sales:";
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(32, 230);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowHeadersWidth = 51;
            this.dgvSalesReport.RowTemplate.Height = 24;
            this.dgvSalesReport.Size = new System.Drawing.Size(525, 238);
            this.dgvSalesReport.TabIndex = 14;
            // 
            // btnViewReport
            // 
            this.btnViewReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReport.Location = new System.Drawing.Point(404, 69);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(153, 154);
            this.btnViewReport.TabIndex = 13;
            this.btnViewReport.Text = "View Report";
            this.btnViewReport.UseVisualStyleBackColor = true;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // cbChef
            // 
            this.cbChef.FormattingEnabled = true;
            this.cbChef.Location = new System.Drawing.Point(190, 200);
            this.cbChef.Name = "cbChef";
            this.cbChef.Size = new System.Drawing.Size(208, 24);
            this.cbChef.TabIndex = 12;
            // 
            // lblSelectChef
            // 
            this.lblSelectChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectChef.Location = new System.Drawing.Point(16, 201);
            this.lblSelectChef.Name = "lblSelectChef";
            this.lblSelectChef.Size = new System.Drawing.Size(168, 23);
            this.lblSelectChef.TabIndex = 11;
            this.lblSelectChef.Text = "Select chef:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(190, 138);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(208, 24);
            this.cbCategory.TabIndex = 10;
            // 
            // lblSelectCategory
            // 
            this.lblSelectCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCategory.Location = new System.Drawing.Point(15, 139);
            this.lblSelectCategory.Name = "lblSelectCategory";
            this.lblSelectCategory.Size = new System.Drawing.Size(169, 23);
            this.lblSelectCategory.TabIndex = 9;
            this.lblSelectCategory.Text = "Select category:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(317, 97);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(81, 24);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(190, 98);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(118, 23);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(317, 70);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(81, 24);
            this.cbYear.TabIndex = 5;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(190, 71);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(121, 24);
            this.cbMonth.TabIndex = 4;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(19, 72);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(165, 23);
            this.lblSelectDate.TabIndex = 3;
            this.lblSelectDate.Text = "Select date:";
            // 
            // lblSalesReport
            // 
            this.lblSalesReport.BackColor = System.Drawing.Color.Moccasin;
            this.lblSalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesReport.Location = new System.Drawing.Point(14, 13);
            this.lblSalesReport.Name = "lblSalesReport";
            this.lblSalesReport.Size = new System.Drawing.Size(566, 23);
            this.lblSalesReport.TabIndex = 2;
            this.lblSalesReport.Text = "Sales Report";
            // 
            // tabEWallet
            // 
            this.tabEWallet.BackColor = System.Drawing.Color.Moccasin;
            this.tabEWallet.Controls.Add(this.lblTotalRefund);
            this.tabEWallet.Controls.Add(this.txtCustomerEmailEWallet);
            this.tabEWallet.Controls.Add(this.lblTotalSpent);
            this.tabEWallet.Controls.Add(this.lblTotalTopUps);
            this.tabEWallet.Controls.Add(this.dgvEWalletReport);
            this.tabEWallet.Controls.Add(this.btnViewEWalletReport);
            this.tabEWallet.Controls.Add(this.lblCustomerEmail);
            this.tabEWallet.Controls.Add(this.lblYearEWallet);
            this.tabEWallet.Controls.Add(this.lblMonthEWallet);
            this.tabEWallet.Controls.Add(this.cbEWalletYear);
            this.tabEWallet.Controls.Add(this.cbEWalletMonth);
            this.tabEWallet.Controls.Add(this.lblDate);
            this.tabEWallet.Controls.Add(this.lblEWallet);
            this.tabEWallet.Location = new System.Drawing.Point(4, 25);
            this.tabEWallet.Name = "tabEWallet";
            this.tabEWallet.Size = new System.Drawing.Size(630, 529);
            this.tabEWallet.TabIndex = 2;
            this.tabEWallet.Text = "E-Wallet";
            // 
            // lblTotalRefund
            // 
            this.lblTotalRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRefund.Location = new System.Drawing.Point(292, 493);
            this.lblTotalRefund.Name = "lblTotalRefund";
            this.lblTotalRefund.Size = new System.Drawing.Size(291, 23);
            this.lblTotalRefund.TabIndex = 29;
            this.lblTotalRefund.Text = "Total Refund:";
            // 
            // txtCustomerEmailEWallet
            // 
            this.txtCustomerEmailEWallet.Location = new System.Drawing.Point(191, 71);
            this.txtCustomerEmailEWallet.Name = "txtCustomerEmailEWallet";
            this.txtCustomerEmailEWallet.Size = new System.Drawing.Size(208, 22);
            this.txtCustomerEmailEWallet.TabIndex = 28;
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(289, 459);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(291, 23);
            this.lblTotalSpent.TabIndex = 27;
            this.lblTotalSpent.Text = "Total Spent:";
            // 
            // lblTotalTopUps
            // 
            this.lblTotalTopUps.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTopUps.Location = new System.Drawing.Point(20, 459);
            this.lblTotalTopUps.Name = "lblTotalTopUps";
            this.lblTotalTopUps.Size = new System.Drawing.Size(292, 23);
            this.lblTotalTopUps.TabIndex = 26;
            this.lblTotalTopUps.Text = "Total top-ups:";
            // 
            // dgvEWalletReport
            // 
            this.dgvEWalletReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEWalletReport.Location = new System.Drawing.Point(20, 184);
            this.dgvEWalletReport.Name = "dgvEWalletReport";
            this.dgvEWalletReport.RowHeadersWidth = 51;
            this.dgvEWalletReport.RowTemplate.Height = 24;
            this.dgvEWalletReport.Size = new System.Drawing.Size(538, 249);
            this.dgvEWalletReport.TabIndex = 25;
            // 
            // btnViewEWalletReport
            // 
            this.btnViewEWalletReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEWalletReport.Location = new System.Drawing.Point(405, 71);
            this.btnViewEWalletReport.Name = "btnViewEWalletReport";
            this.btnViewEWalletReport.Size = new System.Drawing.Size(153, 74);
            this.btnViewEWalletReport.TabIndex = 24;
            this.btnViewEWalletReport.Text = "View e-Wallet Report";
            this.btnViewEWalletReport.UseVisualStyleBackColor = true;
            this.btnViewEWalletReport.Click += new System.EventHandler(this.btnViewEWalletReport_Click);
            // 
            // lblCustomerEmail
            // 
            this.lblCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerEmail.Location = new System.Drawing.Point(16, 71);
            this.lblCustomerEmail.Name = "lblCustomerEmail";
            this.lblCustomerEmail.Size = new System.Drawing.Size(182, 23);
            this.lblCustomerEmail.TabIndex = 22;
            this.lblCustomerEmail.Text = "Customer Email:";
            // 
            // lblYearEWallet
            // 
            this.lblYearEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearEWallet.Location = new System.Drawing.Point(318, 147);
            this.lblYearEWallet.Name = "lblYearEWallet";
            this.lblYearEWallet.Size = new System.Drawing.Size(81, 24);
            this.lblYearEWallet.TabIndex = 19;
            this.lblYearEWallet.Text = "Year";
            this.lblYearEWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthEWallet
            // 
            this.lblMonthEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthEWallet.Location = new System.Drawing.Point(191, 148);
            this.lblMonthEWallet.Name = "lblMonthEWallet";
            this.lblMonthEWallet.Size = new System.Drawing.Size(118, 23);
            this.lblMonthEWallet.TabIndex = 18;
            this.lblMonthEWallet.Text = "Month";
            this.lblMonthEWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbEWalletYear
            // 
            this.cbEWalletYear.FormattingEnabled = true;
            this.cbEWalletYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025"});
            this.cbEWalletYear.Location = new System.Drawing.Point(318, 120);
            this.cbEWalletYear.Name = "cbEWalletYear";
            this.cbEWalletYear.Size = new System.Drawing.Size(81, 24);
            this.cbEWalletYear.TabIndex = 17;
            // 
            // cbEWalletMonth
            // 
            this.cbEWalletMonth.FormattingEnabled = true;
            this.cbEWalletMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cbEWalletMonth.Location = new System.Drawing.Point(191, 121);
            this.cbEWalletMonth.Name = "cbEWalletMonth";
            this.cbEWalletMonth.Size = new System.Drawing.Size(121, 24);
            this.cbEWalletMonth.TabIndex = 16;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(16, 122);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(169, 23);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Select date:";
            // 
            // lblEWallet
            // 
            this.lblEWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEWallet.Location = new System.Drawing.Point(15, 13);
            this.lblEWallet.Name = "lblEWallet";
            this.lblEWallet.Size = new System.Drawing.Size(149, 23);
            this.lblEWallet.TabIndex = 14;
            this.lblEWallet.Text = "e-Wallet Report";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(656, 577);
            this.Controls.Add(this.tabControlAdmin);
            this.Name = "AdminDashboardForm";
            this.Text = "AdminDashboardForm";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdmin)).EndInit();
            this.tabAddorRemoveUsers.ResumeLayout(false);
            this.tabAddorRemoveUsers.PerformLayout();
            this.tabSalesReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.tabEWallet.ResumeLayout(false);
            this.tabEWallet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEWalletReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabAddorRemoveUsers;
        private System.Windows.Forms.TabPage tabSalesReport;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblSalesReport;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.DataGridView dgvSalesReport;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.ComboBox cbChef;
        private System.Windows.Forms.Label lblSelectChef;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lblSelectCategory;
        private System.Windows.Forms.TabPage tabEWallet;
        private System.Windows.Forms.Button btnViewEWalletReport;
        private System.Windows.Forms.Label lblCustomerEmail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEWallet;
        private System.Windows.Forms.Label lblYearEWallet;
        private System.Windows.Forms.Label lblMonthEWallet;
        private System.Windows.Forms.ComboBox cbEWalletYear;
        private System.Windows.Forms.ComboBox cbEWalletMonth;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblTotalTopUps;
        private System.Windows.Forms.DataGridView dgvEWalletReport;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.PictureBox pictureBoxAdmin;
        private System.Windows.Forms.Button btnExitAdmin;
        private System.Windows.Forms.TextBox txtCustomerEmailEWallet;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblUpdateRole;
        private System.Windows.Forms.ComboBox cbUpdateRole;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label lblNewEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.Label lblUpdateProfile;
        private System.Windows.Forms.TextBox txtSearchEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblNameProfile;
        private System.Windows.Forms.Label lblPhoneNumProfile;
        private System.Windows.Forms.Label lblAddorRemoveUsers;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblTotalRefund;
    }
}