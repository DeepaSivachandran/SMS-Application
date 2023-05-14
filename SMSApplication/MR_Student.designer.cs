namespace SMSApplication
{
    partial class MR_Student
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSchemeCode = new System.Windows.Forms.Label();
            this.lblDStatus = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSchemeName = new System.Windows.Forms.TextBox();
            this.lblobjDschemeName = new System.Windows.Forms.Label();
            this.epMR_Student = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.gbScheme.SuspendLayout();
            this.gbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // gbScheme
            // 
            this.gbScheme.Controls.Add(this.textBox6);
            this.gbScheme.Controls.Add(this.textBox5);
            this.gbScheme.Controls.Add(this.label8);
            this.gbScheme.Controls.Add(this.label7);
            this.gbScheme.Controls.Add(this.textBox4);
            this.gbScheme.Controls.Add(this.label6);
            this.gbScheme.Controls.Add(this.textBox3);
            this.gbScheme.Controls.Add(this.textBox2);
            this.gbScheme.Controls.Add(this.comboBox2);
            this.gbScheme.Controls.Add(this.comboBox1);
            this.gbScheme.Controls.Add(this.label5);
            this.gbScheme.Controls.Add(this.label4);
            this.gbScheme.Controls.Add(this.label3);
            this.gbScheme.Controls.Add(this.label2);
            this.gbScheme.Controls.Add(this.textBox1);
            this.gbScheme.Controls.Add(this.label1);
            this.gbScheme.Controls.Add(this.lblSchemeCode);
            this.gbScheme.Controls.Add(this.lblDStatus);
            this.gbScheme.Controls.Add(this.gbStatus);
            this.gbScheme.Controls.Add(this.txtSchemeName);
            this.gbScheme.Controls.Add(this.lblobjDschemeName);
            this.gbScheme.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbScheme.Location = new System.Drawing.Point(8, 5);
            this.gbScheme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Name = "gbScheme";
            this.gbScheme.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbScheme.Size = new System.Drawing.Size(689, 252);
            this.gbScheme.TabIndex = 0;
            this.gbScheme.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 100;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 25);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Name";
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
            this.lblDStatus.Location = new System.Drawing.Point(340, 177);
            this.lblDStatus.Name = "lblDStatus";
            this.lblDStatus.Size = new System.Drawing.Size(43, 17);
            this.lblDStatus.TabIndex = 3;
            this.lblDStatus.Text = "Status";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInActive);
            this.gbStatus.Controls.Add(this.rbActive);
            this.gbStatus.Location = new System.Drawing.Point(485, 164);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(187, 42);
            this.gbStatus.TabIndex = 5;
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
            this.btnClose.Location = new System.Drawing.Point(600, 265);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 29);
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
            this.btnSave.Location = new System.Drawing.Point(513, 265);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 29);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSchemeName
            // 
            this.txtSchemeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSchemeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchemeName.Location = new System.Drawing.Point(136, 24);
            this.txtSchemeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSchemeName.MaxLength = 100;
            this.txtSchemeName.Name = "txtSchemeName";
            this.txtSchemeName.Size = new System.Drawing.Size(187, 25);
            this.txtSchemeName.TabIndex = 0;
            this.txtSchemeName.Enter += new System.EventHandler(this.txtSchemeName_Enter);
            this.txtSchemeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSchemeName_KeyDown);
            this.txtSchemeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSchemeName_KeyPress);
            this.txtSchemeName.Leave += new System.EventHandler(this.txtSchemeName_Leave);
            // 
            // lblobjDschemeName
            // 
            this.lblobjDschemeName.AutoSize = true;
            this.lblobjDschemeName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobjDschemeName.Location = new System.Drawing.Point(13, 28);
            this.lblobjDschemeName.Name = "lblobjDschemeName";
            this.lblobjDschemeName.Size = new System.Drawing.Size(93, 17);
            this.lblobjDschemeName.TabIndex = 0;
            this.lblobjDschemeName.Text = "Admission No.";
            // 
            // epMR_Student
            // 
            this.epMR_Student.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Blood Group";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Admission Card No.\r\n";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 25);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 25);
            this.comboBox2.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(136, 173);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 25);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(136, 208);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox3.MaxLength = 100;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 25);
            this.textBox3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(340, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Address";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(485, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(187, 62);
            this.textBox4.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Contact No.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alternative Contact No.";
            // 
            // textBox5
            // 
            this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(485, 99);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox5.MaxLength = 100;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(187, 25);
            this.textBox5.TabIndex = 22;
            // 
            // textBox6
            // 
            this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(485, 136);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox6.MaxLength = 100;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(187, 25);
            this.textBox6.TabIndex = 23;
            // 
            // MR_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(706, 305);
            this.Controls.Add(this.gbScheme);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(350, 150);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MR_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MR_Student_FormClosing);
            this.Load += new System.EventHandler(this.MR_Student_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_Student_KeyDown);
            this.Leave += new System.EventHandler(this.MR_Student_Leave);
            this.gbScheme.ResumeLayout(false);
            this.gbScheme.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScheme;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox txtSchemeName;
        private System.Windows.Forms.Label lblobjDschemeName;
        private System.Windows.Forms.ErrorProvider epMR_Student;
        public System.Windows.Forms.Label lblSchemeCode;
        private System.Windows.Forms.Label lblDStatus;
        public System.Windows.Forms.GroupBox gbStatus;
        public System.Windows.Forms.RadioButton rbInActive;
        public System.Windows.Forms.RadioButton rbActive;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox6;
        public System.Windows.Forms.TextBox textBox5;
    }
}