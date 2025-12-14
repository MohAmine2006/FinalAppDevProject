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
    public partial class TransactionViewForm : Form
    {
        public int TargetUserID { get; set; }

        public TransactionViewForm()
        {
            InitializeComponent();
            
        }

        private void LoadTransactions()
        {
            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand(
                "SELECT * FROM transactions WHERE userID = @id", conn))
            using (var adapter = new MySqlDataAdapter(cmd))
            {
                cmd.Parameters.AddWithValue("@id", TargetUserID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvTransactions.DataSource = table;
                dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Hide internal column
                if (dgvTransactions.Columns.Contains("userID"))
                    dgvTransactions.Columns["userID"].Visible = false;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Close();
        }

        private void TransactionViewForm_Load(object sender, EventArgs e)
        {
            LoadTransactions();
        }
    }
}
