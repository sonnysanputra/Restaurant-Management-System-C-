namespace Assignment
{
    partial class CustomerOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlaceOrder = new System.Windows.Forms.TabPage();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.tabViewOrderStatus = new System.Windows.Forms.TabPage();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.dgvCompleted = new System.Windows.Forms.DataGridView();
            this.dgvInProgress = new System.Windows.Forms.DataGridView();
            this.btnRefreshStatus = new System.Windows.Forms.Button();
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPlaceOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.tabViewOrderStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlaceOrder);
            this.tabControl1.Controls.Add(this.tabViewOrderStatus);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.tabControl1.Location = new System.Drawing.Point(26, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(865, 520);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPlaceOrder
            // 
            this.tabPlaceOrder.Controls.Add(this.btnRemove);
            this.tabPlaceOrder.Controls.Add(this.lblWalletBalance);
            this.tabPlaceOrder.Controls.Add(this.lblTotalAmount);
            this.tabPlaceOrder.Controls.Add(this.btnAddToCart);
            this.tabPlaceOrder.Controls.Add(this.dgvCart);
            this.tabPlaceOrder.Controls.Add(this.numericUpDown1);
            this.tabPlaceOrder.Controls.Add(this.btnSubmitOrder);
            this.tabPlaceOrder.Controls.Add(this.dgvMenuItems);
            this.tabPlaceOrder.Location = new System.Drawing.Point(4, 32);
            this.tabPlaceOrder.Name = "tabPlaceOrder";
            this.tabPlaceOrder.Padding = new System.Windows.Forms.Padding(2);
            this.tabPlaceOrder.Size = new System.Drawing.Size(857, 484);
            this.tabPlaceOrder.TabIndex = 1;
            this.tabPlaceOrder.Text = "Place Order";
            this.tabPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(427, 412);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 47);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.AutoSize = true;
            this.lblWalletBalance.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold);
            this.lblWalletBalance.Location = new System.Drawing.Point(17, 424);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Size = new System.Drawing.Size(199, 23);
            this.lblWalletBalance.TabIndex = 8;
            this.lblWalletBalance.Text = "Wallet Balance: RM0.00";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(613, 412);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(113, 23);
            this.lblTotalAmount.TabIndex = 7;
            this.lblTotalAmount.Text = "Total Amount";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(359, 218);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(147, 47);
            this.btnAddToCart.TabIndex = 6;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(8, 276);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 82;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(829, 121);
            this.dgvCart.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(8, 218);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 30);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(261, 412);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(147, 47);
            this.btnSubmitOrder.TabIndex = 3;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(8, 15);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.RowHeadersWidth = 82;
            this.dgvMenuItems.Size = new System.Drawing.Size(829, 192);
            this.dgvMenuItems.TabIndex = 2;
            // 
            // tabViewOrderStatus
            // 
            this.tabViewOrderStatus.Controls.Add(this.lblCompleted);
            this.tabViewOrderStatus.Controls.Add(this.lblInProgress);
            this.tabViewOrderStatus.Controls.Add(this.dgvCompleted);
            this.tabViewOrderStatus.Controls.Add(this.dgvInProgress);
            this.tabViewOrderStatus.Controls.Add(this.btnRefreshStatus);
            this.tabViewOrderStatus.Location = new System.Drawing.Point(4, 32);
            this.tabViewOrderStatus.Name = "tabViewOrderStatus";
            this.tabViewOrderStatus.Padding = new System.Windows.Forms.Padding(2);
            this.tabViewOrderStatus.Size = new System.Drawing.Size(857, 484);
            this.tabViewOrderStatus.TabIndex = 2;
            this.tabViewOrderStatus.Text = "View Order Status";
            this.tabViewOrderStatus.UseVisualStyleBackColor = true;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Location = new System.Drawing.Point(25, 218);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(154, 23);
            this.lblCompleted.TabIndex = 5;
            this.lblCompleted.Text = "Completed Orders:";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Location = new System.Drawing.Point(25, 10);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(155, 23);
            this.lblInProgress.TabIndex = 4;
            this.lblInProgress.Text = "In Progress Orders:";
            // 
            // dgvCompleted
            // 
            this.dgvCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompleted.Location = new System.Drawing.Point(22, 244);
            this.dgvCompleted.Name = "dgvCompleted";
            this.dgvCompleted.RowHeadersWidth = 51;
            this.dgvCompleted.RowTemplate.Height = 24;
            this.dgvCompleted.Size = new System.Drawing.Size(812, 177);
            this.dgvCompleted.TabIndex = 3;
            // 
            // dgvInProgress
            // 
            this.dgvInProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInProgress.Location = new System.Drawing.Point(22, 38);
            this.dgvInProgress.Name = "dgvInProgress";
            this.dgvInProgress.RowHeadersWidth = 51;
            this.dgvInProgress.RowTemplate.Height = 24;
            this.dgvInProgress.Size = new System.Drawing.Size(812, 177);
            this.dgvInProgress.TabIndex = 2;
            // 
            // btnRefreshStatus
            // 
            this.btnRefreshStatus.Location = new System.Drawing.Point(695, 426);
            this.btnRefreshStatus.Name = "btnRefreshStatus";
            this.btnRefreshStatus.Size = new System.Drawing.Size(139, 45);
            this.btnRefreshStatus.TabIndex = 1;
            this.btnRefreshStatus.Text = "Refresh Status";
            this.btnRefreshStatus.UseVisualStyleBackColor = true;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold);
            this.lblOrders.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOrders.Location = new System.Drawing.Point(381, 10);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(139, 50);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.125F);
            this.btnClose.Location = new System.Drawing.Point(11, 586);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(99, 28);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomerOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(907, 621);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerOrderForm";
            this.Text = "CustomerOrderForm";
            this.Load += new System.EventHandler(this.CustomerOrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPlaceOrder.ResumeLayout(false);
            this.tabPlaceOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.tabViewOrderStatus.ResumeLayout(false);
            this.tabViewOrderStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPlaceOrder;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.TabPage tabViewOrderStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnRefreshStatus;
        private System.Windows.Forms.DataGridView dgvInProgress;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.DataGridView dgvCompleted;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.Button btnRemove;
    }
}