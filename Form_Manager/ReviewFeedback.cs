using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ReviewFeedback : Form
    {
        private Feedback feedbackObj = new Feedback();
        private List<Feedback> allFeedback;
        private User _loggedInUser;

        public ReviewFeedback(User loggedInUser = null)
        {
            InitializeComponent();
            _loggedInUser = loggedInUser;

            feedbackListbox.DrawMode = DrawMode.OwnerDrawVariable;
            feedbackListbox.DrawItem += feedbackListbox_DrawItem;
            feedbackListbox.MeasureItem += feedbackListbox_MeasureItem;

            LoadFeedback();
            feedbackListbox.SelectedIndexChanged += feedbackListbox_SelectedIndexChanged;
            BtnBack.Click += BtnBack_Click_1;
            BtnRead.Click += BtnRead_Click;
            BtnReply.Click += BtnReply_Click;
        }

        private void LoadFeedback()
        {
            try
            {
                allFeedback = feedbackObj.GetAllFeedback(); 
                DisplayFeedbackInListBox(allFeedback);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayFeedbackInListBox(List<Feedback> feedbackToDisplay)
        {
            feedbackListbox.DataSource = null;
            feedbackListbox.Items.Clear();

            if (feedbackToDisplay != null && feedbackToDisplay.Any())
            {
                foreach (var feedback in feedbackToDisplay)
                {
                    string display = $"From: {feedback.CustomerUsername}\nStatus: {feedback.Status}\nDate: {feedback.FeedbackDate.ToShortDateString()} - {feedback.Message.Split('\n')[0].Substring(0, Math.Min(feedback.Message.Length, 30))}...";
                    feedbackListbox.Items.Add(new ListBoxItem(display, feedback));
                }
            }
            else
            {
                feedbackListbox.Items.Add("No feedback available.");
            }
        }

        private void feedbackListbox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= feedbackListbox.Items.Count)
                return;

            var item = feedbackListbox.Items[e.Index] as ListBoxItem;
            if (item == null) return;

            string displayString = item.DisplayText;
            Feedback feedback = item.Feedback;

            Font itemFont = new Font("Segoe UI", 9f);
            Color bgColor = (e.State & DrawItemState.Selected) == DrawItemState.Selected
                ? Color.FromArgb(0, 120, 215)
                : feedbackListbox.BackColor;

            Brush textBrush = Brushes.Black;

            if (feedback != null)
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    textBrush = Brushes.White;
                }
                else
                {
                    switch (feedback.Status)
                    {
                        case "New":
                            textBrush = Brushes.Red;
                            break;
                        case "Read":
                            textBrush = Brushes.DarkGreen;
                            break;
                        case "Replied":
                            textBrush = Brushes.Blue;
                            break;
                    }
                }
            }

            using (SolidBrush bgBrush = new SolidBrush(bgColor))
                e.Graphics.FillRectangle(bgBrush, e.Bounds);

            Rectangle textRect = new Rectangle(e.Bounds.Left + 5, e.Bounds.Top + 5, e.Bounds.Width - 10, e.Bounds.Height - 10);
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            e.Graphics.DrawString(displayString, itemFont, textBrush, textRect);

            e.DrawFocusRectangle();
        }

        private void feedbackListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (feedbackListbox.SelectedItem is ListBoxItem selectedItem)
            {
                Feedback selectedFeedback = selectedItem.Feedback;
                DisplayFeedbackDetails(selectedFeedback);
            }
            else
            {
                ClearFeedbackDetails();
            }
        }

        private void DisplayFeedbackDetails(Feedback feedback)
        {
            feedbackDetailsPanel.Visible = true;
            LblEmail.Text = $"Email: {feedback.CustomerEmail}";
            LblUsernameReviewFeedback.Text = $"Username: {feedback.CustomerUsername}";
            feedbackExcerptTextBox.Text = feedback.Message;

            if (!string.IsNullOrEmpty(feedback.ManagerResponse))
            {
                feedbackExcerptTextBox.AppendText($"\r\n\r\n--- Manager Response ({feedback.ResponseDate?.ToShortDateString()}) ---\r\n{feedback.ManagerResponse}");
            }
        }

        private void ClearFeedbackDetails()
        {
            feedbackDetailsPanel.Visible = false;
            LblEmail.Text = "Email:";
            LblUsernameReviewFeedback.Text = "Username:";
            feedbackExcerptTextBox.Clear();
        }

        private void BtnRead_Click(object sender, EventArgs e)
        {
            if (feedbackListbox.SelectedItem is ListBoxItem selectedItem)
            {
                Feedback selectedFeedback = selectedItem.Feedback;
                UpdateFeedbackStatus(selectedFeedback, "Read");
            }
            else
            {
                MessageBox.Show("Please select a feedback item to mark as read.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateFeedbackStatus(Feedback feedbackToUpdate, string newStatus)
        {
            try
            {
                feedbackObj.UpdateFeedbackStatus(feedbackToUpdate.FeedbackID, newStatus);

                feedbackToUpdate.Status = newStatus;

                LoadFeedback();
                feedbackListbox.SelectedIndex = allFeedback.FindIndex(f => f.FeedbackID == feedbackToUpdate.FeedbackID);
                DisplayFeedbackDetails(feedbackToUpdate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating feedback status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            if (feedbackListbox.SelectedItem is ListBoxItem selectedItem)
            {
                Feedback selectedFeedback = selectedItem.Feedback;
                ReplyFeedback replyForm = new ReplyFeedback(selectedFeedback, _loggedInUser);
                replyForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select feedback to reply to.", "Selection Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBack_Click_1(object sender, EventArgs e)
        {
            ManagerDashboardForm managerDashboard = new ManagerDashboardForm(_loggedInUser);
            managerDashboard.Show();
            this.Hide();
        }

        private void feedbackListbox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= feedbackListbox.Items.Count)
                return;

            if (feedbackListbox.Items[e.Index] is ListBoxItem item)
            {
                string displayText = item.DisplayText;
                using (Graphics g = feedbackListbox.CreateGraphics())
                {
                    SizeF textSize = g.MeasureString(displayText, new Font("Segoe UI", 9f), feedbackListbox.Width - 10);
                    e.ItemHeight = (int)textSize.Height + 10;
                }
            }
        }

        private class ListBoxItem
        {
            public string DisplayText { get; set; }
            public Feedback Feedback { get; set; }

            public ListBoxItem(string displayText, Feedback feedback)
            {
                DisplayText = displayText;
                Feedback = feedback;
            }

            public override string ToString() => DisplayText;
        }
    }
}