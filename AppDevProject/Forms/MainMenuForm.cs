using System;
using System.Windows.Forms;

namespace AppDevProject.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        // Applies background color and window text
        private void SetupVisuals()
        {
            this.Text = "Smart Expense Tracker - Main Menu";
            this.AutoScaleMode = AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(233, 255, 244); // mint background
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            // Opens User Form
            UserForm user = new UserForm();
            user.Show();
            
            // Hides Main Menu
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            // Opens Transaction Form
            TransactionForm transaction = new TransactionForm();
            transaction.Show();

            // Hides Main Menu
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close Main Menu Form
            this.Close();

            // Reopen the Login screen
            LoginForm login = new LoginForm();
            login.Show();

            // Message to confirm logout
            MessageBox.Show("You have been logged out.", "Logout");
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
        }
    }
}
