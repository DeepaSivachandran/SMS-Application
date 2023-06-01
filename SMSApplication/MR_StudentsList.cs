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
using Excel = Microsoft.Office.Interop.Excel;
namespace SMSApplication
{
    public partial class MR_StudentsList : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0";
        public MR_StudentsList()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void MR_StudentsList_Load(object sender, EventArgs e)
        {
            try
            {
                DataBind objDataBind = new DataBind(); 
                objDataBind.BindComboBoxListSelected("MR_Class", " CS_Id Not in (-1) Order by CS_Id", "CS_ClassSection,CS_Id", cmbClass, "", "CS_ClassSection", "CS_Id");
                objDataBind = null;
                udfnList();
             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdStudentList.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
                grdStudentList.Rows.Clear();
                objDs = objdserv.udfnStudentMasterlist("List", "", MainForm.pbUserID,"");
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdStudentList.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdStudentList.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdStudentList.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["ADMISSION"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["NAME"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["PARENT"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["CLASS"].ToString();
                                item[5] = objDs.Tables[0].Rows[i]["DOB"].ToString(); 
                                item[6] = objDs.Tables[0].Rows[i]["RFIDNO"].ToString();
                                item[7] = objDs.Tables[0].Rows[i]["ADDRESS1"].ToString();
                                item[8] = objDs.Tables[0].Rows[i]["ADDRESS2"].ToString();
                                item[9] = objDs.Tables[0].Rows[i]["ADDRESS3"].ToString();
                                item[10] = objDs.Tables[0].Rows[i]["CITY"].ToString();
                                item[11] = objDs.Tables[0].Rows[i]["PINCODE"].ToString();
                                item[12] = objDs.Tables[0].Rows[i]["BLOODGROUP"].ToString();
                                item[13] = objDs.Tables[0].Rows[i]["mobile"].ToString();
                                item[14] = objDs.Tables[0].Rows[i]["ALTMOBILENO"].ToString(); 
                                item[15] = objDs.Tables[0].Rows[i]["STATUS"].ToString(); 
                                item[16] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                listitem = new ListViewItem(item);
                                grdStudentList.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10], item[11], item[12], item[13], item[14], item[15], item[16]);
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
                grdStudentList.ClearSelection();
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

                udfnEdit();
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

                if (grdStudentList.SelectedRows.Count > 0)
                {
                    MainForm.objMR_Student = new MR_Student(); ;
                    MainForm.objMR_Student.VARstudentcode = grdStudentList.SelectedRows[0].Cells["clmid"].Value.ToString();
                    MainForm.objMR_Student.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }


        //Author : Lavanya
        //created Date :11/04/2019
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //
                udfndelete();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
         
        public void udfndelete()
        {

            try
            {
                if (grdStudentList.SelectedRows.Count > 0)
                {
                    string result = "";
                    var delete = grdStudentList.SelectedRows[0].Cells["clmid"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        SPDataService objspdservice = new SPDataService();
                        result = objspdservice.udfnStudentMaster("Delete", delete, "", "", "", "", "","","", MainForm.pbUserID, "", "Student Delete", "", "", "", "", "","","","");


                        if (result.Contains("Deleted Successfully."))
                        {
                            MessageBox.Show(result, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            udfnList();
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

         
        //Author : Lavanya
        //created Date :11/04/2019
        private void MR_StudentsList_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                //************* short cut keys to open another form ***********
                if (((Control.ModifierKeys & Keys.Control) == Keys.Control) && (e.KeyCode == Keys.N))
                {
                    tsbNew_Click(sender, e);
                }
                if (((Control.ModifierKeys & Keys.Control) == Keys.Control) && (e.KeyCode == Keys.E))
                {
                    tsbEdit_Click(sender, e);
                }               
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Lavanya
        //created Date :11/04/2019
        public void udfnClose()
        {
            try
            {
                DialogResult objDialogResult = MessageBox.Show("Do you want to exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (objDialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
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
                    // 
                    udfnEdit();
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
                DataGridView.HitTestInfo hit = grdStudentList.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                if (hit.RowIndex != -1)
                {
                    // 
                    udfnEdit();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
                MainForm.objMR_StudentImport = new MR_StudentImport();
                MainForm.objMR_StudentImport.MdiParent = this.ParentForm;
                MainForm.objMR_StudentImport.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            excel();
        }

        public void excel() {

            try
            {
                try
                {
                    if ((grdStudentList.Rows.Count > 0))
                    {
                        Excel._Application ExcelObj = new Excel.Application();
                        //************* creating new WorkBook within Excel application   *****************
                        Excel._Workbook ExcelBook = ExcelObj.Workbooks.Add(Type.Missing);
                        //************* creating new Excelsheet in workbook   ****************
                        Excel._Worksheet ExcelSheet = null;
                        //**************** see the excel sheet behind the program ****************
                        ExcelObj.Visible = true;
                        ExcelSheet = ExcelBook.Sheets["Sheet1"];
                        ExcelSheet = ExcelBook.ActiveSheet;
                        //*********** changing the name of active sheet  *********************
                        ExcelSheet.Name = "Purchase";
                        int cIndex = 0;
                        int count = 0;

                        //ExcelSheet.Cells[1, 1].Value = "Purchase ";
                        //ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Merge();
                        //ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].HorizontalAlignment = Excel.Constants.xlCenter;
                        //ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Interior.Color = Color.LightGray;
                        //ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.Size = 12;

                        //ExcelSheet.Cells[2, 1].Value = "From : "  ;
                        //ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Merge();
                        //ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].HorizontalAlignment = Excel.Constants.xlCenter;
                        //ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Interior.Color = Color.LightGray;
                        //ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Font.Size = 12;


                        //ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.Bold = true;
                        //ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.color = Color.White;
                        //ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Interior.Color = Color.LightSlateGray;

                        foreach (DataGridViewColumn col in grdStudentList.Columns)
                        {
                            if (col.Name != "CLMID")
                            {
                                cIndex += 1;
                                ExcelSheet.Cells[3, cIndex] = col.HeaderText;
                                ExcelSheet.Cells[3, cIndex].Interior.Color = Color.LightSlateGray;
                                Excel.Range cell = ExcelSheet.Cells[3, cIndex]; 
                                cell.Font.Color = Excel.XlRgbColor.rgbWhite;  

                                if (col.Name == "clmdob")
                                {
                                    ExcelSheet.Columns[cIndex].NumberFormat = "@";
                                }
                                foreach (DataGridViewRow rowa in grdStudentList.Rows)
                                {
                                    ExcelSheet.Cells[rowa.Index + 4, cIndex] = rowa.Cells[col.Index].Value;
                                }
                            }
                        }


                        MessageBox.Show("Export Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {

                    objError = new DataError();
                    objError.WriteFile(ex);
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void btnWipeOut_Click(object sender, EventArgs e)
        {
            udfnwipeout();
        }


        public void udfnwipeout()
        {

            try
            {
                if (grdStudentList.Rows.Count > 0)
                {
                    string result = "";
                    DialogResult dialogResult = MessageBox.Show("Do you want to Wipeout all contacts ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {


                        MainForm.objMR_StudentWipout = new MR_StudentWipout();
                        MainForm.objMR_StudentWipout.MdiParent = this.ParentForm;
                        MainForm.objMR_StudentWipout.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                grdStudentList.Rows.Clear(); 
                objDs = objdserv.udfnStudentMasterlist("Filter", "", MainForm.pbUserID,Convert.ToString(cmbClass.SelectedValue));
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdStudentList.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdStudentList.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdStudentList.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["ADMISSION"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["NAME"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["PARENT"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["CLASS"].ToString();
                                item[5] = objDs.Tables[0].Rows[i]["DOB"].ToString();
                                item[6] = objDs.Tables[0].Rows[i]["RFIDNO"].ToString();
                                item[7] = objDs.Tables[0].Rows[i]["ADDRESS1"].ToString();
                                item[8] = objDs.Tables[0].Rows[i]["ADDRESS2"].ToString();
                                item[9] = objDs.Tables[0].Rows[i]["ADDRESS3"].ToString();
                                item[10] = objDs.Tables[0].Rows[i]["CITY"].ToString();
                                item[11] = objDs.Tables[0].Rows[i]["PINCODE"].ToString();
                                item[12] = objDs.Tables[0].Rows[i]["BLOODGROUP"].ToString();
                                item[13] = objDs.Tables[0].Rows[i]["mobile"].ToString();
                                item[14] = objDs.Tables[0].Rows[i]["ALTMOBILENO"].ToString();
                                item[15] = objDs.Tables[0].Rows[i]["STATUS"].ToString();
                                item[16] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                listitem = new ListViewItem(item);
                                grdStudentList.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8], item[9], item[10], item[11], item[12], item[13], item[14], item[15], item[16]);
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
                grdStudentList.ClearSelection();
            }
        }

        private void grdStudentList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
