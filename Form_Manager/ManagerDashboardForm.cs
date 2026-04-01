using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment.Assignment_IOOPDataSetTableAdapters;

namespace Assignment
{
    public partial class ManagerDashboardForm: Form
    {
        private readonly User currentUser;
        public ManagerDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void BtnTopup_Click(object sender, EventArgs e)
        {
            Topup TopupForm = new Topup(currentUser);
            TopupForm.Show();
            this.Hide();
        }

        private void BtnProfileupdate_click(object sender, EventArgs e)
        {
                        UpdateProfileForm profileForm = new UpdateProfileForm(currentUser.UserID);
            profileForm.Show();
        }

        private void BtnOpenReviewfeedback_Click(object sender, EventArgs e)
        {
            ReviewFeedback ReviewFeedbackForm = new ReviewFeedback(currentUser);
            ReviewFeedbackForm.Show();
            this.Hide();
        }

        private void BtnOpenRefundRequest_Click(object sender, EventArgs e)
        {
            RefundStatusMenu refundForm = new RefundStatusMenu(currentUser);
            refundForm.Show();
            this.Hide();
        }

        private void BtnManagerback_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
