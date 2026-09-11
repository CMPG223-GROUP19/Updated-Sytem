namespace TawandaSystem
{
    partial class Children
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLoggedInRole = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDatabaseStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpChildInformation = new System.Windows.Forms.GroupBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.checkBoxAccepted = new System.Windows.Forms.CheckBox();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblIDNumber = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.grpChildRecords = new System.Windows.Forms.GroupBox();
            this.dgvChildren = new System.Windows.Forms.DataGridView();
            this.lblFormDescription = new System.Windows.Forms.Label();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpChildInformation.SuspendLayout();
            this.grpChildRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.lblLoggedInRole);
            this.panel1.Controls.Add(this.lblLoggedInUser);
            this.panel1.Controls.Add(this.lblHeading);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 112);
            this.panel1.TabIndex = 15;
            // 
            // lblLoggedInRole
            // 
            this.lblLoggedInRole.AutoSize = true;
            this.lblLoggedInRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInRole.Location = new System.Drawing.Point(1028, 73);
            this.lblLoggedInRole.Name = "lblLoggedInRole";
            this.lblLoggedInRole.Size = new System.Drawing.Size(119, 32);
            this.lblLoggedInRole.TabIndex = 15;
            this.lblLoggedInRole.Text = "Role: User";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(970, 9);
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
            this.lblHeading.Location = new System.Drawing.Point(3, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(571, 78);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "TAWANDA SYSTEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Child & Donation Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblDatabaseStatus);
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Location = new System.Drawing.Point(2, 810);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1297, 99);
            this.panel2.TabIndex = 19;
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
            this.btnBack.Location = new System.Drawing.Point(977, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(284, 64);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grpChildInformation);
            this.panel3.Controls.Add(this.grpChildRecords);
            this.panel3.Controls.Add(this.lblFormDescription);
            this.panel3.Controls.Add(this.lblFormTitle);
            this.panel3.Location = new System.Drawing.Point(2, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1297, 686);
            this.panel3.TabIndex = 20;
            // 
            // grpChildInformation
            // 
            this.grpChildInformation.Controls.Add(this.txtIdNumber);
            this.grpChildInformation.Controls.Add(this.txtLastName);
            this.grpChildInformation.Controls.Add(this.txtFirstName);
            this.grpChildInformation.Controls.Add(this.btnClear);
            this.grpChildInformation.Controls.Add(this.btnUpdate);
            this.grpChildInformation.Controls.Add(this.btnAddChild);
            this.grpChildInformation.Controls.Add(this.dateTimePickerDeparture);
            this.grpChildInformation.Controls.Add(this.dateTimePickerArrival);
            this.grpChildInformation.Controls.Add(this.checkBoxAccepted);
            this.grpChildInformation.Controls.Add(this.lblAccepted);
            this.grpChildInformation.Controls.Add(this.lblDepartureDate);
            this.grpChildInformation.Controls.Add(this.lblArrivalDate);
            this.grpChildInformation.Controls.Add(this.lblIDNumber);
            this.grpChildInformation.Controls.Add(this.lblFirstName);
            this.grpChildInformation.Controls.Add(this.lblLastName);
            this.grpChildInformation.Location = new System.Drawing.Point(3, 109);
            this.grpChildInformation.Name = "grpChildInformation";
            this.grpChildInformation.Size = new System.Drawing.Size(1092, 281);
            this.grpChildInformation.TabIndex = 17;
            this.grpChildInformation.TabStop = false;
            this.grpChildInformation.Text = "CHILD INFORMATION";
            this.grpChildInformation.Enter += new System.EventHandler(this.grpChildInformation_Enter);
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.Location = new System.Drawing.Point(161, 122);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(242, 31);
            this.txtIdNumber.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(161, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 31);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(161, 85);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 31);
            this.txtFirstName.TabIndex = 16;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(763, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 58);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(455, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 58);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(172, 182);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(160, 58);
            this.btnAddChild.TabIndex = 12;
            this.btnAddChild.Text = "ADD CHILD";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.Checked = false;
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(776, 119);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.ShowCheckBox = true;
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(250, 31);
            this.dateTimePickerDeparture.TabIndex = 11;
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Location = new System.Drawing.Point(776, 45);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(242, 31);
            this.dateTimePickerArrival.TabIndex = 10;
            // 
            // checkBoxAccepted
            // 
            this.checkBoxAccepted.AutoSize = true;
            this.checkBoxAccepted.Location = new System.Drawing.Point(776, 87);
            this.checkBoxAccepted.Name = "checkBoxAccepted";
            this.checkBoxAccepted.Size = new System.Drawing.Size(82, 29);
            this.checkBoxAccepted.TabIndex = 9;
            this.checkBoxAccepted.Text = "Yes";
            this.checkBoxAccepted.UseVisualStyleBackColor = true;
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.Location = new System.Drawing.Point(608, 88);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(102, 25);
            this.lblAccepted.TabIndex = 8;
            this.lblAccepted.Text = "Accepted";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(608, 125);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(158, 25);
            this.lblDepartureDate.TabIndex = 7;
            this.lblDepartureDate.Text = "Departure Date";
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(608, 53);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(124, 25);
            this.lblArrivalDate.TabIndex = 5;
            this.lblArrivalDate.Text = "Arrival Date";
            // 
            // lblIDNumber
            // 
            this.lblIDNumber.AutoSize = true;
            this.lblIDNumber.Location = new System.Drawing.Point(11, 125);
            this.lblIDNumber.Name = "lblIDNumber";
            this.lblIDNumber.Size = new System.Drawing.Size(113, 25);
            this.lblIDNumber.TabIndex = 4;
            this.lblIDNumber.Text = "ID Number";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(11, 88);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(116, 25);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(11, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(115, 25);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // grpChildRecords
            // 
            this.grpChildRecords.Controls.Add(this.dgvChildren);
            this.grpChildRecords.Location = new System.Drawing.Point(3, 396);
            this.grpChildRecords.Name = "grpChildRecords";
            this.grpChildRecords.Size = new System.Drawing.Size(1285, 296);
            this.grpChildRecords.TabIndex = 25;
            this.grpChildRecords.TabStop = false;
            this.grpChildRecords.Text = "CHILD RECORDS ";
            // 
            // dgvChildren
            // 
            this.dgvChildren.AllowUserToAddRows = false;
            this.dgvChildren.AllowUserToDeleteRows = false;
            this.dgvChildren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildren.Location = new System.Drawing.Point(10, 30);
            this.dgvChildren.MultiSelect = false;
            this.dgvChildren.Name = "dgvChildren";
            this.dgvChildren.ReadOnly = true;
            this.dgvChildren.RowHeadersVisible = false;
            this.dgvChildren.RowHeadersWidth = 82;
            this.dgvChildren.RowTemplate.Height = 33;
            this.dgvChildren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChildren.Size = new System.Drawing.Size(1269, 247);
            this.dgvChildren.TabIndex = 0;
            this.dgvChildren.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildren_CellClick);
            this.dgvChildren.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChildren_CellContentClick);
            // 
            // lblFormDescription
            // 
            this.lblFormDescription.AutoSize = true;
            this.lblFormDescription.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormDescription.Location = new System.Drawing.Point(309, 69);
            this.lblFormDescription.Name = "lblFormDescription";
            this.lblFormDescription.Size = new System.Drawing.Size(587, 37);
            this.lblFormDescription.TabIndex = 20;
            this.lblFormDescription.Text = "Manage children entering and leaving the home";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(331, 10);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(574, 59);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "CHILDREN MANAGEMENT ";
            // 
            // Children
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1373, 959);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Children";
            this.Text = "Tawanda System - Children Management";
            this.Load += new System.EventHandler(this.Children_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpChildInformation.ResumeLayout(false);
            this.grpChildInformation.PerformLayout();
            this.grpChildRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLoggedInRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblDatabaseStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grpChildInformation;
        private System.Windows.Forms.GroupBox grpChildRecords;
        private System.Windows.Forms.Label lblFormDescription;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblIDNumber;
        private System.Windows.Forms.Label lblAccepted;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.CheckBox checkBoxAccepted;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private System.Windows.Forms.DataGridView dgvChildren;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
    }
}