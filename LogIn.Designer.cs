namespace TawandaSystem
{
    partial class LogIn
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblMotto = new System.Windows.Forms.Label();
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lnkLogHelp = new System.Windows.Forms.LinkLabel();
            this.pcbxLogo = new System.Windows.Forms.PictureBox();
            this.toolTipLogIn = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.gbxLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(364, 250);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(545, 40);
            this.lblHeading.TabIndex = 5;
            this.lblHeading.Text = "TAWANDA - HOME OF LOVE";
            // 
            // lblMotto
            // 
            this.lblMotto.AutoSize = true;
            this.lblMotto.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotto.Location = new System.Drawing.Point(384, 290);
            this.lblMotto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMotto.Name = "lblMotto";
            this.lblMotto.Size = new System.Drawing.Size(511, 33);
            this.lblMotto.TabIndex = 0;
            this.lblMotto.Text = "Providing love, care and opportunities...";
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.Controls.Add(this.checkBox1);
            this.gbxLogIn.Controls.Add(this.btnCancel);
            this.gbxLogIn.Controls.Add(this.txtPassword);
            this.gbxLogIn.Controls.Add(this.btnLogIn);
            this.gbxLogIn.Controls.Add(this.lblPassword);
            this.gbxLogIn.Controls.Add(this.txtUser);
            this.gbxLogIn.Controls.Add(this.lblUser);
            this.gbxLogIn.Location = new System.Drawing.Point(56, 350);
            this.gbxLogIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbxLogIn.Size = new System.Drawing.Size(1079, 396);
            this.gbxLogIn.TabIndex = 1;
            this.gbxLogIn.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(523, 155);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(196, 155);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(240, 31);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(40, 161);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(126, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(198, 70);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(238, 31);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(38, 70);
            this.lblUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(130, 29);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Username:";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogIn.Location = new System.Drawing.Point(12, 299);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(244, 69);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "LOGIN";
            this.toolTipLogIn.SetToolTip(this.btnLogIn, "This button allows access to the system");
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Azure;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(814, 299);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(244, 69);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "CANCEL";
            this.toolTipLogIn.SetToolTip(this.btnCancel, "This button cancels the log in process");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lnkLogHelp
            // 
            this.lnkLogHelp.AutoSize = true;
            this.lnkLogHelp.LinkColor = System.Drawing.Color.Teal;
            this.lnkLogHelp.Location = new System.Drawing.Point(1170, 14);
            this.lnkLogHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLogHelp.Name = "lnkLogHelp";
            this.lnkLogHelp.Size = new System.Drawing.Size(56, 25);
            this.lnkLogHelp.TabIndex = 4;
            this.lnkLogHelp.TabStop = true;
            this.lnkLogHelp.Text = "Help";
            this.toolTipLogIn.SetToolTip(this.lnkLogHelp, "Displays a help function");
            this.lnkLogHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogHelp_LinkClicked);
            // 
            // pcbxLogo
            // 
            this.pcbxLogo.Image = global::TawandaSystem.Properties.Resources.Slide1__1_;
            this.pcbxLogo.Location = new System.Drawing.Point(350, 14);
            this.pcbxLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pcbxLogo.Name = "pcbxLogo";
            this.pcbxLogo.Size = new System.Drawing.Size(574, 324);
            this.pcbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxLogo.TabIndex = 0;
            this.pcbxLogo.TabStop = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(150, 29);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(437, 768);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.Size = new System.Drawing.Size(249, 25);
            this.lnkRegister.TabIndex = 5;
            this.lnkRegister.TabStop = true;
            this.lnkRegister.Text = "New user? Register here";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1269, 831);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.lnkLogHelp);
            this.Controls.Add(this.gbxLogIn);
            this.Controls.Add(this.lblMotto);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.pcbxLogo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "LogIn";
            this.Text = "LOG IN";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbxLogo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblMotto;
        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox txtUser;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel lnkLogHelp;
        private System.Windows.Forms.ToolTip toolTipLogIn;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.LinkLabel lnkRegister;
    }
}

