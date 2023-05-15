using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Reflection;
using System.IO;
using SMSApplication.ServiceClass;

namespace SMSApplication
{
    public partial class MR_StudentImport : Form
    {
        // Author : SIVARANJANA
        // Created Date: 19/04/2019

        //************* Object for Service Classed Initialisation **********************
        DataValidation objValidation = new DataValidation();
        DataError objError;
        //******** Declare public variable ****************
        public string varsettingflag = "";
        public MR_StudentImport()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        public void udfnclear()
        {
            try
            {
                txtFileName.Text = "";
                grdStudentImport.Rows.Clear();
                grdStudentImportRollNo.Rows.Clear();
                txtFileName.Focus();
                btnImport.Enabled = true;
                lblTotal.Text = "0";
                lblDublicate.Text = "0";
                lblMismatch.Text = "0";
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);

            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        //*************** student details excel file **************
        private void btnBrowse_Click(object sender, EventArgs e)
        {   
            try
            {
                Stream objStream = null;
                OpenFileDialog objOPenFileDialog = new OpenFileDialog();
                grdStudentImport.Rows.Clear();
                grdStudentImportRollNo.Rows.Clear();
                btnImport.Enabled = true;
                objOPenFileDialog.InitialDirectory = "c:\\";
                objOPenFileDialog.Filter = "Excel Files (*.xls, *.xlsx)|*.xls; *.xlsx";
                objOPenFileDialog.FilterIndex = 2;
                objOPenFileDialog.RestoreDirectory = true;
                if (objOPenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        objStream = objOPenFileDialog.OpenFile();
                        if ((objStream != null))
                        {
                            txtFileName.Text = objOPenFileDialog.FileName;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Cannot read file from disk. Original error: " + Ex.Message);
                    }
                    finally
                    {
                        if ((objStream != null))
                        {
                            objStream.Close();
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
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        //**************** Preview student List without register number *****************
        public void udfnListReg()
        {
            try
            {
                try
                {
                    int vardublicate = 0, varMismatch = 0;
                    if (!string.IsNullOrEmpty(txtFileName.Text))
                    {
                        string varExtension = Path.GetExtension(txtFileName.Text);
                        string varFilename = Path.GetFileName(txtFileName.Text);
                        string varFilePath = AppDomain.CurrentDomain.BaseDirectory;
                        string varExcelcon = null;
                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + varFilename))
                        {
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + varFilename);
                        }
                        System.IO.File.Copy(txtFileName.Text, AppDomain.CurrentDomain.BaseDirectory + varFilename);
                        OleDbConnection oledbcon = new OleDbConnection();
                        switch (varExtension)
                        {
                            case ".xls":
                             //   varExcelcon = string.Format(System.Configuration.ConfigurationManager.AppSettings["Excel2003"], varFilename);
                                oledbcon = new OleDbConnection(varExcelcon);
                                break;
                            case ".xlsx":
                               // varExcelcon = string.Format(System.Configuration.ConfigurationManager.AppSettings["Excel2007"], varFilename);
                                oledbcon = new OleDbConnection(varExcelcon);
                                break;
                        }
                        oledbcon.Open();
                        //************ Read excel sheet name ***************
                        DataTable dtExcelSchema;
                        dtExcelSchema = oledbcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        oledbcon.Close();
                        oledbcon.Open();
                        OleDbCommand oledbcmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbcon);
                        OleDbDataAdapter oledbda = new OleDbDataAdapter(oledbcmd);
                        DataSet objDs = new DataSet();
                        oledbda.Fill(objDs, "[Sheet1$]");
                        oledbcon.Close();
                        grdStudentImportRollNo.Rows.Clear();
                        string[] item = new string[30];
                        ListViewItem listitem = new ListViewItem();
                        DataService dserv = new DataService();
                        //*************** Datatable value bond to gridview *******************
                        if (objDs != null)
                        {
                            if (objDs.Tables[0].Rows.Count > 0)
                            {
                                lblNoRecordsFound.Visible = false;
                                lblNoRecordsFound.SendToBack();
                                int varcolumnflag = 0;
                                if (objDs.Tables[0].Columns[1].ColumnName == "Student Name")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[2].ColumnName == "Roll No#")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[3].ColumnName == "Roll No#")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[4].ColumnName == "Scheme")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[5].ColumnName == "Branch")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[6].ColumnName == "Term")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[7].ColumnName == "DOB")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[8].ColumnName == "Father's Name")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[9].ColumnName == "Mother's Name")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[10].ColumnName == "ADD_1")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[11].ColumnName == "ADD_2")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[12].ColumnName == "ADD_3")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[13].ColumnName == "City")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[14].ColumnName == "State")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[15].ColumnName == "Pincode")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[16].ColumnName == "Gender")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[17].ColumnName == "Direct II Year")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[18].ColumnName == "Contact No#")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[19].ColumnName == "Caste Category")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[20].ColumnName == "Religion")
                                {

                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[21].ColumnName == "Date of Admission")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[22].ColumnName == "Total Marks")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[23].ColumnName == "Caste Name")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[24].ColumnName == "AadharNo")
                                {
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (varcolumnflag == 0)
                                {
                                    for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                                    {
                                        item[0] = (i + 1).ToString();
                                        item[1] = "";
                                        item[2] = objDs.Tables[0].Rows[i]["Student Name"].ToString();
                                        item[3] = objDs.Tables[0].Rows[i]["Roll No#"].ToString();
                                        item[4] = objDs.Tables[0].Rows[i]["Roll No#"].ToString();
                                        item[5] = objDs.Tables[0].Rows[i]["Scheme"].ToString();
                                        item[6] = objDs.Tables[0].Rows[i]["Branch"].ToString();
                                        item[7] = objDs.Tables[0].Rows[i]["Term"].ToString();
                                        item[8] = objDs.Tables[0].Rows[i]["DOB"].ToString();
                                        item[9] = objDs.Tables[0].Rows[i]["Father's Name"].ToString();
                                        item[10] = objDs.Tables[0].Rows[i]["Mother's Name"].ToString();
                                        item[11] = objDs.Tables[0].Rows[i]["ADD_1"].ToString();
                                        item[12] = objDs.Tables[0].Rows[i]["ADD_2"].ToString();
                                        item[13] = objDs.Tables[0].Rows[i]["ADD_3"].ToString();
                                        item[14] = objDs.Tables[0].Rows[i]["City"].ToString();
                                        item[15] = objDs.Tables[0].Rows[i]["State"].ToString();
                                        item[16] = objDs.Tables[0].Rows[i]["Pincode"].ToString();
                                        item[17] = objDs.Tables[0].Rows[i]["Gender"].ToString();
                                        item[18] = objDs.Tables[0].Rows[i]["Direct II Year"].ToString();
                                        item[19] = objDs.Tables[0].Rows[i]["Contact No#"].ToString();
                                        item[20] = objDs.Tables[0].Rows[i]["Caste Category"].ToString();
                                        item[21] = objDs.Tables[0].Rows[i]["Religion"].ToString();
                                        item[22] = objDs.Tables[0].Rows[i]["Date of Admission"].ToString();
                                        item[23] = objDs.Tables[0].Rows[i]["Total Marks"].ToString();
                                        item[24] = objDs.Tables[0].Rows[i]["Caste Name"].ToString();
                                        item[25] = objDs.Tables[0].Rows[i]["AadharNo"].ToString();
                                        listitem = new ListViewItem(item);
                                        grdStudentImportRollNo.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10], item[11], item[12], item[13], item[14], item[15], item[16], item[17], item[18], item[19], item[20], item[21], item[22], item[23], item[24], item[25]);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please import valid excel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                lblNoRecordsFound.Visible = true;
                                lblNoRecordsFound.BringToFront();
                            }
                        }
                        else
                        {
                            lblNoRecordsFound.Visible = true;
                            lblNoRecordsFound.BringToFront();
                        }
                        //**************Find total records,dublicate records and mismatch records ****************
                        for (int i = 0; i < grdStudentImportRollNo.Rows.Count; i++)
                        {
                            string varCount = "";
                            DataService objDataService = new DataService();
                            varCount = objDataService.displaydata("SELECT COUNT(*) FROM CP_STUDENT WHERE RollNumber='" + grdStudentImportRollNo.Rows[i].Cells["clmRegRollno"].Value.ToString() + "'");
                            objDataService.CloseConnection();
                            if (varCount != "0")
                            {
                                grdStudentImportRollNo.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f7bbbb");
                                vardublicate++;
                            }
                            if (grdStudentImportRollNo.Rows[i].Cells["clmRegStudentName"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegRollno"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegScheme"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegBranch"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegTerm"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegAddress1"].Value.ToString() == "" && grdStudentImportRollNo.Rows[i].Cells["clmRegCity"].Value.ToString() == "")
                            {
                                varMismatch++;
                            }
                        }
                        oledbcon.Close();
                        lblDublicate.Text = Convert.ToString(vardublicate);
                        lblTotal.Text = Convert.ToString(grdStudentImportRollNo.Rows.Count);
                        lblMismatch.Text = Convert.ToString(varMismatch);
                    }
                }
                catch (Exception ex)
                {
                    objError = new DataError();
                    objError.WriteFile(ex);

                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);

            }
            finally
            {
                grdStudentImportRollNo.ClearSelection();
            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        //**************** Preview student List with register number *****************
        public void udfnList()
        {
            try
            {
                try
                {
                    int vardublicate = 0,varMismatch=0;
                    if (!string.IsNullOrEmpty(txtFileName.Text))
                    {
                        string varExtension = Path.GetExtension(txtFileName.Text);
                        string varFilename = Path.GetFileName(txtFileName.Text);
                        string varFilePath = AppDomain.CurrentDomain.BaseDirectory;
                        string varExcelcon = null;
                        if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + varFilename))
                        {
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + varFilename);
                        }
                        System.IO.File.Copy(txtFileName.Text, AppDomain.CurrentDomain.BaseDirectory + varFilename);
                        OleDbConnection oledbcon = new OleDbConnection();
                        switch (varExtension)
                        {
                            case ".xls":
                                varExcelcon = string.Format(System.Configuration.ConfigurationManager.AppSettings["Excel2003"], varFilename);
                                oledbcon = new OleDbConnection(varExcelcon);
                                break;
                            case ".xlsx":
                                //
                               varExcelcon = string.Format(System.Configuration.ConfigurationManager.AppSettings["Excel2007"], varFilename);
                                oledbcon = new OleDbConnection(varExcelcon);
                                break;
                        }
                        //  
                        oledbcon.Open();
                        //************ Read excel sheet name ***************
                        DataTable dtExcelSchema;
                        dtExcelSchema = oledbcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        oledbcon.Close();
                        oledbcon.Open();
                        OleDbCommand oledbcmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbcon);
                        OleDbDataAdapter oledbda = new OleDbDataAdapter(oledbcmd);
                        DataSet objDs = new DataSet();
                        oledbda.Fill(objDs, "[Sheet1$]");
                        oledbcon.Close();
                        grdStudentImport.Rows.Clear ();
                        string[] item = new string[30];
                        ListViewItem listitem = new ListViewItem();
                        DataService dserv = new DataService();
                        //*************** Datatable value bond to gridview *******************
                        if (objDs != null)
                        {
                            if (objDs.Tables[0].Rows.Count > 0)
                            {
                                lblNoRecordsFound.Visible = false;
                                lblNoRecordsFound.SendToBack();
                                int varcolumnflag = 0;
                                if(objDs.Tables[0].Columns[0].ColumnName== "S#No#")
                                {             
                                    
                                                        
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[1].ColumnName == "Student Name")
                                {
                                     
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[2].ColumnName == "Class & Section")
                                {                                    
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[3].ColumnName == "Blood Group")
                                {                                   
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[4].ColumnName == "Address")
                                {

                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[5].ColumnName == "Mobile No#")
                                {
                                     
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[6].ColumnName == "Alternative Mobile No#")
                                {                                   
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                                if (objDs.Tables[0].Columns[7].ColumnName == "RF ID Card No#")
                                {                                   
                                }
                                else
                                {
                                    varcolumnflag = 1;
                                }
                              
                                if (varcolumnflag == 0)
                                {
                                    for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                                    {
                                        item[0] = objDs.Tables[0].Rows[i]["S#No#"].ToString();
                                        item[1] = "";
                                        item[2] = objDs.Tables[0].Rows[i]["Student Name"].ToString();
                                        item[3] = objDs.Tables[0].Rows[i]["Class & Section"].ToString();
                                        item[4] = objDs.Tables[0].Rows[i]["Blood Group"].ToString(); 
                                        item[5] = objDs.Tables[0].Rows[i]["Address"].ToString();
                                        item[6] = objDs.Tables[0].Rows[i]["Mobile No#"].ToString();
                                        item[7] = objDs.Tables[0].Rows[i]["Alternative Mobile No#"].ToString();
                                        item[8] = objDs.Tables[0].Rows[i]["RF ID Card No#"].ToString();
                                        
                                        listitem = new ListViewItem(item);
                                        grdStudentImport.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8]);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Please import valid excel", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                lblNoRecordsFound.Visible = true;
                                lblNoRecordsFound.BringToFront();
                            }
                        }
                        else
                        {
                            lblNoRecordsFound.Visible = true;
                            lblNoRecordsFound.BringToFront();
                        }
                        //**************Find total records,dublicate records and mismatch records ****************
                        for (int i = 0; i < grdStudentImport.Rows.Count; i++)
                        {
                            string varCount = "0";
                            DataService objDataService = new DataService();
                          //  varCount = objDataService.displaydata("SELECT COUNT(*) FROM CP_STUDENT WHERE RollNumber='" + grdStudentImport.Rows[i].Cells["clmrollno"].Value.ToString() + "'");
                            objDataService.CloseConnection();
                            if (varCount != "0")
                            {
                                grdStudentImport.Rows[i].DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#f7bbbb");
                                vardublicate++;                        
                            }
                            if(grdStudentImport.Rows[i].Cells["clmsno"].Value.ToString()=="" && grdStudentImport.Rows[i].Cells["clmadmission"].Value.ToString() == "" && grdStudentImport.Rows[i].Cells["clmStudentName"].Value.ToString() == "" && grdStudentImport.Rows[i].Cells["clmclass"].Value.ToString()==""  && grdStudentImport.Rows[i].Cells["clmaddress"].Value.ToString() == "" && grdStudentImport.Rows[i].Cells["clmmobile"].Value.ToString() == "" && grdStudentImport.Rows[i].Cells["clmaltermobile"].Value.ToString() == "" && grdStudentImport.Rows[i].Cells["clmrfid"].Value.ToString() == "")
                            {
                                varMismatch++;
                            }
                        }

                        DataTable dataTable = objDs.Tables[0];
                        int rowIndex = -1;
                        var duplicates = dataTable.AsEnumerable()
                                  .GroupBy(row => row.Field<string>("RF ID Card No#"))
                                  .Where(g => g.Count() > 1)
                                  .SelectMany(g => g);

                        if (duplicates.Any())
                        {
                            vardublicate++;
                            foreach (var duplicate in duplicates)
                            {

                                string code = duplicate.Field<string>("RF ID Card No#");
                                foreach (DataGridViewRow row in grdStudentImport.Rows)
                                {

                                    //if (row.Cells["clmaddress"].Value.ToString() == code)
                                    //{
                                    //    rowIndex = row.Index;
                                    //    break;
                                    //}
                                }

                                if (rowIndex != -1)
                                {
                                    grdStudentImport.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                                }
                            }
                        }


                        else
                        {
                            vardublicate = 0;
                        }

                        oledbcon.Close();
                        lblDublicate.Text =Convert.ToString(vardublicate);
                        lblTotal.Text =Convert.ToString(grdStudentImport.Rows.Count);
                        lblMismatch.Text = Convert.ToString(varMismatch);
                        if (varMismatch != 0 || vardublicate != 0)
                        {
                            btnImport.Enabled = false;
                        }
                        else {
                            btnImport.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    objError = new DataError();
                    objError.WriteFile(ex);
                   
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
              
            }
            finally
            {
                grdStudentImport.ClearSelection();
            }
        }
        // Author : SIVARANJANA
        // Created Date: 16/04/2019
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                lblNoRecordsFound.Visible = false;
                picLoader.Visible = true;
                Application.DoEvents();
                if (varsettingflag =="0")
                {
                    grdStudentImport.BringToFront();
                    grdStudentImport.SendToBack();
                    udfnList();
                    grdStudentImport_Validated(sender, e);
                }
                else
                {
                    grdStudentImportRollNo.BringToFront();
                    grdStudentImport.SendToBack();
                    udfnListReg();
                    grdStudentImportRollNo_Validated(sender,e);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                picLoader.Visible = false;
            }
        }
        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        //************** Download student template for roll number number based ******************
        public void udndownload()
        {
            try
            {               
                SaveFileDialog objSFD = new SaveFileDialog();
                objSFD.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (objSFD.ShowDialog() == DialogResult.OK)
                {
                    //********** Copy your file to objSFD.FileName ****************
                    string s = objSFD.FileName;
                    File.Copy(Application.StartupPath + "\\Templates\\Student Master Template Import.xlsx", s);
                    MessageBox.Show("Template Downloaded Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        //************** Download student template for register number based ******************
        public void udndownloadReg()
        {
            try
            {                
                SaveFileDialog objSFD = new SaveFileDialog();
                objSFD.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (objSFD.ShowDialog() == DialogResult.OK)
                {
                    //********** Copy your file to objSFD.FileName ****************
                    string s = objSFD.FileName;
                    File.Copy(Application.StartupPath + "\\Templates\\Student RollNo. Import Template.xlsx", s);
                    MessageBox.Show("Template Downloaded Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        //**************** download student master template download *****************
        private void btnDownloadTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                   udndownload(); 
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                udfnclear();
                grdStudentImport.Rows.Clear();
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        private void grdStudentImport_Validated(object sender, EventArgs e)
        {
            try
            {
                DataService objservice = new DataService();
                if (grdStudentImport.Rows.Count > 0)
                {
                    foreach (ListViewItem item in grdStudentImport.Rows)
                    {
                        for (int i = 0; i <= item.SubItems.Count - 1; i++)
                        {

                            if (objservice.blnFindRecord("CP_Student", "RollNo='" + item.SubItems[1].Text + "'") == true)
                            {
                                item.SubItems[i].BackColor = Color.Pink;
                                btnImport.Enabled = false;
                            }
                            else if (objValidation.FormatNumeric(item.SubItems[1].Text) == false || (item.SubItems[1].Text.Length != 6) || string.IsNullOrEmpty(item.SubItems[1].Text))
                            {
                                item.SubItems[i].BackColor = Color.Bisque;
                                btnImport.Enabled = false;
                            }
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
        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        //******************* Import student data with register number *****************
        public void udfnImportreg()
        {
            try
            {
                string varResult = "";
                DataService objDataService = new DataService();
              //  int varBranch = 0, varTerm = 0;
                if (btnImport.Enabled == true)
                {
                    if (grdStudentImportRollNo.Rows.Count > 0)
                    {
                        //********** create datatable **************
                        DataTable objDt = new DataTable();
                        objDt.TableName = "CP_Student";
                        //**************** add column in datatable  *****************
                        objDt.Columns.Add("RollNumber", typeof(string));
                        objDt.Columns.Add("RegisterNumber", typeof(string));
                        objDt.Columns.Add("StudentName", typeof(string));
                        objDt.Columns.Add("Scheme", typeof(string));
                        objDt.Columns.Add("BranchName", typeof(string));
                        objDt.Columns.Add("TermName", typeof(string));
                        objDt.Columns.Add("DOB", typeof(string));
                        objDt.Columns.Add("FatherName", typeof(string));
                        objDt.Columns.Add("Address1", typeof(string));
                        objDt.Columns.Add("Address2", typeof(string));
                        objDt.Columns.Add("Address3", typeof(string));
                        objDt.Columns.Add("City", typeof(string));
                        objDt.Columns.Add("State", typeof(string));
                        objDt.Columns.Add("Pincode", typeof(string));
                        objDt.Columns.Add("Gender", typeof(string));
                        objDt.Columns.Add("DirectSecondYear", typeof(int));
                        objDt.Columns.Add("CarrierStatusCode", typeof(string));
                        objDt.Columns.Add("MotherName", typeof(string));
                        objDt.Columns.Add("ContactNumber", typeof(string));
                        objDt.Columns.Add("CastName", typeof(string));
                        objDt.Columns.Add("Religion", typeof(string));
                        objDt.Columns.Add("DateOfAdmission", typeof(string));
                        objDt.Columns.Add("GrandTotal", typeof(string));
                        objDt.Columns.Add("CastNameDetailed", typeof(string));
                        objDt.Columns.Add("AadharNo", typeof(string));
                        for (int i = 0; i < grdStudentImportRollNo.Rows.Count; i++)
                        {
                            if (objDataService.blnFindRecord("TEMP_CP_Student", "StudentName='" + grdStudentImportRollNo.Rows[i].Cells["clmRegStudentName"].Value.ToString() + "' and RollNumber='" + grdStudentImportRollNo.Rows[i].Cells["clmRegRollNo"].Value.ToString() + "'") == true)
                            {
                                btnImport.Enabled = false;
                            }
                            else
                            {
                                btnImport.Enabled = true;
                                if (objDataService.blnFindRecord("CP_Scheme", "SchemeName='" + grdStudentImportRollNo.Rows[i].Cells["clmRegScheme"].Value.ToString() + "' OR SchemeNameAbr='" + grdStudentImportRollNo.Rows[i].Cells["clmRegScheme"].Value.ToString() + "'"))
                                {
                                    if (objDataService.blnFindRecord("CP_Branch", "BranchCode='" + grdStudentImportRollNo.Rows[i].Cells["clmRegBranch"].Value.ToString() + "' OR ShortName='" + grdStudentImportRollNo.Rows[i].Cells["clmRegBranch"].Value.ToString() + "'"))
                                    {
                                        if (objDataService.blnFindRecord("DEF_Term", "TermCode='" + grdStudentImportRollNo.Rows[i].Cells["clmRegTerm"].Value.ToString() + "'"))
                                        {
                                            string varRegCount = objDataService.displaydata("SELECT COUNT(*) FROM CP_STUDENT WHERE RegisterNumber='" + grdStudentImportRollNo.Rows[i].Cells["clmRegRegNo"].Value.ToString() + "'");
                                            if (varRegCount == "0")
                                            {
                                                //************ pass value from grid to datatable ****************
                                                //objDt.Rows.Add(grdStudentImportRollNo.Rows[i].Cells["clmRegRollNo"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegRollNo"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegStudentName"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegBranch"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegterm"].Value, "", "", "", "", "", "", grdStudentImportRollNo.Rows[i].Cells["clmRegState"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegPincode"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegGender"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegDirectSecondYear"].Value,grdStudentImportRollNo.Rows[i].Cells["clmRegCarrerStatus"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegMotherName"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegContactNumber"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegCaste"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegReligion"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegDateofAdmission"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegGrandTotal"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegCastNameDetailed"].Value);
                                                objDt.Rows.Add(grdStudentImportRollNo.Rows[i].Cells["clmRegRollno"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegRollno"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegStudentName"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegScheme"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegBranch"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegTerm"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegDOB"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegFatherName"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegAddress1"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegAddress2"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegAddress3"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegCity"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegState"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegPincode"].Value, grdStudentImportRollNo.Rows[i].Cells["clmregGender"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegDirectSecondYear"].Value, "4", grdStudentImportRollNo.Rows[i].Cells["clmRegMotherName"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegContactNumber"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegCaste"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegReligion"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegDateofAdmission"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegGrandTotal"].Value, grdStudentImportRollNo.Rows[i].Cells["clmRegCastNameDetailed"].Value,Convert.ToString(grdStudentImportRollNo.Rows[i].Cells["clmRegAadharNo"].Value));
                                            }
                                        }
                                        //else
                                        //{
                                        //    MessageBox.Show("Check Term Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        //}
                                    }
                                }
                            }
                        }
                        objDataService.CloseConnection();
                        if (lblDublicate.Text != "0")
                        {
                            DialogResult dialogResult = MessageBox.Show("Dublicate record will be ignored.Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SPDataService objSPService = new SPDataService();

                                //*********** create the object and access wcf  ***********
                             //   SSSExamCell.CP_StudentMasterService.CP_StudentMasterService objCP_StudentService = new CP_StudentMasterService.CP_StudentMasterService();
                                //*********** pass data to wcf and get the result ************
                            //    varResult = objCP_StudentService.udfn_CP_ImportStudent("Create", 0, true, objDt, MainForm.pbSchemeCode, true, MainForm.pbAcademicCode, true, MainForm.pbUserID, MainForm.pbIpAddress, "Import Student Details");
                                objSPService.CloseConnection();
                                if (varResult.Contains("Success"))
                                {
                                    MessageBox.Show("Students Data Imported Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    udfnclear();
                                }
                                else
                                {
                                    MessageBox.Show(varResult, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            SPDataService objSPService = new SPDataService();

                            //*********** create the object and access wcf  ***********
                          //  SSSExamCell.CP_StudentMasterService.CP_StudentMasterService objCP_StudentService = new CP_StudentMasterService.CP_StudentMasterService();
                            //*********** pass data to wcf and get the result ************
                           // varResult = objCP_StudentService.udfn_CP_ImportStudent("Create", 0, true, objDt, MainForm.pbSchemeCode, true, MainForm.pbAcademicCode, true, MainForm.pbUserID, MainForm.pbIpAddress, "Import Student Details");
                            objSPService.CloseConnection();
                            if (varResult.Contains("Success"))
                            {
                                MessageBox.Show("Students Data Imported Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                udfnclear();
                            }
                            else
                            {
                                MessageBox.Show(varResult, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }



                    }


                }

            //    MainForm.objCP_StudentList.udfnlist();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);

            }
            finally
            {
                btnImport.Enabled = true;
            }
        }
        //Author:SIVARANJANA
        //Created Date:09/05/2019
        //***************** Import student data ******************
        public void udfnImport()
        {
            try
            {
                string varResult = "";
                DataService objDataService = new DataService();
              //  int varBranch = 0, varTerm = 0;
                if (btnImport.Enabled == true)
                {
                    if (grdStudentImport.Rows.Count > 0)
                    {
                        //********** create datatable **************
                        DataTable objDt = new DataTable();
                        objDt.TableName = "CP_Student";
                        //**************** add column in datatable  *****************
                        objDt.Columns.Add("RollNumber", typeof(string));
                        objDt.Columns.Add("RegisterNumber", typeof(string));
                        objDt.Columns.Add("StudentName", typeof(string));
                        objDt.Columns.Add("Scheme", typeof(string));
                        objDt.Columns.Add("BranchName", typeof(string));
                        objDt.Columns.Add("TermName", typeof(string));
                        objDt.Columns.Add("DOB", typeof(string));
                        objDt.Columns.Add("FatherName", typeof(string));
                        objDt.Columns.Add("Address1", typeof(string));
                        objDt.Columns.Add("Address2", typeof(string));
                        objDt.Columns.Add("Address3", typeof(string));
                        objDt.Columns.Add("City", typeof(string));
                        objDt.Columns.Add("State", typeof(string));
                        objDt.Columns.Add("Pincode", typeof(int));
                        objDt.Columns.Add("Gender", typeof(string));
                        objDt.Columns.Add("DirectSecondYear", typeof(int));
                        objDt.Columns.Add("CarrierStatusCode", typeof(string));
                        objDt.Columns.Add("MotherName", typeof(string));
                        objDt.Columns.Add("ContactNumber", typeof(string));
                        objDt.Columns.Add("CastName", typeof(string));
                        objDt.Columns.Add("Religion", typeof(string));
                        objDt.Columns.Add("DateOfAdmission", typeof(string));
                        objDt.Columns.Add("GrandTotal", typeof(string));
                        objDt.Columns.Add("CastNameDetailed", typeof(string));
                        objDt.Columns.Add("AadharNo", typeof(string));

                        for (int i = 0; i < grdStudentImport.Rows.Count; i++)
                        {
                            if (objDataService.blnFindRecord("TEMP_CP_Student", "StudentName='" + grdStudentImport.Rows[i].Cells["clmStudentName"].Value.ToString() + "' and RegisterNumber='" + grdStudentImport.Rows[i].Cells["clmRegisterNumber"].Value.ToString() + "'") == true)
                            {
                                btnImport.Enabled = false;
                            }
                            else
                            {
                                btnImport.Enabled = true;
                                if (objDataService.blnFindRecord("cp_Scheme", "SchemeName='" + grdStudentImport.Rows[i].Cells["clmScheme"].Value.ToString() + "'"))
                                {
                                    if (objDataService.blnFindRecord("CP_Branch", "BranchCode='" + grdStudentImport.Rows[i].Cells["clmBranch"].Value.ToString() + "'"))
                                    {
                                        if (objDataService.blnFindRecord("DEF_Term", "TermCode='" + grdStudentImport.Rows[i].Cells["clmTerm"].Value.ToString() + "'"))
                                        {
                                            string varRegCount = objDataService.displaydata("SELECT COUNT(*) FROM CP_STUDENT WHERE RegisterNumber='" + grdStudentImport.Rows[i].Cells["clmRegisterNumber"].Value.ToString() + "'");
                                            if (varRegCount == "0")
                                            {
                                                int varpincode =0;
                                                if (Convert.ToString(grdStudentImport.Rows[i].Cells["clmPincode"].Value)=="")
                                                {
                                                    varpincode = 0;
                                                }
                                                else
                                                {
                                                    varpincode = Convert.ToInt32(grdStudentImport.Rows[i].Cells["clmPincode"].Value);
                                                }
                                                //************ pass value from grid to datatable ****************
                                                //objDt.Rows.Add(grdStudentImport.Rows[i].Cells["clmRollNo"].Value, grdStudentImport.Rows[i].Cells["clmRegisterNumber"].Value, grdStudentImport.Rows[i].Cells["clmStudentName"].Value, grdStudentImport.Rows[i].Cells["clmScheme"].Value, grdStudentImport.Rows[i].Cells["clmBranch"].Value, grdStudentImport.Rows[i].Cells["clmterm"].Value, grdStudentImport.Rows[i].Cells["clmDOB"].Value, grdStudentImport.Rows[i].Cells["clmFatherName"].Value, grdStudentImport.Rows[i].Cells["clmAddress1"].Value, grdStudentImport.Rows[i].Cells["clmAddress2"].Value, grdStudentImport.Rows[i].Cells["clmAddress3"].Value, grdStudentImport.Rows[i].Cells["clmCity"].Value, grdStudentImport.Rows[i].Cells["clmState"].Value, grdStudentImport.Rows[i].Cells["clmPincode"].Value, grdStudentImport.Rows[i].Cells["clmGender"].Value, grdStudentImport.Rows[i].Cells["clmDirectSecondYear"].Value, "4", grdStudentImport.Rows[i].Cells["clmMotherName"].Value, grdStudentImport.Rows[i].Cells["clmContactNumber"].Value, grdStudentImport.Rows[i].Cells["clmCaste"].Value, grdStudentImport.Rows[i].Cells["clmReligion"].Value, grdStudentImport.Rows[i].Cells["clmDateofAdmission"].Value, grdStudentImport.Rows[i].Cells["clmRegGrandTotal"].Value, grdStudentImport.Rows[i].Cells["clmRegCastNameDetailed"].Value, Convert.ToString(grdStudentImport.Rows[i].Cells["clmAadharNo"].Value));
                                                objDt.Rows.Add(grdStudentImport.Rows[i].Cells["clmRollNo"].Value, grdStudentImport.Rows[i].Cells["clmRegisterNumber"].Value, grdStudentImport.Rows[i].Cells["clmStudentName"].Value, grdStudentImport.Rows[i].Cells["clmScheme"].Value, grdStudentImport.Rows[i].Cells["clmBranch"].Value, grdStudentImport.Rows[i].Cells["clmterm"].Value, grdStudentImport.Rows[i].Cells["clmDOB"].Value, grdStudentImport.Rows[i].Cells["clmFatherName"].Value, grdStudentImport.Rows[i].Cells["clmAddress1"].Value, grdStudentImport.Rows[i].Cells["clmAddress2"].Value, grdStudentImport.Rows[i].Cells["clmAddress3"].Value, grdStudentImport.Rows[i].Cells["clmCity"].Value, grdStudentImport.Rows[i].Cells["clmState"].Value, varpincode, grdStudentImport.Rows[i].Cells["clmGender"].Value, grdStudentImport.Rows[i].Cells["clmDirectSecondYear"].Value,"4", grdStudentImport.Rows[i].Cells["clmMotherName"].Value,grdStudentImport.Rows[i].Cells["clmContactNumber"].Value, grdStudentImport.Rows[i].Cells["clmCaste"].Value, grdStudentImport.Rows[i].Cells["clmReligion"].Value, grdStudentImport.Rows[i].Cells["clmDateofAdmission"].Value, grdStudentImport.Rows[i].Cells["clmGrandTotal"].Value, grdStudentImport.Rows[i].Cells["clmCastNameDetailed"].Value,Convert.ToString(grdStudentImport.Rows[i].Cells["clmAadharNo"].Value));
                                            }
                                        }
                                        //else
                                        //{
                                        //    MessageBox.Show("Check Term Format", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        //}
                                    }
                                }

                            }
                        }
                        objDataService.CloseConnection();
                        if (lblDublicate.Text != "0")
                        {
                            DialogResult dialogResult = MessageBox.Show("Dublicate record will be ignored.Do you want to continue?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialogResult == DialogResult.Yes)
                            {
                                SPDataService objSPService = new SPDataService();

                                //*********** create the object and access wcf  ***********
                              //  SSSExamCell.CP_StudentMasterService.CP_StudentMasterService objCP_StudentService = new CP_StudentMasterService.CP_StudentMasterService();
                                //*********** pass data to wcf and get the result ************
                              //  varResult = objCP_StudentService.udfn_CP_ImportStudent("Create", 0, true, objDt, MainForm.pbSchemeCode, true, MainForm.pbAcademicCode, true, MainForm.pbUserID, MainForm.pbIpAddress, "Import Student Details");
                                objSPService.CloseConnection();
                                if (varResult.Contains("Success"))
                                {
                                    MessageBox.Show("Students Imported Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    udfnclear();
                                }
                                else
                                {
                                    MessageBox.Show(varResult, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            SPDataService objSPService = new SPDataService();

                            //*********** create the object and access wcf  ***********
                          //  SSSExamCell.CP_StudentMasterService.CP_StudentMasterService objCP_StudentService = new CP_StudentMasterService.CP_StudentMasterService();
                            //*********** pass data to wcf and get the result ************
                           // varResult = objCP_StudentService.udfn_CP_ImportStudent("Create",0, true, objDt, MainForm.pbSchemeCode, true, MainForm.pbAcademicCode, true, MainForm.pbUserID, MainForm.pbIpAddress, "Import Student Details");
                            objSPService.CloseConnection();
                            if (varResult.Contains("Success"))
                            {
                                MessageBox.Show("Students Imported Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                udfnclear();
                            }
                            else
                            {
                                MessageBox.Show(varResult, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }



                    }


                }

              //  MainForm.objCP_StudentList.udfnlist();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);

            }
            finally
            {
                btnImport.Enabled = true;
            }
        }
        // Author : SIVARANJANA
        // Created Date: 19/04/2019
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                lblNoRecordsFound.Visible = false;
                picLoader.Visible = true;
                Application.DoEvents();
                
                    udfnImport();
               
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                picLoader.Visible = false;
            }
        }
        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        private void MR_StudentImport_Load(object sender, EventArgs e)
        {
            try
            {
               
                grdStudentImport.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
               // txtDuplicate.BackColor= System.Drawing.ColorTranslator.FromHtml("#f7bbbb");
                DataService objService = new DataService();
                varsettingflag = objService.displaydata("SELECT COALESCE(SettingFlag,0) FROM CP_Settings WHERE SettingCode=1");
                objService.CloseConnection();
                if (varsettingflag == "0")
                {
                    grdStudentImport.Visible = true;
                    grdStudentImport.BringToFront();
                    grdStudentImportRollNo.Visible = false;
                    grdStudentImport.SendToBack();
                }
                else
                {
                    grdStudentImport.Visible = false;
                    grdStudentImport.SendToBack();
                    grdStudentImportRollNo.Visible = true;
                    grdStudentImport.BringToFront();
                }
                lblNoRecordsFound.Visible = true;
                lblNoRecordsFound.BringToFront();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);

            }
        }
        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        public void grdStudentImportRollNo_Validated(object sender, EventArgs e)
        {
            try
            {
                DataService objservice = new DataService();
                if (grdStudentImportRollNo.Rows.Count > 0)
                {
                    foreach (ListViewItem item in grdStudentImportRollNo.Rows)
                    {
                        for (int i = 0; i <= item.SubItems.Count - 1; i++)
                        {

                            if (objservice.blnFindRecord("CP_Student", "RollNo='" + item.SubItems[1].Text + "'") == true)
                            {
                                item.SubItems[i].BackColor = Color.Pink;
                                btnImport.Enabled = false;
                            }
                            else if (objValidation.FormatNumeric(item.SubItems[1].Text) == false || (item.SubItems[1].Text.Length != 6) || string.IsNullOrEmpty(item.SubItems[1].Text))
                            {
                                item.SubItems[i].BackColor = Color.Bisque;
                                btnImport.Enabled = false;
                            }
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
        // Author : SIVARANJANA
        // Created Date: 09/05/2019
        private void MR_StudentImport_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.Escape)
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
    }
}
