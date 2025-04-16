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
    public partial class User : Form
    {
        public User()
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
            MySqlParameter[] param = new MySqlParameter[8];
            param[0] = new MySqlParameter("userID", MySqlDbType.Int64);
            param[0].Value = txtUserID.Text;
            param[1] = new MySqlParameter("firstName", MySqlDbType.VarChar);
            param[1].Value = txtFirstName.Text;
            param[2] = new MySqlParameter("middleName", MySqlDbType.VarChar);
            param[2].Value = txtMiddleName.Text;
            param[3] = new MySqlParameter("lastName", MySqlDbType.VarChar);
            param[3].Value = txtLastName.Text;
            param[4] = new MySqlParameter("roleName", MySqlDbType.VarChar);
            param[4].Value = cmbRole.Text;
            param[5] = new MySqlParameter("phoneNum", MySqlDbType.VarChar);
            param[5].Value = txtPhoneNo.Text;
            param[6] = new MySqlParameter("emailAdd", MySqlDbType.VarChar);
            param[6].Value = txtEmail.Text;
            param[7] = new MySqlParameter("pass", MySqlDbType.VarChar);
            param[7].Value = txtPassword.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertUser";
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

        private void clearData()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            cmbRole.Text = "";
            txtPhoneNo.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
        }

        private void fillComboBox()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Employee");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("CEO");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[8];
            param[0] = new MySqlParameter("userID", MySqlDbType.Int64);
            param[0].Value = txtUserID.Text;
            param[1] = new MySqlParameter("firstName", MySqlDbType.VarChar);
            param[1].Value = txtFirstName.Text;
            param[2] = new MySqlParameter("middleName", MySqlDbType.VarChar);
            param[2].Value = txtMiddleName.Text;
            param[3] = new MySqlParameter("lastName", MySqlDbType.VarChar);
            param[3].Value = txtLastName.Text;
            param[4] = new MySqlParameter("roleName", MySqlDbType.VarChar);
            param[4].Value = cmbRole.Text;
            param[5] = new MySqlParameter("phoneNum", MySqlDbType.VarChar);
            param[5].Value = txtPhoneNo.Text;
            param[6] = new MySqlParameter("emailAdd", MySqlDbType.VarChar);
            param[6].Value = txtEmail.Text;
            param[7] = new MySqlParameter("pass", MySqlDbType.VarChar);
            param[7].Value = txtPassword.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateUser";
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
            cmd.CommandText = "ShowUser";
            MySqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvUsers.DataSource = dt;

            conn.Close();
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserID.Text = dgvUsers.Rows[e.RowIndex].Cells["user_id"].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["f_name"].Value.ToString();
            txtMiddleName.Text = dgvUsers.Rows[e.RowIndex].Cells["m_name"].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["l_name"].Value.ToString();
            cmbRole.Text = dgvUsers.Rows[e.RowIndex].Cells["role"].Value.ToString();
            txtPhoneNo.Text = dgvUsers.Rows[e.RowIndex].Cells["phone_no"].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[e.RowIndex].Cells["email"].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["password"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connectionString());
            conn.Open();
            MySqlParameter[] param = new MySqlParameter[1];
            param[0] = new MySqlParameter("userID", MySqlDbType.Int64);
            param[0].Value = txtUserID.Text;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteUser";
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


        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }
    }
}
