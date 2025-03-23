using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITEC_MANAGEMENT.DL;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ITEC_MANAGEMENT
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
           
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();
            string role = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;

            // Validation check for empty fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }

                    int roleId = GetRoleId(conn, role);
                    if (roleId == -1)
                    {
                        MessageBox.Show("Invalid role selected.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if username or email already exists
                    if (UserExists(conn, username, email))
                    {
                        MessageBox.Show("Username or Email already exists.", "Signup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert new user
                    string query = "INSERT INTO users (username, email, password_hash, role_id) VALUES (@username, @email, @password, @roleId)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", HashPassword(password)); // Make sure HashPassword method works correctly
                        cmd.Parameters.AddWithValue("@roleId", roleId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sign-Up successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Optionally close the form after successful signup
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Sign-Up failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Method to get the role ID from the 'lookup' table
        private int GetRoleId(MySqlConnection conn, string roleName)
        {
            string query = "SELECT lookup_id FROM lookup WHERE category = 'UserRoles' AND value = @roleName";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@roleName", roleName);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : -1;
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
        
        private bool UserExists(MySqlConnection conn, string username, string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username OR email = @Email";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }
    }
}

