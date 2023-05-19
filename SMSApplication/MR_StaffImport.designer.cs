namespace SMSApplication
{
    partial class MR_StaffImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_StaffImport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbStudentImport = new System.Windows.Forms.GroupBox();
            this.lblDublicate = new System.Windows.Forms.Label();
            this.lblMismatch = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDMismatchRecord = new System.Windows.Forms.Label();
            this.lblDDublicateRecords = new System.Windows.Forms.Label();
            this.lblDTotalRecord = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grdStaffImport = new System.Windows.Forms.DataGridView();
            this.btnDownloadTemplate = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblDFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.lblNoRecordsFound = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstaffname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmmobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmblood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpincode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStudentImport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // gbStudentImport
            // 
            this.gbStudentImport.Controls.Add(this.lblDublicate);
            this.gbStudentImport.Controls.Add(this.lblMismatch);
            this.gbStudentImport.Controls.Add(this.lblTotal);
            this.gbStudentImport.Controls.Add(this.lblDMismatchRecord);
            this.gbStudentImport.Controls.Add(this.lblDDublicateRecords);
            this.gbStudentImport.Controls.Add(this.lblDTotalRecord);
            this.gbStudentImport.Controls.Add(this.btnImport);
            this.gbStudentImport.Controls.Add(this.btnClear);
            this.gbStudentImport.Controls.Add(this.btnClose);
            this.gbStudentImport.Controls.Add(this.grdStaffImport);
            this.gbStudentImport.Controls.Add(this.btnDownloadTemplate);
            this.gbStudentImport.Controls.Add(this.btnPreview);
            this.gbStudentImport.Controls.Add(this.btnBrowse);
            this.gbStudentImport.Controls.Add(this.lblDFileName);
            this.gbStudentImport.Controls.Add(this.txtFileName);
            this.gbStudentImport.Controls.Add(this.lblNoRecordsFound);
            this.gbStudentImport.Controls.Add(this.picLoader);
            this.gbStudentImport.Location = new System.Drawing.Point(7, 3);
            this.gbStudentImport.Name = "gbStudentImport";
            this.gbStudentImport.Size = new System.Drawing.Size(1325, 547);
            this.gbStudentImport.TabIndex = 0;
            this.gbStudentImport.TabStop = false;
            // 
            // lblDublicate
            // 
            this.lblDublicate.AutoSize = true;
            this.lblDublicate.BackColor = System.Drawing.Color.Yellow;
            this.lblDublicate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDublicate.Location = new System.Drawing.Point(292, 519);
            this.lblDublicate.Name = "lblDublicate";
            this.lblDublicate.Size = new System.Drawing.Size(15, 17);
            this.lblDublicate.TabIndex = 958771;
            this.lblDublicate.Text = "0";
            // 
            // lblMismatch
            // 
            this.lblMismatch.AutoSize = true;
            this.lblMismatch.BackColor = System.Drawing.Color.Red;
            this.lblMismatch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMismatch.Location = new System.Drawing.Point(467, 519);
            this.lblMismatch.Name = "lblMismatch";
            this.lblMismatch.Size = new System.Drawing.Size(15, 17);
            this.lblMismatch.TabIndex = 958770;
            this.lblMismatch.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(109, 519);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 17);
            this.lblTotal.TabIndex = 958769;
            this.lblTotal.Text = "0";
            // 
            // lblDMismatchRecord
            // 
            this.lblDMismatchRecord.AutoSize = true;
            this.lblDMismatchRecord.Location = new System.Drawing.Point(344, 519);
            this.lblDMismatchRecord.Name = "lblDMismatchRecord";
            this.lblDMismatchRecord.Size = new System.Drawing.Size(97, 17);
            this.lblDMismatchRecord.TabIndex = 958768;
            this.lblDMismatchRecord.Text = "Error Records :";
            // 
            // lblDDublicateRecords
            // 
            this.lblDDublicateRecords.AutoSize = true;
            this.lblDDublicateRecords.Location = new System.Drawing.Point(170, 519);
            this.lblDDublicateRecords.Name = "lblDDublicateRecords";
            this.lblDDublicateRecords.Size = new System.Drawing.Size(121, 17);
            this.lblDDublicateRecords.TabIndex = 958767;
            this.lblDDublicateRecords.Text = "Duplicate Records :";
            // 
            // lblDTotalRecord
            // 
            this.lblDTotalRecord.AutoSize = true;
            this.lblDTotalRecord.Location = new System.Drawing.Point(12, 519);
            this.lblDTotalRecord.Name = "lblDTotalRecord";
            this.lblDTotalRecord.Size = new System.Drawing.Size(95, 17);
            this.lblDTotalRecord.TabIndex = 958766;
            this.lblDTotalRecord.Text = "Total Records :";
            // 
            // btnImport
            // 
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Image = global::SMSApplication.Properties.Resources.import;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(1072, 513);
            this.btnImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(79, 29);
            this.btnImport.TabIndex = 40;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = global::SMSApplication.Properties.Resources.clear1;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(1155, 513);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(79, 29);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::SMSApplication.Properties.Resources.cancel;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1238, 513);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 29);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grdStaffImport
            // 
            this.grdStaffImport.AllowUserToAddRows = false;
            this.grdStaffImport.AllowUserToDeleteRows = false;
            this.grdStaffImport.AllowUserToResizeRows = false;
            this.grdStaffImport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdStaffImport.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStaffImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdStaffImport.ColumnHeadersHeight = 30;
            this.grdStaffImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdStaffImport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.clmstaffname,
            this.clmmobile,
            this.clmdob,
            this.clmblood,
            this.clmdesignation,
            this.clmrfid,
            this.clmaddress,
            this.clmaddress2,
            this.clmaddress3,
            this.clmcity,
            this.clmpincode,
            this.clmstatus});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStaffImport.DefaultCellStyle = dataGridViewCellStyle12;
            this.grdStaffImport.EnableHeadersVisualStyles = false;
            this.grdStaffImport.GridColor = System.Drawing.Color.White;
            this.grdStaffImport.Location = new System.Drawing.Point(8, 58);
            this.grdStaffImport.Name = "grdStaffImport";
            this.grdStaffImport.ReadOnly = true;
            this.grdStaffImport.RowHeadersVisible = false;
            this.grdStaffImport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStaffImport.Size = new System.Drawing.Size(1312, 448);
            this.grdStaffImport.TabIndex = 37;
