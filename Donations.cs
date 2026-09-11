using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class Donations : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True";

        private string loggedInUsername;
        private string loggedInRole;


        private int selectedSponsorID = 0;

        private int selectedDonationID = 0;

        


        public Donations(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }

        public Donations()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        private void Donations_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = "User: " + loggedInUsername;
            lblLoggedInRole.Text = "Role: " + loggedInRole;

            dateTimePickerDateReceived.Value = DateTime.Today;

            LoadDonations();
            CheckDatabaseConnection();

            cmbDonationType.Items.Clear();

            cmbDonationType.Items.Add("Money");
            cmbDonationType.Items.Add("Food");
            cmbDonationType.Items.Add("Clothing");
            cmbDonationType.Items.Add("Other");

            cmbDonationType.SelectedIndex = -1;
        }

        private void CheckDatabaseConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    lblDatabaseStatus.Text = "Database: Connected";
                }
            }
            catch
            {
                lblDatabaseStatus.Text = "Database: Disconnected";
            }
        }

        private void LoadDonations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                    SELECT
        d.Donation_ID,
        d.Sponsor_ID,
        s.Sponsor_Name,
        s.Sponsor_EmailAddr,
        s.Sponsor_PhoneNo,
        d.Date_Received,
        d.Amount,
        d.Quantity,
        d.Donation_Type
    FROM Donation_tbl d
    INNER JOIN SponsorTBL s
        ON d.Sponsor_ID = s.Sponsor_ID
    ORDER BY d.Donation_ID DESC";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dgvDonations.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading donations:\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnAcceptDonations_Click(object sender, EventArgs e)
        {
            // =========================================================
            // VALIDATE SPONSOR NAME
            // =========================================================

            if (string.IsNullOrWhiteSpace(txtSponsorName.Text))
            {
                MessageBox.Show(
                    "Please enter the sponsor name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSponsorName.Focus();
                return;
            }

            // =========================================================
            // VALIDATE DONATION TYPE
            // =========================================================

            if (cmbDonationType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a donation type.",
                    "Donation Type Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDonationType.Focus();
                return;
            }

            // =========================================================
            // VALIDATE AMOUNT / QUANTITY
            // =========================================================

            if (string.IsNullOrWhiteSpace(txtAmount.Text) &&
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show(
                    "Please enter either an amount or a quantity.",
                    "Missing Donation Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // =========================================================
            // VALIDATE AMOUNT
            // =========================================================

            decimal amount = 0;

            if (!string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                if (!decimal.TryParse(txtAmount.Text, out amount) ||
                    amount < 0)
                {
                    MessageBox.Show(
                        "Please enter a valid donation amount.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }
            }

            // =========================================================
            // SAVE DONATION
            // =========================================================

            try
            {
                using (SqlConnection conn =
                       new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        try
                        {
                            // =================================================
                            // INSERT SPONSOR
                            // =================================================

                            string sponsorQuery = @"
                        INSERT INTO SponsorTBL
                            (Sponsor_Name,
                             Sponsor_EmailAddr,
                             Sponsor_PhoneNo)
                        OUTPUT INSERTED.Sponsor_ID
                        VALUES
                            (@SponsorName,
                             @Email,
                             @Phone);";

                            int sponsorID;

                            using (SqlCommand sponsorCommand =
                                   new SqlCommand(
                                       sponsorQuery,
                                       conn,
                                       transaction))
                            {
                                sponsorCommand.Parameters.AddWithValue(
                                    "@SponsorName",
                                    txtSponsorName.Text.Trim());

                                sponsorCommand.Parameters.AddWithValue(
                                    "@Email",
                                    string.IsNullOrWhiteSpace(txtEmail.Text)
                                        ? (object)DBNull.Value
                                        : txtEmail.Text.Trim());

                                sponsorCommand.Parameters.AddWithValue(
                                    "@Phone",
                                    string.IsNullOrWhiteSpace(txtPhone.Text)
                                        ? (object)DBNull.Value
                                        : txtPhone.Text.Trim());

                                sponsorID = Convert.ToInt32(
                                    sponsorCommand.ExecuteScalar());
                            }

                            // =================================================
                            // INSERT DONATION
                            // =================================================

                            string donationQuery = @"
                        INSERT INTO Donation_tbl
                            (Sponsor_ID,
                             Date_Received,
                             Amount,
                             Quantity,
                             Donation_Type)
                        VALUES
                            (@SponsorID,
                             @DateReceived,
                             @Amount,
                             @Quantity,
                             @DonationType);";

                            using (SqlCommand donationCommand =
                                   new SqlCommand(
                                       donationQuery,
                                       conn,
                                       transaction))
                            {
                                donationCommand.Parameters.AddWithValue(
                                    "@SponsorID",
                                    sponsorID);

                                donationCommand.Parameters.AddWithValue(
                                    "@DateReceived",
                                    dateTimePickerDateReceived.Value.Date);

                                donationCommand.Parameters.AddWithValue(
                                    "@Amount",
                                    string.IsNullOrWhiteSpace(txtAmount.Text)
                                        ? (object)DBNull.Value
                                        : amount);

                                donationCommand.Parameters.AddWithValue(
                                    "@Quantity",
                                    string.IsNullOrWhiteSpace(txtQuantity.Text)
                                        ? (object)DBNull.Value
                                        : txtQuantity.Text.Trim());

                                donationCommand.Parameters.AddWithValue(
                                    "@DonationType",
                                    cmbDonationType.SelectedItem.ToString());

                                donationCommand.ExecuteNonQuery();
                            }

                            // =================================================
                            // COMMIT TRANSACTION
                            // =================================================

                            transaction.Commit();

                            MessageBox.Show(
                                "Donation successfully recorded!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Clear form
                            ClearDonationFields();

                            // Refresh donation table
                            LoadDonations();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the donation.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ClearDonationFields()
        {
            txtSponsorName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAmount.Clear();
            txtQuantity.Clear();

            cmbDonationType.SelectedIndex = -1;

            dateTimePickerDateReceived.Value = DateTime.Today;

            selectedDonationID = 0;
            selectedSponsorID = 0;

            dgvDonations.ClearSelection();

            txtSponsorName.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDonationFields();
        }

        
        



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Make sure a donation has been selected
            if (selectedDonationID == 0)
            {
                MessageBox.Show(
                    "Please select a donation record from the table first.",
                    "No Record Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate sponsor name
            if (string.IsNullOrWhiteSpace(txtSponsorName.Text))
            {
                MessageBox.Show(
                    "Please enter the sponsor name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSponsorName.Focus();
                return;
            }

            // Validate donation type
            if (cmbDonationType.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select a donation type.",
                    "Donation Type Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDonationType.Focus();
                return;
            }

            // Make sure amount OR quantity has been entered
            if (string.IsNullOrWhiteSpace(txtAmount.Text) &&
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show(
                    "Please enter either an amount or a quantity.",
                    "Missing Donation Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Validate amount
            decimal amount = 0;

            if (!string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                if (!decimal.TryParse(txtAmount.Text, out amount) ||
                    amount < 0)
                {
                    MessageBox.Show(
                        "Please enter a valid donation amount.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }
            }

            try
            {
                using (SqlConnection conn =
                       new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction =
                           conn.BeginTransaction())
                    {
                        try
                        {
                            // =====================================================
                            // UPDATE SPONSOR INFORMATION
                            // =====================================================

                            string sponsorQuery = @"
                        UPDATE SponsorTBL
                        SET
                            Sponsor_Name = @SponsorName,
                            Sponsor_EmailAddr = @Email,
                            Sponsor_PhoneNo = @Phone
                        WHERE Sponsor_ID =
                            (SELECT Sponsor_ID
                             FROM Donation_tbl
                             WHERE Donation_ID = @DonationID)";

                            using (SqlCommand sponsorCommand =
                                   new SqlCommand(
                                       sponsorQuery,
                                       conn,
                                       transaction))
                            {
                                sponsorCommand.Parameters.AddWithValue(
                                    "@SponsorName",
                                    txtSponsorName.Text.Trim());

                                sponsorCommand.Parameters.AddWithValue(
                                    "@Email",
                                    string.IsNullOrWhiteSpace(txtEmail.Text)
                                        ? (object)DBNull.Value
                                        : txtEmail.Text.Trim());

                                sponsorCommand.Parameters.AddWithValue(
                                    "@Phone",
                                    string.IsNullOrWhiteSpace(txtPhone.Text)
                                        ? (object)DBNull.Value
                                        : txtPhone.Text.Trim());

                                sponsorCommand.Parameters.AddWithValue(
                                    "@DonationID",
                                    selectedDonationID);

                                sponsorCommand.ExecuteNonQuery();
                            }

                            // =====================================================
                            // UPDATE DONATION INFORMATION
                            // =====================================================

                            string donationQuery = @"
                        UPDATE Donation_tbl
                        SET
                            Date_Received = @DateReceived,
                            Amount = @Amount,
                            Quantity = @Quantity,
                            Donation_Type = @DonationType
                        WHERE Donation_ID = @DonationID";

                            using (SqlCommand donationCommand =
                                   new SqlCommand(
                                       donationQuery,
                                       conn,
                                       transaction))
                            {
                                donationCommand.Parameters.AddWithValue(
                                    "@DateReceived",
                                    dateTimePickerDateReceived.Value.Date);

                                donationCommand.Parameters.AddWithValue(
                                    "@Amount",
                                    string.IsNullOrWhiteSpace(txtAmount.Text)
                                        ? (object)DBNull.Value
                                        : amount);

                                donationCommand.Parameters.AddWithValue(
                                    "@Quantity",
                                    string.IsNullOrWhiteSpace(txtQuantity.Text)
                                        ? (object)DBNull.Value
                                        : txtQuantity.Text.Trim());

                                donationCommand.Parameters.AddWithValue(
                                    "@DonationType",
                                    cmbDonationType.SelectedItem.ToString());

                                donationCommand.Parameters.AddWithValue(
                                    "@DonationID",
                                    selectedDonationID);

                                donationCommand.ExecuteNonQuery();
                            }

                            // =====================================================
                            // COMMIT
                            // =====================================================

                            transaction.Commit();

                            MessageBox.Show(
                                "Donation successfully updated!",
                                "Update Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            // Clear form
                            ClearDonationFields();

                            selectedDonationID = 0;
                            selectedSponsorID = 0;

                            // Refresh table
                            LoadDonations();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update the donation.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblSponsorName_Click(object sender, EventArgs e)
        {

        }

        private void dgvDonations_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore the header row
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow row = dgvDonations.Rows[e.RowIndex];

                selectedDonationID =
    Convert.ToInt32(row.Cells["Donation_ID"].Value);

                // =====================================================
                // SPONSOR INFORMATION
                // =====================================================

                txtSponsorName.Text =
                    row.Cells["Sponsor_Name"].Value?.ToString() ?? "";

                txtEmail.Text =
                    row.Cells["Sponsor_EmailAddr"].Value?.ToString() ?? "";

                txtPhone.Text =
                    row.Cells["Sponsor_PhoneNo"].Value?.ToString() ?? "";

                // =====================================================
                // DATE RECEIVED
                // =====================================================

                if (row.Cells["Date_Received"].Value != null &&
                    row.Cells["Date_Received"].Value != DBNull.Value)
                {
                    dateTimePickerDateReceived.Value =
                        Convert.ToDateTime(
                            row.Cells["Date_Received"].Value);
                }

                // =====================================================
                // DONATION TYPE
                // =====================================================

                if (row.Cells["Donation_Type"].Value != null &&
                    row.Cells["Donation_Type"].Value != DBNull.Value)
                {
                    string donationType =
                        row.Cells["Donation_Type"].Value.ToString();

                    cmbDonationType.SelectedItem = donationType;
                }
                else
                {
                    cmbDonationType.SelectedIndex = -1;
                }

                // =====================================================
                // AMOUNT
                // =====================================================

                if (row.Cells["Amount"].Value != null &&
                    row.Cells["Amount"].Value != DBNull.Value)
                {
                    txtAmount.Text =
                        row.Cells["Amount"].Value.ToString();
                }
                else
                {
                    txtAmount.Clear();
                }

                // =====================================================
                // QUANTITY
                // =====================================================

                if (row.Cells["Quantity"].Value != null &&
                    row.Cells["Quantity"].Value != DBNull.Value)
                {
                    txtQuantity.Text =
                        row.Cells["Quantity"].Value.ToString();
                }
                else
                {
                    txtQuantity.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load the selected donation.\n\n"
                    + ex.Message,
                    "Selection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
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
