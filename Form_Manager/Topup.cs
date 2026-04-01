using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Topup : Form
    {
        private User _loggedInUser;
        private User userObj = new User();

        public Topup()
        {
            InitializeComponent();
        }

        public Topup(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void Btn10_Click(object sender, EventArgs e) => txtTopupAmount.Text = "10";
        private void Btn20_Click(object sender, EventArgs e) => txtTopupAmount.Text = "20";
        private void Btn30_Click(object sender, EventArgs e) => txtTopupAmount.Text = "30";
        private void Btn40_Click(object sender, EventArgs e) => txtTopupAmount.Text = "40";
        private void Btn50_Click(object sender, EventArgs e) => txtTopupAmount.Text = "50";
        private void Btn100_Click(object sender, EventArgs e) => txtTopupAmount.Text = "100";

        private void BtnNumber_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            txtTopupAmount.Text = clickedButton.Text;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ManagerDashboardForm managerDashboard = new ManagerDashboardForm(_loggedInUser);
            managerDashboard.Show();
            this.Hide();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            string usernameInput = txtTopupUsername.Text.Trim();
            string amountInputString = txtTopupAmount.Text.Trim();
            decimal topUpAmount;

            try
            {
                User userToTopUp = userObj.GetUserByUsername(usernameInput);
                if (userToTopUp == null)
                {
                    MessageBox.Show($"User with Username '{usernameInput}' not found.",
                        "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTopupUsername.Clear();
                    txtTopupUsername.Focus();
                    return;
                }

                if (!decimal.TryParse(amountInputString, out topUpAmount) || topUpAmount < 10)
                {
                    MessageBox.Show("Please enter a valid numeric amount for top-up (minimum RM 10).",
                        "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTopupAmount.Clear();
                    txtTopupAmount.Focus();
                    return;
                }

                decimal newBalance = userToTopUp.EWalletBalance + topUpAmount;
                userObj.UpdateEwalletBalance(userToTopUp.UserID, newBalance);

                InsertTopUpTransaction(userToTopUp.UserID, topUpAmount, $"Top-up by Manager ({_loggedInUser.Username})");

                MessageBox.Show(
                    $"Top-up successful!\nNew balance for {userToTopUp.Username} ({userToTopUp.Email}): RM {newBalance:F2}",
                    "Top-up Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTopupAmount.Clear();
                txtTopupUsername.Clear();
                txtTopupUsername.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Top-up failed: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertTopUpTransaction(int userID, decimal amount, string description)
        {
            using (var conn = new System.Data.SqlClient.SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();
                string insertQuery = @"
                    INSERT INTO EWalletTransactions 
                        (UserID, TransactionDate, Type, Amount, Description)
                    VALUES 
                        (@UserID, GETDATE(), 'TopUp', @Amount, @Description)";
                using (var cmd = new System.Data.SqlClient.SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
