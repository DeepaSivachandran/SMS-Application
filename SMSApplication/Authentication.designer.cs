﻿namespace SMSApplication
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.lblDUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblDPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblDVersion = new System.Windows.Forms.Label();
            this.pblLogin = new System.Windows.Forms.Panel();
            this.lnklblServerSettings = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSignin = new System.Windows.Forms.Button();
            this.pblLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDUserName
            // 
            this.lblDUserName.AutoSize = true;
            this.lblDUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblDUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDUserName.ForeColor = System.Drawing.Color.White;
            this.lblDUserName.Location = new System.Drawing.Point(117, 31);
            this.lblDUserName.Name = "lblDUserName";
            this.lblDUserName.Size = new System.Drawing.Size(75, 17);
            this.lblDUserName.TabIndex = 0;
            this.lblDUserName.Text = "User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(198, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(211, 29);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUserName.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // lblDPassword
            // 
            this.lblDPassword.AutoSize = true;
            this.lblDPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblDPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDPassword.ForeColor = System.Drawing.Color.White;
            this.lblDPassword.Location = new System.Drawing.Point(117, 88);
            this.lblDPassword.Name = "lblDPassword";
            this.lblDPassword.Size = new System.Drawing.Size(66, 17);
            this.lblDPassword.TabIndex = 2;
            this.lblDPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(198, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(211, 29);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblDVersion
            // 
            this.lblDVersion.AutoSize = true;
            this.lblDVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblDVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVersion.ForeColor = System.Drawing.Color.White;
            this.lblDVersion.Location = new System.Drawing.Point(364, 326);
            this.lblDVersion.Name = "lblDVersion";
            this.lblDVersion.Size = new System.Drawing.Size(0, 17);
            this.lblDVersion.TabIndex = 7;
            // 
            // pblLogin
            // 
            this.pblLogin.BackColor = System.Drawing.Color.Transparent;
            this.pblLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pblLogin.Controls.Add(this.lnklblServerSettings);
            this.pblLogin.Controls.Add(this.btnClose);
            this.pblLogin.Controls.Add(this.txtUserName);
            this.pblLogin.Controls.Add(this.txtPassword);
            this.pblLogin.Controls.Add(this.lblDPassword);
            this.pblLogin.Controls.Add(this.lblDUserName);
            this.pblLogin.Controls.Add(this.btnSignin);
            this.pblLogin.Location = new System.Drawing.Point(242, 70);
            this.pblLogin.Name = "pblLogin";
            this.pblLogin.Size = new System.Drawing.Size(447, 218);
            this.pblLogin.TabIndex = 7;
            // 
            // lnklblServerSettings
            // 
            this.lnklblServerSettings.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnklblServerSettings.AutoSize = true;
            this.lnklblServerSettings.BackColor = System.Drawing.Color.Transparent;
            this.lnklblServerSettings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblServerSettings.ForeColor = System.Drawing.Color.White;
            this.lnklblServerSettings.LinkColor = System.Drawing.Color.White;
            this.lnklblServerSettings.Location = new System.Drawing.Point(117, 149);
            this.lnklblServerSettings.Name = "lnklblServerSettings";
            this.lnklblServerSettings.Size = new System.Drawing.Size(95, 17);
            this.lnklblServerSettings.TabIndex = 6;
            this.lnklblServerSettings.TabStop = true;
            this.lnklblServerSettings.Text = "Server Settings";
            this.lnklblServerSettings.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lnklblServerSettings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = global::SMSApplication.Properties.Resources.cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(324, 141);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 33);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.White;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.Black;
            this.btnSignin.Image = global::SMSApplication.Properties.Resources.signin;
            this.btnSignin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSignin.Location = new System.Drawing.Point(229, 141);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(85, 33);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "Login";
            this.btnSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::SMSApplication.Properties.Resources.Login__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.pblLogin);
            this.Controls.Add(this.lblDVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Application";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Authentication_KeyDown);
            this.pblLogin.ResumeLayout(false);
            this.pblLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblDPassword;
        public System.Windows.Forms.Button btnSignin;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblDVersion;
        private System.Windows.Forms.Panel pblLogin;
        private System.Windows.Forms.LinkLabel lnklblServerSettings;
        public System.Windows.Forms.TextBox txtPassword;
        // private System.Windows.Forms.Panel panel1;
    }
}