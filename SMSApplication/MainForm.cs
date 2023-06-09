﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using SMSApplication.ServiceClass;

namespace SMSApplication
{  
    //Author : Lavanya
    //CreatedDate : 2019-04-06
    public partial class MainForm : Form
    {
        //------- Servic Class object declaration
        DataValidation objValidation = new DataValidation();
        public DataError objError = new DataError();
        private TRN_SMS_Student studentsms;
        private TRN_SMS_General generalsms;
        //------- Variable Declaration

        public static string totalsms="0";
        public static string sentsms="0";
        public static string sentloadingcount = "0";
        public static string pendingsms = "0"; 
        public static int varCloseFlag = 0;
        public static string pbVersion;
        public static string pbUserID;
        public static string pbUserName;
        public static string pbUsername; 
        public static string pbUserRoleId;
        public static string pbView;
        public static string pbSelectedMenu;
        public static string pbIpAddress = "172.16.1.200";
        public static int pbAcademicCode;
        public static string pbAcademicYear;
        public static string pbAcademicMonth;
        public static string pbFromYear;
        public static string pbToYear;
        public static string pbFromMonth;
        public static string pbToMonth;
        public static string pbCurrentYear;
        public static int pbSchemeCode;
        public static string pbSchemeName;
        public static string pbTotalCount;
        //------- Form object declaration
        public static MainForm objMainForm;
        public static Start objStart;
        public static ServerSettings objServerSettings;
        public static MR_SenderID objMR_SenderID;
        public static MR_SenderIDList objMR_SenerIDList;
        public static MR_TemplateList objMR_TemplateList;
        public static MR_Template objMR_Template;
        public static MR_GeneralSettings objMR_GeneralSettings;
        public static MR_ChangePwd objMR_ChangePwd;
        public static MR_Staff objMR_Staff;
        public static MR_StaffList objMR_StaffList;
        public static MR_StudentsList objMR_StudentsList;
        public static MR_Student objMR_Student;
        public static MR_StudentImport objMR_StudentImport;
        public static MR_StaffImport objMR_StaffImport;
        
