using System;
using System.Data;
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
                string query = "SELECT * FROM transactions WHERE userID = @uid";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@uid", Session.UserID);

                DataTable table = new DataTable();
                adapter.Fill(table);

                transactionsGrid.DataSource = table;
            }
        }

        private void WireEvents()
        {
            filterTextBox.TextChanged += (s, e) => FilterTransactions();
        }

        private void FilterTransactions()
        {
            string value = filterTextBox.Text.Trim();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query;

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

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string sql = @"INSERT INTO transactions 
                    (amount, category, type, date, note, userID)
                    VALUES (@a, @c, @t, @d, @n, @uid)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@a", txtAmountAdd.Text);
                    cmd.Parameters.AddWithValue("@c", txtCategoryAdd.Text);
                    cmd.Parameters.AddWithValue("@t", txtTypeAdd.Text);
                    cmd.Parameters.AddWithValue("@d", dtpDateAdd.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@n", txtNoteAdd.Text);
                    cmd.Parameters.AddWithValue("@uid", Session.UserID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Expense added successfully!", "Success");
                LoadTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense:\n" + ex.Message);
            }
        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            UserMenuForm menu = new UserMenuForm();
            menu.Show();
        }

        private void btnEditExpense_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@d", dtpDateEdit.Value.ToString("yyyy-MM-dd"));
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
