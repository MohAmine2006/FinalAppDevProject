using System;
using System.Data;
using System.Windows.Forms;
using AppDevProject.DatabaseConnector;
using MySql.Data.MySqlClient;

namespace AppDevProject.Forms
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        // This button will insert a new user into the database
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseAccess.GetConnection())
                using (var cmd = new MySqlCommand(
                    "INSERT INTO users (username, password, firstName, lastName, phoneNum) VALUES (@u,@p,@f,@l,@ph)",
                    conn))
                {
                    // Send values from textboxes into SQL parameters
                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@f", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@l", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery(); // Insert record
                }

                MessageBox.Show("Account created successfully!", "Success");

                // Clear fields after success
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating account:\n" + ex.Message);
            }
        }

        // Clears all entry fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();
        }

        // Go back to login screen
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close(); // closes create form and returns to login automatically
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
