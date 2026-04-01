namespace Assignment
{
    partial class ReplyFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplyFeedback));
            this.LblReviewFeedback = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PictureBoxSedapRasaRF = new System.Windows.Forms.PictureBox();
            this.LblCustomerName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblOriginalFeedback = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.feedbackExcerptTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSedapRasaRF)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblReviewFeedback
            // 
            this.LblReviewFeedback.AutoSize = true;
            this.LblReviewFeedback.BackColor = System.Drawing.Color.Transparent;
            this.LblReviewFeedback.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReviewFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblReviewFeedback.Location = new System.Drawing.Point(185, 15);
            this.LblReviewFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReviewFeedback.Name = "LblReviewFeedback";
            this.LblReviewFeedback.Size = new System.Drawing.Size(376, 66);
            this.LblReviewFeedback.TabIndex = 35;
            this.LblReviewFeedback.Text = "Reply Feedback";
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.Sienna;
            this.BtnBack.Location = new System.Drawing.Point(29, 604);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 34;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // PictureBoxSedapRasaRF
            // 
            this.PictureBoxSedapRasaRF.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSedapRasaRF.Image")));
            this.PictureBoxSedapRasaRF.Location = new System.Drawing.Point(29, 15);
            this.PictureBoxSedapRasaRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxSedapRasaRF.Name = "PictureBoxSedapRasaRF";
            this.PictureBoxSedapRasaRF.Size = new System.Drawing.Size(80, 78);
            this.PictureBoxSedapRasaRF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSedapRasaRF.TabIndex = 32;
            this.PictureBoxSedapRasaRF.TabStop = false;
            // 
            // LblCustomerName
            // 
            this.LblCustomerName.AutoSize = true;
            this.LblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomerName.Location = new System.Drawing.Point(4, 0);
            this.LblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerName.Name = "LblCustomerName";
            this.LblCustomerName.Size = new System.Drawing.Size(93, 23);
            this.LblCustomerName.TabIndex = 36;
            this.LblCustomerName.Text = "Customer:";
            // 
            // usersTableAdapter1
            // 
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblCustomerName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblOriginalFeedback, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.feedbackExcerptTextBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ActionPanel, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 101);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 491);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // LblOriginalFeedback
            // 
            this.LblOriginalFeedback.AutoSize = true;
            this.LblOriginalFeedback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOriginalFeedback.Location = new System.Drawing.Point(4, 23);
            this.LblOriginalFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOriginalFeedback.Name = "LblOriginalFeedback";
            this.LblOriginalFeedback.Size = new System.Drawing.Size(162, 23);
            this.LblOriginalFeedback.TabIndex = 37;
            this.LblOriginalFeedback.Text = "Original Feedback:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 236);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "Your Reply:";
            // 
            // feedbackExcerptTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.feedbackExcerptTextBox, 2);
            this.feedbackExcerptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackExcerptTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.feedbackExcerptTextBox.Location = new System.Drawing.Point(4, 50);
            this.feedbackExcerptTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.feedbackExcerptTextBox.Multiline = true;
            this.feedbackExcerptTextBox.Name = "feedbackExcerptTextBox";
            this.feedbackExcerptTextBox.ReadOnly = true;
            this.feedbackExcerptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedbackExcerptTextBox.Size = new System.Drawing.Size(512, 182);
            this.feedbackExcerptTextBox.TabIndex = 39;
            // 
            // textBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox2, 2);
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox2.Location = new System.Drawing.Point(4, 263);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(512, 182);
            this.textBox2.TabIndex = 40;
            // 
            // ActionPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ActionPanel, 2);
            this.ActionPanel.Controls.Add(this.btnSend);
            this.ActionPanel.Location = new System.Drawing.Point(4, 453);
            this.ActionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(512, 34);
            this.ActionPanel.TabIndex = 41;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(408, 2);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 28);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send Reply";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(139, 86);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 519);
            this.panel1.TabIndex = 38;
            // 
            // ReplyFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(721, 647);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.PictureBoxSedapRasaRF);
            this.Controls.Add(this.LblReviewFeedback);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ReplyFeedback";
            this.Text = "RepplyFeedback";
            this.Load += new System.EventHandler(this.ReplyFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSedapRasaRF)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PictureBoxSedapRasaRF;
        private System.Windows.Forms.Label LblReviewFeedback;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LblCustomerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblOriginalFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox feedbackExcerptTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel1;
    }
}