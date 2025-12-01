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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            SetupVisuals();
        }

        private void SetupVisuals()
        {
            this.Text = "Smart Expense Tracker - Main Menu";
            //this.Width = 1000;
            //this.Height = 650;
            this.AutoScaleMode = AutoScaleMode.None;

            this.BackColor = System.Drawing.Color.FromArgb(233, 255, 244); // light mint
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm();
            userForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            var transactionForm = new TransactionForm();
            transactionForm.ShowDialog();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
