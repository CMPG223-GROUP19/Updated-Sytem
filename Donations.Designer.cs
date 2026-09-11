namespace TawandaSystem
{
    partial class Donations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipDon = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedInRole = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDonationType = new System.Windows.Forms.ComboBox();
            this.lblDonationType = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateReceived = new System.Windows.Forms.DateTimePicker();
            this.lblDateReceived = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpSponsorInformation = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtSponsorName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSponsorName = new System.Windows.Forms.Label();
            this.btnAcceptDonation = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpSponsorRecords = new System.Windows.Forms.GroupBox();
            this.dgvDonations = new System.Windows.Forms.DataGridView();
            this.lblFormDescription = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDatabaseStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpSponsorInformation.SuspendLayout();
            this.grpSponsorRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblLoggedInRole);
            this.panel1.Controls.Add(this.lblLoggedInUser);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 125);
            this.panel1.TabIndex = 16;
            // 
            // lblLoggedInRole
            // 
            this.lblLoggedInRole.AutoSize = true;
            this.lblLoggedInRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInRole.Location = new System.Drawing.Point(1072, 83);
            this.lblLoggedInRole.Name = "lblLoggedInRole";
            this.lblLoggedInRole.Size = new System.Drawing.Size(119, 32);
            this.lblLoggedInRole.TabIndex = 15;
            this.lblLoggedInRole.Text = "Role: User";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(1071, 9);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(208, 37);
            this.lblLoggedInUser.TabIndex = 14;
            this.lblLoggedInUser.Text = "Welcome, User";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.LightGray;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(12, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(571, 78);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "TAWANDA SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Child & Donation Management System";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.grpSponsorInformation);
            this.panel3.Controls.Add(this.btnAcceptDonation);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.grpSponsorRecords);
            this.panel3.Controls.Add(this.lblFormDescription);
            this.panel3.Controls.Add(this.lblFormTitle);
            this.panel3.Location = new System.Drawing.Point(1, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1340, 736);
            this.panel3.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDonationType);
            this.groupBox1.Controls.Add(this.lblDonationType);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.dateTimePickerDateReceived);
            this.groupBox1.Controls.Add(this.lblDateReceived);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.lblQuantity);
            this.groupBox1.Location = new System.Drawing.Point(730, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 275);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DONATION INFORMATION";
            // 
            // cmbDonationType
            // 
            this.cmbDonationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonationType.FormattingEnabled = true;
            this.cmbDonationType.Items.AddRange(new object[] {
            "Money",
            "",
            "Food",
            "",
            "Clothing",
            "",
            "Other"});
            this.cmbDonationType.Location = new System.Drawing.Point(240, 158);
            this.cmbDonationType.Name = "cmbDonationType";
            this.cmbDonationType.Size = new System.Drawing.Size(242, 33);
            this.cmbDonationType.TabIndex = 19;
            // 
            // lblDonationType
            // 
            this.lblDonationType.AutoSize = true;
            this.lblDonationType.Location = new System.Drawing.Point(6, 166);
            this.lblDonationType.Name = "lblDonationType";
            this.lblDonationType.Size = new System.Drawing.Size(152, 25);
            this.lblDonationType.TabIndex = 18;
            this.lblDonationType.Text = "Donation Type";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(240, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(242, 31);
            this.txtAmount.TabIndex = 17;
            // 
            // dateTimePickerDateReceived
            // 
            this.dateTimePickerDateReceived.Checked = false;
            this.dateTimePickerDateReceived.Location = new System.Drawing.Point(240, 212);
            this.dateTimePickerDateReceived.Name = "dateTimePickerDateReceived";
            this.dateTimePickerDateReceived.ShowCheckBox = true;
            this.dateTimePickerDateReceived.Size = new System.Drawing.Size(250, 31);
            this.dateTimePickerDateReceived.TabIndex = 11;
            // 
            // lblDateReceived
            // 
            this.lblDateReceived.AutoSize = true;
            this.lblDateReceived.Location = new System.Drawing.Point(6, 218);
            this.lblDateReceived.Name = "lblDateReceived";
            this.lblDateReceived.Size = new System.Drawing.Size(153, 25);
            this.lblDateReceived.TabIndex = 7;
            this.lblDateReceived.Text = "Date Received";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(240, 100);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(242, 31);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(85, 25);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(6, 106);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(92, 25);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // grpSponsorInformation
            // 
            this.grpSponsorInformation.Controls.Add(this.txtPhone);
            this.grpSponsorInformation.Controls.Add(this.txtEmail);
            this.grpSponsorInformation.Controls.Add(this.lblPhone);
            this.grpSponsorInformation.Controls.Add(this.txtSponsorName);
            this.grpSponsorInformation.Controls.Add(this.lblEmail);
            this.grpSponsorInformation.Controls.Add(this.lblSponsorName);
            this.grpSponsorInformation.Location = new System.Drawing.Point(3, 122);
            this.grpSponsorInformation.Name = "grpSponsorInformation";
            this.grpSponsorInformation.Size = new System.Drawing.Size(686, 275);
            this.grpSponsorInformation.TabIndex = 17;
            this.grpSponsorInformation.TabStop = false;
            this.grpSponsorInformation.Text = "SPONSOR INFORMATION";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(386, 215);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(242, 31);
            this.txtPhone.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(386, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 31);
            this.txtEmail.TabIndex = 17;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(74, 221);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtSponsorName
            // 
            this.txtSponsorName.Location = new System.Drawing.Point(386, 48);
            this.txtSponsorName.Name = "txtSponsorName";
            this.txtSponsorName.Size = new System.Drawing.Size(242, 31);
            this.txtSponsorName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(74, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblSponsorName
            // 
            this.lblSponsorName.AutoSize = true;
            this.lblSponsorName.Location = new System.Drawing.Point(74, 57);
            this.lblSponsorName.Name = "lblSponsorName";
            this.lblSponsorName.Size = new System.Drawing.Size(154, 25);
            this.lblSponsorName.TabIndex = 0;
            this.lblSponsorName.Text = "Sponsor Name";
            this.lblSponsorName.Click += new System.EventHandler(this.lblSponsorName_Click);
            // 
            // btnAcceptDonation
            // 
            this.btnAcceptDonation.Location = new System.Drawing.Point(182, 403);
            this.btnAcceptDonation.Name = "btnAcceptDonation";
            this.btnAcceptDonation.Size = new System.Drawing.Size(249, 58);
            this.btnAcceptDonation.TabIndex = 12;
            this.btnAcceptDonation.Text = "ACCEPT DONATION";
            this.btnAcceptDonation.UseVisualStyleBackColor = true;
            this.btnAcceptDonation.Click += new System.EventHandler(this.btnAcceptDonations_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(595, 403);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(272, 58);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1018, 403);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(261, 58);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpSponsorRecords
            // 
            this.grpSponsorRecords.Controls.Add(this.dgvDonations);
            this.grpSponsorRecords.Location = new System.Drawing.Point(0, 476);
            this.grpSponsorRecords.Name = "grpSponsorRecords";
            this.grpSponsorRecords.Size = new System.Drawing.Size(1316, 260);
            this.grpSponsorRecords.TabIndex = 25;
            this.grpSponsorRecords.TabStop = false;
            this.grpSponsorRecords.Text = "SPONSOR RECORDS";
            // 
            // dgvDonations
            // 
            this.dgvDonations.AllowUserToAddRows = false;
            this.dgvDonations.AllowUserToDeleteRows = false;
            this.dgvDonations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonations.Location = new System.Drawing.Point(10, 30);
            this.dgvDonations.MultiSelect = false;
            this.dgvDonations.Name = "dgvDonations";
            this.dgvDonations.ReadOnly = true;
            this.dgvDonations.RowHeadersVisible = false;
            this.dgvDonations.RowHeadersWidth = 82;
            this.dgvDonations.RowTemplate.Height = 33;
            this.dgvDonations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonations.Size = new System.Drawing.Size(1300, 221);
            this.dgvDonations.TabIndex = 0;
            this.dgvDonations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonations_CellClick_1);
            // 
            // lblFormDescription
            // 
            this.lblFormDescription.AutoSize = true;
            this.lblFormDescription.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormDescription.Location = new System.Drawing.Point(493, 69);
            this.lblFormDescription.Name = "lblFormDescription";
            this.lblFormDescription.Size = new System.Drawing.Size(593, 37);
            this.lblFormDescription.TabIndex = 20;
            this.lblFormDescription.Text = "Manage sponsors and record received donations";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(480, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(617, 59);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "DONATIONS MANAGEMENT ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblDatabaseStatus);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(4, 873);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1334, 96);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblDatabaseStatus
            // 
            this.lblDatabaseStatus.AutoSize = true;
            this.lblDatabaseStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseStatus.Location = new System.Drawing.Point(30, 38);
            this.lblDatabaseStatus.Name = "lblDatabaseStatus";
            this.lblDatabaseStatus.Size = new System.Drawing.Size(257, 32);
            this.lblDatabaseStatus.TabIndex = 9;
            this.lblDatabaseStatus.Text = "● Database Connected";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(894, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(382, 64);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1706, 972);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Donations";
            this.Text = "Donations";
            this.Load += new System.EventHandler(this.Donations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpSponsorInformation.ResumeLayout(false);
            this.grpSponsorInformation.PerformLayout();
            this.grpSponsorRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonations)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTipDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedInRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpSponsorInformation;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAcceptDonation;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtSponsorName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSponsorName;
        private System.Windows.Forms.GroupBox grpSponsorRecords;
        private System.Windows.Forms.DataGridView dgvDonations;
        private System.Windows.Forms.Label lblFormDescription;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatabaseStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateReceived;
        private System.Windows.Forms.Label lblDateReceived;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbDonationType;
        private System.Windows.Forms.Label lblDonationType;
    }
}