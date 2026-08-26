using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TawandaSystem
{
    public partial class UserManagement : Form
    {

        private string loggedInUsername;
        private string loggedInRole;

        private readonly string connectionString =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";


        public UserManagement(string username, string role)
        {
            InitializeComponent();
            loggedInUsername = username;
            loggedInRole = role;
        }

        public UserManagement()
{
    InitializeComponent();

    loggedInUsername = "";
    loggedInRole = "";
}

        private void lblSubtitle_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void LoadUsers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT
                    User_Name AS Username,
                    User_Role AS Role,
                    Account_Status AS Status
                FROM LOGIN
                ORDER BY User_Name";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvUsers.DataSource = table;
                        StyleUserGrid();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to load users from the TAWANDA database.\n\n" +
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

        private void StyleUserGrid()
        {
            // Basic appearance
            dgvUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.ReadOnly = true;

            // Selection
            dgvUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsers.MultiSelect = false;

            // Header
            dgvUsers.EnableHeadersVisualStyles = false;

            dgvUsers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvUsers.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Cells
            dgvUsers.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvUsers.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Row height
            dgvUsers.RowTemplate.Height = 30;

            // Alternating rows
            dgvUsers.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Color.WhiteSmoke
                };

            // Remove row headers
            dgvUsers.RowHeadersVisible = false;
        }

        private void dgvUsers_CellClick(
    object sender,
    DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

                txtSelectedUser.Text =
                    row.Cells["Username"].Value?.ToString();

                cmbRole.Text =
                    row.Cells["Role"].Value?.ToString();

                cmbAccountStatus.Text =
                    row.Cells["Status"].Value?.ToString();
            }
        }





        private void btnUpdateRole_Click_1(object sender, EventArgs e)
        {
            string selectedUsername = txtSelectedUser.Text.Trim();
            string newRole = cmbRole.Text.Trim();
            string newStatus = cmbAccountStatus.Text.Trim();

            // Check that a user is selected
            if (string.IsNullOrWhiteSpace(selectedUsername))
            {
                MessageBox.Show(
                    "Please select a user from the list first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check that a role is selected
            if (string.IsNullOrWhiteSpace(newRole))
            {
                MessageBox.Show(
                    "Please select a role.",
                    "Role Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Check that a status is selected
            if (string.IsNullOrWhiteSpace(newStatus))
            {
                MessageBox.Show(
                    "Please select an account status.",
                    "Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Prevent Administrator from changing their own role/status
            if (selectedUsername.Equals(
                loggedInUsername,
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You cannot change your own role or account status.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    // CHECK WHETHER SELECTED USER IS LAST ADMIN
                    // ------------------------------------------------

                    string currentRoleQuery = @"
                SELECT User_Role
                FROM LOGIN
                WHERE User_Name = @username";

                    string currentRole = "";

                    using (SqlCommand roleCmd =
                        new SqlCommand(currentRoleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue(
                            "@username",
                            selectedUsername);

                        object roleResult =
                            roleCmd.ExecuteScalar();

                        if (roleResult != null)
                        {
                            currentRole = roleResult.ToString();
                        }
                    }

                    // If this user is currently an Administrator
                    // and we are removing Administrator privileges
                    if (currentRole.Equals(
                            "Administrator",
                            StringComparison.OrdinalIgnoreCase)
                        &&
                        (!newRole.Equals(
                            "Administrator",
                            StringComparison.OrdinalIgnoreCase)
                         ||
                         !newStatus.Equals(
                            "Active",
                            StringComparison.OrdinalIgnoreCase)))
                    {
                        string adminCountQuery = @"
                    SELECT COUNT(*)
                    FROM LOGIN
                    WHERE User_Role = 'Administrator'
                    AND Account_Status = 'Active'";

                        using (SqlCommand adminCmd =
                            new SqlCommand(adminCountQuery, conn))
                        {
                            int activeAdminCount =
                                Convert.ToInt32(
                                    adminCmd.ExecuteScalar());

                            if (activeAdminCount <= 1)
                            {
                                MessageBox.Show(
                                    "This user is the last active Administrator.\n\n" +
                                    "You must have at least one active Administrator " +
                                    "in the system.",
                                    "Action Not Allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }
                        }
                    }

                    // ------------------------------------------------
                    // CONFIRM UPDATE
                    // ------------------------------------------------

                    DialogResult confirm = MessageBox.Show(
                        "Update the account for " + selectedUsername +
                        "?\n\nRole: " + newRole +
                        "\nStatus: " + newStatus,
                        "Confirm Account Update",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // ------------------------------------------------
                    // UPDATE USER
                    // ------------------------------------------------

                    string query = @"
                UPDATE LOGIN
                SET User_Role = @role,
                    Account_Status = @status
                WHERE User_Name = @username";

                    using (SqlCommand cmd =
                        new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue(
                            "@role",
                            newRole);

                        cmd.Parameters.AddWithValue(
                            "@status",
                            newStatus);

                        cmd.Parameters.AddWithValue(
                            "@username",
                            selectedUsername);

                        int rowsAffected =
                            cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "User account updated successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadUsers();

                            txtSelectedUser.Clear();
                            cmbRole.SelectedIndex = -1;
                            cmbAccountStatus.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to update the user account.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            string selectedUsername = txtSelectedUser.Text.Trim();

            // Check that a user has been selected
            if (string.IsNullOrWhiteSpace(selectedUsername))
            {
                MessageBox.Show(
                    "Please select a user from the list first.",
                    "No User Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Prevent Administrator from deleting their own account
            if (selectedUsername.Equals(
                loggedInUsername,
                StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    "You cannot delete your own account.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check whether the selected user is an Administrator
                    string roleQuery = @"
                SELECT User_Role
                FROM LOGIN
                WHERE User_Name = @username";

                    string selectedRole = "";

                    using (SqlCommand roleCmd =
                        new SqlCommand(roleQuery, conn))
                    {
                        roleCmd.Parameters.AddWithValue(
                            "@username",
                            selectedUsername);

                        object roleResult = roleCmd.ExecuteScalar();

                        if (roleResult != null)
                        {
                            selectedRole = roleResult.ToString();
                        }
                    }

                    // If the selected user is an Administrator,
                    // check how many Administrators exist
                    if (selectedRole.Equals(
                        "Administrator",
                        StringComparison.OrdinalIgnoreCase))
                    {
                        string countQuery = @"
                    SELECT COUNT(*)
                    FROM LOGIN
                    WHERE User_Role = 'Administrator'
                    AND Account_Status = 'Active'";

                        using (SqlCommand countCmd =
                            new SqlCommand(countQuery, conn))
                        {
                            int adminCount =
                                Convert.ToInt32(countCmd.ExecuteScalar());

                            if (adminCount <= 1)
                            {
                                MessageBox.Show(
                                    "This account cannot be deleted because it is the last active Administrator.",
                                    "Action Not Allowed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }
                        }
                    }

                    // Confirm deletion
                    DialogResult confirm = MessageBox.Show(
                        "Are you sure you want to delete the account for " +
                        selectedUsername + "?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirm != DialogResult.Yes)
                    {
                        return;
                    }

                    // Delete the account
                    string deleteQuery = @"
                DELETE FROM LOGIN
                WHERE User_Name = @username";

                    using (SqlCommand deleteCmd =
                        new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue(
                            "@username",
                            selectedUsername);

                        int rowsAffected =
                            deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "User account deleted successfully.",
                                "User Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            txtSelectedUser.Clear();
                            cmbRole.SelectedIndex = -1;
                            cmbAccountStatus.SelectedIndex = -1;

                            LoadUsers();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to delete the user.\n\n" +
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

        private void btnReload_Click_1(object sender, EventArgs e)
        {
            LoadUsers();

            txtSelectedUser.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            AccessControl accessForm =
                new AccessControl(loggedInUsername, loggedInRole);

            accessForm.Show();
            this.Close();
        }
    }
}
