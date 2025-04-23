namespace InventoryManagementSystem
{
    partial class Shipment
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
            txtShipmentID = new TextBox();
            lblShipmentID = new Label();
            lblWarehouseID = new Label();
            lblOrderID = new Label();
            lblShipmentCost = new Label();
            lblShipmentDate = new Label();
            lblStatus = new Label();
            cmbWarehouseID = new ComboBox();
            cmbOrderID = new ComboBox();
            nmricShipmentCost = new NumericUpDown();
            dtpShipmentDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            lblStoredShipments = new Label();
            dgvShipments = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)nmricShipmentCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
            SuspendLayout();
            // 
            // txtShipmentID
            // 
            txtShipmentID.Location = new Point(178, 73);
            txtShipmentID.Name = "txtShipmentID";
            txtShipmentID.Size = new Size(169, 27);
            txtShipmentID.TabIndex = 3;
            // 
            // lblShipmentID
            // 
            lblShipmentID.AutoSize = true;
            lblShipmentID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentID.Location = new Point(72, 76);
            lblShipmentID.Name = "lblShipmentID";
            lblShipmentID.Size = new Size(100, 20);
            lblShipmentID.TabIndex = 2;
            lblShipmentID.Text = "Shipment ID:";
            // 
            // lblWarehouseID
            // 
            lblWarehouseID.AutoSize = true;
            lblWarehouseID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblWarehouseID.Location = new Point(61, 108);
            lblWarehouseID.Name = "lblWarehouseID";
            lblWarehouseID.Size = new Size(111, 20);
            lblWarehouseID.TabIndex = 4;
            lblWarehouseID.Text = "Warehouse ID:";
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOrderID.Location = new Point(99, 141);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(73, 20);
            lblOrderID.TabIndex = 5;
            lblOrderID.Text = "Order ID:";
            // 
            // lblShipmentCost
            // 
            lblShipmentCost.AutoSize = true;
            lblShipmentCost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentCost.Location = new Point(57, 173);
            lblShipmentCost.Name = "lblShipmentCost";
            lblShipmentCost.Size = new Size(115, 20);
            lblShipmentCost.TabIndex = 6;
            lblShipmentCost.Text = "Shipment Cost:";
            // 
            // lblShipmentDate
            // 
            lblShipmentDate.AutoSize = true;
            lblShipmentDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblShipmentDate.Location = new Point(55, 207);
            lblShipmentDate.Name = "lblShipmentDate";
            lblShipmentDate.Size = new Size(117, 20);
            lblShipmentDate.TabIndex = 7;
            lblShipmentDate.Text = "Shipment Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.Location = new Point(44, 238);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(128, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Shipment Status:";
            // 
            // cmbWarehouseID
            // 
            cmbWarehouseID.FormattingEnabled = true;
            cmbWarehouseID.Location = new Point(178, 105);
            cmbWarehouseID.Name = "cmbWarehouseID";
            cmbWarehouseID.Size = new Size(168, 28);
            cmbWarehouseID.TabIndex = 9;
            // 
            // cmbOrderID
            // 
            cmbOrderID.FormattingEnabled = true;
            cmbOrderID.Location = new Point(178, 138);
            cmbOrderID.Name = "cmbOrderID";
            cmbOrderID.Size = new Size(169, 28);
            cmbOrderID.TabIndex = 10;
            // 
            // nmricShipmentCost
            // 
            nmricShipmentCost.DecimalPlaces = 2;
            nmricShipmentCost.Location = new Point(178, 171);
            nmricShipmentCost.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmricShipmentCost.Name = "nmricShipmentCost";
            nmricShipmentCost.Size = new Size(168, 27);
            nmricShipmentCost.TabIndex = 11;
            // 
            // dtpShipmentDate
            // 
            dtpShipmentDate.Location = new Point(178, 202);
            dtpShipmentDate.Name = "dtpShipmentDate";
            dtpShipmentDate.Size = new Size(250, 27);
            dtpShipmentDate.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(178, 235);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(169, 28);
            cmbStatus.TabIndex = 13;
            // 
            // lblStoredShipments
            // 
            lblStoredShipments.AutoSize = true;
            lblStoredShipments.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredShipments.Location = new Point(463, 49);
            lblStoredShipments.Name = "lblStoredShipments";
            lblStoredShipments.Size = new Size(137, 20);
            lblStoredShipments.TabIndex = 57;
            lblStoredShipments.Text = "Stored Shipments:";
            // 
            // dgvShipments
            // 
            dgvShipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipments.Location = new Point(463, 76);
            dgvShipments.Name = "dgvShipments";
            dgvShipments.RowHeadersWidth = 51;
            dgvShipments.Size = new Size(441, 230);
            dgvShipments.TabIndex = 56;
            dgvShipments.CellClick += dgvShipments_CellClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(378, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 63;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(278, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 62;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(178, 343);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 61;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(78, 343);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 60;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // Shipment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 444);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(lblStoredShipments);
            Controls.Add(dgvShipments);
            Controls.Add(cmbStatus);
            Controls.Add(dtpShipmentDate);
            Controls.Add(nmricShipmentCost);
            Controls.Add(cmbOrderID);
            Controls.Add(cmbWarehouseID);
            Controls.Add(lblStatus);
            Controls.Add(lblShipmentDate);
            Controls.Add(lblShipmentCost);
            Controls.Add(lblOrderID);
            Controls.Add(lblWarehouseID);
            Controls.Add(txtShipmentID);
            Controls.Add(lblShipmentID);
            Name = "Shipment";
            Text = "Shipment";
            ((System.ComponentModel.ISupportInitialize)nmricShipmentCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtShipmentID;
        private Label lblShipmentID;
        private Label lblWarehouseID;
        private Label lblOrderID;
        private Label lblShipmentCost;
        private Label lblShipmentDate;
        private Label lblStatus;
        private ComboBox cmbWarehouseID;
        private ComboBox cmbOrderID;
        private NumericUpDown nmricShipmentCost;
        private DateTimePicker dtpShipmentDate;
        private ComboBox cmbStatus;
        private Label lblStoredShipments;
        private DataGridView dgvShipments;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSubmit;
    }
}