using SMSApplication.ServiceClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SMSApplication
{
    public partial class MR_Staff : Form
    {
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();
        //  **********Tooltip Initialisation**********
        private ToolTip tpSchemeName = new ToolTip();
        private ToolTip tpShortName = new ToolTip();
         
        //********* Declare the variable*************
        public string pbflag="0",pbFromYear="", VARSTAFFCODE = "";
        public MR_Staff()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void MR_Staff_Load(object sender, EventArgs e)
        {
            try
            {
                DataBind objDataBind = new DataBind();
                objDataBind.BindComboBoxListSelected("MR_BloodGroup", " Bg_Code Not in (0) Order by Bg_Code", "BG_Name,Bg_Code", cmbBloodGroup, "", "BG_Name", "Bg_Code");
                objDataBind.BindComboBoxListSelected("MR_Designation", " dn_Code Not in (0) Order by dn_Code", "DN_Name,DN_Code", cmbdesignation, "", "DN_Name", "DN_Code");
                objDataBind = null;
                udfnEdit();
                if (btnSave.Text == "Update")
                {
                    //******** if form is in update mode status will be show **********
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                 //   MainForm.objMR_Staff.Text = "Edit Scheme";
                    //********** combobox Enable & disable ***************  
                } 
                this.ActiveControl = txtStaffName;      
             }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void udfnEdit()
        {
            try
            {
                if (VARSTAFFCODE != "")
                {
                    SPDataService objspservice = new SPDataService();
                    DataSet objDS;
                    objDS = objspservice.udfnStaffMasterLIST("Editload", VARSTAFFCODE, MainForm.pbUserID);
                    objspservice.CloseConnection();
                    string staffstatus = "0";
                    if (objDS != null)
                    {
                        if (objDS.Tables[0].Rows.Count > 0)
                        {
                            txtStaffName.Text = objDS.Tables[0].Rows[0]["name"].ToString() ;
                            txtMobileNo.Text = objDS.Tables[0].Rows[0]["mobile"].ToString() ; 
                            dpFromDate.Text = objDS.Tables[0].Rows[0]["dob"].ToString();
                            cmbBloodGroup.SelectedValue= objDS.Tables[0].Rows[0]["bloodgroup"].ToString(); 
                            cmbdesignation.SelectedValue = objDS.Tables[0].Rows[0]["designation"].ToString();
                            txtAddress.Text = objDS.Tables[0].Rows[0]["address1"].ToString();
                            txtAddress2.Text = objDS.Tables[0].Rows[0]["address2"].ToString();
                            textAddress3.Text = objDS.Tables[0].Rows[0]["address3"].ToString();
                            txtpincode.Text = objDS.Tables[0].Rows[0]["PinCode"].ToString(); 
                            txtcity.Text = objDS.Tables[0].Rows[0]["City"].ToString() ;
                            staffstatus= objDS.Tables[0].Rows[0]["STATUS"].ToString();
                           txtRfCardno.Text= objDS.Tables[0].Rows[0]["rfidno"].ToString();
                            if (staffstatus == "1")
                            {
                                rbActive.Checked = true; ;
                            }
                            else {
                                rbInActive.Checked = true;
                            }

                            btnSave.Text = "Update";
                        }
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

            }
        }

        // Author : Venkat
        // Created Date: 16/05/2023
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                pbflag ="1";
                udfnClose();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        public void udfnClose()
        {
            try
            {
                epMR_Staff.Clear();
                tpSchemeName.Active = false;
                txtStaffName.BackColor = Color.White;
                DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        // Author : Venkat
        // Created Date: 16/05/2023
        private void txtSchemeName_Enter(object sender, EventArgs e)
        {
            try
            {
              
                txtStaffName.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void MR_Staff_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    pbflag = "1";
                    udfnClose();
                }
                if (e.KeyCode == Keys.F5)
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
        // Author : Venkat
        // Created Date: 16/05/2023
        private void txtSchemeName_Leave(object sender, EventArgs e)
        {
            try
            {

                txtStaffName.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void cmbFromYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void rbActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void rbInActive_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSave.Focus();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        //************ Save data *************
        private void btnSave_Click(object sender, EventArgs e)
        {            
            try
            {
                btnSave.Enabled = false;
                udfnsave();
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

        // Author : Venkat
        // Created Date: 16/05/2023
        //************ Save data *************
        public void udfnsave()
        {
            if (Convert.ToInt32(cmbBloodGroup.SelectedValue) != -1 && Convert.ToString(cmbdesignation.SelectedValue) != "-1" && txtStaffName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "" && txtpincode.Text !="" && txtcity.Text !="" && txtRfCardno.Text!="")
            {

                epMR_Staff.Clear();
                txtStaffName.BackColor = Color.White;
                txtMobileNo.BackColor = Color.White;
                txtAddress.BackColor = Color.White;
                cmbBloodGroup.BackColor = Color.White;
                txtpincode.BackColor = Color.White;
                txtcity.BackColor = Color.White; 
                cmbdesignation.BackColor = Color.White;
                SPDataService objspdservice = new SPDataService();

                string result = "",status="0";

                if (rbActive.Checked == true)
                {
                    status = "1";
                }
                else {

                    status = "0";
                }
                if (btnSave.Text == "Save")
                {
                    result = objspdservice.udfnStaffMaster("Create", "0", txtStaffName.Text, txtMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbdesignation.SelectedValue.ToString(), MainForm.pbUserID, status,"Staff Create",txtAddress.Text,txtAddress2.Text,textAddress3.Text, txtcity.Text,txtpincode.Text, txtRfCardno.Text,"1");

                }

                else
                {
                    result = objspdservice.udfnStaffMaster("edit", VARSTAFFCODE, txtStaffName.Text, txtMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbdesignation.SelectedValue.ToString(), MainForm.pbUserID, status, "Staff Update", txtAddress.Text, txtAddress2.Text, textAddress3.Text, txtcity.Text, txtpincode.Text, txtRfCardno.Text,"1");
                }

                if (result.Contains("Saved Successfully.")|| result.Contains("Updated Successfully.") || result.Contains("Deleted Successfully."))
                {
                    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    udfnclear();
                    MainForm.objMR_StaffList.udfnList();
                }
                else  
                {
                    MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }
            }
            else
            {
                if (txtRfCardno.Text == "")
                {
                    epMR_Staff.SetError(txtRfCardno, "Please enter the RF ID No.");
                    txtRfCardno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the RF ID No.", txtRfCardno, 5000);
                }
                if (txtStaffName.Text == "")
                {
                    epMR_Staff.SetError(txtStaffName, "Please enter the Staff Name");
                    txtStaffName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the Staff Name", txtStaffName, 5000); 
                }
                if (txtMobileNo.Text == "")
                {
                    epMR_Staff.SetError(txtMobileNo, "Please enter the mobile number");
                    txtMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the mobile number", txtMobileNo, 5000); 
                }
                if (txtAddress.Text == "")
                {
                    epMR_Staff.SetError(txtAddress, "Please enter Staff address");
                    txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter Staff address", txtAddress, 5000); 
                }
                if (txtcity.Text == "")
                {
                    epMR_Staff.SetError(txtcity, "Please enter City name");
                    txtcity.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter City name", txtcity, 5000);
                }
                if (txtpincode.Text == "")
                {
                    epMR_Staff.SetError(txtpincode, "Please enter pincode");
                    txtpincode.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter pincode", txtpincode, 5000);
                }
                if (Convert.ToString(cmbBloodGroup.SelectedValue) == "-1")
                {
                    epMR_Staff.SetError(cmbBloodGroup, "Please select blood Group");
                    cmbBloodGroup.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please select blood Group", cmbBloodGroup, 5000);
                }
                if (Convert.ToString(cmbdesignation.SelectedValue) == "-1")
                {
                    epMR_Staff.SetError(cmbdesignation, "Please select designation");
                    cmbdesignation.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please select designation", cmbdesignation, 5000);
                }
            }

        }

         
        // Author : Venkat
        // Created Date: 16/05/2023
        //*************** Clear the data in MR_Staff form **************
        public void udfnclear()
        {
            try
            {
                txtRfCardno.Text = "";
                txtStaffName.Text = ""; 
                txtMobileNo.Text = "";
                cmbBloodGroup.SelectedValue = "-1";
                cmbdesignation.SelectedValue = "-1";
                txtAddress.Text = "";
                txtAddress2.Text = "";
                textAddress3.Text = "";
                txtStaffName.Text = "";
                txtpincode.Text = "";
                txtcity.Text = ""; 
                rbActive.Checked = true;
                lblDStatus.Visible = false;
                lblSchemeCode.Text = "0";
                dpFromDate.Value = DateTime.Now.Date;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void txtSchemeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtMobileNo.Focus();
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
                if (e.KeyData == (Keys.Control | Keys.X))
                {
                    (sender as TextBox).Cut();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Venkat
        // Created Date: 16/05/2023
        private void MR_Staff_Leave(object sender, EventArgs e)
        {
            try
            {
                epMR_Staff.Clear();
                tpSchemeName.Active = false;
                tpShortName.Active = false;
                txtStaffName.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author: Venkat
        //created date : 16/05/2023
        private void MR_Staff_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (pbflag == "0")
                {
                    DialogResult objDialogResult = MessageBox.Show("Do you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (objDialogResult == DialogResult.Yes)
                    {
                      //  MainForm.objMR_Staff.Hide();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author: Venkat
        //created date : 16/05/2023
        private void txtShortName_Enter(object sender, EventArgs e)
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
        //Author: Venkat
        //created date : 16/05/2023
        private void txtShortName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Enter)
                {
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
                if (e.KeyData == (Keys.Control | Keys.X))
                {
                    (sender as TextBox).Cut();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author: Venkat
        //created date : 16/05/2023
        private void txtShortName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                bool varTest = objValidation.CheckSpecialCharacter(e);
                if (varTest == true) { e.Handled = true; } else { e.Handled = false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        //Author: Venkat
        //created date : 16/05/2023
        private void txtShortName_Leave(object sender, EventArgs e)
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
        //Author : Venkat
        //created date : 16/05/2023
        private void chkBranchWise_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (btnSave.Text == "Save")
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                    }
                }
                else
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                       if(rbActive.Checked==true)
                        {
                            rbActive.Focus();
                        }
                        else
                        {
                            rbInActive.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Venkat
        //created date : 16/05/2023
        private void rbFirstYear_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Venkat
        //created date : 16/05/2023
        private void rbDepartmentwise_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Venkat
        //created date : 16/05/2023
        private void cmbFromYear_SelectedIndexChanged(object sender, EventArgs e)
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

        private void chkCNCBranch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSave.Text == "Save")
                    {
                        btnSave.Focus();
                    }
                    else
                    {
                        if (rbActive.Checked == true)
                        {
                            rbActive.Focus();
                        }
                        else
                        {
                            rbInActive.Focus();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
         }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dpFromDate.Focus();
            }
        }

        private void dpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbBloodGroup.Focus();
            }
        }

        private void cmbBloodGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbdesignation.Focus();
            }
        }

        private void cmbdesignation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRfCardno.Focus();
            }
        }

        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress2.Focus();
            }
        }

        private void txtAddress2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textAddress3.Focus();
            }
        }

        private void textAddress3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtcity.Focus();
            }
        }

        private void txtcity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpincode.Focus();
            }
        }

        private void txtpincode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtpincode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRfCardno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }

        private void txtMobileNo_Leave(object sender, EventArgs e)
        {

            txtMobileNo.BackColor = Color.White;
        }

        private void dpFromDate_Leave(object sender, EventArgs e)
        {

            dpFromDate.BackColor = Color.White;
        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {

            cmbBloodGroup.BackColor = Color.White;
        }

        private void cmbdesignation_Leave(object sender, EventArgs e)
        {

            cmbdesignation.BackColor = Color.White;
        }

        private void txtRfCardno_Leave(object sender, EventArgs e)
        {

            txtRfCardno.BackColor = Color.White;
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {


            txtAddress.BackColor = Color.White;
        }

        private void txtAddress2_Leave(object sender, EventArgs e)
        {

            txtAddress2.BackColor = Color.White;
        }

        private void textAddress3_Leave(object sender, EventArgs e)
        {

            textAddress3.BackColor = Color.White;
        }

        private void txtcity_Leave(object sender, EventArgs e)
        {

            txtcity.BackColor = Color.White;
        }

        private void txtpincode_Leave(object sender, EventArgs e)
        {

            txtpincode.BackColor = Color.White;
        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbBloodGroup.SelectedValue) != 0)
            {
                lblbloodgroup.Text = Convert.ToString(cmbBloodGroup.SelectedValue);
                
            }
            else
            {
                lblbloodgroup.Text = "0";
            }
        }

        //Author : Venkat
        //created date : 16/05/2023
        private void txtSchemeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                bool varTest = objValidation.CheckSpecialCharacter(e);
                if (varTest == true) { e.Handled = true; } else { e.Handled = false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
    }
}
