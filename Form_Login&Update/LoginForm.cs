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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text; 
            string password = txtPassword.Text; 


            LoginHandler handler = new LoginHandler();
            User user = handler.Authentication(0,"", "", email, password, "", "", 0);

            if (user != null)
            {
                MessageBox.Show($"Welcome {user.Role}!");
                this.Hide();

                switch (user.Role)
                {
                    case "SystemAdmin":
                        new AdminDashboardForm(user).Show();
                        break;
                    case "Manager":
                        new ManagerDashboardForm(user).Show();
                        break;
                    case "Chef":
                        new ChefDashboardForm(user).Show();
                        break;
                    case "Customer":
                        new CustomerDashboardForm(user).Show();
                        break;
                }
            }
            else
            {
                lblErrorMessage.Text = "Invalid email or password.";
                lblErrorMessage.Visible = true;
                return;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
