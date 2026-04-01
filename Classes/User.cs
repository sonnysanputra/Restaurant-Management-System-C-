using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class User
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }
        public decimal EWalletBalance { get; set; }

        public User() { }

        public User(int userID, string username, string name, string email, string password, string role, string phoneNumber, decimal eWalletBalance)
        {
            UserID = userID;
            Username = username;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            PhoneNumber = phoneNumber;
            EWalletBalance = eWalletBalance;
        }

        public void addUser(int userID, string username, string name, string email, string password, string role, string phoneNumber)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
            string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phoneNumber) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string query = "INSERT INTO Users (Username, Email, Password, Name, PhoneNumber, Role) VALUES (@Username, @Email, @Password, @Name, @PhoneNumber, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        cmd.Parameters.AddWithValue("@Role", role);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user. Please try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void removeUser(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string query = "DELETE FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User removed successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No user found with that email.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public void updateUser(string oldEmail, string newEmail, string oldPassword, string newPassword, string newRole)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string updateQuery = "UPDATE Users SET Email = @NewEmail, Password = @NewPassword, Role = @NewRole WHERE Email = @OldEmail";
                    using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                    {
                        conn.Open();

                        if (oldEmail == newEmail && oldPassword == newPassword)
                        {
                            MessageBox.Show("No changes detected.");
                            return;
                        }
                        if (string.IsNullOrEmpty(newEmail) && string.IsNullOrEmpty(newPassword))
                        {
                            MessageBox.Show("Please provide at least one field to update.");
                            return;
                        }
                        updateCmd.Parameters.AddWithValue("@NewEmail", newEmail);
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@NewRole", newRole);
                        updateCmd.Parameters.AddWithValue("@OldEmail", oldEmail);

                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check the details and try again.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }


        public void SearchUser()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string query = "SELECT Email, Role, Password FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.Role = reader["Role"].ToString();
                                this.Password = reader["Password"].ToString();
                                MessageBox.Show($"User found! Email: {this.Email}, Role: {this.Role}");
                            }
                            else
                            {
                                MessageBox.Show("User not found!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search error: " + ex.Message);
            }
        }

        //Manager
        public User GetUserByUsername(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
                {
                    string query = "SELECT * FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User(
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Username"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Password"].ToString(),
                                    reader["Role"].ToString(),
                                    reader["PhoneNumber"].ToString(),
                                    Convert.ToDecimal(reader["EWalletBalance"])
                                );
                            }
                        }
                    }
                }
                MessageBox.Show("User not found!");
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Get user error: " + ex.Message);
                return null;
            }
        }


        public void UpdateEwalletBalance(int userID, decimal newBalance)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
                {
                    string query = "UPDATE Users SET EWalletBalance = @EWalletBalance WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.Parameters.AddWithValue("@EWalletBalance", newBalance);
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Wallet updated successfully!" : "Failed to update wallet balance.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("EWallet update error: " + ex.Message);
            }
        }

        //Method for UpdateProfileForm:

        //Method to get User info by their UserID
        public User GetUserById(int userId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
                {
                    string query = "SELECT * FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User(
                                    Convert.ToInt32(reader["UserID"]),
                                    reader["Username"].ToString(),
                                    reader["Name"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Password"].ToString(),
                                    reader["Role"].ToString(),
                                    reader["PhoneNumber"].ToString(),
                                    Convert.ToDecimal(reader["EWalletBalance"])
                                );
                            }
                        }
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }


        //2nd Method to check if the email is already in use or not
        public bool IsEmailInUse(string email, int excludeUserId)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email AND UserID != @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@UserID", excludeUserId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        //3rd Method to check whether the Username is already used or not
        public bool IsUsernameInUse(string username, int excludeUserId)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID != @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@UserID", excludeUserId);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        //4th Method to update the user's profile details/info
        public bool UpdateUserProfile(int userId, string email, string username, string password, string phone)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string updateQuery = @"UPDATE Users SET Email = @Email, Username = @Username, Password = @Password, PhoneNumber = @Phone
                                       WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
