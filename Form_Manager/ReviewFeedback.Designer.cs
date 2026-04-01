namespace Assignment
{
    partial class ReviewFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewFeedback));
            this.PictureBoxSedapRasaRF = new System.Windows.Forms.PictureBox();
            this.LblReviewFeedback = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.feedbackListbox = new System.Windows.Forms.ListBox();
            this.feedbackDetailsPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblFeedbackMessage = new System.Windows.Forms.Label();
            this.LblCustomerDetail = new System.Windows.Forms.Label();
            this.LblUsernameReviewFeedback = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.feedbackExcerptTextBox = new System.Windows.Forms.TextBox();
            this.BtnReply = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSedapRasaRF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.MessagesPanel.SuspendLayout();
            this.feedbackDetailsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxSedapRasaRF
            // 
            this.PictureBoxSedapRasaRF.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxSedapRasaRF.Image")));
            this.PictureBoxSedapRasaRF.Location = new System.Drawing.Point(41, 15);
            this.PictureBoxSedapRasaRF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBoxSedapRasaRF.Name = "PictureBoxSedapRasaRF";
            this.PictureBoxSedapRasaRF.Size = new System.Drawing.Size(80, 78);
            this.PictureBoxSedapRasaRF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxSedapRasaRF.TabIndex = 27;
            this.PictureBoxSedapRasaRF.TabStop = false;
            // 
            // LblReviewFeedback
            // 
            this.LblReviewFeedback.AutoSize = true;
            this.LblReviewFeedback.BackColor = System.Drawing.Color.Transparent;
            this.LblReviewFeedback.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReviewFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblReviewFeedback.Location = new System.Drawing.Point(297, 17);
            this.LblReviewFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblReviewFeedback.Name = "LblReviewFeedback";
            this.LblReviewFeedback.Size = new System.Drawing.Size(414, 66);
            this.LblReviewFeedback.TabIndex = 30;
            this.LblReviewFeedback.Text = "Review Feedback";
            // 
            // BtnBack
            // 
            this.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBack.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BtnBack.ForeColor = System.Drawing.Color.Sienna;
            this.BtnBack.Location = new System.Drawing.Point(41, 564);
            this.BtnBack.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(100, 28);
            this.BtnBack.TabIndex = 29;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(120, 89);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MessagesPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.feedbackDetailsPanel);
            this.splitContainer1.Size = new System.Drawing.Size(829, 473);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 28;
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.Controls.Add(this.BtnRead);
            this.MessagesPanel.Controls.Add(this.feedbackListbox);
            this.MessagesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessagesPanel.Location = new System.Drawing.Point(0, 0);
            this.MessagesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(200, 473);
            this.MessagesPanel.TabIndex = 1;
            // 
            // feedbackListbox
            // 
            this.feedbackListbox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.feedbackListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedbackListbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.feedbackListbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.feedbackListbox.FormattingEnabled = true;
            this.feedbackListbox.ItemHeight = 40;
            this.feedbackListbox.Location = new System.Drawing.Point(0, 0);
            this.feedbackListbox.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackListbox.Name = "feedbackListbox";
            this.feedbackListbox.Size = new System.Drawing.Size(266, 442);
            this.feedbackListbox.TabIndex = 0;
            // 
            // feedbackDetailsPanel
            // 
            this.feedbackDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.feedbackDetailsPanel.Controls.Add(this.tableLayoutPanel1);
            this.feedbackDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackDetailsPanel.Location = new System.Drawing.Point(0, 0);
            this.feedbackDetailsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackDetailsPanel.Name = "feedbackDetailsPanel";
            this.feedbackDetailsPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.feedbackDetailsPanel.Size = new System.Drawing.Size(624, 473);
            this.feedbackDetailsPanel.TabIndex = 0;
            this.feedbackDetailsPanel.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.LblFeedbackMessage, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblCustomerDetail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblUsernameReviewFeedback, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.feedbackExcerptTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnReply, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 447);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LblFeedbackMessage
            // 
            this.LblFeedbackMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LblFeedbackMessage.AutoSize = true;
            this.LblFeedbackMessage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.SetColumnSpan(this.LblFeedbackMessage, 2);
            this.LblFeedbackMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblFeedbackMessage.Location = new System.Drawing.Point(216, 63);
            this.LblFeedbackMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFeedbackMessage.Name = "LblFeedbackMessage";
            this.LblFeedbackMessage.Size = new System.Drawing.Size(164, 23);
            this.LblFeedbackMessage.TabIndex = 5;
            this.LblFeedbackMessage.Text = "Feedback Message:";
            // 
            // LblCustomerDetail
            // 
            this.LblCustomerDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblCustomerDetail.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblCustomerDetail, 2);
            this.LblCustomerDetail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.LblCustomerDetail.Location = new System.Drawing.Point(228, 0);
            this.LblCustomerDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCustomerDetail.Name = "LblCustomerDetail";
            this.LblCustomerDetail.Size = new System.Drawing.Size(140, 23);
            this.LblCustomerDetail.TabIndex = 2;
            this.LblCustomerDetail.Text = "Customer Detail";
            // 
            // LblUsernameReviewFeedback
            // 
            this.LblUsernameReviewFeedback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsernameReviewFeedback.AutoSize = true;
            this.LblUsernameReviewFeedback.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblUsernameReviewFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsernameReviewFeedback.Location = new System.Drawing.Point(4, 43);
            this.LblUsernameReviewFeedback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsernameReviewFeedback.Name = "LblUsernameReviewFeedback";
            this.LblUsernameReviewFeedback.Size = new System.Drawing.Size(84, 20);
            this.LblUsernameReviewFeedback.TabIndex = 4;
            this.LblUsernameReviewFeedback.Text = "Username:";
            // 
            // LblEmail
            // 
            this.LblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblEmail.AutoSize = true;
            this.LblEmail.BackColor = System.Drawing.SystemColors.HighlightText;
            this.LblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(4, 23);
            this.LblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(84, 20);
            this.LblEmail.TabIndex = 3;
            this.LblEmail.Text = "Email:";
            // 
            // feedbackExcerptTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.feedbackExcerptTextBox, 2);
            this.feedbackExcerptTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.feedbackExcerptTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.feedbackExcerptTextBox.Location = new System.Drawing.Point(4, 90);
            this.feedbackExcerptTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.feedbackExcerptTextBox.Multiline = true;
            this.feedbackExcerptTextBox.Name = "feedbackExcerptTextBox";
            this.feedbackExcerptTextBox.ReadOnly = true;
            this.feedbackExcerptTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.feedbackExcerptTextBox.Size = new System.Drawing.Size(588, 317);
            this.feedbackExcerptTextBox.TabIndex = 6;
            // 
            // BtnReply
            // 
            this.BtnReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReply.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnReply.Location = new System.Drawing.Point(492, 415);
            this.BtnReply.Margin = new System.Windows.Forms.Padding(4);
            this.BtnReply.Name = "BtnReply";
            this.BtnReply.Size = new System.Drawing.Size(100, 28);
            this.BtnReply.TabIndex = 7;
            this.BtnReply.Text = "Reply";
            this.BtnReply.UseVisualStyleBackColor = true;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(0, 441);
            this.BtnRead.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(266, 28);
            this.BtnRead.TabIndex = 1;
            this.BtnRead.Text = "Mark as Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            // 
            // ReviewFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(965, 606);
            this.Controls.Add(this.PictureBoxSedapRasaRF);
            this.Controls.Add(this.LblReviewFeedback);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReviewFeedback";
            this.Text = "ReviewFeedbackNew";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxSedapRasaRF)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.MessagesPanel.ResumeLayout(false);
            this.feedbackDetailsPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxSedapRasaRF;
        private System.Windows.Forms.Label LblReviewFeedback;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox feedbackListbox;
        private System.Windows.Forms.Panel feedbackDetailsPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblFeedbackMessage;
        private System.Windows.Forms.Label LblCustomerDetail;
        private System.Windows.Forms.Label LblUsernameReviewFeedback;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox feedbackExcerptTextBox;
        private System.Windows.Forms.Button BtnReply;
        private System.Windows.Forms.Panel MessagesPanel;
        private System.Windows.Forms.Button BtnRead;
    }
}