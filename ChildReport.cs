using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class ChildReport : Form
    {
        // ============================================================
        // LOGIN INFORMATION
        // ============================================================

        private string loggedInUsername;
        private string loggedInRole;


        // ============================================================
        // DATABASE CONNECTION
        // ============================================================

        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";


        // ============================================================
        // CONSTRUCTOR
        // ============================================================

        public ChildReport(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }


        // ============================================================
        // STYLE DATAGRIDVIEW
        // ============================================================

        private void StyleChildReportGrid()
        {
            dgvChildReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvChildReport.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvChildReport.AllowUserToAddRows = false;
            dgvChildReport.AllowUserToDeleteRows = false;
            dgvChildReport.AllowUserToResizeRows = false;

            dgvChildReport.ReadOnly = true;

            dgvChildReport.MultiSelect = false;

            dgvChildReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvChildReport.RowHeadersVisible = false;

            dgvChildReport.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    dgvChildReport.Font,
                    FontStyle.Bold);

            dgvChildReport.ColumnHeadersHeight = 35;

            dgvChildReport.AlternatingRowsDefaultCellStyle.BackColor =
                SystemColors.ControlLight;

            dgvChildReport.GridColor =
                SystemColors.ControlDark;
        }


        // ============================================================
        // APPLY BUTTON
        // ============================================================

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ------------------------------------------------
                    // BASE QUERY
                    // ------------------------------------------------

                    string query = @"
                        SELECT
                            Child_ID,
                            Child_FName,
                            Child_LName,
                            ID_Number,
                            Arrival_Date,
                            Accepted_YN,
                            Departure_Date
                        FROM Child_tbl";


                    // ------------------------------------------------
                    // CHILD STATUS FILTER
                    // ------------------------------------------------

                    if (rdbAcceptedChildren.Checked)
                    {
                        query +=
                            " WHERE Accepted_YN = 1";
                    }
                    else if (rdbNotAcceptedChildren.Checked)
                    {
                        query +=
                            " WHERE Accepted_YN = 0";
                    }
                    else if (rdbDepartedChildren.Checked)
                    {
                        query +=
                            " WHERE Departure_Date IS NOT NULL";
                    }


                    // ------------------------------------------------
                    // SORTING
                    // ------------------------------------------------

                    string sortColumn;

                    switch (cmbSortBy.SelectedItem?.ToString())
                    {
                        case "Arrival Date":

                            sortColumn = "Arrival_Date";

                            break;

                        case "Child ID":

                            sortColumn = "Child_ID";

                            break;

                        case "Child Name":

                        default:

                            sortColumn = "Child_LName";

                            break;
                    }


                    string sortDirection;

                    if (rdoD.Checked)
                    {
                        sortDirection = "DESC";
                    }
                    else
                    {
                        sortDirection = "ASC";
                    }


                    // ------------------------------------------------
                    // APPLY SORTING
                    // ------------------------------------------------

                    if (sortColumn == "Child_LName")
                    {
                        query +=
                            " ORDER BY Child_LName " +
                            sortDirection +
                            ", Child_FName " +
                            sortDirection;
                    }
                    else
                    {
                        query +=
                            " ORDER BY " +
                            sortColumn +
                            " " +
                            sortDirection;
                    }


                    // ------------------------------------------------
                    // LOAD RESULTS
                    // ------------------------------------------------

                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvChildReport.DataSource =
                                table;


                            // ------------------------------------------------
                            // RECORD COUNT
                            // ------------------------------------------------

                            lblRecordCount.Text =
                                "Records Found: " +
                                table.Rows.Count;


                            // ------------------------------------------------
                            // STYLE GRID
                            // ------------------------------------------------

                            StyleChildReportGrid();


                            // ------------------------------------------------
                            // FRIENDLY COLUMN HEADERS
                            // ------------------------------------------------

                            if (dgvChildReport.Columns[
                                "Child_ID"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Child_ID"].HeaderText =
                                    "Child ID";
                            }


                            if (dgvChildReport.Columns[
                                "Child_FName"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Child_FName"].HeaderText =
                                    "First Name";
                            }


                            if (dgvChildReport.Columns[
                                "Child_LName"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Child_LName"].HeaderText =
                                    "Last Name";
                            }


                            if (dgvChildReport.Columns[
                                "ID_Number"] != null)
                            {
                                dgvChildReport.Columns[
                                    "ID_Number"].HeaderText =
                                    "ID Number";
                            }


                            if (dgvChildReport.Columns[
                                "Arrival_Date"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Arrival_Date"].HeaderText =
                                    "Arrival Date";

                                dgvChildReport.Columns[
                                    "Arrival_Date"]
                                    .DefaultCellStyle.Format =
                                    "dd MMM yyyy";
                            }


                            if (dgvChildReport.Columns[
                                "Accepted_YN"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Accepted_YN"].HeaderText =
                                    "Accepted";
                            }


                            if (dgvChildReport.Columns[
                                "Departure_Date"] != null)
                            {
                                dgvChildReport.Columns[
                                    "Departure_Date"].HeaderText =
                                    "Departure Date";

                                dgvChildReport.Columns[
                                    "Departure_Date"]
                                    .DefaultCellStyle.Format =
                                    "dd MMM yyyy";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "A database error occurred while loading the children report:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading children report:\n\n" +
                    ex.Message,
                    "Children Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // LOAD ALL CHILDREN
        // ============================================================

        private void LoadAllChildren()
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
                            ID_Number,
                            Arrival_Date,
                            Accepted_YN,
                            Departure_Date
                        FROM Child_tbl
                        ORDER BY
                            Child_LName ASC,
                            Child_FName ASC";


                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table =
                            new DataTable();

                        adapter.Fill(table);

                        dgvChildReport.DataSource =
                            table;

                        StyleChildReportGrid();

                        lblRecordCount.Text =
                            "Records Found: " +
                            table.Rows.Count;


                        // ------------------------------------------------
                        // FRIENDLY COLUMN HEADERS
                        // ------------------------------------------------

                        if (dgvChildReport.Columns[
                            "Child_ID"] != null)
                        {
                            dgvChildReport.Columns[
                                "Child_ID"].HeaderText =
                                "Child ID";
                        }


                        if (dgvChildReport.Columns[
                            "Child_FName"] != null)
                        {
                            dgvChildReport.Columns[
                                "Child_FName"].HeaderText =
                                "First Name";
                        }


                        if (dgvChildReport.Columns[
                            "Child_LName"] != null)
                        {
                            dgvChildReport.Columns[
                                "Child_LName"].HeaderText =
                                "Last Name";
                        }


                        if (dgvChildReport.Columns[
                            "ID_Number"] != null)
                        {
                            dgvChildReport.Columns[
                                "ID_Number"].HeaderText =
                                "ID Number";
                        }


                        if (dgvChildReport.Columns[
                            "Arrival_Date"] != null)
                        {
                            dgvChildReport.Columns[
                                "Arrival_Date"].HeaderText =
                                "Arrival Date";

                            dgvChildReport.Columns[
                                "Arrival_Date"]
                                .DefaultCellStyle.Format =
                                "dd MMM yyyy";
                        }


                        if (dgvChildReport.Columns[
                            "Accepted_YN"] != null)
                        {
                            dgvChildReport.Columns[
                                "Accepted_YN"].HeaderText =
                                "Accepted";
                        }


                        if (dgvChildReport.Columns[
                            "Departure_Date"] != null)
                        {
                            dgvChildReport.Columns[
                                "Departure_Date"].HeaderText =
                                "Departure Date";

                            dgvChildReport.Columns[
                                "Departure_Date"]
                                .DefaultCellStyle.Format =
                                "dd MMM yyyy";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading children:\n\n" +
                    ex.Message,
                    "Children Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // FORM LOAD
        // ============================================================

        private void ChildReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Default filter
                rdbAllChildren.Checked = true;

                // Default sorting
                rdoA.Checked = true;

                // Sort options
                cmbSortBy.Items.Clear();

                cmbSortBy.Items.Add("Child Name");
                cmbSortBy.Items.Add("Arrival Date");
                cmbSortBy.Items.Add("Child ID");

                cmbSortBy.SelectedIndex = 0;

                // Load all children
                LoadAllChildren();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading child report:\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            AccessControl form =
                new AccessControl(
                    loggedInUsername,
                    loggedInRole);

            form.Show();
        }


        // ============================================================
        // REPORT LABEL
        // ============================================================

        private void label2_Click(object sender, EventArgs e)
        {
        }


        // ============================================================
        // DATAGRIDVIEW CELL CLICK
        // ============================================================

        private void dgvChildReport_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}
