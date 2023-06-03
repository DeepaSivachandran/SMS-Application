namespace SMSApplication
{
    partial class RPT_Absent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPT_Absent));
            this.gbCollegeProfile = new System.Windows.Forms.GroupBox();
            this.lblNorecordFound = new System.Windows.Forms.Label();
            this.rptviewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblProfilePhotoPath = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.lblProfilePhotoFileName = new System.Windows.Forms.Label();
            this.lblCollegeLogoPath = new System.Windows.Forms.Label();
            this.epMR_GeneralSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsCollegeProfile = new System.Windows.Forms.ToolStrip();
            this.tspHeader = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.dpFromDate = new System.Windows.Forms.DateTimePicker();
            this.DpDate = new System.Windows.Forms.Label();
            this.btnclassview = new System.Windows.Forms.Button();
            this.gbCollegeProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).BeginInit();
            this.tsCollegeProfile.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCollegeProfile
            // 
            this.gbCollegeProfile.Controls.Add(this.lblNorecordFound);
            this.gbCollegeProfile.Controls.Add(this.rptviewer);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoPath);
            this.gbCollegeProfile.Controls.Add(this.picLoader);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoFileName);
            this.gbCollegeProfile.Controls.Add(this.lblCollegeLogoPath);
            this.gbCollegeProfile.Location = new System.Drawing.Point(12, 74);
            this.gbCollegeProfile.Name = "gbCollegeProfile";
            this.gbCollegeProfile.Size = new System.Drawing.Size(1321, 488);
            this.gbCollegeProfile.TabIndex = 0;
            this.gbCollegeProfile.TabStop = false;
            // 
            // lblNorecordFound
            // 
            this.lblNorecordFound.AutoSize = true;
            this.lblNorecordFound.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblNorecordFound.Location = new System.Drawing.Point(607, 234);
            this.lblNorecordFound.Name = "lblNorecordFound";
            this.lblNorecordFound.Size = new System.Drawing.Size(138, 20);
            this.lblNorecordFound.TabIndex = 1111167;
            this.lblNorecordFound.Text = "No Records Found";
            // 
            // rptviewer
            // 
            this.rptviewer.ActiveViewIndex = -1;
            this.rptviewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptviewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptviewer.Location = new System.Drawing.Point(4, 12);
            this.rptviewer.Name = "rptviewer";
            this.rptviewer.Size = new System.Drawing.Size(1316, 465);
            this.rptviewer.TabIndex = 252;
            this.rptviewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.rptviewer.Visible = false;
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
            this.picLoader.Size = new System.Drawing.Size(1323, 470);
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
            this.tspHeader.Size = new System.Drawing.Size(117, 22);
            this.tspHeader.Text = "Report - Absent";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbStaff);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Controls.Add(this.dpFromDate);
            this.groupBox1.Controls.Add(this.DpDate);
            this.groupBox1.Controls.Add(this.btnclassview);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 51);
            this.groupBox1.TabIndex = 958789;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(283, 20);
            this.rbStaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(52, 21);
            this.rbStaff.TabIndex = 958810;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Checked = true;
            this.rbStudent.Location = new System.Drawing.Point(197, 20);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(70, 21);
            this.rbStudent.TabIndex = 958809;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // dpFromDate
            // 
            this.dpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpFromDate.Location = new System.Drawing.Point(50, 18);
            this.dpFromDate.Name = "dpFromDate";
            this.dpFromDate.Size = new System.Drawing.Size(113, 25);
            this.dpFromDate.TabIndex = 958808;
            // 
            // DpDate
            // 
            this.DpDate.AutoSize = true;
            this.DpDate.Location = new System.Drawing.Point(8, 22);
            this.DpDate.Name = "DpDate";
            this.DpDate.Size = new System.Drawing.Size(35, 17);
            this.DpDate.TabIndex = 958802;
            this.DpDate.Text = "Date";
            // 
            // btnclassview
            // 
            this.btnclassview.Image = global::SMSApplication.Properties.Resources.view2;
            this.btnclassview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclassview.Location = new System.Drawing.Point(428, 15);
            this.btnclassview.Name = "btnclassview";
            this.btnclassview.Size = new System.Drawing.Size(75, 30);
            this.btnclassview.TabIndex = 4;
            this.btnclassview.Text = "View";
            this.btnclassview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclassview.UseVisualStyleBackColor = true;
            this.btnclassview.Click += new System.EventHandler(this.btnclassview_Click);
            // 
            // RPT_Absent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsCollegeProfile);
            this.Controls.Add(this.gbCollegeProfile);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RPT_Absent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "College Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RPT_Persent_FormClosed);
            this.Load += new System.EventHandler(this.MR_GeneralSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MR_GeneralSettings_KeyDown);
            this.Leave += new System.EventHandler(this.MR_GeneralSettings_Leave);
            this.gbCollegeProfile.ResumeLayout(false);
            this.gbCollegeProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).EndInit();
            this.tsCollegeProfile.ResumeLayout(false);
            this.tsCollegeProfile.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptviewer;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DpDate;
        private System.Windows.Forms.Button btnclassview;
        private System.Windows.Forms.DateTimePicker dpFromDate;
        public System.Windows.Forms.RadioButton rbStaff;
        public System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.Label lblNorecordFound;
    }
}