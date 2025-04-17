using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
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
            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("supID", MySqlDbType.Int64);
            param[0].Value = txtSupID.Text;
            param[1] = new MySqlParameter("phoneNum", MySqlDbType.VarChar);
            param[1].Value = txtSupPhoneNo.Text;
            param[2] = new MySqlParameter("emailAdd", MySqlDbType.VarChar);
            param[2].Value = txtSupEmail.Text;
            param[3] = new MySqlParameter("supName", MySqlDbType.VarChar);
            param[3].Value = txtSupName.Text;
            param[4] = new MySqlParameter("brandName", MySqlDbType.VarChar);
            param[4].Value = txtBrand.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertSupplier";
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

        private void fillDataGridView()
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ShowSupplier";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvSupplier.DataSource = dt;

            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[5];
            param[0] = new MySqlParameter("supID", MySqlDbType.Int64);
            param[0].Value = txtSupID.Text;
            param[1] = new MySqlParameter("phoneNum", MySqlDbType.VarChar);
            param[1].Value = txtSupPhoneNo.Text;
            param[2] = new MySqlParameter("emailAdd", MySqlDbType.VarChar);
            param[2].Value = txtSupEmail.Text;
            param[3] = new MySqlParameter("supName", MySqlDbType.VarChar);
            param[3].Value = txtSupName.Text;
            param[4] = new MySqlParameter("brandName", MySqlDbType.VarChar);
            param[4].Value = txtBrand.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateSupplier";
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
            txtSupID.Text = "";
            txtSupPhoneNo.Text = "";
            txtSupEmail.Text = "";
            txtSupName.Text = "";
            txtBrand.Text = "";
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
            param[0] = new MySqlParameter("supID", MySqlDbType.Int64);
            param[0].Value = txtSupID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteSupplier";
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

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSupID.Text = dgvSupplier.Rows[e.RowIndex].Cells["supplier_id"].Value.ToString();
            txtSupPhoneNo.Text = dgvSupplier.Rows[e.RowIndex].Cells["phone_no"].Value.ToString();
            txtSupEmail.Text = dgvSupplier.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtSupName.Text = dgvSupplier.Rows[e.RowIndex].Cells["supplier_name"].Value.ToString();
            txtBrand.Text = dgvSupplier.Rows[e.RowIndex].Cells["brand"].Value.ToString();
        }
    }
}
