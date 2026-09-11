namespace TawandaSystem
{
    partial class DonationsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonationsReport));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTipAS = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRecords = new System.Windows.Forms.GroupBox();
            this.dgvDonationReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.chartDonations = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDatabaseStatus = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoggedInRole = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationReport)).BeginInit();
            this.grpStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDonations)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpRecords);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.grpStatistics);
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Controls.Add(this.lblReportDescription);
            this.panel1.Controls.Add(this.lblReportTitle);
            this.panel1.Location = new System.Drawing.Point(12, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1448, 662);
            this.panel1.TabIndex = 17;
            // 
            // grpRecords
            // 
            this.grpRecords.Controls.Add(this.dgvDonationReport);
            this.grpRecords.Location = new System.Drawing.Point(9, 257);
            this.grpRecords.Name = "grpRecords";
            this.grpRecords.Size = new System.Drawing.Size(653, 392);
            this.grpRecords.TabIndex = 17;
            this.grpRecords.TabStop = false;
            this.grpRecords.Text = "DETAILED RECORDS";
            // 
            // dgvDonationReport
            // 
            this.dgvDonationReport.AllowUserToAddRows = false;
            this.dgvDonationReport.AllowUserToDeleteRows = false;
            this.dgvDonationReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonationReport.Location = new System.Drawing.Point(4, 30);
            this.dgvDonationReport.MultiSelect = false;
            this.dgvDonationReport.Name = "dgvDonationReport";
            this.dgvDonationReport.ReadOnly = true;
            this.dgvDonationReport.RowHeadersVisible = false;
            this.dgvDonationReport.RowHeadersWidth = 82;
            this.dgvDonationReport.RowTemplate.Height = 33;
            this.dgvDonationReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonationReport.Size = new System.Drawing.Size(643, 356);
            this.dgvDonationReport.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(852, 579);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(558, 70);
            this.btnGenerate.TabIndex = 26;
            this.btnGenerate.Text = "GENERATE REPORT";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.chartDonations);
            this.grpStatistics.Location = new System.Drawing.Point(657, 14);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(788, 549);
            this.grpStatistics.TabIndex = 25;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "DONATIONS STATISTICS";
            // 
            // chartDonations
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDonations.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDonations.Legends.Add(legend1);
            this.chartDonations.Location = new System.Drawing.Point(11, 30);
            this.chartDonations.Name = "chartDonations";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDonations.Series.Add(series1);
            this.chartDonations.Size = new System.Drawing.Size(771, 503);
            this.chartDonations.TabIndex = 0;
            this.chartDonations.Text = "chart1";
            this.chartDonations.Click += new System.EventHandler(this.chartDonations_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.dateTimePickerTo);
            this.grpFilter.Controls.Add(this.lblTo);
            this.grpFilter.Controls.Add(this.lblFrom);
            this.grpFilter.Controls.Add(this.dateTimePickerFrom);
            this.grpFilter.Location = new System.Drawing.Point(3, 106);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(514, 145);
            this.grpFilter.TabIndex = 21;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "FILTERS";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(250, 93);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerTo.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(11, 98);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(186, 25);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "Donation Date To:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(11, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(210, 25);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "Donation Date From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(250, 34);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDescription.Location = new System.Drawing.Point(9, 59);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(442, 37);
            this.lblReportDescription.TabIndex = 20;
            this.lblReportDescription.Text = "View and analyse donations records";
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(3, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(455, 59);
            this.lblReportTitle.TabIndex = 4;
            this.lblReportTitle.Text = "DONATIONS REPORT";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lblDatabaseStatus);
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Location = new System.Drawing.Point(9, 793);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1451, 112);
            this.panel3.TabIndex = 19;
            // 
            // lblDatabaseStatus
            // 
            this.lblDatabaseStatus.AutoSize = true;
            this.lblDatabaseStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatabaseStatus.Location = new System.Drawing.Point(30, 45);
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
            this.btnBack.Location = new System.Drawing.Point(870, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(382, 97);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblLoggedInRole);
            this.panel2.Controls.Add(this.lblLoggedInUser);
            this.panel2.Controls.Add(this.lblHeading);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1443, 115);
            this.panel2.TabIndex = 18;
            // 
            // lblLoggedInRole
            // 
            this.lblLoggedInRole.AutoSize = true;
            this.lblLoggedInRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInRole.Location = new System.Drawing.Point(1007, 68);
            this.lblLoggedInRole.Name = "lblLoggedInRole";
            this.lblLoggedInRole.Size = new System.Drawing.Size(119, 32);
            this.lblLoggedInRole.TabIndex = 15;
            this.lblLoggedInRole.Text = "Role: User";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(997, 14);
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
            this.label3.Location = new System.Drawing.Point(26, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Child & Donation Management System";
            // 
            // DonationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 910);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DonationsReport";
            this.Text = "Tawanda System - Donations Report";
            this.Load += new System.EventHandler(this.DonationsReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationReport)).EndInit();
            this.grpStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDonations)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTipAS;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpRecords;
        private System.Windows.Forms.DataGridView dgvDonationReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDonations;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label lblReportDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDatabaseStatus;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoggedInRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label3;
    }
}