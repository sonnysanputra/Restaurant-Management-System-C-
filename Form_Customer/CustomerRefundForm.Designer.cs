namespace Assignment
{
    partial class CustomerRefundForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerRefundForm));
            this.tabCntrlRefund = new System.Windows.Forms.TabControl();
            this.tabRequestRefund = new System.Windows.Forms.TabPage();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnRequestRefund = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.dgvCompletedOrders = new System.Windows.Forms.DataGridView();
            this.tabRefundStatus = new System.Windows.Forms.TabPage();
            this.btnRefreshRefunds = new System.Windows.Forms.Button();
            this.dgvRefundStatus = new System.Windows.Forms.DataGridView();
            this.lbRefundStatus = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabCntrlRefund.SuspendLayout();
            this.tabRequestRefund.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedOrders)).BeginInit();
            this.tabRefundStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCntrlRefund
            // 
            this.tabCntrlRefund.Controls.Add(this.tabRequestRefund);
            this.tabCntrlRefund.Controls.Add(this.tabRefundStatus);
            this.tabCntrlRefund.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCntrlRefund.Location = new System.Drawing.Point(8, 89);
            this.tabCntrlRefund.Margin = new System.Windows.Forms.Padding(2);
            this.tabCntrlRefund.Name = "tabCntrlRefund";
            this.tabCntrlRefund.SelectedIndex = 0;
            this.tabCntrlRefund.Size = new System.Drawing.Size(819, 468);
            this.tabCntrlRefund.TabIndex = 16;
            // 
            // tabRequestRefund
            // 
            this.tabRequestRefund.Controls.Add(this.lblReason);
            this.tabRequestRefund.Controls.Add(this.btnRequestRefund);
            this.tabRequestRefund.Controls.Add(this.txtReason);
            this.tabRequestRefund.Controls.Add(this.dgvCompletedOrders);
            this.tabRequestRefund.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRequestRefund.Location = new System.Drawing.Point(4, 32);
            this.tabRequestRefund.Margin = new System.Windows.Forms.Padding(2);
            this.tabRequestRefund.Name = "tabRequestRefund";
            this.tabRequestRefund.Padding = new System.Windows.Forms.Padding(2);
            this.tabRequestRefund.Size = new System.Drawing.Size(811, 432);
            this.tabRequestRefund.TabIndex = 0;
            this.tabRequestRefund.Text = "Request Refund";
            this.tabRequestRefund.UseVisualStyleBackColor = true;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReason.Location = new System.Drawing.Point(5, 277);
            this.lblReason.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(78, 28);
            this.lblReason.TabIndex = 6;
            this.lblReason.Text = "Reason:";
            // 
            // btnRequestRefund
            // 
            this.btnRequestRefund.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.btnRequestRefund.Location = new System.Drawing.Point(633, 330);
            this.btnRequestRefund.Margin = new System.Windows.Forms.Padding(2);
            this.btnRequestRefund.Name = "btnRequestRefund";
            this.btnRequestRefund.Size = new System.Drawing.Size(143, 44);
            this.btnRequestRefund.TabIndex = 5;
            this.btnRequestRefund.Text = "Request Refund";
            this.btnRequestRefund.UseVisualStyleBackColor = true;
            this.btnRequestRefund.Click += new System.EventHandler(this.btnRequestRefund_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(11, 308);
            this.txtReason.Margin = new System.Windows.Forms.Padding(2);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(590, 101);
            this.txtReason.TabIndex = 4;
            // 
            // dgvCompletedOrders
            // 
            this.dgvCompletedOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompletedOrders.Location = new System.Drawing.Point(11, 13);
            this.dgvCompletedOrders.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCompletedOrders.Name = "dgvCompletedOrders";
            this.dgvCompletedOrders.RowHeadersWidth = 82;
            this.dgvCompletedOrders.RowTemplate.Height = 33;
            this.dgvCompletedOrders.Size = new System.Drawing.Size(785, 255);
            this.dgvCompletedOrders.TabIndex = 3;
            // 
            // tabRefundStatus
            // 
            this.tabRefundStatus.Controls.Add(this.btnRefreshRefunds);
            this.tabRefundStatus.Controls.Add(this.dgvRefundStatus);
            this.tabRefundStatus.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRefundStatus.Location = new System.Drawing.Point(4, 32);
            this.tabRefundStatus.Margin = new System.Windows.Forms.Padding(2);
            this.tabRefundStatus.Name = "tabRefundStatus";
            this.tabRefundStatus.Padding = new System.Windows.Forms.Padding(2);
            this.tabRefundStatus.Size = new System.Drawing.Size(811, 432);
            this.tabRefundStatus.TabIndex = 1;
            this.tabRefundStatus.Text = "View Refund Status";
            this.tabRefundStatus.UseVisualStyleBackColor = true;
            // 
            // btnRefreshRefunds
            // 
            this.btnRefreshRefunds.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.btnRefreshRefunds.Location = new System.Drawing.Point(645, 375);
            this.btnRefreshRefunds.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshRefunds.Name = "btnRefreshRefunds";
            this.btnRefreshRefunds.Size = new System.Drawing.Size(143, 48);
            this.btnRefreshRefunds.TabIndex = 5;
            this.btnRefreshRefunds.Text = "Refresh Refunds";
            this.btnRefreshRefunds.UseVisualStyleBackColor = true;
            this.btnRefreshRefunds.Click += new System.EventHandler(this.btnRefreshRefunds_Click);
            // 
            // dgvRefundStatus
            // 
            this.dgvRefundStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRefundStatus.Location = new System.Drawing.Point(13, 12);
            this.dgvRefundStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRefundStatus.Name = "dgvRefundStatus";
            this.dgvRefundStatus.RowHeadersWidth = 82;
            this.dgvRefundStatus.RowTemplate.Height = 33;
            this.dgvRefundStatus.Size = new System.Drawing.Size(777, 348);
            this.dgvRefundStatus.TabIndex = 4;
            // 
            // lbRefundStatus
            // 
            this.lbRefundStatus.AutoSize = true;
            this.lbRefundStatus.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRefundStatus.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbRefundStatus.Location = new System.Drawing.Point(269, 17);
            this.lbRefundStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRefundStatus.Name = "lbRefundStatus";
            this.lbRefundStatus.Size = new System.Drawing.Size(262, 50);
            this.lbRefundStatus.TabIndex = 14;
            this.lbRefundStatus.Text = "Refund Status";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.btnClose.Location = new System.Drawing.Point(775, 577);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(8, 8);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(65, 59);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 15;
            this.picLogo.TabStop = false;
            // 
            // CustomerRefundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(861, 623);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabCntrlRefund);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lbRefundStatus);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerRefundForm";
            this.Text = "CustomerRefundForm";
            this.Load += new System.EventHandler(this.CustomerRefundForm_Load);
            this.tabCntrlRefund.ResumeLayout(false);
            this.tabRequestRefund.ResumeLayout(false);
            this.tabRequestRefund.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedOrders)).EndInit();
            this.tabRefundStatus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRefundStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCntrlRefund;
        private System.Windows.Forms.TabPage tabRequestRefund;
        private System.Windows.Forms.TabPage tabRefundStatus;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lbRefundStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvCompletedOrders;
        private System.Windows.Forms.DataGridView dgvRefundStatus;
        private System.Windows.Forms.Button btnRequestRefund;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button btnRefreshRefunds;
    }
}