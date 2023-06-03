namespace SMSApplication
{
    partial class TRN_SMS_General
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRN_SMS_General));
            this.grdstudentsms = new System.Windows.Forms.DataGridView();
            this.clmstudentcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmadmission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSchemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tspFormHeader = new System.Windows.Forms.ToolStripLabel();
            this.lblDcolumnIndex = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtemplate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbsender = new System.Windows.Forms.ComboBox();
            this.lblsenderid = new System.Windows.Forms.Label();
            this.lblsmscount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsmscontent = new System.Windows.Forms.TextBox();
            this.grdstaffsms = new System.Windows.Forms.DataGridView();
            this.clmstaffcheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmstaffno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstaffid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkSelectStaff = new System.Windows.Forms.CheckBox();
            this.chkSelectstudent = new System.Windows.Forms.CheckBox();
            this.epMR_SMSStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsenderno = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.btnsmssend = new System.Windows.Forms.Button();
            this.btnsendsms = new System.Windows.Forms.Button();
            this.btnclassview = new System.Windows.Forms.Button();
            this.picLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentsms)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffsms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // grdstudentsms
            // 
            this.grdstudentsms.AllowUserToAddRows = false;
            this.grdstudentsms.AllowUserToDeleteRows = false;
            this.grdstudentsms.AllowUserToResizeRows = false;
            this.grdstudentsms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdstudentsms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstudentsms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdstudentsms.ColumnHeadersHeight = 30;
            this.grdstudentsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdstudentsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmstudentcheck,
            this.clmsno,
            this.clmadmission,
            this.clmsmid,
            this.admission,
            this.clmSchemeName,
            this.Column2,
            this.C});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdstudentsms.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdstudentsms.EnableHeadersVisualStyles = false;
            this.grdstudentsms.GridColor = System.Drawing.Color.White;
            this.grdstudentsms.Location = new System.Drawing.Point(17, 121);
            this.grdstudentsms.Name = "grdstudentsms";
            this.grdstudentsms.ReadOnly = true;
            this.grdstudentsms.RowHeadersVisible = false;
            this.grdstudentsms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstudentsms.Size = new System.Drawing.Size(1325, 475);
            this.grdstudentsms.TabIndex = 18;
            this.grdstudentsms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstudentsms_CellContentClick);
            this.grdstudentsms.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdstudentsms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
            // 
            // clmstudentcheck
            // 
            this.clmstudentcheck.HeaderText = "  ";
            this.clmstudentcheck.Name = "clmstudentcheck";
            this.clmstudentcheck.ReadOnly = true;
            this.clmstudentcheck.Width = 25;
            // 
            // clmsno
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 60;
            // 
            // clmadmission
            // 
            this.clmadmission.HeaderText = "Group";
            this.clmadmission.Name = "clmadmission";
            this.clmadmission.ReadOnly = true;
            this.clmadmission.Width = 200;
            // 
            // clmsmid
            // 
            this.clmsmid.HeaderText = "id";
            this.clmsmid.Name = "clmsmid";
            this.clmsmid.ReadOnly = true;
            this.clmsmid.Visible = false;
            // 
            // admission
            // 
            this.admission.HeaderText = "Admission";
            this.admission.Name = "admission";
            this.admission.ReadOnly = true;
            this.admission.Visible = false;
            this.admission.Width = 200;
            // 
            // clmSchemeName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmSchemeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSchemeName.HeaderText = "Student Name";
            this.clmSchemeName.Name = "clmSchemeName";
            this.clmSchemeName.ReadOnly = true;
            this.clmSchemeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSchemeName.Visible = false;
            this.clmSchemeName.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Class & Section";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 120;
            // 
            // C
            // 
            this.C.HeaderText = "Mobile No.";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Visible = false;
            this.C.Width = 200;
            // 
            // lblDNoRecordFound
            // 
            this.lblDNoRecordFound.AutoSize = true;
            this.lblDNoRecordFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNoRecordFound.Location = new System.Drawing.Point(619, 299);
            this.lblDNoRecordFound.Name = "lblDNoRecordFound";
            this.lblDNoRecordFound.Size = new System.Drawing.Size(121, 17);
            this.lblDNoRecordFound.TabIndex = 958721;
            this.lblDNoRecordFound.Text = "No Records Found";
            this.lblDNoRecordFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tspMenu
            // 
            this.tspMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspFormHeader});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(1360, 25);
            this.tspMenu.TabIndex = 958722;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tspFormHeader
            // 
            this.tspFormHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspFormHeader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspFormHeader.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tspFormHeader.Name = "tspFormHeader";
            this.tspFormHeader.Size = new System.Drawing.Size(125, 22);
            this.tspFormHeader.Text = "Send SMS - General";
            // 
            // lblDcolumnIndex
            // 
            this.lblDcolumnIndex.AutoSize = true;
            this.lblDcolumnIndex.Location = new System.Drawing.Point(918, 0);
            this.lblDcolumnIndex.Name = "lblDcolumnIndex";
            this.lblDcolumnIndex.Size = new System.Drawing.Size(15, 17);
            this.lblDcolumnIndex.TabIndex = 958723;
            this.lblDcolumnIndex.Text = "0";
            this.lblDcolumnIndex.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbtemplate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbsender);
            this.groupBox1.Controls.Add(this.btnclassview);
            this.groupBox1.Location = new System.Drawing.Point(25, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 51);
            this.groupBox1.TabIndex = 958788;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // cmbtemplate
            // 
            this.cmbtemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtemplate.Enabled = false;
            this.cmbtemplate.FormattingEnabled = true;
            this.cmbtemplate.Location = new System.Drawing.Point(271, 18);
            this.cmbtemplate.Name = "cmbtemplate";
            this.cmbtemplate.Size = new System.Drawing.Size(171, 25);
            this.cmbtemplate.TabIndex = 2;
            this.cmbtemplate.SelectedIndexChanged += new System.EventHandler(this.cmbtemplate_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 958807;
            this.label7.Text = "Template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 958802;
            this.label3.Text = "Sender";
            // 
            // cmbsender
            // 
            this.cmbsender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsender.FormattingEnabled = true;
            this.cmbsender.Location = new System.Drawing.Point(58, 18);
            this.cmbsender.Name = "cmbsender";
            this.cmbsender.Size = new System.Drawing.Size(131, 25);
            this.cmbsender.TabIndex = 3;
            this.cmbsender.SelectedIndexChanged += new System.EventHandler(this.cmbsender_SelectedIndexChanged);
            // 
            // lblsenderid
            // 
            this.lblsenderid.AutoSize = true;
            this.lblsenderid.Location = new System.Drawing.Point(1333, 8);
            this.lblsenderid.Name = "lblsenderid";
            this.lblsenderid.Size = new System.Drawing.Size(15, 17);
            this.lblsenderid.TabIndex = 958806;
            this.lblsenderid.Text = "0";
            this.lblsenderid.Visible = false;
            // 
            // lblsmscount
            // 
            this.lblsmscount.AutoSize = true;
            this.lblsmscount.Location = new System.Drawing.Point(670, 98);
            this.lblsmscount.Name = "lblsmscount";
            this.lblsmscount.Size = new System.Drawing.Size(15, 17);
            this.lblsmscount.TabIndex = 958805;
            this.lblsmscount.Text = "0";
            this.lblsmscount.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 958804;
            this.label4.Text = "SMS Count:";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1265, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 958803;
            this.label5.Text = "Sender ID:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(913, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 958793;
            this.label6.Text = "SMS Content";
            // 
            // txtsmscontent
            // 
            this.txtsmscontent.Location = new System.Drawing.Point(996, 31);
            this.txtsmscontent.Multiline = true;
            this.txtsmscontent.Name = "txtsmscontent";
            this.txtsmscontent.ReadOnly = true;
            this.txtsmscontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsmscontent.Size = new System.Drawing.Size(241, 84);
            this.txtsmscontent.TabIndex = 958794;
            // 
            // grdstaffsms
            // 
            this.grdstaffsms.AllowUserToAddRows = false;
            this.grdstaffsms.AllowUserToDeleteRows = false;
            this.grdstaffsms.AllowUserToResizeRows = false;
            this.grdstaffsms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdstaffsms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstaffsms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grdstaffsms.ColumnHeadersHeight = 30;
            this.grdstaffsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdstaffsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmstaffcheck,
            this.clmstaffno,
            this.clmstaffname,
            this.clmstatus,
            this.clmid,
            this.clmstaffid});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdstaffsms.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdstaffsms.EnableHeadersVisualStyles = false;
            this.grdstaffsms.GridColor = System.Drawing.Color.White;
            this.grdstaffsms.Location = new System.Drawing.Point(17, 121);
            this.grdstaffsms.Name = "grdstaffsms";
            this.grdstaffsms.ReadOnly = true;
            this.grdstaffsms.RowHeadersVisible = false;
            this.grdstaffsms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstaffsms.Size = new System.Drawing.Size(1325, 474);
            this.grdstaffsms.TabIndex = 958796;
            this.grdstaffsms.Visible = false;
            this.grdstaffsms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdstaffsms_CellContentClick);
            // 
            // clmstaffcheck
            // 
            this.clmstaffcheck.HeaderText = "           ";
            this.clmstaffcheck.Name = "clmstaffcheck";
            this.clmstaffcheck.ReadOnly = true;
            this.clmstaffcheck.Width = 25;
            // 
            // clmstaffno
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmstaffno.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmstaffno.HeaderText = "S.No.";
            this.clmstaffno.Name = "clmstaffno";
            this.clmstaffno.ReadOnly = true;
            this.clmstaffno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmstaffno.Width = 60;
            // 
            // clmstaffname
            // 
            this.clmstaffname.HeaderText = "Staff Name";
            this.clmstaffname.Name = "clmstaffname";
            this.clmstaffname.ReadOnly = true;
            this.clmstaffname.Width = 200;
            // 
            // clmstatus
            // 
            this.clmstatus.HeaderText = "Status";
            this.clmstatus.Name = "clmstatus";
            this.clmstatus.ReadOnly = true;
            // 
            // clmid
            // 
            this.clmid.HeaderText = "id";
            this.clmid.Name = "clmid";
            this.clmid.ReadOnly = true;
            this.clmid.Visible = false;
            // 
            // clmstaffid
            // 
            this.clmstaffid.HeaderText = "id1";
            this.clmstaffid.Name = "clmstaffid";
            this.clmstaffid.ReadOnly = true;
            this.clmstaffid.Visible = false;
            // 
            // chkSelectStaff
            // 
            this.chkSelectStaff.AutoSize = true;
            this.chkSelectStaff.Location = new System.Drawing.Point(34, 185);
            this.chkSelectStaff.Name = "chkSelectStaff";
            this.chkSelectStaff.Size = new System.Drawing.Size(15, 14);
            this.chkSelectStaff.TabIndex = 958797;
            this.chkSelectStaff.UseVisualStyleBackColor = true;
            this.chkSelectStaff.Visible = false;
            this.chkSelectStaff.CheckedChanged += new System.EventHandler(this.chkSelectStaff_CheckedChanged);
            // 
            // chkSelectstudent
            // 
            this.chkSelectstudent.AutoSize = true;
            this.chkSelectstudent.Location = new System.Drawing.Point(24, 132);
            this.chkSelectstudent.Name = "chkSelectstudent";
            this.chkSelectstudent.Size = new System.Drawing.Size(15, 14);
            this.chkSelectstudent.TabIndex = 958798;
            this.chkSelectstudent.UseVisualStyleBackColor = true;
            this.chkSelectstudent.CheckedChanged += new System.EventHandler(this.chkSelectstudent_CheckedChanged);
            // 
            // epMR_SMSStudent
            // 
            this.epMR_SMSStudent.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnsendsms);
            this.groupBox4.Controls.Add(this.txtsenderno);
            this.groupBox4.Location = new System.Drawing.Point(583, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 51);
            this.groupBox4.TabIndex = 958813;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test SMS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 958794;
            this.label8.Text = "Send To :";
            // 
            // txtsenderno
            // 
            this.txtsenderno.Location = new System.Drawing.Point(67, 19);
            this.txtsenderno.MaxLength = 110;
            this.txtsenderno.Multiline = true;
            this.txtsenderno.Name = "txtsenderno";
            this.txtsenderno.Size = new System.Drawing.Size(159, 25);
            this.txtsenderno.TabIndex = 958795;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(669, 8);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 17);
            this.lblid.TabIndex = 958814;
            this.lblid.Text = "0";
            this.lblid.Visible = false;
            // 
            // btnsmssend
            // 
            this.btnsmssend.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btnsmssend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsmssend.Location = new System.Drawing.Point(1242, 61);
            this.btnsmssend.Name = "btnsmssend";
            this.btnsmssend.Size = new System.Drawing.Size(97, 30);
            this.btnsmssend.TabIndex = 958795;
            this.btnsmssend.Text = "Send SMS";
            this.btnsmssend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsmssend.UseVisualStyleBackColor = true;
            this.btnsmssend.Click += new System.EventHandler(this.btnsmssend_Click);
            // 
            // btnsendsms
            // 
            this.btnsendsms.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btnsendsms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsendsms.Location = new System.Drawing.Point(229, 16);
            this.btnsendsms.Name = "btnsendsms";
            this.btnsendsms.Size = new System.Drawing.Size(87, 30);
            this.btnsendsms.TabIndex = 958791;
            this.btnsendsms.Text = "Test SMS";
            this.btnsendsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsendsms.UseVisualStyleBackColor = true;
            this.btnsendsms.Click += new System.EventHandler(this.btnsendsms_Click);
            // 
            // btnclassview
            // 
            this.btnclassview.Image = global::SMSApplication.Properties.Resources.view2;
            this.btnclassview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclassview.Location = new System.Drawing.Point(462, 15);
            this.btnclassview.Name = "btnclassview";
            this.btnclassview.Size = new System.Drawing.Size(75, 30);
            this.btnclassview.TabIndex = 4;
            this.btnclassview.Text = "View";
            this.btnclassview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclassview.UseVisualStyleBackColor = true;
            this.btnclassview.Click += new System.EventHandler(this.btnclassview_Click);
            // 
            // picLoader
            // 
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoader.ErrorImage = null;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = null;
            this.picLoader.Location = new System.Drawing.Point(17, 28);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1325, 567);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958787;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // TRN_SMS_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnsmssend);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chkSelectstudent);
            this.Controls.Add(this.lblsmscount);
            this.Controls.Add(this.lblsenderid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsmscontent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDcolumnIndex);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.lblDNoRecordFound);
            this.Controls.Add(this.grdstudentsms);
            this.Controls.Add(this.grdstaffsms);
            this.Controls.Add(this.chkSelectStaff);
            this.Controls.Add(this.picLoader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TRN_SMS_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_SchemeList";
            this.Load += new System.EventHandler(this.TRN_SMS_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdstudentsms)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffsms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdstudentsms;
        private System.Windows.Forms.Label lblDNoRecordFound;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel tspFormHeader;
        private System.Windows.Forms.Label lblDcolumnIndex;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsmscontent;
        private System.Windows.Forms.Button btnclassview;
        private System.Windows.Forms.Button btnsmssend;
        public System.Windows.Forms.DataGridView grdstaffsms;
        private System.Windows.Forms.CheckBox chkSelectStaff;
        private System.Windows.Forms.CheckBox chkSelectstudent;
        private System.Windows.Forms.ErrorProvider epMR_SMSStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbsender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblsmscount;
        private System.Windows.Forms.Label lblsenderid;
        private System.Windows.Forms.ComboBox cmbtemplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmstaffcheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstaffno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstaffid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsendsms;
        private System.Windows.Forms.TextBox txtsenderno;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmstudentcheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmadmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn admission;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSchemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.Label lblid;
    }
}