using Assignment.Assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminDashboardForm : Form
    {
        private User currentUser;
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string name = txtName.Text.Trim();
            string phoneNumber = txtPhoneNum.Text.Trim();
            string role = cbRole.SelectedItem?.ToString();

            var addUser = new User(0, username, name, email, password, role, phoneNumber, 0);
            addUser.addUser(0, username, name, email, password, role, phoneNumber);
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            var removeUser = new User(0, "", "", email, "", "", "", 0);
            removeUser.removeUser(email);
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            lblWelcomeAdmin.Text = $"Welcome, {currentUser.Email}!";
            dgvSalesReport.AutoGenerateColumns = true;
            dgvEWalletReport.AutoGenerateColumns = true;

            try
            {
                var loader = new AdminDashboardLoader();
                loader.LoadComboBoxValues(cbMonth, cbYear, cbCategory, cbChef);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string email = txtSearchEmail.Text.Trim();

            User user = new User();
            user.Email = email;

            user.SearchUser();

            txtSearchEmail.Text = user.Email;
            cbUpdateRole.SelectedItem = user.Role;
            txtCurrentPassword.Text = user.Password;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string oldEmail = txtSearchEmail.Text.Trim();
            string newEmail = txtNewEmail.Text.Trim();
            string oldPassword = txtCurrentPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string newRole = cbUpdateRole.SelectedItem?.ToString();

            var updateUser = new User(0, "", "", oldEmail, oldPassword, newRole, "", 0);
            updateUser.updateUser(oldEmail, newEmail, oldPassword, newPassword, newRole);
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            dgvSalesReport.DataSource = null;
            dgvSalesReport.Rows.Clear();

            int month = int.Parse(cbMonth.SelectedItem?.ToString() ?? "0");
            int year = int.Parse(cbYear.SelectedItem?.ToString() ?? "0");
            string category = cbCategory.SelectedItem?.ToString();
            string chef = cbChef.SelectedItem?.ToString();

            try
            {
                var service = new SalesReportService();
                decimal totalSales;
                var dt = service.GetSalesReport(month, year, category, out totalSales);

                dgvSalesReport.DataSource = dt;
                lblTotalSales.Text = $"Total Sales: RM {totalSales:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Report error: " + ex.Message);
            }
        }

        private void btnViewEWalletReport_Click(object sender, EventArgs e)
        {
            dgvEWalletReport.DataSource = null;
            dgvEWalletReport.Rows.Clear();

            string email = txtCustomerEmailEWallet.Text.Trim();
            if (string.IsNullOrEmpty(email) || cbEWalletMonth.SelectedItem == null || cbEWalletYear.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int month = cbEWalletMonth.SelectedIndex + 1;
            int year = int.Parse(cbEWalletYear.SelectedItem.ToString());

            try
            {
                var service = new eWallet();
                decimal totalTopup, totalSpent, totalRefund;
                var dt = service.GetEWalletReport(email, month, year, out totalTopup, out totalSpent, out totalRefund);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No transactions found for this user in the selected month/year.");
                    return;
                }

                dgvEWalletReport.DataSource = dt;
                lblTotalTopUps.Text = $"Total Top-up: RM {totalTopup:F2}";
                lblTotalSpent.Text = $"Total Spent: RM {totalSpent:F2}";
                lblTotalRefund.Text = $"Total Refund: RM {totalRefund:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-wallet report error: " + ex.Message);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}