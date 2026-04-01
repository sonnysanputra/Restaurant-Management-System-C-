using System;
using System.Data;
using System.Data.SqlClient;

namespace Assignment
{
    public class Refund
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");


        //CUSTOMER
        //1st Method to get the completed orders done without refund request being initiated yet 
        public DataTable GetCompletedOrdersWithoutRefund(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT o.OrderID, m.MenuItemID, m.Name, oi.Quantity, o.OrderDate FROM Orders o
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
                                 LEFT JOIN RefundRequest r ON o.OrderID = r.OrderID
                                 WHERE o.UserID = @UserID AND o.Status = 'Completed' AND r.OrderID IS NULL
                                 ORDER BY o.OrderID ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        //2nd Method to get the status of the refund of a specific customer
        public DataTable GetRefundStatus(int userId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT o.OrderID, o.OrderDate, o.TotalAmount, r.Status, STRING_AGG(m.Name + ' x' + CAST(oi.Quantity AS NVARCHAR), ', ') AS Items, SUM(oi.Quantity) AS TotalQty FROM RefundRequest r
                                 JOIN Orders o ON r.OrderID = o.OrderID
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
                                 WHERE r.UserID = @UserID
                                 GROUP BY o.OrderID, o.OrderDate, o.TotalAmount, r.Status
                                 ORDER BY o.OrderID ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        //3rd Method to submit a new refund request to manager
        public bool SubmitRefundRequest(int userId, int orderId, string reason)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();
                decimal totalAmount = 0;
                string totalQuery = "SELECT TotalAmount FROM Orders WHERE OrderID = @OrderID";
                using (SqlCommand cmd = new SqlCommand(totalQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    object result = cmd.ExecuteScalar();
                    if (result == null || result == DBNull.Value) return false;
                    totalAmount = Convert.ToDecimal(result);
                }

                string insertQuery = @"INSERT INTO RefundRequest (UserID, OrderID, Reason, Amount, Status) VALUES (@UserID, @OrderID, @Reason, @Amount, 'Pending')";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@OrderID", orderId);
                    cmd.Parameters.AddWithValue("@Reason", reason);
                    cmd.Parameters.AddWithValue("@Amount", totalAmount);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



        //MANAGER

        //1st method to get all of the pending refund request done by the customer
        public DataTable GetPendingRefundRequests()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT rr.RefundID, rr.OrderID, u.Username AS CustomerName, rr.Amount AS RefundAmount, rr.Reason, rr.RequestDate, rr.Status, STRING_AGG(m.Name + ' x' + CAST(oi.Quantity AS NVARCHAR), ', ') AS RequestedItems
                                 FROM RefundRequest rr
                                 JOIN Orders o ON rr.OrderID = o.OrderID
                                 JOIN Users u ON rr.UserID = u.UserID
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
                                 WHERE rr.Status = 'Pending'
                                 GROUP BY rr.RefundID, rr.OrderID, u.Username, rr.Amount, rr.Reason, rr.RequestDate, rr.Status
                                 ORDER BY rr.RefundID ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        //2nd method to get all of the refund request that has been processesed (approved/cancelled)
        public DataTable GetRefundRecords()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT rr.RefundID, rr.OrderID, u.Username AS CustomerName, rr.Amount AS RefundAmount, rr.Reason, rr.RequestDate, rr.Status AS ManagerAction, rr.DecisionDate, 
                                        STRING_AGG(m.Name + ' x' + CAST(oi.Quantity AS NVARCHAR), ', ') AS RequestedItems
                                 FROM RefundRequest rr
                                 JOIN Orders o ON rr.OrderID = o.OrderID
                                 JOIN Users u ON rr.UserID = u.UserID
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
                                 WHERE rr.Status IN ('Approved', 'Cancelled')
                                 GROUP BY rr.RefundID, rr.OrderID, u.Username, rr.Amount, rr.Reason, rr.RequestDate, rr.Status, rr.DecisionDate
                                 ORDER BY rr.RefundID ASC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }


        //3rd Method to approve a refund request done by a customer
        public bool ApproveRefund(int refundId, int managerUserId)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    //Gets the refund details done by the customer
                    int userId;
                    decimal amount;
                    string getRefundDetailsQuery = "SELECT UserID, Amount FROM RefundRequest WHERE RefundID = @RefundID";
                    using (SqlCommand cmd = new SqlCommand(getRefundDetailsQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RefundID", refundId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                                throw new Exception("Refund request not found.");
                            userId = Convert.ToInt32(reader["UserID"]);
                            amount = Convert.ToDecimal(reader["Amount"]);
                        }
                    }

                    //THis will update the customer's wallet balance
                    string updateBalanceQuery = "UPDATE Users SET EWalletBalance = EWalletBalance + @Amount WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(updateBalanceQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.ExecuteNonQuery();
                    }

                    //Logs the reund request
                    string insertTransactionQuery = @"INSERT INTO EWalletTransactions (UserID, TransactionDate, Type, Amount, Description) VALUES (@UserID, GETDATE(), 'Refund', @Amount, @Description)";
                    using (SqlCommand cmd = new SqlCommand(insertTransactionQuery, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userId);
                        cmd.Parameters.AddWithValue("@Amount", amount);
                        cmd.Parameters.AddWithValue("@Description", "Refund approved by Manager ID: " + managerUserId);
                        cmd.ExecuteNonQuery();
                    }

                    //This will update the status of the refund request done by the customer
                    string updateRefundStatus = "UPDATE RefundRequest SET Status = 'Approved', DecisionDate = GETDATE() WHERE RefundID = @RefundID";
                    using (SqlCommand cmd = new SqlCommand(updateRefundStatus, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@RefundID", refundId);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }


        //4th Method to reject a refund request done by a customer
        public bool RejectRefund(int refundId)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();
                string updateQuery = @"UPDATE RefundRequest SET Status = 'Cancelled', DecisionDate = GETDATE() WHERE RefundID = @RefundID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@RefundID", refundId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        //5th Method to get the details of a refund request done by a specific customer
        public DataRow GetRefundDetails(int refundId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT rr.RefundID, rr.OrderID, u.Username AS CustomerName, u.Email AS CustomerEmail, rr.Amount AS RefundAmount, rr.Reason, rr.RequestDate, rr.Status, rr.DecisionDate, STRING_AGG(m.Name + ' (Qty: ' + CAST(oi.Quantity AS NVARCHAR) + ')', ', ') AS Items
                                 FROM RefundRequest rr
                                 JOIN Orders o ON rr.OrderID = o.OrderID
                                 JOIN Users u ON rr.UserID = u.UserID
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID
                                 WHERE rr.RefundID = @RefundID
                                 GROUP BY rr.RefundID, rr.OrderID, u.Username, u.Email, rr.Amount, rr.Reason, rr.RequestDate, rr.Status, rr.DecisionDate";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RefundID", refundId);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }

    }
}
