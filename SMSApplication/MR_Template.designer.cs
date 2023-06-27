namespace SMSApplication
{
    partial class MR_Template
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
            this.txttempid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttempcontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbenglish = new System.Windows.Forms.RadioButton();
            this.rbunicode = new System.Windows.Forms.RadioButton();
            this.cmbsender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchemeCode = new System.Windows.Forms.Label();
            this.lblDStatus = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTempname = new System.Windows.Forms.TextBox();
            this.lblobjDschemeName = new System.Windows.Forms.Label();
            this.epMR_Template = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbScheme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Template)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScheme
            // 
            this.gbScheme.Controls.Add(this.txttempid);
            this.gbScheme.Controls.Add(this.label3);
            this.gbScheme.Controls.Add(this.txttempcontant);
            this.gbScheme.Controls.Add(this.label4);
            this.gbScheme.Controls.Add(this.groupBox1);
            this.gbScheme.Controls.Add(this.cmbsender);
            this.gbScheme.Controls.Add(this.label2);
            this.gbScheme.Controls.Add(this.label1);
            this.gbScheme.Controls.Add(this.lblSchemeCode);
            this.gbScheme.Controls.Add(this.lblDStatus);
            this.gbScheme.Controls.Add(this.gbStatus);
            this.gbScheme.Controls.Add(this.btnClose);
            this.gbScheme.Controls.Add(this.btnSave);
            this.gbScheme.Controls.Add(this.txtTempname);
            this.gbScheme.Controls.Add(this.lblobjDschemeName);
            this.gbScheme.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheme.Location = new System.Drawing.Point(8, 5);
            this.gbScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Name = "gbScheme";
            this.gbScheme.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Size = new System.Drawing.Size(636, 263);
            this.gbScheme.TabIndex = 0;
            this.gbScheme.TabStop = false;
            // 
            // txttempid
            // 
            this.txttempid.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttempid.Location = new System.Drawing.Point(123, 66);
            this.txttempid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttempid.MaxLength = 100;
            this.txttempid.Name = "txttempid";
            this.txttempid.Size = new System.Drawing.Size(187, 25);
            this.txttempid.TabIndex = 1;
            this.txttempid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttempid_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Template ID";
            // 
            // txttempcontant
            // 
            this.txttempcontant.Location = new System.Drawing.Point(123, 102);
            this.txttempcontant.MaxLength = 500;
            this.txttempcontant.Multiline = true;
            this.txttempcontant.Name = "txttempcontant";
            this.txttempcontant.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txttempcontant.Size = new System.Drawing.Size(498, 106);
            this.txttempcontant.TabIndex = 5;
            this.txttempcontant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttempcontant_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Content";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbenglish);
            this.groupBox1.Controls.Add(this.rbunicode);
            this.groupBox1.Location = new System.Drawing.Point(432, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 42);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbenglish
            // 
            this.rbenglish.AutoSize = true;
            this.rbenglish.Location = new System.Drawing.Point(98, 13);
            this.rbenglish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbenglish.Name = "rbenglish";
            this.rbenglish.Size = new System.Drawing.Size(67, 21);
            this.rbenglish.TabIndex = 3;
            this.rbenglish.Text = "English";
            this.rbenglish.UseVisualStyleBackColor = true;
            this.rbenglish.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbenglish_KeyDown);
            // 
            // rbunicode
            // 
            this.rbunicode.AutoSize = true;
            this.rbunicode.Checked = true;
            this.rbunicode.Location = new System.Drawing.Point(12, 13);
            this.rbunicode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbunicode.Name = "rbunicode";
            this.rbunicode.Size = new System.Drawing.Size(74, 21);
            this.rbunicode.TabIndex = 2;
            this.rbunicode.TabStop = true;
            this.rbunicode.Text = "Unicode";
            this.rbunicode.UseVisualStyleBackColor = true;
            this.rbunicode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rbunicode_KeyDown);
            // 
            // cmbsender
            // 
            this.cmbsender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsender.FormattingEnabled = true;
            this.cmbsender.Location = new System.Drawing.Point(432, 66);
            this.cmbsender.Name = "cmbsender";
            this.cmbsender.Size = new System.Drawing.Size(187, 25);
            this.cmbsender.TabIndex = 4;
            this.cmbsender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbsender_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Content Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sender ID";
            // 
            // lblSchemeCode
            // 
            this.lblSchemeCode.AutoSize = true;
            this.lblSchemeCode.Location = new System.Drawing.Point(429, 102);
            this.lblSchemeCode.Name = "lblSchemeCode";
            this.lblSchemeCode.Size = new System.Drawing.Size(15, 17);
            this.lblSchemeCode.TabIndex = 99999;
            this.lblSchemeCode.Text = "0";
            this.lblSchemeCode.Visible = false;
            // 
            // lblDStatus
            // 
            this.lblDStatus.AutoSize = true;
            this.lblDStatus.Location = new System.Drawing.Point(13, 222);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(43, 17);
            this.lblDStatus.TabIndex = 9999;
            this.lblDStatus.Text = "Status";
            this.lblDStatus.Visible = false;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(123, 209);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(187, 42);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Visible = false;
            // 
            // rbInActive
            // 
            this.rbInActive.AutoSize = true;
            this.rbInActive.Location = new System.Drawing.Point(98, 13);
            this.rbInActive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbInActive.Name = "rbInActive";
            this.rbInActive.Size = new System.Drawing.Size(69, 21);
            this.rbInActive.TabIndex = 7;
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
            this.rbActive.TabIndex = 6;
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
            this.btnClose.Location = new System.Drawing.Point(531, 222);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.TabIndex = 7;
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
            this.btnSave.Location = new System.Drawing.Point(444, 222);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTempname
            // 
            this.txtTempname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempname.Location = new System.Drawing.Point(123, 24);
            this.txtTempname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTempname.MaxLength = 100;
            this.txtTempname.Name = "txtTempname";
            this.txtTempname.Size = new System.Drawing.Size(187, 25);
            this.txtTempname.TabIndex = 0;
            this.txtTempname.Enter += new System.EventHandler(this.txtSchemeName_Enter);
            this.txtTempname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSchemeName_KeyDown);
            this.txtTempname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchemeName_KeyPress);
            this.txtTempname.Leave += new System.EventHandler(this.txtSchemeName_Leave);
            // 
            // lblobjDschemeName
            // 
            this.lblobjDschemeName.AutoSize = true;
            this.lblobjDschemeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjDschemeName.Location = new System.Drawing.Point(13, 28);
            this.lblobjDschemeName.Name = "lblobjDschemeName";
            this.lblobjDschemeName.Size = new System.Drawing.Size(100, 17);
            this.lblobjDschemeName.TabIndex = 9999;
            this.lblobjDschemeName.Text = "Template Name";
            // 
            // epMR_Template
            // 
            this.epMR_Template.ContainerControl = this;
            // 
            // MR_Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(654, 278);
            this.Controls.Add(this.gbScheme);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(350, 150);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MR_Template";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Template";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MR_Template_FormClosing);
            this.Load += new System.EventHandler(this.MR_Template_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_Template_KeyDown);
            this.Leave += new System.EventHandler(this.MR_Template_Leave);
            this.gbScheme.ResumeLayout(false);
            this.gbScheme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Template)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScheme;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtTempname;
        private System.Windows.Forms.Label lblobjDschemeName;
        private System.Windows.Forms.ErrorProvider epMR_Template;
        public System.Windows.Forms.Label lblSchemeCode;
        private System.Windows.Forms.Label lblDStatus;
        public System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.RadioButton rbInActive;
        public System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rbenglish;
        public System.Windows.Forms.RadioButton rbunicode;
        private System.Windows.Forms.ComboBox cmbsender;
        private System.Windows.Forms.TextBox txttempcontant;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txttempid;
        private System.Windows.Forms.Label label3;
    }
}