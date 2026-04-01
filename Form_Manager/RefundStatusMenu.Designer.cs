namespace Assignment
{
    partial class RefundStatusMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RefundStatusMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlRefunds = new System.Windows.Forms.TabControl();
            this.tabPageIncomingRequests = new System.Windows.Forms.TabPage();
            this.btnViewDetailIncoming = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dgvIncomingRequests = new System.Windows.Forms.DataGridView();
            this.tabRefundRecords = new System.Windows.Forms.TabPage();
            this.btnViewDetailRecords = new System.Windows.Forms.Button();
            this.dgvRefundRecords = new System.Windows.Forms.DataGridView();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlRefunds.SuspendLayout();
            this.tabPageIncomingRequests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequests)).BeginInit();
            this.tabRefundRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 31.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(287, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refund Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // tabControlRefunds
            // 
            this.tabControlRefunds.Controls.Add(this.tabPageIncomingRequests);
            this.tabControlRefunds.Controls.Add(this.tabRefundRecords);
            this.tabControlRefunds.Location = new System.Drawing.Point(96, 106);
            this.tabControlRefunds.Name = "tabControlRefunds";
            this.tabControlRefunds.SelectedIndex = 0;
            this.tabControlRefunds.Size = new System.Drawing.Size(662, 513);
            this.tabControlRefunds.TabIndex = 13;
            // 
            // tabPageIncomingRequests
            // 
            this.tabPageIncomingRequests.Controls.Add(this.btnViewDetailIncoming);
            this.tabPageIncomingRequests.Controls.Add(this.btnReject);
            this.tabPageIncomingRequests.Controls.Add(this.btnApprove);
            this.tabPageIncomingRequests.Controls.Add(this.dgvIncomingRequests);
            this.tabPageIncomingRequests.Location = new System.Drawing.Point(4, 25);
            this.tabPageIncomingRequests.Name = "tabPageIncomingRequests";
            this.tabPageIncomingRequests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIncomingRequests.Size = new System.Drawing.Size(654, 484);
            this.tabPageIncomingRequests.TabIndex = 0;
            this.tabPageIncomingRequests.Text = "Incoming Requests";
            this.tabPageIncomingRequests.UseVisualStyleBackColor = true;
            // 
            // btnViewDetailIncoming
            // 
            this.btnViewDetailIncoming.Location = new System.Drawing.Point(6, 455);
            this.btnViewDetailIncoming.Name = "btnViewDetailIncoming";
            this.btnViewDetailIncoming.Size = new System.Drawing.Size(100, 23);
            this.btnViewDetailIncoming.TabIndex = 3;
            this.btnViewDetailIncoming.Text = "View Detail";
            this.btnViewDetailIncoming.UseVisualStyleBackColor = true;
            // 
            // btnReject
            // 
            this.btnReject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReject.Location = new System.Drawing.Point(484, 455);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(79, 23);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Location = new System.Drawing.Point(569, 455);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(79, 23);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // dgvIncomingRequests
            // 
            this.dgvIncomingRequests.AllowUserToAddRows = false;
            this.dgvIncomingRequests.AllowUserToDeleteRows = false;
            this.dgvIncomingRequests.AllowUserToOrderColumns = true;
            this.dgvIncomingRequests.AllowUserToResizeColumns = false;
            this.dgvIncomingRequests.AllowUserToResizeRows = false;
            this.dgvIncomingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncomingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncomingRequests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncomingRequests.Location = new System.Drawing.Point(3, 3);
            this.dgvIncomingRequests.Name = "dgvIncomingRequests";
            this.dgvIncomingRequests.ReadOnly = true;
            this.dgvIncomingRequests.RowTemplate.Height = 24;
            this.dgvIncomingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIncomingRequests.Size = new System.Drawing.Size(648, 478);
            this.dgvIncomingRequests.TabIndex = 0;
            // 
            // tabRefundRecords
            // 
            this.tabRefundRecords.Controls.Add(this.btnViewDetailRecords);
            this.tabRefundRecords.Controls.Add(this.dgvRefundRecords);
            this.tabRefundRecords.Location = new System.Drawing.Point(4, 25);
            this.tabRefundRecords.Name = "tabRefundRecords";
            this.tabRefundRecords.Padding = new System.Windows.Forms.Padding(3);
            this.tabRefundRecords.Size = new System.Drawing.Size(654, 484);
            this.tabRefundRecords.TabIndex = 1;
            this.tabRefundRecords.Text = "Refund Records";
            this.tabRefundRecords.UseVisualStyleBackColor = true;
            // 
            // btnViewDetailRecords
            // 
            this.btnViewDetailRecords.Location = new System.Drawing.Point(6, 455);
            this.btnViewDetailRecords.Name = "btnViewDetailRecords";
            this.btnViewDetailRecords.Size = new System.Drawing.Size(100, 23);
            this.btnViewDetailRecords.TabIndex = 4;
            this.btnViewDetailRecords.Text = "View Detail";
            this.btnViewDetailRecords.UseVisualStyleBackColor = true;
            // 
            // dgvRefundRecords
            // 
            this.dgvRefundRecords.AllowUserToAddRows = false;
            this.dgvRefundRecords.AllowUserToDeleteRows = false;
            this.dgvRefundRecords.AllowUserToOrderColumns = true;
            this.dgvRefundRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRefundRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRefundRecords.Location = new System.Drawing.Point(3, 3);
            this.dgvRefundRecords.Name = "dgvRefundRecords";
            this.dgvRefundRecords.ReadOnly = true;
            this.dgvRefundRecords.RowTemplate.Height = 24;
            this.dgvRefundRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRefundRecords.Size = new System.Drawing.Size(648, 478);
            this.dgvRefundRecords.TabIndex = 0;
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.Sienna;
            this.BtnBack.Location = new System.Drawing.Point(13, 639);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 30;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // RefundStatusMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(845, 680);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.tabControlRefunds);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RefundStatusMenu";
            this.Text = "RefundOrderMenu";
            this.Load += new System.EventHandler(this.RefundStatusMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlRefunds.ResumeLayout(false);
            this.tabPageIncomingRequests.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncomingRequests)).EndInit();
            this.tabRefundRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControlRefunds;
        private System.Windows.Forms.TabPage tabPageIncomingRequests;
        private System.Windows.Forms.TabPage tabRefundRecords;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView dgvIncomingRequests;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnViewDetailIncoming;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnViewDetailRecords;
        private System.Windows.Forms.DataGridView dgvRefundRecords;
    }
}