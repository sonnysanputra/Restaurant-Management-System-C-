using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MenuItem
    {
        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            string availabilityText = IsAvailable ? "Available" : "Not Available";
            return $"{Name} - {Category} - RM{Price:F2} - {availabilityText}";
        }

        //Method to get all the items inside the MenuItems in the database
        public List<MenuItem> GetAllMenuItems()
        {
            var items = new List<MenuItem>();

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                var command = new SqlCommand("Select * from MenuItem", conn);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new MenuItem
                    {
                        MenuItemID = (int)reader["MenuItemID"],
                        Name = reader["Name"].ToString(),
                        Category = reader["Category"].ToString(),
                        Price = (decimal)reader["Price"],
                        IsAvailable = (bool)reader["IsAvailable"]
                    });
                }
            }
            return items; 
        }

        //2nd Method, to implement the way a new item is added into the MenuItem table in the db
        public void AddMenuItem(MenuItem menuItem)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                var command = new SqlCommand("Insert into MenuItem (Name, Category, Price, IsAvailable) VALUES (@Name, @Category, @Price, @IsAvailable)", conn);

                command.Parameters.AddWithValue("@Name", menuItem.Name);
                command.Parameters.AddWithValue("@Category", menuItem.Category);
                command.Parameters.AddWithValue("@Price", menuItem.Price);
                command.Parameters.AddWithValue("@IsAvailable", menuItem.IsAvailable);

                command.ExecuteNonQuery();
            }
        }

        //3rd Method, to implement the way on how the existing item in the MenuItem table in the db is updated
        public void UpdateMenuItem(MenuItem menuItem)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();

                var command = new SqlCommand("Update MenuItem set Name = @Name, Category = @Category, Price = @Price, IsAvailable = @IsAvailable where MenuItemID = @MenuItemID", conn);

                command.Parameters.AddWithValue("@MenuItemID", menuItem.MenuItemID);
                command.Parameters.AddWithValue("@Name", menuItem.Name);
                command.Parameters.AddWithValue("@Category", menuItem.Category);
                command.Parameters.AddWithValue("@Price", menuItem.Price);
                command.Parameters.AddWithValue("@IsAvailable", menuItem.IsAvailable);

                command.ExecuteNonQuery();
            }
        }

        //4th method, to implement the way on how an item in the MenuItem table in the db is deleted/removed
        public void DeleteMenuItem(int MenuItemID)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "Delete from MenuItem where MenuItemID = @MenuItemID";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MenuItemID", MenuItemID);

                    conn.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
