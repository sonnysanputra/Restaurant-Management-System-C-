namespace Assignment
{
    partial class ChefOrdersForm
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
            this.lblOrders = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picOrders = new System.Windows.Forms.PictureBox();
            this.tabControlOrders = new System.Windows.Forms.TabControl();
            this.tabInProgress = new System.Windows.Forms.TabPage();
            this.dgvInProgress = new System.Windows.Forms.DataGridView();
            this.picTick = new System.Windows.Forms.PictureBox();
            this.btnComplete = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.tabCompleted = new System.Windows.Forms.TabPage();
            this.lblRevertFeedback = new System.Windows.Forms.Label();
            this.btnRevert = new System.Windows.Forms.Button();
            this.dgvCompleted = new System.Windows.Forms.DataGridView();
            this.feedbackTimer = new System.Windows.Forms.Timer(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).BeginInit();
            this.tabControlOrders.SuspendLayout();
            this.tabInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).BeginInit();
            this.tabCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOrders.Location = new System.Drawing.Point(370, 27);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(94, 35);
            this.lblOrders.TabIndex = 0;
            this.lblOrders.Text = "Orders";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Assignment.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(56, 50);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // picOrders
            // 
            this.picOrders.Image = global::Assignment.Properties.Resources.orders;
            this.picOrders.Location = new System.Drawing.Point(470, 27);
            this.picOrders.Name = "picOrders";
            this.picOrders.Size = new System.Drawing.Size(50, 50);
            this.picOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOrders.TabIndex = 9;
            this.picOrders.TabStop = false;
            // 
            // tabControlOrders
            // 
            this.tabControlOrders.Controls.Add(this.tabInProgress);
            this.tabControlOrders.Controls.Add(this.tabCompleted);
            this.tabControlOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tabControlOrders.Location = new System.Drawing.Point(57, 92);
            this.tabControlOrders.Name = "tabControlOrders";
            this.tabControlOrders.SelectedIndex = 0;
            this.tabControlOrders.Size = new System.Drawing.Size(698, 437);
            this.tabControlOrders.TabIndex = 10;
            this.tabControlOrders.SelectedIndexChanged += new System.EventHandler(this.TabControlOrders_SelectedIndexChanged);
            // 
            // tabInProgress
            // 
            this.tabInProgress.BackColor = System.Drawing.Color.White;
            this.tabInProgress.Controls.Add(this.dgvInProgress);
            this.tabInProgress.Controls.Add(this.picTick);
            this.tabInProgress.Controls.Add(this.btnComplete);
            this.tabInProgress.Controls.Add(this.lblFeedback);
            this.tabInProgress.Location = new System.Drawing.Point(4, 29);
            this.tabInProgress.Name = "tabInProgress";
            this.tabInProgress.Padding = new System.Windows.Forms.Padding(3);
            this.tabInProgress.Size = new System.Drawing.Size(690, 404);
            this.tabInProgress.TabIndex = 0;
            this.tabInProgress.Text = "In Progress Orders";
            // 
            // dgvInProgress
            // 
            this.dgvInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgress.Location = new System.Drawing.Point(7, 7);
            this.dgvInProgress.Name = "dgvInProgress";
            this.dgvInProgress.RowHeadersWidth = 51;
            this.dgvInProgress.RowTemplate.Height = 24;
            this.dgvInProgress.Size = new System.Drawing.Size(677, 331);
            this.dgvInProgress.TabIndex = 12;
            // 
            // picTick
            // 
            this.picTick.Image = global::Assignment.Properties.Resources.WhatsApp_Image_2025_05_09_at_4_53_38_PM;
            this.picTick.Location = new System.Drawing.Point(486, 344);
            this.picTick.Name = "picTick";
            this.picTick.Size = new System.Drawing.Size(27, 30);
            this.picTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTick.TabIndex = 10;
            this.picTick.TabStop = false;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(227, 344);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(232, 30);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Mark As Completed";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblFeedback.Location = new System.Drawing.Point(262, 377);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblFeedback.TabIndex = 11;
            // 
            // tabCompleted
            // 
            this.tabCompleted.Controls.Add(this.lblRevertFeedback);
            this.tabCompleted.Controls.Add(this.btnRevert);
            this.tabCompleted.Controls.Add(this.dgvCompleted);
            this.tabCompleted.Location = new System.Drawing.Point(4, 29);
            this.tabCompleted.Name = "tabCompleted";
            this.tabCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompleted.Size = new System.Drawing.Size(690, 404);
            this.tabCompleted.TabIndex = 1;
            this.tabCompleted.Text = "Completed Orders";
            this.tabCompleted.UseVisualStyleBackColor = true;
            // 
            // lblRevertFeedback
            // 
            this.lblRevertFeedback.AutoSize = true;
            this.lblRevertFeedback.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblRevertFeedback.ForeColor = System.Drawing.Color.Green;
            this.lblRevertFeedback.Location = new System.Drawing.Point(272, 376);
            this.lblRevertFeedback.Name = "lblRevertFeedback";
            this.lblRevertFeedback.Size = new System.Drawing.Size(0, 15);
            this.lblRevertFeedback.TabIndex = 16;
            // 
            // btnRevert
            // 
            this.btnRevert.Location = new System.Drawing.Point(275, 343);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(157, 30);
            this.btnRevert.TabIndex = 14;
            this.btnRevert.Text = "Revert";
            this.btnRevert.UseVisualStyleBackColor = true;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // dgvCompleted
            // 
            this.dgvCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompleted.Location = new System.Drawing.Point(6, 6);
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.RowHeadersWidth = 51;
            this.dgvCompleted.RowTemplate.Height = 24;
            this.dgvCompleted.Size = new System.Drawing.Size(678, 331);
            this.dgvCompleted.TabIndex = 13;
            // 
            // feedbackTimer
            // 
            this.feedbackTimer.Interval = 3000;
            this.feedbackTimer.Tick += new System.EventHandler(this.feedbackTimer_Tick_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 7.8F);
            this.btnClose.Location = new System.Drawing.Point(712, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ChefOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(815, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControlOrders);
            this.Controls.Add(this.picOrders);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblOrders);
            this.Name = "ChefOrdersForm";
            this.Text = "ChefOrdersForm";
            this.Load += new System.EventHandler(this.ChefOrdersForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrders)).EndInit();
            this.tabControlOrders.ResumeLayout(false);
            this.tabInProgress.ResumeLayout(false);
            this.tabInProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTick)).EndInit();
            this.tabCompleted.ResumeLayout(false);
            this.tabCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picOrders;
        private System.Windows.Forms.TabControl tabControlOrders;
        private System.Windows.Forms.TabPage tabInProgress;
        private System.Windows.Forms.TabPage tabCompleted;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.PictureBox picTick;
        private System.Windows.Forms.DataGridView dgvInProgress;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Timer feedbackTimer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblRevertFeedback;
    }
}