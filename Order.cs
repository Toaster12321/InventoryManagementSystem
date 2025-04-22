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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            loadItemComboBox();
            loadUserComboBox();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("orderID", MySqlDbType.Int64);
            param[0].Value = txtOrderID.Text;
            param[1] = new MySqlParameter("userID", MySqlDbType.Int64);
            string selectedUser = cmbUserID.SelectedItem.ToString();
            int userID = int.Parse(selectedUser.Split('-')[0].Trim());
            param[1].Value = userID;
            param[2] = new MySqlParameter("itemID", MySqlDbType.Int64);
            string selectedItem = cmbItemID.SelectedItem.ToString();
            int itemID = int.Parse(selectedItem.Split('-')[0].Trim());
            param[2].Value = itemID;
            param[3] = new MySqlParameter("orderDate", MySqlDbType.Date);
            param[3].Value = dtpOrderDate.Value.Date;
            param[4] = new MySqlParameter("deliveryDate", MySqlDbType.Date);
            param[4].Value = dtpDeliveryDate.Value.Date;
            param[5] = new MySqlParameter("totalCost", MySqlDbType.Float);
            param[5].Value = nmricTotalCost.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertOrder";
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

        private void loadUserComboBox()
        {
            cmbUserID.Items.Clear();
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT user_id, f_name, l_name FROM user", conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string display = $"{reader["user_id"]} - {reader["f_name"]} {reader["l_name"]}";
                cmbUserID.Items.Add(display);
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
            cmd.CommandText = "ShowOrder";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvOrder.DataSource = dt;

            conn.Close();
        }

        private void clearData()
        {
            txtOrderID.Text = "";
            cmbItemID.Text = "";
            cmbUserID.Text = "";
            dtpDeliveryDate.Value = DateTime.Today;
            dtpOrderDate.Value = DateTime.Today;
            nmricTotalCost.Value = 0;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOrderID.Text = dgvOrder.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            cmbItemID.Text = dgvOrder.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            cmbUserID.Text = dgvOrder.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
            dtpOrderDate.Text = dgvOrder.Rows[e.RowIndex].Cells["order_date"].Value.ToString();
            dtpDeliveryDate.Text = dgvOrder.Rows[e.RowIndex].Cells["delivery_date"].Value.ToString();
            nmricTotalCost.Text = dgvOrder.Rows[e.RowIndex].Cells["total_cost"].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("orderID", MySqlDbType.Int64);
            param[0].Value = txtOrderID.Text;
            param[1] = new MySqlParameter("userID", MySqlDbType.Int64);
            string selectedUser = cmbUserID.SelectedItem.ToString();
            int userID = int.Parse(selectedUser.Split('-')[0].Trim());
            param[1].Value = userID;
            param[2] = new MySqlParameter("itemID", MySqlDbType.Int64);
            string selectedItem = cmbItemID.SelectedItem.ToString();
            int itemID = int.Parse(selectedItem.Split('-')[0].Trim());
            param[2].Value = itemID;
            param[3] = new MySqlParameter("orderDate", MySqlDbType.Date);
            param[3].Value = dtpOrderDate.Value.Date;
            param[4] = new MySqlParameter("deliveryDate", MySqlDbType.Date);
            param[4].Value = dtpDeliveryDate.Value.Date;
            param[5] = new MySqlParameter("totalCost", MySqlDbType.Float);
            param[5].Value = nmricTotalCost.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateOrder";
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("orderID", MySqlDbType.Int64);
            param[0].Value = txtOrderID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrder";
            cmd.Parameters.AddRange(param);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Delete successful");
                fillDataGridView();
                clearData();
            }
            else
            {
                MessageBox.Show("Delete failed");
            }

            conn.Close();
        }
    }
}
