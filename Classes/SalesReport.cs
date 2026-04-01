using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace Assignment
    {
        public class SalesReportService
        {
            private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
            public DataTable GetSalesReport(int month, int year, string category, out decimal totalSales)
            {
                totalSales = 0;
                DataTable dt = new DataTable();

                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    string query = @"SELECT o.OrderID, o.OrderDate, u.Email AS CustomerEmail, mi.Name AS ItemName, mi.Category, oi.Quantity, oi.UnitPrice
                                     FROM Orders o
                                     JOIN OrderItems oi ON o.OrderID = oi.OrderID
                                     JOIN MenuItem mi ON oi.MenuItemID = mi.MenuItemID
                                     JOIN Users u ON o.UserID = u.UserID
                                     WHERE MONTH(o.OrderDate) = @Month AND YEAR(o.OrderDate) = @Year";

                    if (!string.IsNullOrEmpty(category))
                    {
                        query += " AND mi.Category = @Category";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Month", month);
                        cmd.Parameters.AddWithValue("@Year", year);
                        if (!string.IsNullOrEmpty(category))
                        {
                            cmd.Parameters.AddWithValue("@Category", category);
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            decimal unitPrice = (decimal)row["UnitPrice"];
                            int quantity = (int)row["Quantity"];
                            decimal total = unitPrice * quantity;

                            if (!dt.Columns.Contains("Total"))
                            {
                                dt.Columns.Add("Total", typeof(decimal));
                            }

                            row["Total"] = total; 
                            totalSales += total;
                        }
                    }
                }
                return dt;
            }
        }
    }
}
