
 
using SMSApplication.ServiceClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApplication
{
    public partial class Activation : Form
    {
        Authentication objAuth = new Authentication();
        DataValidation objValidation = new DataValidation();
        DataError objError;
        private ToolTip tpMobileNo = new ToolTip();
        private ToolTip tpEmailId = new ToolTip();
        public Activation()
        {
            InitializeComponent();
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        // ********** String Encryption **********
        public string GenerateMD5(string HashString)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(HashString)).Select(s => s.ToString("x2")));
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string varSerialNumber = "";
                // Generate Registration key
                varSerialNumber = objValidation.baseId();
                txtRegistrationKey.Text = GenerateMD5( varSerialNumber);
                DataService objDserv = new DataService();
                string varFolderName = objValidation.Encrypt("Activation");
                string varPath = Application.StartupPath + "\\"+ varFolderName;
                // Check activation folder exists
                if (Directory.Exists(varPath))
                {
                    string varEncryptedText = objValidation.Encrypt(string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(varSerialNumber)).Select(s => s.ToString("x2"))));
                    string[] varFiles = Directory.GetFiles(varPath);
                    string varFileName = "";
                    foreach (string varFile in varFiles)
                        varFileName = (Path.GetFileName(varFile));
                    string varDecryptedFile = objValidation.Decrypt(varFileName.Replace(".sss", ""));
                    // Check activation file exists
                    if (varDecryptedFile == "Activation")
                    {
                        varPath = varPath + "\\" + varFileName;
                        FileInfo varInfo = new FileInfo(varPath);
                        if (varInfo.Exists)
                        {
                            var varFileContents = System.IO.File.ReadAllText(varPath);
                            string[] varValues = varFileContents.Replace("\r", "").Split('\n');
                            if (objValidation.internetconnection() == true)
                            {
                                if (varValues.Length > 1)
                                {
                                 
                                    ActivationService.ActivationService objActivationService = new ActivationService.ActivationService();
                                    string varResult = ""; string varStatus = "";
                                    string varKey = objValidation.Decrypt(varValues[0]);
                                    string varOTP = objValidation.Decrypt(varValues[1]);
                                    string varCustomerName = objValidation.Decrypt(varValues[2]);
                                    string varMobileNo = objValidation.Decrypt(varValues[3]);
                                    string varEmailId = objValidation.Decrypt(varValues[4]);
                                    string varAddress = objValidation.Decrypt(varValues[5]);
                                    // Check registration key with cloud database
                                    varResult = objActivationService.udfnAuthenticate(varCustomerName, varMobileNo, varEmailId, varAddress, varKey, "", varOTP, "29");
                                    if (varResult == "Success" || varResult == "Activated")
                                    {
                                        varStatus = "success";
                                    }
                                    else if (varResult == "Blocked")
                                    {
                                        varStatus = "error";
                                    }
                                    else { varStatus = ""; varResult = ""; }
                                    if (varStatus == "error" || varStatus == "")
                                    {
                                        if (varResult == "Blocked") { MessageBox.Show("You are a blocked User, cant able to use this product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }
                                        this.Close();
                                    }
                                    else
                                    {
                                        Application.EnableVisualStyles();
                                        Application.SetCompatibleTextRenderingDefault(false);
                                        Application.Run(new Authentication());
                                        //this.Hide();
                                        //objAuth.Show();
                                    }
                                }
                            }
                            //else
                            //{
                            //    if (varEncryptedText == (varValues[0]))
                            //    {
                            //        //Application.EnableVisualStyles();
                            //        //Application.SetCompatibleTextRenderingDefault(false);
                            //        ////Application.Run(new Expandablegrd());
                            //        //Application.Run(new Authentication());
                            //        this.Close(); Application.Run(new Authentication());
                            //    }
                            //}
                        }
                    }
                }
                //if (objValidation.internetconnection() == false)
                //{
                //    lblNetwork.Text = "Off";
                //    btnGetOtp.Enabled = false;
                //}
                //else
                //{
                //    lblNetwork.Text = "On";
                //    btnGetOtp.Enabled = true;
                //}
            }
            catch(Exception ex)
            {
                //objError = new DataError();
                //objError.WriteFile(ex);
                //lblNetwork.Text = "Off";
                //btnGetOtp.Enabled = false;
                ////MessageBox.Show(ex.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void btnGetOtp_Click(object sender, EventArgs e)
        {
            try
            {
                txtOTP.Text = "";
                if (txtMobileNo.Text != "" && txtEmailId.Text != "")
                {
                    // Check internet connection
                    if (objValidation.internetconnection() == false)
                    {
                        MessageBox.Show("No Network Connection, Please Check your Internet Connection", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        // Get OTP from cloud server
                   
                        ActivationService.ActivationService objActivationService = new ActivationService.ActivationService();
                        objActivationService.udfngetOTPForProduct(txtCustomerName.Text, txtMobileNo.Text, txtEmailId.Text, txtAddress.Text, txtRegistrationKey.Text, "v1.0.0", "29");
                        MessageBox.Show("OTP sent successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Validations
                    if (txtMobileNo.Text == "")
                    {
                        errorProvider1.SetError(txtMobileNo, "This field is required");
                        txtMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpMobileNo.ShowAlways = true;
                        tpMobileNo.Show("This field is required", txtMobileNo);
                    }
                    else if (txtMobileNo.Text != "" && objValidation.FormatNumeric(txtMobileNo.Text) == false && txtMobileNo.Text.Length <= 10)
                    {
                        errorProvider1.SetError(txtMobileNo, "Please enter correctMobile No.");
                        txtMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpMobileNo.ShowAlways = true;
                        tpMobileNo.Show("Please enter correctMobile No.", txtMobileNo);
                        txtMobileNo.Text = "";
                        txtMobileNo.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();
                        txtMobileNo.BackColor = Color.White;
                        tpMobileNo.Hide(txtMobileNo);
                    }
                    if (txtEmailId.Text == "")
                    {
                        errorProvider1.SetError(txtEmailId, "This field is required");
                        txtEmailId.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpEmailId.ShowAlways = true;
                        tpEmailId.Show("This field is required", txtMobileNo);
                    }
                    else if (txtEmailId.Text != "" && objValidation.FormatEMail(txtEmailId.Text) == false)
                    {
                        errorProvider1.SetError(txtEmailId, "Please enter correctEmailID");
                        txtEmailId.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpEmailId.ShowAlways = true;
                        tpEmailId.Show("Please enter correctEmailID", txtEmailId);

                        txtEmailId.Text = "";
                        txtEmailId.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();
                        txtEmailId.BackColor = Color.White;
                        tpEmailId.Hide(txtEmailId);
                    }
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
                MessageBox.Show(ex.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        // ***** Create activation text file in local machine *****
        // Author : Deepa
        // Created Date: 2019-04-06
        public void CreateFile(string varFilePath, string varCustomerName, string varMobileNo, string varEmailId, string varAddress, string varOTP, string varEncryptedText)
        {
            try
            {
                udfn_DeleteFile(varFilePath);
                var varTextWritten = varEncryptedText + Environment.NewLine + objValidation.Encrypt(varOTP) + Environment.NewLine + objValidation.Encrypt(varCustomerName) + Environment.NewLine + objValidation.Encrypt(varMobileNo) + Environment.NewLine + objValidation.Encrypt(varEmailId) + Environment.NewLine + objValidation.Encrypt(varAddress);
                if (!File.Exists(varFilePath))
                {
                    var varFileStream =  File.Create(varFilePath);
                    varFileStream.Close();                 
                    TextWriter objTextWriter = new StreamWriter(varFilePath);
                    objTextWriter.WriteLine(varTextWritten);
                    objTextWriter.Close();
                }
            }
            catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
        }
        // ***** delete activation Text file from local machine *****
        public void udfn_DeleteFile(string varFilePAth)
        {
            try
            {
                FileInfo objInfo = new FileInfo(varFilePAth);
                if (objInfo.Exists) { System.IO.File.Delete(varFilePAth); }
            }
            catch (Exception ex) { }
        }        // Author : Deepa
        // Created Date: 2019-04-06
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string varResult = "";
                string varSerialNumber = "";
                varSerialNumber = objValidation.baseId();
                // check internet connection
                if (objValidation.internetconnection() == false)
                {
                    MessageBox.Show("No Network Connection, Please Check your Internet Connection", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    // Check OTP with cloud server
                    ActivationService.ActivationService objActivationService = new ActivationService.ActivationService();
                    varResult = objActivationService.udfnAuthenticate(txtCustomerName.Text, txtMobileNo.Text, txtEmailId.Text, txtAddress.Text, txtRegistrationKey.Text, "1.0.0", txtOTP.Text,"29");                   
                    if (varResult == "Success")
                    {
                        string path = Application.StartupPath + "\\"+ objValidation.Encrypt("Activation");
                        if (!Directory.Exists(path))
                        { Directory.CreateDirectory(path); }
                        string filename = objValidation.Encrypt("Activation");
                        string filepath = path + "\\" + filename + ".sss";
                        string encriptedtext = objValidation.Encrypt(string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(varSerialNumber)).Select(s => s.ToString("x2"))));
                        CreateFile(filepath, txtCustomerName.Text, txtMobileNo.Text,txtEmailId.Text, txtAddress.Text, txtOTP.Text, encriptedtext);
                        this.Hide();
                        objAuth.Show();
                    }
                    if (varResult == "Blocked")
                    {
                        MessageBox.Show("You are a blocked user, cant access this Product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        this.Close();
                    }
                    if (varResult == "Activated")
                    {
                        this.Hide();
                        objAuth.Show();
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString(), "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtotp_Leave(object sender, EventArgs e)
        {
            try
            {
                txtOTP.BackColor = Color.White;
                if (txtOTP.Text!="")
                {
                    btnSubmit.Enabled = true;
                }
                else
                {
                    btnSubmit.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void Form1_Leave(object sender, EventArgs e)
        {
            tpMobileNo.Active = false;
            tpEmailId.Active = false;
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtotp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtOTP.Text.Length==6)
                {
                    btnSubmit.Enabled = true;
                }
                else
                {
                    btnSubmit.Enabled = false;
                }

            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtotp_Enter(object sender, EventArgs e)
        {

            try
            {
                txtOTP.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtotp_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                   
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtName_Enter(object sender, EventArgs e)
        {

            try
            {
                txtCustomerName.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtMobile_Enter(object sender, EventArgs e)
        {
            try
            {
                txtMobileNo.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            try
            {
                txtEmailId.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtAddress_Enter(object sender, EventArgs e)
        {
            try
            {
                txtAddress.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtName_Leave(object sender, EventArgs e)
        {
            try
            {
                txtCustomerName.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtMobile_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtMobileNo.Text == "")
                {
                    errorProvider1.SetError(txtMobileNo, "This field is required");
                    txtMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpMobileNo.ShowAlways = true;
                    tpMobileNo.Show("This field is required", txtMobileNo);
                }
                else if (txtMobileNo.Text != "" && objValidation.FormatNumeric(txtMobileNo.Text) == false && txtMobileNo.Text.Length <= 10)
                {
                    errorProvider1.SetError(txtMobileNo, "Please enter correctMobile No.");
                    txtMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpMobileNo.ShowAlways = true;
                    tpMobileNo.Show("Please enter correctMobile No.", txtMobileNo);
                    //txtMobile.Text = "";
                    txtMobileNo.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    txtMobileNo.BackColor = Color.White;
                    tpMobileNo.Hide(txtMobileNo);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtEmailId.Text == "")
                {
                    errorProvider1.SetError(txtEmailId, "This field is required");
                    txtEmailId.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpEmailId.ShowAlways = true;
                    tpEmailId.Show("This field is required", txtMobileNo);
                }
                else if (txtEmailId.Text != "" && objValidation.FormatEMail(txtEmailId.Text) == false)
                {
                    errorProvider1.SetError(txtEmailId, "Please enter correctEmailID");
                    txtEmailId.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpEmailId.ShowAlways = true;
                    tpEmailId.Show("Please enter correctEmailID", txtEmailId);

                    //txtEmail.Text = "";
                    txtEmailId.Focus();
                }
                else
                {
                    errorProvider1.Clear();
                    txtEmailId.BackColor = Color.White;
                    tpEmailId.Hide(txtEmailId);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtAddress_Leave(object sender, EventArgs e)
        {
            try
            {
                txtAddress.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobileNo.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtEmailId.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtAddress.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtotp_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnGetOtp.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                ServerSettings objServerSettigs = new ServerSettings();
                objServerSettigs.lblformname.Text = "activation";
                objServerSettigs.Show();
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }        // Author : Deepa
        // Created Date: 2019-04-06
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                bool varResult = objValidation.CheckSpecialCharacter(e);
                if (varResult == true) { e.Handled = true; } else { e.Handled = false; }
            } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
    }
    }