//            this.grdStaffImport.Validated += new System.EventHandler(this.grdStudentImport_Validated);
            // 
            // btnDownloadTemplate
            // 
            this.btnDownloadTemplate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadTemplate.Image = global::SMSApplication.Properties.Resources.download;
            this.btnDownloadTemplate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDownloadTemplate.Location = new System.Drawing.Point(819, 21);
            this.btnDownloadTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadTemplate.Name = "btnDownloadTemplate";
            this.btnDownloadTemplate.Size = new System.Drawing.Size(160, 29);
            this.btnDownloadTemplate.TabIndex = 21;
            this.btnDownloadTemplate.Text = "Download Template";
            this.btnDownloadTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDownloadTemplate.UseVisualStyleBackColor = true;
            this.btnDownloadTemplate.Click += new System.EventHandler(this.btnDownloadTemplate_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Image = global::SMSApplication.Properties.Resources.view1;
            this.btnPreview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreview.Location = new System.Drawing.Point(712, 21);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(94, 29);
            this.btnPreview.TabIndex = 20;
            this.btnPreview.Text = "Preview";
            this.btnPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Image = global::SMSApplication.Properties.Resources.browse;
            this.btnBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowse.Location = new System.Drawing.Point(607, 21);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 29);
            this.btnBrowse.TabIndex = 19;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblDFileName
            // 
            this.lblDFileName.AutoSize = true;
            this.lblDFileName.Location = new System.Drawing.Point(12, 27);
            this.lblDFileName.Name = "lblDFileName";
            this.lblDFileName.Size = new System.Drawing.Size(66, 17);
            this.lblDFileName.TabIndex = 16;
            this.lblDFileName.Text = "File Name";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.White;
            this.txtFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(80, 24);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(506, 23);
            this.txtFileName.TabIndex = 14;
            // 
            // lblNoRecordsFound
            // 
            this.lblNoRecordsFound.AutoSize = true;
            this.lblNoRecordsFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecordsFound.Location = new System.Drawing.Point(604, 274);
            this.lblNoRecordsFound.Name = "lblNoRecordsFound";
            this.lblNoRecordsFound.Size = new System.Drawing.Size(121, 17);
            this.lblNoRecordsFound.TabIndex = 958763;
            this.lblNoRecordsFound.Text = "No Records Found";
            this.lblNoRecordsFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNoRecordsFound.Visible = false;
            // 
            // picLoader
            // 
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoader.ErrorImage = null;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = null;
            this.picLoader.Location = new System.Drawing.Point(9, 58);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1310, 448);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958787;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // clmsno
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 65;
            // 
            // clmstaffname
            // 
            this.clmstaffname.HeaderText = "Staff Name";
            this.clmstaffname.Name = "clmstaffname";
            this.clmstaffname.ReadOnly = true;
            this.clmstaffname.Width = 180;
            // 
            // clmmobile
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmmobile.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmmobile.HeaderText = "Mobile No.";
            this.clmmobile.Name = "clmmobile";
            this.clmmobile.ReadOnly = true;
            // 
            // clmdob
            // 
            this.clmdob.HeaderText = "Date Of Birth";
            this.clmdob.Name = "clmdob";
            this.clmdob.ReadOnly = true;
            // 
            // clmblood
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmblood.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmblood.HeaderText = "Blood Group";
            this.clmblood.Name = "clmblood";
            this.clmblood.ReadOnly = true;
            // 
            // clmdesignation
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmdesignation.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmdesignation.HeaderText = "Designation";
            this.clmdesignation.Name = "clmdesignation";
            this.clmdesignation.ReadOnly = true;
            this.clmdesignation.Width = 200;
            // 
            // clmrfid
            // 
            this.clmrfid.HeaderText = "RF ID Card No.";
            this.clmrfid.Name = "clmrfid";
            this.clmrfid.ReadOnly = true;
            this.clmrfid.Width = 150;
            // 
            // clmaddress
            // 
            this.clmaddress.HeaderText = "Address - 1";
            this.clmaddress.Name = "clmaddress";
            this.clmaddress.ReadOnly = true;
            this.clmaddress.Width = 150;
            // 
            // clmaddress2
            // 
            this.clmaddress2.HeaderText = "Address - 2";
            this.clmaddress2.Name = "clmaddress2";
            this.clmaddress2.ReadOnly = true;
            // 
            // clmaddress3
            // 
            this.clmaddress3.HeaderText = "Address - 3";
            this.clmaddress3.Name = "clmaddress3";
            this.clmaddress3.ReadOnly = true;
            // 
            // clmcity
            // 
            this.clmcity.HeaderText = "City";
            this.clmcity.Name = "clmcity";
            this.clmcity.ReadOnly = true;
            // 
            // clmpincode
            // 
            this.clmpincode.HeaderText = "Pincode";
            this.clmpincode.Name = "clmpincode";
            this.clmpincode.ReadOnly = true;
            // 
            // clmstatus
            // 
            this.clmstatus.HeaderText = "Status";
            this.clmstatus.Name = "clmstatus";
            this.clmstatus.ReadOnly = true;
            this.clmstatus.Width = 70;
            // 
            // MR_StaffImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1339, 557);
            this.Controls.Add(this.gbStudentImport);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MR_StaffImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Import";
            this.gbStudentImport.ResumeLayout(false);
            this.gbStudentImport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStudentImport;
        internal System.Windows.Forms.Label lblDFileName;
        internal System.Windows.Forms.TextBox txtFileName;
        public System.Windows.Forms.Button btnBrowse;
        public System.Windows.Forms.Button btnPreview;
        public System.Windows.Forms.Button btnDownloadTemplate;
        public System.Windows.Forms.DataGridView grdStaffImport;
        public System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblNoRecordsFound;
        internal System.Windows.Forms.Label lblDDublicateRecords;
        internal System.Windows.Forms.Label lblDTotalRecord;
        internal System.Windows.Forms.Label lblDMismatchRecord;
        private System.Windows.Forms.Label lblDublicate;
        private System.Windows.Forms.Label lblMismatch;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstaffname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmmobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmblood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpincode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatus;
    }
}