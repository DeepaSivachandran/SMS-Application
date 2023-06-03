﻿using System.Drawing;

namespace SMSApplication
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ntfy = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblTime = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsbLogo = new System.Windows.Forms.ToolStripMenuItem();
            this.tssNew = new System.Windows.Forms.ToolStripSeparator();
            this.tsbHome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbControlPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSMSStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSMSStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSMSGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmpresentreport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSenderID = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGeneralSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChangePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.tssTotalCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblsentsms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltotalsms = new System.Windows.Forms.Label();
            this.lblbucketlist = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsmscompare = new System.Windows.Forms.Label();
            this.lblouttimesms = new System.Windows.Forms.Label();
            this.lblnetoff = new System.Windows.Forms.Label();
            this.lblneton = new System.Windows.Forms.Label();
            this.smsTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ntfy
            // 
            this.ntfy.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfy.BalloonTipText = "SSS Exam Cell";
            this.ntfy.BalloonTipTitle = "SSS Exam Cell";
            this.ntfy.Text = "SSS Exam Cell";
            this.ntfy.Click += new System.EventHandler(this.ntfy_Click);
            this.ntfy.DoubleClick += new System.EventHandler(this.ntfy_DoubleClick);
            // 
            // lblTime
            // 
            this.lblTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblTime.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbChangePassword});
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTime.Margin = new System.Windows.Forms.Padding(50, 21, 0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(27, 33);
            this.lblTime.Text = "a";
            // 
            // tsbChangePassword
            // 
            this.tsbChangePassword.Checked = true;
            this.tsbChangePassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsbChangePassword.Name = "tsbChangePassword";
            this.tsbChangePassword.Size = new System.Drawing.Size(180, 22);
            this.tsbChangePassword.Text = "Change Password";
            this.tsbChangePassword.Visible = false;
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.SystemColors.Menu;
            this.ms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogo,
            this.tssNew,
            this.tsbHome,
            this.tsbControlPanel,
            this.reportsToolStripMenuItem1,
            this.toolStripMenuItem1,
            this.tsbLogout,
            this.lblTime});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.ms.Size = new System.Drawing.Size(1275, 58);
            this.ms.TabIndex = 112;
            this.ms.Text = "ms";
            // 
            // tsbLogo
            // 
            this.tsbLogo.BackColor = System.Drawing.Color.Transparent;
            this.tsbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbLogo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLogo.Image = global::SMSApplication.Properties.Resources.trio_s_logo;
            this.tsbLogo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLogo.Name = "tsbLogo";
            this.tsbLogo.Size = new System.Drawing.Size(137, 54);
            this.tsbLogo.Text = "Logo";
            this.tsbLogo.Click += new System.EventHandler(this.tsbLogo_Click);
            // 
            // tssNew
            // 
            this.tssNew.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.tssNew.Name = "tssNew";
            this.tssNew.Size = new System.Drawing.Size(6, 54);
            // 
            // tsbHome
            // 
            this.tsbHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbHome.Image = global::SMSApplication.Properties.Resources.Home;
            this.tsbHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbHome.Name = "tsbHome";
            this.tsbHome.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.tsbHome.Size = new System.Drawing.Size(55, 54);
            this.tsbHome.Text = "&Home";
            this.tsbHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbHome.Visible = false;
            this.tsbHome.Click += new System.EventHandler(this.tsbHome_Click);
            // 
            // tsbControlPanel
            // 
            this.tsbControlPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSMSStudents,
            this.tsmSMSStaff,
            this.tsmSMSGeneral});
            this.tsbControlPanel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbControlPanel.Image = global::SMSApplication.Properties.Resources.send_sms;
            this.tsbControlPanel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbControlPanel.Name = "tsbControlPanel";
            this.tsbControlPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.tsbControlPanel.ShowShortcutKeys = false;
            this.tsbControlPanel.Size = new System.Drawing.Size(79, 54);
            this.tsbControlPanel.Text = "&Send SMS";
            this.tsbControlPanel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbControlPanel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmSMSStudents
            // 
            this.tsmSMSStudents.Name = "tsmSMSStudents";
            this.tsmSMSStudents.Size = new System.Drawing.Size(261, 22);
            this.tsmSMSStudents.Text = "Student Attendance - Parents";
            this.tsmSMSStudents.Click += new System.EventHandler(this.TsmSMSStudents_Click);
            // 
            // tsmSMSStaff
            // 
            this.tsmSMSStaff.Name = "tsmSMSStaff";
            this.tsmSMSStaff.Size = new System.Drawing.Size(261, 22);
            this.tsmSMSStaff.Text = "Staff Attendance - Management";
            this.tsmSMSStaff.Click += new System.EventHandler(this.TsmSMSStaff_Click);
            // 
            // tsmSMSGeneral
            // 
            this.tsmSMSGeneral.Name = "tsmSMSGeneral";
            this.tsmSMSGeneral.Size = new System.Drawing.Size(261, 22);
            this.tsmSMSGeneral.Text = "Compose ";
            this.tsmSMSGeneral.Click += new System.EventHandler(this.TsmSMSGeneral_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmpresentreport,
            this.smsTransactionsToolStripMenuItem});
            this.reportsToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem1.Image = global::SMSApplication.Properties.Resources.reports1;
            this.reportsToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(66, 54);
            this.reportsToolStripMenuItem1.Text = "&Reports";
            this.reportsToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reportsToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsmpresentreport
            // 
            this.tsmpresentreport.Name = "tsmpresentreport";
            this.tsmpresentreport.Size = new System.Drawing.Size(176, 22);
            this.tsmpresentreport.Text = "Absent Report";
            this.tsmpresentreport.Click += new System.EventHandler(this.tsmpresentreport_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.tsmGeneralSettings,
            this.tsmChangePwd});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Image = global::SMSApplication.Properties.Resources.control_panel;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 54);
            this.toolStripMenuItem1.Text = "&Control Panel";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStudent,
            this.toolStripMenuItem4,
            this.tsmSenderID,
            this.tsmTemplate});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Masters";
            // 
            // tsmStudent
            // 
            this.tsmStudent.Name = "tsmStudent";
            this.tsmStudent.Size = new System.Drawing.Size(133, 22);
            this.tsmStudent.Text = "Student";
            this.tsmStudent.Click += new System.EventHandler(this.TsmStudent_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItem4.Text = "Staff";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.ToolStripMenuItem4_Click);
            // 
            // tsmSenderID
            // 
            this.tsmSenderID.Name = "tsmSenderID";
            this.tsmSenderID.Size = new System.Drawing.Size(133, 22);
            this.tsmSenderID.Text = "Sender ID";
            this.tsmSenderID.Click += new System.EventHandler(this.TsmSenderID_Click);
            // 
            // tsmTemplate
            // 
            this.tsmTemplate.Name = "tsmTemplate";
            this.tsmTemplate.Size = new System.Drawing.Size(133, 22);
            this.tsmTemplate.Text = "Template";
            this.tsmTemplate.Click += new System.EventHandler(this.TsmTemplate_Click);
            // 
            // tsmGeneralSettings
            // 
            this.tsmGeneralSettings.Name = "tsmGeneralSettings";
            this.tsmGeneralSettings.Size = new System.Drawing.Size(180, 22);
            this.tsmGeneralSettings.Text = "General Settings";
            this.tsmGeneralSettings.Click += new System.EventHandler(this.TsmGeneralSettings_Click);
            // 
            // tsmChangePwd
            // 
            this.tsmChangePwd.Name = "tsmChangePwd";
            this.tsmChangePwd.Size = new System.Drawing.Size(180, 22);
            this.tsmChangePwd.Text = "Change Password";
            this.tsmChangePwd.Click += new System.EventHandler(this.TsmChangePwd_Click);
            // 
            // tsbLogout
            // 
            this.tsbLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogout.Image")));
            this.tsbLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.tsbLogout.ShowShortcutKeys = false;
            this.tsbLogout.Size = new System.Drawing.Size(61, 54);
            this.tsbLogout.Text = "&Logout";
            this.tsbLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogout.Click += new System.EventHandler(this.tsbLogout_Click);
            // 
            // tssTotalCount
            // 
            this.tssTotalCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tssTotalCount.Name = "tssTotalCount";
            this.tssTotalCount.Size = new System.Drawing.Size(14, 17);
            this.tssTotalCount.Text = "0";
            // 
            // tsslable
            // 
            this.tsslable.Name = "tsslable";
            this.tsslable.Size = new System.Drawing.Size(91, 17);
            this.tsslable.Text = ": No.of Records ";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTotalCount,
            this.tsslable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1275, 22);
            this.statusStrip1.TabIndex = 958784;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblsentsms
            // 
            this.lblsentsms.AutoSize = true;
            this.lblsentsms.BackColor = System.Drawing.SystemColors.Menu;
            this.lblsentsms.Font = new System.Drawing.Font("Oswald Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsentsms.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblsentsms.Location = new System.Drawing.Point(256, 21);
            this.lblsentsms.Name = "lblsentsms";
            this.lblsentsms.Size = new System.Drawing.Size(24, 29);
            this.lblsentsms.TabIndex = 958806;
            this.lblsentsms.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 958805;
            this.label2.Text = "Sent SMS : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1065, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 958809;
            this.label1.Text = "Internet Status";
            // 
            // timer2
            // 
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsentsms);
            this.groupBox1.Controls.Add(this.lbltotalsms);
            this.groupBox1.Controls.Add(this.lblbucketlist);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(493, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 50);
            this.groupBox1.TabIndex = 958812;
            this.groupBox1.TabStop = false;
            // 
            // lbltotalsms
            // 
            this.lbltotalsms.AutoSize = true;
            this.lbltotalsms.BackColor = System.Drawing.SystemColors.Menu;
            this.lbltotalsms.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsms.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbltotalsms.Location = new System.Drawing.Point(334, 12);
            this.lbltotalsms.Name = "lbltotalsms";
            this.lbltotalsms.Size = new System.Drawing.Size(15, 17);
            this.lbltotalsms.TabIndex = 958821;
            this.lbltotalsms.Text = "0";
            this.lbltotalsms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltotalsms.Visible = false;
            // 
            // lblbucketlist
            // 
            this.lblbucketlist.AutoSize = true;
            this.lblbucketlist.BackColor = System.Drawing.SystemColors.Menu;
            this.lblbucketlist.Font = new System.Drawing.Font("Oswald Regular", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbucketlist.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblbucketlist.Location = new System.Drawing.Point(116, 21);
            this.lblbucketlist.Name = "lblbucketlist";
            this.lblbucketlist.Size = new System.Drawing.Size(24, 29);
            this.lblbucketlist.TabIndex = 958815;
            this.lblbucketlist.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 958814;
            this.label4.Text = "Available Credits : ";
            // 
            // lblsmscompare
            // 
            this.lblsmscompare.AutoSize = true;
            this.lblsmscompare.BackColor = System.Drawing.SystemColors.Menu;
            this.lblsmscompare.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblsmscompare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblsmscompare.Location = new System.Drawing.Point(760, 14);
            this.lblsmscompare.Name = "lblsmscompare";
            this.lblsmscompare.Size = new System.Drawing.Size(247, 19);
            this.lblsmscompare.TabIndex = 958819;
            this.lblsmscompare.Text = "Last SMS Batch Time 4;00pm - 8:00am";
            this.lblsmscompare.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblsmscompare.Visible = false;
            // 
            // lblouttimesms
            // 
            this.lblouttimesms.AutoSize = true;
            this.lblouttimesms.BackColor = System.Drawing.SystemColors.Menu;
            this.lblouttimesms.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblouttimesms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblouttimesms.Location = new System.Drawing.Point(760, 33);
            this.lblouttimesms.Name = "lblouttimesms";
            this.lblouttimesms.Size = new System.Drawing.Size(51, 19);
            this.lblouttimesms.TabIndex = 958823;
            this.lblouttimesms.Text = "sms va";
            this.lblouttimesms.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblouttimesms.Visible = false;
            // 
            // lblnetoff
            // 
            this.lblnetoff.AutoSize = true;
            this.lblnetoff.BackColor = System.Drawing.SystemColors.Menu;
            this.lblnetoff.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblnetoff.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetoff.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblnetoff.Image = global::SMSApplication.Properties.Resources.internet_off__2_;
            this.lblnetoff.Location = new System.Drawing.Point(1158, 16);
            this.lblnetoff.Name = "lblnetoff";
            this.lblnetoff.Size = new System.Drawing.Size(16, 17);
            this.lblnetoff.TabIndex = 958811;
            this.lblnetoff.Text = "  ";
            // 
            // lblneton
            // 
            this.lblneton.AutoSize = true;
            this.lblneton.BackColor = System.Drawing.SystemColors.Menu;
            this.lblneton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblneton.ForeColor = System.Drawing.Color.White;
            this.lblneton.Image = global::SMSApplication.Properties.Resources.internet_on__2_;
            this.lblneton.Location = new System.Drawing.Point(1158, 16);
            this.lblneton.Name = "lblneton";
            this.lblneton.Size = new System.Drawing.Size(16, 17);
            this.lblneton.TabIndex = 958810;
            this.lblneton.Text = "  ";
            this.lblneton.Visible = false;
            // 
            // smsTransactionsToolStripMenuItem
            // 
            this.smsTransactionsToolStripMenuItem.Name = "smsTransactionsToolStripMenuItem";
            this.smsTransactionsToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.smsTransactionsToolStripMenuItem.Text = "SMS Transactions";
            this.smsTransactionsToolStripMenuItem.Click += new System.EventHandler(this.smsTransactionsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1275, 559);
            this.Controls.Add(this.lblouttimesms);
            this.Controls.Add(this.lblsmscompare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblnetoff);
            this.Controls.Add(this.lblneton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ms);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.NotifyIcon ntfy;
        private System.Windows.Forms.ToolStripMenuItem tsbLogout;
        private System.Windows.Forms.ToolStripMenuItem lblTime;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem tsbLogo;
        private System.Windows.Forms.ToolStripSeparator tssNew;
        private System.Windows.Forms.ToolStripMenuItem tsbChangePassword;
        public System.Windows.Forms.ToolStripStatusLabel tssTotalCount;
        public System.Windows.Forms.ToolStripStatusLabel tsslable;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsbControlPanel;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem tsmSenderID;
        private System.Windows.Forms.ToolStripMenuItem tsmTemplate;
        private System.Windows.Forms.ToolStripMenuItem tsmGeneralSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmChangePwd;
        private System.Windows.Forms.ToolStripMenuItem tsmSMSStudents;
        private System.Windows.Forms.ToolStripMenuItem tsmSMSStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmSMSGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Timer timer2;
        internal System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label lblneton;
        private System.Windows.Forms.Label lblnetoff;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblsentsms;
        public System.Windows.Forms.Label lblbucketlist;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblsmscompare;
        public System.Windows.Forms.Label lbltotalsms;
        private System.Windows.Forms.ToolStripMenuItem tsbHome;
        public System.Windows.Forms.Label lblouttimesms;
        private System.Windows.Forms.ToolStripMenuItem tsmpresentreport;
        private System.Windows.Forms.ToolStripMenuItem smsTransactionsToolStripMenuItem;
    }
}