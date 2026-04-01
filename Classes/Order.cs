using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");


        //Chef Section
        //1st Method
        //This method is to retrieve the list of orders filtered by the status (In Progress/Completed)
        //This method also load the other attribute data of the table like item name and quantity
        private List<Order> GetOrdersByStatus(string status)
        {
            List<Order> orders = new List<Order>();
            Dictionary<int, Order> orderDict = new Dictionary<int, Order>();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = @"SELECT o.OrderID, o.OrderDate, o.Status, oi.OrderItemID, oi.Quantity, oi.UnitPrice, m.MenuItemID, m.Name AS ItemName FROM Orders o
                                 JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                 JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID WHERE o.Status = @status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int orderId = Convert.ToInt32(reader["OrderID"]);
                            if (!orderDict.ContainsKey(orderId))
                            {
                                orderDict[orderId] = new Order
                                {
                                    OrderID = orderId,
                                    OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                                    Status = reader["Status"].ToString(),
                                    OrderItems = new List<OrderItem>()
                                };
                            }

                            OrderItem item = new OrderItem
                            {
                                OrderItemID = Convert.ToInt32(reader["OrderItemID"]),
                                MenuItemID = Convert.ToInt32(reader["MenuItemID"]),
                                ItemName = reader["ItemName"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"]),
                                UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                            };

                            orderDict[orderId].OrderItems.Add(item);
                        }
                    }
                }
            }

            orders.AddRange(orderDict.Values);
            return orders;
        }

        //2nd Method
        public void UpdateOrderStatus(int orderID, string status)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = "UPDATE Orders SET Status = @status WHERE OrderID = @orderID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@orderID", orderID);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Order> GetInProgressOrders()
        {
            return GetOrdersByStatus("In Progress");
        }

        public List<Order> GetCompletedOrders()
        {
            return GetOrdersByStatus("Completed");
        }

        public void MarkOrderAsCompleted(int orderID)
        {
            UpdateOrderStatus(orderID, "Completed");
        }

        public void RevertOrderToInProgress(int orderID)
        {
            UpdateOrderStatus(orderID, "In Progress");
        }



        //Customer section

        //This method is for the feedback part
        public List<int> GetCompletedOrderIdsWithoutFeedback(int userId)
        {
            List<int> orderIds = new List<int>();
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = @"SELECT o.OrderID FROM Orders o
                                 WHERE o.UserID = @UserID AND o.Status = 'Completed' AND o.OrderID NOT IN (SELECT OrderID FROM Feedback WHERE UserID = @UserID)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orderIds.Add(Convert.ToInt32(reader["OrderID"]));
                }
                reader.Close();
            }
            return orderIds;
        }

        public bool SubmitCustomerOrder(int userId, List<OrderItem> items, decimal totalAmount)
        {
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    SqlCommand checkBalanceCmd = new SqlCommand("SELECT EWalletBalance FROM Users WHERE UserID = @uid", conn, transaction);
                    checkBalanceCmd.Parameters.AddWithValue("@uid", userId);
                    decimal balance = (decimal)checkBalanceCmd.ExecuteScalar();
                    if (balance < totalAmount)
                    {
                        transaction.Rollback();
                        return false;
                    }

                    SqlCommand updateBalanceCmd = new SqlCommand("UPDATE Users SET EWalletBalance = EWalletBalance - @amt WHERE UserID = @uid", conn, transaction);
                    updateBalanceCmd.Parameters.AddWithValue("@amt", totalAmount);
                    updateBalanceCmd.Parameters.AddWithValue("@uid", userId);
                    updateBalanceCmd.ExecuteNonQuery();

                    SqlCommand logPaymentCmd = new SqlCommand(
                        "INSERT INTO EWalletTransactions (UserID, TransactionDate, Type, Amount, Description) VALUES (@uid, GETDATE(), 'Payment', @amt, @desc)",
                        conn, transaction);
                    logPaymentCmd.Parameters.AddWithValue("@uid", userId);
                    logPaymentCmd.Parameters.AddWithValue("@amt", totalAmount);
                    logPaymentCmd.Parameters.AddWithValue("@desc", "Payment for order placed on " + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
                    logPaymentCmd.ExecuteNonQuery();

                    SqlCommand orderCmd = new SqlCommand(
                        "INSERT INTO Orders (UserID, OrderDate, TotalAmount, Status) OUTPUT INSERTED.OrderID VALUES (@uid, GETDATE(), @total, 'In Progress')",
                        conn, transaction);
                    orderCmd.Parameters.AddWithValue("@uid", userId);
                    orderCmd.Parameters.AddWithValue("@total", totalAmount);
                    int orderId = (int)orderCmd.ExecuteScalar();

                    foreach (var item in items)
                    {
                        SqlCommand itemCmd = new SqlCommand("INSERT INTO OrderItems (OrderID, MenuItemID, Quantity, UnitPrice) VALUES (@oid, @mid, @qty, @price)", conn, transaction);
                        itemCmd.Parameters.AddWithValue("@oid", orderId);
                        itemCmd.Parameters.AddWithValue("@mid", item.MenuItemID);
                        itemCmd.Parameters.AddWithValue("@qty", item.Quantity);
                        itemCmd.Parameters.AddWithValue("@price", item.UnitPrice);
                        itemCmd.ExecuteNonQuery();
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


        public DataTable GetOrderStatusDataTable(int userId, string status)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            {
                string query = @"SELECT O.OrderID, O.OrderDate, O.TotalAmount, O.Status, STRING_AGG(M.Name + ' x' + CAST(OI.Quantity AS NVARCHAR), ', ') AS Items
                                 FROM Orders O
                                 JOIN OrderItems OI ON O.OrderID = OI.OrderID
                                 JOIN MenuItem M ON OI.MenuItemID = M.MenuItemID
                                 WHERE O.UserID = @uid AND O.Status = @status
                                 GROUP BY O.OrderID, O.OrderDate, O.TotalAmount, O.Status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@uid", userId);
                    cmd.Parameters.AddWithValue("@status", status);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
