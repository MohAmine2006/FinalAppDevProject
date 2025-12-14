using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using AppDevProject.DatabaseConnector;
using MySql.Data.MySqlClient;

namespace AppDevProject.Forms
{
    public partial class MainMenuForm : Form
    {
        private bool isDarkTheme = false;
        public MainMenuForm()
        {
            InitializeComponent();
            SetupVisuals();
            LoadUsers();
        }

        // Applies background color and window text
        private void SetupVisuals()
        {
            this.Text = "Smart Expense Tracker - Main Menu";
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(233, 255, 244); // mint background
        }

        private void LoadUsers()
        {
            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT userID, username, firstName, lastName, phoneNum " +
                "FROM users WHERE role = 'user'", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvUsers.DataSource = table;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["userID"].Value);

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand("DELETE FROM users WHERE userID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", userID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("User deleted successfully.");
            LoadUsers();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a user first.");
                return;
            }

            int userID = Convert.ToInt32(
                dgvUsers.SelectedRows[0].Cells["userID"].Value);

            TransactionViewForm t = new TransactionViewForm();
            t.TargetUserID = userID;
            t.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            MessageBox.Show("You have been logged out.", "Logout");
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDarkTheme)
            {
                this.BackColor = Color.FromArgb(233, 255, 244);
                isDarkTheme = false;
            }
            else
            {
                this.BackColor = Color.FromArgb(200, 230, 220);
                isDarkTheme = true;
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }
    }
}
