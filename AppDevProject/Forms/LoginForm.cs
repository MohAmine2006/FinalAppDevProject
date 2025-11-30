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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            // basic styling – you can tweak as you like
            this.Text = "Smart Expense Tracker - Login";
            this.Width = 1000;
            this.Height = 650;

            this.BackColor = System.Drawing.Color.FromArgb(209, 247, 209); // soft green

            lblTitle.Text = "Smart Expense Tracker";
            lblSubtitle.Text = "Please log in to continue";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open Main Menu Form
                MainMenuForm menu = new MainMenuForm();
                menu.Show();

                this.Hide(); // hide login screen
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateLoginFromDatabase(string username, string password)
        {
            // Simple query against your existing users table in MySQL
            const string sql = "SELECT COUNT(*) FROM users WHERE username = @u AND password = @p";

            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                conn.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
