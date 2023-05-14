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
    public partial class MR_Student : Form
    {
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();
        //  **********Tooltip Initialisation**********
        private ToolTip tpSchemeName = new ToolTip();
        private ToolTip tpShortName = new ToolTip();

        //********* Declare the variable*************
        public string pbflag="0",pbFromYear="";
        public MR_Student()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_Student_Load(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "Update")
                {
                    //******** if form is in update mode status will be show **********
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                 //   MainForm.objMR_Student.Text = "Edit Scheme";
                    //********** combobox Enable & disable ***************  
                } 
                this.ActiveControl = txtSchemeName;      
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
                epMR_Student.Clear();
                tpSchemeName.Active = false;
                txtSchemeName.BackColor = Color.White;
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
              
                txtSchemeName.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_Student_KeyDown(object sender, KeyEventArgs e)
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
                if (txtSchemeName.Text == "")
                {
                    epMR_Student.SetError(txtSchemeName, "Please enter scheme name");
                    txtSchemeName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter scheme name", txtSchemeName, 5000);
                }
                else
                {
                    if (objValidation.FormatAlphbeticNumericAndSpecialchar(txtSchemeName.Text))
                    {
                        epMR_Student.Clear();
                        txtSchemeName.BackColor = Color.White;
                        if (btnSave.Text == "Save")
                        {
                           
                        }
                    }
                    else
                    {
                        if (txtSchemeName.Text != "")
                        {
                            epMR_Student.SetError(txtSchemeName, "Please enter valid scheme name");
                            txtSchemeName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                            tpSchemeName.ShowAlways = true;
                            tpSchemeName.Show("Please enter valid scheme name", txtSchemeName, 5000);
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        //*************** Clear the data in MR_Student form **************
        public void udfnclear()
        {
            try
            {
                txtSchemeName.Text = "";
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
        // Author : Lavanya
        // Created Date: 2019-04-11
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
        // Author : Lavanya
        // Created Date: 2019-04-11
        private void MR_Student_Leave(object sender, EventArgs e)
        {
            try
            {
                epMR_Student.Clear();
                tpSchemeName.Active = false;
                tpShortName.Active = false;
                txtSchemeName.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author: Lavanya
        //created date : 16/04/2019
        private void MR_Student_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (pbflag == "0")
                {
                    DialogResult objDialogResult = MessageBox.Show("Do you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (objDialogResult == DialogResult.Yes)
                    {
                      //  MainForm.objMR_Student.Hide();
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
        private void txtShortName_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                bool varTest = objValidation.CheckSpecialCharacter(e);
                if (varTest == true) { e.Handled = true; } else { e.Handled = false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : SIVARANJANA
        //Created Date : 28/06/2019
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
        //Author : Deepa
        //Created Date : 06/07/2019
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

        //Author : lavanya
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
