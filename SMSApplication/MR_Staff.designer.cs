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
            this.cmbBloodGroup = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbdesignation = new System.Windows.Forms.ComboBox();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddress3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpincode = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblbloodgroup = new System.Windows.Forms.Label();
            this.gbScheme.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Staff)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScheme
            // 
            this.gbScheme.Controls.Add(this.lblbloodgroup);
            this.gbScheme.Controls.Add(this.txtcity);
            this.gbScheme.Controls.Add(this.txtpincode);
            this.gbScheme.Controls.Add(this.label9);
            this.gbScheme.Controls.Add(this.label8);
            this.gbScheme.Controls.Add(this.textAddress3);
            this.gbScheme.Controls.Add(this.label7);
            this.gbScheme.Controls.Add(this.txtAddress2);
            this.gbScheme.Controls.Add(this.label5);
            this.gbScheme.Controls.Add(this.dpFromDate);
            this.gbScheme.Controls.Add(this.cmbdesignation);
            this.gbScheme.Controls.Add(this.label3);
            this.gbScheme.Controls.Add(this.label2);
            this.gbScheme.Controls.Add(this.cmbBloodGroup);
            this.gbScheme.Controls.Add(this.txtAddress);
            this.gbScheme.Controls.Add(this.label6);
            this.gbScheme.Controls.Add(this.label4);
            this.gbScheme.Controls.Add(this.txtMobileNo);
            this.gbScheme.Controls.Add(this.label1);
            this.gbScheme.Controls.Add(this.lblSchemeCode);
            this.gbScheme.Controls.Add(this.lblDStatus);
            this.gbScheme.Controls.Add(this.gbStatus);
            this.gbScheme.Controls.Add(this.txtStaffName);
            this.gbScheme.Controls.Add(this.lblobjDschemeName);
            this.gbScheme.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheme.Location = new System.Drawing.Point(8, 5);
            this.gbScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Name = "gbScheme";
            this.gbScheme.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Size = new System.Drawing.Size(630, 279);
            this.gbScheme.TabIndex = 0;
            this.gbScheme.TabStop = false;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(100, 65);
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
            this.label1.Location = new System.Drawing.Point(13, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mobile No.";
            // 
            // lblSchemeCode
            // 
            this.lblSchemeCode.AutoSize = true;
            this.lblSchemeCode.Location = new System.Drawing.Point(315, 402);
            this.lblSchemeCode.Name = "lblSchemeCode";
            this.lblSchemeCode.Size = new System.Drawing.Size(15, 17);
            this.lblSchemeCode.TabIndex = 7;
            this.lblSchemeCode.Text = "0";
            this.lblSchemeCode.Visible = false;
            // 
            // lblDStatus
            // 
            this.lblDStatus.AutoSize = true;
            this.lblDStatus.Location = new System.Drawing.Point(315, 238);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(43, 17);
            this.lblDStatus.TabIndex = 3;
            this.lblDStatus.Text = "Status";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(429, 225);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(187, 42);
            this.gbStatus.TabIndex = 9;
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
            this.btnClose.Location = new System.Drawing.Point(546, 288);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.TabIndex = 11;
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
            this.btnSave.Location = new System.Drawing.Point(459, 288);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStaffName
            // 
            this.txtStaffName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStaffName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(100, 24);
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
            // cmbBloodGroup
            // 
            this.cmbBloodGroup.FormattingEnabled = true;
            this.cmbBloodGroup.Location = new System.Drawing.Point(100, 146);
            this.cmbBloodGroup.Name = "cmbBloodGroup";
            this.cmbBloodGroup.Size = new System.Drawing.Size(187, 25);
            this.cmbBloodGroup.TabIndex = 3;
            this.cmbBloodGroup.SelectedIndexChanged += new System.EventHandler(this.cmbBloodGroup_SelectedIndexChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(429, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 24);
            this.txtAddress.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(315, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address  Line -1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Blood Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "DOB";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbdesignation
            // 
            this.cmbdesignation.FormattingEnabled = true;
            this.cmbdesignation.Location = new System.Drawing.Point(100, 187);
            this.cmbdesignation.Name = "cmbdesignation";
            this.cmbdesignation.Size = new System.Drawing.Size(187, 25);
            this.cmbdesignation.TabIndex = 4;
            // 
            // dpFromDate
            // 
            this.dpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(100, 106);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(187, 24);
            this.dpFromDate.TabIndex = 2;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Location = new System.Drawing.Point(429, 66);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(187, 24);
            this.txtAddress2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Address  Line -2";
            // 
            // textAddress3
            // 
            this.textAddress3.Location = new System.Drawing.Point(429, 108);
            this.textAddress3.Name = "textAddress3";
            this.textAddress3.Size = new System.Drawing.Size(187, 24);
            this.textAddress3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(315, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address  Line -3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(315, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(315, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "PinCode ";
            // 
            // txtpincode
            // 
            this.txtpincode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpincode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpincode.Location = new System.Drawing.Point(429, 192);
            this.txtpincode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpincode.MaxLength = 10;
            this.txtpincode.Name = "txtpincode";
            this.txtpincode.Size = new System.Drawing.Size(187, 25);
            this.txtpincode.TabIndex = 9;
            // 
            // txtcity
            // 
            this.txtcity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(429, 150);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcity.MaxLength = 10;
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(187, 25);
            this.txtcity.TabIndex = 8;
            // 
            // lblbloodgroup
            // 
            this.lblbloodgroup.AutoSize = true;
            this.lblbloodgroup.Location = new System.Drawing.Point(116, 250);
            this.lblbloodgroup.Name = "lblbloodgroup";
            this.lblbloodgroup.Size = new System.Drawing.Size(15, 17);
            this.lblbloodgroup.TabIndex = 33;
            this.lblbloodgroup.Text = "0";
            this.lblbloodgroup.Visible = false;
            // 
            // MR_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(647, 329);
            this.Controls.Add(this.gbScheme);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
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
        private System.Windows.Forms.ComboBox cmbBloodGroup;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdesignation;
        private System.Windows.Forms.DateTimePicker dpFromDate;
        private System.Windows.Forms.TextBox textAddress3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtpincode;
        public System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblbloodgroup;
    }
}