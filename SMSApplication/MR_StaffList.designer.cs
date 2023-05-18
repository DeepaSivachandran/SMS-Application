namespace SMSApplication
{
    partial class MR_StaffList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_StaffList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdStaffList = new System.Windows.Forms.DataGridView();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tspFormHeader = new System.Windows.Forms.ToolStripLabel();
            this.tsbexport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.lblDcolumnIndex = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.LBLSTAFFCODE = new System.Windows.Forms.Label();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSchemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmaddress3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmpincode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmdob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmblood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmrfcardno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMSTAFFID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffList)).BeginInit();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // grdStaffList
            // 
            this.grdStaffList.AllowUserToAddRows = false;
            this.grdStaffList.AllowUserToDeleteRows = false;
            this.grdStaffList.AllowUserToResizeRows = false;
            this.grdStaffList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdStaffList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdStaffList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdStaffList.ColumnHeadersHeight = 30;
            this.grdStaffList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdStaffList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.clmSchemeName,
            this.clmdesignation,
            this.clmaddress1,
            this.clmaddress2,
            this.clmaddress3,
            this.clmpincode,
            this.C,
            this.clmcity,
            this.clmdob,
            this.clmblood,
            this.clmrfcardno,
            this.clmShortName,
            this.CLMSTAFFID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdStaffList.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdStaffList.EnableHeadersVisualStyles = false;
            this.grdStaffList.GridColor = System.Drawing.Color.White;
            this.grdStaffList.Location = new System.Drawing.Point(17, 28);
            this.grdStaffList.Name = "grdStaffList";
            this.grdStaffList.ReadOnly = true;
            this.grdStaffList.RowHeadersVisible = false;
            this.grdStaffList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStaffList.Size = new System.Drawing.Size(1325, 559);
            this.grdStaffList.TabIndex = 18;
            this.grdStaffList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStaffList_CellContentClick);
            this.grdStaffList.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdStaffList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
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
            this.tspFormHeader,
            this.tsbexport,
            this.toolStripSeparator3,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbEdit,
            this.toolStripSeparator2,
            this.tsbNew});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(1360, 31);
            this.tspMenu.TabIndex = 958722;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tspFormHeader
            // 
            this.tspFormHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspFormHeader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspFormHeader.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tspFormHeader.Name = "tspFormHeader";
            this.tspFormHeader.Size = new System.Drawing.Size(34, 28);
            this.tspFormHeader.Text = "Staff";
            // 
            // tsbexport
            // 
            this.tsbexport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbexport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbexport.Image = global::SMSApplication.Properties.Resources.excel;
            this.tsbexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbexport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbexport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbexport.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbexport.Name = "tsbexport";
            this.tsbexport.Size = new System.Drawing.Size(74, 28);
            this.tsbexport.Text = "Export";
            this.tsbexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbexport.Click += new System.EventHandler(this.tsbexport_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = global::SMSApplication.Properties.Resources.delete16X16;
            this.tsbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(65, 28);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEdit.Image = global::SMSApplication.Properties.Resources.edit__2_;
            this.tsbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(50, 28);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbNew
            // 
            this.tsbNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = global::SMSApplication.Properties.Resources.New;
            this.tsbNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(62, 28);
            this.tsbNew.Text = "New";
            this.tsbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
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
            // LBLSTAFFCODE
            // 
            this.LBLSTAFFCODE.AutoSize = true;
            this.LBLSTAFFCODE.Location = new System.Drawing.Point(710, 8);
            this.LBLSTAFFCODE.Name = "LBLSTAFFCODE";
            this.LBLSTAFFCODE.Size = new System.Drawing.Size(15, 17);
            this.LBLSTAFFCODE.TabIndex = 958788;
            this.LBLSTAFFCODE.Text = "0";
            this.LBLSTAFFCODE.Visible = false;
            // 
            // clmsno
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmsno.Frozen = true;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 60;
            // 
            // clmSchemeName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmSchemeName.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmSchemeName.Frozen = true;
            this.clmSchemeName.HeaderText = "Staff Name";
            this.clmSchemeName.Name = "clmSchemeName";
            this.clmSchemeName.ReadOnly = true;
            this.clmSchemeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSchemeName.Width = 200;
            // 
            // clmdesignation
            // 
            this.clmdesignation.Frozen = true;
            this.clmdesignation.HeaderText = "Designation";
            this.clmdesignation.Name = "clmdesignation";
            this.clmdesignation.ReadOnly = true;
            // 
            // clmaddress1
            // 
            this.clmaddress1.HeaderText = "Address - 1";
            this.clmaddress1.Name = "clmaddress1";
            this.clmaddress1.ReadOnly = true;
            this.clmaddress1.Visible = false;
            this.clmaddress1.Width = 200;
            // 
            // clmaddress2
            // 
            this.clmaddress2.HeaderText = "Address - 2";
            this.clmaddress2.Name = "clmaddress2";
            this.clmaddress2.ReadOnly = true;
            this.clmaddress2.Visible = false;
            this.clmaddress2.Width = 200;
            // 
            // clmaddress3
            // 
            this.clmaddress3.HeaderText = "Address - 3";
            this.clmaddress3.Name = "clmaddress3";
            this.clmaddress3.ReadOnly = true;
            this.clmaddress3.Visible = false;
            this.clmaddress3.Width = 200;
            // 
            // clmpincode
            // 
            this.clmpincode.HeaderText = "Pincode";
            this.clmpincode.Name = "clmpincode";
            this.clmpincode.ReadOnly = true;
            this.clmpincode.Visible = false;
            // 
            // C
            // 
            this.C.Frozen = true;
            this.C.HeaderText = "Mobile No.";
            this.C.Name = "C";
            this.C.ReadOnly = true;
            // 
            // clmcity
            // 
            this.clmcity.HeaderText = "City";
            this.clmcity.Name = "clmcity";
            this.clmcity.ReadOnly = true;
            // 
            // clmdob
            // 
            this.clmdob.HeaderText = "DOB";
            this.clmdob.Name = "clmdob";
            this.clmdob.ReadOnly = true;
            // 
            // clmblood
            // 
            this.clmblood.HeaderText = "Blood Group";
            this.clmblood.Name = "clmblood";
            this.clmblood.ReadOnly = true;
            // 
            // clmrfcardno
            // 
            this.clmrfcardno.HeaderText = "RF ID Card No.";
            this.clmrfcardno.Name = "clmrfcardno";
            this.clmrfcardno.ReadOnly = true;
            this.clmrfcardno.Width = 120;
            // 
            // clmShortName
            // 
            this.clmShortName.HeaderText = "Status";
            this.clmShortName.Name = "clmShortName";
            this.clmShortName.ReadOnly = true;
            this.clmShortName.Width = 150;
            // 
            // CLMSTAFFID
            // 
            this.CLMSTAFFID.HeaderText = "STAFFID";
            this.CLMSTAFFID.Name = "CLMSTAFFID";
            this.CLMSTAFFID.ReadOnly = true;
            this.CLMSTAFFID.Visible = false;
            this.CLMSTAFFID.Width = 5;
            // 
            // MR_StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.LBLSTAFFCODE);
            this.Controls.Add(this.lblDcolumnIndex);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.lblDNoRecordFound);
            this.Controls.Add(this.grdStaffList);
            this.Controls.Add(this.picLoader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MR_StaffList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_SchemeList";
            this.Load += new System.EventHandler(this.MR_StaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStaffList)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdStaffList;
        private System.Windows.Forms.Label lblDNoRecordFound;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel tspFormHeader;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.Label lblDcolumnIndex;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbexport;
        private System.Windows.Forms.Label LBLSTAFFCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSchemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmaddress3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmpincode;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmdob;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmblood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmrfcardno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMSTAFFID;
    }
}