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
    //Author : Deepa
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
                lblAcademicYear.Text =  pbAcademicMonth + " - " + pbCurrentYear;
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

        private void tsbCollegeProfile_Click(object sender, EventArgs e)
        {

        }

        private void tsbScheme_Click(object sender, EventArgs e)
        {

        }

        private void tsbBranch_Click(object sender, EventArgs e)
        {

        }

        private void tsbLocationName_Click(object sender, EventArgs e)
        {

        }

        private void tsbHall_Click(object sender, EventArgs e)
        {

        }

        private void tsbFee_Click(object sender, EventArgs e)
        {

        }

        private void tsbReasonMenu_Click(object sender, EventArgs e)
        {

        }

        private void tsbSettings_Click(object sender, EventArgs e)
        {

        }

        private void tsbUserProfileMenu_Click(object sender, EventArgs e)
        {

        }

        private void tsbResultDataDownload_Click(object sender, EventArgs e)
        {

        }

        private void tsbDiplomaEligibilityReport_Click(object sender, EventArgs e)
        {

        }

        private void tsbpasspercentage_Click(object sender, EventArgs e)
        {

        }

        private void tsbStudentPhotoDownload_Click(object sender, EventArgs e)
        {

        }

        private void tsbClassWiseRank_Click(object sender, EventArgs e)
        {

        }

        private void tsbSubjectWiseRank_Click(object sender, EventArgs e)
        {

        }

        private void tsbStatisticsComparision_Click(object sender, EventArgs e)
        {

        }

        private void tsbFailedCandidates_Click(object sender, EventArgs e)
        {

        }

        private void tsbPassPer_Click(object sender, EventArgs e)
        {

        }

        private void tsbCombinedStudentSignature_Click(object sender, EventArgs e)
        {

        }

        private void tsbConsolidateStudentSignature_Click(object sender, EventArgs e)
        {

        }

        private void tsbStatisticReport_Click(object sender, EventArgs e)
        {

        }

        private void tsbConsolidateMarksheetOG_Click(object sender, EventArgs e)
        {

        }

        private void tsbDiplomanotcompleted_Click(object sender, EventArgs e)
        {

        }

        private void tsbTotalMarkRange_Click(object sender, EventArgs e)
        {

        }
    } 
}
