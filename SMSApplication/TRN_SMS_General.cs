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
    public partial class TRN_SMS_General : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        private ToolTip tpConfirmPwd = new ToolTip();
        //*************** Declare the variable *******************

        public string pbflag = "0", PRESENTVAL = "0", ABSENTVAL = "0", OUTVAL = "0";
        public string varstudentcode = "0", varstaffcode = "0", varid = "0";

        public TRN_SMS_General()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void TRN_SMS_General_Load(object sender, EventArgs e)
        {
            try
            {

                DataBind objDataBind = new DataBind();
                objDataBind.BindComboBoxListSelected("View_senderid ", " sd_id not in ('0') Order by sd_id", "sd_name,sd_id", cmbsender, "", "sd_name", "sd_id");


                objDataBind = null;
                udfnList();
                //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdstudentsms.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
                picLoader.Visible = true;
                Application.DoEvents();
                //****** To display a data in a grid  ******************
                grdstudentsms.Rows.Clear();
                SPDataService objDserv = new SPDataService();
                DataSet objDs;
                //*********** To call the function from SP ***********
                //   objDs = objDserv.udfn_TRN_SMS_General(MainForm.pbUserID,MainForm.pbIpAddress);
                objDserv.CloseConnection();

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                grdstudentsms.ClearSelection();
                picLoader.Visible = false;
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
                DataGridView.HitTestInfo hit = grdstudentsms.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
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




        private void btnclassview_Click(object sender, EventArgs e)
        {

            try
            {
                DataSet objDs;
                //****To call the function from SP***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                string member = "1";
                if (Convert.ToString(cmbtemplate.SelectedValue) != "-1")
                {
                    grdstaffsms.Rows.Clear();
                    objDs = objdserv.udfncompsesms(member, MainForm.pbUserID, Convert.ToString(cmbsender.SelectedValue), Convert.ToString(cmbtemplate.SelectedValue), "0");
                    objdserv.CloseConnection();
                    epMR_SMSStudent.Clear();
                    lblsenderid.Text = Convert.ToString(cmbsender.SelectedValue);
                    txtsmscontent.Text = objDs.Tables[0].Rows[0]["content"].ToString();
                    if (member == "1")
                    {
                        if (objDs != null)
                        {
                            grdstudentsms.Rows.Clear();
                            if (objDs.Tables.Count != 0)
                            {
                                grdstudentsms.Rows.Clear();
                                if (objDs.Tables[1].Rows.Count != 0)
                                {
                                    grdstudentsms.DataSource = null;
                                    lblDNoRecordFound.Visible = false;
                                    lblDNoRecordFound.SendToBack();
                                    lblsmscount.Text = "0";
                                    for (int i = 0; i < objDs.Tables[1].Rows.Count; i++)
                                    {

                                        // grdstudentsms.DataSource = objDs.Tables[1];
                                        item[1] = objDs.Tables[1].Rows[i]["SINO"].ToString();
                                        item[2] = objDs.Tables[1].Rows[i]["NAME"].ToString();
                                        item[3] = objDs.Tables[1].Rows[i]["id"].ToString();
                                        listitem = new ListViewItem(item);
                                        grdstudentsms.Rows.Add(item[0], item[1], item[2], item[3]);
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
                    else
                    {
                        if (objDs != null)
                        {
                            grdstaffsms.Rows.Clear();
                            if (objDs.Tables.Count != 0)
                            {
                                grdstaffsms.Rows.Clear();
                                if (objDs.Tables[1].Rows.Count != 0)
                                {
                                    grdstaffsms.DataSource = null;
                                    lblDNoRecordFound.Visible = false;
                                    lblDNoRecordFound.SendToBack();
                                    lblsmscount.Text = "0";
                                    for (int i = 0; i < objDs.Tables[1].Rows.Count; i++)
                                    {
                                        item[1] = objDs.Tables[1].Rows[i]["SINO"].ToString();
                                        item[2] = objDs.Tables[1].Rows[i]["NAME"].ToString();
                                        item[3] = objDs.Tables[1].Rows[i]["mobile"].ToString();
                                        item[4] = objDs.Tables[1].Rows[i]["STATUS"].ToString();
                                        item[5] = objDs.Tables[1].Rows[i]["id"].ToString();

                                        listitem = new ListViewItem(item);
                                        grdstaffsms.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
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

                }
                else
                {

                    if (Convert.ToString(cmbsender.SelectedValue) == "-1")
                    {
                        epMR_SMSStudent.SetError(cmbsender, "Please select the sender.");
                        cmbsender.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please select the sender.", cmbsender, 5000);
                    }
                    if (Convert.ToString(cmbtemplate.SelectedValue) == "-1")
                    {
                        epMR_SMSStudent.SetError(cmbtemplate, "Please select the senderthe template.");
                        cmbtemplate.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please select the template.", cmbtemplate, 5000);
                    }
                }

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }



        }

        private void chkSelectstudent_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                varstudentcode = "0";
                for (int i = 0; i < grdstudentsms.Rows.Count; i++)
                {
                    grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value = chkSelectstudent.Checked;

                    Boolean varbooleanvalue = Convert.ToBoolean(grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value);

                    if (varbooleanvalue == true)
                    {
                        count = count + 1;
                    }

                    if (varstudentcode == "0")
                    {
                        varstudentcode = Convert.ToString(grdstudentsms.Rows[i].Cells["id"].Value);
                    }
                    else
                    {
                        varstudentcode = varstudentcode + ',' + Convert.ToString(grdstudentsms.Rows[i].Cells["id"].Value);
                    }
                }

                SPDataService objdserv = new SPDataService();
                DataSet objDs = new DataSet();
                varid = "0";
                objDs = objdserv.udfncompsesms("0", MainForm.pbUserID, Convert.ToString(cmbsender.SelectedValue), Convert.ToString(cmbtemplate.SelectedValue), varstudentcode);
                objdserv.CloseConnection();
                for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                {
                    if (varid == "0")
                    {
                        varid = Convert.ToString(objDs.Tables[0].Rows[i]["id"].ToString());
                    }
                    else
                    {
                        varid = varid + ',' + Convert.ToString(objDs.Tables[0].Rows[i]["id"].ToString());
                    }
                }

                lblsmscount.Text = Convert.ToString(count);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void grdstaffsms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                object value1 = grdstaffsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value1 == null)
                {
                    grdstaffsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else if ((bool)value1 == true)
                {
                    grdstaffsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    grdstaffsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                int count = 0;
                varstudentcode = "0";
                for (int i = 0; i < grdstudentsms.Rows.Count; i++)
                {
                    grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value = chkSelectstudent.Checked;

                    Boolean varbooleanvalue = Convert.ToBoolean(grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value);

                    if (varbooleanvalue == true)
                    {
                        count = count + 1;
                    }

                    if (varstudentcode == "0")
                    {
                        varstudentcode = Convert.ToString(grdstudentsms.Rows[i].Cells["id"].Value);
                    }
                    else
                    {
                        varstudentcode = varstudentcode + ',' + Convert.ToString(grdstudentsms.Rows[i].Cells["id"].Value);
                    }
                }

                SPDataService objdserv = new SPDataService();
                DataSet objDs = new DataSet();
                varid = "0";
                objDs = objdserv.udfncompsesms("0", MainForm.pbUserID, Convert.ToString(cmbsender.SelectedValue), Convert.ToString(cmbtemplate.SelectedValue), varstudentcode);
                objdserv.CloseConnection();
                for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                {
                    if (varid == "0")
                    {
                        varid = Convert.ToString(objDs.Tables[0].Rows[i]["id"].ToString());
                    }
                    else
                    {
                        varid = varid + ',' + Convert.ToString(objDs.Tables[0].Rows[i]["id"].ToString());
                    }
                }

                lblsmscount.Text = Convert.ToString(count);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbsender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToString(cmbtemplate.SelectedValue) != "0")
                {
                    string varsenderid = "0";
                    DataSet objdservice = new DataSet();
                    cmbtemplate.Enabled = true;
                    DataBind objDataBind = new DataBind();
                    objDataBind.BindComboBoxListSelected("View_template", " TMP_Id  not in (0) and TMP_SDId in ('" + cmbsender.SelectedValue + "') Order by TMP_Id", "tmp_name,TMP_Id", cmbtemplate, "", "tmp_name", "TMP_Id");
                    objDataBind = null;
                }
                else
                {
                    cmbtemplate.Enabled = false;
                }
            }

            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }

        private void btnsendsms_Click(object sender, EventArgs e)
        {
            try
            {
                if (objValidation.internetconnection() == true)
                {
                    if (Convert.ToString(cmbsender.SelectedValue) != "-1")
                    {

                        DataService objdservice = new DataService();
                        SPDataService objspdservice = new SPDataService();
                        string result = "", studentleft = "0", smscount = "0";
                        //   PRESENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=5 ");
                        // objdservice.CloseConnection();
                        int varflag = 0;
                        varstudentcode = "0";
                        varstaffcode = "0";
                        //if (PRESENTVAL == "0")
                        //{
                        varstaffcode = lblid.Text;
                        for (int i = 0; i < grdstudentsms.Rows.Count; i++)
                        {
                            Boolean varbooleanvalue = Convert.ToBoolean(grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value);
                            if (varbooleanvalue == true)
                            {
                                varflag++;
                            }

                        }
                        if (varflag == 0)
                        {
                            MessageBox.Show("Please Select Atleast group.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                        else
                        {
                            if (btnsmssend.Enabled == true)
                            {
                                result = objspdservice.udfnsendsmscompose("compose", varstaffcode, MainForm.pbUserID, "General SMS for staff", lblsmscount.Text, "2", Convert.ToString(cmbtemplate.SelectedValue), txtsenderno.Text);
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

                        //}
                        //else
                        //{

                        //    MessageBox.Show("Already Message Was Send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //}
                    }

                    else
                    {

                        if (Convert.ToString(cmbsender.SelectedValue) == "-1")
                        {
                            epMR_SMSStudent.SetError(cmbsender, "Please select the sender.");
                            cmbsender.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                            tpConfirmPwd.ShowAlways = true;
                            tpConfirmPwd.Show("Please select the sender.", cmbsender, 5000);
                        }

                    }
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

        private void cmbtemplate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkSelectStaff_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void grdstudentsms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                object value1 = grdstudentsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (value1 == null)
                {
                    grdstudentsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                else if ((bool)value1 == true)
                {
                    grdstudentsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                }
                else
                {
                    grdstudentsms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                int count = 0;
                varstudentcode = "0";
                varid = "0";
                for (int i = 0; i < grdstudentsms.Rows.Count; i++)
                {
                    Boolean varbooleanvalue = Convert.ToBoolean(grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value);

                    if (varbooleanvalue == true)
                    {
                        if (varstudentcode == "0")
                        {
                            varstudentcode = Convert.ToString(grdstudentsms.Rows[i].Cells["clmsmid"].Value);
                        }
                        else
                        {
                            varstudentcode = varstudentcode + ',' + Convert.ToString(grdstudentsms.Rows[i].Cells["clmsmid"].Value);
                        }
                        DataSet objDs = new DataSet();
                        SPDataService objdserv = new SPDataService();
                        objDs = objdserv.udfncompsesms("0", MainForm.pbUserID, Convert.ToString(cmbsender.SelectedValue), Convert.ToString(cmbtemplate.SelectedValue), varstudentcode);
                        objdserv.CloseConnection();

                        for (int j = 0; j < objDs.Tables[1].Rows.Count; j++)
                        {
                            count = count + 1;
                            if (varid == "0")
                            {
                                varid = Convert.ToString(objDs.Tables[1].Rows[j]["id"].ToString());
                            }
                            else
                            {
                                varid = varid + ',' + Convert.ToString(objDs.Tables[1].Rows[j]["id"].ToString());
                            }

                        }
                    }
                }
                lblid.Text = varid;
                lblsmscount.Text = Convert.ToString(count);
            }

            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
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
            if (objValidation.internetconnection() == true)
            {
                if (Convert.ToString(cmbsender.SelectedValue) != "-1")
                {

                    DataService objdservice = new DataService();
                    SPDataService objspdservice = new SPDataService();
                    string result = "", studentleft = "0", smscount = "0";
                    //   PRESENTVAL = objdservice.displaydata(" SELECT COUNT(*) AS OUTVALUE FROM TRN_SMS  WHERE CONVERT(NVARCHAR, CONVERT(DATE,SMS_Date,101),103)=CONVERT(NVARCHAR,GETDATE(),103) AND SMS_SMSType=5 ");
                    // objdservice.CloseConnection();
                    int varflag = 0;
                    varstudentcode = "0";
                    varstaffcode = "0";
                    //if (PRESENTVAL == "0")
                    //{
                    varstaffcode = lblid.Text;
                    for (int i = 0; i < grdstudentsms.Rows.Count; i++)
                    {
                        Boolean varbooleanvalue = Convert.ToBoolean(grdstudentsms.Rows[i].Cells["clmstudentcheck"].Value);
                        if (varbooleanvalue == true)
                        {
                            varflag++;
                        }

                    }
                    if (varflag == 0)
                    {
                        MessageBox.Show("Please Select Atleast group.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                    }
                    else
                    {
                        if (btnsmssend.Enabled == true)
                        {
                            result = objspdservice.udfnsendsmscompose("compose", varid, MainForm.pbUserID, "General SMS for staff", lblsmscount.Text, "1", Convert.ToString(cmbtemplate.SelectedValue), "");
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

                    //}
                    //else
                    //{

                    //    MessageBox.Show("Already Message Was Send", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }

                else
                {

                    if (Convert.ToString(cmbsender.SelectedValue) == "-1")
                    {
                        epMR_SMSStudent.SetError(cmbsender, "Please select the sender.");
                        cmbsender.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                        tpConfirmPwd.ShowAlways = true;
                        tpConfirmPwd.Show("Please select the sender.", cmbsender, 5000);
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Check Your Internet connection !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
