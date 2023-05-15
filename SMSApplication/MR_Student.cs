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
        public string pbflag = "0", pbFromYear = "";
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
            if (txtAdmisssionno.Text == "")
            {
                epMR_Student.SetError(txtAdmisssionno, "Please enter the admission number");
                txtAdmisssionno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the admission number", txtAdmisssionno, 5000);
                return;
            }
            if (txtstudentname.Text == "")
            {
                epMR_Student.SetError(txtstudentname, "Please enter the student name");
                txtstudentname.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the student name", txtstudentname, 5000);
                return;
            }
            if (txtRfCardno.Text == "")
            {
                epMR_Student.SetError(txtRfCardno, "Please enter the RF Cardnumber");
                txtRfCardno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the RF Cardnumber", txtRfCardno, 5000);
                return;
            }

            if (txtMobileno.Text == "")
            {
                epMR_Student.SetError(txtMobileno, "Please enter the mobile number");
                txtMobileno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the mobile number", txtMobileno, 5000);
                return;
            }
            if (txtAlternativeMobileNo.Text == "")
            {
                epMR_Student.SetError(txtAlternativeMobileNo, "Please enter the alternative mobile number");
                txtAlternativeMobileNo.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the alternative mobile number", txtAlternativeMobileNo, 5000);
                return;
            }
            if (txtAddress.Text == "")
            {
                epMR_Student.SetError(txtAddress, "Please enter the RF Cardnumber");
                txtAddress.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpSchemeName.ShowAlways = true;
                tpSchemeName.Show("Please enter the RF Cardnumber", txtAddress, 5000);
                return;
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
