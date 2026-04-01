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
    public partial class CustomerDashboardForm : Form
    {
        private User _loggedInUser;


        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        public CustomerDashboardForm (User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void btnRefundOrder_Click(object sender, EventArgs e)
        {
            CustomerRefundForm refundForm = new CustomerRefundForm(_loggedInUser);
            refundForm.Show();
        }

        private void btnBrowseOrder_Click(object sender, EventArgs e)
        {
            CustomerOrderForm orderForm = new CustomerOrderForm(_loggedInUser.Username); 
            orderForm.Show();
        }

        private void btnSendFeedback_Click(object sender, EventArgs e)
        {
            CustomerFeedbackForm feedbackForm = new CustomerFeedbackForm(_loggedInUser.UserID);
            feedbackForm.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm(_loggedInUser.UserID);
            profileForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
        }
    }
}
