using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CustomerFeedbackForm : Form
    {
        private int userId;
        private Feedback feedbackObj = new Feedback();
        private Order orderObj = new Order();

        public CustomerFeedbackForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void CustomerFeedbackForm_Load(object sender, EventArgs e)
        {
            LoadUserFeedbacks();
            LoadCompletedOrdersWithoutFeedback();
        }

        private void LoadUserFeedbacks()
        {
            dgvFeedbacks.Rows.Clear();

            if (dgvFeedbacks.Columns.Count == 0)
            {
                dgvFeedbacks.Columns.Add("FeedbackDate", "Date");
                dgvFeedbacks.Columns.Add("Message", "Message");
                dgvFeedbacks.Columns.Add("ManagerResponse", "Manager Response");
                dgvFeedbacks.Columns.Add("ResponseDate", "Response Date");
                dgvFeedbacks.Columns.Add("Status", "Status");
            }

            var feedbackList = feedbackObj.GetFeedbackByUser(userId);

            foreach (var f in feedbackList)
            {
                dgvFeedbacks.Rows.Add(
                    f.FeedbackDate.ToString("g"),
                    f.Message,
                    f.ManagerResponse,
                    f.ResponseDate.HasValue ? f.ResponseDate.Value.ToString("g") : "",
                    f.Status
                );
            }
        }

        private void LoadCompletedOrdersWithoutFeedback()
        {
            cmbOrders.Items.Clear();

            List<int> orderIds = orderObj.GetCompletedOrderIdsWithoutFeedback(userId);

            foreach (int id in orderIds)
            {
                cmbOrders.Items.Add(id.ToString());
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string feedbackText = txtFeedback.Text.Trim();

            if (string.IsNullOrWhiteSpace(feedbackText))
            {
                MessageBox.Show("Please enter your feedback message.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbOrders.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to give feedback for.", "Missing Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedOrderId = Convert.ToInt32(cmbOrders.SelectedItem);

            var userFeedbacks = feedbackObj.GetFeedbackByUser(userId);
            if (userFeedbacks.Any(f => f.OrderID == selectedOrderId))
            {
                MessageBox.Show("You've already submitted feedback for this order. Thank you!", "Already Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCompletedOrdersWithoutFeedback();
                return;
            }

            bool result = feedbackObj.AddFeedback(userId, selectedOrderId, feedbackText);

            if (result)
            {
                MessageBox.Show("Feedback submitted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFeedback.Clear();
                LoadUserFeedbacks();
                LoadCompletedOrdersWithoutFeedback();
            }
            else
            {
                MessageBox.Show("Failed to submit feedback. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserFeedbacks();
            MessageBox.Show("Feedback result refreshed.", "Refreshed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}