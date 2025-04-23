using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Shipment : Form
    {
        public Shipment()
        {
            InitializeComponent();
            loadWarehouseComboBox();
            loadStatusComboBox();
            loadOrderComboBox();
            fillDataGridView();
        }

        string connectionString()
        {
            string server = "localhost";
            string database = "inventorymanagement";
            string uid = "root";
            string pass = "MyCLyde1$$<>";
            string connectionString = "Server=" + server + ";database=" + database + ";uid=" + uid + ";password=" + pass;
            return connectionString;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("shipmentID", MySqlDbType.Int64);
            param[0].Value = txtShipmentID.Text;
            param[1] = new MySqlParameter("warehouseID", MySqlDbType.Int64);
            string selectedWarehouse = cmbWarehouseID.SelectedItem.ToString();
            int warehouseID = int.Parse(selectedWarehouse.Split('-')[0].Trim());
            param[1].Value = warehouseID;
            param[2] = new MySqlParameter("orderID", MySqlDbType.Int64);
            string selectedOrder = cmbOrderID.SelectedItem.ToString();
            int orderID = int.Parse(selectedOrder.Split('-')[0].Trim());
            param[2].Value = orderID;
            param[3] = new MySqlParameter("shipmentCost", MySqlDbType.Float);
            param[3].Value = nmricShipmentCost.Text;
            param[4] = new MySqlParameter("shipmentDate", MySqlDbType.Date);
            param[4].Value = dtpShipmentDate.Value.Date;
            param[5] = new MySqlParameter("statusName", MySqlDbType.VarChar);
            param[5].Value = cmbStatus.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertShipment";
            cmd.Parameters.AddRange(param);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Insertion successful");
                fillDataGridView();
                clearData();
            }
            else
            {
                MessageBox.Show("Insertion failed");
            }

            conn.Close();
        }

        private void loadWarehouseComboBox()
        {
            cmbWarehouseID.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT warehouse_id, address FROM warehouse", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string display = $"{reader["warehouse_id"]} - {reader["address"]}";
                cmbWarehouseID.Items.Add(display);
            }

            conn.Close();
        }

        private void loadOrderComboBox()
        {
            cmbOrderID.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT order_id, order_date FROM inventorymanagement.order", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string display = $"{reader["order_id"]} - {reader["order_date"]}";
                cmbOrderID.Items.Add(display);
            }

            conn.Close();
        }

        private void loadStatusComboBox()
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Processing");
            cmbStatus.Items.Add("Shipped");
            cmbStatus.Items.Add("Delivered");
        }

        private void fillDataGridView()
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowShipment";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvShipments.DataSource = dt;

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("shipmentID", MySqlDbType.Int64);
            param[0].Value = txtShipmentID.Text;
            param[1] = new MySqlParameter("warehouseID", MySqlDbType.Int64);
            string selectedWarehouse = cmbWarehouseID.SelectedItem.ToString();
            int warehouseID = int.Parse(selectedWarehouse.Split('-')[0].Trim());
            param[1].Value = warehouseID;
            param[2] = new MySqlParameter("orderID", MySqlDbType.Int64);
            string selectedOrder = cmbOrderID.SelectedItem.ToString();
            int orderID = int.Parse(selectedOrder.Split('-')[0].Trim());
            param[2].Value = orderID;
            param[3] = new MySqlParameter("shipmentCost", MySqlDbType.Float);
            param[3].Value = nmricShipmentCost.Text;
            param[4] = new MySqlParameter("shipmentDate", MySqlDbType.Date);
            param[4].Value = dtpShipmentDate.Value.Date;
            param[5] = new MySqlParameter("statusName", MySqlDbType.VarChar);
            param[5].Value = cmbStatus.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateShipment";
            cmd.Parameters.AddRange(param);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Update successful");
                fillDataGridView();
                clearData();
            }
            else
            {
                MessageBox.Show("Update failed");
            }

            conn.Close();
        }

        private void clearData()
        {
            txtShipmentID.Text = "";
            cmbWarehouseID.Text = "";
            cmbOrderID.Text = "";
            nmricShipmentCost.Value = 0;
            dtpShipmentDate.Value = DateTime.Today;
            cmbStatus.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("shipmentID", MySqlDbType.Int64);
            param[0].Value = txtShipmentID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteShipment";
            cmd.Parameters.AddRange(param);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Deletion successful");
                fillDataGridView();
                clearData();
            }
            else
            {
                MessageBox.Show("Deletion failed");
            }

            conn.Close();
        }

        private void dgvShipments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtShipmentID.Text = dgvShipments.Rows[e.RowIndex].Cells["shipment_id"].Value.ToString();
            cmbWarehouseID.Text = dgvShipments.Rows[e.RowIndex].Cells["warehouse_id"].Value.ToString();
            cmbOrderID.Text = dgvShipments.Rows[e.RowIndex].Cells["order_id"].Value.ToString();
            nmricShipmentCost.Text = dgvShipments.Rows[e.RowIndex].Cells["shipment_cost"].Value.ToString();
            dtpShipmentDate.Text = dgvShipments.Rows[e.RowIndex].Cells["shipment_date"].Value.ToString();
            cmbStatus.Text = dgvShipments.Rows[e.RowIndex].Cells["status"].Value.ToString();
        }
    }
}
