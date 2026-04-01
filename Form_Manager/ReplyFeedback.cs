using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ReplyFeedback : Form
    {
        private Feedback _feedbackToReply; 
        private User _managerUser;        

        public ReplyFeedback(Feedback feedback, User managerUser)
        {
            InitializeComponent();
            _feedbackToReply = feedback;
            _managerUser = managerUser;

            BtnBack.Click += BtnBack_Click;
            btnSend.Click += BtnSend_Click;
        }


        public ReplyFeedback()
        {
            InitializeComponent();
        }

        private void ReplyFeedback_Load(object sender, EventArgs e)
        {
            if (_feedbackToReply != null)
            {
                LblCustomerName.Text = $"Customer: {_feedbackToReply.CustomerUsername}";
                feedbackExcerptTextBox.Text = _feedbackToReply.Message;
                feedbackExcerptTextBox.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("No feedback selected to reply to.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string replyMessage = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(replyMessage))
            {
                MessageBox.Show("Please enter a reply before sending.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_feedbackToReply != null)
            {
                try
                {
                    _feedbackToReply.UpdateFeedbackManagerResponse(
                        _feedbackToReply.FeedbackID,
                        replyMessage,
                        "Replied"
                    );

                    MessageBox.Show("Reply sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReviewFeedback reviewForm = new ReviewFeedback(_managerUser);
                    reviewForm.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error sending reply: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Feedback data is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ReviewFeedback reviewForm = new ReviewFeedback(_managerUser);
            reviewForm.Show();
            this.Close();
        }

    }
}