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
    public partial class MR_SenderID : Form
    {
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();
        //  **********Tooltip Initialisation**********
        private ToolTip tpSchemeName = new ToolTip();
        private ToolTip tpShortName = new ToolTip();

        //********* Declare the variable*************
        public string pbflag="0",pbFromYear="",senderid="";
        public MR_SenderID()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_SenderID_Load(object sender, EventArgs e)
        {
            try
            {

                lblDStatus.Visible = false;
                gbStatus.Visible = false;
                udfnEdit();
                if (btnSave.Text == "Update")
                {
                    //******** if form is in update mode status will be show **********
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                 //   MainForm.objMR_SenderID.Text = "Edit Scheme";
                    //********** combobox Enable & disable ***************  
                } 
                this.ActiveControl = txtsendername;      
             }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-11
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        public void udfnClose()
        {
            try
            {
                epMR_SenderID.Clear();
                tpSchemeName.Active = false;
                txtsendername.BackColor = Color.White;
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void txtSchemeName_Enter(object sender, EventArgs e)
        {
            try
            {
              
                txtsendername.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_SenderID_KeyDown(object sender, KeyEventArgs e)
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void txtSchemeName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtsendername.Text == "")
                {
                    epMR_SenderID.SetError(txtsendername, "Please enter sender id");
                    txtsendername.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter sender id name", txtsendername, 5000);
                }
                else
                {
                    if (objValidation.FormatAlphbeticNumericAndSpecialchar(txtsendername.Text))
                    {
                        epMR_SenderID.Clear();
                        txtsendername.BackColor = Color.White;
                        if (btnSave.Text == "Save")
                        {
                           
                        }
                    }
                    else
                    {
                        if (txtsendername.Text != "")
                        {
                            epMR_SenderID.SetError(txtsendername, "Please enter  sender id");
                            txtsendername.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                            tpSchemeName.ShowAlways = true;
                            tpSchemeName.Show("Please enter sender id name", txtsendername, 5000);
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
        // Author : Lavanya
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
        // Author : Lavanya
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
        // Author : Lavanya
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

        void udfnsave()
        {
            if (txtsendername.Text != "")
            {
                txtsendername.BackColor = Color.White; 
                SPDataService objspdservice = new SPDataService();

                string result = "", status = "0";

                if (rbActive.Checked == true)
                {
                    status = "1";
                }
                else
                {

                    status = "0";
                }
                if (btnSave.Text == "Save")
                {
                    result = objspdservice.udfnsenderidmaster("Create", "0",txtsendername.Text, status, MainForm.pbUserID, "Sender Create");

                }

                else
                {
                    result = objspdservice.udfnsenderidmaster("Edit", senderid, txtsendername.Text, status, MainForm.pbUserID, "Sender Edit");
                }

                if (result.Contains("Saved Successfully.") || result.Contains("Updated Successfully.") || result.Contains("Deleted Successfully."))
                {
                    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    udfnclear();
                    MainForm.objMR_SenerIDList.udfnList();
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
                if (txtsendername.Text == "")
                {
                    epMR_SenderID.SetError(txtsendername, "Please enter the sender id.");
                    txtsendername.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the sender id.", txtsendername, 5000);
                }
            }

        }



        private void udfnEdit()
        {
            try
            {
                if (senderid != "")
                {
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                    SPDataService objspservice = new SPDataService();
                    DataSet objDS;
                    objDS = objspservice.udfnsenderidmasterlist("Editload", senderid, MainForm.pbUserID);
                    objspservice.CloseConnection();
                    string senderstatus = "0";
                    if (objDS != null)
                    {
                        if (objDS.Tables[0].Rows.Count > 0)
                        {
                            txtsendername.Text = objDS.Tables[0].Rows[0]["name"].ToString(); 
                            senderstatus = objDS.Tables[0].Rows[0]["STATUS"].ToString(); 
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


        public void udfnclear()
        {
            try
            {
                txtsendername.Text = "";
                rbActive.Checked = true; 
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
                    if (rbActive.Visible == true)
                    {
                        rbActive.Focus();
                    }
                    else {
                        btnSave.Focus();
                    }
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_SenderID_Leave(object sender, EventArgs e)
        {
            try
            {
                epMR_SenderID.Clear();
                tpSchemeName.Active = false;
                tpShortName.Active = false;
                txtsendername.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author: Lavanya
        //created date : 16/04/2019
        private void MR_SenderID_FormClosing(object sender, FormClosingEventArgs e)
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
                            //  MainForm.objMR_SenderID.Hide();
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
     

        //Author : Lavanya
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
