using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDevProject.Forms
{
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            this.BackColor = System.Drawing.Color.FromArgb(233, 255, 244); // mint background
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            EditUserForm f = new EditUserForm();
            f.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TransactionForm t = new TransactionForm();
            t.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Session.UserID = 0;
            Session.Username = null;
            Session.Role = null;

            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void UserMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
