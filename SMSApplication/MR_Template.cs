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
    public partial class MR_Template : Form
    {
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();
        //  **********Tooltip Initialisation**********
        private ToolTip tpSchemeName = new ToolTip();
        private ToolTip tpShortName = new ToolTip();

        //********* Declare the variable*************
        public string pbflag="0",pbFromYear="",vartemplateid="";
        public MR_Template()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Deepa
        // Created Date: 2019-04-11
        private void MR_Template_Load(object sender, EventArgs e)
        {
            try
            {

                lblDStatus.Visible = false;
                gbStatus.Visible = false;
                DataBind objDataBind = new DataBind();
                objDataBind.BindComboBoxListSelected("view_senderid", " SD_Id Not in (0) and SD_STSID in (3,1) Order by SD_Id", "SD_Name,SD_Id", cmbsender, "", "SD_Name", "SD_Id"); 
                objDataBind = null;

                udfnEdit();
                if (btnSave.Text == "Update")
                {
                    //******** if form is in update mode status will be show **********
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                 //   MainForm.objMR_Template.Text = "Edit Scheme";
                    //********** combobox Enable & disable ***************  
                } 
                this.ActiveControl = txtTempname;      
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
                if (vartemplateid != "")
                {
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                    SPDataService objspservice = new SPDataService();
                    DataSet objDS;
                    objDS = objspservice.udfnTemplatemasterlist("Editload", vartemplateid, MainForm.pbUserID);
                    objspservice.CloseConnection();
                    string senderstatus = "0",contanttype="0";
                    if (objDS != null)
                    {
                        if (objDS.Tables[0].Rows.Count > 0)
                        {
                            txtTempname.Text = objDS.Tables[0].Rows[0]["name"].ToString();
                            txttempid.Text = objDS.Tables[0].Rows[0]["templatevalue"].ToString();
                            txttempcontant.Text = objDS.Tables[0].Rows[0]["CONTANT"].ToString();
                            cmbsender.SelectedValue = objDS.Tables[0].Rows[0]["SENDER"].ToString(); 
                            senderstatus = objDS.Tables[0].Rows[0]["STATUS"].ToString();
                            contanttype = objDS.Tables[0].Rows[0]["CONTANTTYPE"].ToString();

                            if (contanttype == "1")
                            {
                                rbunicode.Checked = true; ;
                            }
                            else
                            {
                                rbenglish.Checked = true;
                            }

                            if (senderstatus == "1")
                            {
                                rbActive.Checked = true; ;
                            }
                            else
                            {
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
        // Author : Deepa
        // Created Date: 2019-04-11
        public void udfnClose()
        {
            try
            {
                epMR_Template.Clear();
                tpSchemeName.Active = false;
                txtTempname.BackColor = Color.White;
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
        // Author : Deepa
        // Created Date: 2019-04-11
        private void txtSchemeName_Enter(object sender, EventArgs e)
        {
            try
            {
              
                txtTempname.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-11
        private void MR_Template_KeyDown(object sender, KeyEventArgs e)
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
        // Author : Deepa
        // Created Date: 2019-04-11
        private void txtSchemeName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtTempname.Text == "")
                {
                    epMR_Template.SetError(txtTempname, "Please enter Template name");
                    txtTempname.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter Template name", txtTempname, 5000);
                }
                else
                {
                    if (objValidation.FormatAlphbeticNumericAndSpecialchar(txtTempname.Text))
                    {
                        epMR_Template.Clear();
                        txtTempname.BackColor = Color.White;
                        if (btnSave.Text == "Save")
                        {
                           
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-11
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
        // Author : Deepa
        // Created Date: 2019-04-11
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
        // Author : Deepa
        // Created Date: 2019-04-11
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
         
        public void udfnsave()
        {
            if (Convert.ToInt32(cmbsender.SelectedValue) != -1 && txtTempname.Text != "" && txttempid.Text != "" && txttempcontant.Text != "")
            {

                epMR_Template.Clear();
                txttempcontant.BackColor = Color.White;
                txttempid.BackColor = Color.White;
                txtTempname.BackColor = Color.White;
                cmbsender.BackColor = Color.White; 
                SPDataService objspdservice = new SPDataService();

                string result = "", status = "0",content="0";

                if (rbActive.Checked == true)
                {
                    status = "1";
                }
                if (rbInActive.Checked == true)
                {

                    status = "0";
                }
                if (rbunicode.Checked == true)
                {
                    content = "1";
                }
                if (rbenglish.Checked == true)
                {

                    content = "0";
                }

                if (btnSave.Text == "Save")
                {
                    result = objspdservice.udfntemplatemaster("Create", "0", txtTempname.Text, txttempid.Text, content, cmbsender.SelectedValue.ToString(), txttempcontant.Text, status, MainForm.pbUserID, "Template Create");
                } 
                else
                {
                    result = objspdservice.udfntemplatemaster("edit", vartemplateid, txtTempname.Text, txttempid.Text, content, cmbsender.SelectedValue.ToString(), txttempcontant.Text, status, MainForm.pbUserID, "Template Update");
                }

                if (result.Contains("Saved Successfully.") || result.Contains("Updated Successfully.") || result.Contains("Deleted Successfully."))
                {
                    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    udfnclear();
                    MainForm.objMR_TemplateList.udfnList();
                    if (result.Contains("Updated Successfully."))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (txtTempname.Text == "")
                {
                    epMR_Template.SetError(txtTempname, "Please enter the Templatename.");
                    txtTempname.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the RF ID No.", txtTempname, 5000);
                }
                if (txttempid.Text == "")
                {
                    epMR_Template.SetError(txttempid, "Please enter the Templateid");
                    txttempid.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the Staff Name", txttempid, 5000);
                }
                if (txttempcontant.Text == "")
                {
                    epMR_Template.SetError(txttempcontant, "Please enter the TemplateContant");
                    txttempcontant.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the mobile number", txttempcontant, 5000);
                }
                
                if (Convert.ToString(cmbsender.SelectedValue) == "-1")
                {
                    epMR_Template.SetError(cmbsender, "Please select Sender id");
                    cmbsender.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please select Sender id", cmbsender, 5000);
                }
                
            }

        }



        public void udfnclear()
        {
            try
            {
                txtTempname.Text = "";
                    txttempid.Text = "";
                txttempcontant.Text = "";
                cmbsender.SelectedValue = 0;
                rbActive.Checked = true;
                rbunicode.Checked = true;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtSchemeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txttempid.Focus();
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
        // Author : Deepa
        // Created Date: 2019-04-11
        private void MR_Template_Leave(object sender, EventArgs e)
        {
            try
            {
                epMR_Template.Clear();
                tpSchemeName.Active = false;
                tpShortName.Active = false;
                txtTempname.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txttempid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbunicode.Focus();
            }
        }

        private void rbunicode_KeyDown(object sender, KeyEventArgs e)
        {
            rbenglish.Focus();
        }

        private void rbenglish_KeyDown(object sender, KeyEventArgs e)
        {
            cmbsender.Focus();
        }

        private void cmbsender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txttempcontant.Focus();
            }
        }

        private void txttempcontant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rbActive.Focus();
            }
        }

        //Author: Lavanya
        //created date : 16/04/2019
        private void MR_Template_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (pbflag == "0")
                {
                    if (btnSave.Text != "Update")
                    {
                        DialogResult objDialogResult = MessageBox.Show("Do you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (objDialogResult == DialogResult.Yes)
                        {
                            //  MainForm.objMR_Template.Hide();
                            e.Cancel = false;
                        }
                        else
                        {
                            e.Cancel = true;
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
        //Author : Deepa
        //Created Date : 17/04/2019
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
