namespace SMSApplication
{
    partial class Activation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activation));
            this.lblDOTP = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnGetOtp = new System.Windows.Forms.Button();
            this.txtRegistrationKey = new System.Windows.Forms.TextBox();
            this.lblDRegistrationKey = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblDAddress = new System.Windows.Forms.Label();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.lblDEmailId = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblDMobileNo = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblDCustomerName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDInternet = new System.Windows.Forms.Label();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.lnllblServerSetting = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDOTP
            // 
            this.lblDOTP.AutoSize = true;
            this.lblDOTP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDOTP.Location = new System.Drawing.Point(81, 238);
            this.lblDOTP.Name = "lblDOTP";
            this.lblDOTP.Size = new System.Drawing.Size(31, 17);
            this.lblDOTP.TabIndex = 27;
            this.lblDOTP.Text = "OTP";
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtOTP.Location = new System.Drawing.Point(119, 234);
            this.txtOTP.MaxLength = 6;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(149, 25);
            this.txtOTP.TabIndex = 4;
            this.txtOTP.TextChanged += new System.EventHandler(this.txtotp_TextChanged);
            this.txtOTP.Enter += new System.EventHandler(this.txtotp_Enter);
            this.txtOTP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtotp_KeyDown);
            this.txtOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtotp_KeyPress);
            this.txtOTP.Leave += new System.EventHandler(this.txtotp_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSubmit.Location = new System.Drawing.Point(116, 269);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 28);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnGetOtp
            // 
            this.btnGetOtp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGetOtp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGetOtp.Location = new System.Drawing.Point(283, 232);
            this.btnGetOtp.Name = "btnGetOtp";
            this.btnGetOtp.Size = new System.Drawing.Size(99, 28);
            this.btnGetOtp.TabIndex = 5;
            this.btnGetOtp.Text = "Get OTP";
            this.btnGetOtp.UseVisualStyleBackColor = true;
            this.btnGetOtp.Click += new System.EventHandler(this.btnGetOtp_Click);
            // 
            // txtRegistrationKey
            // 
            this.txtRegistrationKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRegistrationKey.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtRegistrationKey.Location = new System.Drawing.Point(119, 199);
            this.txtRegistrationKey.Name = "txtRegistrationKey";
            this.txtRegistrationKey.ReadOnly = true;
            this.txtRegistrationKey.Size = new System.Drawing.Size(263, 25);
            this.txtRegistrationKey.TabIndex = 23;
            // 
            // lblDRegistrationKey
            // 
            this.lblDRegistrationKey.AutoSize = true;
            this.lblDRegistrationKey.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDRegistrationKey.Location = new System.Drawing.Point(10, 203);
            this.lblDRegistrationKey.Name = "lblDRegistrationKey";
            this.lblDRegistrationKey.Size = new System.Drawing.Size(103, 17);
            this.lblDRegistrationKey.TabIndex = 22;
            this.lblDRegistrationKey.Text = "Registration Key";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAddress.Location = new System.Drawing.Point(119, 126);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(263, 63);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Enter += new System.EventHandler(this.txtAddress_Enter);
            this.txtAddress.Leave += new System.EventHandler(this.txtAddress_Leave);
            // 
            // lblDAddress
            // 
            this.lblDAddress.AutoSize = true;
            this.lblDAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDAddress.Location = new System.Drawing.Point(57, 149);
            this.lblDAddress.Name = "lblDAddress";
            this.lblDAddress.Size = new System.Drawing.Size(56, 17);
            this.lblDAddress.TabIndex = 20;
            this.lblDAddress.Text = "Address";
            // 
            // txtEmailId
            // 
            this.txtEmailId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtEmailId.Location = new System.Drawing.Point(119, 91);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(263, 25);
            this.txtEmailId.TabIndex = 2;
            this.txtEmailId.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmailId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmailId.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblDEmailId
            // 
            this.lblDEmailId.AutoSize = true;
            this.lblDEmailId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDEmailId.Location = new System.Drawing.Point(52, 95);
            this.lblDEmailId.Name = "lblDEmailId";
            this.lblDEmailId.Size = new System.Drawing.Size(61, 17);
            this.lblDEmailId.TabIndex = 18;
            this.lblDEmailId.Text = "E-Mail ID";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtMobileNo.Location = new System.Drawing.Point(119, 56);
            this.txtMobileNo.MaxLength = 10;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(263, 25);
            this.txtMobileNo.TabIndex = 1;
            this.txtMobileNo.Enter += new System.EventHandler(this.txtMobile_Enter);
            this.txtMobileNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            this.txtMobileNo.Leave += new System.EventHandler(this.txtMobile_Leave);
            // 
            // lblDMobileNo
            // 
            this.lblDMobileNo.AutoSize = true;
            this.lblDMobileNo.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDMobileNo.Location = new System.Drawing.Point(12, 60);
            this.lblDMobileNo.Name = "lblDMobileNo";
            this.lblDMobileNo.Size = new System.Drawing.Size(101, 17);
            this.lblDMobileNo.TabIndex = 16;
            this.lblDMobileNo.Text = "Mobile Number";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCustomerName.Location = new System.Drawing.Point(119, 17);
            this.txtCustomerName.MaxLength = 250;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(263, 25);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            this.txtCustomerName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblDCustomerName
            // 
            this.lblDCustomerName.AutoSize = true;
            this.lblDCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblDCustomerName.Location = new System.Drawing.Point(10, 21);
            this.lblDCustomerName.Name = "lblDCustomerName";
            this.lblDCustomerName.Size = new System.Drawing.Size(103, 17);
            this.lblDCustomerName.TabIndex = 14;
            this.lblDCustomerName.Text = "Customer Name";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCancel.Location = new System.Drawing.Point(197, 269);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // lblDInternet
            // 
            this.lblDInternet.AutoSize = true;
            this.lblDInternet.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDInternet.Location = new System.Drawing.Point(250, 1);
            this.lblDInternet.Name = "lblDInternet";
            this.lblDInternet.Size = new System.Drawing.Size(57, 13);
            this.lblDInternet.TabIndex = 28;
            this.lblDInternet.Text = "Internet : ";
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetwork.Location = new System.Drawing.Point(304, 1);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(0, 13);
            this.lblNetwork.TabIndex = 29;
            // 
            // lnllblServerSetting
            // 
            this.lnllblServerSetting.AutoSize = true;
            this.lnllblServerSetting.BackColor = System.Drawing.Color.Transparent;
            this.lnllblServerSetting.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnllblServerSetting.ForeColor = System.Drawing.Color.Black;
            this.lnllblServerSetting.LinkColor = System.Drawing.Color.Blue;
            this.lnllblServerSetting.Location = new System.Drawing.Point(278, 275);
            this.lnllblServerSetting.Name = "lnllblServerSetting";
            this.lnllblServerSetting.Size = new System.Drawing.Size(101, 17);
            this.lnllblServerSetting.TabIndex = 30;
            this.lnllblServerSetting.TabStop = true;
            this.lnllblServerSetting.Text = "Server Settings";
            this.lnllblServerSetting.Visible = false;
            this.lnllblServerSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Activation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 306);
            this.Controls.Add(this.lnllblServerSetting);
            this.Controls.Add(this.lblNetwork);
            this.Controls.Add(this.lblDInternet);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDOTP);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnGetOtp);
            this.Controls.Add(this.txtRegistrationKey);
            this.Controls.Add(this.lblDRegistrationKey);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblDAddress);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.lblDEmailId);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.lblDMobileNo);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblDCustomerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Activation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activation Wizard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnGetOtp;
        private System.Windows.Forms.TextBox txtRegistrationKey;
        private System.Windows.Forms.Label lblDRegistrationKey;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblDAddress;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.Label lblDEmailId;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblDMobileNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblDCustomerName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.Label lblDInternet;
        private System.Windows.Forms.LinkLabel lnllblServerSetting;
    }
}