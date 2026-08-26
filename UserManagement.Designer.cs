namespace TawandaSystem
{
    partial class UserManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSelectedUser = new System.Windows.Forms.Label();
            this.txtSelectedUser = new System.Windows.Forms.TextBox();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.cmbAccountStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(403, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(443, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "User Management";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.Location = new System.Drawing.Point(329, 98);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(586, 32);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Manage Tawanda system users and their access levels";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(22, 147);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 82;
            this.dgvUsers.RowTemplate.Height = 33;
            this.dgvUsers.Size = new System.Drawing.Size(705, 387);
            this.dgvUsers.TabIndex = 3;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(768, 243);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(119, 32);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "User Role:";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Pending",
            "Manager",
            "Administrator"});
            this.cmbRole.Location = new System.Drawing.Point(1106, 242);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(313, 33);
            this.cmbRole.TabIndex = 5;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(760, 460);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(328, 74);
            this.btnUpdateRole.TabIndex = 6;
            this.btnUpdateRole.Text = "UPDATE ACCOUNT";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click_1);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(1145, 460);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(328, 74);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "DELETE USER";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(22, 621);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(328, 74);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "RELOAD ";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(868, 621);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(328, 74);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblSelectedUser
            // 
            this.lblSelectedUser.AutoSize = true;
            this.lblSelectedUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedUser.Location = new System.Drawing.Point(768, 166);
            this.lblSelectedUser.Name = "lblSelectedUser";
            this.lblSelectedUser.Size = new System.Drawing.Size(164, 32);
            this.lblSelectedUser.TabIndex = 10;
            this.lblSelectedUser.Text = "Selected User:";
            // 
            // txtSelectedUser
            // 
            this.txtSelectedUser.Location = new System.Drawing.Point(1106, 166);
            this.txtSelectedUser.Name = "txtSelectedUser";
            this.txtSelectedUser.ReadOnly = true;
            this.txtSelectedUser.Size = new System.Drawing.Size(256, 31);
            this.txtSelectedUser.TabIndex = 11;
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountStatus.Location = new System.Drawing.Point(768, 365);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(177, 32);
            this.lblAccountStatus.TabIndex = 12;
            this.lblAccountStatus.Text = "Account Status:";
            // 
            // cmbAccountStatus
            // 
            this.cmbAccountStatus.FormattingEnabled = true;
            this.cmbAccountStatus.Items.AddRange(new object[] {
            "Pending",
            "Active"});
            this.cmbAccountStatus.Location = new System.Drawing.Point(1106, 364);
            this.cmbAccountStatus.Name = "cmbAccountStatus";
            this.cmbAccountStatus.Size = new System.Drawing.Size(313, 33);
            this.cmbAccountStatus.TabIndex = 13;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 722);
            this.Controls.Add(this.cmbAccountStatus);
            this.Controls.Add(this.lblAccountStatus);
            this.Controls.Add(this.txtSelectedUser);
            this.Controls.Add(this.lblSelectedUser);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Name = "UserManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAWANDA - User Management";
            this.Load += new System.EventHandler(this.UserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelectedUser;
        private System.Windows.Forms.TextBox txtSelectedUser;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.ComboBox cmbAccountStatus;
    }
}