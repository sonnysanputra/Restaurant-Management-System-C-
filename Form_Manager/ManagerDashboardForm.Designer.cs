namespace Assignment
{
    partial class ManagerDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerDashboardForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblManager = new System.Windows.Forms.Label();
            this.btnReviewfeedback = new System.Windows.Forms.Button();
            this.btnTopup = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblMainmenu = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnManagerback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblManager.ForeColor = System.Drawing.Color.Sienna;
            this.lblManager.Location = new System.Drawing.Point(235, 49);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(120, 31);
            this.lblManager.TabIndex = 1;
            this.lblManager.Text = "Manager";
            // 
            // btnReviewfeedback
            // 
            this.btnReviewfeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReviewfeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReviewfeedback.ForeColor = System.Drawing.Color.Sienna;
            this.btnReviewfeedback.Location = new System.Drawing.Point(202, 147);
            this.btnReviewfeedback.Name = "btnReviewfeedback";
            this.btnReviewfeedback.Size = new System.Drawing.Size(188, 39);
            this.btnReviewfeedback.TabIndex = 2;
            this.btnReviewfeedback.Text = "Review Feedback";
            this.btnReviewfeedback.UseVisualStyleBackColor = true;
            this.btnReviewfeedback.Click += new System.EventHandler(this.BtnOpenReviewfeedback_Click);
            // 
            // btnTopup
            // 
            this.btnTopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTopup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTopup.ForeColor = System.Drawing.Color.Sienna;
            this.btnTopup.Location = new System.Drawing.Point(203, 204);
            this.btnTopup.Name = "btnTopup";
            this.btnTopup.Size = new System.Drawing.Size(188, 39);
            this.btnTopup.TabIndex = 3;
            this.btnTopup.Text = "Top-Up Portal";
            this.btnTopup.UseVisualStyleBackColor = true;
            this.btnTopup.Click += new System.EventHandler(this.BtnTopup_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRefund.ForeColor = System.Drawing.Color.Sienna;
            this.btnRefund.Location = new System.Drawing.Point(203, 264);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(190, 39);
            this.btnRefund.TabIndex = 4;
            this.btnRefund.Text = "Refund Requests";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.BtnOpenRefundRequest_Click);
            // 
            // lblMainmenu
            // 
            this.lblMainmenu.AutoSize = true;
            this.lblMainmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMainmenu.ForeColor = System.Drawing.Color.Sienna;
            this.lblMainmenu.Location = new System.Drawing.Point(240, 80);
            this.lblMainmenu.Name = "lblMainmenu";
            this.lblMainmenu.Size = new System.Drawing.Size(110, 25);
            this.lblMainmenu.TabIndex = 5;
            this.lblMainmenu.Text = "Main Menu";
            // 
            // btnProfile
            // 
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnProfile.ForeColor = System.Drawing.Color.Sienna;
            this.btnProfile.Location = new System.Drawing.Point(203, 321);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(190, 39);
            this.btnProfile.TabIndex = 6;
            this.btnProfile.Text = "Profile Settings";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.BtnProfileupdate_click);
            // 
            // btnManagerback
            // 
            this.btnManagerback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManagerback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManagerback.ForeColor = System.Drawing.Color.Sienna;
            this.btnManagerback.Location = new System.Drawing.Point(12, 358);
            this.btnManagerback.Name = "btnManagerback";
            this.btnManagerback.Size = new System.Drawing.Size(75, 23);
            this.btnManagerback.TabIndex = 26;
            this.btnManagerback.Text = "Back";
            this.btnManagerback.UseVisualStyleBackColor = true;
            this.btnManagerback.Click += new System.EventHandler(this.BtnManagerback_Click);
            // 
            // ManagerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.btnManagerback);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.lblMainmenu);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnTopup);
            this.Controls.Add(this.btnReviewfeedback);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerDashboardForm";
            this.Text = "ManagerDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnReviewfeedback;
        private System.Windows.Forms.Button btnTopup;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblMainmenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnManagerback;
    }
}