using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TawandaSystem
{
    public partial class AccessControl : Form
    {
        private readonly string loggedInUsername;
        private readonly string loggedInRole;

        private readonly string connectionString =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True";

        // ============================================================
        // CONSTRUCTOR
        // ============================================================

        public AccessControl(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }

        // ============================================================
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public AccessControl()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void AccessControl_Load(object sender, EventArgs e)
        {
            ApplyPermissions();

            // Display logged-in user
            lblLoggedInUser.Text = "Welcome, " + loggedInUsername;
            lblLoggedInRole.Text = "Role: " + loggedInRole;

            // Check database connection
            CheckDatabaseConnection();

            // Form title
            this.Text = "Tawanda System - Access Management";
        }
        // ============================================================
        // APPLY USER PERMISSIONS
        // ============================================================

        private void ApplyPermissions()
        {
            // --------------------------------------------------------
            // HIDE ADMIN-ONLY BUTTON FIRST
            // --------------------------------------------------------

            btnUserManagement.Visible = false;

            // --------------------------------------------------------
            // STANDARD BUTTONS
            // --------------------------------------------------------

            btnChildren.Visible = true;
            btnDonations.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            // --------------------------------------------------------
            // ADMINISTRATOR ONLY
            // --------------------------------------------------------

            if (loggedInRole.Equals(
                "Administrator",
                StringComparison.OrdinalIgnoreCase))
            {
                btnUserManagement.Visible = true;
            }

            // --------------------------------------------------------
            // MANAGER
            // --------------------------------------------------------

            else if (loggedInRole.Equals(
                "Manager",
                StringComparison.OrdinalIgnoreCase))
            {
                btnUserManagement.Visible = false;
            }
        }

        private void CheckDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    lblDatabaseStatus.Text = "● Database Connected";
                }
            }
            catch
            {
                lblDatabaseStatus.Text = "● Database Disconnected";
            }
        }

        // ============================================================
        // CHILDREN
        // ============================================================

        private void btnChildren_Click(object sender, EventArgs e)
        {
            Children form =
                new Children(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
            this.Hide();
        }

        // ============================================================
        // DONATIONS
        // ============================================================

        private void btnDonations_Click(object sender, EventArgs e)
        {
            Donations form =
                new Donations(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
            this.Hide();
        }

        // ============================================================
        // DONATION REPORT
        // ============================================================

        private void button1_Click(object sender, EventArgs e)
        {
            DonationsReport form =
                new DonationsReport(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
            this.Hide();
        }

        // ============================================================
        // CHILDREN REPORT
        // ============================================================

        private void button2_Click(object sender, EventArgs e)
        {
            ChildReport form =
                new ChildReport(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
            this.Hide();
        }

        // ============================================================
        // USER MANAGEMENT
        // ADMINISTRATOR ONLY
        // ============================================================

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            // Extra security check
            if (!loggedInRole.Equals(
                "Administrator",
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "Only Administrators can access User Management.",
                    "Access Denied",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            UserManagement form =
                new UserManagement(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
            this.Hide();
        }

        // ============================================================
        // LOGOUT
        // ============================================================

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn loginForm = new LogIn();

                loginForm.Show();

                this.Close();
            }
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInRole_Click(object sender, EventArgs e)
        {

        }

        private void lblDatabaseStatus_Click(object sender, EventArgs e)
        {

        }
    }
}

