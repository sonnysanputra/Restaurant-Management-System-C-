using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    // Class responsible for handling user login authentication
    class LoginHandler
    {

        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");

        public User Authentication(int userID, string username, string name, string email, string password, string role, string phoneNumber, decimal eWalletBalance)
        {
            User user = null; 

            string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email); 
                cmd.Parameters.AddWithValue("@Password", password);

                conn.Open(); 

                SqlDataReader reader = cmd.ExecuteReader(); 

                if (reader.Read()) 
                {
                    user = new User(userID, username, name, email, password, role, phoneNumber, eWalletBalance)
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Username = reader["Username"].ToString(),
                        Name = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        EWalletBalance = Convert.ToDecimal(reader["EWalletBalance"])
                    };
                }
                reader.Close();
                conn.Close(); 
            }

            return user; 
        }

    }
}
