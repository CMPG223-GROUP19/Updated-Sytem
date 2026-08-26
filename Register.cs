using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;







namespace TawandaSystem
{
    public partial class Register : Form
    {

        private readonly string connectionString =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";
        public Register()
        {
            InitializeComponent();
        }

        
        

        

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            LogIn loginForm = new LogIn();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Check username
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter a username.",
                    "Username Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            // Check password
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter a password.",
                    "Password Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            // Check password confirmation
            if (password != confirmPassword)
            {
                MessageBox.Show(
                    "The passwords do not match.",
                    "Password Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check whether username already exists
                    string checkQuery = @"
                SELECT COUNT(*)
                FROM LOGIN
                WHERE User_Name = @username";

                    using (SqlCommand checkCmd =
                        new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);

                        int existingUser =
                            Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (existingUser > 0)
                        {
                            MessageBox.Show(
                                "That username already exists. Please choose another username.",
                                "Username Already Exists",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtUsername.Focus();
                            return;
                        }
                    }

                    // Create the new account
                    string insertQuery = @"
                INSERT INTO LOGIN
                    (User_Name, User_passwords, User_Role , Account_Status)
                VALUES
                    (@username, @password, 'Pending', 'Pending')";

                    using (SqlCommand insertCmd =
                        new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);

                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Account created successfully!\n\n" +
    "Your account is waiting for Administrator approval.",
    "Registration Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Return to Login
                    LogIn loginForm = new LogIn();
                    loginForm.Show();
                    this.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to create the account.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
