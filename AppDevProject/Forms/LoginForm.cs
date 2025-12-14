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

            if (ValidateLogin(username, password))
            {
                if (Session.Role == "user")
                {
                    UserMenuForm user = new UserMenuForm();
                    user.Show();
                    this.Hide();
                }
                else if (Session.Role == "admin")
                {
                    MainMenuForm admin = new MainMenuForm();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string sql = "SELECT userID, role FROM users WHERE username=@u AND password=@p";

            using (var conn = DatabaseAccess.GetConnection())
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
                    Session.Role = reader.GetString(1);
                    return true;
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
