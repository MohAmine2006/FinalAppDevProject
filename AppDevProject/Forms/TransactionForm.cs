using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppDevProject.Forms
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
            LoadTransactions();
            WireEvents();
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=127.0.0.1;database=expense;uid=root;pwd=;");
        }
        private void LoadTransactions()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transactions";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                transactionsGrid.DataSource = table;
            }
        }

        private void FilterTransactions()
        {
            string value = filterTextBox.Text.Trim();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query;

                // number? -> filter amount
                if (double.TryParse(value, out double amount))
                {
                    query = "SELECT * FROM transactions WHERE amount = @amount";
                }
                else
                {
                    query = "SELECT * FROM transactions WHERE category LIKE @v OR date LIKE @v";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                if (double.TryParse(value, out double amt))
                    cmd.Parameters.AddWithValue("@amount", amt);
                else
                    cmd.Parameters.AddWithValue("@v", "%" + value + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                transactionsGrid.DataSource = table;
            }
        }

        private void WireEvents()
        {
            filterTextBox.TextChanged += (s, e) => FilterTransactions();
            btnAddExpense.Click += (s, e) => AddExpense();
            btnDeleteExpense.Click += (s, e) => DeleteExpense();
            btnEditExpense.Click += (s, e) => EditExpense();
            btnGoBack.Click += (s, e) => this.Close();
        }
        private void AddExpense()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string sql = "INSERT INTO transactions (amount, category, type, date, note) VALUES (@a, @c, @t, @d, @n)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@a", txtAmountAdd.Text);
                    cmd.Parameters.AddWithValue("@c", txtCategoryAdd.Text);
                    cmd.Parameters.AddWithValue("@t", txtTypeAdd.Text);
                    cmd.Parameters.AddWithValue("@d", txtDateAdd.Text);
                    cmd.Parameters.AddWithValue("@n", txtNoteAdd.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense:\n" + ex.Message);
            }
        }

        private void DeleteExpense()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string sql = "DELETE FROM transactions WHERE transactionID = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtDeleteID.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Expense deleted.", "Success");
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting expense:\n" + ex.Message);
            }
        }

        private void EditExpense()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string sql = @"UPDATE transactions 
                                   SET amount=@a, category=@c, type=@t, date=@d, note=@n
                                   WHERE transactionID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtEditID.Text);
                    cmd.Parameters.AddWithValue("@a", txtAmountEdit.Text);
                    cmd.Parameters.AddWithValue("@c", txtCategoryEdit.Text);
                    cmd.Parameters.AddWithValue("@t", txtTypeEdit.Text);
                    cmd.Parameters.AddWithValue("@d", txtDateEdit.Text);
                    cmd.Parameters.AddWithValue("@n", txtNoteEdit.Text);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Expense updated!", "Success");
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating expense:\n" + ex.Message);
            }
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
