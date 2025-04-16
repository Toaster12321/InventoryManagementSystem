using Microsoft.Win32;

namespace InventoryManagementSystem
{
    public partial class InventoryManagement : Form
    {
        public InventoryManagement()
        {
            InitializeComponent();
        }

        private void manageShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shipment shipmentForm = new Shipment();
            shipmentForm.MdiParent = this;
            shipmentForm.Show();
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User userForm = new User();
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void manageOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order orderForm = new Order();
            orderForm.MdiParent = this;
            orderForm.Show();
        }

        private void manageWarehousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse warehouseForm = new Warehouse();
            warehouseForm.MdiParent = this;
            warehouseForm.Show();
        }

        private void manageItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Item itemForm = new Item();
            itemForm.MdiParent = this;
            itemForm.Show();
        }

        private void manageSuppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier supplierForm = new Supplier();
            supplierForm.MdiParent = this;
            supplierForm.Show();
        }
    }
}
