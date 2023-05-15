namespace SMSApplication
{
    partial class MR_Staff
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
            this.gbScheme = new System.Windows.Forms.GroupBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchemeCode = new System.Windows.Forms.Label();
            this.lblDStatus = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.lblobjDschemeName = new System.Windows.Forms.Label();
            this.epMR_Staff = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbScheme.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScheme
            // 
            this.gbScheme.Controls.Add(this.txtMobileNo);
            this.gbScheme.Controls.Add(this.label1);
            this.gbScheme.Controls.Add(this.lblSchemeCode);
            this.gbScheme.Controls.Add(this.lblDStatus);
            this.gbScheme.Controls.Add(this.gbStatus);
            this.gbScheme.Controls.Add(this.btnClose);
            this.gbScheme.Controls.Add(this.btnSave);
            this.gbScheme.Controls.Add(this.txtStaffName);
            this.gbScheme.Controls.Add(this.lblobjDschemeName);
            this.gbScheme.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheme.Location = new System.Drawing.Point(8, 5);
            this.gbScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Name = "gbScheme";
            this.gbScheme.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Size = new System.Drawing.Size(297, 199);
            this.gbScheme.TabIndex = 0;
            this.gbScheme.TabStop = false;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(90, 62);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(187, 25);
            this.txtMobileNo.TabIndex = 1;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mobile No.";
            // 
            // lblSchemeCode
            // 
            this.lblSchemeCode.AutoSize = true;
            this.lblSchemeCode.Location = new System.Drawing.Point(429, 102);
            this.lblSchemeCode.Name = "lblSchemeCode";
            this.lblSchemeCode.Size = new System.Drawing.Size(15, 17);
            this.lblSchemeCode.TabIndex = 7;
            this.lblSchemeCode.Text = "0";
            this.lblSchemeCode.Visible = false;
            // 
            // lblDStatus
            // 
            this.lblDStatus.AutoSize = true;
            this.lblDStatus.Location = new System.Drawing.Point(13, 107);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(43, 17);
            this.lblDStatus.TabIndex = 3;
            this.lblDStatus.Text = "Status";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(90, 92);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(187, 42);
            this.gbStatus.TabIndex = 2;
            this.gbStatus.TabStop = false;
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Location = new System.Drawing.Point(98, 13);
            this.rbInActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(69, 21);
            this.rbInActive.TabIndex = 1;
            this.rbInActive.Text = "Inactive";
            this.rbInActive.UseVisualStyleBackColor = true;
            this.rbInActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbInActive_KeyDown);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Checked = true;
            this.rbActive.Location = new System.Drawing.Point(12, 13);
            this.rbActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(60, 21);
            this.rbActive.TabIndex = 0;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbActive_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::SMSApplication.Properties.Resources.cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(197, 146);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::SMSApplication.Properties.Resources.save1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(110, 146);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(90, 24);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStaffName.MaxLength = 100;
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(187, 25);
            this.txtStaffName.TabIndex = 0;
            this.txtStaffName.Enter += new System.EventHandler(this.txtSchemeName_Enter);
            this.txtStaffName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSchemeName_KeyDown);
            this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchemeName_KeyPress);
            this.txtStaffName.Leave += new System.EventHandler(this.txtSchemeName_Leave);
            // 
            // lblobjDschemeName
            // 
            this.lblobjDschemeName.AutoSize = true;
            this.lblobjDschemeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjDschemeName.Location = new System.Drawing.Point(13, 28);
            this.lblobjDschemeName.Name = "lblobjDschemeName";
            this.lblobjDschemeName.Size = new System.Drawing.Size(73, 17);
            this.lblobjDschemeName.TabIndex = 0;
            this.lblobjDschemeName.Text = "Staff Name";
            // 
            // epMR_Staff
            // 
            this.epMR_Staff.ContainerControl = this;
            // 
            // MR_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(315, 215);
            this.Controls.Add(this.gbScheme);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(350, 150);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MR_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Staff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MR_Staff_FormClosing);
            this.Load += new System.EventHandler(this.MR_Staff_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_Staff_KeyDown);
            this.Leave += new System.EventHandler(this.MR_Staff_Leave);
            this.gbScheme.ResumeLayout(false);
            this.gbScheme.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Staff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScheme;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label lblobjDschemeName;
        private System.Windows.Forms.ErrorProvider epMR_Staff;
        public System.Windows.Forms.Label lblSchemeCode;
        private System.Windows.Forms.Label lblDStatus;
        public System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.RadioButton rbInActive;
        public System.Windows.Forms.RadioButton rbActive;
        public System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label1;
    }
}