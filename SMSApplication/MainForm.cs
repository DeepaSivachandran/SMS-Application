using System;
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

        //------- Variable Declaration
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
        public MainForm()
        {
            try
            {
                InitializeComponent();
                objValidation.setFontAndFontSize(this);
                timer1.Start();
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
                udfnCloseChildForms();
                objStart = new Start();
                objStart.MdiParent = this;
                objStart.Show();
            }
            catch (Exception ex)
            { objError = new DataError();objError.WriteFile(ex); }
        }
        
        private void tsbLogout_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult objResponse = MessageBox.Show("Are you sure want to Logout?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if ((objResponse == DialogResult.Yes))
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
                lblTime.Text = "Welcome " + MainForm.pbUserName + "\r\n" + objDservice.displaydata("SELECT CONVERT(nvarchar, GETDATE(), 106) + ' ' + SUBSTRING(CONVERT(nvarchar, GETDATE(), 100), 13, 7) AS CurrentDate");
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
                //udfnCloseChildForms();
                //MainForm.objMR_SenerIDList = new MR_SenderIDList();
                //MainForm.objMR_SenerIDList.MdiParent = this;
                //MainForm.objMR_SenerIDList.Show();
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
    } 
}
