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

            // Load all transactions into the DataGridView
            LoadTransactions();

            // Connect textbox search event to filtering function
            WireEvents();
        }

        // Creates and returns a new MySQL connection
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection("server=127.0.0.1;database=expense;uid=root;pwd=;");
        }

        // Retrieves all transactions from database and displays them in the grid
        private void LoadTransactions()
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); // open connection

                string query = "SELECT * FROM transactions"; // SQL query to fetch rows

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable table = new DataTable();

                adapter.Fill(table); // fill table with returned rows

                transactionsGrid.DataSource = table; // display data in the grid
            }
        }

        // Binds UI events to code methods(only used for filter)
        private void WireEvents()
        {
            // Each time user types in search box, filter results
            filterTextBox.TextChanged += (s, e) => FilterTransactions();
        }

        // Filters transactions based on amount, category, or date
        private void FilterTransactions()
        {
            string value = filterTextBox.Text.Trim(); // get input from the textbox

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                string query;

                // If input is a number, filter based on amount
                if (double.TryParse(value, out double amount))
                {
                    query = "SELECT * FROM transactions WHERE amount = @amount";
                }
                else
                {
                    // If input is a String, filter category or date 
                    query = "SELECT * FROM transactions WHERE category LIKE @v OR date LIKE @v";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Assign parameter value depending on type of search
                if (double.TryParse(value, out double amt))
                    cmd.Parameters.AddWithValue("@amount", amt);
                else
                    cmd.Parameters.AddWithValue("@v", "%" + value + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();

                adapter.Fill(table);

                // Refresh the grid with the filtered data
                transactionsGrid.DataSource = table;
            }
        }

        // Adds a new transaction record to database
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Statement to add new transaction values
                    string sql =
                        "INSERT INTO transactions (amount, category, type, date, note) " +
                        "VALUES (@a, @c, @t, @d, @n)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // Assign values taken from Add section textboxes
                    cmd.Parameters.AddWithValue("@a", txtAmountAdd.Text);
                    cmd.Parameters.AddWithValue("@c", txtCategoryAdd.Text);
                    cmd.Parameters.AddWithValue("@t", txtTypeAdd.Text);
                    cmd.Parameters.AddWithValue("@d", txtDateAdd.Text);
                    cmd.Parameters.AddWithValue("@n", txtNoteAdd.Text);

                    cmd.ExecuteNonQuery(); // execute
                }

                MessageBox.Show("Expense added successfully!", "Success");
                LoadTransactions(); // refresh table after insert
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding expense:\n" + ex.Message);
            }
        }

        // Removes a transaction based on ID entered
        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Delete transaction using matching ID
                    string sql =
                        "DELETE FROM transactions WHERE transactionID = @id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", txtDeleteID.Text);

                    cmd.ExecuteNonQuery(); // execute
                }

                MessageBox.Show("Expense deleted.", "Success");
                LoadTransactions(); // refresh display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting expense:\n" + ex.Message);
            }
        }

        // Button to return to main menu
        private void btnGoBack_Click(object sender, EventArgs e)
        {
            // Closes current form
            this.Close();

            // Opens a new instance of the main menu screen
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
        }

        // Updates existing transaction fields based on ID
        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // SQL to update existing row values
                    string sql = @"UPDATE transactions 
                                   SET amount=@a, category=@c, type=@t, date=@d, note=@n
                                   WHERE transactionID=@id";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    // Assign updated values taken from Edit section textboxes
                    cmd.Parameters.AddWithValue("@id", txtEditID.Text);
                    cmd.Parameters.AddWithValue("@a", txtAmountEdit.Text);
                    cmd.Parameters.AddWithValue("@c", txtCategoryEdit.Text);
                    cmd.Parameters.AddWithValue("@t", txtTypeEdit.Text);
                    cmd.Parameters.AddWithValue("@d", txtDateEdit.Text);
                    cmd.Parameters.AddWithValue("@n", txtNoteEdit.Text);

                    cmd.ExecuteNonQuery(); // run update
                }

                MessageBox.Show("Expense updated!", "Success");
                LoadTransactions(); // refresh displayed values
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
