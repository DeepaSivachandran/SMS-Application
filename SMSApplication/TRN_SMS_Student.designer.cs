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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdsmsstudent)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdsmsstudent
            // 
            this.grdsmsstudent.AllowUserToAddRows = false;
            this.grdsmsstudent.AllowUserToDeleteRows = false;
            this.grdsmsstudent.AllowUserToResizeRows = false;
            this.grdsmsstudent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdsmsstudent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdsmsstudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdsmsstudent.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdsmsstudent.EnableHeadersVisualStyles = false;
            this.grdsmsstudent.GridColor = System.Drawing.Color.White;
            this.grdsmsstudent.Location = new System.Drawing.Point(17, 104);
            this.grdsmsstudent.Name = "grdsmsstudent";
            this.grdsmsstudent.ReadOnly = true;
            this.grdsmsstudent.RowHeadersVisible = false;
            this.grdsmsstudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdsmsstudent.Size = new System.Drawing.Size(1325, 483);
            this.grdsmsstudent.TabIndex = 18;
            this.grdsmsstudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdsmsstudent_CellContentClick);
            this.grdsmsstudent.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdsmsstudent_CellFormatting);
            this.grdsmsstudent.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdsmsstudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
            // 
            // clmsno
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmSchemeName.DefaultCellStyle = dataGridViewCellStyle11;
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
            this.groupBox1.Location = new System.Drawing.Point(31, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 58);
            this.groupBox1.TabIndex = 958788;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbout
            // 
            this.rbout.AutoSize = true;
            this.rbout.Location = new System.Drawing.Point(202, 23);
            this.rbout.Name = "rbout";
            this.rbout.Size = new System.Drawing.Size(47, 21);
            this.rbout.TabIndex = 958803;
            this.rbout.Text = "Out";
            this.rbout.UseVisualStyleBackColor = true;
            this.rbout.CheckedChanged += new System.EventHandler(this.rbout_CheckedChanged);
            // 
            // rbin
            // 
            this.rbin.AutoSize = true;
            this.rbin.Checked = true;
            this.rbin.Location = new System.Drawing.Point(147, 23);
            this.rbin.Name = "rbin";
            this.rbin.Size = new System.Drawing.Size(36, 21);
            this.rbin.TabIndex = 958802;
            this.rbin.TabStop = true;
            this.rbin.Text = "In";
            this.rbin.UseVisualStyleBackColor = true;
            this.rbin.CheckedChanged += new System.EventHandler(this.rbin_CheckedChanged);
            // 
            // chkouttime
            // 
            this.chkouttime.AutoSize = true;
            this.chkouttime.Location = new System.Drawing.Point(148, -10);
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
            this.btn_VIEW.Location = new System.Drawing.Point(515, 17);
            this.btn_VIEW.Name = "btn_VIEW";
            this.btn_VIEW.Size = new System.Drawing.Size(75, 30);
            this.btn_VIEW.TabIndex = 3;
            this.btn_VIEW.Text = "View";
            this.btn_VIEW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_VIEW.UseVisualStyleBackColor = true;
            this.btn_VIEW.Click += new System.EventHandler(this.btn_VIEW_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(48, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 17);
            this.lblDate.TabIndex = 958797;
            this.lblDate.Text = "15/05/2023";
            // 
            // msktxtfrom
            // 
            this.msktxtfrom.Location = new System.Drawing.Point(347, 21);
            this.msktxtfrom.Mask = "00:00";
            this.msktxtfrom.Name = "msktxtfrom";
            this.msktxtfrom.Size = new System.Drawing.Size(36, 25);
            this.msktxtfrom.TabIndex = 1;
            this.msktxtfrom.ValidatingType = typeof(System.DateTime);
            this.msktxtfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtfrom_KeyDown);
            // 
            // msktxtto
            // 
            this.msktxtto.Location = new System.Drawing.Point(456, 21);
            this.msktxtto.Mask = "00:00";
            this.msktxtto.Name = "msktxtto";
            this.msktxtto.Size = new System.Drawing.Size(36, 25);
            this.msktxtto.TabIndex = 2;
            this.msktxtto.ValidatingType = typeof(System.DateTime);
            this.msktxtto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtto_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 958794;
            this.label2.Text = "To Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 2;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(6, 17);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(93, 25);
            this.comboBox3.TabIndex = 958790;
            this.comboBox3.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Location = new System.Drawing.Point(1310, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(27, 58);
            this.groupBox2.TabIndex = 958792;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.epMR_SMSStudent.SetIconAlignment(this.label7, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label7.Location = new System.Drawing.Point(84, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 17);
            this.label7.TabIndex = 958801;
            this.label7.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMS Count:";
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
            this.btnsmssend.Location = new System.Drawing.Point(1175, 52);
            this.btnsmssend.Name = "btnsmssend";
            this.btnsmssend.Size = new System.Drawing.Size(97, 30);
            this.btnsmssend.TabIndex = 958793;
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
            this.lblouttime.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblouttime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblouttime.ForeColor = System.Drawing.Color.White;
            this.lblouttime.Location = new System.Drawing.Point(381, 46);
            this.lblouttime.Name = "lblouttime";
            this.lblouttime.Size = new System.Drawing.Size(15, 17);
            this.lblouttime.TabIndex = 958808;
            this.lblouttime.Text = "0";
            this.lblouttime.Visible = false;
            // 
            // lbldouttime
            // 
            this.lbldouttime.AutoSize = true;
            this.lbldouttime.Location = new System.Drawing.Point(253, 46);
            this.lbldouttime.Name = "lbldouttime";
            this.lbldouttime.Size = new System.Drawing.Size(122, 17);
            this.lbldouttime.TabIndex = 958807;
            this.lbldouttime.Text = "Out Student Count :";
            this.lbldouttime.Visible = false;
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.BackColor = System.Drawing.Color.Red;
            this.lblAbsent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbsent.ForeColor = System.Drawing.Color.White;
            this.lblAbsent.Location = new System.Drawing.Point(381, 46);
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
            this.lblpresent.Location = new System.Drawing.Point(140, 45);
            this.lblpresent.Name = "lblpresent";
            this.lblpresent.Size = new System.Drawing.Size(15, 17);
            this.lblpresent.TabIndex = 958805;
            this.lblpresent.Text = "0";
            // 
            // lbldabsent
            // 
            this.lbldabsent.AutoSize = true;
            this.lbldabsent.Location = new System.Drawing.Point(241, 46);
            this.lbldabsent.Name = "lbldabsent";
            this.lbldabsent.Size = new System.Drawing.Size(134, 17);
            this.lbldabsent.TabIndex = 958803;
            this.lbldabsent.Text = "No. of Absent Count :";
            // 
            // lbldpresent
            // 
            this.lbldpresent.AutoSize = true;
            this.lbldpresent.Location = new System.Drawing.Point(7, 45);
            this.lbldpresent.Name = "lbldpresent";
            this.lbldpresent.Size = new System.Drawing.Size(137, 17);
            this.lbldpresent.TabIndex = 958804;
            this.lbldpresent.Text = "No. of Present Count :";
            // 
            // lbltotstudent
            // 
            this.lbltotstudent.AutoSize = true;
            this.lbltotstudent.BackColor = System.Drawing.Color.LimeGreen;
            this.lbltotstudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotstudent.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltotstudent.Location = new System.Drawing.Point(247, 16);
            this.lbltotstudent.Name = "lbltotstudent";
            this.lbltotstudent.Size = new System.Drawing.Size(15, 17);
            this.lbltotstudent.TabIndex = 958810;
            this.lbltotstudent.Text = "0";
            // 
            // lbldstudent
            // 
            this.lbldstudent.AutoSize = true;
            this.lbldstudent.Location = new System.Drawing.Point(113, 16);
            this.lbldstudent.Name = "lbldstudent";
            this.lbldstudent.Size = new System.Drawing.Size(139, 17);
            this.lbldstudent.TabIndex = 958809;
            this.lbldstudent.Text = "Total Students Count : ";
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbltotstudent);
            this.groupBox3.Controls.Add(this.lbldouttime);
            this.groupBox3.Controls.Add(this.lblAbsent);
            this.groupBox3.Controls.Add(this.lblpresent);
            this.groupBox3.Controls.Add(this.lbldstudent);
            this.groupBox3.Controls.Add(this.lbldpresent);
            this.groupBox3.Controls.Add(this.lbldabsent);
            this.groupBox3.Controls.Add(this.lblouttime);
            this.groupBox3.Location = new System.Drawing.Point(652, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 70);
            this.groupBox3.TabIndex = 958811;
            this.groupBox3.TabStop = false;
            // 
            // TRN_SMS_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnsmssend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label7;
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
    }
}