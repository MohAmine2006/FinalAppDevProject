using System;
using System.Windows.Forms;
using AppDevProject.DatabaseConnector;
using MySql.Data.MySqlClient;

namespace AppDevProject.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            this.Text = "Smart Expense Tracker - Login";
            this.BackColor = System.Drawing.Color.FromArgb(209, 247, 209); // light green background
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            try
            {
                if (ValidateLogin(username, password))
                {
                    var role = (Session.Role ?? string.Empty).Trim();

                    Form next = null;

                    if (string.Equals(role, "user", StringComparison.OrdinalIgnoreCase))
                    {
                        next = new UserMenuForm();
                    }
                    else if (string.Equals(role, "admin", StringComparison.OrdinalIgnoreCase))
                    {
                        next = new MainMenuForm();
                    }
                    else
                    {
                        // Unknown role - fallback to user menu so app continues
                        next = new UserMenuForm();
                    }

                    // Ensure the login form is closed when the next form is closed
                    next.FormClosed += (s, ev) => this.Close();

                    next.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string sql = "SELECT userID, role FROM users WHERE username=@u AND password=@p";

            using (var conn = DatabaseAccess.GetConnection())
            {
                if (conn == null)
                    throw new InvalidOperationException("Database connection is not available.");

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    conn.Open();
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Session.UserID = reader.GetInt32(0);
                        Session.Username = username;
                        Session.Role = reader.IsDBNull(1) ? null : reader.GetString(1);
                        return true;
                    }
                }
            }

            return false;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateForm create = new CreateForm();
            create.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0:
                    changeLanguage.UpdateConfig("Language", "en");
                    Application.Restart();
                    break;

                case 1:
                    changeLanguage.UpdateConfig("Language", "fr-CA");
                    Application.Restart();
                    break;

                case 2:
                    changeLanguage.UpdateConfig("Language", "es-ES");
                    Application.Restart();
                    break;
            }
        }
    }
}
