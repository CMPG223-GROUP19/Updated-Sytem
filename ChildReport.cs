using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TawandaSystem
{
    public partial class ChildReport : Form
    {
        // ============================================================
        // USER INFORMATION
        // ============================================================

        private readonly string loggedInUsername;
        private readonly string loggedInRole;

        // ============================================================
        // DATABASE CONNECTION
        // ============================================================

        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True";

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
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public ChildReport()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void ChildReport_Load(object sender, EventArgs e)
        {
            // Display logged-in user
            lblLoggedInUser.Text = "Welcome, " + loggedInUsername;
            lblLoggedInRole.Text = "Role: " + loggedInRole;

            // Set default date range
            dateTimePickerFrom.Value = new DateTime(2000, 1, 1);

            dateTimePickerTo.Value = DateTime.Now;

            // Check database
            CheckDatabaseConnection();

            // Show initial report
            GenerateChildReport();
        }

        // ============================================================
        // DATABASE CONNECTION CHECK
        // ============================================================

        private void CheckDatabaseConnection()
        {
            try
            {
                using (SqlConnection connection =
                       new SqlConnection(connectionString))
                {
                    connection.Open();

                    lblDTB.Text = "● Database Connected";
                }
            }
            catch
            {
                lblDTB.Text = "● Database Disconnected";
            }
        }

        // ============================================================
        // GENERATE REPORT
        // ============================================================

        private void GenerateChildReport()
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
                        WHERE Arrival_Date BETWEEN @FromDate AND @ToDate
                    ";

                    // ------------------------------------------------
                    // STATUS FILTER
                    // ------------------------------------------------

                    if (rdbAcceptedChildren.Checked)
                    {
                        query += " AND Accepted_YN = 1";
                    }
                    else if (rdbNotAcceptedChildren.Checked)
                    {
                        query += " AND Accepted_YN = 0";
                    }
                    else if (rdbDepartedChildren.Checked)
                    {
                        query += " AND Departure_Date IS NOT NULL";
                    }

                    query += " ORDER BY Arrival_Date ASC";

                    using (SqlCommand command =
                           new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@FromDate",
                            dateTimePickerFrom.Value.Date);

                        command.Parameters.AddWithValue(
                            "@ToDate",
                            dateTimePickerTo.Value.Date);

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(command);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        // Display records
                        dgvChildReport.DataSource = table;

                        // Format grid
                        FormatDataGridView();

                        // Create chart
                        CreateChildrenChart(table);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading children report:\n\n" + ex.Message,
                    "Report Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // FORMAT DATA GRID
        // ============================================================

        private void FormatDataGridView()
        {
            if (dgvChildReport.Columns.Count == 0)
                return;

            dgvChildReport.Columns["Child_ID"]
                .HeaderText = "Child ID";

            dgvChildReport.Columns["Child_LName"]
                .HeaderText = "Last Name";

            dgvChildReport.Columns["Child_FName"]
                .HeaderText = "First Name";

            dgvChildReport.Columns["ID_Number"]
                .HeaderText = "ID Number";

            dgvChildReport.Columns["Arrival_Date"]
                .HeaderText = "Arrival Date";

            dgvChildReport.Columns["Accepted_YN"]
                .HeaderText = "Accepted";

            dgvChildReport.Columns["Departure_Date"]
                .HeaderText = "Departure Date";

            // Date formatting
            dgvChildReport.Columns["Arrival_Date"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvChildReport.Columns["Departure_Date"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

           
        }

        // ============================================================
        // CREATE PIE CHART
        // ============================================================

        private void CreateChildrenChart(DataTable table)
        {
            chartChildrenStatus.Series.Clear();
            chartChildrenStatus.Titles.Clear();
            chartChildrenStatus.Legends.Clear();

            chartChildrenStatus.Titles.Add(
                "Children by Status");

            Series series =
                new Series("Children");

            series.ChartType =
                SeriesChartType.Pie;

            series.IsValueShownAsLabel = true;

            // --------------------------------------------------------
            // COUNT STATUS
            // --------------------------------------------------------

            int accepted = 0;
            int notAccepted = 0;
            int departed = 0; int notDeparted = 0;

            foreach (DataRow row in table.Rows)
            {
                bool isAccepted =
                    Convert.ToBoolean(row["Accepted_YN"]);

                bool hasDeparted =
                    row["Departure_Date"] != DBNull.Value;

                if (hasDeparted)
                {
                    departed++;
                }
                else if (isAccepted)
                {
                    accepted++;
                }
                else
                {
                    notAccepted++;
                }
            }

            // --------------------------------------------------------
            // ADD PIE SLICES
            // --------------------------------------------------------

            if (accepted > 0)
            {
                series.Points.AddXY(
                    "Accepted",
                    accepted);
            }

            if (notAccepted > 0)
            {
                series.Points.AddXY(
                    "Not Accepted",
                    notAccepted);
            }

            if (departed > 0)
            {
                series.Points.AddXY(
                    "Departed",
                    departed);
            }

            chartChildrenStatus.Series.Add(series);

            chartChildrenStatus.Legends.Clear();

            Legend legend = new Legend();
            chartChildrenStatus.Legends.Add(legend);

            series.Legend = legend.Name;

            chartChildrenStatus.Dock = DockStyle.Fill;
        }

        // ============================================================
        // GENERATE BUTTON
        // ============================================================

        private void btnGenerate_Click(
            object sender,
            EventArgs e)
        {
            if (dateTimePickerFrom.Value.Date >
                dateTimePickerTo.Value.Date)
            {
                MessageBox.Show(
                    "The 'From' date cannot be later than the 'To' date.",
                    "Invalid Date Range",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            GenerateChildReport();
        }

        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void btnBck_Click(
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
    }
}