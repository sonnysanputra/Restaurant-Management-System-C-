using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class UpdateProfileForm : Form
    {
        private int userId;
        private User userObj = new User();

        public UpdateProfileForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void UpdateProfileForm_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            var user = userObj.GetUserById(userId); 
            if (user != null)
            {
                txtEmail.Text = user.Email;
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtPhoneNumber.Text = user.PhoneNumber;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Calls the method in User class for validation
            if (userObj.IsEmailInUse(email, userId))
            {
                MessageBox.Show("This email is already in use by another account.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userObj.IsUsernameInUse(username, userId))
            {
                MessageBox.Show("This username is already taken. Please choose another one.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //This is to update using User class method
            bool updated = userObj.UpdateUserProfile(userId, email, username, password, phone);

            if (updated)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}
