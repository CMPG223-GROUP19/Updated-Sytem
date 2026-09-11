
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TawandaSystem
{
    public partial class DonationsReport : Form
    {
        // ============================================================
        // LOGGED-IN USER
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

        public DonationsReport(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }

        // ============================================================
        // DEFAULT CONSTRUCTOR
        // ============================================================

        public DonationsReport()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void DonationsReport_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = "Welcome, " + loggedInUsername;
            lblLoggedInRole.Text = "Role: " + loggedInRole;

            // Show all existing donations by default
            dateTimePickerFrom.Value = new DateTime(2000, 1, 1);
            dateTimePickerTo.Value = DateTime.Today;

            CheckDatabaseConnection();

            GenerateDonationReport();
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

                    lblDatabaseStatus.Text = "● Database Connected";
                }
            }
            catch
            {
                lblDatabaseStatus.Text = "● Database Disconnected";
            }
        }

        // ============================================================
        // GENERATE DONATION REPORT
        // ============================================================

        private void GenerateDonationReport()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                SELECT
                    d.Donation_ID,
                    d.Sponsor_ID,
                    s.Sponsor_Name,
                    d.Date_Received,
                    d.Donation_Type,
                    d.Amount,
                    d.Quantity
                FROM Donation_tbl d
                LEFT JOIN SponsorTBL s
                    ON d.Sponsor_ID = s.Sponsor_ID
                WHERE d.Date_Received
                    BETWEEN @FromDate AND @ToDate
                ORDER BY d.Date_Received ASC";

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

                        dgvDonationReport.DataSource = table;

                        FormatDataGridView();

                        CreateDonationChart(table);
                    }
                }
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
        // FORMAT DATA GRID VIEW
        // ============================================================

        private void FormatDataGridView()
        {
            if (dgvDonationReport.Columns.Count == 0)
                return;

            dgvDonationReport.EnableHeadersVisualStyles = false;

            dgvDonationReport.ColumnHeadersHeight = 35;
            dgvDonationReport.RowTemplate.Height = 30;

            dgvDonationReport.Columns["Donation_ID"]
                .HeaderText = "Donation ID";

            dgvDonationReport.Columns["Sponsor_ID"]
                .HeaderText = "Sponsor ID";

            dgvDonationReport.Columns["Sponsor_Name"]
                .HeaderText = "Sponsor Name";

            dgvDonationReport.Columns["Date_Received"]
                .HeaderText = "Date Received";

            dgvDonationReport.Columns["Donation_Type"]
                .HeaderText = "Donation Type";

            dgvDonationReport.Columns["Amount"]
                .HeaderText = "Amount";

            dgvDonationReport.Columns["Quantity"]
                .HeaderText = "Quantity";

            dgvDonationReport.Columns["Date_Received"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvDonationReport.Columns["Amount"]
                .DefaultCellStyle.Format = "R #,##0.00";
        }
        // ============================================================
        // CREATE DONATION CHART
        // ============================================================

        private void CreateDonationChart(DataTable table)
        {
            chartDonations.Series.Clear();
            chartDonations.ChartAreas.Clear();
            chartDonations.Titles.Clear();
            chartDonations.Legends.Clear();

            // Create chart area
            ChartArea chartArea = new ChartArea("MainArea");
            chartDonations.ChartAreas.Add(chartArea);

            // Chart title
            Title title = chartDonations.Titles.Add("Donations by Type");

            title.Font = new Font(
                "Segoe UI",
                12,
                FontStyle.Bold);

            // Create series
            Series series = new Series("Donations");

            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            // Store totals for each donation type
            System.Collections.Generic.Dictionary<string, decimal>
                donationTotals =
                new System.Collections.Generic.Dictionary<string, decimal>();

            foreach (DataRow row in table.Rows)
            {
                string donationType = "Other";

                if (row["Donation_Type"] != DBNull.Value &&
                    !string.IsNullOrWhiteSpace(row["Donation_Type"].ToString()))
                {
                    donationType = row["Donation_Type"].ToString();
                }

                decimal amount = 0;

                if (row["Amount"] != DBNull.Value)
                {
                    decimal.TryParse(
                        row["Amount"].ToString(),
                        out amount);
                }

                if (donationTotals.ContainsKey(donationType))
                {
                    donationTotals[donationType] += amount;
                }
                else
                {
                    donationTotals.Add(donationType, amount);
                }
            }

            // Add donation types to chart
            foreach (var item in donationTotals)
            {
                DataPoint point =
                    series.Points.Add((double)item.Value);

                point.AxisLabel = item.Key;

                point.Label =
                    "R " +
                    item.Value.ToString("#,##0.00");

                point.ToolTip =
                    item.Key +
                    ": R " +
                    item.Value.ToString("#,##0.00");
            }

            chartDonations.Series.Add(series);

            // Axis titles
            chartArea.AxisX.Title = "Donation Type";
            chartArea.AxisY.Title = "Donation Amount";

            chartArea.AxisY.LabelStyle.Format = "R #,##0";

            chartDonations.Dock = DockStyle.Fill;
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

            GenerateDonationReport();
        }

        // ============================================================
        // BACK BUTTON
        // ============================================================

        private void btnBack_Click(
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

        private void chartDonations_Click(object sender, EventArgs e)
        {

        }
    }
}





