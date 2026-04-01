using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{

    public partial class CustomerOrderForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
        private User _loggedInUser;
        private Order orderObj = new Order();
        private eWallet walletObj = new eWallet();

        public CustomerOrderForm(string username)
        {
            InitializeComponent();
            _loggedInUser = GetUser(username);

            dgvMenuItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenuItems.MultiSelect = false;
            dgvMenuItems.ReadOnly = true;
            dgvMenuItems.AllowUserToAddRows = false;
            dgvMenuItems.AutoGenerateColumns = true;

            dgvCart.AllowUserToAddRows = false;
            dgvCart.ReadOnly = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Load += CustomerOrderForm_Load;
        }

        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            LoadMenuItems();
            InitializeCartGrid();
            UpdateTotalAmount();
            UpdateWalletBalance();
            RefreshOrderStatus();
        }

        private User GetUser(string username)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    return new User(0, username, "", "", "", "", "", 0)
                    {
                        UserID = Convert.ToInt32(reader["UserID"]),
                        Username = reader["Username"].ToString(),
                        EWalletBalance = Convert.ToDecimal(reader["EWalletBalance"])
                    };
                }
                else
                {
                    throw new Exception("User not found.");
                }
            }
        }

        private void LoadMenuItems()
        {
            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"SELECT MenuItemID, Name, CASE WHEN IsAvailable = 1 THEN 'Available' ELSE 'Not Available' END AS Availability
                                                         FROM MenuItem 
                                                         ORDER BY MenuItemID ASC", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMenuItems.DataSource = dt;
            }
        }

        private void InitializeCartGrid()
        {
            dgvCart.Columns.Clear();
            dgvCart.Columns.Add("RowNumber", "#");
            dgvCart.Columns["RowNumber"].ReadOnly = true;
            dgvCart.Columns["RowNumber"].Width = 40;
            dgvCart.Columns.Add("MenuItemID", "ID");
            dgvCart.Columns["MenuItemID"].Visible = false;
            dgvCart.Columns.Add("Name", "Name");
            dgvCart.Columns.Add("Quantity", "Quantity");
            dgvCart.Columns.Add("Price", "Price");
            dgvCart.Columns.Add("Total", "Total");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Error");
                return;
            }

            if (dgvMenuItems.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMenuItems.SelectedRows[0];

                if (selectedRow.Cells["MenuItemID"].Value == null)
                {
                    MessageBox.Show("Please select a valid item.");
                    return;
                }

                string availability = selectedRow.Cells["Availability"].Value.ToString();
                if (availability != "Available")
                {
                    MessageBox.Show("This item is currently unavailable.", "Unavailable Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int menuItemId = Convert.ToInt32(selectedRow.Cells["MenuItemID"].Value);
                string name = selectedRow.Cells["Name"].Value.ToString();
                int quantity = (int)numericUpDown1.Value;

                using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True"))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Price FROM MenuItem WHERE MenuItemID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", menuItemId);
                    decimal price = (decimal)cmd.ExecuteScalar();

                    decimal total = price * quantity;
                    int rowNumber = dgvCart.Rows.Count + 1;

                    dgvCart.Rows.Add(rowNumber, menuItemId, name, quantity, price.ToString("F2"), total.ToString("F2"));
                }

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select an item from the menu.");
            }
        }

        private void UpdateTotalAmount()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow || row.Cells["Total"].Value == null) continue;
                total += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            lblTotalAmount.Text = "Total Amount: RM" + total.ToString("F2");
        }

        private void UpdateWalletBalance()
        {
            decimal balance = walletObj.GetWalletBalance(_loggedInUser.UserID); 
            lblWalletBalance.Text = "Wallet Balance: RM" + balance.ToString("F2");
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            bool isCartEmpty = true;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (!row.IsNewRow)
                {
                    isCartEmpty = false;
                    break;
                }
            }

            if (isCartEmpty)
            {
                MessageBox.Show("Your cart is empty. Please add at least one item before submitting the order.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow || row.Cells["Total"].Value == null) continue;
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            //Checking balance 
            decimal balance = walletObj.GetWalletBalance(_loggedInUser.UserID);
            if (balance < totalAmount)
            {
                MessageBox.Show("Insufficient balance.", "Error");
                return;
            }

            var orderItems = new List<OrderItem>();
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;
                orderItems.Add(new OrderItem
                {
                    MenuItemID = Convert.ToInt32(row.Cells["MenuItemID"].Value),
                    ItemName = row.Cells["Name"].Value.ToString(),
                    Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                    UnitPrice = Convert.ToDecimal(row.Cells["Price"].Value)
                });
            }

            var orderObj = new Order();
            bool isSuccess = orderObj.SubmitCustomerOrder(_loggedInUser.UserID, orderItems, totalAmount);

            if (isSuccess)
            {
                MessageBox.Show("Order submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvCart.Rows.Clear();
                UpdateTotalAmount();
                UpdateWalletBalance();
                RefreshOrderStatus();
            }
            else
            {
                MessageBox.Show("Order failed, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshOrderStatus()
        {
            DataTable dtInProgress = orderObj.GetOrderStatusDataTable(_loggedInUser.UserID, "In Progress"); 
            dgvInProgress.DataSource = dtInProgress;

            DataTable dtCompleted = orderObj.GetOrderStatusDataTable(_loggedInUser.UserID, "Completed"); 
            dgvCompleted.DataSource = dtCompleted;
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null && !dgvCart.CurrentRow.IsNewRow)
            {
                dgvCart.Rows.Remove(dgvCart.CurrentRow);
                UpdateRowNumbers();
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Please select a valid item to remove.", "Remove Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateRowNumbers()
        {
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                if (!dgvCart.Rows[i].IsNewRow)
                {
                    dgvCart.Rows[i].Cells["RowNumber"].Value = (i + 1).ToString();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
