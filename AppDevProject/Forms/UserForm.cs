using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDevProject.DatabaseConnector;
using MySql.Data.MySqlClient;

namespace AppDevProject.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        // Loads all users from DB and displays them in the DataGridView
        private void LoadUsers()
        {
            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand("SELECT userID, username, password, firstName, lastName, phoneNum FROM users", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
            }
        }

        // Reloads user records
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        // Insert new records into database
        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand(
                "INSERT INTO users (username, password, firstName, lastName, phoneNum) " +
                "VALUES (@u,@p,@f,@l,@ph)", conn))
            {
                cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@f", txtFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@l", txtLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User created successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearFields();
            LoadUsers();
        }

        // Clear the texfields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Method for clear button
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
        }

        // Close the program
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // Close User Form and reopens a new Main Menu Form
            this.Close();
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
        }
    }
}
