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
using System.Security.Cryptography;
using System.IO;

namespace SMSApplication
{
    public partial class MR_StudentWipout : Form
    {
        // Author : Lavanya
        // Created Date: 01/06/2019

        //********* Object for Service Classed Initialisation ***********
        DataValidation objValidation = new DataValidation();
        DataError objError;

        private SecurityController _security;
        //**************Tooltips Initialization ***************
        private ToolTip tpOldPwd = new ToolTip();
        private ToolTip tpNewPwd = new ToolTip();
        private ToolTip tpConfirmPwd = new ToolTip();
         

        //Declare public variable
        public int pbCharCount = 0;
        public string pbPwdType = "";

        public MR_StudentWipout()
        {
            InitializeComponent();
            //************ Form Resolution ************** 
            _security = new SecurityController();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void CP_ChangePassword_Load(object sender, EventArgs e)
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void CP_ChangePassword_KeyDown(object sender, KeyEventArgs e)
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
        // Author : Lavanya
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
        // Author : Lavanya
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void txtConfirmPwd_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirmPwd.Text == "")
                {
                    epCP_ChangePassword.SetError(txtConfirmPwd, "Please enter confirm password");
                    txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Please enter confirm password", txtConfirmPwd, 5000);
                }
                else {
                    epCP_ChangePassword.Clear();
                    txtConfirmPwd.BackColor = Color.White;
                }               
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        // Author : Lavanya
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
        // Author : Lavanya
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void CP_ChangePassword_Leave(object sender, EventArgs e)
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
        // Author : Lavanya
        // Created Date: 01/06/2019
      
        // Author : Lavanya
        // Created Date: 01/06/2019
        //*********** Save password **********
        private void btnSave_Click(object sender, EventArgs e)
        {
        } 
        public void udfnclear()
        {
            try
            {
                tpOldPwd.Active = false;
                tpConfirmPwd.Active = false;
                txtConfirmPwd.BackColor = Color.White;
                tpNewPwd.Active = false;
                txtConfirmPwd.Text = "";
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            try
            {
                btnSave.Enabled = false;
                bool blnErrorFlag = false;

                if (txtConfirmPwd.Text == "")
                {
                    epCP_ChangePassword.SetError(txtConfirmPwd, "Please enter Admin password");
                    txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Please enter confirm password", txtConfirmPwd, 5000);
                    blnErrorFlag = true;
                }
                else
                {
                    epCP_ChangePassword.Clear();
                    txtConfirmPwd.BackColor = Color.White;
                }
                bool varSetting = true;
                if (pbCharCount != 0)
                {
                    if (pbCharCount > txtConfirmPwd.Text.Length)
                    {
                        epCP_ChangePassword.SetError(txtConfirmPwd, "Password length should be minimum " + pbCharCount + " charaters.");
                        txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password length should be minimum " + pbCharCount + " charaters.", txtConfirmPwd, 5000);
                        blnErrorFlag = true;
                        varSetting = false;
                    }
                    else
                    {
                        epCP_ChangePassword.Clear();
                        txtConfirmPwd.BackColor = Color.White;
                        if (pbPwdType != "")
                        {
                            if (pbPwdType == "AN")
                            {
                                //  A- alphabet N- Numeric
                                varSetting = txtConfirmPwd.Text.Any(c => char.IsLetter(c)) && txtConfirmPwd.Text.Any(c => char.IsDigit(c));
                            }
                            else if (pbPwdType == "SCAN")
                            {
                                // S- Symbol C- Capital A- alphabet N- Numeric
                                varSetting = txtConfirmPwd.Text.Any(c => char.IsLetter(c)) && txtConfirmPwd.Text.Any(c => char.IsDigit(c)) && txtConfirmPwd.Text.Any(c => char.IsSymbol(c)) && txtConfirmPwd.Text.Any(c => char.IsUpper(c));
                            }
                        }
                    }
                }
                if (varSetting == true)
                {
                    epCP_ChangePassword.Clear();
                    tpNewPwd.BackColor = Color.White;
                }
                else
                {
                    if (pbPwdType == "AN")
                    {
                        //  A- alphabet N- Numeric
                        epCP_ChangePassword.SetError(txtConfirmPwd, "Password should contain alpha numeric charaters.");
                        txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password should contain alpha numeric charaters.", txtConfirmPwd, 5000);
                    }
                    else if (pbPwdType == "SCAN")
                    {
                        // S- Symbol C- Capital A- alphabet N- Numeric
                        epCP_ChangePassword.SetError(txtConfirmPwd, "Password should contain atleast one symbol, capital, alphabet and numeric charater.");
                        txtConfirmPwd.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpNewPwd.ShowAlways = true;
                        tpNewPwd.Show("Password should contain atleast one symbol, capital, alphabet and numeric charater.", txtConfirmPwd, 5000);
                    }
                    blnErrorFlag = true;
                }

                if (blnErrorFlag == false)
                {

                    DataService objDataService = new DataService();
                    string varcount = "", result = "";
                    varcount = objDataService.displaydata("SELECT COUNT(*) FROM MR_User WHERE UM_Password='" + _security.Encrypt(MainForm.pbUsername, txtConfirmPwd.Text) + "'");
                    objDataService.CloseConnection();
                    if (varcount != "0")
                    {
                        SPDataService objspdservice = new SPDataService();
                        result = objspdservice.udfnStudentMaster("Wipeout", "", "", "", "", "", "", "", "", MainForm.pbUserID, "", "Wipout student", "", "", "", "", "", "", "", "");
                        if (result.Contains("Wipout Successfully."))
                        {
                            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MainForm.objMR_StudentsList.udfnList();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password mismatch", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_KeyDown(object sender, KeyEventArgs e)
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
    }
}
