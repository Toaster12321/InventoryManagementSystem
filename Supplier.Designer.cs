namespace InventoryManagementSystem
{
    partial class Supplier
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
            btnClear = new Button();
            btnDelete = new Button();
            lblStoredSuppliers = new Label();
            dgvSupplier = new DataGridView();
            btnUpdate = new Button();
            btnSubmit = new Button();
            txtBrand = new TextBox();
            txtSupEmail = new TextBox();
            txtSupPhoneNo = new TextBox();
            txtSupName = new TextBox();
            txtSupID = new TextBox();
            lblSupEmail = new Label();
            lblSupPhoneNo = new Label();
            lblBrand = new Label();
            lblSupName = new Label();
            lblSupID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(350, 303);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 43;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(250, 303);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 42;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblStoredSuppliers
            // 
            lblStoredSuppliers.AutoSize = true;
            lblStoredSuppliers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredSuppliers.Location = new Point(391, 37);
            lblStoredSuppliers.Name = "lblStoredSuppliers";
            lblStoredSuppliers.Size = new Size(127, 20);
            lblStoredSuppliers.TabIndex = 41;
            lblStoredSuppliers.Text = "Stored Suppliers:";
            // 
            // dgvSupplier
            // 
            dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplier.Location = new Point(391, 64);
            dgvSupplier.Name = "dgvSupplier";
            dgvSupplier.RowHeadersWidth = 51;
            dgvSupplier.Size = new Size(385, 219);
            dgvSupplier.TabIndex = 40;
            dgvSupplier.CellClick += dgvSupplier_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(150, 303);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(50, 303);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 38;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(175, 235);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(171, 27);
            txtBrand.TabIndex = 37;
            // 
            // txtSupEmail
            // 
            txtSupEmail.Location = new Point(175, 202);
            txtSupEmail.Name = "txtSupEmail";
            txtSupEmail.Size = new Size(171, 27);
            txtSupEmail.TabIndex = 36;
            // 
            // txtSupPhoneNo
            // 
            txtSupPhoneNo.Location = new Point(175, 169);
            txtSupPhoneNo.Name = "txtSupPhoneNo";
            txtSupPhoneNo.Size = new Size(171, 27);
            txtSupPhoneNo.TabIndex = 35;
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(175, 136);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(169, 27);
            txtSupName.TabIndex = 31;
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(175, 103);
            txtSupID.Name = "txtSupID";
            txtSupID.Size = new Size(171, 27);
            txtSupID.TabIndex = 30;
            // 
            // lblSupEmail
            // 
            lblSupEmail.AutoSize = true;
            lblSupEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupEmail.Location = new Point(57, 205);
            lblSupEmail.Name = "lblSupEmail";
            lblSupEmail.Size = new Size(112, 20);
            lblSupEmail.TabIndex = 28;
            lblSupEmail.Text = "Supplier Email:";
            // 
            // lblSupPhoneNo
            // 
            lblSupPhoneNo.AutoSize = true;
            lblSupPhoneNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupPhoneNo.Location = new Point(49, 172);
            lblSupPhoneNo.Name = "lblSupPhoneNo";
            lblSupPhoneNo.Size = new Size(120, 20);
            lblSupPhoneNo.TabIndex = 27;
            lblSupPhoneNo.Text = "Phone Number:";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBrand.Location = new Point(116, 235);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(55, 20);
            lblBrand.TabIndex = 26;
            lblBrand.Text = "Brand:";
            // 
            // lblSupName
            // 
            lblSupName.AutoSize = true;
            lblSupName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupName.Location = new Point(53, 136);
            lblSupName.Name = "lblSupName";
            lblSupName.Size = new Size(116, 20);
            lblSupName.TabIndex = 23;
            lblSupName.Text = "Supplier Name:";
            // 
            // lblSupID
            // 
            lblSupID.AutoSize = true;
            lblSupID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSupID.Location = new Point(79, 106);
            lblSupID.Name = "lblSupID";
            lblSupID.Size = new Size(90, 20);
            lblSupID.TabIndex = 22;
            lblSupID.Text = "Supplier ID:";
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 411);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblStoredSuppliers);
            Controls.Add(dgvSupplier);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(txtBrand);
            Controls.Add(txtSupEmail);
            Controls.Add(txtSupPhoneNo);
            Controls.Add(txtSupName);
            Controls.Add(txtSupID);
            Controls.Add(lblSupEmail);
            Controls.Add(lblSupPhoneNo);
            Controls.Add(lblBrand);
            Controls.Add(lblSupName);
            Controls.Add(lblSupID);
            Name = "Supplier";
            Text = "Supplier";
            ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button btnDelete;
        private Label lblStoredSuppliers;
        private DataGridView dgvSupplier;
        private Button btnUpdate;
        private Button btnSubmit;
        private TextBox txtBrand;
        private TextBox txtSupEmail;
        private TextBox txtSupPhoneNo;
        private TextBox txtSupName;
        private TextBox txtSupID;
        private Label lblSupEmail;
        private Label lblSupPhoneNo;
        private Label lblBrand;
        private Label lblSupName;
        private Label lblSupID;
    }
}