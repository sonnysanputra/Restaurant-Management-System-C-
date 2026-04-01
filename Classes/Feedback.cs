using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime FeedbackDate { get; set; }
        public string Message { get; set; }
        public string ManagerResponse { get; set; }
        public DateTime? ResponseDate { get; set; } 
        public string Status { get; set; }
        public string CustomerUsername { get; set; } 
        public string CustomerEmail { get; set; }

        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");

        public override string ToString()
        {
            // Use 'Message' property here
            return $"{CustomerUsername} - {FeedbackDate.ToShortDateString()} - {Message.Substring(0, Math.Min(Message.Length, 50))}...";
        }

        //This one is used by the manager to egt all the feedbacks from the customers
        public List<Feedback> GetAllFeedback()
        {
            List<Feedback> feedbackList = new List<Feedback>();
            string query = @"SELECT F.FeedbackID, F.UserID, F.FeedbackDate, F.Message, F.ManagerResponse, F.ResponseDate, F.Status, U.Username AS CustomerUsername, U.Email AS CustomerEmail
                             FROM Feedback F
                             JOIN Users U ON F.UserID = U.UserID
                             ORDER BY F.FeedbackDate DESC;";

            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Feedback feedback = new Feedback
                        {
                            FeedbackID = reader.GetInt32(reader.GetOrdinal("FeedbackID")),
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            FeedbackDate = reader.GetDateTime(reader.GetOrdinal("FeedbackDate")),
                            Message = reader["Message"].ToString(),
                            ManagerResponse = reader.IsDBNull(reader.GetOrdinal("ManagerResponse")) ? null : reader["ManagerResponse"].ToString(),
                            ResponseDate = reader.IsDBNull(reader.GetOrdinal("ResponseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ResponseDate")),
                            Status = reader["Status"].ToString(),
                            CustomerUsername = reader["CustomerUsername"].ToString(),
                            CustomerEmail = reader["CustomerEmail"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }
                }
            }
            return feedbackList;
        }


        //This method is to get the feeback by user
        public List<Feedback> GetFeedbackByUser(int userId)
        {
            List<Feedback> feedbackList = new List<Feedback>();
            string query = @"SELECT * FROM Feedback WHERE UserID = @UserID ORDER BY FeedbackDate DESC;";

            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Feedback feedback = new Feedback
                        {
                            FeedbackID = reader.GetInt32(reader.GetOrdinal("FeedbackID")),
                            UserID = reader.GetInt32(reader.GetOrdinal("UserID")),
                            FeedbackDate = reader.GetDateTime(reader.GetOrdinal("FeedbackDate")),
                            Message = reader["Message"].ToString(),
                            ManagerResponse = reader.IsDBNull(reader.GetOrdinal("ManagerResponse")) ? null : reader["ManagerResponse"].ToString(),
                            ResponseDate = reader.IsDBNull(reader.GetOrdinal("ResponseDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ResponseDate")),
                            Status = reader["Status"].ToString()
                        };
                        feedbackList.Add(feedback);
                    }
                }
            }
            return feedbackList;
        }


        //This method is for customer to send a feedback
        public bool AddFeedback(int userId, int orderId, string message)
        {
            string query = @"INSERT INTO Feedback (UserID, OrderID, Message, FeedbackDate, Status)
                             VALUES (@UserID, @OrderID, @Message, @FeedbackDate, @Status)";
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                cmd.Parameters.AddWithValue("@Message", message);
                cmd.Parameters.AddWithValue("@FeedbackDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@Status", "Pending");
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


        //This method is to update the feedback satus when updates are made by the manager
        public void UpdateFeedbackStatus(int feedbackId, string newStatus)
        {
            string query = "UPDATE Feedback SET Status = @newStatus WHERE FeedbackID = @feedbackId";
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@newStatus", newStatus);
                command.Parameters.AddWithValue("@feedbackId", feedbackId);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }


        //This method is for manager to reply to customer's feedback
        public void UpdateFeedbackManagerResponse(int feedbackId, string managerResponse, string newStatus)
        {
            string query = "UPDATE Feedback SET ManagerResponse = @managerResponse, ResponseDate = GETDATE(), Status = @newStatus WHERE FeedbackID = @feedbackId";
            using (SqlConnection conn = new SqlConnection(this.conn.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@managerResponse", managerResponse);
                command.Parameters.AddWithValue("@newStatus", newStatus);
                command.Parameters.AddWithValue("@feedbackId", feedbackId);
                conn.Open();
                command.ExecuteNonQuery();
            }
        }

    }
}
