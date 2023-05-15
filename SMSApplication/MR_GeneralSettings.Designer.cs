namespace SMSApplication
{
    partial class MR_GeneralSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_GeneralSettings));
            this.lblDOldPassword = new System.Windows.Forms.Label();
            this.gbCollegeProfile = new System.Windows.Forms.GroupBox();
            this.gbChangePassword = new System.Windows.Forms.GroupBox();
            this.txtStaffReportnumber = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.lblDNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblDConfirmPassword = new System.Windows.Forms.Label();
            this.lblProfilePhotoPath = new System.Windows.Forms.Label();
            this.lblProfilePhotoFileName = new System.Windows.Forms.Label();
            this.lblCollegeLogoPath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.epMR_GeneralSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsCollegeProfile = new System.Windows.Forms.ToolStrip();
            this.tspHeader = new System.Windows.Forms.ToolStripLabel();
            this.gbCollegeProfile.SuspendLayout();
            this.gbChangePassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).BeginInit();
            this.tsCollegeProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDOldPassword
            // 
            this.lblDOldPassword.AutoSize = true;
            this.lblDOldPassword.Location = new System.Drawing.Point(28, 238);
            this.lblDOldPassword.Name = "lblDOldPassword";
            this.lblDOldPassword.Size = new System.Drawing.Size(76, 17);
            this.lblDOldPassword.TabIndex = 1;
            this.lblDOldPassword.Text = "FROM Time";
            this.lblDOldPassword.Visible = false;
            // 
            // gbCollegeProfile
            // 
            this.gbCollegeProfile.Controls.Add(this.gbChangePassword);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoPath);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoFileName);
            this.gbCollegeProfile.Controls.Add(this.lblCollegeLogoPath);
            this.gbCollegeProfile.Location = new System.Drawing.Point(20, 33);
            this.gbCollegeProfile.Name = "gbCollegeProfile";
            this.gbCollegeProfile.Size = new System.Drawing.Size(1321, 572);
            this.gbCollegeProfile.TabIndex = 0;
            this.gbCollegeProfile.TabStop = false;
            // 
            // gbChangePassword
            // 
            this.gbChangePassword.Controls.Add(this.txtStaffReportnumber);
            this.gbChangePassword.Controls.Add(this.maskedTextBox2);
            this.gbChangePassword.Controls.Add(this.maskedTextBox1);
            this.gbChangePassword.Controls.Add(this.label2);
            this.gbChangePassword.Controls.Add(this.btnSave);
            this.gbChangePassword.Controls.Add(this.label1);
            this.gbChangePassword.Controls.Add(this.txtNewPwd);
            this.gbChangePassword.Controls.Add(this.lblDNewPassword);
            this.gbChangePassword.Controls.Add(this.lblDOldPassword);
            this.gbChangePassword.Controls.Add(this.txtConfirmPwd);
            this.gbChangePassword.Controls.Add(this.lblDConfirmPassword);
            this.gbChangePassword.Location = new System.Drawing.Point(442, 181);
            this.gbChangePassword.Name = "gbChangePassword";
            this.gbChangePassword.Size = new System.Drawing.Size(444, 147);
            this.gbChangePassword.TabIndex = 0;
            this.gbChangePassword.TabStop = false;
            // 
            // txtStaffReportnumber
            // 
            this.txtStaffReportnumber.Location = new System.Drawing.Point(174, 30);
            this.txtStaffReportnumber.Multiline = true;
            this.txtStaffReportnumber.Name = "txtStaffReportnumber";
            this.txtStaffReportnumber.Size = new System.Drawing.Size(249, 72);
            this.txtStaffReportnumber.TabIndex = 254;
            this.txtStaffReportnumber.TextChanged += new System.EventHandler(this.txtStaffReportnumber_TextChanged);
            this.txtStaffReportnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStaffReportnumber_KeyPress);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(100, 235);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(32, 25);
            this.maskedTextBox2.TabIndex = 253;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(233, 235);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(32, 25);
            this.maskedTextBox1.TabIndex = 252;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 251;
            this.label2.Text = "Single SMS Length for Unicode";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 17);
            this.label1.TabIndex = 250;
            this.label1.Text = "Single SMS Length for Engilsh";
            this.label1.Visible = false;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(233, 152);
            this.txtNewPwd.MaxLength = 50;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.Size = new System.Drawing.Size(32, 25);
            this.txtNewPwd.TabIndex = 2;
            this.txtNewPwd.Visible = false;
            this.txtNewPwd.Enter += new System.EventHandler(this.txtNewPwd_Enter);
            this.txtNewPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNewPwd_KeyDown);
            // 
            // lblDNewPassword
            // 
            this.lblDNewPassword.AutoSize = true;
            this.lblDNewPassword.Location = new System.Drawing.Point(151, 238);
            this.lblDNewPassword.Name = "lblDNewPassword";
            this.lblDNewPassword.Size = new System.Drawing.Size(56, 17);
            this.lblDNewPassword.TabIndex = 249;
            this.lblDNewPassword.Text = "TO Time";
            this.lblDNewPassword.Visible = false;
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(233, 192);
            this.txtConfirmPwd.MaxLength = 100;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.Size = new System.Drawing.Size(32, 25);
            this.txtConfirmPwd.TabIndex = 3;
            this.txtConfirmPwd.Visible = false;
            this.txtConfirmPwd.Enter += new System.EventHandler(this.txtConfirmPwd_Enter);
            this.txtConfirmPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPwd_KeyDown);
            this.txtConfirmPwd.Leave += new System.EventHandler(this.txtConfirmPwd_Leave);
            // 
            // lblDConfirmPassword
            // 
            this.lblDConfirmPassword.AutoSize = true;
            this.lblDConfirmPassword.Location = new System.Drawing.Point(28, 34);
            this.lblDConfirmPassword.Name = "lblDConfirmPassword";
            this.lblDConfirmPassword.Size = new System.Drawing.Size(140, 17);
            this.lblDConfirmPassword.TabIndex = 247;
            this.lblDConfirmPassword.Text = "Send Staff Report To : ";
            // 
            // lblProfilePhotoPath
            // 
            this.lblProfilePhotoPath.AutoSize = true;
            this.lblProfilePhotoPath.Location = new System.Drawing.Point(315, 495);
            this.lblProfilePhotoPath.Name = "lblProfilePhotoPath";
            this.lblProfilePhotoPath.Size = new System.Drawing.Size(0, 17);
            this.lblProfilePhotoPath.TabIndex = 251;
            this.lblProfilePhotoPath.Visible = false;
            // 
            // lblProfilePhotoFileName
            // 
            this.lblProfilePhotoFileName.AutoSize = true;
            this.lblProfilePhotoFileName.Location = new System.Drawing.Point(206, 495);
            this.lblProfilePhotoFileName.Name = "lblProfilePhotoFileName";
            this.lblProfilePhotoFileName.Size = new System.Drawing.Size(0, 17);
            this.lblProfilePhotoFileName.TabIndex = 250;
            this.lblProfilePhotoFileName.Visible = false;
            // 
            // lblCollegeLogoPath
            // 
            this.lblCollegeLogoPath.AutoSize = true;
            this.lblCollegeLogoPath.Location = new System.Drawing.Point(88, 505);
            this.lblCollegeLogoPath.Name = "lblCollegeLogoPath";
            this.lblCollegeLogoPath.Size = new System.Drawing.Size(0, 17);
            this.lblCollegeLogoPath.TabIndex = 249;
            this.lblCollegeLogoPath.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SMSApplication.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(344, 111);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 29);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Update";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epMR_GeneralSettings
            // 
            this.epMR_GeneralSettings.ContainerControl = this;
            // 
            // tsCollegeProfile
            // 
            this.tsCollegeProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCollegeProfile.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCollegeProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHeader});
            this.tsCollegeProfile.Location = new System.Drawing.Point(0, 0);
            this.tsCollegeProfile.Name = "tsCollegeProfile";
            this.tsCollegeProfile.Size = new System.Drawing.Size(1360, 25);
            this.tsCollegeProfile.TabIndex = 35;
            this.tsCollegeProfile.Text = "toolStrip1";
            // 
            // tspHeader
            // 
            this.tspHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspHeader.Image = ((System.Drawing.Image)(resources.GetObject("tspHeader.Image")));
            this.tspHeader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspHeader.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tspHeader.Name = "tspHeader";
            this.tspHeader.Size = new System.Drawing.Size(119, 22);
            this.tspHeader.Text = "General Settings";
            // 
            // MR_GeneralSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.tsCollegeProfile);
            this.Controls.Add(this.gbCollegeProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MR_GeneralSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "College Profile";
            this.Load += new System.EventHandler(this.MR_GeneralSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_GeneralSettings_KeyDown);
            this.Leave += new System.EventHandler(this.MR_GeneralSettings_Leave);
            this.gbCollegeProfile.ResumeLayout(false);
            this.gbCollegeProfile.PerformLayout();
            this.gbChangePassword.ResumeLayout(false);
            this.gbChangePassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).EndInit();
            this.tsCollegeProfile.ResumeLayout(false);
            this.tsCollegeProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDOldPassword;
        private System.Windows.Forms.GroupBox gbCollegeProfile;
        public System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDConfirmPassword;
        public System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.ErrorProvider epMR_GeneralSettings;
        public System.Windows.Forms.Label lblCollegeLogoPath;
        public System.Windows.Forms.Label lblProfilePhotoFileName;
        public System.Windows.Forms.Label lblProfilePhotoPath;
        private System.Windows.Forms.ToolStrip tsCollegeProfile;
        private System.Windows.Forms.ToolStripLabel tspHeader;
        private System.Windows.Forms.GroupBox gbChangePassword;
        public System.Windows.Forms.TextBox txtNewPwd;
        private System.Windows.Forms.Label lblDNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtStaffReportnumber;
    }
}