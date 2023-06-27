namespace SMSApplication
{
    partial class TRN_SMS_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TRN_SMS_Staff));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdstaffsms = new System.Windows.Forms.DataGridView();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpunch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tspFormHeader = new System.Windows.Forms.ToolStripLabel();
            this.lblDcolumnIndex = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenderno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VIEW = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.msktxtfrom = new System.Windows.Forms.MaskedTextBox();
            this.msktxtto = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.epMR_SMSStaff = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnsendsms = new System.Windows.Forms.Button();
            this.txtcontantbox = new System.Windows.Forms.TextBox();
            this.btntestsms = new System.Windows.Forms.Button();
            this.grdstaffabsent = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpunchabsent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbldabsentnorecord = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbltotstudent = new System.Windows.Forms.Label();
            this.lblpresent = new System.Windows.Forms.Label();
            this.lbldstudent = new System.Windows.Forms.Label();
            this.lbldpresent = new System.Windows.Forms.Label();
            this.lbldabsent = new System.Windows.Forms.Label();
            this.lblouttime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffsms)).BeginInit();
            this.tspMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffabsent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdstaffsms
            // 
            this.grdstaffsms.AllowUserToAddRows = false;
            this.grdstaffsms.AllowUserToDeleteRows = false;
            this.grdstaffsms.AllowUserToResizeRows = false;
            this.grdstaffsms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdstaffsms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstaffsms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdstaffsms.ColumnHeadersHeight = 30;
            this.grdstaffsms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdstaffsms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.Column1,
            this.Column2,
            this.clmpunch});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdstaffsms.DefaultCellStyle = dataGridViewCellStyle9;
            this.grdstaffsms.EnableHeadersVisualStyles = false;
            this.grdstaffsms.GridColor = System.Drawing.Color.White;
            this.grdstaffsms.Location = new System.Drawing.Point(22, 115);
            this.grdstaffsms.Name = "grdstaffsms";
            this.grdstaffsms.ReadOnly = true;
            this.grdstaffsms.RowHeadersVisible = false;
            this.grdstaffsms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstaffsms.Size = new System.Drawing.Size(655, 486);
            this.grdstaffsms.TabIndex = 18;
            this.grdstaffsms.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdstaffsms_CellFormatting);
            this.grdstaffsms.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdstaffsms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
            // 
            // clmsno
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Staff Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // clmpunch
            // 
            this.clmpunch.HeaderText = "Designation";
            this.clmpunch.Name = "clmpunch";
            this.clmpunch.ReadOnly = true;
            this.clmpunch.Width = 150;
            // 
            // lblDNoRecordFound
            // 
            this.lblDNoRecordFound.AutoSize = true;
            this.lblDNoRecordFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNoRecordFound.Location = new System.Drawing.Point(287, 351);
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
            this.tspFormHeader.Size = new System.Drawing.Size(106, 22);
            this.tspFormHeader.Text = "Send SMS - Staff";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(1306, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(32, 58);
            this.groupBox2.TabIndex = 958792;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "SMS Count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 25);
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
            this.picLoader.Location = new System.Drawing.Point(16, 29);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1330, 576);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958787;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 958794;
            this.label2.Text = "Send To :";
            // 
            // txtsenderno
            // 
            this.txtsenderno.Location = new System.Drawing.Point(67, 21);
            this.txtsenderno.MaxLength = 110;
            this.txtsenderno.Multiline = true;
            this.txtsenderno.Name = "txtsenderno";
            this.txtsenderno.Size = new System.Drawing.Size(294, 25);
            this.txtsenderno.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_VIEW);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.msktxtfrom);
            this.groupBox1.Controls.Add(this.msktxtto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(22, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 58);
            this.groupBox1.TabIndex = 958796;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // btn_VIEW
            // 
            this.btn_VIEW.Image = global::SMSApplication.Properties.Resources.view1;
            this.btn_VIEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VIEW.Location = new System.Drawing.Point(417, 18);
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
            this.lblDate.Location = new System.Drawing.Point(44, 25);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(74, 17);
            this.lblDate.TabIndex = 958797;
            this.lblDate.Text = "15/05/2023";
            // 
            // msktxtfrom
            // 
            this.msktxtfrom.Location = new System.Drawing.Point(216, 21);
            this.msktxtfrom.Mask = "00:00";
            this.msktxtfrom.Name = "msktxtfrom";
            this.msktxtfrom.Size = new System.Drawing.Size(38, 25);
            this.msktxtfrom.TabIndex = 1;
            this.msktxtfrom.ValidatingType = typeof(System.DateTime);
            this.msktxtfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtfrom_KeyDown);
            // 
            // msktxtto
            // 
            this.msktxtto.Location = new System.Drawing.Point(356, 21);
            this.msktxtto.Mask = "00:00";
            this.msktxtto.Name = "msktxtto";
            this.msktxtto.Size = new System.Drawing.Size(38, 25);
            this.msktxtto.TabIndex = 2;
            this.msktxtto.ValidatingType = typeof(System.DateTime);
            this.msktxtto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msktxtto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 958794;
            this.label1.Text = "To Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 29999;
            this.label3.Text = "From Time :";
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
            // epMR_SMSStaff
            // 
            this.epMR_SMSStaff.ContainerControl = this;
            // 
            // btnsendsms
            // 
            this.btnsendsms.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btnsendsms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsendsms.Location = new System.Drawing.Point(370, 18);
            this.btnsendsms.Name = "btnsendsms";
            this.btnsendsms.Size = new System.Drawing.Size(87, 30);
            this.btnsendsms.TabIndex = 5;
            this.btnsendsms.Text = "Test SMS";
            this.btnsendsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsendsms.UseVisualStyleBackColor = true;
            this.btnsendsms.Click += new System.EventHandler(this.btnsendsms_Click);
            this.btnsendsms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsendsms_KeyDown);
            // 
            // txtcontantbox
            // 
            this.txtcontantbox.Location = new System.Drawing.Point(1214, 29);
            this.txtcontantbox.Multiline = true;
            this.txtcontantbox.Name = "txtcontantbox";
            this.txtcontantbox.Size = new System.Drawing.Size(10, 62);
            this.txtcontantbox.TabIndex = 958797;
            this.txtcontantbox.Visible = false;
            // 
            // btntestsms
            // 
            this.btntestsms.Image = global::SMSApplication.Properties.Resources.send_message__1_;
            this.btntestsms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntestsms.Location = new System.Drawing.Point(261, 19);
            this.btntestsms.Name = "btntestsms";
            this.btntestsms.Size = new System.Drawing.Size(87, 30);
            this.btntestsms.TabIndex = 6;
            this.btntestsms.Text = "Sent SMS";
            this.btntestsms.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntestsms.UseVisualStyleBackColor = true;
            this.btntestsms.Click += new System.EventHandler(this.btntestsms_Click);
            // 
            // grdstaffabsent
            // 
            this.grdstaffabsent.AllowUserToAddRows = false;
            this.grdstaffabsent.AllowUserToDeleteRows = false;
            this.grdstaffabsent.AllowUserToResizeRows = false;
            this.grdstaffabsent.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdstaffabsent.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdstaffabsent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdstaffabsent.ColumnHeadersHeight = 30;
            this.grdstaffabsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdstaffabsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.clmpunchabsent});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdstaffabsent.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdstaffabsent.EnableHeadersVisualStyles = false;
            this.grdstaffabsent.GridColor = System.Drawing.Color.White;
            this.grdstaffabsent.Location = new System.Drawing.Point(678, 115);
            this.grdstaffabsent.Name = "grdstaffabsent";
            this.grdstaffabsent.ReadOnly = true;
            this.grdstaffabsent.RowHeadersVisible = false;
            this.grdstaffabsent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdstaffabsent.Size = new System.Drawing.Size(660, 486);
            this.grdstaffabsent.TabIndex = 958798;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "S.No.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Staff Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Status";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // clmpunchabsent
            // 
            this.clmpunchabsent.HeaderText = "Designation";
            this.clmpunchabsent.Name = "clmpunchabsent";
            this.clmpunchabsent.ReadOnly = true;
            this.clmpunchabsent.Width = 150;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnsendsms);
            this.groupBox3.Controls.Add(this.txtsenderno);
            this.groupBox3.Location = new System.Drawing.Point(528, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(459, 58);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test SMS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 958800;
            this.label7.Text = "Present";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(678, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 958801;
            this.label8.Text = "Absent";
            // 
            // lbldabsentnorecord
            // 
            this.lbldabsentnorecord.AutoSize = true;
            this.lbldabsentnorecord.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldabsentnorecord.Location = new System.Drawing.Point(949, 351);
            this.lbldabsentnorecord.Name = "lbldabsentnorecord";
            this.lbldabsentnorecord.Size = new System.Drawing.Size(121, 17);
            this.lbldabsentnorecord.TabIndex = 958802;
            this.lbldabsentnorecord.Text = "No Records Found";
            this.lbldabsentnorecord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbldabsentnorecord.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbltotstudent);
            this.groupBox4.Controls.Add(this.btntestsms);
            this.groupBox4.Controls.Add(this.lblpresent);
            this.groupBox4.Controls.Add(this.lbldstudent);
            this.groupBox4.Controls.Add(this.lbldpresent);
            this.groupBox4.Controls.Add(this.lbldabsent);
            this.groupBox4.Controls.Add(this.lblouttime);
            this.groupBox4.Location = new System.Drawing.Point(989, 38);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 58);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "No. of Staff";
            // 
            // lbltotstudent
            // 
            this.lbltotstudent.AutoSize = true;
            this.lbltotstudent.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbltotstudent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotstudent.ForeColor = System.Drawing.SystemColors.Control;
            this.lbltotstudent.Location = new System.Drawing.Point(52, 26);
            this.lbltotstudent.Name = "lbltotstudent";
            this.lbltotstudent.Size = new System.Drawing.Size(15, 17);
            this.lbltotstudent.TabIndex = 958810;
            this.lbltotstudent.Text = "0";
            // 
            // lblpresent
            // 
            this.lblpresent.AutoSize = true;
            this.lblpresent.BackColor = System.Drawing.Color.LimeGreen;
            this.lblpresent.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpresent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpresent.Location = new System.Drawing.Point(141, 26);
            this.lblpresent.Name = "lblpresent";
            this.lblpresent.Size = new System.Drawing.Size(15, 17);
            this.lblpresent.TabIndex = 958805;
            this.lblpresent.Text = "0";
            // 
            // lbldstudent
            // 
            this.lbldstudent.AutoSize = true;
            this.lbldstudent.Location = new System.Drawing.Point(10, 26);
            this.lbldstudent.Name = "lbldstudent";
            this.lbldstudent.Size = new System.Drawing.Size(36, 17);
            this.lbldstudent.TabIndex = 958809;
            this.lbldstudent.Text = "Total";
            // 
            // lbldpresent
            // 
            this.lbldpresent.AutoSize = true;
            this.lbldpresent.Location = new System.Drawing.Point(85, 26);
            this.lbldpresent.Name = "lbldpresent";
            this.lbldpresent.Size = new System.Drawing.Size(51, 17);
            this.lbldpresent.TabIndex = 958804;
            this.lbldpresent.Text = "Present";
            // 
            // lbldabsent
            // 
            this.lbldabsent.AutoSize = true;
            this.lbldabsent.Location = new System.Drawing.Point(175, 26);
            this.lbldabsent.Name = "lbldabsent";
            this.lbldabsent.Size = new System.Drawing.Size(48, 17);
            this.lbldabsent.TabIndex = 958803;
            this.lbldabsent.Text = "Absent";
            // 
            // lblouttime
            // 
            this.lblouttime.AutoSize = true;
            this.lblouttime.BackColor = System.Drawing.Color.Red;
            this.lblouttime.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblouttime.ForeColor = System.Drawing.Color.White;
            this.lblouttime.Location = new System.Drawing.Point(230, 26);
            this.lblouttime.Name = "lblouttime";
            this.lblouttime.Size = new System.Drawing.Size(15, 17);
            this.lblouttime.TabIndex = 958808;
            this.lblouttime.Text = "0";
            // 
            // TRN_SMS_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbldabsentnorecord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grdstaffabsent);
            this.Controls.Add(this.txtcontantbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDcolumnIndex);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.lblDNoRecordFound);
            this.Controls.Add(this.grdstaffsms);
            this.Controls.Add(this.picLoader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TRN_SMS_Staff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_SchemeList";
            this.Load += new System.EventHandler(this.TRN_SMS_Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffsms)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_SMSStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdstaffabsent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdstaffsms;
        private System.Windows.Forms.Label lblDNoRecordFound;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel tspFormHeader;
        private System.Windows.Forms.Label lblDcolumnIndex;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenderno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox msktxtfrom;
        private System.Windows.Forms.MaskedTextBox msktxtto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_VIEW;
        private System.Windows.Forms.ErrorProvider epMR_SMSStaff;
        private System.Windows.Forms.TextBox txtcontantbox;
        private System.Windows.Forms.Button btnsendsms;
        private System.Windows.Forms.Button btntestsms;
        public System.Windows.Forms.DataGridView grdstaffabsent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbldabsentnorecord;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbltotstudent;
        private System.Windows.Forms.Label lblpresent;
        private System.Windows.Forms.Label lbldstudent;
        private System.Windows.Forms.Label lbldpresent;
        private System.Windows.Forms.Label lbldabsent;
        private System.Windows.Forms.Label lblouttime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpunch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpunchabsent;
    }
}