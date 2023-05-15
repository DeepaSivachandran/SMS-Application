using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Diagnostics;
using SMSApplication.ServiceClass;

//[assembly: XmlConfigurator(Watch = true)]
//[assembly: Repository()]
// Author : Lavanya
// Created Date: 2019-04-13
namespace SMSApplication
{
    public partial class Authentication : Form
    {
        private SecurityController _security;

        // ***** Object for data service classes declaration *****
        DataValidation objValidation = new DataValidation();
        DataError objError;

        // ***** Declaration Part *****
        public static string varUserID;
        ToolTip tpUserName = new ToolTip();
        ToolTip tpPassword = new ToolTip();
        public Authentication()
        {
            InitializeComponent();
            _security = new SecurityController();
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtPassword.Focus();
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            try
            {
                txtUserName.BackColor = Color.LemonChiffon;
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            try
            {
                txtUserName.BackColor = Color.White;
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSignin.Focus();
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            try
            {
                txtPassword.BackColor = Color.LemonChiffon;
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPassword.BackColor = Color.White;
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void btnSignin_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet objDataset;
                if (txtUserName.TextLength != 0 & txtPassword.TextLength != 0)
                {
                    // Check user details exists or not
                    DataService objDserv = new DataService();
                    objDataset = objDserv.GetDataset("select Userid,RoleID,UserName from CP_UserProfile where Userid='" + txtUserName.Text + "' and Password='" + _security.Encrypt(txtUserName.Text, txtPassword.Text) + "'");
                    objDserv.CloseConnection();
                    if (objDataset.Tables[0].Rows.Count == 1)
                    {
                        // Assign values to variable for further process
                        MainForm.pbUserID = objDataset.Tables[0].Rows[0]["Userid"].ToString();
                        MainForm.pbUserRoleId = objDataset.Tables[0].Rows[0]["RoleID"].ToString();
                        MainForm.pbUserName = objDataset.Tables[0].Rows[0]["UserName"].ToString();
                        MainForm.pbVersion = lblDVersion.Text;
                        DataSet objAcademicdetails = new DataSet();
                        //objAcademicdetails = objDserv.GetDataset("IF (SELECT COUNT( *) FROM EXAM_NextSemGeneration) = 0  SELECT TOP 1 AcademicCode, CONCAT(FromYear, ' - ', ToYear) AS AcademicYear, FromYear, ToYear, frommonth, tomonth, frommonth AS AcademicMonth , FromYear AS CurrentYear FROM CP_AcademicYear ORDER BY AcademicCode DESC   ELSE   SELECT DERV.AcademicCode, CONCAT(FromYear, ' - ', ToYear) AS AcademicYear, FromYear, ToYear, frommonth, tomonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN tomonth ELSE frommonth END AS AcademicMonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN ToYear ELSE FromYear END AS CurrentYear FROM   (SELECT TOP 1 AcademicCode, AcademicMonth FROM EXAM_NextSemGeneration ORDER BY AcademicCode DESC, AcademicMonth DESC)   DERV INNER JOIN CP_AcademicYear AS DERV2 ON CASE WHEN DERV.AcademicMonth = frommonth THEN DERV.AcademicCode ELSE DERV.AcademicCode - 1  END = DERV2.AcademicCode");
                        //  objAcademicdetails = objDserv.GetDataset("IF (SELECT COUNT( *) FROM EXAM_NextSemGeneration) = 0  SELECT TOP 1 AcademicCode, CONCAT(FromYear, ' - ', ToYear) AS AcademicYear, FromYear, ToYear, frommonth, tomonth, frommonth AS AcademicMonth , FromYear AS CurrentYear FROM CP_AcademicYear ORDER BY AcademicCode DESC   ELSE   SELECT DERV.AcademicCode, CONCAT(FromYear, ' - ', ToYear) AS AcademicYear, FromYear, ToYear, frommonth, tomonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN tomonth ELSE frommonth END AS AcademicMonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN ToYear ELSE FromYear END AS CurrentYear FROM   (SELECT TOP 1 AcademicCode, AcademicMonth FROM EXAM_NextSemGeneration ORDER BY AcademicCode DESC, AcademicMonth DESC)   DERV INNER JOIN CP_AcademicYear AS DERV2 ON derv.AcademicCode=DERV2.AcademicCode");
                        objAcademicdetails = objDserv.GetDataset("IF (SELECT COUNT( *) FROM EXAM_NextSemGeneration) = 0  SELECT TOP 1 AcademicCode, CONCAT(FromYear, ' - ', ToYear) AS AcademicYear, FromYear, ToYear, frommonth, tomonth, frommonth AS AcademicMonth , FromYear AS CurrentYear FROM CP_AcademicYear ORDER BY AcademicCode DESC   ELSE   SELECT DERV.AcademicCode, CASE WHEN DERV.AcademicMonth = frommonth THEN ToYear ELSE FromYear END AS AcademicYear, FromYear, ToYear, frommonth, tomonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN tomonth ELSE frommonth END AS AcademicMonth,   CASE WHEN DERV.AcademicMonth = frommonth THEN ToYear ELSE FromYear END AS CurrentYear FROM   (SELECT TOP 1 AcademicCode, AcademicMonth FROM EXAM_NextSemGeneration ORDER BY AcademicCode DESC, AcademicMonth DESC)   DERV INNER JOIN CP_AcademicYear AS DERV2 ON derv.AcademicCode=DERV2.AcademicCode");

                        objDserv.CloseConnection();
                        if (objAcademicdetails != null) {
                            if (objAcademicdetails.Tables.Count > 0) {
                                MainForm.pbAcademicCode = Convert.ToInt16(objAcademicdetails.Tables[0].Rows[0]["AcademicCode"]);
                                MainForm.pbAcademicYear = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["AcademicYear"]);
                                MainForm.pbFromYear = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["FromYear"]);
                                MainForm.pbToYear = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["ToYear"]);
                                MainForm.pbFromMonth = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["frommonth"]);
                                MainForm.pbToMonth = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["tomonth"]);
                                MainForm.pbAcademicMonth = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["AcademicMonth"]);
                                MainForm.pbCurrentYear = Convert.ToString(objAcademicdetails.Tables[0].Rows[0]["CurrentYear"]);
                            }
                        }
                        DataSet objSchemeDetails = new DataSet();
                        objSchemeDetails = objDserv.GetDataset("SELECT TOP 1 SchemeName,SchemeCode FROM CP_Scheme WHERE ToYear IS NULL");
                        objDserv.CloseConnection();
                        if (objSchemeDetails != null)
                        {
                            if (objSchemeDetails.Tables.Count > 0)
                            {
                                if (objSchemeDetails.Tables[0].Rows.Count > 0)
                                {
                                    MainForm.pbSchemeCode = Convert.ToInt16(objSchemeDetails.Tables[0].Rows[0]["SchemeCode"]);
                                    MainForm.pbSchemeName = Convert.ToString(objSchemeDetails.Tables[0].Rows[0]["SchemeName"]);
                                }
                            }
                        }
                        this.Hide();
                        MainForm objMainForm = new MainForm();
                        objMainForm.Show();
                    }
                    else if (objDataset.Tables[0].Rows.Count == 0)
                    {
                        DialogResult objResponse = MessageBox.Show("User Name or Password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        txtUserName.Focus();
                    }
                }
                else
                {
                    // Validations
                    if (txtUserName.Text == "")
                    {
                        txtUserName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpUserName.Show("User Name is required", txtUserName, 5000);
                    }
                    else
                    {
                        tpUserName.Hide(txtUserName);
                    }
                    if (txtPassword.Text == "")
                    {
                        txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpPassword.Show("Password is required", txtPassword, 5000);
                    }
                    else
                    {
                        tpPassword.Hide(txtPassword);
                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        // ***** Check newer version with server *****
        public void checknewversion()
        {
            this.Enabled = false;
            try
            {
                DataService objDserv = new DataService();
                string varNewVersion = objDserv.displaydata("SELECT COALESCE( (select top (1) VersionNumber from TRANS_Release order by VersionNumber desc),'')");
                objDserv.CloseConnection();
                if (varNewVersion != lblDVersion.Text && varNewVersion != null && varNewVersion != "")
                {
                    DialogResult objDialogueResult = MessageBox.Show("A newer version of this software is available on the server. You need to upgrade. Click OK to continue, CANCEL to exit.", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (objDialogueResult == DialogResult.Cancel)
                    { this.Close(); }
                    else
                    {
                        string varPath = ""; string varSetupName = "";
                        DataSet objDs = new DataSet();
                        objDs = objDserv.GetDataset("select top 1 path,name from DEF_SharedFolderPath where pathcode=1 ");
                        objDserv.CloseConnection();
                        if (objDs != null)
                        {
                            if (objDs.Tables.Count > 0)
                            {
                                if (objDs.Tables[0].Rows.Count > 0)
                                {
                                    varPath = Convert.ToString(objDs.Tables[0].Rows[0]["path"]);
                                    varSetupName = Convert.ToString(objDs.Tables[0].Rows[0]["name"]) + " " + varNewVersion;
                                    System.IO.DirectoryInfo objDir = new System.IO.DirectoryInfo(varPath);
                                    foreach (System.IO.FileInfo varFile in objDir.GetFiles("*.*"))
                                    {
                                        if (varFile.Exists)
                                        {
                                            try
                                            {
                                                // Run .exe from server
                                                Process varProcess = new Process();
                                                varProcess.StartInfo.FileName = "msiexec";
                                                varProcess.StartInfo.Arguments = "/i " + varFile.FullName + "";
                                                varProcess.Start();
                                                System.Environment.Exit(1);
                                                varProcess.WaitForExit();
                                            }
                                            catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
                                            finally { this.Close(); }
                                        }
                                        else
                                        {
                                            DialogResult result = MessageBox.Show("File not uploaded in shared folder!", "Warning", MessageBoxButtons.OK);
                                            if (result == DialogResult.OK)
                                            {
                                                this.Close();
                                            }
                                            else { this.Close(); }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); this.Close(); }
            finally { this.Enabled = true; }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        public void Authentication_Load(object sender, EventArgs e)
        {
            // Check server settings file exists or not
            string paths = Application.StartupPath + "\\Server Settings\\serversettings.txt";
            if (File.Exists(paths))
            {
                //string regkey = "";
                //string varSerialNumber = "";
                //DataValidation obj = new DataValidation();
                //varSerialNumber = obj.baseId();
                //regkey = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(varSerialNumber)).Select(s => s.ToString("x2")));
                try
                {
                    //        string foldername = obj.Encrypt("Activation");
                    //        string path = Application.StartupPath + "\\"+ foldername;
                    //        // Check activation folder exists or not
                    //        if (Directory.Exists(path))
                    //        {
                    //            string encriptedtext = obj.Encrypt(string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(varSerialNumber)).Select(s => s.ToString("x2"))));
                    //            string[] files = Directory.GetFiles(path);
                    //            string filename = "";
                    //            foreach (string file in files)
                    //                filename = (Path.GetFileName(file));
                    //            string decryptedfile = obj.Decrypt(filename.Replace(".sss", ""));
                    //            // Check activation file exists or not
                    //            if (decryptedfile == "Activation")
                    //            {
                    //                path = path + "\\" + filename;
                    //                FileInfo info = new FileInfo(path);
                    //                if (info.Exists)
                    //                {
                    //                    var fileContents = System.IO.File.ReadAllText(path);
                    //                    string[] values = fileContents.Replace("\r", "").Split('\n');
                    //                    // Check internet connection
                    //                    if (obj.internetconnection() == true)
                    //                    {
                    //                        if (values.Length > 0)
                    //                        {
                    //                            ActivationService.ActivationService activser = new ActivationService.ActivationService();
                    //                            string rs = ""; string st = "";
                    //                            string key = obj.Decrypt(values[0]);
                    //                            string otp = obj.Decrypt(values[1]);
                    //                            string customername = obj.Decrypt(values[2]);
                    //                            string mobileno = obj.Decrypt(values[3]);
                    //                            string emailid = obj.Decrypt(values[4]);
                    //                            string address = obj.Decrypt(values[5]);
                    //                            rs = activser.udfnAuthenticate(customername, mobileno, emailid, address, key, "", otp, "15");
                    //                            if (rs == "Success" || rs == "Activated")
                    //                            {
                    //                                st = "success";
                    //                            }
                    //                            else if (rs == "Blocked")
                    //                            {
                    //                                st = "error";
                    //                            }
                    //                            else { st = ""; rs = ""; }
                    //                            if (st == "error" || st == "")
                    //                            {
                    //                                this.Close(); Application.Run(new Activation());
                    //                            }
                    //                            else { goto lbl; }
                    //                        }
                    //                        else { goto lbl; }
                    //                    }
                    //                    else
                    //                    {
                    //                        if (encriptedtext == (values[0]))
                    //                        {
                    //                            goto lbl;
                    //                        }
                    //                        else { this.Close(); Application.Run(new Activation()); }
                    //                    }
                    //                }
                    //                else { this.Close(); Application.Run(new Activation()); }
                    //            }
                    //            else { this.Close(); Application.Run(new Activation()); }
                    //        }
                    //        else { this.Close(); Application.Run(new Activation()); }

                    lbl:  lblDVersion.Text = "v1.8.27";
                    lblDVersion.BringToFront();
                    Authentication objAuthetication = new Authentication();
                    objAuthetication.Name = "Exam Cell - "+lblDVersion.Text;
                    //checknewversion();
                    //txtUserName.AutoSize = false;
                    //txtUserName.Size = new System.Drawing.Size(256, 32);
                    //txtPassword.AutoSize = false;
                    //txtPassword.Size = new System.Drawing.Size(256, 32);
                }
                catch (Exception ex)
                {
                  //  checknewversion();
                }
            }
            else { Application.Run(new ServerSettings()); }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        public void udfnclose()
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void Authentication_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    udfnclose();
                }
               
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                udfnclose();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try {
               this.Hide();
                ServerSettings obj = new ServerSettings();
                obj.lblformname.Text = "login";
                obj.Show();
            } catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
        }
    }
}
