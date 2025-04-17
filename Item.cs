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
    public partial class Item : Form
    {
        public Item()
        {
            InitializeComponent();
            fillComboBox();
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
            param[0] = new MySqlParameter("itemID", MySqlDbType.Int64);
            param[0].Value = txtItemID.Text;
            param[1] = new MySqlParameter("supID", MySqlDbType.Int64);
            param[1].Value = txtSupplierID.Text;
            param[2] = new MySqlParameter("itemName", MySqlDbType.VarChar);
            param[2].Value = txtItemName.Text;
            param[3] = new MySqlParameter("quantityNum", MySqlDbType.Float);
            param[3].Value = nmricQuantity.Text;
            param[4] = new MySqlParameter("categoryName", MySqlDbType.VarChar);
            param[4].Value = cmbCategory.Text;
            param[5] = new MySqlParameter("itemCost", MySqlDbType.Float);
            param[5].Value = nmricItemCost.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertItem";
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

        private void fillComboBox()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Produce");
            cmbCategory.Items.Add("Electronics");
            cmbCategory.Items.Add("Stationery");
            cmbCategory.Items.Add("Medical");
            cmbCategory.Items.Add("Toys");
        }

        private void fillDataGridView()
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowItem";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvItems.DataSource = dt;

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[6];
            param[0] = new MySqlParameter("itemID", MySqlDbType.Int64);
            param[0].Value = txtItemID.Text;
            param[1] = new MySqlParameter("supID", MySqlDbType.Int64);
            param[1].Value = txtSupplierID.Text;
            param[2] = new MySqlParameter("itemName", MySqlDbType.VarChar);
            param[2].Value = txtItemName.Text;
            param[3] = new MySqlParameter("quantityNum", MySqlDbType.Float);
            param[3].Value = nmricQuantity.Text;
            param[4] = new MySqlParameter("categoryName", MySqlDbType.VarChar);
            param[4].Value = cmbCategory.Text;
            param[5] = new MySqlParameter("itemCost", MySqlDbType.Float);
            param[5].Value = nmricItemCost.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateItem";
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
            txtItemID.Text = "";
            txtSupplierID.Text = "";
            txtItemName.Text = "";
            nmricQuantity.Text = "";
            nmricItemCost.Text = "";
            cmbCategory.Text = "";
            nmricItemCost.Text = "";
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
            param[0] = new MySqlParameter("itemID", MySqlDbType.Int64);
            param[0].Value = txtItemID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteItem";
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

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtItemID.Text = dgvItems.Rows[e.RowIndex].Cells["item_id"].Value.ToString();
            txtSupplierID.Text = dgvItems.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
            txtItemName.Text = dgvItems.Rows[e.RowIndex].Cells["item_name"].Value.ToString();
            nmricQuantity.Text = dgvItems.Rows[e.RowIndex].Cells["quantity"].Value.ToString();
            cmbCategory.Text = dgvItems.Rows[e.RowIndex].Cells["category"].Value.ToString();
            nmricItemCost.Text = dgvItems.Rows[e.RowIndex].Cells["item_cost"].Value.ToString();
        }
    }
}
