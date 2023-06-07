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
using System.Globalization;

namespace SMSApplication
{
    public partial class TRN_SMS_Staff : Form
    {
        // Author : Deepa
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
                udfnListabsent();

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
        //Author : Deepa
        //created Date :11/04/2019
        public void udfnList()
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                string studentleft = "0";
               
                ListViewItem listitem = new ListViewItem();
                grdstaffsms.Rows.Clear();
                objDs = objdserv.udfnsmsstaffmasterlist("list", "", MainForm.pbUserID, msktxtto.Text, msktxtfrom.Text, studentleft);
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
                                item[2] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["Designation"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["Designation"].ToString();
                                listitem = new ListViewItem(item);
                                grdstaffsms.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                            }
                           txtcontantbox.Text= objDs.Tables[1].Rows[0]["content"].ToString();
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

        public void udfnListabsent()
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                string studentleft = "0";

                ListViewItem listitem = new ListViewItem();
                grdstaffabsent.Rows.Clear();
                objDs = objdserv.udfnsmsstaffmasterlist("list", "", MainForm.pbUserID, msktxtto.Text, msktxtfrom.Text, studentleft);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdstaffabsent.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdstaffabsent.Rows.Clear();
                        if (objDs.Tables[2].Rows.Count != 0)
                        {
                            grdstaffabsent.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[2].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[2].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[2].Rows[i]["NAME"].ToString();
                                item[2] = objDs.Tables[2].Rows[i]["ID"].ToString();
                                item[3] = objDs.Tables[2].Rows[i]["Designation"].ToString();
                                item[4] = objDs.Tables[2].Rows[i]["Designation"].ToString();
                                listitem = new ListViewItem(item);
                                grdstaffabsent.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
                            }
                            txtcontantbox.Text = objDs.Tables[1].Rows[0]["content"].ToString();
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
                grdstaffabsent.ClearSelection();
            }
        }


                

        //Author : Deepa
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
    
        //Author : Deepa
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
            DateTime value1, value2;
            if (DateTime.TryParseExact(msktxtfrom.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out value1) &&
    DateTime.TryParseExact(msktxtto.Text, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out value2))
            {
                if (value1 < value2)
                {
                    epMR_SMSStaff.Clear();
                    udfnList();
                    msktxtfrom.BackColor = Color.White;
                    udfnListabsent();
                    lblpresent.Text = Convert.ToString(grdstaffsms.RowCount);
                    lblouttime.Text = Convert.ToString(grdstaffabsent.RowCount);
                    int present = int.Parse(lblpresent.Text);
                    int outTime = int.Parse(lblouttime.Text);
                    int total = present + outTime;
                    lbltotstudent.Text = total.ToString();
                }
                else
                {
                    epMR_SMSStaff.SetError(msktxtfrom, "From time greater then to time.");
                    msktxtfrom.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("From time greater then to time.", msktxtfrom, 5000);
                }
            }
            

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
            if (objValidation.internetconnection() == true)
            {
                string input = txtsenderno.Text.Trim();
                string PRESENTVAL = "0";
                // Define the regular expression pattern
                string pattern = @"^\d{10}(,\d{10})*$";
                string pattern1 = @"^\d{10},$";
                // Check if the input matches the pattern
                bool inputvalue = Regex.IsMatch(input, pattern);
                bool inputvalue1 = Regex.IsMatch(input, pattern1);
                DataService objdservice = new DataService();
                PRESENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=4 ");


                if (inputvalue || inputvalue1 || input.Length == 10)
                {
                    
                        SPDataService objspdservice = new SPDataService();
                        string result = "", status = "0", source = "1";
                        result = objspdservice.udfnsendsmsSTAFF("Create", lblDate.Text, msktxtfrom.Text, txtsenderno.Text, msktxtto.Text, Convert.ToString(grdstaffsms.RowCount), MainForm.pbUserID, "Send SMS Staff");
                        if (result.Contains("SMS Send Successfully."))
                        {
                            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // udfnclear();
                            // MainForm.objMR_StudentsList.udfnList();
                        }
                        else
                        {
                            MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    
                    //else
                    //{
                    //    MessageBox.Show("Already Message Was Send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
                else
                {
                    epMR_SMSStaff.SetError(txtsenderno, "Please enter Valid number.");
                    txtsenderno.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpConfirmPwd.ShowAlways = true;
                    tpConfirmPwd.Show("Please enter valid number.", txtsenderno, 5000);
                }
            }
            else
            {
                MessageBox.Show("Please Check Your Internet connection !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btntestsms_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidation.internetconnection() == true)
                {
                    string PRESENTVAL = "0", mobile = "";
                    DataService objdservice = new DataService();
                    // PRESENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=4 ");
                    mobile = objdservice.displaydata("select ST_ToContactNo from MR_Settings");


                   
                        SPDataService objspdservice = new SPDataService();
                        string result = "", status = "0", source = "1";
                        result = objspdservice.udfnsendsmsSTAFF("Create", lblDate.Text, msktxtfrom.Text, mobile, msktxtto.Text, Convert.ToString(grdstaffsms.RowCount), MainForm.pbUserID, "Send SMS Staff");
                        if (result.Contains("SMS Send Successfully."))
                        {
                            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // udfnclear();
                            // MainForm.objMR_StudentsList.udfnList();
                        }
                        else
                        {
                            MessageBox.Show(result, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Already Message Was Send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}

                }
                else
                {
                    MessageBox.Show("Please Check Your Internet connection !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void btnsendsms_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsendsms.Focus();
            }
        }
    }
}
