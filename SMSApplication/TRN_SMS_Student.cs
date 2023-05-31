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
namespace SMSApplication
{
    public partial class TRN_SMS_Student : Form
    {
        // Author : Deepa
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        private ToolTip tpConfirmPwd = new ToolTip();
        //*************** Declare the variable *******************
        public string pbflag = "0",PRESENTVAL="0", ABSENTVAL = "0", OUTVAL = "0", totalsms="0",sentsms="0";
        public TRN_SMS_Student()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void TRN_SMS_Student_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime currentDate = DateTime.Now; 
                lblDate.Text = currentDate.ToString("dd/MM/yyyy");
                udfnList();
             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdsmsstudent.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
                picLoader.Visible = true;
                Application.DoEvents();
                //****** To display a data in a grid  ******************
                grdsmsstudent.Rows.Clear();
                SPDataService objDserv = new SPDataService();
                DataSet objDs;
                //*********** To call the function from SP ***********
             //   objDs = objDserv.udfn_TRN_SMS_Student(MainForm.pbUserID,MainForm.pbIpAddress);
                objDserv.CloseConnection();               
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                grdsmsstudent.ClearSelection();
                picLoader.Visible = false;
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
                DataGridView.HitTestInfo hit = grdsmsstudent.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
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
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                grdsmsstudent.Rows.Clear();
                string studentleft = "0";
                btnsmssend.Enabled = true;
                if (rbout.Checked == true)
                {
                    studentleft = "1";
                }
                else
                {
                    studentleft = "0";
                }
                objDs = objdserv.udfnsmsstudentmasterlist("list", "", MainForm.pbUserID, msktxtto.Text,msktxtfrom.Text,studentleft);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdsmsstudent.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdsmsstudent.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdsmsstudent.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["ADMISSION"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["NAME"].ToString(); 
                                item[3] = objDs.Tables[0].Rows[i]["CLASS"].ToString(); 
                                item[4] = objDs.Tables[0].Rows[i]["mobile"].ToString(); 
                                item[5] = objDs.Tables[0].Rows[i]["ID"].ToString(); 
                                item[6] = objDs.Tables[0].Rows[i]["time"].ToString();
                                
                                listitem = new ListViewItem(item);
                                grdsmsstudent.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5],item[6]);
                            }
                            lblpresent.Text = objDs.Tables[1].Rows[0]["Present"].ToString(); 
                            lblouttime.Text = objDs.Tables[1].Rows[0]["Present"].ToString();
                            lblAbsent.Text = objDs.Tables[1].Rows[0]["absent"].ToString();
                            lbltotstudent.Text = objDs.Tables[1].Rows[0]["Totalstudent"].ToString();

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
                grdsmsstudent.ClearSelection();
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

        private void grdsmsstudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void grdsmsstudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rbin_CheckedChanged(object sender, EventArgs e)
        {
            if (rbin.Checked == true)
            {
                lblAbsent.Visible = true;
                lbldabsent.Visible = true;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = false;
                lbldouttime.Visible = false;
                lbltotstudent.Visible = true;
                lbldstudent.Visible = true;

            }
            else
            {
                lblAbsent.Visible = false;
                lbldabsent.Visible = false;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = true;
                lbldouttime.Visible = true;
                lbltotstudent.Visible = false;
                lbldstudent.Visible = false;
            }
        }

        private void rbout_CheckedChanged(object sender, EventArgs e)
        {
            if (rbout.Checked == true)
            {
                lblAbsent.Visible = false;
                lbldabsent.Visible = false;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = true;
                lbldouttime.Visible = true;
                lbltotstudent.Visible = false;
                lbldstudent.Visible = false;
            }
            else
            {
                lblAbsent.Visible = true;
                lbldabsent.Visible = true;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = false;
                lbldouttime.Visible = false;
                lbltotstudent.Visible = true;
                lbldstudent.Visible = true;
            }
        }

     

        private void btnsmssend_Click(object sender, EventArgs e)
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
            DataService objDservice = new DataService();
            if (objValidation.internetconnection() == true)
            {
                if (msktxtfrom.Text != "" && msktxtto.Text != "" && grdsmsstudent.RowCount > 0)
                {

                    DataService objdservice = new DataService();
                    SPDataService objspdservice = new SPDataService();
                    string result = "", studentleft = "0", smscount = "0";
                    PRESENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=1 ");
                    ABSENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=3 ");
                    OUTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=2 ");
                    objdservice.CloseConnection();
                    if (rbout.Checked == true)
                    {
                        studentleft = "1";
                    }
                    else
                    {
                        studentleft = "0";
                    }
                    if (rbout.Checked == true)
                    {
                        smscount = lblouttime.Text;
                        if (OUTVAL != "0")
                        {
                            btnsmssend.Enabled = false;
                        }

                    }
                    else
                    {

                        smscount = lblpresent.Text;
                        if ((PRESENTVAL != "0" && ABSENTVAL != "0"))
                        {
                            btnsmssend.Enabled = false;
                        }
                    }

                    if (btnsmssend.Enabled == true)
                    {
                        result = objspdservice.udfnsendsms("Create", lblDate.Text, msktxtfrom.Text, lblAbsent.Text, msktxtto.Text, smscount, MainForm.pbUserID, "Send SMS", studentleft);
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
                    }
                    else
                    {
                        MessageBox.Show("Already Message Was Send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (msktxtfrom.Text == "")
                    {
                        epMR_SMSStudent.SetError(msktxtfrom, "Please enter from time.");
                        msktxtfrom.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please enter from time.", msktxtfrom, 5000);
                    }
                    if (msktxtto.Text == "")
                    {
                        epMR_SMSStudent.SetError(msktxtto, "Please enter to time.");
                        msktxtto.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please enter to time.", msktxtto, 5000);
                    }
                    if (grdsmsstudent.RowCount <= 0)
                    {
                        MessageBox.Show("No Records Found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else {
                MessageBox.Show("Please Check Your Internet connection !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      
        private void chkouttime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkouttime.Checked == true)
            {
                lblAbsent.Visible = false;
                lbldabsent.Visible = false;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = true;
                lbldouttime.Visible = true;
                lbltotstudent.Visible = false;
                lbldstudent.Visible = false;
            }
            else
            { 
                lblAbsent.Visible = true;
                lbldabsent.Visible = true;
                lblpresent.Visible = true;
                lbldpresent.Visible = true;
                lblouttime.Visible = false;
                lbldouttime.Visible = false;
                lbltotstudent.Visible = true;
                lbldstudent.Visible = true;
            }
        }
    }
}