        public static TRN_SMS_Student objTRN_SMS_Student;
        public static TRN_SMS_Staff objTRN_SMS_Staff;
        public static TRN_SMS_General objTRN_SMS_General;
        public static MR_StudentWipout objMR_StudentWipout; 
        public static RPT_Absent objReportRPT_Absent;
        public static RPT_SMSTRANSACTION objRPT_SMSTRANSACTION;
      

          
        public MainForm()
        {
            try
            {
                InitializeComponent();
                objValidation.setFontAndFontSize(this);
                studentsms = new TRN_SMS_Student();
                studentsms.SetmainformInstance(this); // Pass the instance of Form1 to Form2 

                generalsms = new TRN_SMS_General();
                generalsms.SetmainformInstance(this);
                timer1.Start();
                lblbucketlist.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Replace label1 with the actual name of your label
                lblsentsms.Font = new Font("Segoe UI", 14, FontStyle.Bold); // Replace label1 with the actual name of your label

                lblsmscompare.Font = new Font("Segoe UI", 10, FontStyle.Regular); // Replace label1 with the actual name of your label
                lblsmscounting.Font = new Font("Segoe UI", 10, FontStyle.Regular); // Replace label1 with the actual name of your label

               // timer3.Start();
                timer2.Start();
            }
            catch (Exception ex)
            {
                objError = new ServiceClass.DataError();
                objError.WriteFile(ex);
            }
        }
        public void udfnCloseChildForms()
        {
            try
            {
                foreach (Form child in MdiChildren)
                {
                    child.Close();
                }
            }
            catch (Exception ex) {
                objError = new ServiceClass.DataError();
                objError.WriteFile(ex);
            }
        }
        public bool IsFrmOpen(Form nameForm)
        {
            bool isFound = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == nameForm.Name)
                {
                    isFound = true;
                }
            }
            return isFound;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                GetLocalIPAddress();
                this.Text = "SMS Application" + " - " + pbVersion;
                //lblAcademicYear.Text =  pbAcademicMonth + " - " + pbCurrentYear;
                timer1_Tick(sender, e);
                timer2_Tick(sender, e);
                //timer3_Tick(sender, e);
                udfnCloseChildForms();
                objTRN_SMS_Student = new TRN_SMS_Student();
                objTRN_SMS_Student.MdiParent = this;
                objTRN_SMS_Student.Show(); 
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex); }
        }
        
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult objResponse = MessageBox.Show("Are you sure want to Logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                DataService objDservice = new DataService();
                pendingsms = objDservice.displaydata("select top(1) case when jl_enddate is null then 0 else 1 end as smswaiting from TRN_SMSJobLog where jl_smscount <>0 and CONVERT(NVARCHAR, CONVERT(DATE,jl_enddate,101),103)=CONVERT(NVARCHAR,GETDATE(),103)order by jl_id desc");

                if ((objResponse == DialogResult.Yes))
                {
                    if (pendingsms == "1" || pendingsms == "")
                    {
                        if ((System.Windows.Forms.Application.MessageLoop))
                        {
                            varCloseFlag = 1;
                            System.Windows.Forms.Application.Exit();
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                        Close();
                    }
                    else { 
                        MessageBox.Show("Please Wait Message was Sending", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                objDservice.CloseConnection();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DataService objDservice = new DataService();
                // lblTime.Text = lblAcademicYear.Text + "\r\n" + "Welcome " + MainForm.pbUserName + "\r\n" + objDservice.displaydata("SELECT CONVERT(nvarchar, GETDATE(), 106) + ' ' + SUBSTRING(CONVERT(nvarchar, GETDATE(), 100), 13, 7) AS CurrentDate");
                lblTime.Text = "Welcome " + MainForm.pbUserName + "  " + objDservice.displaydata("select (CONVERT(nvarchar, GETDATE(), 106))  + ' ' +  RIGHT(GETDATE(),7)  AS CurrentDate");
                objDservice.CloseConnection();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (varCloseFlag == 0)
                {
                    DialogResult objResponse = MessageBox.Show("Are you sure want to Logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    DataService objDservice = new DataService();
                    pendingsms = objDservice.displaydata("select top(1) case when jl_enddate is null then 0 else 1 end as smswaiting from TRN_SMSJobLog where jl_smscount <>0 and CONVERT(NVARCHAR, CONVERT(DATE,jl_enddate,101),103)=CONVERT(NVARCHAR,GETDATE(),103)order by jl_id desc");
                    if (pendingsms == "1" || pendingsms == "")
                    {
                        if ((objResponse == DialogResult.Yes))
                        {
                            e.Cancel = false;
                            varCloseFlag = 1;
                            System.Windows.Forms.Application.Exit();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Wait Message was Sending!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    objDservice.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }         
        }
      //private void tsbBackup_Click(object sender, EventArgs e)
      //  {
      //      try
      //      {
      //          SaveFileDialog objSaveDialogu = new SaveFileDialog();

      //          if (objSaveDialogu.ShowDialog() == DialogResult.OK)
      //          {
      //              string varFileName = objSaveDialogu.FileName;
      //              SPDataService objSPService = new SPDataService();
      //              objSPService.spdbbackup(varFileName);
      //              MessageBox.Show("Successfully Downloaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //          }
      //      }
      //      catch (Exception ex)
      //      {
      //          objError = new DataError();
      //          objError.WriteFile(ex);
      //      }
      //  }
        
        private void MainForm_Resize(object sender, EventArgs e)
        {
            try
            {
                //if (FormWindowState.Minimized == WindowState)
                //{
                //    Hide();
                //    ntfy.Visible = true;
                //    ntfy.BalloonTipTitle = "SSS Inventory";
                //    ntfy.BalloonTipText = "Click here to maximize";
                //    ntfy.ShowBalloonTip(10000, "SSS Inventory", "Click here to maximize", ToolTipIcon.Info);
                //    ntfy.Icon = new Icon(Application.StartupPath + @"\SS_Apple.ico");
                //}
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        
        private void ntfy_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Show();
                WindowState = FormWindowState.Maximized;
                ntfy.Visible = false;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        
        private void ntfy_Click(object sender, EventArgs e)
        {
            try
            {
                Show();
                WindowState = FormWindowState.Maximized;
                ntfy.Visible = false;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
          
        public void GetLocalIPAddress()
        {
            try
            {
                pbIpAddress = Dns.GetHostAddresses(Dns.GetHostName()).First(a => a.AddressFamily == AddressFamily.InterNetwork).ToString();
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
        }
       
        private void tsbLogo_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                objTRN_SMS_Student = new TRN_SMS_Student();
                objTRN_SMS_Student.MdiParent = this;
                objTRN_SMS_Student.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
      
        private void tsbHome_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objStart = new Start();
                MainForm.objStart.MdiParent = this;
                MainForm.objStart.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmSenderID_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_SenerIDList = new MR_SenderIDList();
                MainForm.objMR_SenerIDList.MdiParent = this;
                MainForm.objMR_SenerIDList.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_TemplateList = new MR_TemplateList();
                MainForm.objMR_TemplateList.MdiParent = this;
                MainForm.objMR_TemplateList.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmGeneralSettings_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_GeneralSettings = new MR_GeneralSettings();
                MainForm.objMR_GeneralSettings.MdiParent = this;
                MainForm.objMR_GeneralSettings.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmChangePwd_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_ChangePwd = new MR_ChangePwd();
                MainForm.objMR_ChangePwd.MdiParent = this;
                MainForm.objMR_ChangePwd.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_StaffList = new MR_StaffList();
                MainForm.objMR_StaffList.MdiParent = this;
                MainForm.objMR_StaffList.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmStudent_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objMR_StudentsList = new MR_StudentsList();
                MainForm.objMR_StudentsList.MdiParent = this;
                MainForm.objMR_StudentsList.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmSMSStudents_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objTRN_SMS_Student = new TRN_SMS_Student();
                MainForm.objTRN_SMS_Student.MdiParent = this;
                MainForm.objTRN_SMS_Student.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void TsmSMSStaff_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objTRN_SMS_Staff = new TRN_SMS_Staff();
                MainForm.objTRN_SMS_Staff.MdiParent = this;
                MainForm.objTRN_SMS_Staff.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }

        private void TsmSMSGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms();
                MainForm.objTRN_SMS_General = new TRN_SMS_General();
                MainForm.objTRN_SMS_General.MdiParent = this;
                MainForm.objTRN_SMS_General.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public event EventHandler TimerElapsed;

        protected virtual void OnTimerElapsed()
        {
            TimerElapsed?.Invoke(this, EventArgs.Empty);
        }
        public void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                DataSet objds = new DataSet();  
                DataService objDservice = new DataService();
                 objds= objDservice.GetDataset("select top(1) CONVERT(NVARCHAR, CONVERT(DATE,jl_startdate,101),103)+' '+ left(CONVERT(NVARCHAR, jl_startdate, 108),5) as startvalue, RIGHT(jl_enddate,7)endvalue,jl_smscount as smscount,case when jl_enddate is null then 0 else 1 end as smswaiting from TRN_SMSJobLog where jl_smscount <>0 and CONVERT(NVARCHAR, CONVERT(DATE,jl_enddate,101),103)=CONVERT(NVARCHAR,GETDATE(),103)order by jl_id desc");
                //lblTime.Text = lblAcademicYear.Text + "\r\n" + "Welcome " + MainForm.pbUserName + "\r\n" + objDservice.displaydata("SELECT CONVERT(nvarchar, GETDATE(), 106) + ' ' + SUBSTRING(CONVERT(nvarchar, GETDATE(), 100), 13, 7) AS CurrentDate");
                lblbucketlist.Text = objDservice.displaydata("select ST_smsbucket from MR_Settings"); 
                totalsms = objDservice.displaydata("select top(1) SMS_TotalSms from TRN_SMS order by SMS_Id desc");
                sentsms = objDservice.displaydata("SELECT isnull(sum(SMSD_Count),0) AS TOTALSMS FROM TRN_SMSDetails AS A INNER JOIN TRN_SMS AS B ON A.SMSD_SMSId=B.SMS_Id WHERE SMS_SMSType IN (1,3,4,5,2) AND CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) ");
              //sentloadingcount =  objDservice.displaydata("SELECT sum(SMSD_Count) AS TOTALSMS FROM TRN_SMSDetails AS A INNER JOIN TRN_SMS AS B ON A.SMSD_SMSId=B.SMS_Id WHERE SMS_SMSType IN (1,3,4,5,2)AND CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) and SMSD_SMSId=(select max(SMS_Id) from TRN_SMS)");
                pendingsms = objDservice.displaydata("SELECT isnull(sum(SMSD_Count),0) AS TOTALSMS FROM TRN_SMSDetails AS A INNER JOIN TRN_SMS AS B ON A.SMSD_SMSId=B.SMS_Id WHERE SMS_SMSType IN (1,3,4,5,2) AND CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) and SMSD_SMSId=(select max(SMS_Id) from TRN_SMS)  and SMSD_Count is not null");

                objDservice.CloseConnection();  
                lbltotalsms.Text =totalsms;
                lblsentsms.Text = sentsms;
                if (objds.Tables[0].Rows.Count > 0)
                {
                    lblsmscounting.Visible = true;
                    lblsmscompare.Visible = true;
                    lblsmscompare.Text = objds.Tables[0].Rows[0]["startvalue"].ToString();
                    if (sentsms != "0")
                    {
                        if ( objds.Tables[0].Rows[0]["smswaiting"].ToString() == "1")
                        {
                            lblsmscounting.Text = totalsms + " / " +totalsms; 
                            lblsmscompleted.Text = "Completed";
                        }
                        else
                        {
                            lblsmscounting.Text = pendingsms + " / " + totalsms; 
                            lblsmscompleted.Text = "Sending";
                        }
                    }
                    else
                    {

                        lblsmscounting.Text = " - ";
                    }

                }
                else
                {
                    lblsmscounting.Visible = true;
                    lblsmscompare.Visible = true;

                    lblsmscounting.Text =  " - ";
                    lblsmscompare.Text = " - ";
                    
                   }
                objDservice.CloseConnection();
                OnTimerElapsed();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                 
                //if (objValidation.internetconnection()==true)
                //{

                //    lblneton.Visible = true; 
                //    lblnetoff.Visible = false;
                //}
                //else
                //{
                //    lblnetoff.Visible = true;
                //    lblneton.Visible = false;
                //}
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        

        private void tsmpresentreport_Click(object sender, EventArgs e)
        {
            try
            {
                udfnCloseChildForms(); 
                MainForm.objReportRPT_Absent = new RPT_Absent();
                MainForm.objReportRPT_Absent.MdiParent = this;
                MainForm.objReportRPT_Absent.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void smsTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
                try
            {
                udfnCloseChildForms();
                MainForm.objRPT_SMSTRANSACTION = new RPT_SMSTRANSACTION();
                MainForm.objRPT_SMSTRANSACTION.MdiParent = this;
                MainForm.objRPT_SMSTRANSACTION.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
         
         
    } 
}
