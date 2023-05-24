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
using System.Text.RegularExpressions;

namespace SMSApplication
{
    public partial class TRN_SMS_Staff : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0"; 
        private ToolTip tpConfirmPwd = new ToolTip();
        public TRN_SMS_Staff()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void TRN_SMS_Staff_Load(object sender, EventArgs e)
        {
            try
            {
                DataService objdataservice = new DataService();
                string numbers = "0";
                numbers = objdataservice.displaydata("Select ST_TOCONTACTNO from MR_Settings");

                if (numbers.Length > 0)
                {
                    txtsenderno.Text = numbers;
                }
                objdataservice.CloseConnection();
                 
                DateTime currentDate = DateTime.Now;
                lblDate.Text = currentDate.ToString("dd/MM/yyyy");
                udfnList();

             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdstaffsms.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Lavanya
        //created Date :11/04/2019
        public void udfnList()
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                grdstaffsms.Rows.Clear();
                objDs = objdserv.udfnsmsstaffmasterlist("list", "", MainForm.pbUserID, msktxtto.Text, msktxtfrom.Text);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdstaffsms.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdstaffsms.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdstaffsms.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString(); 
                                item[1] = objDs.Tables[0].Rows[i]["NAME"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["status"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                listitem = new ListViewItem(item);
                                grdstaffsms.Rows.Add(item[0], item[1], item[2], item[3] );
                            } 
                        }
                        else
                        {
                            lblDNoRecordFound.BringToFront();
                            lblDNoRecordFound.Visible = true;
                        }
                    }
                    else
                    {
                        lblDNoRecordFound.BringToFront();
                        lblDNoRecordFound.Visible = true;
                    }
                }
                else
                {
                    lblDNoRecordFound.BringToFront();
                    lblDNoRecordFound.Visible = true;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                grdstaffsms.ClearSelection();
            }
        }
        //Author : Lavanya
        //created Date :11/04/2019
        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.objMR_Student = new MR_Student();
                MainForm.objMR_Student.MdiParent = this.ParentForm;
                MainForm.objMR_Student.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Lavanya
        //created Date :11/04/2019
        private void tsbEdit_Click(object sender, EventArgs e)
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
        
       
        //Author : Lavanya
        //created Date :11/04/2019
        private void grdSchemeList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                   // udfnedit();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
    
        //Author : Lavanya
        //Created Date : 17/04/2019
        private void grdSchemeList_DoubleClick(object sender, EventArgs e)
        {
           try
            {
                //************ On Double Click Event ********
                DataGridView.HitTestInfo hit = grdstaffsms.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                if (hit.RowIndex != -1)
                {
                  //  udfnedit();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
 

        private void btn_VIEW_Click(object sender, EventArgs e)
        {
            udfnList();
        }

        private void msktxtfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                msktxtto.Focus();
            }
        }

        private void msktxtto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_VIEW.Focus();
            }
        }

        private void btnsendsms_Click(object sender, EventArgs e)
        {
            try
            {
                udfnsave();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        public void udfnsave()
        { 
            string input = txtsenderno.Text.Trim();

            // Define the regular expression pattern
            string pattern = @"^\d{10}(,\d{10})*$";
            string pattern1 = @"^\d{10},$";
            // Check if the input matches the pattern
            bool inputvalue = Regex.IsMatch(input, pattern);
            bool inputvalue1 = Regex.IsMatch(input, pattern1); 
            if (inputvalue || inputvalue1 || input.Length == 10)
            {
                SPDataService objspdservice = new SPDataService();

                string result = "", status = "0", source = "1";
                 
                if (btnsendsms.Text == "Save")
                {
                  //result = objspdservice.udfnsendsms("Create",lblDate.Text,msktxtfrom.Text,txt,msktxtto.Text, txtstudentname.Text, txtAdmisssionno.Text, txtMobileno.Text, txtAlternativeMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbClass.SelectedValue.ToString(), MainForm.pbUserID, status, "Student Create", txtAddress.Text, txtAddress2.Text, textAddress3.Text, txtcity.Text, txtpincode.Text, txtParentname.Text, txtRfCardno.Text, source);
                }

                else
                {
                //result = objspdservice.udfnStudentMaster("edit", VARstudentcode, txtstudentname.Text, txtAdmisssionno.Text, txtMobileno.Text, txtAlternativeMobileNo.Text, dpFromDate.Text, cmbBloodGroup.SelectedValue.ToString(), cmbClass.SelectedValue.ToString(), MainForm.pbUserID, status, "Staff Create", txtAddress.Text, txtAddress2.Text, textAddress3.Text, txtcity.Text, txtpincode.Text, txtParentname.Text, txtRfCardno.Text, source);
                }

                if (result.Contains("Saved Successfully.") || result.Contains("Updated Successfully.") || result.Contains("Deleted Successfully."))
                {
                    MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // udfnclear();
                    MainForm.objMR_StudentsList.udfnList();
                }
                else
                {
                    MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                epMR_SMSStaff.SetError(txtsenderno, "Please enter the Valid staff number.");
                txtsenderno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                tpConfirmPwd.ShowAlways = true;
                tpConfirmPwd.Show("Please enter the valid staff number.", txtsenderno, 5000);
            }

        }


        private void grdstaffsms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Convert the cell value to uppercase
                string cellValue = e.Value.ToString().ToUpper();

                // Update the formatted value
                e.Value = cellValue;
                e.FormattingApplied = true;
            }
        }
    }
}
