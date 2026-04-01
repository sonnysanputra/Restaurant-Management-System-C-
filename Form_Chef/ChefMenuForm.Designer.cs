namespace Assignment
{
    partial class ChefMenuForm
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.grpUpdateMenu = new System.Windows.Forms.GroupBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rdoBtnUpdate = new System.Windows.Forms.RadioButton();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.chckAvailable = new System.Windows.Forms.CheckBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDishName = new System.Windows.Forms.Label();
            this.rdoBtnRemove = new System.Windows.Forms.RadioButton();
            this.rdoBtnAdd = new System.Windows.Forms.RadioButton();
            this.grpMenuList = new System.Windows.Forms.GroupBox();
            this.lstMenuList = new System.Windows.Forms.ListBox();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.picViewMenu = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpUpdateMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            this.grpMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViewMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHeader.Location = new System.Drawing.Point(313, 27);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(149, 35);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Main Menu";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpUpdateMenu
            // 
            this.grpUpdateMenu.Controls.Add(this.cmbCategory);
            this.grpUpdateMenu.Controls.Add(this.rdoBtnUpdate);
            this.grpUpdateMenu.Controls.Add(this.lblCategory);
            this.grpUpdateMenu.Controls.Add(this.lblFeedback);
            this.grpUpdateMenu.Controls.Add(this.picTick);
            this.grpUpdateMenu.Controls.Add(this.btnConfirm);
            this.grpUpdateMenu.Controls.Add(this.txtDishName);
            this.grpUpdateMenu.Controls.Add(this.txtPrice);
            this.grpUpdateMenu.Controls.Add(this.chckAvailable);
            this.grpUpdateMenu.Controls.Add(this.lblAvailability);
            this.grpUpdateMenu.Controls.Add(this.lblPrice);
            this.grpUpdateMenu.Controls.Add(this.lblDishName);
            this.grpUpdateMenu.Controls.Add(this.rdoBtnRemove);
            this.grpUpdateMenu.Controls.Add(this.rdoBtnAdd);
            this.grpUpdateMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpUpdateMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpUpdateMenu.Location = new System.Drawing.Point(468, 119);
            this.grpUpdateMenu.Name = "grpUpdateMenu";
            this.grpUpdateMenu.Size = new System.Drawing.Size(324, 297);
            this.grpUpdateMenu.TabIndex = 9;
            this.grpUpdateMenu.TabStop = false;
            this.grpUpdateMenu.Text = "Update Menu:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Vegetarian",
            "Italian",
            "Mexican",
            "Drinks"});
            this.cmbCategory.Location = new System.Drawing.Point(161, 104);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(140, 25);
            this.cmbCategory.TabIndex = 13;
            // 
            // rdoBtnUpdate
            // 
            this.rdoBtnUpdate.AutoSize = true;
            this.rdoBtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rdoBtnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoBtnUpdate.Location = new System.Drawing.Point(206, 32);
            this.rdoBtnUpdate.Name = "rdoBtnUpdate";
            this.rdoBtnUpdate.Size = new System.Drawing.Size(81, 24);
            this.rdoBtnUpdate.TabIndex = 13;
            this.rdoBtnUpdate.TabStop = true;
            this.rdoBtnUpdate.Text = "Update";
            this.rdoBtnUpdate.UseVisualStyleBackColor = true;
            this.rdoBtnUpdate.CheckedChanged += new System.EventHandler(this.rdoBtnUpdate_CheckedChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCategory.Location = new System.Drawing.Point(69, 110);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Category:";
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblFeedback.Location = new System.Drawing.Point(58, 254);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(203, 15);
            this.lblFeedback.TabIndex = 10;
            this.lblFeedback.Text = "✔ Dish changes applied successfully!";
            this.lblFeedback.Visible = false;
            // 
            // picTick
            // 
            this.picTick.Image = global::Assignment.Properties.Resources.WhatsApp_Image_2025_05_09_at_4_53_38_PM;
            this.picTick.Location = new System.Drawing.Point(206, 216);
            this.picTick.Name = "picTick";
            this.picTick.Size = new System.Drawing.Size(41, 35);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTick.TabIndex = 9;
            this.picTick.TabStop = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirm.Location = new System.Drawing.Point(90, 216);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 35);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtDishName
            // 
            this.txtDishName.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtDishName.Location = new System.Drawing.Point(161, 69);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(140, 25);
            this.txtDishName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtPrice.Location = new System.Drawing.Point(161, 141);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 25);
            this.txtPrice.TabIndex = 6;
            // 
            // chckAvailable
            // 
            this.chckAvailable.AutoSize = true;
            this.chckAvailable.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chckAvailable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chckAvailable.Location = new System.Drawing.Point(165, 187);
            this.chckAvailable.Name = "chckAvailable";
            this.chckAvailable.Size = new System.Drawing.Size(85, 23);
            this.chckAvailable.TabIndex = 5;
            this.chckAvailable.Text = "Available";
            this.chckAvailable.UseVisualStyleBackColor = true;
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAvailability.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAvailability.Location = new System.Drawing.Point(73, 187);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(86, 20);
            this.lblAvailability.TabIndex = 4;
            this.lblAvailability.Text = "Availability:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(69, 146);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(80, 20);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price (RM):";
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDishName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDishName.Location = new System.Drawing.Point(67, 74);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(85, 20);
            this.lblDishName.TabIndex = 2;
            this.lblDishName.Text = "Dish Name:";
            // 
            // rdoBtnRemove
            // 
            this.rdoBtnRemove.AutoSize = true;
            this.rdoBtnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rdoBtnRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoBtnRemove.Location = new System.Drawing.Point(113, 32);
            this.rdoBtnRemove.Name = "rdoBtnRemove";
            this.rdoBtnRemove.Size = new System.Drawing.Size(87, 24);
            this.rdoBtnRemove.TabIndex = 1;
            this.rdoBtnRemove.TabStop = true;
            this.rdoBtnRemove.Text = "Remove";
            this.rdoBtnRemove.UseVisualStyleBackColor = true;
            // 
            // rdoBtnAdd
            // 
            this.rdoBtnAdd.AutoSize = true;
            this.rdoBtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.rdoBtnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoBtnAdd.Location = new System.Drawing.Point(44, 32);
            this.rdoBtnAdd.Name = "rdoBtnAdd";
            this.rdoBtnAdd.Size = new System.Drawing.Size(59, 24);
            this.rdoBtnAdd.TabIndex = 0;
            this.rdoBtnAdd.TabStop = true;
            this.rdoBtnAdd.Text = "Add";
            this.rdoBtnAdd.UseVisualStyleBackColor = true;
            this.rdoBtnAdd.CheckedChanged += new System.EventHandler(this.rdoBtnAdd_CheckedChanged_1);
            // 
            // grpMenuList
            // 
            this.grpMenuList.Controls.Add(this.lstMenuList);
            this.grpMenuList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMenuList.ForeColor = System.Drawing.Color.DarkOrange;
            this.grpMenuList.Location = new System.Drawing.Point(12, 119);
            this.grpMenuList.Name = "grpMenuList";
            this.grpMenuList.Size = new System.Drawing.Size(441, 430);
            this.grpMenuList.TabIndex = 11;
            this.grpMenuList.TabStop = false;
            this.grpMenuList.Text = "Menu List:";
            // 
            // lstMenuList
            // 
            this.lstMenuList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstMenuList.FormattingEnabled = true;
            this.lstMenuList.ItemHeight = 20;
            this.lstMenuList.Location = new System.Drawing.Point(16, 32);
            this.lstMenuList.Name = "lstMenuList";
            this.lstMenuList.Size = new System.Drawing.Size(398, 384);
            this.lstMenuList.TabIndex = 0;
            this.lstMenuList.SelectedIndexChanged += new System.EventHandler(this.lstMenuList_SelectedIndexChanged);
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 3000;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick);
            // 
            // picViewMenu
            // 
            this.picViewMenu.Image = global::Assignment.Properties.Resources.menu;
            this.picViewMenu.Location = new System.Drawing.Point(471, 27);
            this.picViewMenu.Name = "picViewMenu";
            this.picViewMenu.Size = new System.Drawing.Size(53, 47);
            this.picViewMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picViewMenu.TabIndex = 10;
            this.picViewMenu.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Assignment.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnClose.Location = new System.Drawing.Point(712, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 30);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChefMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(815, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpMenuList);
            this.Controls.Add(this.picViewMenu);
            this.Controls.Add(this.grpUpdateMenu);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblHeader);
            this.Name = "ChefMenuForm";
            this.Text = "ChefMenuForm";
            this.grpUpdateMenu.ResumeLayout(false);
            this.grpUpdateMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            this.grpMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picViewMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grpUpdateMenu;
        private System.Windows.Forms.RadioButton rdoBtnRemove;
        private System.Windows.Forms.RadioButton rdoBtnAdd;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.CheckBox chckAvailable;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox picViewMenu;
        private System.Windows.Forms.GroupBox grpMenuList;
        private System.Windows.Forms.ListBox lstMenuList;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.RadioButton rdoBtnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}