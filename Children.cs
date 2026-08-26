using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TawandaSystem
{
    public partial class Children : Form
    {

        private string loggedInUsername;
        private string loggedInRole;

        // =========================================================
        // DATABASE
        // =========================================================

        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public Children(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;

           
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        private void Children_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;

            LoadChildren();
        }

        // =========================================================
        // VALIDATE ID NUMBER
        // =========================================================

        private bool ValidateIDNum(string idNumber)
        {
            if (string.IsNullOrWhiteSpace(idNumber))
                return false;

            if (idNumber.Length != 13)
                return false;

            if (!idNumber.All(char.IsDigit))
                return false;

            return true;
        }

        // =========================================================
        // LOAD MAIN CHILDREN GRID
        // =========================================================

        private void LoadChildren()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        ORDER BY Child_ID";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvchildren.DataSource = table;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to load children records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD UPDATE GRID
        // =========================================================

        private void LoadChildrenForUpdate()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_FName,
                            Child_LName,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        ORDER BY Child_ID";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvchild.DataSource = table;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to load children for updating.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD DELETE GRID
        // =========================================================

        private void LoadChildrenForDelete()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        ORDER BY Child_ID";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvDeleteRecord.DataSource = table;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to load children records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ADD CHILD
        // =========================================================

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string lastName = txtLName.Text.Trim();
            string firstName = txtName.Text.Trim();
            string idNumber = txtID.Text.Trim();

            // ---------------------------------------------
            // REQUIRED FIELDS
            // ---------------------------------------------

            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show(
                    "Please enter the child's last name.",
                    "Last Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show(
                    "Please enter the child's first name.",
                    "First Name Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();
                return;
            }

            // ---------------------------------------------
            // ID VALIDATION
            // ---------------------------------------------

            if (!ValidateIDNum(idNumber))
            {
                MessageBox.Show(
                    "Please enter a valid 13-digit ID number.",
                    "Invalid ID Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtID.Focus();
                return;
            }

            // ---------------------------------------------
            // ARRIVAL DATE
            // ---------------------------------------------

            if (dateTimePicker1.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Arrival date cannot be in the future.",
                    "Invalid Arrival Date",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // ---------------------------------------------
            // ACCEPTANCE STATUS
            // ---------------------------------------------

            if (!rdoYes.Checked && !rdoNo.Checked)
            {
                MessageBox.Show(
                    "Please indicate whether the child has been accepted.",
                    "Acceptance Status Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            bool isAccepted = rdoYes.Checked;

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // -----------------------------------------
                    // CHECK DUPLICATE ID
                    // -----------------------------------------

                    string checkQuery = @"
                        SELECT COUNT(*)
                        FROM Child_tbl
                        WHERE ID_Number = @IDNumber";

                    using (SqlCommand checkCmd =
                        new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.Add(
                            "@IDNumber",
                            SqlDbType.Char,
                            13).Value = idNumber;

                        int existing =
                            Convert.ToInt32(
                                checkCmd.ExecuteScalar());

                        if (existing > 0)
                        {
                            MessageBox.Show(
                                "A child with this ID number already exists.",
                                "Duplicate ID Number",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            txtID.Focus();
                            return;
                        }
                    }

                    // -----------------------------------------
                    // INSERT
                    // -----------------------------------------

                    string insertQuery = @"
                        INSERT INTO Child_tbl
                        (
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            Accepted_YN
                        )
                        VALUES
                        (
                            @LastName,
                            @FirstName,
                            @IDNumber,
                            @ArrivalDate,
                            @Accepted
                        )";

                    using (SqlCommand cmd =
                        new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.Add(
                            "@LastName",
                            SqlDbType.VarChar,
                            25).Value = lastName;

                        cmd.Parameters.Add(
                            "@FirstName",
                            SqlDbType.VarChar,
                            25).Value = firstName;

                        cmd.Parameters.Add(
                            "@IDNumber",
                            SqlDbType.Char,
                            13).Value = idNumber;

                        cmd.Parameters.Add(
                            "@ArrivalDate",
                            SqlDbType.Date).Value =
                            dateTimePicker1.Value.Date;

                        cmd.Parameters.Add(
                            "@Accepted",
                            SqlDbType.Bit).Value =
                            isAccepted;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Child record added successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    ClearAddFields();
                    LoadChildren();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to add the child record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLEAR ADD
        // =========================================================

        private void ClearAddFields()
        {
            txtLName.Clear();
            txtName.Clear();
            txtID.Clear();

            dateTimePicker1.Value = DateTime.Today;

            rdoYes.Checked = false;
            rdoNo.Checked = false;

            txtLName.Focus();
        }

        // =========================================================
        // DISPLAY / FILTER
        // =========================================================

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl";

                    using (SqlCommand command =
                        new SqlCommand())
                    {
                        command.Connection = conn;

                        if (rbtnDisplayAll.Checked)
                        {
                            query += " ORDER BY Child_ID";
                        }
                        else if (rdoLess.Checked)
                        {
                            query += @"
                                WHERE ID_Number < @IDNumber
                                ORDER BY Child_ID";

                            command.Parameters.Add(
                                "@IDNumber",
                                SqlDbType.Char,
                                13).Value =
                                "1512301111111";
                        }
                        else if (rdoBetween.Checked)
                        {
                            query += @"
                                WHERE ID_Number BETWEEN
                                @StartID AND @EndID
                                ORDER BY Child_ID";

                            command.Parameters.Add(
                                "@StartID",
                                SqlDbType.Char,
                                13).Value =
                                "0712301111111";

                            command.Parameters.Add(
                                "@EndID",
                                SqlDbType.Char,
                                13).Value =
                                "1512301111111";
                        }
                        else if (rdogreater.Checked)
                        {
                            query += @"
                                WHERE ID_Number > @IDNumber
                                ORDER BY Child_ID";

                            command.Parameters.Add(
                                "@IDNumber",
                                SqlDbType.Char,
                                13).Value =
                                "1512301111111";
                        }
                        else
                        {
                            MessageBox.Show(
                                "Please select a display option.",
                                "Selection Required",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        command.CommandText = query;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dgvchildren.DataSource = table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to filter children records.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // UPDATE DEPARTURE DATE
        // =========================================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string childIDText =
                txtChild_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(childIDText))
            {
                MessageBox.Show(
                    "Please select a child or enter the Child ID.",
                    "Child ID Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                childIDText,
                out int childID))
            {
                MessageBox.Show(
                    "Child ID must be a valid number.",
                    "Invalid Child ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (dateTimePicker2.Value.Date > DateTime.Today)
            {
                MessageBox.Show(
                    "Departure date cannot be in the future.",
                    "Invalid Departure Date",
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

                    // -----------------------------------------
                    // GET ARRIVAL DATE
                    // -----------------------------------------

                    string selectQuery = @"
                        SELECT Arrival_Date
                        FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    DateTime arrivalDate;

                    using (SqlCommand selectCmd =
                        new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        object result =
                            selectCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show(
                                "No child was found with Child ID " +
                                childID + ".",
                                "Child Not Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        arrivalDate =
                            Convert.ToDateTime(result);
                    }

                    // -----------------------------------------
                    // DEPARTURE CANNOT BE BEFORE ARRIVAL
                    // -----------------------------------------

                    if (dateTimePicker2.Value.Date < arrivalDate.Date)
                    {
                        MessageBox.Show(
                            "Departure date cannot be before the child's arrival date.",
                            "Invalid Date",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // -----------------------------------------
                    // UPDATE
                    // -----------------------------------------

                    string updateQuery = @"
                        UPDATE Child_tbl
                        SET Departure_Date = @DepartureDate
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand updateCmd =
                        new SqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.Add(
                            "@DepartureDate",
                            SqlDbType.Date).Value =
                            dateTimePicker2.Value.Date;

                        updateCmd.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        updateCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Departure date updated successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadChildrenForUpdate();

                    txtChild_ID.Clear();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to update the child's record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLICK UPDATE GRID TO SELECT CHILD
        // =========================================================

        private void dgvchild_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvchild.Rows[e.RowIndex];

            if (row.Cells["Child_ID"].Value != null)
            {
                txtChild_ID.Text =
                    row.Cells["Child_ID"]
                    .Value
                    .ToString();
            }

            if (row.Cells["Departure_Date"].Value != null &&
                row.Cells["Departure_Date"].Value != DBNull.Value)
            {
                DateTime departureDate =
                    Convert.ToDateTime(
                        row.Cells["Departure_Date"].Value);

                dateTimePicker2.Value =
                    departureDate;
            }
        }

        // =========================================================
        // SEARCH UPDATE RECORD
        // =========================================================

        private void txtLNameUp_TextChanged(
            object sender,
            EventArgs e)
        {
            string childIDText =
                txtChild_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(childIDText))
            {
                return;
            }

            if (!int.TryParse(
                childIDText,
                out int childID))
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_FName,
                            Child_LName,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvchild.DataSource = table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to search for the child.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DELETE CHILD
        // =========================================================

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string childIDText =
                txtChild_IDdel.Text.Trim();

            if (string.IsNullOrWhiteSpace(childIDText))
            {
                MessageBox.Show(
                    "Please select a child or enter the Child ID.",
                    "Child ID Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                childIDText,
                out int childID))
            {
                MessageBox.Show(
                    "Child ID must be a valid number.",
                    "Invalid Child ID",
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

                    // -----------------------------------------
                    // GET CHILD DETAILS
                    // -----------------------------------------

                    string selectQuery = @"
                        SELECT
                            Child_FName,
                            Child_LName
                        FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    string firstName = "";
                    string lastName = "";

                    using (SqlCommand selectCmd =
                        new SqlCommand(selectQuery, conn))
                    {
                        selectCmd.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        using (SqlDataReader reader =
                            selectCmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show(
                                    "No child was found with Child ID " +
                                    childID + ".",
                                    "Child Not Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                                return;
                            }

                            firstName =
                                reader["Child_FName"]
                                .ToString();

                            lastName =
                                reader["Child_LName"]
                                .ToString();
                        }
                    }

                    // -----------------------------------------
                    // CONFIRM DELETE
                    // -----------------------------------------

                    DialogResult result =
                        MessageBox.Show(
                            "You are about to delete:\n\n" +
                            "Child ID: " + childID +
                            "\nName: " + firstName +
                            " " + lastName +
                            "\n\nAre you sure?",
                            "Confirm Delete",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                    if (result != DialogResult.Yes)
                    {
                        return;
                    }

                    // -----------------------------------------
                    // DELETE
                    // -----------------------------------------

                    string deleteQuery = @"
                        DELETE FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand deleteCmd =
                        new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        int rowsAffected =
                            deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Child record deleted successfully.",
                                "Deleted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }

                txtChild_IDdel.Clear();

                LoadChildrenForDelete();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to delete the child record.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CLICK DELETE GRID TO SELECT CHILD
        // =========================================================

        private void dgvDeleteRecord_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvDeleteRecord.Rows[e.RowIndex];

            if (row.Cells["Child_ID"].Value != null)
            {
                txtChild_IDdel.Text =
                    row.Cells["Child_ID"]
                    .Value
                    .ToString();
            }
        }

        // =========================================================
        // SEARCH DELETE RECORD
        // =========================================================

        private void txtChild_IDdel_TextChanged(
            object sender,
            EventArgs e)
        {
            string childIDText =
                txtChild_IDdel.Text.Trim();

            if (string.IsNullOrWhiteSpace(childIDText))
            {
                return;
            }

            if (!int.TryParse(
                childIDText,
                out int childID))
            {
                return;
            }

            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_FName,
                            Child_LName,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvDeleteRecord.DataSource =
                                table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to search for the child.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // TAB EVENTS
        // =========================================================

        private void tpgChildren_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            if (tpgChildren.SelectedTab == tpgUpdate)
            {
                LoadChildrenForUpdate();
            }
            else if (tpgChildren.SelectedTab == tpgDelete)
            {
                LoadChildrenForDelete();
            }
        }

        private void tpgAdd_Click(
            object sender,
            EventArgs e)
        {
            txtLName.Focus();
        }

        private void tpgUpdate_Click(
            object sender,
            EventArgs e)
        {
            LoadChildrenForUpdate();
        }

        private void tpgDelete_Click(
            object sender,
            EventArgs e)
        {
            LoadChildrenForDelete();
        }

        // =========================================================
        // RELOAD
        // =========================================================

        private void btnReload_Click(
            object sender,
            EventArgs e)
        {
            LoadChildrenForUpdate();
        }

        // =========================================================
        // CLEAR UPDATE
        // =========================================================

        private void btnClearUp_Click(
            object sender,
            EventArgs e)
        {
            txtChild_ID.Clear();

            dateTimePicker2.Value =
                DateTime.Today;

            LoadChildrenForUpdate();
        }

        // =========================================================
        // CLEAR DELETE
        // =========================================================

        private void btnClearDel_Click(
            object sender,
            EventArgs e)
        {
            txtChild_IDdel.Clear();

            LoadChildrenForDelete();
        }

        // =========================================================
        // CLEAR ADD
        // =========================================================

        private void btnClear_Click(
            object sender,
            EventArgs e)
        {
            ClearAddFields();
        }

        // =========================================================
        // BACK
        // =========================================================

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            AccessControl form = new AccessControl(loggedInUsername, loggedInRole);
            form.Show();
            this.Hide();
        }

        private void btnBackDel_Click(
            object sender,
            EventArgs e)
        {
            AccessControl form = new AccessControl(loggedInUsername, loggedInRole);
            form.Show();
            this.Hide();
        }

        private void btnBackUp_Click(
            object sender,
            EventArgs e)
        {
             AccessControl form = new AccessControl(loggedInUsername, loggedInRole);
    form.Show();
    this.Hide();
        }

        private void btnBackto_Click(
            object sender,
            EventArgs e)
        {
            AccessControl form = new AccessControl(loggedInUsername, loggedInRole);
            form.Show();
            this.Hide();
        }

        // =========================================================
        // EXIT
        // =========================================================

        private void exitToolStripMenuItem_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to exit?",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================================================
        // SEARCH BUTTON
        // =========================================================

        private void btnSearch_Click(
            object sender,
            EventArgs e)
        {
            string searchText =
                txtChild_ID.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show(
                    "Please enter a Child ID to search.",
                    "Search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (!int.TryParse(
                searchText,
                out int childID))
            {
                MessageBox.Show(
                    "Please enter a valid Child ID.",
                    "Invalid Child ID",
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

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_LName,
                            Child_FName,
                            ID_Number,
                            Arrival_Date,
                            CASE
                                WHEN Accepted_YN = 1
                                THEN 'Accepted'
                                ELSE 'Not Accepted'
                            END AS Accepted_Status,
                            Departure_Date
                        FROM Child_tbl
                        WHERE Child_ID = @ChildID";

                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(
                            "@ChildID",
                            SqlDbType.Int).Value =
                            childID;

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count == 0)
                            {
                                MessageBox.Show(
                                    "No child was found with Child ID " +
                                    childID + ".",
                                    "No Results",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }

                            dgvchildren.DataSource =
                                table;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Unable to search for the child.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // RADIO BUTTON
        // =========================================================

        private void rdoNo_CheckedChanged(
            object sender,
            EventArgs e)
        {
            // The two radio buttons should already be inside
            // the same GroupBox, so only one can be selected.
        }

        // =========================================================
        // OTHER EXISTING EVENTS
        // =========================================================

        private void btnDisplayALLage_Click(
            object sender,
            EventArgs e)
        {
        }

        private void groupBox1_Enter(
            object sender,
            EventArgs e)
        {
        }
    }
}



