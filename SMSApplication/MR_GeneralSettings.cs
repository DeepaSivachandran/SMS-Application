using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMSApplication.ServiceClass;
using System.IO;

namespace SMSApplication
{
    public partial class MR_GeneralSettings : Form
    {
        // Author : DEEPA
        // Created Date: 01/06/2019

        //********* Object for Service Classed Initialisation ***********
        DataValidation objValidation = new DataValidation();
        DataError objError;

        //**************Tooltips Initialization ***************
        private ToolTip tpOldPwd = new ToolTip();
        private ToolTip tpNewPwd = new ToolTip();
        private ToolTip tpConfirmPwd = new ToolTip();

        private SecurityController _security = new SecurityController();

        //Declare public variable
        public int pbCharCount = 0;
        public string pbPwdType = "";

        public MR_GeneralSettings()
        {
            InitializeComponent();
            //************ Form Resolution **************
            objValidation.resolutionsettingsForm(this);
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void MR_GeneralSettings_Load(object sender, EventArgs e)
        {
            try
            {     
                //***************Load password settings details******************
                DataSet objDs = new DataSet();
                DataService objDser = new DataService();
                objDs = objDser.GetDataset("SELECT TOP 1 [No.of.Chars], PasswordType FROM DEF_PasswordSettings WHERE StatusCode = 1 ORDER BY Autonum DESC");
                objDser.CloseConnection();
                if (objDs != null)
                {
                    if (objDs.Tables.Count > 0)
                    {
                        pbCharCount = Convert.ToInt16(objDs.Tables[0].Rows[0]["No.of.Chars"]);
                        pbPwdType = Convert.ToString(objDs.Tables[0].Rows[0]["PasswordType"]);
                    }
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        private void MR_GeneralSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.F5)
                {
                    btnSave_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void txtConfirmPwd_Enter(object sender, EventArgs e)
        {
            try
            {
                txtConfirmPwd.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void txtConfirmPwd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
                if (e.Control && (e.KeyCode == Keys.A))
                {
                    if (sender != null)
                        ((TextBox)sender).SelectAll();
                    e.Handled = true;
                }
                if (e.KeyData == (Keys.Control | Keys.V))
                {
                    (sender as TextBox).Paste();
                }
                if (e.KeyData == (Keys.Control | Keys.C))
                {
                    (sender as TextBox).Copy();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void txtConfirmPwd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmPwd.Text == "")
                {
                    epMR_GeneralSettings.SetError(txtConfirmPwd, "Please enter confirm password");
                    txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Please enter confirm password", txtConfirmPwd, 5000);
                }
                else {
                    epMR_GeneralSettings.Clear();
                    txtConfirmPwd.BackColor = Color.White;
                }               
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        // Author : DEEPA
        // Created Date: 01/06/2019
        //********* get form close confirmation **********
        public void udfnclose()
        {
            try
            {
                udfnclear();
                DialogResult objDialogResult = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (objDialogResult == DialogResult.Yes)
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
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                udfnclose();
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void MR_GeneralSettings_Leave(object sender, EventArgs e)
        {
            try
            {
                udfnclear();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }      
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void txtNewPwd_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtConfirmPwd.Focus();
                }
                if (e.Control && (e.KeyCode == Keys.A))
                {
                    if (sender != null)
                        ((TextBox)sender).SelectAll();
                    e.Handled = true;
                }
                if (e.KeyData == (Keys.Control | Keys.V))
                {
                    (sender as TextBox).Paste();
                }
                if (e.KeyData == (Keys.Control | Keys.C))
                {
                    (sender as TextBox).Copy();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        private void txtNewPwd_Enter(object sender, EventArgs e)
        {
            try
            {
                txtNewPwd.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : DEEPA
        // Created Date: 01/06/2019
        //*********** Save password **********
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                btnSave.Enabled = false;
                bool blnErrorFlag = false; 
                if (txtNewPwd.Text == "")
                {
                    epMR_GeneralSettings.SetError(txtNewPwd, "Please enter new password");
                    txtNewPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpNewPwd.ShowAlways = true;
                    tpNewPwd.Show("Please enter new password", txtNewPwd, 5000);
                    blnErrorFlag = true;
                }
                else
                {
                    epMR_GeneralSettings.Clear();
                    txtNewPwd.BackColor = Color.White;
                }
                if (txtConfirmPwd.Text == "")
                {
                    epMR_GeneralSettings.SetError(txtConfirmPwd, "Please enter confirm password");
                    txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Please enter confirm password", txtConfirmPwd, 5000);
                    blnErrorFlag = true;
                }
                else
                {
                    epMR_GeneralSettings.Clear();
                    txtConfirmPwd.BackColor = Color.White;
                }
                bool varSetting = true;
                if (pbCharCount != 0)
                {
                    if (pbCharCount > txtNewPwd.Text.Length)
                    {
                        epMR_GeneralSettings.SetError(txtNewPwd, "Password length should be minimum " + pbCharCount + " charaters.");
                        txtNewPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password length should be minimum " + pbCharCount + " charaters.", txtNewPwd, 5000);
                        blnErrorFlag = true;
                        varSetting = false;
                    }
                    else
                    {
                        epMR_GeneralSettings.Clear();
                        txtNewPwd.BackColor = Color.White;
                        if (pbPwdType != "")
                        {
                            if (pbPwdType == "AN")
                            {
                                //  A- alphabet N- Numeric
                                varSetting = txtNewPwd.Text.Any(c => char.IsLetter(c)) && txtNewPwd.Text.Any(c => char.IsDigit(c));
                            }
                            else if (pbPwdType == "SCAN")
                            {
                                // S- Symbol C- Capital A- alphabet N- Numeric
                                varSetting = txtNewPwd.Text.Any(c => char.IsLetter(c)) && txtNewPwd.Text.Any(c => char.IsDigit(c)) && txtNewPwd.Text.Any(c => char.IsSymbol(c)) && txtNewPwd.Text.Any(c => char.IsUpper(c));
                            }
                        }
                    }
                }
                if (varSetting == true)
                {
                    epMR_GeneralSettings.Clear();
                    tpNewPwd.BackColor = Color.White;
                }
                else
                {
                    if (pbPwdType == "AN")
                    {
                        //  A- alphabet N- Numeric
                        epMR_GeneralSettings.SetError(txtNewPwd, "Password should contain alpha numeric charaters.");
                        txtNewPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password should contain alpha numeric charaters.", txtNewPwd, 5000);
                    }
                    else if (pbPwdType == "SCAN")
                    {
                        // S- Symbol C- Capital A- alphabet N- Numeric
                        epMR_GeneralSettings.SetError(txtNewPwd, "Password should contain atleast one symbol, capital, alphabet and numeric charater.");
                        txtNewPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password should contain atleast one symbol, capital, alphabet and numeric charater.", txtNewPwd, 5000);
                    }
                    blnErrorFlag = true;
                }
                if (txtConfirmPwd.Text != txtNewPwd.Text)
                {
                    epMR_GeneralSettings.SetError(txtConfirmPwd, "Password mismatched");
                    txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Password mismatched", txtConfirmPwd, 5000);
                    blnErrorFlag = true;
                }
                else {
                    epMR_GeneralSettings.Clear();
                    txtConfirmPwd.BackColor = Color.White;
                }
                if (blnErrorFlag == false) {
                    ////create the object and access wcf 
                    //MR_GeneralSettingsService.MR_GeneralSettingsService objChangePassword = new MR_GeneralSettingsService.MR_GeneralSettingsService();
                    ////pass data to wcf and get the result
                    //string varResult = objChangePassword.udfn_MR_GeneralSettings(_security.Encrypt(MainForm.pbUserID,txtOldPwd.Text), _security.Encrypt(MainForm.pbUserID, txtNewPwd.Text),MainForm.pbUserID,MainForm.pbIpAddress,"Change Password");
                    //if (varResult.Contains("Success"))
                    //{
                    //    MessageBox.Show(varResult, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //   // Clear all controls in form
                    //    udfnclear();
                    //    txtOldPwd.Focus();
                    //}
                    //else
                    //{
                    //    MessageBox.Show(varResult, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    txtOldPwd.Focus();
                    //}
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally {
                btnSave.Enabled = true;
            }
        }
        // Author : Deepa
        // Created Date: 2019-06-01
        // Clear Data
        public void udfnclear()
        {
            try
            {
                tpOldPwd.Active = false; 
                tpConfirmPwd.Active = false;
                txtConfirmPwd.BackColor = Color.White;
                tpNewPwd.Active = false;
                txtNewPwd.BackColor = Color.White; 
                txtNewPwd.Text = "";
                txtConfirmPwd.Text = "";
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
    }
}
