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
            this.dgvDonationReport = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxGroupBy = new System.Windows.Forms.ComboBox();
            this.groupBoxSortBy = new System.Windows.Forms.GroupBox();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.btnApply = new System.Windows.Forms.Button();
            this.toolTipAS = new System.Windows.Forms.ToolTip(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblReport = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxSortBy.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDonationReport
            // 
            this.dgvDonationReport.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvDonationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonationReport.Location = new System.Drawing.Point(18, 373);
            this.dgvDonationReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDonationReport.Name = "dgvDonationReport";
            this.dgvDonationReport.RowHeadersWidth = 51;
            this.dgvDonationReport.RowTemplate.Height = 24;
            this.dgvDonationReport.Size = new System.Drawing.Size(1169, 226);
            this.dgvDonationReport.TabIndex = 0;
            this.toolTipAS.SetToolTip(this.dgvDonationReport, "Displays generated report");
            this.dgvDonationReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonationReport_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(493, 40);
            this.label10.TabIndex = 24;
            this.label10.Text = "REPORT FOR DONATIONS";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(52, 92);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(298, 31);
            this.dateTimePickerStartDate.TabIndex = 25;
            this.toolTipAS.SetToolTip(this.dateTimePickerStartDate, "Earliest date displayed on report");
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(52, 166);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(298, 31);
            this.dateTimePickerEndDate.TabIndex = 26;
            this.toolTipAS.SetToolTip(this.dateTimePickerEndDate, "Latest date on report");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerStartDate);
            this.groupBox1.Controls.Add(this.dateTimePickerEndDate);
            this.groupBox1.Location = new System.Drawing.Point(18, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(432, 224);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "to";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxGroupBy);
            this.groupBox2.Location = new System.Drawing.Point(471, 84);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(343, 224);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Group by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose to group by:";
            // 
            // comboBoxGroupBy
            // 
            this.comboBoxGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroupBy.FormattingEnabled = true;
            this.comboBoxGroupBy.Items.AddRange(new object[] {
            "Both",
            "Year",
            "Month"});
            this.comboBoxGroupBy.Location = new System.Drawing.Point(64, 119);
            this.comboBoxGroupBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGroupBy.Name = "comboBoxGroupBy";
            this.comboBoxGroupBy.Size = new System.Drawing.Size(180, 33);
            this.comboBoxGroupBy.TabIndex = 0;
            this.toolTipAS.SetToolTip(this.comboBoxGroupBy, "Groups report into a chosen category");
            // 
            // groupBoxSortBy
            // 
            this.groupBoxSortBy.Controls.Add(this.rdoD);
            this.groupBoxSortBy.Controls.Add(this.rdoA);
            this.groupBoxSortBy.Location = new System.Drawing.Point(848, 105);
            this.groupBoxSortBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSortBy.Name = "groupBoxSortBy";
            this.groupBoxSortBy.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSortBy.Size = new System.Drawing.Size(339, 203);
            this.groupBoxSortBy.TabIndex = 2;
            this.groupBoxSortBy.TabStop = false;
            this.groupBoxSortBy.Text = "Sort by:";
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(76, 132);
            this.rdoD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(157, 29);
            this.rdoD.TabIndex = 1;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "Descending";
            this.toolTipAS.SetToolTip(this.rdoD, "Sorts report in descending order");
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(89, 57);
            this.rdoA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(144, 29);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "Ascending";
            this.toolTipAS.SetToolTip(this.rdoA, "Sorts report in ascending order");
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.SkyBlue;
            this.btnApply.Location = new System.Drawing.Point(18, 666);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(410, 75);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "&Apply";
            this.toolTipAS.SetToolTip(this.btnApply, "This button filters the output");
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Location = new System.Drawing.Point(780, 666);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(407, 75);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "&Back";
            this.toolTipAS.SetToolTip(this.btnBack, "This button prints the generated report");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(466, 327);
            this.lblReport.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(266, 29);
            this.lblReport.TabIndex = 32;
            this.lblReport.Text = "DONATION RECORDS";
            this.lblReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripExit});
            this.menuStrip1.Location = new System.Drawing.Point(1120, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(80, 755);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripExit
            // 
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(61, 36);
            this.toolStripExit.Text = "Exit";
            this.toolStripExit.ToolTipText = "Closes the application";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(22, 619);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(165, 25);
            this.lblRecordCount.TabIndex = 34;
            this.lblRecordCount.Text = "Records Found:";
            // 
            // DonationsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 755);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBoxSortBy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDonationReport);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DonationsReport";
            this.Text = "DonationsReport";
            this.Load += new System.EventHandler(this.DonationsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxSortBy.ResumeLayout(false);
            this.groupBoxSortBy.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxGroupBy;
        private System.Windows.Forms.GroupBox groupBoxSortBy;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTipAS;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        public System.Windows.Forms.DataGridView dgvDonationReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.Label lblRecordCount;
    }
}