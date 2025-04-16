namespace InventoryManagementSystem
{
    partial class User
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
            lblUserID = new Label();
            lblFName = new Label();
            lblMName = new Label();
            lblLName = new Label();
            lblRole = new Label();
            lblPhoneNo = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtUserID = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtLastName = new TextBox();
            cmbRole = new ComboBox();
            txtPhoneNo = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSubmit = new Button();
            btnUpdate = new Button();
            dgvUsers = new DataGridView();
            lblStoredUsers = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserID.Location = new Point(109, 52);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(65, 20);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID:";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFName.Location = new Point(86, 85);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(90, 20);
            lblFName.TabIndex = 1;
            lblFName.Text = "First Name:";
            // 
            // lblMName
            // 
            lblMName.AutoSize = true;
            lblMName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMName.Location = new Point(69, 120);
            lblMName.Name = "lblMName";
            lblMName.Size = new Size(107, 20);
            lblMName.TabIndex = 2;
            lblMName.Text = "Middle Name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblLName.Location = new Point(86, 149);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(88, 20);
            lblLName.TabIndex = 3;
            lblLName.Text = "Last Name:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.Location = new Point(130, 184);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(44, 20);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // lblPhoneNo
            // 
            lblPhoneNo.AutoSize = true;
            lblPhoneNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPhoneNo.Location = new Point(54, 215);
            lblPhoneNo.Name = "lblPhoneNo";
            lblPhoneNo.Size = new Size(120, 20);
            lblPhoneNo.TabIndex = 5;
            lblPhoneNo.Text = "Phone Number:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.Location = new Point(123, 247);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPassword.Location = new Point(94, 284);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password:";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(180, 52);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(171, 27);
            txtUserID.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(182, 85);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(169, 27);
            txtFirstName.TabIndex = 9;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(182, 118);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(169, 27);
            txtMiddleName.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(180, 151);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(171, 27);
            txtLastName.TabIndex = 11;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(180, 184);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(171, 28);
            cmbRole.TabIndex = 12;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(180, 215);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(171, 27);
            txtPhoneNo.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 248);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(171, 27);
            txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 281);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(171, 27);
            txtPassword.TabIndex = 15;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(57, 354);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(157, 354);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(402, 79);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(471, 229);
            dgvUsers.TabIndex = 18;
            dgvUsers.CellClick += dgvUsers_CellClick;
            // 
            // lblStoredUsers
            // 
            lblStoredUsers.AutoSize = true;
            lblStoredUsers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStoredUsers.Location = new Point(402, 52);
            lblStoredUsers.Name = "lblStoredUsers";
            lblStoredUsers.Size = new Size(102, 20);
            lblStoredUsers.TabIndex = 19;
            lblStoredUsers.Text = "Stored Users:";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(257, 354);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(357, 354);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 451);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblStoredUsers);
            Controls.Add(dgvUsers);
            Controls.Add(btnUpdate);
            Controls.Add(btnSubmit);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNo);
            Controls.Add(cmbRole);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtUserID);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNo);
            Controls.Add(lblRole);
            Controls.Add(lblLName);
            Controls.Add(lblMName);
            Controls.Add(lblFName);
            Controls.Add(lblUserID);
            Name = "User";
            Text = "User";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserID;
        private Label lblFName;
        private Label lblMName;
        private Label lblLName;
        private Label lblRole;
        private Label lblPhoneNo;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtUserID;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtLastName;
        private ComboBox cmbRole;
        private TextBox txtPhoneNo;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSubmit;
        private Button btnUpdate;
        private DataGridView dgvUsers;
        private Label lblStoredUsers;
        private Button btnDelete;
        private Button btnClear;
    }
}