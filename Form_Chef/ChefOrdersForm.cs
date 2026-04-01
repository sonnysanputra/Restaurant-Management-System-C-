using Assignment;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ChefOrdersForm : Form
    {
        private Order _order = new Order();
        public ChefOrdersForm()
        {
            InitializeComponent();

            dgvInProgress.AutoGenerateColumns = true;
            dgvCompleted.AutoGenerateColumns = true;

            SetupDataGrids();
        }

        private void ChefOrdersForm_Load_1(object sender, EventArgs e)
        {
            dgvInProgress.AutoGenerateColumns = true;
            dgvCompleted.AutoGenerateColumns = true;

            LoadInProgressOrders();

            feedbackTimer.Stop();
            lblFeedback.Text = "";
            picTick.Visible = false;

            lblRevertFeedback.Text = "";
            lblRevertFeedback.Visible = false;
        }

        //This method is to initialize and setup the columns of the dgvs
        private void SetupDataGrids()
        {
            dgvInProgress.Columns.Clear();
            dgvInProgress.Columns.Add("OrderID", "Order ID");
            dgvInProgress.Columns.Add("Items", "Items");
            dgvInProgress.Columns.Add("Quantity", "Total Quantity");
            dgvInProgress.Columns.Add("OrderDate", "Order Date");
            dgvInProgress.Columns["Items"].Width = 250;

            dgvCompleted.Columns.Clear();
            dgvCompleted.Columns.Add("OrderID", "Order ID");
            dgvCompleted.Columns.Add("Items", "Items");
            dgvCompleted.Columns.Add("Quantity", "Total Quantity");
            dgvCompleted.Columns.Add("OrderDate", "Order Date");
            dgvCompleted.Columns["Items"].Width = 250;
        }

        //This method is to load orders which has the status of 'In Progress'
        private void LoadInProgressOrders()
        {
            dgvInProgress.Rows.Clear();

            List<Order> orders = _order.GetInProgressOrders();

            foreach (var order in orders)
            {
                dgvInProgress.Rows.Add(order.OrderID, GetOrderItemsSummary(order.OrderItems), GetOrderTotalQuantity(order.OrderItems), order.OrderDate.ToShortDateString());
            }
        }

        //This method to load orders which has the status 'Completed'
        private void LoadCompletedOrders()
        {
            dgvCompleted.Rows.Clear();

            List<Order> orders = _order.GetCompletedOrders();

            foreach (var order in orders)
            {
                dgvCompleted.Rows.Add(order.OrderID, GetOrderItemsSummary(order.OrderItems), GetOrderTotalQuantity(order.OrderItems), order.OrderDate.ToShortDateString());
            }
        }

        //This method is to format the string into item names + quantity
        private string GetOrderItemsSummary(List<OrderItem> items)
        {
            return string.Join(", ", items.Select(i => $"{i.ItemName} x {i.Quantity}"));
        }

        private int GetOrderTotalQuantity(List<OrderItem> items)
        {
            return items.Sum(i => i.Quantity);
        }

        private void TabControlOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlOrders.SelectedTab == tabInProgress)
            {
                LoadInProgressOrders();
            }
            else if (tabControlOrders.SelectedTab == tabCompleted)
            {
                LoadCompletedOrders();
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dgvInProgress.SelectedRows.Count == 0)
            {
                ShowFeedback("Please select an order to Mark As Completed", Color.Red, false);
                return;
            }

            var selectedRow = dgvInProgress.SelectedRows[0];

            if (selectedRow.IsNewRow || selectedRow.Cells["OrderID"].Value == null)
            {
                ShowFeedback("Cannot mark an empty row as completed", Color.Red, false);
                return;
            }

            int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

            _order.MarkOrderAsCompleted(orderId);

            ShowFeedback("Order marked as completed", Color.Green, true);
            LoadInProgressOrders();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (dgvCompleted.SelectedRows.Count == 0)
            {
                lblRevertFeedback.Text = "Please select an order to Revert to In Progress";
                lblRevertFeedback.ForeColor = Color.Red;
                lblRevertFeedback.Visible = true;
                feedbackTimer.Start();
                return;
            }

            var selectedRow = dgvCompleted.SelectedRows[0];

            if (selectedRow.IsNewRow || selectedRow.Cells["OrderID"].Value == null)
            {
                lblRevertFeedback.Text = "Cannot revert an empty row";
                lblRevertFeedback.ForeColor = Color.Red;
                lblRevertFeedback.Visible = true;
                feedbackTimer.Start();
                return;
            }

            int orderId = Convert.ToInt32(selectedRow.Cells["OrderID"].Value);

            _order.RevertOrderToInProgress(orderId);
            lblRevertFeedback.Text = "✔ Order marked successfully!";
            lblRevertFeedback.ForeColor = Color.Green;
            lblRevertFeedback.Visible = true;
            feedbackTimer.Start();
            LoadCompletedOrders();
        }

        private void ShowFeedback(string message, Color color, bool showTick)
        {
            feedbackTimer.Stop(); 
            lblFeedback.Text = message;
            lblFeedback.ForeColor = color;
            lblFeedback.Visible = true;
            picTick.Visible = showTick;
            feedbackTimer.Start(); 
        }

        private void feedbackTimer_Tick_1(object sender, EventArgs e)
        {
            lblFeedback.Text = "";
            lblFeedback.Visible = false;
            lblRevertFeedback.Text = "";
            lblRevertFeedback.Visible = false;
            picTick.Visible = false;
            feedbackTimer.Stop();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
