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
            this.tpgDonationsReceived = new System.Windows.Forms.TabControl();
            this.tpgAdd = new System.Windows.Forms.TabPage();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbvDonations = new System.Windows.Forms.GroupBox();
            this.cmbDonationType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQTYA = new System.Windows.Forms.TextBox();
            this.dateTimePickerDreceived = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbvSponsor = new System.Windows.Forms.GroupBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtSponsorName = new System.Windows.Forms.TextBox();
            this.txtSponsorLName = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblSponsorName = new System.Windows.Forms.Label();
            this.lblSponsorLName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.tpgUpdate = new System.Windows.Forms.TabPage();
            this.btnReloadD = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnClearUp = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbSponsorUp = new System.Windows.Forms.GroupBox();
            this.txtSponsorID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSponsor = new System.Windows.Forms.DataGridView();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.txtEmailAddressUp = new System.Windows.Forms.TextBox();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.txtNameUp = new System.Windows.Forms.TextBox();
            this.txtLNameUp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpgDisplay = new System.Windows.Forms.TabPage();
            this.gbSort = new System.Windows.Forms.GroupBox();
            this.rbtnPresent = new System.Windows.Forms.RadioButton();
            this.rbtnLessThan = new System.Windows.Forms.RadioButton();
            this.rbtnDisplayAll = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvReceived = new System.Windows.Forms.DataGridView();
            this.btnBackDis = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipDon = new System.Windows.Forms.ToolTip(this.components);
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.tpgDonationsReceived.SuspendLayout();
            this.tpgAdd.SuspendLayout();
            this.gbvDonations.SuspendLayout();
            this.gbvSponsor.SuspendLayout();
            this.tpgUpdate.SuspendLayout();
            this.gbSponsorUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSponsor)).BeginInit();
            this.tpgDisplay.SuspendLayout();
            this.gbSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceived)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpgDonationsReceived
            // 
            this.tpgDonationsReceived.Controls.Add(this.tpgAdd);
            this.tpgDonationsReceived.Controls.Add(this.tpgUpdate);
            this.tpgDonationsReceived.Controls.Add(this.tpgDisplay);
            this.tpgDonationsReceived.Location = new System.Drawing.Point(4, 49);
            this.tpgDonationsReceived.Margin = new System.Windows.Forms.Padding(6);
            this.tpgDonationsReceived.Name = "tpgDonationsReceived";
            this.tpgDonationsReceived.SelectedIndex = 0;
            this.tpgDonationsReceived.Size = new System.Drawing.Size(1560, 796);
            this.tpgDonationsReceived.TabIndex = 0;
            this.tpgDonationsReceived.SelectedIndexChanged += new System.EventHandler(this.tpgDonationsReceived_SelectedIndexChanged);
            // 
            // tpgAdd
            // 
            this.tpgAdd.Controls.Add(this.btnAccept);
            this.tpgAdd.Controls.Add(this.btnBack);
            this.tpgAdd.Controls.Add(this.btnClear);
            this.tpgAdd.Controls.Add(this.gbvDonations);
            this.tpgAdd.Controls.Add(this.gbvSponsor);
            this.tpgAdd.Controls.Add(this.lblHeading);
            this.tpgAdd.Location = new System.Drawing.Point(8, 39);
            this.tpgAdd.Margin = new System.Windows.Forms.Padding(6);
            this.tpgAdd.Name = "tpgAdd";
            this.tpgAdd.Padding = new System.Windows.Forms.Padding(6);
            this.tpgAdd.Size = new System.Drawing.Size(1256, 745);
            this.tpgAdd.TabIndex = 0;
            this.tpgAdd.Text = "Add Records";
            this.tpgAdd.UseVisualStyleBackColor = true;
            this.tpgAdd.Click += new System.EventHandler(this.tpgAdd_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAccept.Location = new System.Drawing.Point(496, 659);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(232, 69);
            this.btnAccept.TabIndex = 17;
            this.btnAccept.Text = "&Accept";
            this.toolTipDon.SetToolTip(this.btnAccept, "This button inserts new records into the system");
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(982, 659);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(232, 69);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "&Back";
            this.toolTipDon.SetToolTip(this.btnBack, "Takes you back to the access control screen");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(738, 659);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 69);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "&Clear";
            this.toolTipDon.SetToolTip(this.btnClear, "This button clears user input");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbvDonations
            // 
            this.gbvDonations.Controls.Add(this.cmbDonationType);
            this.gbvDonations.Controls.Add(this.label8);
            this.gbvDonations.Controls.Add(this.label7);
            this.gbvDonations.Controls.Add(this.txtAmount);
            this.gbvDonations.Controls.Add(this.label12);
            this.gbvDonations.Controls.Add(this.txtQTYA);
            this.gbvDonations.Controls.Add(this.dateTimePickerDreceived);
            this.gbvDonations.Controls.Add(this.label11);
            this.gbvDonations.Controls.Add(this.lblAmount);
            this.gbvDonations.Location = new System.Drawing.Point(648, 120);
            this.gbvDonations.Margin = new System.Windows.Forms.Padding(6);
            this.gbvDonations.Name = "gbvDonations";
            this.gbvDonations.Padding = new System.Windows.Forms.Padding(6);
            this.gbvDonations.Size = new System.Drawing.Size(596, 378);
            this.gbvDonations.TabIndex = 7;
            this.gbvDonations.TabStop = false;
            this.gbvDonations.Text = "Donation Information";
            // 
            // cmbDonationType
            // 
            this.cmbDonationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonationType.FormattingEnabled = true;
            this.cmbDonationType.Location = new System.Drawing.Point(235, 308);
            this.cmbDonationType.Name = "cmbDonationType";
            this.cmbDonationType.Size = new System.Drawing.Size(267, 33);
            this.cmbDonationType.TabIndex = 16;
            this.cmbDonationType.SelectedIndexChanged += new System.EventHandler(this.cmbDonationType_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Donation Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "OR";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(222, 69);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(280, 31);
            this.txtAmount.TabIndex = 13;
            this.toolTipDon.SetToolTip(this.txtAmount, "Enter the amount of the donation received");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(24, 166);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "Quantity:";
            // 
            // txtQTYA
            // 
            this.txtQTYA.Location = new System.Drawing.Point(224, 166);
            this.txtQTYA.Margin = new System.Windows.Forms.Padding(6);
            this.txtQTYA.Name = "txtQTYA";
            this.txtQTYA.Size = new System.Drawing.Size(280, 31);
            this.txtQTYA.TabIndex = 11;
            this.toolTipDon.SetToolTip(this.txtQTYA, "Enter the quantity of the donation received (in kg)");
            // 
            // dateTimePickerDreceived
            // 
            this.dateTimePickerDreceived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDreceived.Location = new System.Drawing.Point(224, 238);
            this.dateTimePickerDreceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerDreceived.Name = "dateTimePickerDreceived";
            this.dateTimePickerDreceived.Size = new System.Drawing.Size(278, 31);
            this.dateTimePickerDreceived.TabIndex = 10;
            this.toolTipDon.SetToolTip(this.dateTimePickerDreceived, "Enter the date the donation was received");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(24, 244);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date Received:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(24, 75);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 29);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // gbvSponsor
            // 
            this.gbvSponsor.Controls.Add(this.txtPhoneNumber);
            this.gbvSponsor.Controls.Add(this.txtEmailAddress);
            this.gbvSponsor.Controls.Add(this.txtSponsorName);
            this.gbvSponsor.Controls.Add(this.txtSponsorLName);
            this.gbvSponsor.Controls.Add(this.lblPhoneNum);
            this.gbvSponsor.Controls.Add(this.lblEmailAddress);
            this.gbvSponsor.Controls.Add(this.lblSponsorName);
            this.gbvSponsor.Controls.Add(this.lblSponsorLName);
            this.gbvSponsor.Location = new System.Drawing.Point(34, 120);
            this.gbvSponsor.Margin = new System.Windows.Forms.Padding(6);
            this.gbvSponsor.Name = "gbvSponsor";
            this.gbvSponsor.Padding = new System.Windows.Forms.Padding(6);
            this.gbvSponsor.Size = new System.Drawing.Size(584, 300);
            this.gbvSponsor.TabIndex = 6;
            this.gbvSponsor.TabStop = false;
            this.gbvSponsor.Text = "Sponsor Information";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(222, 209);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(280, 31);
            this.txtPhoneNumber.TabIndex = 9;
            this.toolTipDon.SetToolTip(this.txtPhoneNumber, "Enter the sponsor\'s phone numbers, (+27) format not accepted");
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(222, 156);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(280, 31);
            this.txtEmailAddress.TabIndex = 8;
            this.toolTipDon.SetToolTip(this.txtEmailAddress, "Enter the sponsor\'s email address");
            // 
            // txtSponsorName
            // 
            this.txtSponsorName.Location = new System.Drawing.Point(222, 98);
            this.txtSponsorName.Margin = new System.Windows.Forms.Padding(6);
            this.txtSponsorName.Name = "txtSponsorName";
            this.txtSponsorName.Size = new System.Drawing.Size(280, 31);
            this.txtSponsorName.TabIndex = 7;
            this.toolTipDon.SetToolTip(this.txtSponsorName, "This is for the sponsor\'s first name");
            // 
            // txtSponsorLName
            // 
            this.txtSponsorLName.Location = new System.Drawing.Point(222, 41);
            this.txtSponsorLName.Margin = new System.Windows.Forms.Padding(6);
            this.txtSponsorLName.Name = "txtSponsorLName";
            this.txtSponsorLName.Size = new System.Drawing.Size(280, 31);
            this.txtSponsorLName.TabIndex = 6;
            this.toolTipDon.SetToolTip(this.txtSponsorLName, "This is for the sponsor\'s last name, if sponsor is an enterprise or company, ente" +
        "r the name of the sponsor as both the last and first name");
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(12, 219);
            this.lblPhoneNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(182, 29);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(12, 166);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(175, 29);
            this.lblEmailAddress.TabIndex = 4;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblSponsorName
            // 
            this.lblSponsorName.AutoSize = true;
            this.lblSponsorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsorName.Location = new System.Drawing.Point(12, 108);
            this.lblSponsorName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSponsorName.Name = "lblSponsorName";
            this.lblSponsorName.Size = new System.Drawing.Size(90, 29);
            this.lblSponsorName.TabIndex = 3;
            this.lblSponsorName.Text = "Name: ";
            // 
            // lblSponsorLName
            // 
            this.lblSponsorLName.AutoSize = true;
            this.lblSponsorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSponsorLName.Location = new System.Drawing.Point(12, 50);
            this.lblSponsorLName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSponsorLName.Name = "lblSponsorLName";
            this.lblSponsorLName.Size = new System.Drawing.Size(140, 29);
            this.lblSponsorLName.TabIndex = 2;
            this.lblSponsorLName.Text = "Last Name: ";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(400, 27);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(450, 40);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "DONATIONS RECEIVED";
            // 
            // tpgUpdate
            // 
            this.tpgUpdate.Controls.Add(this.btnReloadD);
            this.tpgUpdate.Controls.Add(this.btnBackUp);
            this.tpgUpdate.Controls.Add(this.btnClearUp);
            this.tpgUpdate.Controls.Add(this.btnUpdate);
            this.tpgUpdate.Controls.Add(this.gbSponsorUp);
            this.tpgUpdate.Controls.Add(this.label1);
            this.tpgUpdate.Location = new System.Drawing.Point(8, 39);
            this.tpgUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.tpgUpdate.Name = "tpgUpdate";
            this.tpgUpdate.Padding = new System.Windows.Forms.Padding(6);
            this.tpgUpdate.Size = new System.Drawing.Size(1544, 749);
            this.tpgUpdate.TabIndex = 1;
            this.tpgUpdate.Text = "Update Records";
            this.tpgUpdate.UseVisualStyleBackColor = true;
            this.tpgUpdate.Click += new System.EventHandler(this.tpgUpdate_Click);
            // 
            // btnReloadD
            // 
            this.btnReloadD.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReloadD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReloadD.Location = new System.Drawing.Point(288, 661);
            this.btnReloadD.Margin = new System.Windows.Forms.Padding(6);
            this.btnReloadD.Name = "btnReloadD";
            this.btnReloadD.Size = new System.Drawing.Size(232, 69);
            this.btnReloadD.TabIndex = 21;
            this.btnReloadD.Text = "&Reload";
            this.toolTipDon.SetToolTip(this.btnReloadD, "Reloads the updated sponsor details");
            this.btnReloadD.UseVisualStyleBackColor = false;
            this.btnReloadD.Click += new System.EventHandler(this.btnReloadD_Click);
            // 
            // btnBackUp
            // 
            this.btnBackUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackUp.Location = new System.Drawing.Point(1022, 661);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(232, 69);
            this.btnBackUp.TabIndex = 20;
            this.btnBackUp.Text = "&Back";
            this.toolTipDon.SetToolTip(this.btnBackUp, "Takes you back to the access control screen");
            this.btnBackUp.UseVisualStyleBackColor = false;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // btnClearUp
            // 
            this.btnClearUp.BackColor = System.Drawing.Color.SkyBlue;
            this.btnClearUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearUp.Location = new System.Drawing.Point(777, 659);
            this.btnClearUp.Margin = new System.Windows.Forms.Padding(6);
            this.btnClearUp.Name = "btnClearUp";
            this.btnClearUp.Size = new System.Drawing.Size(232, 69);
            this.btnClearUp.TabIndex = 19;
            this.btnClearUp.Text = "&Clear";
            this.toolTipDon.SetToolTip(this.btnClearUp, "Clears input ");
            this.btnClearUp.UseVisualStyleBackColor = false;
            this.btnClearUp.Click += new System.EventHandler(this.btnClearUp_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdate.Location = new System.Drawing.Point(532, 659);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 69);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "&Update";
            this.toolTipDon.SetToolTip(this.btnUpdate, "Updates an existing sponsor\'s details");
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbSponsorUp
            // 
            this.gbSponsorUp.Controls.Add(this.txtSponsorID);
            this.gbSponsorUp.Controls.Add(this.label6);
            this.gbSponsorUp.Controls.Add(this.dgvSponsor);
            this.gbSponsorUp.Controls.Add(this.txtPhoneNum);
            this.gbSponsorUp.Controls.Add(this.txtEmailAddressUp);
            this.gbSponsorUp.Controls.Add(this.lblUpdated);
            this.gbSponsorUp.Controls.Add(this.txtNameUp);
            this.gbSponsorUp.Controls.Add(this.txtLNameUp);
            this.gbSponsorUp.Controls.Add(this.label2);
            this.gbSponsorUp.Controls.Add(this.label3);
            this.gbSponsorUp.Controls.Add(this.label4);
            this.gbSponsorUp.Controls.Add(this.label5);
            this.gbSponsorUp.Location = new System.Drawing.Point(12, 77);
            this.gbSponsorUp.Margin = new System.Windows.Forms.Padding(6);
            this.gbSponsorUp.Name = "gbSponsorUp";
            this.gbSponsorUp.Padding = new System.Windows.Forms.Padding(6);
            this.gbSponsorUp.Size = new System.Drawing.Size(1520, 570);
            this.gbSponsorUp.TabIndex = 7;
            this.gbSponsorUp.TabStop = false;
            this.gbSponsorUp.Text = "Sponsor Information";
            // 
            // txtSponsorID
            // 
            this.txtSponsorID.Location = new System.Drawing.Point(222, 100);
            this.txtSponsorID.Margin = new System.Windows.Forms.Padding(6);
            this.txtSponsorID.Name = "txtSponsorID";
            this.txtSponsorID.Size = new System.Drawing.Size(280, 31);
            this.txtSponsorID.TabIndex = 23;
            this.toolTipDon.SetToolTip(this.txtSponsorID, "Searches for the Sponsor ID entered");
            this.txtSponsorID.TextChanged += new System.EventHandler(this.txtSponsorID_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sponsor ID:";
            // 
            // dgvSponsor
            // 
            this.dgvSponsor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSponsor.Location = new System.Drawing.Point(512, 86);
            this.dgvSponsor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSponsor.Name = "dgvSponsor";
            this.dgvSponsor.RowHeadersWidth = 51;
            this.dgvSponsor.RowTemplate.Height = 24;
            this.dgvSponsor.Size = new System.Drawing.Size(1000, 458);
            this.dgvSponsor.TabIndex = 21;
            this.toolTipDon.SetToolTip(this.dgvSponsor, "Displays the updated record");
            this.dgvSponsor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSponsor_CellClick);
            this.dgvSponsor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSponsor_CellContentClick);
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Location = new System.Drawing.Point(222, 347);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(280, 31);
            this.txtPhoneNum.TabIndex = 9;
            // 
            // txtEmailAddressUp
            // 
            this.txtEmailAddressUp.Location = new System.Drawing.Point(222, 300);
            this.txtEmailAddressUp.Margin = new System.Windows.Forms.Padding(6);
            this.txtEmailAddressUp.Name = "txtEmailAddressUp";
            this.txtEmailAddressUp.Size = new System.Drawing.Size(280, 31);
            this.txtEmailAddressUp.TabIndex = 8;
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.Location = new System.Drawing.Point(562, 41);
            this.lblUpdated.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(274, 29);
            this.lblUpdated.TabIndex = 16;
            this.lblUpdated.Text = "Update Sponsor Details:";
            // 
            // txtNameUp
            // 
            this.txtNameUp.Location = new System.Drawing.Point(222, 253);
            this.txtNameUp.Margin = new System.Windows.Forms.Padding(6);
            this.txtNameUp.Name = "txtNameUp";
            this.txtNameUp.Size = new System.Drawing.Size(280, 31);
            this.txtNameUp.TabIndex = 7;
            // 
            // txtLNameUp
            // 
            this.txtLNameUp.Location = new System.Drawing.Point(222, 206);
            this.txtLNameUp.Margin = new System.Windows.Forms.Padding(6);
            this.txtLNameUp.Name = "txtLNameUp";
            this.txtLNameUp.Size = new System.Drawing.Size(280, 31);
            this.txtLNameUp.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Last Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "DONATIONS RECEIVED";
            // 
            // tpgDisplay
            // 
            this.tpgDisplay.Controls.Add(this.lblTotalQuantity);
            this.tpgDisplay.Controls.Add(this.lblTotalAmount);
            this.tpgDisplay.Controls.Add(this.lblRecordCount);
            this.tpgDisplay.Controls.Add(this.gbSort);
            this.tpgDisplay.Controls.Add(this.label10);
            this.tpgDisplay.Controls.Add(this.dgvReceived);
            this.tpgDisplay.Controls.Add(this.btnBackDis);
            this.tpgDisplay.Controls.Add(this.btnEnter);
            this.tpgDisplay.Location = new System.Drawing.Point(8, 39);
            this.tpgDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpgDisplay.Name = "tpgDisplay";
            this.tpgDisplay.Size = new System.Drawing.Size(1544, 749);
            this.tpgDisplay.TabIndex = 3;
            this.tpgDisplay.Text = "Display Records";
            this.tpgDisplay.UseVisualStyleBackColor = true;
            // 
            // gbSort
            // 
            this.gbSort.Controls.Add(this.rbtnPresent);
            this.gbSort.Controls.Add(this.rbtnLessThan);
            this.gbSort.Controls.Add(this.rbtnDisplayAll);
            this.gbSort.Location = new System.Drawing.Point(16, 76);
            this.gbSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSort.Name = "gbSort";
            this.gbSort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSort.Size = new System.Drawing.Size(1204, 193);
            this.gbSort.TabIndex = 24;
            this.gbSort.TabStop = false;
            this.gbSort.Text = "Display";
            // 
            // rbtnPresent
            // 
            this.rbtnPresent.AutoSize = true;
            this.rbtnPresent.Location = new System.Drawing.Point(26, 130);
            this.rbtnPresent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPresent.Name = "rbtnPresent";
            this.rbtnPresent.Size = new System.Drawing.Size(274, 29);
            this.rbtnPresent.TabIndex = 2;
            this.rbtnPresent.TabStop = true;
            this.rbtnPresent.Text = "Donations 2018–Present";
            this.toolTipDon.SetToolTip(this.rbtnPresent, "Displays donations from later than 2018");
            this.rbtnPresent.UseVisualStyleBackColor = true;
            // 
            // rbtnLessThan
            // 
            this.rbtnLessThan.AutoSize = true;
            this.rbtnLessThan.Location = new System.Drawing.Point(26, 89);
            this.rbtnLessThan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnLessThan.Name = "rbtnLessThan";
            this.rbtnLessThan.Size = new System.Drawing.Size(263, 29);
            this.rbtnLessThan.TabIndex = 1;
            this.rbtnLessThan.TabStop = true;
            this.rbtnLessThan.Text = "Donations Before 2018";
            this.toolTipDon.SetToolTip(this.rbtnLessThan, "Displays donations earlier than 2017");
            this.rbtnLessThan.UseVisualStyleBackColor = true;
            // 
            // rbtnDisplayAll
            // 
            this.rbtnDisplayAll.AutoSize = true;
            this.rbtnDisplayAll.Location = new System.Drawing.Point(26, 48);
            this.rbtnDisplayAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnDisplayAll.Name = "rbtnDisplayAll";
            this.rbtnDisplayAll.Size = new System.Drawing.Size(170, 29);
            this.rbtnDisplayAll.TabIndex = 0;
            this.rbtnDisplayAll.TabStop = true;
            this.rbtnDisplayAll.Text = "All Donations";
            this.toolTipDon.SetToolTip(this.rbtnDisplayAll, "Displays all donations that exist in the system");
            this.rbtnDisplayAll.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(405, 31);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 40);
            this.label10.TabIndex = 23;
            this.label10.Text = "DISPLAY DONATIONS";
            // 
            // dgvReceived
            // 
            this.dgvReceived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceived.Location = new System.Drawing.Point(16, 379);
            this.dgvReceived.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReceived.Name = "dgvReceived";
            this.dgvReceived.RowHeadersWidth = 51;
            this.dgvReceived.RowTemplate.Height = 24;
            this.dgvReceived.Size = new System.Drawing.Size(1204, 228);
            this.dgvReceived.TabIndex = 22;
            // 
            // btnBackDis
            // 
            this.btnBackDis.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBackDis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackDis.Location = new System.Drawing.Point(1286, 670);
            this.btnBackDis.Margin = new System.Windows.Forms.Padding(6);
            this.btnBackDis.Name = "btnBackDis";
            this.btnBackDis.Size = new System.Drawing.Size(232, 69);
            this.btnBackDis.TabIndex = 21;
            this.btnBackDis.Text = "&Back";
            this.toolTipDon.SetToolTip(this.btnBackDis, "Takes user back to access control screen");
            this.btnBackDis.UseVisualStyleBackColor = false;
            this.btnBackDis.Click += new System.EventHandler(this.btnBackDis_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnter.Location = new System.Drawing.Point(492, 289);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(6);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(232, 69);
            this.btnEnter.TabIndex = 20;
            this.btnEnter.Text = "&Enter";
            this.toolTipDon.SetToolTip(this.btnEnter, "Displays donation records");
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1484, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(80, 842);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(61, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(25, 670);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(165, 25);
            this.lblRecordCount.TabIndex = 25;
            this.lblRecordCount.Text = "Records Found:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(487, 670);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(145, 25);
            this.lblTotalAmount.TabIndex = 26;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Location = new System.Drawing.Point(915, 670);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(152, 25);
            this.lblTotalQuantity.TabIndex = 27;
            this.lblTotalQuantity.Text = "Total Quantity:";
            // 
            // Donations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1564, 842);
            this.Controls.Add(this.tpgDonationsReceived);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Donations";
            this.Text = "Donations";
            this.Load += new System.EventHandler(this.Donations_Load);
            this.tpgDonationsReceived.ResumeLayout(false);
            this.tpgAdd.ResumeLayout(false);
            this.tpgAdd.PerformLayout();
            this.gbvDonations.ResumeLayout(false);
            this.gbvDonations.PerformLayout();
            this.gbvSponsor.ResumeLayout(false);
            this.gbvSponsor.PerformLayout();
            this.tpgUpdate.ResumeLayout(false);
            this.tpgUpdate.PerformLayout();
            this.gbSponsorUp.ResumeLayout(false);
            this.gbSponsorUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSponsor)).EndInit();
            this.tpgDisplay.ResumeLayout(false);
            this.tpgDisplay.PerformLayout();
            this.gbSort.ResumeLayout(false);
            this.gbSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceived)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpgDonationsReceived;
        private System.Windows.Forms.TabPage tpgAdd;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TabPage tpgUpdate;
        private System.Windows.Forms.GroupBox gbvSponsor;
        private System.Windows.Forms.TextBox txtSponsorLName;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblSponsorName;
        private System.Windows.Forms.Label lblSponsorLName;
        private System.Windows.Forms.GroupBox gbvDonations;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtSponsorName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSponsorUp;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.TextBox txtEmailAddressUp;
        private System.Windows.Forms.TextBox txtNameUp;
        private System.Windows.Forms.TextBox txtLNameUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClearUp;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabPage tpgDisplay;
        private System.Windows.Forms.Button btnBackDis;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvReceived;
        private System.Windows.Forms.GroupBox gbSort;
        private System.Windows.Forms.RadioButton rbtnDisplayAll;
        private System.Windows.Forms.RadioButton rbtnPresent;
        private System.Windows.Forms.RadioButton rbtnLessThan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePickerDreceived;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQTYA;
        private System.Windows.Forms.DataGridView dgvSponsor;
        private System.Windows.Forms.TextBox txtSponsorID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReloadD;
        private System.Windows.Forms.ToolTip toolTipDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDonationType;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblRecordCount;
    }
}