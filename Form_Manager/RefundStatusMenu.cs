using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment
{
    public partial class RefundStatusMenu : Form
    {
        private User _managerUser;
        private Refund refundObj = new Refund();

        public RefundStatusMenu(User manager)
        {
            InitializeComponent();
            _managerUser = manager;
            this.Load += RefundStatusMenu_Load;
            btnApprove.Click += btnApprove_Click;
            btnReject.Click += btnReject_Click;
            btnViewDetailIncoming.Click += btnViewDetailIncoming_Click;
            btnViewDetailRecords.Click += btnViewDetailRecords_Click;
            BtnBack.Click += btnBack_Click;
        }

        private void RefundStatusMenu_Load(object sender, EventArgs e)
        {
            LoadIncomingRefundRequests();
            LoadRefundRecords();
        }

        private void LoadIncomingRefundRequests()
        {
            dgvIncomingRequests.Rows.Clear();
            dgvIncomingRequests.Columns.Clear();

            dgvIncomingRequests.Columns.Add("RefundID", "Refund ID");
            dgvIncomingRequests.Columns.Add("OrderID", "Order ID");
            dgvIncomingRequests.Columns.Add("CustomerName", "Customer Name");
            dgvIncomingRequests.Columns.Add("RequestedItems", "Requested Items");
            dgvIncomingRequests.Columns.Add("RefundAmount", "Refund Amount");
            dgvIncomingRequests.Columns.Add("Reason", "Reason");
            dgvIncomingRequests.Columns.Add("RequestDate", "Request Date");
            dgvIncomingRequests.Columns.Add("Status", "Status");

            DataTable dt = refundObj.GetPendingRefundRequests(); 

            foreach (DataRow row in dt.Rows)
            {
                dgvIncomingRequests.Rows.Add(
                    row["RefundID"],
                    row["OrderID"],
                    row["CustomerName"],
                    row["RequestedItems"],
                    Convert.ToDecimal(row["RefundAmount"]).ToString("F2"),
                    row["Reason"],
                    Convert.ToDateTime(row["RequestDate"]).ToShortDateString(),
                    row["Status"]
                );
            }
        }

        private void LoadRefundRecords()
        {
            dgvRefundRecords.Rows.Clear();
            dgvRefundRecords.Columns.Clear();

            dgvRefundRecords.Columns.Add("RefundID", "Refund ID");
            dgvRefundRecords.Columns.Add("OrderID", "Order ID");
            dgvRefundRecords.Columns.Add("CustomerName", "Customer Name");
            dgvRefundRecords.Columns.Add("RequestedItems", "Requested Items");
            dgvRefundRecords.Columns.Add("RefundAmount", "Refund Amount");
            dgvRefundRecords.Columns.Add("Reason", "Customer Reason");
            dgvRefundRecords.Columns.Add("RequestDate", "Request Date");
            dgvRefundRecords.Columns.Add("ManagerAction", "Manager Action");
            dgvRefundRecords.Columns.Add("DecisionDate", "Decision Date");

            DataTable dt = refundObj.GetRefundRecords(); 

            foreach (DataRow row in dt.Rows)
            {
                dgvRefundRecords.Rows.Add(
                    row["RefundID"],
                    row["OrderID"],
                    row["CustomerName"],
                    row["RequestedItems"],
                    Convert.ToDecimal(row["RefundAmount"]).ToString("F2"),
                    row["Reason"],
                    Convert.ToDateTime(row["RequestDate"]).ToShortDateString(),
                    row["ManagerAction"],
                    row["DecisionDate"] == DBNull.Value ? "N/A" : Convert.ToDateTime(row["DecisionDate"]).ToShortDateString()
                );
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (dgvIncomingRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int refundId = Convert.ToInt32(dgvIncomingRequests.SelectedRows[0].Cells["RefundID"].Value);

            bool success = refundObj.ApproveRefund(refundId, _managerUser.UserID); 

            if (success)
            {
                MessageBox.Show("Refund request approved and wallet rebalanced.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIncomingRefundRequests();
                LoadRefundRecords();
            }
            else
            {
                MessageBox.Show("Error approving refund.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            if (dgvIncomingRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request to reject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int refundId = Convert.ToInt32(dgvIncomingRequests.SelectedRows[0].Cells["RefundID"].Value);

            bool success = refundObj.RejectRefund(refundId); 

            if (success)
            {
                MessageBox.Show("Refund request rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadIncomingRefundRequests();
                LoadRefundRecords();
            }
            else
            {
                MessageBox.Show("Error rejecting refund.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayRefundDetails(int refundId)
        {
            DataRow row = refundObj.GetRefundDetails(refundId); 

            if (row != null)
            {
                string details =
                    $"Refund ID: {row["RefundID"]}\n" +
                    $"Order ID: {row["OrderID"]}\n" +
                    $"Customer: {row["CustomerName"]} ({row["CustomerEmail"]})\n" +
                    $"Refund Amount: RM {Convert.ToDecimal(row["RefundAmount"]):F2}\n" +
                    $"Reason: {row["Reason"]}\n" +
                    $"Request Date: {Convert.ToDateTime(row["RequestDate"]).ToShortDateString()}\n" +
                    $"Status: {row["Status"]}\n" +
                    $"Decision Date: {(row["DecisionDate"] == DBNull.Value ? "N/A" : Convert.ToDateTime(row["DecisionDate"]).ToShortDateString())}\n" +
                    $"Ordered Items: {row["Items"]}";

                MessageBox.Show(details, "Refund Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Refund details not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewDetailIncoming_Click(object sender, EventArgs e)
        {
            if (dgvIncomingRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund request to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int refundId = Convert.ToInt32(dgvIncomingRequests.SelectedRows[0].Cells["RefundID"].Value);
            DisplayRefundDetails(refundId);
        }

        private void btnViewDetailRecords_Click(object sender, EventArgs e)
        {
            if (dgvRefundRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a refund record to view details.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int refundId = Convert.ToInt32(dgvRefundRecords.SelectedRows[0].Cells["RefundID"].Value);
            DisplayRefundDetails(refundId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerDashboardForm dashboard = new ManagerDashboardForm(_managerUser);
            dashboard.Show();
            this.Close();
        }
    }
}