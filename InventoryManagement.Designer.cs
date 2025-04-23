namespace InventoryManagementSystem
{
    partial class InventoryManagement
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            manageOrdersToolStripMenuItem = new ToolStripMenuItem();
            manageShipmentToolStripMenuItem = new ToolStripMenuItem();
            manageWarehousesToolStripMenuItem = new ToolStripMenuItem();
            manageItemsToolStripMenuItem = new ToolStripMenuItem();
            manageSuppliersToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageUsersToolStripMenuItem, manageOrdersToolStripMenuItem, manageShipmentToolStripMenuItem, manageWarehousesToolStripMenuItem, manageItemsToolStripMenuItem, manageSuppliersToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(229, 26);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            manageUsersToolStripMenuItem.Click += manageUsersToolStripMenuItem_Click;
            // 
            // manageOrdersToolStripMenuItem
            // 
            manageOrdersToolStripMenuItem.Name = "manageOrdersToolStripMenuItem";
            manageOrdersToolStripMenuItem.Size = new Size(229, 26);
            manageOrdersToolStripMenuItem.Text = "Manage Orders";
            manageOrdersToolStripMenuItem.Click += manageOrdersToolStripMenuItem_Click;
            // 
            // manageShipmentToolStripMenuItem
            // 
            manageShipmentToolStripMenuItem.Name = "manageShipmentToolStripMenuItem";
            manageShipmentToolStripMenuItem.Size = new Size(229, 26);
            manageShipmentToolStripMenuItem.Text = "Manage Shipments";
            manageShipmentToolStripMenuItem.Click += manageShipmentToolStripMenuItem_Click;
            // 
            // manageWarehousesToolStripMenuItem
            // 
            manageWarehousesToolStripMenuItem.Name = "manageWarehousesToolStripMenuItem";
            manageWarehousesToolStripMenuItem.Size = new Size(229, 26);
            manageWarehousesToolStripMenuItem.Text = "Manage Warehouses";
            manageWarehousesToolStripMenuItem.Click += manageWarehousesToolStripMenuItem_Click;
            // 
            // manageItemsToolStripMenuItem
            // 
            manageItemsToolStripMenuItem.Name = "manageItemsToolStripMenuItem";
            manageItemsToolStripMenuItem.Size = new Size(229, 26);
            manageItemsToolStripMenuItem.Text = "Manage Items";
            manageItemsToolStripMenuItem.Click += manageItemsToolStripMenuItem_Click;
            // 
            // manageSuppliersToolStripMenuItem
            // 
            manageSuppliersToolStripMenuItem.Name = "manageSuppliersToolStripMenuItem";
            manageSuppliersToolStripMenuItem.Size = new Size(229, 26);
            manageSuppliersToolStripMenuItem.Text = "Manage Suppliers";
            manageSuppliersToolStripMenuItem.Click += manageSuppliersToolStripMenuItem_Click;
            // 
            // InventoryManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "InventoryManagement";
            Text = "Inventory Mangament System";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem manageOrdersToolStripMenuItem;
        private ToolStripMenuItem manageShipmentToolStripMenuItem;
        private ToolStripMenuItem manageWarehousesToolStripMenuItem;
        private ToolStripMenuItem manageItemsToolStripMenuItem;
        private ToolStripMenuItem manageSuppliersToolStripMenuItem;
    }
}
