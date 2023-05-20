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
        public string pbflag = "0", pbFromYear = "", VARstudentcode="";
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
                DataBind objDataBind = new DataBind();
                objDataBind.BindComboBoxListSelected("MR_BloodGroup", " Bg_Code Not in (0) Order by Bg_Code", "BG_Name,Bg_Code", cmbBloodGroup, "", "BG_Name", "Bg_Code");
                objDataBind.BindComboBoxListSelected("MR_Class", " CS_Id Not in (0) Order by CS_Id", "CS_ClassSection,CS_Id", cmbClass, "", "CS_ClassSection", "CS_Id");
                objDataBind = null;
                udfnEdit();
                if (btnSave.Text == "Update")
                {
                    //******** if form is in update mode status will be show **********
                   
                    // 
                    lblDStatus.Visible = true;
                    gbStatus.Visible = true;
                    //   MainForm.objMR_Student.Text = "Edit Scheme";
                    //********** combobox Enable & disable ***************  
                }
                this.ActiveControl = txtAdmisssionno;
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
                pbflag = "1";
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
                txtAdmisssionno.BackColor = Color.White;
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

                txtAdmisssionno.BackColor = Color.LemonChiffon;
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
        //Author : venkat
        //Created Date : 15/05/2023
        private void txtSchemeName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtAdmisssionno.Text == "")
                {
                    epMR_Student.SetError(txtAdmisssionno, "Please admission number");
                    txtAdmisssionno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please admission number", txtAdmisssionno, 5000);
                }
                else
                {
                    if (objValidation.FormatAlphbeticNumericAndSpecialchar(txtAdmisssionno.Text))
                    {
                        epMR_Student.Clear();
                        txtAdmisssionno.BackColor = Color.White;
                        if (btnSave.Text == "Save")
                        {

                        }
                    }
                    else
                    {
                        if (txtAdmisssionno.Text != "")
                        {
                            epMR_Student.SetError(txtAdmisssionno, "Please admission number");
                            txtAdmisssionno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                            tpSchemeName.ShowAlways = true;
                            tpSchemeName.Show("Please admission number", txtAdmisssionno, 5000);
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
        //Author : venkat
        //Created Date : 15/05/2023
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
        //Author : venkat
        //Created Date : 15/05/2023
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
        //Author : venkat
        //Created Date : 15/05/2023
        //************ Save data *************
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = false;
                udfnSave();
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



        public void udfnSave()
        {

            epMR_Student.Clear();
            txtAdmisssionno.BackColor = Color.White;
            txtMobileno.BackColor = Color.White;
            txtAddress.BackColor = Color.White;
            txtstudentname.BackColor = Color.White;
            txtRfCardno.BackColor = Color.White;
            txtAlternativeMobileNo.BackColor = Color.White;
            txtParentname.BackColor = Color.White;
            cmbBloodGroup.BackColor = Color.White;
            cmbClass.BackColor = Color.White;
            txtpincode.BackColor = Color.White;
            txtcity.BackColor = Color.White;
            if (Convert.ToInt32(cmbBloodGroup.SelectedValue) != -1 && Convert.ToString(cmbClass.SelectedValue) != "-1" && txtAdmisssionno.Text != "" && txtstudentname.Text!="" &&
                txtRfCardno.Text!="" && txtMobileno.Text != "" && txtAddress.Text != "" && txtpincode.Text != "" && txtcity.Text != "" && txtAlternativeMobileNo.Text != "" && 
                txtParentname.Text != "")
            {


                SPDataService objspdservice = new SPDataService();

                string result = "", status = "0",source="1";

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
                    result = objspdservice.udfnStudentMaster("Create", "0", txtstudentname.Text,txtAdmisssionno.Text, txtMobileno.Text,txtAlternativeMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbClass.SelectedValue.ToString(), MainForm.pbUserID, status, "Student Create", txtAddress.Text, txtAddress2.Text, textAddress3.Text, txtcity.Text, txtpincode.Text,txtParentname.Text,txtRfCardno.Text, source);

                }

                else
                {
                    //
                    result = objspdservice.udfnStudentMaster("edit", VARstudentcode, txtstudentname.Text, txtAdmisssionno.Text, txtMobileno.Text, txtAlternativeMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbClass.SelectedValue.ToString(), MainForm.pbUserID, status, "Staff Create", txtAddress.Text, txtAddress2.Text, textAddress3.Text, txtcity.Text, txtpincode.Text, txtParentname.Text, txtRfCardno.Text, source);
                }

                if (result.Contains("Saved Successfully.") || result.Contains("Updated Successfully.") || result.Contains("Deleted Successfully."))
                {
                    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    udfnclear();
                    MainForm.objMR_StudentsList.udfnList();
                }
                else
                {
                    MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            else
            {
                if (txtAdmisssionno.Text == "")
                {
                    epMR_Student.SetError(txtAdmisssionno, "Please enter the admission number");
                    txtAdmisssionno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the admission number", txtAdmisssionno, 5000);
                   
                }
                if (txtstudentname.Text == "")
                {
                    epMR_Student.SetError(txtstudentname, "Please enter the student name");
                    txtstudentname.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the student name", txtstudentname, 5000);
                }
                if (txtRfCardno.Text == "")
                {
                    epMR_Student.SetError(txtRfCardno, "Please enter the RF Cardnumber");
                    txtRfCardno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the RF Cardnumber", txtRfCardno, 5000);
                }

                if (txtMobileno.Text == "")
                {
                    epMR_Student.SetError(txtMobileno, "Please enter the mobile number");
                    txtMobileno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the mobile number", txtMobileno, 5000);
                }
                if (txtAlternativeMobileNo.Text == "")
                {
                    epMR_Student.SetError(txtAlternativeMobileNo, "Please enter the alternative mobile number");
                    txtAlternativeMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the alternative mobile number", txtAlternativeMobileNo, 5000);
                }
                if (txtAddress.Text == "")
                {
                    epMR_Student.SetError(txtAddress, "Please enter the RF Cardnumber");
                    txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter the RF Cardnumber", txtAddress, 5000);
                }
                if (txtParentname.Text == "")
                {
                    epMR_Student.SetError(txtParentname, "Please enter student  Parent name");
                    txtParentname.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter Student Parent name", txtParentname, 5000);
                }
                if (txtcity.Text == "")
                {
                    epMR_Student.SetError(txtcity, "Please enter City name");
                    txtcity.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter City name", txtcity, 5000);
                }
                if (txtpincode.Text == "")
                {
                    epMR_Student.SetError(txtpincode, "Please enter pincode");
                    txtpincode.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please enter pincode", txtpincode, 5000);
                }
                if (Convert.ToString(cmbBloodGroup.SelectedValue) == "-1")
                {
                    epMR_Student.SetError(cmbBloodGroup, "Please select blood Group");
                    cmbBloodGroup.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please select blood Group", cmbBloodGroup, 5000);
                }
                if (Convert.ToString(cmbClass.SelectedValue) == "-1")
                {
                    epMR_Student.SetError(cmbClass, "Please select class & Section");
                    cmbClass.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpSchemeName.ShowAlways = true;
                    tpSchemeName.Show("Please select class & Section", cmbClass, 5000);
                }
            }
        }

        private void udfnEdit()
        {
            try
            {
                if (VARstudentcode != "")
                {
                    SPDataService objspservice = new SPDataService();
                    DataSet objDS;
                    objDS = objspservice.udfnStudentMasterlist("Editload", VARstudentcode, MainForm.pbUserID,"");
                    objspservice.CloseConnection();
                    string studentstatus = "0";
                    if (objDS != null)
                    {
                        if (objDS.Tables[0].Rows.Count > 0)
                        {

                            txtAdmisssionno.Text = objDS.Tables[0].Rows[0]["Admission"].ToString();
                            txtstudentname.Text = objDS.Tables[0].Rows[0]["name"].ToString(); 
                            txtParentname.Text = objDS.Tables[0].Rows[0]["parent"].ToString();
                            cmbClass.SelectedValue = objDS.Tables[0].Rows[0]["class"].ToString();
                            dpFromDate.Text = objDS.Tables[0].Rows[0]["dob"].ToString();
                            cmbBloodGroup.SelectedValue = objDS.Tables[0].Rows[0]["bloodgroup"].ToString();
                            txtMobileno.Text = objDS.Tables[0].Rows[0]["mobile"].ToString();
                            txtAlternativeMobileNo.Text = objDS.Tables[0].Rows[0]["altmobileno"].ToString();
                            txtRfCardno.Text = objDS.Tables[0].Rows[0]["rfidno"].ToString();
                            txtAddress.Text = objDS.Tables[0].Rows[0]["address1"].ToString();
                            txtAddress2.Text = objDS.Tables[0].Rows[0]["address2"].ToString();
                            textAddress3.Text = objDS.Tables[0].Rows[0]["address3"].ToString();
                            txtpincode.Text = objDS.Tables[0].Rows[0]["PinCode"].ToString();
                            txtcity.Text = objDS.Tables[0].Rows[0]["City"].ToString();
                            studentstatus = objDS.Tables[0].Rows[0]["STATUS"].ToString();

                            if (studentstatus == "1")
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
                txtstudentname.Text = "";
                txtMobileno.Text = "";
                cmbBloodGroup.SelectedValue = "-1";
                cmbClass.SelectedValue = "-1";
                txtAddress.Text = ""; 
                txtRfCardno.Text = "";
                txtAddress2.Text = "";
                txtAlternativeMobileNo.Text = "";
                textAddress3.Text = "";
                txtParentname.Text = "";
                txtAdmisssionno.Text = "";
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

        //Author : venkat
        //Created Date : 15/05/2023
        private void txtSchemeName_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtstudentname.Focus();
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
        //Author : venkat
        //Created Date : 15/05/2023
        private void MR_Student_Leave(object sender, EventArgs e)
        {
            try
            {
                epMR_Student.Clear();
                tpSchemeName.Active = false;
                tpShortName.Active = false;
                txtAdmisssionno.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : venkat
        //Created Date : 15/05/2023
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
        
        //Author : venkat
        //Created Date : 15/05/2023
      

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdmisssionno_TextChanged(object sender, EventArgs e)
        {

            txtAdmisssionno.Text = txtAdmisssionno.Text.ToUpper();
        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {

            txtstudentname.Text = txtstudentname.Text.ToUpper();
        }

        private void txtMobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
            }
        }

        private void txtAlternativeMobileNo_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txtpincode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtstudentname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtParentname.Focus();
            }
        }

        private void txtParentname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbClass.Focus();
            }
        }

        private void cmbClass_KeyDown(object sender, KeyEventArgs e)
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
                txtMobileno.Focus();
            }
        }

        private void txtMobileno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAlternativeMobileNo.Focus();
            }
        }

        private void txtAlternativeMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRfCardno.Focus();
            }
        }

        private void txtRfCardno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
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

        private void txtstudentname_Enter(object sender, EventArgs e)
        {
            try
            {

                txtstudentname.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtParentname_Enter(object sender, EventArgs e)
        {
            try
            {

                txtParentname.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void cmbClass_Enter(object sender, EventArgs e)
        {
            try
            {

                cmbClass.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void cmbBloodGroup_Enter(object sender, EventArgs e)
        {
            try
            {

                cmbBloodGroup.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtMobileno_Enter(object sender, EventArgs e)
        {
            try
            {

                txtMobileno.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtAlternativeMobileNo_Enter(object sender, EventArgs e)
        {
            try
            {

                txtAlternativeMobileNo.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtRfCardno_Enter(object sender, EventArgs e)
        {
            try
            {

                txtRfCardno.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

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

        private void txtAddress2_Enter(object sender, EventArgs e)
        {
            try
            {

                txtAddress2.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void textAddress3_Enter(object sender, EventArgs e)
        {
            try
            {

                textAddress3.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtcity_Enter(object sender, EventArgs e)
        {
            try
            {

                txtcity.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtpincode_Enter(object sender, EventArgs e)
        {
            try
            {

                txtpincode.BackColor = Color.LemonChiffon;
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void txtstudentname_Leave(object sender, EventArgs e)
        {

            txtstudentname.BackColor = Color.White;
        }

        private void txtParentname_Leave(object sender, EventArgs e)
        {


            txtParentname.BackColor = Color.White;
        }

        private void cmbClass_Leave(object sender, EventArgs e)
        {


            cmbClass.BackColor = Color.White;
        }

        private void cmbBloodGroup_Leave(object sender, EventArgs e)
        {


            cmbBloodGroup.BackColor = Color.White;
        }

        private void txtMobileno_Leave(object sender, EventArgs e)
        {


            txtMobileno.BackColor = Color.White;
        }

        private void txtAlternativeMobileNo_Leave(object sender, EventArgs e)
        {


            txtAlternativeMobileNo.BackColor = Color.White;
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

        private void txtAlternativeMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
                e.Handled = true;
            }
        }
         


        //Author : venkat
        //Created Date : 15/05/2023
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
