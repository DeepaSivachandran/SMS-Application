namespace SMSApplication
{
    partial class RPT_SMSTRANSACTION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPT_SMSTRANSACTION));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCollegeProfile = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.DpDate = new System.Windows.Forms.Label();
            this.btnclassview = new System.Windows.Forms.Button();
            this.lblProfilePhotoPath = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.lblProfilePhotoFileName = new System.Windows.Forms.Label();
            this.lblCollegeLogoPath = new System.Windows.Forms.Label();
            this.epMR_GeneralSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsCollegeProfile = new System.Windows.Forms.ToolStrip();
            this.tspHeader = new System.Windows.Forms.ToolStripLabel();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.grdsmstransaction = new System.Windows.Forms.DataGridView();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcatagory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmsmscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmstatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbCollegeProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).BeginInit();
            this.tsCollegeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsmstransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCollegeProfile
            // 
            this.gbCollegeProfile.Controls.Add(this.lblDNoRecordFound);
            this.gbCollegeProfile.Controls.Add(this.grdsmstransaction);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoPath);
            this.gbCollegeProfile.Controls.Add(this.picLoader);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoFileName);
            this.gbCollegeProfile.Controls.Add(this.lblCollegeLogoPath);
            this.gbCollegeProfile.Location = new System.Drawing.Point(12, 74);
            this.gbCollegeProfile.Name = "gbCollegeProfile";
            this.gbCollegeProfile.Size = new System.Drawing.Size(1321, 521);
            this.gbCollegeProfile.TabIndex = 0;
            this.gbCollegeProfile.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.dpFromDate);
            this.groupBox1.Controls.Add(this.DpDate);
            this.groupBox1.Controls.Add(this.btnclassview);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 51);
            this.groupBox1.TabIndex = 958789;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // dpFromDate
            // 
            this.dpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(64, 18);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(113, 25);
            this.dpFromDate.TabIndex = 1;
            // 
            // DpDate
            // 
            this.DpDate.AutoSize = true;
            this.DpDate.Location = new System.Drawing.Point(16, 22);
            this.DpDate.Name = "DpDate";
            this.DpDate.Size = new System.Drawing.Size(35, 17);
            this.DpDate.TabIndex = 958802;
            this.DpDate.Text = "Date";
            // 
            // btnclassview
            // 
            this.btnclassview.Image = global::SMSApplication.Properties.Resources.view2;
            this.btnclassview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclassview.Location = new System.Drawing.Point(188, 15);
            this.btnclassview.Name = "btnclassview";
            this.btnclassview.Size = new System.Drawing.Size(75, 30);
            this.btnclassview.TabIndex = 2;
            this.btnclassview.Text = "View";
            this.btnclassview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclassview.UseVisualStyleBackColor = true;
            this.btnclassview.Click += new System.EventHandler(this.btnclassview_Click);
            // 
            // lblProfilePhotoPath
            // 
            this.lblProfilePhotoPath.AutoSize = true;
            this.lblProfilePhotoPath.Location = new System.Drawing.Point(315, 495);
            this.lblProfilePhotoPath.Name = "lblProfilePhotoPath";
            this.lblProfilePhotoPath.Size = new System.Drawing.Size(0, 17);
            this.lblProfilePhotoPath.TabIndex = 251;
            this.lblProfilePhotoPath.Visible = false;
            // 
            // picLoader
            // 
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoader.ErrorImage = null;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = null;
            this.picLoader.Location = new System.Drawing.Point(5, 12);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1323, 503);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958788;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // lblProfilePhotoFileName
            // 
            this.lblProfilePhotoFileName.AutoSize = true;
            this.lblProfilePhotoFileName.Location = new System.Drawing.Point(206, 495);
            this.lblProfilePhotoFileName.Name = "lblProfilePhotoFileName";
            this.lblProfilePhotoFileName.Size = new System.Drawing.Size(0, 17);
            this.lblProfilePhotoFileName.TabIndex = 250;
            this.lblProfilePhotoFileName.Visible = false;
            // 
            // lblCollegeLogoPath
            // 
            this.lblCollegeLogoPath.AutoSize = true;
            this.lblCollegeLogoPath.Location = new System.Drawing.Point(88, 505);
            this.lblCollegeLogoPath.Name = "lblCollegeLogoPath";
            this.lblCollegeLogoPath.Size = new System.Drawing.Size(0, 17);
            this.lblCollegeLogoPath.TabIndex = 249;
            this.lblCollegeLogoPath.Visible = false;
            // 
            // epMR_GeneralSettings
            // 
            this.epMR_GeneralSettings.ContainerControl = this;
            // 
            // tsCollegeProfile
            // 
            this.tsCollegeProfile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsCollegeProfile.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCollegeProfile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspHeader});
            this.tsCollegeProfile.Location = new System.Drawing.Point(0, 0);
            this.tsCollegeProfile.Name = "tsCollegeProfile";
            this.tsCollegeProfile.Size = new System.Drawing.Size(1360, 25);
            this.tsCollegeProfile.TabIndex = 35;
            this.tsCollegeProfile.Text = "toolStrip1";
            // 
            // tspHeader
            // 
            this.tspHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspHeader.Image = ((System.Drawing.Image)(resources.GetObject("tspHeader.Image")));
            this.tspHeader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspHeader.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tspHeader.Name = "tspHeader";
            this.tspHeader.Size = new System.Drawing.Size(179, 22);
            this.tspHeader.Text = "Report - SMS Transactions";
            // 
            // lblDNoRecordFound
            // 
            this.lblDNoRecordFound.AutoSize = true;
            this.lblDNoRecordFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNoRecordFound.Location = new System.Drawing.Point(602, 217);
            this.lblDNoRecordFound.Name = "lblDNoRecordFound";
            this.lblDNoRecordFound.Size = new System.Drawing.Size(121, 17);
            this.lblDNoRecordFound.TabIndex = 958790;
            this.lblDNoRecordFound.Text = "No Records Found";
            this.lblDNoRecordFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grdsmstransaction
            // 
            this.grdsmstransaction.AllowUserToAddRows = false;
            this.grdsmstransaction.AllowUserToDeleteRows = false;
            this.grdsmstransaction.AllowUserToResizeRows = false;
            this.grdsmstransaction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdsmstransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdsmstransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.grdsmstransaction.ColumnHeadersHeight = 30;
            this.grdsmstransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdsmstransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.clmcatagory,
            this.clmcontant,
            this.C,
            this.clmsmscount,
            this.clmstatus});
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdsmstransaction.DefaultCellStyle = dataGridViewCellStyle36;
            this.grdsmstransaction.EnableHeadersVisualStyles = false;
            this.grdsmstransaction.GridColor = System.Drawing.Color.White;
            this.grdsmstransaction.Location = new System.Drawing.Point(0, 12);
            this.grdsmstransaction.Name = "grdsmstransaction";
            this.grdsmstransaction.ReadOnly = true;
            this.grdsmstransaction.RowHeadersVisible = false;
            this.grdsmstransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdsmstransaction.Size = new System.Drawing.Size(1321, 503);
            this.grdsmstransaction.TabIndex = 958789;
            // 
            // clmsno
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle32;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 60;
            // 
            // clmcatagory
            // 
            this.clmcatagory.HeaderText = "Category";
            this.clmcatagory.Name = "clmcatagory";
            this.clmcatagory.ReadOnly = true;
            this.clmcatagory.Width = 200;
            // 
            // clmcontant
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmcontant.DefaultCellStyle = dataGridViewCellStyle33;
            this.clmcontant.HeaderText = "SMS Contant";
            this.clmcontant.Name = "clmcontant";
            this.clmcontant.ReadOnly = true;
            this.clmcontant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmcontant.Width = 450;
            // 
            // C
            // 
            this.C.HeaderText = "Mobile No.";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            this.C.Width = 200;
            // 
            // clmsmscount
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsmscount.DefaultCellStyle = dataGridViewCellStyle34;
            this.clmsmscount.HeaderText = "SMS Count";
            this.clmsmscount.Name = "clmsmscount";
            this.clmsmscount.ReadOnly = true;
            // 
            // clmstatus
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmstatus.DefaultCellStyle = dataGridViewCellStyle35;
            this.clmstatus.HeaderText = "Status";
            this.clmstatus.Name = "clmstatus";
            this.clmstatus.ReadOnly = true;
            // 
            // btnExport
            // 
            this.btnExport.Image = global::SMSApplication.Properties.Resources.excel;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(274, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 30);
            this.btnExport.TabIndex = 958791;
            this.btnExport.Text = "Export Contacts";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // RPT_SMSTRANSACTION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsCollegeProfile);
            this.Controls.Add(this.gbCollegeProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPT_SMSTRANSACTION";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "College Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RPT_Persent_FormClosed);
            this.Load += new System.EventHandler(this.MR_GeneralSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_GeneralSettings_KeyDown);
            this.Leave += new System.EventHandler(this.MR_GeneralSettings_Leave);
            this.gbCollegeProfile.ResumeLayout(false);
            this.gbCollegeProfile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).EndInit();
            this.tsCollegeProfile.ResumeLayout(false);
            this.tsCollegeProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdsmstransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCollegeProfile;
        private System.Windows.Forms.ErrorProvider epMR_GeneralSettings;
        public System.Windows.Forms.Label lblCollegeLogoPath;
        public System.Windows.Forms.Label lblProfilePhotoFileName;
        public System.Windows.Forms.Label lblProfilePhotoPath;
        private System.Windows.Forms.ToolStrip tsCollegeProfile;
        private System.Windows.Forms.ToolStripLabel tspHeader;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DpDate;
        private System.Windows.Forms.Button btnclassview;
        private System.Windows.Forms.DateTimePicker dpFromDate;
        private System.Windows.Forms.Label lblDNoRecordFound;
        public System.Windows.Forms.DataGridView grdsmstransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcatagory;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsmscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmstatus;
        private System.Windows.Forms.Button btnExport;
    }
}