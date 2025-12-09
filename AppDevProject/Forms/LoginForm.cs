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
            // Read username and password
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // hardcoded login check
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!", "Success");

                // Opens main menu 
                MainMenuForm menu = new MainMenuForm();
                menu.Show();

                // Hides login screen
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Error");
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // open the CreateForm screen
            CreateForm create = new CreateForm();
            create.Show(); // open it as a normal window
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void languageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var changeLanguage = new ChangeLanguage();

            switch (languageComboBox.SelectedIndex)
            {
                case 0: // English
                    changeLanguage.UpdateConfig("Language", "en");
                    Application.Restart();
                    break;

                case 1: // French
                    changeLanguage.UpdateConfig("Language", "fr-CA");
                    Application.Restart();
                    break;

                case 2: // Spanish
                    changeLanguage.UpdateConfig("Language", "es-ES");
                    Application.Restart();
                    break;
            }
        }
    }
}
