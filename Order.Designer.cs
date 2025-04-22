namespace InventoryManagementSystem
{
    partial class Order
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOrderID = new Label();
            txtOrderID = new TextBox();
            lblUserID = new Label();
            cmbUserID = new ComboBox();
            cmbItemID = new ComboBox();
            lblItemID = new Label();
            lblOrderDate = new Label();
            lblDeliveryDate = new Label();
            dtpOrderDate = new DateTimePicker();
            dtpDeliveryDate = new DateTimePicker();
            lblTotalCost = new Label();
            nmricTotalCost = new NumericUpDown();
            lblStoredOrders = new Label();
            dgvOrder = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)nmricTotalCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            SuspendLayout();
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderID.Location = new Point(76, 46);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(73, 20);
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = "Order ID:";
            lblOrderID.Click += label1_Click;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(155, 43);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(169, 27);
            txtOrderID.TabIndex = 1;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserID.Location = new Point(84, 80);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(65, 20);
            lblUserID.TabIndex = 2;
            lblUserID.Text = "User ID:";
            // 
            // cmbUserID
            // 
            cmbUserID.FormattingEnabled = true;
            cmbUserID.Location = new Point(155, 80);
            cmbUserID.Name = "cmbUserID";
            cmbUserID.Size = new Size(169, 28);
            cmbUserID.TabIndex = 3;
            // 
            // cmbItemID
            // 
            cmbItemID.FormattingEnabled = true;
            cmbItemID.Location = new Point(156, 114);
            cmbItemID.Name = "cmbItemID";
            cmbItemID.Size = new Size(168, 28);
            cmbItemID.TabIndex = 5;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemID.Location = new Point(84, 117);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(66, 20);
            lblItemID.TabIndex = 4;
            lblItemID.Text = "Item ID:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderDate.Location = new Point(60, 153);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(90, 20);
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Order Date:";
            // 
            // lblDeliveryDate
            // 
            lblDeliveryDate.AutoSize = true;
            lblDeliveryDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDeliveryDate.Location = new Point(42, 186);
            lblDeliveryDate.Name = "lblDeliveryDate";
            lblDeliveryDate.Size = new Size(108, 20);
            lblDeliveryDate.TabIndex = 7;
            lblDeliveryDate.Text = "Delivery Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(155, 148);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 8;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(156, 181);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(250, 27);
            dtpDeliveryDate.TabIndex = 9;
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalCost.Location = new Point(66, 216);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(83, 20);
            lblTotalCost.TabIndex = 10;
            lblTotalCost.Text = "Total Cost:";
            // 
            // nmricTotalCost
            // 
            nmricTotalCost.DecimalPlaces = 2;
            nmricTotalCost.Location = new Point(155, 216);
            nmricTotalCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmricTotalCost.Name = "nmricTotalCost";
            nmricTotalCost.Size = new Size(169, 27);
            nmricTotalCost.TabIndex = 11;
            // 
            // lblStoredOrders
            // 
            lblStoredOrders.AutoSize = true;
            lblStoredOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredOrders.Location = new Point(449, 30);
            lblStoredOrders.Name = "lblStoredOrders";
            lblStoredOrders.Size = new Size(110, 20);
            lblStoredOrders.TabIndex = 55;
            lblStoredOrders.Text = "Stored Orders:";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(449, 57);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(441, 230);
            dgvOrder.TabIndex = 54;
            dgvOrder.CellClick += dgvOrder_CellClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(367, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 59;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(267, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(167, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 57;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(67, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 56;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 424);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(lblStoredOrders);
            Controls.Add(dgvOrder);
            Controls.Add(nmricTotalCost);
            Controls.Add(lblTotalCost);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(dtpOrderDate);
            Controls.Add(lblDeliveryDate);
            Controls.Add(lblOrderDate);
            Controls.Add(cmbItemID);
            Controls.Add(lblItemID);
            Controls.Add(cmbUserID);
            Controls.Add(lblUserID);
            Controls.Add(txtOrderID);
            Controls.Add(lblOrderID);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)nmricTotalCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOrderID;
        private TextBox txtOrderID;
        private Label lblUserID;
        private ComboBox cmbUserID;
        private ComboBox cmbItemID;
        private Label lblItemID;
        private Label lblOrderDate;
        private Label lblDeliveryDate;
        private DateTimePicker dtpOrderDate;
        private DateTimePicker dtpDeliveryDate;
        private Label lblTotalCost;
        private NumericUpDown nmricTotalCost;
        private Label lblStoredOrders;
        private DataGridView dgvOrder;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSubmit;
    }
}