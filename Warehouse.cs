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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace InventoryManagementSystem
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
            loadItemComboBox();
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
            MySqlParameter[] param = new MySqlParameter[4];
            param[0] = new MySqlParameter("warehouseID", MySqlDbType.Int64);
            param[0].Value = txtWarehouseID.Text;
            param[1] = new MySqlParameter("itemID", MySqlDbType.Int64);
            string selected = cmbItemID.SelectedItem.ToString();
            int itemID = int.Parse(selected.Split('-')[0].Trim());
            param[1].Value = itemID;
            param[2] = new MySqlParameter("capacityNum", MySqlDbType.Int64);
            param[2].Value = nmricCapacity.Text;
            param[3] = new MySqlParameter("addressName", MySqlDbType.VarChar);
            param[3].Value = txtAddress.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertWarehouse";
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

        private void loadItemComboBox()
        {
            cmbItemID.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT item_id, item_name FROM item", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string display = $"{reader["item_id"]} - {reader["item_name"]}";
                cmbItemID.Items.Add(display);
            }

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[4];
            param[0] = new MySqlParameter("warehouseID", MySqlDbType.Int64);
            param[0].Value = txtWarehouseID.Text;
            param[1] = new MySqlParameter("itemID", MySqlDbType.Int64);
            string selected = cmbItemID.SelectedItem.ToString();
            int itemID = int.Parse(selected.Split('-')[0].Trim());
            param[1].Value = itemID;
            param[2] = new MySqlParameter("capacityNum", MySqlDbType.Int64);
            param[2].Value = nmricCapacity.Text;
            param[3] = new MySqlParameter("addressName", MySqlDbType.VarChar);
            param[3].Value = txtAddress.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateWarehouse";
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

        private void fillDataGridView()
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowWarehouse";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvWarehouse.DataSource = dt;

            conn.Close();
        }

        private void clearData()
        {
            txtWarehouseID.Text = "";
            cmbItemID.Text = "";
            nmricCapacity.Text = "";
            txtAddress.Text = "";
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
            param[0] = new MySqlParameter("warehouseID", MySqlDbType.Int64);
            param[0].Value = txtWarehouseID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteWarehouse";
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

        private void dgvWarehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtWarehouseID.Text = dgvWarehouse.Rows[e.RowIndex].Cells["warehouse_id"].Value.ToString();
            cmbItemID.Text = dgvWarehouse.Rows[e.RowIndex].Cells["warehouse_item_id"].Value.ToString();
            nmricCapacity.Text = dgvWarehouse.Rows[e.RowIndex].Cells["capacity"].Value.ToString();
            txtAddress.Text = dgvWarehouse.Rows[e.RowIndex].Cells["address"].Value.ToString();
        }
    }
}
