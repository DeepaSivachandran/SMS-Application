namespace SMSApplication
{
    partial class TRN_SMS_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRN_SMS_Student));
            this.grdsmsstudent = new System.Windows.Forms.DataGridView();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSchemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tspFormHeader = new System.Windows.Forms.ToolStripLabel();
            this.lblDcolumnIndex = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbout = new System.Windows.Forms.RadioButton();
            this.rbin = new System.Windows.Forms.RadioButton();
            this.chkouttime = new System.Windows.Forms.CheckBox();
            this.btn_VIEW = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.msktxtfrom = new System.Windows.Forms.MaskedTextBox();
            this.msktxtto = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.btnsmssend = new System.Windows.Forms.Button();
            this.epMR_SMSStudent = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblouttime = new System.Windows.Forms.Label();
            this.lbldouttime = new System.Windows.Forms.Label();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.lblpresent = new System.Windows.Forms.Label();
            this.lbldabsent = new System.Windows.Forms.Label();
            this.lbldpresent = new System.Windows.Forms.Label();
            this.lbltotstudent = new System.Windows.Forms.Label();
            this.lbldstudent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsenderno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsendsms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdsmsstudent)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdsmsstudent
            // 
            this.grdsmsstudent.AllowUserToAddRows = false;
            this.grdsmsstudent.AllowUserToDeleteRows = false;
            this.grdsmsstudent.AllowUserToResizeRows = false;
            this.grdsmsstudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdsmsstudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdsmsstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdsmsstudent.ColumnHeadersHeight = 30;
            this.grdsmsstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdsmsstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.Column1,
            this.clmSchemeName,
            this.Column2,
            this.C,
            this.clmid,
            this.clmpunch});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdsmsstudent.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdsmsstudent.EnableHeadersVisualStyles = false;
            this.grdsmsstudent.GridColor = System.Drawing.Color.White;
            this.grdsmsstudent.Location = new System.Drawing.Point(17, 97);
            this.grdsmsstudent.Name = "grdsmsstudent";
            this.grdsmsstudent.ReadOnly = true;
            this.grdsmsstudent.RowHeadersVisible = false;
            this.grdsmsstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdsmsstudent.Size = new System.Drawing.Size(1321, 490);
            this.grdsmsstudent.TabIndex = 18;
            this.grdsmsstudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdsmsstudent_CellFormatting);
            this.grdsmsstudent.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdsmsstudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
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
            // Column1
            // 
            this.Column1.HeaderText = "Admission No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // clmSchemeName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmSchemeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSchemeName.HeaderText = "Student Name";
            this.clmSchemeName.Name = "clmSchemeName";
            this.clmSchemeName.ReadOnly = true;
            this.clmSchemeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSchemeName.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Class & Section";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // C
            // 
            this.C.HeaderText = "Mobile No.";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 200;
            // 
            // clmid
            // 
            this.clmid.HeaderText = "Id";
            this.clmid.Name = "clmid";
            this.clmid.ReadOnly = true;
            this.clmid.Visible = false;
            // 
            // clmpunch
            // 
            this.clmpunch.HeaderText = "Punch Time";
            this.clmpunch.Name = "clmpunch";
            this.clmpunch.ReadOnly = true;
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
            this.tspFormHeader.Size = new System.Drawing.Size(130, 22);
            this.tspFormHeader.Text = "Send SMS - Students";
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
            this.groupBox1.Controls.Add(this.rbout);
            this.groupBox1.Controls.Add(this.rbin);
            this.groupBox1.Controls.Add(this.chkouttime);
            this.groupBox1.Controls.Add(this.btn_VIEW);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.msktxtfrom);
            this.groupBox1.Controls.Add(this.msktxtto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(31, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 58);
            this.groupBox1.TabIndex = 958788;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // rbout
            // 
            this.rbout.AutoSize = true;
            this.rbout.Location = new System.Drawing.Point(172, 23);
            this.rbout.Name = "rbout";
            this.rbout.Size = new System.Drawing.Size(47, 21);
            this.rbout.TabIndex = 2;
            this.rbout.Text = "Out";
            this.rbout.UseVisualStyleBackColor = true;
            this.rbout.CheckedChanged += new System.EventHandler(this.rbout_CheckedChanged);
            // 
            // rbin
            // 
            this.rbin.AutoSize = true;
            this.rbin.Checked = true;
            this.rbin.Location = new System.Drawing.Point(131, 23);
            this.rbin.Name = "rbin";
            this.rbin.Size = new System.Drawing.Size(36, 21);
            this.rbin.TabIndex = 1;
            this.rbin.TabStop = true;
            this.rbin.Text = "In";
            this.rbin.UseVisualStyleBackColor = true;
            this.rbin.CheckedChanged += new System.EventHandler(this.rbin_CheckedChanged);
            // 
            // chkouttime
            // 
            this.chkouttime.AutoSize = true;
            this.chkouttime.Location = new System.Drawing.Point(148, -18);
            this.chkouttime.Name = "chkouttime";
            this.chkouttime.Size = new System.Drawing.Size(73, 21);
            this.chkouttime.TabIndex = 958801;
            this.chkouttime.Text = "Outtime";
            this.chkouttime.UseVisualStyleBackColor = true;
            this.chkouttime.Visible = false;
            this.chkouttime.CheckedChanged += new System.EventHandler(this.chkouttime_CheckedChanged);
            // 
            // btn_VIEW
            // 
            this.btn_VIEW.Image = global::SMSApplication.Properties.Resources.view1;
            this.btn_VIEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VIEW.Location = new System.Drawing.Point(461, 18);
            this.btn_VIEW.Name = "btn_VIEW";
            this.btn_VIEW.Size = new System.Drawing.Size(75, 30);
            this.btn_VIEW.TabIndex = 5;
            this.btn_VIEW.Text = "View";
            this.btn_VIEW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VIEW.UseVisualStyleBackColor = true;
            this.btn_VIEW.Click += new System.EventHandler(this.btn_VIEW_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(45, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 17);
            this.lblDate.TabIndex = 958797;
            this.lblDate.Text = "15/05/2023";
            // 
            // msktxtfrom
            // 
            this.msktxtfrom.Location = new System.Drawing.Point(302, 21);
            this.msktxtfrom.Mask = "00:00";
            this.msktxtfrom.Name = "msktxtfrom";
            this.msktxtfrom.Size = new System.Drawing.Size(36, 25);
            this.msktxtfrom.TabIndex = 3;
            this.msktxtfrom.ValidatingType = typeof(System.DateTime);
            this.msktxtfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtfrom_KeyDown);
            // 
            // msktxtto
            // 
            this.msktxtto.Location = new System.Drawing.Point(413, 21);
            this.msktxtto.Mask = "00:00";
            this.msktxtto.Name = "msktxtto";
            this.msktxtto.Size = new System.Drawing.Size(36, 25);
            this.msktxtto.TabIndex = 4;
            this.msktxtto.ValidatingType = typeof(System.DateTime);
            this.msktxtto.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msktxtto_MaskInputRejected);
            this.msktxtto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 958794;
            this.label2.Text = "To Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 100000;
            this.label1.Text = "From Time :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 958793;
            this.label6.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1126, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 958789;
            this.label3.Text = "Attendance Type";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1057, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sender ID:";
            this.label5.Visible = false;
            // 
            // picLoader
            // 
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoader.ErrorImage = null;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = null;
            this.picLoader.Location = new System.Drawing.Point(17, 28);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1325, 559);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958787;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // btnsmssend
            // 
            this.btnsmssend.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btnsmssend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsmssend.Location = new System.Drawing.Point(319, 20);
            this.btnsmssend.Name = "btnsmssend";
            this.btnsmssend.Size = new System.Drawing.Size(97, 30);
            this.btnsmssend.TabIndex = 8;
            this.btnsmssend.Text = "Send SMS";
            this.btnsmssend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsmssend.UseVisualStyleBackColor = true;
            this.btnsmssend.Click += new System.EventHandler(this.btnsmssend_Click);
            // 
            // epMR_SMSStudent
            // 
            this.epMR_SMSStudent.ContainerControl = this;
            // 
            // lblouttime
            // 
            this.lblouttime.AutoSize = true;
            this.lblouttime.BackColor = System.Drawing.Color.Red;
            this.lblouttime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblouttime.ForeColor = System.Drawing.Color.White;
            this.lblouttime.Location = new System.Drawing.Point(270, 25);
            this.lblouttime.Name = "lblouttime";
            this.lblouttime.Size = new System.Drawing.Size(15, 17);
            this.lblouttime.TabIndex = 958808;
            this.lblouttime.Text = "0";
            this.lblouttime.Visible = false;
            // 
            // lbldouttime
            // 
            this.lbldouttime.AutoSize = true;
            this.lbldouttime.Location = new System.Drawing.Point(201, 25);
            this.lbldouttime.Name = "lbldouttime";
            this.lbldouttime.Size = new System.Drawing.Size(64, 17);
            this.lbldouttime.TabIndex = 958807;
            this.lbldouttime.Text = "Out Gone";
            this.lbldouttime.Visible = false;
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.BackColor = System.Drawing.Color.Red;
            this.lblAbsent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsent.ForeColor = System.Drawing.Color.White;
            this.lblAbsent.Location = new System.Drawing.Point(270, 25);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(15, 17);
            this.lblAbsent.TabIndex = 958806;
            this.lblAbsent.Text = "0";
            // 
            // lblpresent
            // 
            this.lblpresent.AutoSize = true;
            this.lblpresent.BackColor = System.Drawing.Color.LimeGreen;
            this.lblpresent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpresent.Location = new System.Drawing.Point(155, 25);
            this.lblpresent.Name = "lblpresent";
            this.lblpresent.Size = new System.Drawing.Size(15, 17);
            this.lblpresent.TabIndex = 958805;
            this.lblpresent.Text = "0";
            // 
            // lbldabsent
            // 
            this.lbldabsent.AutoSize = true;
            this.lbldabsent.Location = new System.Drawing.Point(217, 25);
            this.lbldabsent.Name = "lbldabsent";
            this.lbldabsent.Size = new System.Drawing.Size(48, 17);
            this.lbldabsent.TabIndex = 958803;
            this.lbldabsent.Text = "Absent";
            // 
            // lbldpresent
            // 
            this.lbldpresent.AutoSize = true;
            this.lbldpresent.Location = new System.Drawing.Point(98, 25);
            this.lbldpresent.Name = "lbldpresent";
            this.lbldpresent.Size = new System.Drawing.Size(51, 17);
            this.lbldpresent.TabIndex = 958804;
            this.lbldpresent.Text = "Present";
            // 
            // lbltotstudent
            // 
            this.lbltotstudent.AutoSize = true;
            this.lbltotstudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbltotstudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotstudent.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltotstudent.Location = new System.Drawing.Point(45, 25);
            this.lbltotstudent.Name = "lbltotstudent";
            this.lbltotstudent.Size = new System.Drawing.Size(15, 17);
            this.lbltotstudent.TabIndex = 958810;
            this.lbltotstudent.Text = "0";
            // 
            // lbldstudent
            // 
            this.lbldstudent.AutoSize = true;
            this.lbldstudent.Location = new System.Drawing.Point(3, 25);
            this.lbldstudent.Name = "lbldstudent";
            this.lbldstudent.Size = new System.Drawing.Size(36, 17);
            this.lbldstudent.TabIndex = 958809;
            this.lbldstudent.Text = "Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbltotstudent);
            this.groupBox3.Controls.Add(this.btnsmssend);
            this.groupBox3.Controls.Add(this.lbldouttime);
            this.groupBox3.Controls.Add(this.lblAbsent);
            this.groupBox3.Controls.Add(this.lblpresent);
            this.groupBox3.Controls.Add(this.lbldstudent);
            this.groupBox3.Controls.Add(this.lbldpresent);
            this.groupBox3.Controls.Add(this.lbldabsent);
            this.groupBox3.Controls.Add(this.lblouttime);
            this.groupBox3.Location = new System.Drawing.Point(914, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 58);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "No. of Student";
            // 
            // txtsenderno
            // 
            this.txtsenderno.Location = new System.Drawing.Point(67, 21);
            this.txtsenderno.MaxLength = 110;
            this.txtsenderno.Multiline = true;
            this.txtsenderno.Name = "txtsenderno";
            this.txtsenderno.Size = new System.Drawing.Size(159, 25);
            this.txtsenderno.TabIndex = 6;
            this.txtsenderno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsenderno_KeyDown);
            this.txtsenderno.Leave += new System.EventHandler(this.txtsenderno_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 958794;
            this.label8.Text = "Send To :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.btnsendsms);
            this.groupBox4.Controls.Add(this.txtsenderno);
            this.groupBox4.Location = new System.Drawing.Point(580, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 58);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Test SMS";
            // 
            // btnsendsms
            // 
            this.btnsendsms.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btnsendsms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsendsms.Location = new System.Drawing.Point(229, 18);
            this.btnsendsms.Name = "btnsendsms";
            this.btnsendsms.Size = new System.Drawing.Size(87, 30);
            this.btnsendsms.TabIndex = 7;
            this.btnsendsms.Text = "Test SMS";
            this.btnsendsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsendsms.UseVisualStyleBackColor = true;
            this.btnsendsms.Click += new System.EventHandler(this.btnsendsms_Click_1);
            // 
            // TRN_SMS_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDcolumnIndex);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.lblDNoRecordFound);
            this.Controls.Add(this.grdsmsstudent);
            this.Controls.Add(this.picLoader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TRN_SMS_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_SchemeList";
            this.Load += new System.EventHandler(this.TRN_SMS_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdsmsstudent)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdsmsstudent;
        private System.Windows.Forms.Label lblDNoRecordFound;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel tspFormHeader;
        private System.Windows.Forms.Label lblDcolumnIndex;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox msktxtfrom;
        private System.Windows.Forms.MaskedTextBox msktxtto;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnsmssend;
        private System.Windows.Forms.Button btn_VIEW;
        private System.Windows.Forms.ErrorProvider epMR_SMSStudent;
        private System.Windows.Forms.CheckBox chkouttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSchemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpunch;
        private System.Windows.Forms.Label lblouttime;
        private System.Windows.Forms.Label lbldouttime;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label lblpresent;
        private System.Windows.Forms.Label lbldabsent;
        private System.Windows.Forms.Label lbldpresent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbltotstudent;
        private System.Windows.Forms.Label lbldstudent;
        private System.Windows.Forms.RadioButton rbout;
        private System.Windows.Forms.RadioButton rbin;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsendsms;
        private System.Windows.Forms.TextBox txtsenderno;
    }
}