using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class DonationsReport : Form
    {

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

        public DonationsReport(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }


        // ============================================================
        // FORM LOAD
        // ============================================================

        private void DonationsReport_Load(object sender, EventArgs e)
        {
            try
            {
                // Populate Group By ComboBox
                comboBoxGroupBy.Items.Clear();

                comboBoxGroupBy.Items.Add("Both");
                comboBoxGroupBy.Items.Add("Year");
                comboBoxGroupBy.Items.Add("Month");

                comboBoxGroupBy.SelectedIndex = 0;

                // Default sorting
                rdoA.Checked = true;

                // Default date range
                dateTimePickerStartDate.Value =
                    new DateTime(DateTime.Now.Year, 1, 1);

                dateTimePickerEndDate.Value =
                    DateTime.Today;

                // Initial label
                lblRecordCount.Text =
                    "Records Found: 0";

                // Load report
                LoadDonationReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading the donations report:\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // APPLY BUTTON
        // ============================================================

        private void btnApply_Click(object sender, EventArgs e)
        {
            LoadDonationReport();
        }


        // ============================================================
        // LOAD DONATION REPORT
        // ============================================================

        private void LoadDonationReport()
        {
            try
            {
                // ----------------------------------------------------
                // CHECK DATE RANGE
                // ----------------------------------------------------

                DateTime startDate =
                    dateTimePickerStartDate.Value.Date;

                DateTime endDate =
                    dateTimePickerEndDate.Value.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show(
                        "The From date cannot be later than the To date.",
                        "Invalid Date Range",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                // ----------------------------------------------------
                // DATABASE CONNECTION
                // ----------------------------------------------------

                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();


                    // ------------------------------------------------
                    // BASE QUERY
                    // ------------------------------------------------

                    string query = @"
                        SELECT
                            d.Donation_ID,

                            ISNULL(
                                s.Sponsor_FName + ' ' + s.Sponsor_LName,
                                'Unknown Sponsor'
                            ) AS Sponsor_Name,

                            d.Date_Received,

                            d.Amount,

                            d.Quantity,

                            ISNULL(
                                dt.Description,
                                'Not Specified'
                            ) AS Donation_Type

                        FROM Donation_tbl AS d

                        LEFT JOIN SponsorTBL AS s
                            ON d.Sponsor_ID = s.Sponsor_ID

                        LEFT JOIN DonationDetails AS dd
                            ON d.Donation_ID = dd.Donation_ID

                        LEFT JOIN DonationType AS dt
                            ON dd.DonationT_ID = dt.DonationT_ID

                        WHERE d.Date_Received >= @StartDate

                        AND d.Date_Received < DATEADD(day, 1, @EndDate)
                    ";


                    // ------------------------------------------------
                    // GROUP BY
                    // ------------------------------------------------

                    string groupBy =
                        comboBoxGroupBy.SelectedItem?.ToString();

                    if (string.IsNullOrWhiteSpace(groupBy))
                    {
                        groupBy = "Both";
                    }


                    // ------------------------------------------------
                    // SORT DIRECTION
                    // ------------------------------------------------

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
                    // SORTING
                    // ------------------------------------------------

                    if (groupBy == "Year")
                    {
                        query += @"
                            ORDER BY
                                YEAR(d.Date_Received) " +
                            sortDirection +
                            @",
                                d.Date_Received " +
                            sortDirection;
                    }
                    else if (groupBy == "Month")
                    {
                        query += @"
                            ORDER BY
                                MONTH(d.Date_Received) " +
                            sortDirection +
                            @",
                                d.Date_Received " +
                            sortDirection;
                    }
                    else
                    {
                        // Both Year and Month

                        query += @"
                            ORDER BY
                                YEAR(d.Date_Received) " +
                            sortDirection +
                            @",
                                MONTH(d.Date_Received) " +
                            sortDirection +
                            @",
                                d.Date_Received " +
                            sortDirection;
                    }


                    // ------------------------------------------------
                    // COMMAND
                    // ------------------------------------------------

                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(
                            "@StartDate",
                            SqlDbType.Date).Value =
                            startDate;

                        command.Parameters.Add(
                            "@EndDate",
                            SqlDbType.Date).Value =
                            endDate;


                        // ------------------------------------------------
                        // LOAD DATA
                        // ------------------------------------------------

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);


                            // ------------------------------------------------
                            // DISPLAY
                            // ------------------------------------------------

                            dgvDonationReport.DataSource =
                                table;


                            // ------------------------------------------------
                            // STYLE GRID
                            // ------------------------------------------------

                            StyleDonationReportGrid();


                            // ------------------------------------------------
                            // FRIENDLY HEADERS
                            // ------------------------------------------------

                            if (dgvDonationReport.Columns[
                                "Donation_ID"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Donation_ID"].HeaderText =
                                    "Donation ID";
                            }


                            if (dgvDonationReport.Columns[
                                "Sponsor_Name"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Sponsor_Name"].HeaderText =
                                    "Sponsor";
                            }


                            if (dgvDonationReport.Columns[
                                "Date_Received"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Date_Received"].HeaderText =
                                    "Date Received";

                                dgvDonationReport.Columns[
                                    "Date_Received"]
                                    .DefaultCellStyle.Format =
                                    "dd MMM yyyy";
                            }


                            if (dgvDonationReport.Columns[
                                "Amount"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Amount"].HeaderText =
                                    "Amount";

                                dgvDonationReport.Columns[
                                    "Amount"]
                                    .DefaultCellStyle.Format =
                                    "C2";
                            }


                            if (dgvDonationReport.Columns[
                                "Quantity"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Quantity"].HeaderText =
                                    "Quantity";
                            }


                            if (dgvDonationReport.Columns[
                                "Donation_Type"] != null)
                            {
                                dgvDonationReport.Columns[
                                    "Donation_Type"].HeaderText =
                                    "Donation Type";
                            }


                            // ------------------------------------------------
                            // RECORD COUNT
                            // ------------------------------------------------

                            lblRecordCount.Text =
                                "Records Found: " +
                                table.Rows.Count;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "A database error occurred while loading the donations report:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading donations report:\n\n" +
                    ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // STYLE DATAGRIDVIEW
        // ============================================================

        private void StyleDonationReportGrid()
        {
            dgvDonationReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDonationReport.AllowUserToAddRows = false;

            dgvDonationReport.AllowUserToDeleteRows = false;

            dgvDonationReport.AllowUserToResizeRows = false;

            dgvDonationReport.ReadOnly = true;

            dgvDonationReport.MultiSelect = false;

            dgvDonationReport.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDonationReport.RowHeadersVisible = false;

            dgvDonationReport.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    dgvDonationReport.Font,
                    FontStyle.Bold);

            dgvDonationReport.ColumnHeadersHeight = 35;

            dgvDonationReport.AlternatingRowsDefaultCellStyle.BackColor =
                SystemColors.ControlLight;

            dgvDonationReport.GridColor =
                SystemColors.ControlDark;
        }


        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            AccessControl access =
                new AccessControl(loggedInUsername, loggedInRole);

            access.Show();
        }



        // ============================================================
        // EXIT
        // ============================================================

        private void toolStripExit_Click(object sender, EventArgs e)
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


        // ============================================================
        // REPORT LABEL
        // ============================================================

        private void lblReport_Click(object sender, EventArgs e)
        {
        }


        // ============================================================
        // DATAGRIDVIEW CELL CLICK
        // ============================================================

        private void dgvDonationReport_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}






