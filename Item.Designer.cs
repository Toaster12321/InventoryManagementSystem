namespace InventoryManagementSystem
{
    partial class Item
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
            lblItemID = new Label();
            txtItemID = new TextBox();
            txtSupplierID = new TextBox();
            lblSupplierID = new Label();
            txtItemName = new TextBox();
            label1 = new Label();
            lblQuantity = new Label();
            nmricQuantity = new NumericUpDown();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            nmricItemCost = new NumericUpDown();
            label2 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSubmit = new Button();
            lblStoredItems = new Label();
            dgvItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nmricQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmricItemCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblItemID
            // 
            lblItemID.AutoSize = true;
            lblItemID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblItemID.Location = new Point(71, 64);
            lblItemID.Name = "lblItemID";
            lblItemID.Size = new Size(66, 20);
            lblItemID.TabIndex = 0;
            lblItemID.Text = "Item ID:";
            // 
            // txtItemID
            // 
            txtItemID.Location = new Point(143, 61);
            txtItemID.Name = "txtItemID";
            txtItemID.Size = new Size(166, 27);
            txtItemID.TabIndex = 1;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(143, 94);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(166, 27);
            txtSupplierID.TabIndex = 3;
            // 
            // lblSupplierID
            // 
            lblSupplierID.AutoSize = true;
            lblSupplierID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupplierID.Location = new Point(47, 97);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(90, 20);
            lblSupplierID.TabIndex = 2;
            lblSupplierID.Text = "Supplier ID:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(143, 127);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(166, 27);
            txtItemName.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(47, 130);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 4;
            label1.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblQuantity.Location = new Point(63, 161);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(74, 20);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            // 
            // nmricQuantity
            // 
            nmricQuantity.Location = new Point(143, 161);
            nmricQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmricQuantity.Name = "nmricQuantity";
            nmricQuantity.Size = new Size(166, 27);
            nmricQuantity.TabIndex = 7;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.Location = new Point(63, 195);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(77, 20);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(143, 192);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(166, 28);
            cmbCategory.TabIndex = 9;
            // 
            // nmricItemCost
            // 
            nmricItemCost.DecimalPlaces = 2;
            nmricItemCost.Location = new Point(143, 226);
            nmricItemCost.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nmricItemCost.Name = "nmricItemCost";
            nmricItemCost.Size = new Size(166, 27);
            nmricItemCost.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(59, 228);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 10;
            label2.Text = "Item Cost:";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(343, 330);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 47;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(243, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 46;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(143, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(43, 330);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 44;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // lblStoredItems
            // 
            lblStoredItems.AutoSize = true;
            lblStoredItems.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredItems.Location = new Point(360, 34);
            lblStoredItems.Name = "lblStoredItems";
            lblStoredItems.Size = new Size(103, 20);
            lblStoredItems.TabIndex = 49;
            lblStoredItems.Text = "Stored Items:";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(360, 61);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(385, 219);
            dgvItems.TabIndex = 48;
            dgvItems.CellClick += dgvItems_CellClick;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStoredItems);
            Controls.Add(dgvItems);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(nmricItemCost);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(nmricQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(txtItemName);
            Controls.Add(label1);
            Controls.Add(txtSupplierID);
            Controls.Add(lblSupplierID);
            Controls.Add(txtItemID);
            Controls.Add(lblItemID);
            Name = "Item";
            Text = "Item";
            ((System.ComponentModel.ISupportInitialize)nmricQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmricItemCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemID;
        private TextBox txtItemID;
        private TextBox txtSupplierID;
        private Label lblSupplierID;
        private TextBox txtItemName;
        private Label label1;
        private Label lblQuantity;
        private NumericUpDown nmricQuantity;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private NumericUpDown nmricItemCost;
        private Label label2;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSubmit;
        private Label lblStoredItems;
        private DataGridView dgvItems;
    }
}