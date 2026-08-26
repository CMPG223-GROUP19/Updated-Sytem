using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class LogIn : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";

        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPassword.Text;

            // -----------------------------
            // VALIDATE USERNAME
            // -----------------------------
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "Username Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUser.Focus();
                return;
            }

            // -----------------------------
            // VALIDATE PASSWORD
            // -----------------------------
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "Password Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();



                    string query = @"
    SELECT User_Role
    FROM LOGIN
    WHERE User_Name = @username
    AND User_passwords = @password
    AND Account_Status = 'Active'";

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(
                            "@username",
                            System.Data.SqlDbType.VarChar, 50).Value = username;

                        cmd.Parameters.Add(
                            "@password",
                            System.Data.SqlDbType.VarChar, 100).Value = password;

                        object result = cmd.ExecuteScalar();

                        // -----------------------------
                        // LOGIN FAILED
                        // -----------------------------
                        if (result == null)
                        {
                            MessageBox.Show(
                                "Invalid username or password.",
                                "Login Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                            txtPassword.Clear();
                            txtPassword.Focus();

                            return;
                        }

                        // -----------------------------
                        // GET USER ROLE
                        // -----------------------------
                        string userRole = result.ToString();

                        // -----------------------------
                        // OPEN ACCESS CONTROL
                        // -----------------------------
                        AccessControl accessForm =
                            new AccessControl(username, userRole);

                        accessForm.Show();

                        this.Hide();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to connect to the TAWANDA database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // -----------------------------
        // SHOW / HIDE PASSWORD
        // -----------------------------
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar =
                checkBox1.Checked ? '\0' : '*';
        }

        // -----------------------------
        // CANCEL / EXIT
        // -----------------------------
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // -----------------------------
        // HELP
        // -----------------------------
        private void lnkLogHelp_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            Help form = new Help();
            form.Show();
            this.Hide();
        }

        // -----------------------------
        // UNUSED EVENTS
        // -----------------------------
        private void comboBox1_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged_1(
            object sender,
            EventArgs e)
        {
            txtPassword.PasswordChar =
                checkBox1.Checked ? '\0' : '*';
        }

        private void LogIn_Load(
            object sender,
            EventArgs e)
        {
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }
    }
}