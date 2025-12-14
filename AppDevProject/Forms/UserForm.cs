using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void usersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtUserID.Text = row.Cells["userID"].Value.ToString();
                txtUsername.Text = row.Cells["username"].Value.ToString();
                txtPassword.Text = row.Cells["password"].Value.ToString();
                txtFirstName.Text = row.Cells["firstName"].Value.ToString();
                txtLastName.Text = row.Cells["lastName"].Value.ToString();
                txtPhone.Text = row.Cells["phoneNum"].Value.ToString();
            }
        }

        private void FilterUsers()
        {
            string value = txtFilter.Text.Trim();

            using (MySqlConnection conn = DatabaseAccess.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM users " +
                               "WHERE username LIKE @v OR firstName LIKE @v OR lastName LIKE @v";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@v", "%" + value + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvUsers.DataSource = table;
            }
        }

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterUsers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseAccess.GetConnection())
                {
                    conn.Open();

                    string sql = "UPDATE users SET username=@u, password=@p, firstName=@f, lastName=@l, phoneNum=@ph " +
                        "WHERE userID=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@u", txtUsername.Text.Trim());
                    cmd.Parameters.AddWithValue("@p", txtPassword.Text.Trim());
                    cmd.Parameters.AddWithValue("@f", txtFirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@l", txtLastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ph", txtPhone.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtUserID.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user:\n" + ex.Message);
            }
            ClearFields();
        }

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var conn = DatabaseAccess.GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM users WHERE userID=@id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtUserID.Text.Trim());

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete user:\n" + ex.Message);
            }
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

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
