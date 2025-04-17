namespace InventoryManagementSystem
{
    partial class Warehouse
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
            lblWarehouseID = new Label();
            txtWarehouseID = new TextBox();
            lblItemID = new Label();
            cmbItemID = new ComboBox();
            nmricCapacity = new NumericUpDown();
            lblCapacity = new Label();
            lblAddress = new Label();
            txtAddress = new TextBox();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSubmit = new Button();
            lblStoredWarehouses = new Label();
            dgvWarehouse = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nmricCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).BeginInit();
            SuspendLayout();
            // 
            // lblWarehouseID
            // 
            lblWarehouseID.AutoSize = true;
            lblWarehouseID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWarehouseID.Location = new Point(45, 85);
            lblWarehouseID.Name = "lblWarehouseID";
            lblWarehouseID.Size = new Size(111, 20);
            lblWarehouseID.TabIndex = 0;
            lblWarehouseID.Text = "Warehouse ID:";
            // 
            // txtWarehouseID
            // 
            txtWarehouseID.Location = new Point(162, 78);
            txtWarehouseID.Name = "txtWarehouseID";
            txtWarehouseID.Size = new Size(149, 27);
            txtWarehouseID.TabIndex = 1;
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemID.Location = new Point(94, 114);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(62, 20);
            lblItemID.TabIndex = 2;
            lblItemID.Text = "ItemID:";
            // 
            // cmbItemID
            // 
            cmbItemID.FormattingEnabled = true;
            cmbItemID.Location = new Point(162, 111);
            cmbItemID.Name = "cmbItemID";
            cmbItemID.Size = new Size(151, 28);
            cmbItemID.TabIndex = 3;
            // 
            // nmricCapacity
            // 
            nmricCapacity.Location = new Point(162, 145);
            nmricCapacity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmricCapacity.Name = "nmricCapacity";
            nmricCapacity.Size = new Size(150, 27);
            nmricCapacity.TabIndex = 4;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.Location = new Point(84, 147);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(72, 20);
            lblCapacity.TabIndex = 5;
            lblCapacity.Text = "Capacity:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAddress.Location = new Point(84, 177);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(70, 20);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(160, 178);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(149, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(336, 308);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 51;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(236, 308);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 50;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(136, 308);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 49;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(36, 308);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 48;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStoredWarehouses
            // 
            lblStoredWarehouses.AutoSize = true;
            lblStoredWarehouses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredWarehouses.Location = new Point(349, 27);
            lblStoredWarehouses.Name = "lblStoredWarehouses";
            lblStoredWarehouses.Size = new Size(148, 20);
            lblStoredWarehouses.TabIndex = 53;
            lblStoredWarehouses.Text = "Stored Warehouses:";
            // 
            // dgvWarehouse
            // 
            dgvWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWarehouse.Location = new Point(349, 54);
            dgvWarehouse.Name = "dgvWarehouse";
            dgvWarehouse.RowHeadersWidth = 51;
            dgvWarehouse.Size = new Size(385, 219);
            dgvWarehouse.TabIndex = 52;
            dgvWarehouse.CellClick += dgvWarehouse_CellClick;
            // 
            // Warehouse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStoredWarehouses);
            Controls.Add(dgvWarehouse);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(lblCapacity);
            Controls.Add(nmricCapacity);
            Controls.Add(cmbItemID);
            Controls.Add(lblItemID);
            Controls.Add(txtWarehouseID);
            Controls.Add(lblWarehouseID);
            Name = "Warehouse";
            Text = "Warehouse";
            ((System.ComponentModel.ISupportInitialize)nmricCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWarehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWarehouseID;
        private TextBox txtWarehouseID;
        private Label lblItemID;
        private ComboBox cmbItemID;
        private NumericUpDown nmricCapacity;
        private Label lblCapacity;
        private Label lblAddress;
        private TextBox txtAddress;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSubmit;
        private Label lblStoredWarehouses;
        private DataGridView dgvWarehouse;
    }
}