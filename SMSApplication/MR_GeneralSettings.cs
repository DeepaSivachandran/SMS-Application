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
using System.Text.RegularExpressions;

namespace SMSApplication
{
    public partial class MR_GeneralSettings : Form
    {
        // Author : Lavanya
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void MR_GeneralSettings_Load(object sender, EventArgs e)
        {
            try
            {
                //***************Load password settings details******************

                udfnlist();
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
        public void udfnlist() {

            DataService objdataservice = new DataService();
            string  numbers = "0";
            numbers = objdataservice.displaydata("Select ST_TOCONTACTNO from MR_Settings");

            if (numbers.Length > 0)
            {
                txtStaffReportnumber.Text = numbers;
            }
                objdataservice.CloseConnection();
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void txtNewPwd_KeyDown(object sender, KeyEventArgs e)
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
        // Author : Lavanya
        // Created Date: 01/06/2019
        //*********** Save password **********
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (txtStaffReportnumber.Text != "")
                {

                    epMR_GeneralSettings.Clear(); 
                    txtStaffReportnumber.BackColor = Color.White;
                    SPDataService objspdservice = new SPDataService();
                    DataService objdataservice = new DataService();
                    string result = "", id = "0";
                    id = objdataservice.displaydata("Select count(st_id) from MR_Settings");

                    string input = txtStaffReportnumber.Text.Trim();

                    // Define the regular expression pattern
                    string pattern = @"^\d{10}(,\d{10})*$";
                    string pattern1 = @"^\d{10},$";
                    // Check if the input matches the pattern
                    bool inputvalue = Regex.IsMatch(input, pattern); 
                    bool inputvalue1 = Regex.IsMatch(input, pattern1);



                    if (inputvalue || inputvalue1 || input.Length==10)
                    {
                        if (btnSave.Text == "Update")
                        {
                            result = objspdservice.udfngenralsettings("Create", id, input, MainForm.pbUserID, "staff mobile number Entry");
                        }


                        if (result.Contains("Saved Successfully.") || result.Contains("Updated Successfully."))
                        {
                            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            udfnclear();
                        }
                        else
                        {
                            MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else {
                        epMR_GeneralSettings.SetError(txtStaffReportnumber, "Please enter the Valid staff number.");
                        txtStaffReportnumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please enter the valid staff number.", txtStaffReportnumber, 5000);
                    }

                    objdataservice.CloseConnection();
                    objspdservice.CloseConnection();
                }
                else
                {
                    if (txtStaffReportnumber.Text == "")
                    {
                        epMR_GeneralSettings.SetError(txtStaffReportnumber, "Please enter the Report staff number.");
                        txtStaffReportnumber.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please enter the Report staff number.", txtStaffReportnumber, 5000);
                    }
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
        // Author : Lavanya
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

        private void txtStaffReportnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                // Ignore the key press event
                e.Handled = true;
            }

        }

        private void txtStaffReportnumber_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
