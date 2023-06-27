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
            this.grpstaff = new System.Windows.Forms.GroupBox();
            this.btnstaffabsent = new System.Windows.Forms.Button();
            this.dpstafftodate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dpstafffromdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpstaffabsent = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnstaffpresent = new System.Windows.Forms.Button();
            this.grpstudent = new System.Windows.Forms.GroupBox();
            this.btnstudentabsent = new System.Windows.Forms.Button();
            this.dpstudenttodate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dpstudentfrom = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpabsentstudent = new System.Windows.Forms.DateTimePicker();
            this.DpDate = new System.Windows.Forms.Label();
            this.btnstudentpresent = new System.Windows.Forms.Button();
            this.lblProfilePhotoPath = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.lblProfilePhotoFileName = new System.Windows.Forms.Label();
            this.lblCollegeLogoPath = new System.Windows.Forms.Label();
            this.epMR_GeneralSettings = new System.Windows.Forms.ErrorProvider(this.components);
            this.tsCollegeProfile = new System.Windows.Forms.ToolStrip();
            this.tspHeader = new System.Windows.Forms.ToolStripLabel();
            this.gbCollegeProfile.SuspendLayout();
            this.grpstaff.SuspendLayout();
            this.grpstudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).BeginInit();
            this.tsCollegeProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCollegeProfile
            // 
            this.gbCollegeProfile.Controls.Add(this.grpstaff);
            this.gbCollegeProfile.Controls.Add(this.grpstudent);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoPath);
            this.gbCollegeProfile.Controls.Add(this.picLoader);
            this.gbCollegeProfile.Controls.Add(this.lblProfilePhotoFileName);
            this.gbCollegeProfile.Controls.Add(this.lblCollegeLogoPath);
            this.gbCollegeProfile.Location = new System.Drawing.Point(12, 28);
            this.gbCollegeProfile.Name = "gbCollegeProfile";
            this.gbCollegeProfile.Size = new System.Drawing.Size(1321, 521);
            this.gbCollegeProfile.TabIndex = 0;
            this.gbCollegeProfile.TabStop = false;
            // 
            // grpstaff
            // 
            this.grpstaff.Controls.Add(this.btnstaffabsent);
            this.grpstaff.Controls.Add(this.dpstafftodate);
            this.grpstaff.Controls.Add(this.label5);
            this.grpstaff.Controls.Add(this.dpstafffromdate);
            this.grpstaff.Controls.Add(this.label6);
            this.grpstaff.Controls.Add(this.label7);
            this.grpstaff.Controls.Add(this.label8);
            this.grpstaff.Controls.Add(this.dpstaffabsent);
            this.grpstaff.Controls.Add(this.label9);
            this.grpstaff.Controls.Add(this.btnstaffpresent);
            this.grpstaff.Location = new System.Drawing.Point(640, 48);
            this.grpstaff.Name = "grpstaff";
            this.grpstaff.Size = new System.Drawing.Size(570, 188);
            this.grpstaff.TabIndex = 958790;
            this.grpstaff.TabStop = false;
            this.grpstaff.Text = "Staff";
            // 
            // btnstaffabsent
            // 
            this.btnstaffabsent.Image = global::SMSApplication.Properties.Resources.download;
            this.btnstaffabsent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstaffabsent.Location = new System.Drawing.Point(435, 129);
            this.btnstaffabsent.Name = "btnstaffabsent";
            this.btnstaffabsent.Size = new System.Drawing.Size(98, 30);
            this.btnstaffabsent.TabIndex = 5;
            this.btnstaffabsent.Text = "Download";
            this.btnstaffabsent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstaffabsent.UseVisualStyleBackColor = true;
            this.btnstaffabsent.Click += new System.EventHandler(this.btnstaffabsent_Click);
            // 
            // dpstafftodate
            // 
            this.dpstafftodate.CustomFormat = "dd/MM/yyyy";
            this.dpstafftodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstafftodate.Location = new System.Drawing.Point(300, 60);
            this.dpstafftodate.Name = "dpstafftodate";
            this.dpstafftodate.Size = new System.Drawing.Size(113, 25);
            this.dpstafftodate.TabIndex = 2;
            this.dpstafftodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpstafftodate_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 958813;
            this.label5.Text = "To Date";
            // 
            // dpstafffromdate
            // 
            this.dpstafffromdate.CustomFormat = "dd/MM/yyyy";
            this.dpstafffromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstafffromdate.Location = new System.Drawing.Point(113, 60);
            this.dpstafffromdate.Name = "dpstafffromdate";
            this.dpstafffromdate.Size = new System.Drawing.Size(113, 25);
            this.dpstafffromdate.TabIndex = 1;
            this.dpstafffromdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpstafffromdate_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 958811;
            this.label6.Text = "Absent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Green;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 958810;
            this.label7.Text = "Present";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 958809;
            this.label8.Text = "Attendance Date";
            // 
            // dpstaffabsent
            // 
            this.dpstaffabsent.CustomFormat = "dd/MM/yyyy";
            this.dpstaffabsent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstaffabsent.Location = new System.Drawing.Point(113, 132);
            this.dpstaffabsent.Name = "dpstaffabsent";
            this.dpstaffabsent.Size = new System.Drawing.Size(113, 25);
            this.dpstaffabsent.TabIndex = 4;
            this.dpstaffabsent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpstaffabsent_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 958802;
            this.label9.Text = "From Date";
            // 
            // btnstaffpresent
            // 
            this.btnstaffpresent.Image = global::SMSApplication.Properties.Resources.download;
            this.btnstaffpresent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstaffpresent.Location = new System.Drawing.Point(435, 57);
            this.btnstaffpresent.Name = "btnstaffpresent";
            this.btnstaffpresent.Size = new System.Drawing.Size(98, 30);
            this.btnstaffpresent.TabIndex = 3;
            this.btnstaffpresent.Text = "Download";
            this.btnstaffpresent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstaffpresent.UseVisualStyleBackColor = true;
            this.btnstaffpresent.Click += new System.EventHandler(this.btnstaffpresent_Click);
            // 
            // grpstudent
            // 
            this.grpstudent.Controls.Add(this.btnstudentabsent);
            this.grpstudent.Controls.Add(this.dpstudenttodate);
            this.grpstudent.Controls.Add(this.label4);
            this.grpstudent.Controls.Add(this.dpstudentfrom);
            this.grpstudent.Controls.Add(this.label3);
            this.grpstudent.Controls.Add(this.label2);
            this.grpstudent.Controls.Add(this.label1);
            this.grpstudent.Controls.Add(this.dpabsentstudent);
            this.grpstudent.Controls.Add(this.DpDate);
            this.grpstudent.Controls.Add(this.btnstudentpresent);
            this.grpstudent.Location = new System.Drawing.Point(30, 48);
            this.grpstudent.Name = "grpstudent";
            this.grpstudent.Size = new System.Drawing.Size(570, 188);
            this.grpstudent.TabIndex = 958789;
            this.grpstudent.TabStop = false;
            this.grpstudent.Text = "Student";
            // 
            // btnstudentabsent
            // 
            this.btnstudentabsent.Image = global::SMSApplication.Properties.Resources.download;
            this.btnstudentabsent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudentabsent.Location = new System.Drawing.Point(435, 129);
            this.btnstudentabsent.Name = "btnstudentabsent";
            this.btnstudentabsent.Size = new System.Drawing.Size(98, 30);
            this.btnstudentabsent.TabIndex = 5;
            this.btnstudentabsent.Text = "Download";
            this.btnstudentabsent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstudentabsent.UseVisualStyleBackColor = true;
            this.btnstudentabsent.Click += new System.EventHandler(this.btnstudentabsent_Click);
            // 
            // dpstudenttodate
            // 
            this.dpstudenttodate.CustomFormat = "dd/MM/yyyy";
            this.dpstudenttodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstudenttodate.Location = new System.Drawing.Point(300, 60);
            this.dpstudenttodate.Name = "dpstudenttodate";
            this.dpstudenttodate.Size = new System.Drawing.Size(113, 25);
            this.dpstudenttodate.TabIndex = 2;
            this.dpstudenttodate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpstudenttodate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 958813;
            this.label4.Text = "To Date";
            // 
            // dpstudentfrom
            // 
            this.dpstudentfrom.CustomFormat = "dd/MM/yyyy";
            this.dpstudentfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpstudentfrom.Location = new System.Drawing.Point(113, 60);
            this.dpstudentfrom.Name = "dpstudentfrom";
            this.dpstudentfrom.Size = new System.Drawing.Size(113, 25);
            this.dpstudentfrom.TabIndex = 1;
            this.dpstudentfrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpstudentfrom_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 958811;
            this.label3.Text = "Absent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 958810;
            this.label2.Text = "Present";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 958809;
            this.label1.Text = "Attendance Date";
            // 
            // dpabsentstudent
            // 
            this.dpabsentstudent.CustomFormat = "dd/MM/yyyy";
            this.dpabsentstudent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpabsentstudent.Location = new System.Drawing.Point(113, 132);
            this.dpabsentstudent.Name = "dpabsentstudent";
            this.dpabsentstudent.Size = new System.Drawing.Size(113, 25);
            this.dpabsentstudent.TabIndex = 4;
            this.dpabsentstudent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dpabsentstudent_KeyDown);
            // 
            // DpDate
            // 
            this.DpDate.AutoSize = true;
            this.DpDate.Location = new System.Drawing.Point(6, 64);
            this.DpDate.Name = "DpDate";
            this.DpDate.Size = new System.Drawing.Size(69, 17);
            this.DpDate.TabIndex = 958802;
            this.DpDate.Text = "From Date";
            // 
            // btnstudentpresent
            // 
            this.btnstudentpresent.Image = global::SMSApplication.Properties.Resources.download;
            this.btnstudentpresent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudentpresent.Location = new System.Drawing.Point(435, 57);
            this.btnstudentpresent.Name = "btnstudentpresent";
            this.btnstudentpresent.Size = new System.Drawing.Size(98, 30);
            this.btnstudentpresent.TabIndex = 3;
            this.btnstudentpresent.Text = "Download";
            this.btnstudentpresent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstudentpresent.UseVisualStyleBackColor = true;
            this.btnstudentpresent.Click += new System.EventHandler(this.btnclassview_Click);
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
            this.picLoader.Location = new System.Drawing.Point(5, -27);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1323, 581);
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
            this.tspHeader.Size = new System.Drawing.Size(133, 22);
            this.tspHeader.Text = "Attendance Report";
            // 
            // RPT_Absent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
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
            this.grpstaff.ResumeLayout(false);
            this.grpstaff.PerformLayout();
            this.grpstudent.ResumeLayout(false);
            this.grpstudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMR_GeneralSettings)).EndInit();
            this.tsCollegeProfile.ResumeLayout(false);
            this.tsCollegeProfile.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpstudent;
        private System.Windows.Forms.Label DpDate;
        private System.Windows.Forms.Button btnstudentpresent;
        private System.Windows.Forms.DateTimePicker dpabsentstudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dpstudenttodate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpstudentfrom;
        private System.Windows.Forms.Button btnstudentabsent;
        private System.Windows.Forms.GroupBox grpstaff;
        private System.Windows.Forms.Button btnstaffabsent;
        private System.Windows.Forms.DateTimePicker dpstafftodate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpstafffromdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpstaffabsent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnstaffpresent;
    }
}