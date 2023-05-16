﻿using SMSApplication.ServiceClass;
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
        public string pbflag="0",pbFromYear="";
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
            if (Convert.ToInt32(cmbBloodGroup.SelectedValue) != 0 && Convert.ToString(cmbdesignation.SelectedValue) != "-1" && txtStaffName.Text != "" && txtMobileNo.Text != "" && txtAddress.Text != "")
            {

                epMR_Staff.Clear();
                txtStaffName.BackColor = Color.White;
                txtMobileNo.BackColor = Color.White;
                txtAddress.BackColor = Color.White;
                cmbBloodGroup.BackColor = Color.White;
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
                    result = objspdservice.udfnStaffMaster("Create", "0", txtStaffName.Text, txtMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbdesignation.SelectedValue.ToString(), MainForm.pbUserID, status,"Staff Create",txtAddress.Text,txtAddress2.Text,textAddress3.Text, txtcity.Text,txtpincode.Text);

                }

                else
                {
                   // result = objspdservice.udfnSPUserMaster("Update", varusercode, txtLoginID.Text, txtUserName.Text, cmbUserRole.SelectedValue.ToString(), varpassword, varstatus, MainForm.pbUserID, MainForm.pbIpAddress, "User Update");
                }
            }
            else
            {
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
                txtStaffName.Text = "";
                rbActive.Checked = true;
                lblDStatus.Visible = false;
                lblSchemeCode.Text = "0";
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
