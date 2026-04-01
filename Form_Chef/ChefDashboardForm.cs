using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ChefDashboardForm : Form
    {
        private User _loggedInUser;
        public ChefDashboardForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;

            // Set welcome label using Name or Email
            lblChef.Text = $"Welcome, {user.Email}!";
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm(_loggedInUser.UserID);
            profileForm.Show();
        }

        private void btnViewMenu_Click(object sender, EventArgs e)
        {
            ChefMenuForm menuForm = new ChefMenuForm();
            menuForm.ShowDialog();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ChefOrdersForm ordersForm = new ChefOrdersForm();
            ordersForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

    }
}
