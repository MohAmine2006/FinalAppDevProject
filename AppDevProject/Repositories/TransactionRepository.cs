using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDevProject.DatabaseConnector;
using AppDevProject.Models;
using MySql.Data.MySqlClient;

namespace AppDevProject.Repositories
{
    public static class TransactionRepository
    {
        public static List<Transaction> GetAllTransactions()
        {
            var list = new List<Transaction>();

            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM transactions";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            TransactionID = reader.GetInt32("transactionID"),
                            Amount = reader.GetDouble("amount"),
                            Category = reader.GetString("category"),
                            Type = reader.GetString("type"),
                            Date = reader.GetString("date"),
                            Note = reader.GetString("note")
                        });
                    }
                }
            }

            return list;
        }

        public static List<Transaction> FilterTransactions(double? amount, string text)
        {
            var list = new List<Transaction>();
            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();

                string sql;
                var cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (amount.HasValue)
                {
                    sql = "SELECT * FROM transactions WHERE amount = @a";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@a", amount.Value);
                }
                else
                {
                    sql = @"SELECT * FROM transactions
                            WHERE category LIKE @t OR date LIKE @t";
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@t", "%" + text + "%");
                }

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaction
                        {
                            TransactionID = reader.GetInt32("transactionID"),
                            Amount = reader.GetDouble("amount"),
                            Category = reader.GetString("category"),
                            Type = reader.GetString("type"),
                            Date = reader.GetString("date"),
                            Note = reader.GetString("note")
                        });
                    }
                }
            }

            return list;
        }

        public static void InsertTransaction(Transaction t)
        {
            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();

                string sql = @"INSERT INTO transactions
                               (amount, category, type, date, note)
                               VALUES (@a,@c,@t,@d,@n)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@a", t.Amount);
                    cmd.Parameters.AddWithValue("@c", t.Category);
                    cmd.Parameters.AddWithValue("@t", t.Type);
                    cmd.Parameters.AddWithValue("@d", t.Date);
                    cmd.Parameters.AddWithValue("@n", t.Note);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteTransaction(int id)
        {
            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM transactions WHERE transactionID=@id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateTransaction(Transaction t)
        {
            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE transactions
                               SET amount=@a, category=@c, type=@t, date=@d, note=@n
                               WHERE transactionID=@id";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", t.TransactionID);
                    cmd.Parameters.AddWithValue("@a", t.Amount);
                    cmd.Parameters.AddWithValue("@c", t.Category);
                    cmd.Parameters.AddWithValue("@t", t.Type);
                    cmd.Parameters.AddWithValue("@d", t.Date);
                    cmd.Parameters.AddWithValue("@n", t.Note);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
