namespace TawandaSystem
{
    partial class ChildReport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rdbAllChildren = new System.Windows.Forms.RadioButton();
            this.rdbAcceptedChildren = new System.Windows.Forms.RadioButton();
            this.rdbNotAcceptedChildren = new System.Windows.Forms.RadioButton();
            this.rdbDepartedChildren = new System.Windows.Forms.RadioButton();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoggedInRole = new System.Windows.Forms.Label();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRecords = new System.Windows.Forms.GroupBox();
            this.dgvChildReport = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.chartChildrenStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.lblReportDescription = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.btnBck = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildReport)).BeginInit();
            this.grpStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartChildrenStatus)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbAllChildren
            // 
            this.rdbAllChildren.AutoSize = true;
            this.rdbAllChildren.Location = new System.Drawing.Point(6, 30);
            this.rdbAllChildren.Name = "rdbAllChildren";
            this.rdbAllChildren.Size = new System.Drawing.Size(159, 29);
            this.rdbAllChildren.TabIndex = 0;
            this.rdbAllChildren.TabStop = true;
            this.rdbAllChildren.Text = "All Children ";
            this.rdbAllChildren.UseVisualStyleBackColor = true;
            // 
            // rdbAcceptedChildren
            // 
            this.rdbAcceptedChildren.AutoSize = true;
            this.rdbAcceptedChildren.Location = new System.Drawing.Point(302, 30);
            this.rdbAcceptedChildren.Name = "rdbAcceptedChildren";
            this.rdbAcceptedChildren.Size = new System.Drawing.Size(219, 29);
            this.rdbAcceptedChildren.TabIndex = 1;
            this.rdbAcceptedChildren.TabStop = true;
            this.rdbAcceptedChildren.Text = "Accepted Children";
            this.rdbAcceptedChildren.UseVisualStyleBackColor = true;
            // 
            // rdbNotAcceptedChildren
            // 
            this.rdbNotAcceptedChildren.AutoSize = true;
            this.rdbNotAcceptedChildren.Location = new System.Drawing.Point(643, 30);
            this.rdbNotAcceptedChildren.Name = "rdbNotAcceptedChildren";
            this.rdbNotAcceptedChildren.Size = new System.Drawing.Size(258, 29);
            this.rdbNotAcceptedChildren.TabIndex = 2;
            this.rdbNotAcceptedChildren.TabStop = true;
            this.rdbNotAcceptedChildren.Text = "Not Accepted Children";
            this.rdbNotAcceptedChildren.UseVisualStyleBackColor = true;
            // 
            // rdbDepartedChildren
            // 
            this.rdbDepartedChildren.AutoSize = true;
            this.rdbDepartedChildren.Location = new System.Drawing.Point(984, 30);
            this.rdbDepartedChildren.Name = "rdbDepartedChildren";
            this.rdbDepartedChildren.Size = new System.Drawing.Size(217, 29);
            this.rdbDepartedChildren.TabIndex = 3;
            this.rdbDepartedChildren.TabStop = true;
            this.rdbDepartedChildren.Text = "Departed Children";
            this.rdbDepartedChildren.UseVisualStyleBackColor = true;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.AutoSize = true;
            this.lblReportTitle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(362, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Size = new System.Drawing.Size(412, 59);
            this.lblReportTitle.TabIndex = 4;
            this.lblReportTitle.Text = "CHILDREN REPORT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblLoggedInRole);
            this.panel2.Controls.Add(this.lblLoggedInUser);
            this.panel2.Controls.Add(this.lblHeading);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1233, 115);
            this.panel2.TabIndex = 15;
            // 
            // lblLoggedInRole
            // 
            this.lblLoggedInRole.AutoSize = true;
            this.lblLoggedInRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInRole.Location = new System.Drawing.Point(905, 73);
            this.lblLoggedInRole.Name = "lblLoggedInRole";
            this.lblLoggedInRole.Size = new System.Drawing.Size(119, 32);
            this.lblLoggedInRole.TabIndex = 15;
            this.lblLoggedInRole.Text = "Role: User";
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.AutoSize = true;
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.Location = new System.Drawing.Point(869, 9);
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
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(459, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Child & Donation Management System";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpRecords);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.grpStatistics);
            this.panel1.Controls.Add(this.grpFilter);
            this.panel1.Controls.Add(this.lblReportDescription);
            this.panel1.Controls.Add(this.lblReportTitle);
            this.panel1.Location = new System.Drawing.Point(1, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1236, 662);
            this.panel1.TabIndex = 16;
            // 
            // grpRecords
            // 
            this.grpRecords.Controls.Add(this.dgvChildReport);
            this.grpRecords.Location = new System.Drawing.Point(574, 239);
            this.grpRecords.Name = "grpRecords";
            this.grpRecords.Size = new System.Drawing.Size(630, 334);
            this.grpRecords.TabIndex = 17;
            this.grpRecords.TabStop = false;
            this.grpRecords.Text = "DETAILED RECORDS";
            // 
            // dgvChildReport
            // 
            this.dgvChildReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildReport.Location = new System.Drawing.Point(6, 30);
            this.dgvChildReport.Name = "dgvChildReport";
            this.dgvChildReport.RowHeadersWidth = 82;
            this.dgvChildReport.RowTemplate.Height = 33;
            this.dgvChildReport.Size = new System.Drawing.Size(624, 297);
            this.dgvChildReport.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(9, 579);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(1195, 70);
            this.btnGenerate.TabIndex = 26;
            this.btnGenerate.Text = "GENERATE REPORT";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // grpStatistics
            // 
            this.grpStatistics.Controls.Add(this.chartChildrenStatus);
            this.grpStatistics.Location = new System.Drawing.Point(3, 239);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(565, 334);
            this.grpStatistics.TabIndex = 25;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "CHILD STATISTICS";
            // 
            // chartChildrenStatus
            // 
            chartArea2.Name = "ChartArea1";
            this.chartChildrenStatus.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartChildrenStatus.Legends.Add(legend2);
            this.chartChildrenStatus.Location = new System.Drawing.Point(11, 30);
            this.chartChildrenStatus.Name = "chartChildrenStatus";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartChildrenStatus.Series.Add(series2);
            this.chartChildrenStatus.Size = new System.Drawing.Size(543, 297);
            this.chartChildrenStatus.TabIndex = 0;
            this.chartChildrenStatus.Text = "chart1";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.dateTimePickerTo);
            this.grpFilter.Controls.Add(this.lblTo);
            this.grpFilter.Controls.Add(this.rdbAllChildren);
            this.grpFilter.Controls.Add(this.lblFrom);
            this.grpFilter.Controls.Add(this.dateTimePickerFrom);
            this.grpFilter.Controls.Add(this.rdbAcceptedChildren);
            this.grpFilter.Controls.Add(this.rdbNotAcceptedChildren);
            this.grpFilter.Controls.Add(this.rdbDepartedChildren);
            this.grpFilter.Location = new System.Drawing.Point(3, 90);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(1217, 143);
            this.grpFilter.TabIndex = 21;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "FILTERS";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(738, 82);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerTo.TabIndex = 22;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(683, 88);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(49, 25);
            this.lblTo.TabIndex = 24;
            this.lblTo.Text = "To :";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 88);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(73, 25);
            this.lblFrom.TabIndex = 23;
            this.lblFrom.Text = "From :";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(110, 88);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 31);
            this.dateTimePickerFrom.TabIndex = 4;
            // 
            // lblReportDescription
            // 
            this.lblReportDescription.AutoSize = true;
            this.lblReportDescription.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportDescription.Location = new System.Drawing.Point(383, 59);
            this.lblReportDescription.Name = "lblReportDescription";
            this.lblReportDescription.Size = new System.Drawing.Size(380, 37);
            this.lblReportDescription.TabIndex = 20;
            this.lblReportDescription.Text = "View and analyse child records";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(21, 819);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(233, 25);
            this.lblDTB.TabIndex = 27;
            this.lblDTB.Text = "● Database Connected";
            // 
            // btnBck
            // 
            this.btnBck.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBck.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBck.Location = new System.Drawing.Point(730, 798);
            this.btnBck.Name = "btnBck";
            this.btnBck.Size = new System.Drawing.Size(475, 82);
            this.btnBck.TabIndex = 28;
            this.btnBck.Text = "BACK";
            this.btnBck.UseVisualStyleBackColor = false;
            this.btnBck.Click += new System.EventHandler(this.btnBck_Click);
            // 
            // ChildReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1233, 898);
            this.Controls.Add(this.btnBck);
            this.Controls.Add(this.lblDTB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildReport";
            this.Text = "Tawanda System - Children Report";
            this.Load += new System.EventHandler(this.ChildReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildReport)).EndInit();
            this.grpStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartChildrenStatus)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rdbAllChildren;
        private System.Windows.Forms.RadioButton rdbAcceptedChildren;
        private System.Windows.Forms.RadioButton rdbNotAcceptedChildren;
        private System.Windows.Forms.RadioButton rdbDepartedChildren;
        private System.Windows.Forms.Label lblReportTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoggedInRole;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblReportDescription;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.DataGridView dgvChildReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox grpRecords;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Button btnBck;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartChildrenStatus;
    }
}