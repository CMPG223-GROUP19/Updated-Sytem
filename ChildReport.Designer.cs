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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblRecords = new System.Windows.Forms.Label();
            this.dgvChildReport = new System.Windows.Forms.DataGridView();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoD = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxIsAccepted = new System.Windows.Forms.GroupBox();
            this.rdbDepartedChildren = new System.Windows.Forms.RadioButton();
            this.rdbNotAcceptedChildren = new System.Windows.Forms.RadioButton();
            this.rdbAcceptedChildren = new System.Windows.Forms.RadioButton();
            this.rdbAllChildren = new System.Windows.Forms.RadioButton();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildReport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxIsAccepted.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(26, 0);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(14, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.SkyBlue;
            this.btnApply.Location = new System.Drawing.Point(26, 670);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(416, 77);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "&Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBack.Location = new System.Drawing.Point(766, 670);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(375, 77);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "&Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(343, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(376, 40);
            this.lblHeading.TabIndex = 10;
            this.lblHeading.Text = "CHILDREN REPORT";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(387, 381);
            this.lblRecords.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(259, 29);
            this.lblRecords.TabIndex = 33;
            this.lblRecords.Text = "CHILDREN RECORDS";
            // 
            // dgvChildReport
            // 
            this.dgvChildReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildReport.Location = new System.Drawing.Point(26, 425);
            this.dgvChildReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvChildReport.Name = "dgvChildReport";
            this.dgvChildReport.RowHeadersWidth = 51;
            this.dgvChildReport.RowTemplate.Height = 24;
            this.dgvChildReport.Size = new System.Drawing.Size(1115, 194);
            this.dgvChildReport.TabIndex = 2;
            // 
            // rdoA
            // 
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(9, 53);
            this.rdoA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(144, 29);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "Ascending";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoD
            // 
            this.rdoD.AutoSize = true;
            this.rdoD.Location = new System.Drawing.Point(9, 92);
            this.rdoD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoD.Name = "rdoD";
            this.rdoD.Size = new System.Drawing.Size(157, 29);
            this.rdoD.TabIndex = 1;
            this.rdoD.TabStop = true;
            this.rdoD.Text = "Descending";
            this.rdoD.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoD);
            this.groupBox1.Controls.Add(this.rdoA);
            this.groupBox1.Location = new System.Drawing.Point(572, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(552, 144);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // groupBoxIsAccepted
            // 
            this.groupBoxIsAccepted.Controls.Add(this.rdbDepartedChildren);
            this.groupBoxIsAccepted.Controls.Add(this.rdbNotAcceptedChildren);
            this.groupBoxIsAccepted.Controls.Add(this.rdbAcceptedChildren);
            this.groupBoxIsAccepted.Controls.Add(this.rdbAllChildren);
            this.groupBoxIsAccepted.Location = new System.Drawing.Point(26, 218);
            this.groupBoxIsAccepted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIsAccepted.Name = "groupBoxIsAccepted";
            this.groupBoxIsAccepted.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxIsAccepted.Size = new System.Drawing.Size(1098, 134);
            this.groupBoxIsAccepted.TabIndex = 2;
            this.groupBoxIsAccepted.TabStop = false;
            this.groupBoxIsAccepted.Text = "Child Status";
            // 
            // rdbDepartedChildren
            // 
            this.rdbDepartedChildren.AutoSize = true;
            this.rdbDepartedChildren.Location = new System.Drawing.Point(546, 90);
            this.rdbDepartedChildren.Name = "rdbDepartedChildren";
            this.rdbDepartedChildren.Size = new System.Drawing.Size(217, 29);
            this.rdbDepartedChildren.TabIndex = 3;
            this.rdbDepartedChildren.TabStop = true;
            this.rdbDepartedChildren.Text = "Departed Children";
            this.rdbDepartedChildren.UseVisualStyleBackColor = true;
            // 
            // rdbNotAcceptedChildren
            // 
            this.rdbNotAcceptedChildren.AutoSize = true;
            this.rdbNotAcceptedChildren.Location = new System.Drawing.Point(546, 32);
            this.rdbNotAcceptedChildren.Name = "rdbNotAcceptedChildren";
            this.rdbNotAcceptedChildren.Size = new System.Drawing.Size(258, 29);
            this.rdbNotAcceptedChildren.TabIndex = 2;
            this.rdbNotAcceptedChildren.TabStop = true;
            this.rdbNotAcceptedChildren.Text = "Not Accepted Children";
            this.rdbNotAcceptedChildren.UseVisualStyleBackColor = true;
            // 
            // rdbAcceptedChildren
            // 
            this.rdbAcceptedChildren.AutoSize = true;
            this.rdbAcceptedChildren.Location = new System.Drawing.Point(32, 90);
            this.rdbAcceptedChildren.Name = "rdbAcceptedChildren";
            this.rdbAcceptedChildren.Size = new System.Drawing.Size(219, 29);
            this.rdbAcceptedChildren.TabIndex = 1;
            this.rdbAcceptedChildren.TabStop = true;
            this.rdbAcceptedChildren.Text = "Accepted Children";
            this.rdbAcceptedChildren.UseVisualStyleBackColor = true;
            // 
            // rdbAllChildren
            // 
            this.rdbAllChildren.AutoSize = true;
            this.rdbAllChildren.Location = new System.Drawing.Point(32, 32);
            this.rdbAllChildren.Name = "rdbAllChildren";
            this.rdbAllChildren.Size = new System.Drawing.Size(165, 29);
            this.rdbAllChildren.TabIndex = 0;
            this.rdbAllChildren.TabStop = true;
            this.rdbAllChildren.Text = "All Children  ";
            this.rdbAllChildren.UseVisualStyleBackColor = true;
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Items.AddRange(new object[] {
            "Child Name",
            "Arrival Date",
            "Child ID"});
            this.cmbSortBy.Location = new System.Drawing.Point(32, 89);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(369, 33);
            this.cmbSortBy.TabIndex = 34;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSortBy);
            this.groupBox2.Location = new System.Drawing.Point(26, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 156);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Records By:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(21, 624);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(165, 25);
            this.lblRecordCount.TabIndex = 36;
            this.lblRecordCount.Text = "Records Found:";
            // 
            // ChildReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 752);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBoxIsAccepted);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvChildReport);
            this.Controls.Add(this.checkedListBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildReport";
            this.Text = "ChildReport";
            this.Load += new System.EventHandler(this.ChildReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildReport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxIsAccepted.ResumeLayout(false);
            this.groupBoxIsAccepted.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.DataGridView dgvChildReport;
        private System.Windows.Forms.RadioButton rdoA;
        private System.Windows.Forms.RadioButton rdoD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxIsAccepted;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.RadioButton rdbDepartedChildren;
        private System.Windows.Forms.RadioButton rdbNotAcceptedChildren;
        private System.Windows.Forms.RadioButton rdbAcceptedChildren;
        private System.Windows.Forms.RadioButton rdbAllChildren;
    }
}