using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    internal class AdminDashboardLoader
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
        public void LoadComboBoxValues(ComboBox cbMonth, ComboBox cbYear, ComboBox cbCategory, ComboBox cbChef)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    LoadDistinctValues(conn, "SELECT DISTINCT MONTH(OrderDate) AS OrderMonth FROM Orders", cbMonth, "OrderMonth");
                    LoadDistinctValues(conn, "SELECT DISTINCT YEAR(OrderDate) AS OrderYear FROM Orders", cbYear, "OrderYear");
                    LoadDistinctValues(conn, "SELECT DISTINCT Category FROM MenuItem", cbCategory, "Category");
                    LoadDistinctValues(conn, "SELECT Email FROM Users WHERE Role = 'Chef'", cbChef, "Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadDistinctValues(SqlConnection conn, string query, ComboBox comboBox, string fieldName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox.Items.Add(reader[fieldName].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox load error: " + ex.Message);
            }
        }
    }
}