using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class Children : Form
    {
        private readonly string loggedInUsername;
        private readonly string loggedInRole;

        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True";

        // Stores the ID of the child selected in the DataGridView.
        // The user does NOT see or enter this ID.
        private int selectedChildID = 0;

        // =========================================================
        // CONSTRUCTORS
        // =========================================================

        public Children(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }

        // Default constructor for the Designer
        public Children()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void Children_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = "Welcome, " + loggedInUsername;
            lblLoggedInRole.Text = "Role: " + loggedInRole;

            dateTimePickerArrival.Value = DateTime.Today;

            // New child should NOT have a departure date
            dateTimePickerDeparture.Value = DateTime.Today;
            dateTimePickerDeparture.Checked = false;

            // New child is not accepted by default
            checkBoxAccepted.Checked = false;

            CheckDatabaseConnection();
            LoadChildren();
        }

        // =========================================================
        // DATABASE CONNECTION CHECK
        // =========================================================

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

        // =========================================================
        // LOAD CHILDREN
        // =========================================================

        private void LoadChildren()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            Accepted_YN,
                            Departure_Date
                        FROM Child_tbl
                        ORDER BY Child_ID ASC";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, connection))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvChildren.DataSource = table;

                        FormatDataGridView();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading children:\n\n" + ex.Message,
                    "Children Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // FORMAT DATAGRIDVIEW
        // =========================================================

        private void FormatDataGridView()
        {
            if (dgvChildren.Columns.Count == 0)
                return;

            dgvChildren.Columns["Child_ID"].HeaderText = "Child ID";
            dgvChildren.Columns["Child_LName"].HeaderText = "Last Name";
            dgvChildren.Columns["Child_FName"].HeaderText = "First Name";
            dgvChildren.Columns["ID_Number"].HeaderText = "ID Number";
            dgvChildren.Columns["Arrival_Date"].HeaderText = "Arrival Date";
            dgvChildren.Columns["Accepted_YN"].HeaderText = "Accepted";
            dgvChildren.Columns["Departure_Date"].HeaderText = "Departure Date";

            dgvChildren.Columns["Arrival_Date"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvChildren.Columns["Departure_Date"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvChildren.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvChildren.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvChildren.MultiSelect = false;

            dgvChildren.ReadOnly = true;

            dgvChildren.AllowUserToAddRows = false;
        }

        // =========================================================
        // VALIDATION
        // =========================================================

        private bool ValidateChildDetails()
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show(
                    "Please enter the child's last name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show(
                    "Please enter the child's first name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtIdNumber.Text))
            {
                MessageBox.Show(
                    "Please enter the child's ID number.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdNumber.Focus();
                return false;
            }

            if (txtIdNumber.Text.Trim().Length != 13)
            {
                MessageBox.Show(
                    "The ID number must contain 13 digits.",
                    "Invalid ID Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdNumber.Focus();
                return false;
            }

            return true;
        }

        // =========================================================
        // CLEAR
        // =========================================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtLastName.Clear();
            txtFirstName.Clear();
            txtIdNumber.Clear();

            dateTimePickerArrival.Value = DateTime.Today;

            // New record has no departure date
            dateTimePickerDeparture.Value = DateTime.Today;
            dateTimePickerDeparture.Checked = false;

            // New record is not accepted by default
            checkBoxAccepted.Checked = false;

            // No child is currently selected
            selectedChildID = 0;

            dgvChildren.ClearSelection();

            txtLastName.Focus();
        }

        // =========================================================
        // SELECT CHILD FROM DATAGRIDVIEW
        // =========================================================

        private void dgvChildren_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            // Ignore header
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row =
                    dgvChildren.Rows[e.RowIndex];

                // Store Child_ID internally.
                // The user does not need to enter it.
                if (row.Cells["Child_ID"].Value != null &&
                    row.Cells["Child_ID"].Value != DBNull.Value)
                {
                    selectedChildID =
                        Convert.ToInt32(
                            row.Cells["Child_ID"].Value);
                }

                // Last Name
                txtLastName.Text =
                    row.Cells["Child_LName"].Value?.ToString() ?? "";

                // First Name
                txtFirstName.Text =
                    row.Cells["Child_FName"].Value?.ToString() ?? "";

                // ID Number
                txtIdNumber.Text =
                    row.Cells["ID_Number"].Value?.ToString() ?? "";

                // Arrival Date
                if (row.Cells["Arrival_Date"].Value != null &&
                    row.Cells["Arrival_Date"].Value != DBNull.Value)
                {
                    dateTimePickerArrival.Value =
                        Convert.ToDateTime(
                            row.Cells["Arrival_Date"].Value);
                }

                // Accepted
                if (row.Cells["Accepted_YN"].Value != null &&
                    row.Cells["Accepted_YN"].Value != DBNull.Value)
                {
                    checkBoxAccepted.Checked =
                        Convert.ToBoolean(
                            row.Cells["Accepted_YN"].Value);
                }
                else
                {
                    checkBoxAccepted.Checked = false;
                }

                // Departure Date
                if (row.Cells["Departure_Date"].Value != null &&
                    row.Cells["Departure_Date"].Value != DBNull.Value)
                {
                    dateTimePickerDeparture.Value =
                        Convert.ToDateTime(
                            row.Cells["Departure_Date"].Value);

                    dateTimePickerDeparture.Checked = true;
                }
                else
                {
                    dateTimePickerDeparture.Value =
                        DateTime.Today;

                    dateTimePickerDeparture.Checked = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the selected child's information.\n\n"
                    + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // UPDATE CHILD
        // =========================================================

        private void btnUpdate_Click_1(
            object sender,
            EventArgs e)
        {
            // Make sure a child was selected
            if (selectedChildID == 0)
            {
                MessageBox.Show(
                    "Please select a child from the table first.",
                    "Update Child",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate fields
            if (!ValidateChildDetails())
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE Child_tbl
                        SET
                            Child_LName = @LastName,
                            Child_FName = @FirstName,
                            ID_Number = @IDNumber,
                            Arrival_Date = @ArrivalDate,
                            Accepted_YN = @Accepted,
                            Departure_Date = @DepartureDate
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@ChildID",
                            selectedChildID);

                        command.Parameters.AddWithValue(
                            "@LastName",
                            txtLastName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@FirstName",
                            txtFirstName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@IDNumber",
                            txtIdNumber.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@ArrivalDate",
                            dateTimePickerArrival.Value.Date);

                        command.Parameters.AddWithValue(
                            "@Accepted",
                            checkBoxAccepted.Checked);

                        // If departure date is not selected,
                        // store NULL in the database.
                        if (dateTimePickerDeparture.Checked)
                        {
                            command.Parameters.AddWithValue(
                                "@DepartureDate",
                                dateTimePickerDeparture.Value.Date);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(
                                "@DepartureDate",
                                DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Child updated successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadChildren();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating child:\n\n" + ex.Message,
                    "Update Child Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ADD CHILD
        // =========================================================

        private void btnAddChild_Click(
            object sender,
            EventArgs e)
        {
            if (!ValidateChildDetails())
                return;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO Child_tbl
                        (
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            Accepted_YN,
                            Departure_Date
                        )
                        VALUES
                        (
                            @LastName,
                            @FirstName,
                            @IDNumber,
                            @ArrivalDate,
                            @Accepted,
                            @DepartureDate
                        )";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@LastName",
                            txtLastName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@FirstName",
                            txtFirstName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@IDNumber",
                            txtIdNumber.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@ArrivalDate",
                            dateTimePickerArrival.Value.Date);

                        // Accepted can be Yes or No
                        command.Parameters.AddWithValue(
                            "@Accepted",
                            checkBoxAccepted.Checked);

                        // Only save departure date if selected
                        if (dateTimePickerDeparture.Checked)
                        {
                            command.Parameters.AddWithValue(
                                "@DepartureDate",
                                dateTimePickerDeparture.Value.Date);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(
                                "@DepartureDate",
                                DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Child added successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadChildren();

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error adding child:\n\n" + ex.Message,
                    "Add Child Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       

       

        // =========================================================
        // BACK TO DASHBOARD
        // =========================================================

        private void btnBack_Click_1(
            object sender,
            EventArgs e)
        {
            AccessControl dashboard =
                new AccessControl(
                    loggedInUsername,
                    loggedInRole);

            dashboard.Show();

            this.Close();
        }

        // =========================================================
        // OTHER DESIGNER EVENTS
        // =========================================================

        private void grpChildInformation_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void dgvChildren_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}



