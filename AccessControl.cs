using System;
using System.Windows.Forms;

namespace TawandaSystem
{
    public partial class AccessControl : Form
    {
        private string loggedInUsername;
        private string loggedInRole;

        public AccessControl(string username, string role)
        {
            InitializeComponent();

            loggedInUsername = username;
            loggedInRole = role;
        }

        public AccessControl()
        {
            InitializeComponent();

            loggedInUsername = "";
            loggedInRole = "";
        }

        private void AccessControl_Load(object sender, EventArgs e)
        {
            ApplyPermissions();
        }

        private void ApplyPermissions()
        {
            // ---------------------------------------
            // DEFAULT: HIDE EVERYTHING
            // ---------------------------------------

            btnChildren.Visible = false;
            btnDonations.Visible = false;
            btnUserManagement.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            btnUserManagement.Visible = false;

            // ---------------------------------------
            // MANAGER
            // ---------------------------------------

            if (loggedInRole.Equals(
                "Manager",
                StringComparison.OrdinalIgnoreCase))
            {
                btnChildren.Visible = true;
                btnDonations.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
            }

            // ---------------------------------------
            // ADMINISTRATOR
            // ---------------------------------------

            else if (loggedInRole.Equals(
                "Administrator",
                StringComparison.OrdinalIgnoreCase))
            {
                btnChildren.Visible = true;
                btnDonations.Visible = true;
                btnUserManagement.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                
            }
        }

        // ---------------------------------------
        // CHILDREN
        // ---------------------------------------

        private void btnChildren_Click(object sender, EventArgs e)
        {
            Children form = new Children(loggedInUsername, loggedInRole);
            form.Show();
            this.Hide();
        }

        // ---------------------------------------
        // DONATIONS
        // ---------------------------------------

        private void btnDonations_Click(
            object sender,
            EventArgs e)
        {
            Donations form = new Donations(
     loggedInUsername,
     loggedInRole);

            form.Show();
            this.Hide();
        }

        

        // ---------------------------------------
        // DONATION REPORT
        // ---------------------------------------

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            DonationsReport form =
                new DonationsReport(loggedInUsername, loggedInRole);

            form.Show();
            this.Hide();
        }

        // ---------------------------------------
        // CHILDREN REPORT
        // ---------------------------------------

        private void button2_Click(
            object sender,
            EventArgs e)
        {
            ChildReport form = new ChildReport(
        loggedInUsername,
        loggedInRole
    );

            form.Show();
            this.Hide();
        }

        // ---------------------------------------
        // BACK / LOGOUT
        // ---------------------------------------

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Do you want to log out?",
                    "Confirm Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();

                this.Close();
            }
        }


        //---------------------------------------
        // USER MANAGEMENT
        // ADMINISTRATOR ONLY
        // 
        private void btnUserManagement_Click(
    object sender,
    EventArgs e)
        {
            UserManagement form =
                new UserManagement(loggedInUsername, loggedInRole);

            form.Show();
            this.Hide();
        }
    }
}
