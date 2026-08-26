using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class Donations : Form
    {
        // ============================================================
        // DATABASE CONNECTION
        // ============================================================

        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TAWANDA;Integrated Security=True;";


        // ============================================================
        // LOGGED-IN USER INFORMATION
        // ============================================================

        private string loggedInUsername;
        private string loggedInRole;


        // ============================================================
        // CONSTRUCTOR
        // ============================================================

        public Donations(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }


        // Optional constructor
        // Keeps the form compatible with the Designer
        public Donations()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }


        // ============================================================
        // DONATION TYPE CLASS
        // ============================================================

        private class DonationTypeItem
        {
            public int ID { get; set; }
            public string Description { get; set; }

            public override string ToString()
            {
                return Description;
            }
        }


        // ============================================================
        // FORM LOAD
        // ============================================================

        private void Donations_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDonationTypes();
                LoadSponsors();

                MessageBox.Show(
                    "Database loaded successfully.\n\n" +
                    "Donation types and sponsor records are ready.",
                    "Database Ready",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading donation data:\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // LOAD DONATION TYPES
        // ============================================================

        private void LoadDonationTypes()
        {
            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT DonationT_ID, Description
                    FROM dbo.DonationType
                    ORDER BY DonationT_ID";

                using (SqlCommand command =
                    new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader =
                        command.ExecuteReader())
                    {
                        cmbDonationType.Items.Clear();

                        while (reader.Read())
                        {
                            DonationTypeItem item =
                                new DonationTypeItem
                                {
                                    ID = Convert.ToInt32(
                                        reader["DonationT_ID"]),

                                    Description =
                                        reader["Description"]
                                        .ToString()
                                };

                            cmbDonationType.Items.Add(item);
                        }
                    }
                }
            }
        }


        // ============================================================
        // LOAD SPONSORS
        // ============================================================

        private void LoadSponsors()
        {
            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT
                            Sponsor_ID,
                            Sponsor_LName,
                            Sponsor_FName,
                            Sponsor_EmailAddr,
                            Sponsor_PhoneNo
                        FROM dbo.SponsorTBL
                        ORDER BY Sponsor_ID";

                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(query, conn))
                    {
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvSponsor.DataSource = table;

                        StyleSponsorGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading sponsors:\n\n" +
                    ex.Message,
                    "Sponsor Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // EMAIL VALIDATION
        // ============================================================

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern =
                @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email.Trim(), pattern);
        }


        // ============================================================
        // PHONE VALIDATION
        // ============================================================

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            phoneNumber = phoneNumber
                .Replace(" ", "")
                .Replace("-", "");

            if (phoneNumber.Length != 10)
                return false;

            if (!phoneNumber.StartsWith("0"))
                return false;

            return phoneNumber.All(char.IsDigit);
        }


        // ============================================================
        // ACCEPT DONATION
        // ============================================================

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string lastName =
                txtSponsorLName.Text.Trim();

            string firstName =
                txtSponsorName.Text.Trim();

            string email =
                txtEmailAddress.Text.Trim();

            string phone =
                txtPhoneNumber.Text.Trim();


            if (string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show(
                    "Please enter the sponsor's last name.",
                    "Required Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSponsorLName.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show(
                    "Please enter the sponsor's first name.",
                    "Required Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSponsorName.Focus();
                return;
            }


            if (!IsValidEmail(email))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmailAddress.Focus();
                return;
            }


            if (!ValidatePhoneNumber(phone))
            {
                MessageBox.Show(
                    "Please enter a valid 10-digit South African phone number starting with 0.",
                    "Invalid Phone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhoneNumber.Focus();
                return;
            }


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


            DonationTypeItem selectedType =
                cmbDonationType.SelectedItem as DonationTypeItem;

            if (selectedType == null)
            {
                MessageBox.Show(
                    "Please select a valid donation type.",
                    "Invalid Donation Type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbDonationType.Focus();
                return;
            }


            decimal amount = 0;

            if (!string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                if (!decimal.TryParse(
                    txtAmount.Text.Trim(),
                    out amount))
                {
                    MessageBox.Show(
                        "Please enter a valid amount.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }

                if (amount < 0)
                {
                    MessageBox.Show(
                        "Donation amount cannot be negative.",
                        "Invalid Amount",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtAmount.Focus();
                    return;
                }
            }


            int quantity = 0;

            if (!string.IsNullOrWhiteSpace(txtQTYA.Text))
            {
                if (!int.TryParse(
                    txtQTYA.Text.Trim(),
                    out quantity))
                {
                    MessageBox.Show(
                        "Please enter a whole number for quantity.",
                        "Invalid Quantity",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtQTYA.Focus();
                    return;
                }

                if (quantity < 0)
                {
                    MessageBox.Show(
                        "Quantity cannot be negative.",
                        "Invalid Quantity",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtQTYA.Focus();
                    return;
                }
            }


            if (amount == 0 && quantity == 0)
            {
                MessageBox.Show(
                    "Please enter either an amount or a quantity.",
                    "Donation Information Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmount.Focus();
                return;
            }


            DateTime donationDate =
                dateTimePickerDreceived.Value.Date;


            // ========================================================
            // DATABASE TRANSACTION
            // ========================================================

            using (SqlConnection conn =
                new SqlConnection(connectionString))
            {
                conn.Open();

                SqlTransaction transaction =
                    conn.BeginTransaction();

                try
                {
                    // ------------------------------------------------
                    // INSERT SPONSOR
                    // ------------------------------------------------

                    string sponsorQuery = @"
                        INSERT INTO SponsorTBL
                        (
                            Sponsor_LName,
                            Sponsor_FName,
                            Sponsor_EmailAddr,
                            Sponsor_PhoneNo
                        )
                        VALUES
                        (
                            @LastName,
                            @FirstName,
                            @Email,
                            @Phone
                        );

                        SELECT CAST(SCOPE_IDENTITY() AS int);";


                    int sponsorID;

                    using (SqlCommand command =
                        new SqlCommand(
                            sponsorQuery,
                            conn,
                            transaction))
                    {
                        command.Parameters.Add(
                            "@LastName",
                            SqlDbType.VarChar,
                            255).Value = lastName;

                        command.Parameters.Add(
                            "@FirstName",
                            SqlDbType.VarChar,
                            255).Value = firstName;

                        command.Parameters.Add(
                            "@Email",
                            SqlDbType.VarChar,
                            255).Value = email;

                        command.Parameters.Add(
                            "@Phone",
                            SqlDbType.Char,
                            10).Value = phone;

                        sponsorID =
                            Convert.ToInt32(
                                command.ExecuteScalar());
                    }


                    // ------------------------------------------------
                    // INSERT DONATION
                    // ------------------------------------------------

                    string donationQuery = @"
    INSERT INTO Donation_tbl 
    ( 
        Sponsor_ID, 
        Date_Received, 
        Amount, 
        Quantity 
    ) 
    VALUES 
    ( 
        @Sponsor_ID, 
        @Date_Received, 
        @Amount, 
        @Quantity 
    );

    SELECT CAST(SCOPE_IDENTITY() AS int);";


                    int donationID;

                    using (SqlCommand command =
                        new SqlCommand(
                            donationQuery,
                            conn,
                            transaction))
                    {
                        command.Parameters.Add(
                            "@Sponsor_ID",
                            SqlDbType.Int).Value =
                            sponsorID;

                        command.Parameters.Add(
                             "@Date_Received",
                            SqlDbType.Date).Value =
                            donationDate;

                        command.Parameters.Add(
                            "@Amount",
                            SqlDbType.Money).Value =
                            amount;

                        command.Parameters.Add(
                            "@Quantity",
                            SqlDbType.Int).Value =
                            quantity;

                        donationID =
                            Convert.ToInt32(
                                command.ExecuteScalar());
                    }


                    // ------------------------------------------------
                    // INSERT DONATION DETAILS
                    // ------------------------------------------------

                    string detailsQuery = @"
                        INSERT INTO DonationDetails
                        (
                            Donation_ID,
                            DonationT_ID
                        )
                        VALUES
                        (
                            @Donation_ID,
                            @DonationT_ID
                        );";


                    using (SqlCommand command =
                        new SqlCommand(
                            detailsQuery,
                            conn,
                            transaction))
                    {
                        command.Parameters.Add(
                            "@Donation_ID",
                            SqlDbType.Int).Value =
                            donationID;

                        command.Parameters.Add(
                            "@DonationT_ID",
                            SqlDbType.Int).Value =
                            selectedType.ID;

                        command.ExecuteNonQuery();
                    }


                    transaction.Commit();


                    MessageBox.Show(
                        "Donation successfully recorded!\n\n" +
                        "Sponsor ID: " + sponsorID + "\n" +
                        "Donation ID: " + donationID + "\n" +
                        "Donation Type: " +
                        selectedType.Description,
                        "Donation Recorded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                    ClearAddFields();

                    LoadSponsors();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
                    }
                    catch
                    {
                    }

                    MessageBox.Show(
                        "The donation could not be saved.\n\n" +
                        ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }


        // ============================================================
        // CLEAR ADD DONATION
        // ============================================================

        private void ClearAddFields()
        {
            txtSponsorLName.Clear();
            txtSponsorName.Clear();
            txtEmailAddress.Clear();
            txtPhoneNumber.Clear();

            txtAmount.Clear();
            txtQTYA.Clear();

            cmbDonationType.SelectedIndex = -1;

            dateTimePickerDreceived.Value =
                DateTime.Today;
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAddFields();
        }


        // ============================================================
        // DISPLAY DONATIONS
        // ============================================================

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
        Donation_ID, 
        Sponsor_ID, 
        Date_Received, 
        Amount, 
        Quantity 
    FROM Donation_tbl";


                    if (rbtnLessThan.Checked)
                    {
                        query +=
                            " WHERE Date_Received < @StartDate";
                    }
                    else if (rbtnPresent.Checked)
                    {
                        query +=
                            " WHERE Date_Received >= @StartDate";
                    }


                    query +=
                        " ORDER BY Date_Received DESC";


                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        if (rbtnLessThan.Checked ||
                            rbtnPresent.Checked)
                        {
                            command.Parameters.Add(
                                "@StartDate",
                                SqlDbType.Date).Value =
                                new DateTime(2018, 1, 1);
                        }


                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvReceived.DataSource =
                                table;

                            StyleReceivedGrid();


                            if (dgvReceived.Columns["Amount"] != null)
                            {
                                dgvReceived.Columns["Amount"]
                                    .DefaultCellStyle.Format =
                                    "C2";
                            }


                            if (dgvReceived.Columns["Date_Received"] != null)
                            {
                                dgvReceived.Columns["Date_Received"]
                                    .DefaultCellStyle.Format =
                                    "dd MMM yyyy";
                            }


                            lblRecordCount.Text =
                                "Records Found: " +
                                table.Rows.Count;


                            decimal totalAmount = 0;
                            int totalQuantity = 0;


                            foreach (DataRow row in table.Rows)
                            {
                                if (row["Amount"] != DBNull.Value)
                                {
                                    totalAmount +=
                                        Convert.ToDecimal(
                                            row["Amount"]);
                                }


                                if (row["Quantity"] != DBNull.Value)
                                {
                                    totalQuantity +=
                                        Convert.ToInt32(
                                            row["Quantity"]);
                                }
                            }


                            lblTotalAmount.Text =
                                "Total Amount: " +
                                totalAmount.ToString("C2");


                            lblTotalQuantity.Text =
                                "Total Quantity: " +
                                totalQuantity;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading donation records:\n\n" +
                    ex.Message,
                    "Display Records Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // UPDATE SPONSOR
        // ============================================================

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(
                txtSponsorID.Text.Trim(),
                out int sponsorID))
            {
                MessageBox.Show(
                    "Please select a valid sponsor first.",
                    "Invalid Sponsor ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtSponsorID.Focus();
                return;
            }


            string lastName =
                txtLNameUp.Text.Trim();

            string firstName =
                txtNameUp.Text.Trim();

            string email =
                txtEmailAddressUp.Text.Trim();

            string phone =
                txtPhoneNum.Text.Trim();


            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show(
                    "Please enter the sponsor's first name and last name.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }


            if (!IsValidEmail(email))
            {
                MessageBox.Show(
                    "Please enter a valid email address.",
                    "Invalid Email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmailAddressUp.Focus();
                return;
            }


            if (!ValidatePhoneNumber(phone))
            {
                MessageBox.Show(
                    "Please enter a valid 10-digit South African phone number starting with 0.",
                    "Invalid Phone Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPhoneNum.Focus();
                return;
            }


            try
            {
                using (SqlConnection conn =
                    new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        UPDATE SponsorTBL
                        SET
                            Sponsor_LName = @LastName,
                            Sponsor_FName = @FirstName,
                            Sponsor_EmailAddr = @Email,
                            Sponsor_PhoneNo = @Phone
                        WHERE Sponsor_ID = @Sponsor_ID";


                    using (SqlCommand command =
                        new SqlCommand(query, conn))
                    {
                        command.Parameters.Add(
                            "@LastName",
                            SqlDbType.VarChar,
                            255).Value =
                            lastName;

                        command.Parameters.Add(
                            "@FirstName",
                            SqlDbType.VarChar,
                            255).Value =
                            firstName;

                        command.Parameters.Add(
                            "@Email",
                            SqlDbType.VarChar,
                            255).Value =
                            email;

                        command.Parameters.Add(
                            "@Phone",
                            SqlDbType.Char,
                            10).Value =
                            phone;

                        command.Parameters.Add(
                            "@Sponsor_ID",
                            SqlDbType.Int).Value =
                            sponsorID;


                        int rowsAffected =
                            command.ExecuteNonQuery();


                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Sponsor information updated successfully.",
                                "Update Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadSponsors();
                        }
                        else
                        {
                            MessageBox.Show(
                                "No sponsor was found with Sponsor ID " +
                                sponsorID + ".",
                                "Update Failed",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error updating sponsor:\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        // ============================================================
        // UPDATE - CLEAR
        // ============================================================

        private void btnClearUp_Click(object sender, EventArgs e)
        {
            txtSponsorID.Clear();
            txtLNameUp.Clear();
            txtNameUp.Clear();
            txtEmailAddressUp.Clear();
            txtPhoneNum.Clear();

            dgvSponsor.ClearSelection();
        }


        // ============================================================
        // RELOAD SPONSORS
        // ============================================================

        private void btnReloadD_Click(object sender, EventArgs e)
        {
            LoadSponsors();

            txtSponsorID.Clear();
            txtLNameUp.Clear();
            txtNameUp.Clear();
            txtEmailAddressUp.Clear();
            txtPhoneNum.Clear();

            dgvSponsor.ClearSelection();

            MessageBox.Show(
                "Sponsor records have been refreshed successfully.",
                "Reload Successful",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        // ============================================================
        // SPONSOR GRID CLICK
        // ============================================================

        private void dgvSponsor_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;


            DataGridViewRow row =
                dgvSponsor.Rows[e.RowIndex];


            txtSponsorID.Text =
                row.Cells["Sponsor_ID"]
                .Value?.ToString() ?? "";


            txtLNameUp.Text =
                row.Cells["Sponsor_LName"]
                .Value?.ToString() ?? "";


            txtNameUp.Text =
                row.Cells["Sponsor_FName"]
                .Value?.ToString() ?? "";


            txtEmailAddressUp.Text =
                row.Cells["Sponsor_EmailAddr"]
                .Value?.ToString() ?? "";


            txtPhoneNum.Text =
                row.Cells["Sponsor_PhoneNo"]
                .Value?.ToString() ?? "";
        }


        // ============================================================
        // SPONSOR GRID STYLE
        // ============================================================

        private void StyleSponsorGrid()
        {
            dgvSponsor.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvSponsor.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvSponsor.AllowUserToAddRows = false;
            dgvSponsor.AllowUserToDeleteRows = false;
            dgvSponsor.AllowUserToResizeRows = false;

            dgvSponsor.ReadOnly = true;

            dgvSponsor.MultiSelect = false;

            dgvSponsor.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvSponsor.RowHeadersVisible = false;

            dgvSponsor.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    dgvSponsor.Font,
                    FontStyle.Bold);

            dgvSponsor.ColumnHeadersHeight = 35;

            dgvSponsor.DefaultCellStyle.SelectionBackColor =
                SystemColors.Highlight;

            dgvSponsor.DefaultCellStyle.SelectionForeColor =
                SystemColors.HighlightText;

            dgvSponsor.AlternatingRowsDefaultCellStyle.BackColor =
                SystemColors.ControlLight;

            dgvSponsor.GridColor =
                SystemColors.ControlDark;
        }


        // ============================================================
        // RECEIVED DONATIONS GRID STYLE
        // ============================================================

        private void StyleReceivedGrid()
        {
            dgvReceived.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReceived.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.None;

            dgvReceived.AllowUserToAddRows = false;
            dgvReceived.AllowUserToDeleteRows = false;
            dgvReceived.AllowUserToResizeRows = false;

            dgvReceived.ReadOnly = true;

            dgvReceived.MultiSelect = false;

            dgvReceived.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvReceived.RowHeadersVisible = false;

            dgvReceived.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    dgvReceived.Font,
                    FontStyle.Bold);

            dgvReceived.ColumnHeadersHeight = 35;

            dgvReceived.DefaultCellStyle.SelectionBackColor =
                SystemColors.Highlight;

            dgvReceived.DefaultCellStyle.SelectionForeColor =
                SystemColors.HighlightText;

            dgvReceived.AlternatingRowsDefaultCellStyle.BackColor =
                SystemColors.ControlLight;

            dgvReceived.GridColor =
                SystemColors.ControlDark;
        }


        // ============================================================
        // BACK BUTTONS
        // ============================================================

        private void btnBack_Click(object sender, EventArgs e)
        {
            ReturnToAccessControl();
        }


        private void btnBackUp_Click(object sender, EventArgs e)
        {
            ReturnToAccessControl();
        }


        private void btnBackDel_Click(object sender, EventArgs e)
        {
            ReturnToAccessControl();
        }


        private void btnBackDis_Click(object sender, EventArgs e)
        {
            ReturnToAccessControl();
        }


        // ============================================================
        // RETURN TO ACCESS CONTROL
        // ============================================================

        private void ReturnToAccessControl()
        {
            AccessControl access =
                new AccessControl(
                    loggedInUsername,
                    loggedInRole);

            access.Show();

            this.Close();
        }


        // ============================================================
        // EXIT
        // ============================================================

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


        // ============================================================
        // DESIGNER EVENT HANDLERS
        // ============================================================

        private void btnDisplayAll_Click(
            object sender,
            EventArgs e)
        {
        }


        private void btnClearDel_Click(
            object sender,
            EventArgs e)
        {
        }


        private void tpgDonationsReceived_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void tpgAdd_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtDescription_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void comboBoxDonationID_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void tpgDelete_Click(
            object sender,
            EventArgs e)
        {
        }


        private void lstOutput_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void tpgUpdate_Click(
            object sender,
            EventArgs e)
        {
        }


        private void txtSponsorID_TextChanged(
            object sender,
            EventArgs e)
        {
        }


        private void cmbDonationType_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
        }


        private void cmbDonationType_SelectedIndexChanged_1(
            object sender,
            EventArgs e)
        {
        }


        private void dgvSponsor_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}


