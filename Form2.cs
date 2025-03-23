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

namespace ITEC_MANAGEMENT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
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
        private bool ValidateUser(MySqlConnection conn, string username, string password, int roleId)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password_hash = @password AND role_id = @roleId";
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", HashPassword(password));
                cmd.Parameters.AddWithValue("@roleId", roleId);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp s = new SignUp();
            s.ShowDialog();
            s.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text.Trim();
            string passInput = textBox2.Text.Trim();
            string userRole = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(userInput) || string.IsNullOrWhiteSpace(passInput) || string.IsNullOrWhiteSpace(userRole))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var conn = DatabaseHelper.Instance.getConnection())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                    {
                        MessageBox.Show("Could not establish a connection to the database.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int roleId = GetRoleId(conn, userRole);
                    if (roleId == -1)
                    {
                        MessageBox.Show("Selected role is not valid.", "Role Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (ValidateUser(conn, userInput, passInput, roleId))
                    {
                        MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Incorrect credentials. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
