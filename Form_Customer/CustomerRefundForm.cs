using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment
{
    public partial class CustomerRefundForm : Form
    {
        private SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=Assignment_IOOP;Integrated Security=True;TrustServerCertificate=True");
        private User _loggedInUser;
        private Refund refundObj = new Refund();

        public CustomerRefundForm(User user)
        {
            InitializeComponent();
            _loggedInUser = user;
        }

        private void CustomerRefundForm_Load(object sender, EventArgs e)
        {
            LoadCompletedOrders();
            LoadRefundStatus();
        }

        private void LoadCompletedOrders()
        {
            dgvCompletedOrders.Rows.Clear();
            dgvCompletedOrders.Columns.Clear();

            dgvCompletedOrders.Columns.Add("OrderID", "Order ID");
            dgvCompletedOrders.Columns.Add("MenuItemID", "Menu Item ID");
            dgvCompletedOrders.Columns.Add("Name", "Dish Name");
            dgvCompletedOrders.Columns.Add("Quantity", "Quantity");
            dgvCompletedOrders.Columns.Add("OrderDate", "Order Date");

            DataTable dt = refundObj.GetCompletedOrdersWithoutRefund(_loggedInUser.UserID); 
            foreach (DataRow row in dt.Rows)
            {
                dgvCompletedOrders.Rows.Add(
                    row["OrderID"],
                    row["MenuItemID"],
                    row["Name"],
                    row["Quantity"],
                    Convert.ToDateTime(row["OrderDate"]).ToShortDateString()
                );
            }
        }

        private void LoadRefundStatus()
        {
            dgvRefundStatus.Rows.Clear();
            dgvRefundStatus.Columns.Clear();

            dgvRefundStatus.Columns.Add("OrderID", "Order ID");
            dgvRefundStatus.Columns.Add("Items", "Dishes Ordered");
            dgvRefundStatus.Columns.Add("Quantities", "Total Quantity");
            dgvRefundStatus.Columns.Add("OrderDate", "Order Date");
            dgvRefundStatus.Columns.Add("Amount", "Total Amount");
            dgvRefundStatus.Columns.Add("Status", "Refund Status");

            DataTable dt = refundObj.GetRefundStatus(_loggedInUser.UserID); 
            foreach (DataRow row in dt.Rows)
            {
                dgvRefundStatus.Rows.Add(
                    row["OrderID"],
                    row["Items"],
                    row["TotalQty"],
                    Convert.ToDateTime(row["OrderDate"]).ToShortDateString(),
                    Convert.ToDecimal(row["TotalAmount"]).ToString("F2"),
                    row["Status"]
                );
            }
        }

        private void btnRequestRefund_Click(object sender, EventArgs e)
        {
            if (dgvCompletedOrders.SelectedRows.Count == 0 || string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please select an order and enter a reason.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int orderId;
            try
            {
                orderId = Convert.ToInt32(dgvCompletedOrders.SelectedRows[0].Cells["OrderID"].Value);
            }
            catch
            {
                MessageBox.Show("Please select a valid order.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string reason = txtReason.Text.Trim();

            bool success = refundObj.SubmitRefundRequest(_loggedInUser.UserID, orderId, reason);
            if (!success)
            {
                MessageBox.Show("Failed to submit refund request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Refund request submitted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtReason.Clear();
            LoadCompletedOrders();
            LoadRefundStatus();
        }

        private void btnRefreshRefunds_Click(object sender, EventArgs e)
        {
            LoadRefundStatus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}