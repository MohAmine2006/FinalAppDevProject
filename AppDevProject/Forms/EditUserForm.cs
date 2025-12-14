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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
        {
            InitializeComponent();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            using (var conn = DatabaseAccess.GetConnection())
            using (var cmd = new MySqlCommand("SELECT username, firstName, lastName, phoneNum FROM users WHERE userID=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", Session.UserID);

                conn.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtUsername.Text = reader.GetString("username");
                    txtFirstName.Text = reader.GetString("firstName");
                    txtLastName.Text = reader.GetString("lastName");
                    txtPhone.Text = reader.GetString("phoneNum");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text.Trim();
            string newFirst = txtFirstName.Text.Trim();
            string newLast = txtLastName.Text.Trim();
            string newPhone = txtPhone.Text.Trim();
            string newPassword = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            // If user is trying to change password, validate it first
            if (!string.IsNullOrEmpty(newPassword) || !string.IsNullOrEmpty(confirmPassword))
            {
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match!");
                    return;
                }
            }

            using (var conn = DatabaseAccess.GetConnection())
            {
                conn.Open();

                string sql;

                // ✔ password field is empty → update all fields EXCEPT password
                if (string.IsNullOrEmpty(newPassword))
                {
                    sql = @"UPDATE users 
                    SET username=@u, firstName=@f, lastName=@l, phoneNum=@p
                    WHERE userID=@id";
                }
                else
                {
                    // If password filled → update password as well
                    sql = @"UPDATE users 
                    SET username=@u, firstName=@f, lastName=@l, phoneNum=@p, password=@pw
                    WHERE userID=@id";
                }

                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", Session.UserID);
                    cmd.Parameters.AddWithValue("@u", newUsername);
                    cmd.Parameters.AddWithValue("@f", newFirst);
                    cmd.Parameters.AddWithValue("@l", newLast);
                    cmd.Parameters.AddWithValue("@p", newPhone);

                    if (!string.IsNullOrEmpty(newPassword))
                        cmd.Parameters.AddWithValue("@pw", newPassword);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Information updated successfully!");
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
