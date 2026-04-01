using System;
using System.Data;
using System.Data.SqlClient;

namespace Assignment
{
    public class eWallet
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
        public DataTable GetEWalletReport(string email, int month, int year, out decimal totalTopup, out decimal totalSpent, out decimal totalRefund)
        {
            totalTopup = 0;
            totalSpent = 0;
            totalRefund = 0;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                SqlCommand getIdCmd = new SqlCommand("SELECT UserID FROM Users WHERE Email = @Email", conn);
                getIdCmd.Parameters.AddWithValue("@Email", email);
                object result = getIdCmd.ExecuteScalar();

                if (result == null)
                {
                    return null;
                }

                int userID = Convert.ToInt32(result);

                SqlCommand cmd = new SqlCommand(@"
                    SELECT Type, Amount, TransactionDate 
                    FROM EWalletTransactions 
                    WHERE UserID = @UserID AND MONTH(TransactionDate) = @Month AND YEAR(TransactionDate) = @Year", conn);

                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@Month", month);
                cmd.Parameters.AddWithValue("@Year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string type = row["Type"].ToString();
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    if (type == "Top-Up" || type == "TopUp" || type == "Topup" || type == "topup") totalTopup += amount;
                    if (type == "Payment") totalSpent += amount;
                    if (type == "Refund") totalRefund += amount;
                }
            }
            return dt;
        }

        //Used by the customer
        public decimal GetWalletBalance(int userId)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT EWalletBalance FROM Users WHERE UserID = @uid", conn);
                cmd.Parameters.AddWithValue("@uid", userId);
                return (decimal)cmd.ExecuteScalar();
            }
        }
    }
}
