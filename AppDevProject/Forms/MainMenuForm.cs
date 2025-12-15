using AppDevProject.DatabaseConnector;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "TXT files (*.txt)|*.txt",
                FileName = "UserRecords.txt"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        for (int i = 0; i < dgvUsers.Columns.Count; i++)
                        {
                            sw.Write(dgvUsers.Columns[i].HeaderText);
                            if (i < dgvUsers.Columns.Count - 1)
                            {
                                sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dgvUsers.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                for (int i = 0; i < dgvUsers.Columns.Count; i++)
                                {
                                    sw.Write(row.Cells[i].Value?.ToString());
                                    if (i < dgvUsers.Columns.Count - 1)
                                    {
                                        sw.Write(",");
                                    }
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                    MessageBox.Show("Exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnOpenViewer_Click(object sender, EventArgs e)
        {
            CsvUserViewerForm viewer = new CsvUserViewerForm();
            viewer.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            MessageBox.Show("You have been logged out.", "Logout");
        }

        private void comboBoxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTheme.SelectedItem.ToString())
            {
                case "Light Mint":
                    this.BackColor = Color.FromArgb(233, 255, 244);
                    break;

                case "Soft Aqua":
                    this.BackColor = Color.FromArgb(200, 230, 220);
                    break;

                case "Sunset Peach":
                    this.BackColor = Color.FromArgb(255, 230, 220);
                    break;

                case "Lavender Breeze":
                    this.BackColor = Color.FromArgb(230, 225, 255);
                    break;

                case "Slate Grey":
                    this.BackColor = Color.FromArgb(220, 220, 220);
                    break;
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }
    }
}
