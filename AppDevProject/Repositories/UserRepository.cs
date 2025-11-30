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
    public static class UserRepository
    {
        public static List<User> GetAllUsers()
        {
            var list = new List<User>();

            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM users";

                using (var cmd = new MySqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new User
                        {
                            UserID = reader.GetInt32("userID"),
                            Username = reader.GetString("username"),
                            Password = reader.GetString("password"),
                            FirstName = reader.GetString("firstName"),
                            LastName = reader.GetString("lastName"),
                            PhoneNum = reader.GetString("phoneNum")
                        });
                    }
                }
            }

            return list;
        }

        public static List<User> FilterUsers(string search)
        {
            var list = new List<User>();
            string pattern = "%" + search + "%";

            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT * FROM users
                               WHERE username LIKE @s
                                  OR firstName LIKE @s
                                  OR lastName LIKE @s";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@s", pattern);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new User
                            {
                                UserID = reader.GetInt32("userID"),
                                Username = reader.GetString("username"),
                                Password = reader.GetString("password"),
                                FirstName = reader.GetString("firstName"),
                                LastName = reader.GetString("lastName"),
                                PhoneNum = reader.GetString("phoneNum")
                            });
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertUser(User u)
        {
            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO users
                               (username, password, firstName, lastName, phoneNum)
                               VALUES (@u, @p, @f, @l, @ph)";

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@u", u.Username);
                    cmd.Parameters.AddWithValue("@p", u.Password);
                    cmd.Parameters.AddWithValue("@f", u.FirstName);
                    cmd.Parameters.AddWithValue("@l", u.LastName);
                    cmd.Parameters.AddWithValue("@ph", u.PhoneNum);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
