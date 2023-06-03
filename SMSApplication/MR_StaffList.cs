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
    public partial class MR_StaffList : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0";
        public MR_StaffList()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void MR_StaffList_Load(object sender, EventArgs e)
        {
            try
            {
                udfnList();
             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdStaffList.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
                grdStaffList.Rows.Clear();
                objDs = objdserv.udfnStaffMasterLIST("List", "", MainForm.pbUserID);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdStaffList.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdStaffList.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdStaffList.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["NAME"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["DESIGNATION"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["ADDRESS1"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["ADDRESS2"].ToString();
                                item[5] = objDs.Tables[0].Rows[i]["ADDRESS3"].ToString();
                                item[6] = objDs.Tables[0].Rows[i]["pincode"].ToString();
                                item[7] = objDs.Tables[0].Rows[i]["mobile"].ToString();
                                item[8] = objDs.Tables[0].Rows[i]["city"].ToString();
                                item[9] = objDs.Tables[0].Rows[i]["dob"].ToString();
                                item[10] = objDs.Tables[0].Rows[i]["BLOODGROUP"].ToString();
                                item[11] = objDs.Tables[0].Rows[i]["rfidno"].ToString();
                                item[12] = objDs.Tables[0].Rows[i]["status"].ToString();
                                item[13] = objDs.Tables[0].Rows[i]["STAFFID"].ToString();
                                listitem = new ListViewItem(item);
                                grdStaffList.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7], item[8],item[9], item[10], item[11], item[12], item[13]); 
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
                grdStaffList.ClearSelection(); 
            }
        }


        private void udfnEdit()
        {
            try
            {

                if (grdStaffList.SelectedRows.Count > 0)
                {
                    MainForm.objMR_Staff = new MR_Staff(); ;
                    MainForm.objMR_Staff.VARSTAFFCODE = grdStaffList.SelectedRows[0].Cells["clmstaffid"].Value.ToString();
                    MainForm.objMR_Staff.ShowDialog();
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
        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.objMR_Staff = new MR_Staff();
                MainForm.objMR_Staff.MdiParent = this.ParentForm;
                MainForm.objMR_Staff.Show();
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
        //Author : Lavanya
        //created Date :11/04/2019
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                udfndelete();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }

        public void udfndelete() {

            try
            {
                if (grdStaffList.SelectedRows.Count > 0)
                {
                    string result = "";
                    var delete = grdStaffList.SelectedRows[0].Cells["clmstaffid"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        SPDataService objspdservice = new SPDataService();
                        result = objspdservice.udfnStaffMaster("Delete", delete, "", "", "", "", "", MainForm.pbUserID, "", "Staff Delete", "","", "", "", "","","");


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
        private void MR_StaffList_KeyDown(object sender, KeyEventArgs e)
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
                DataGridView.HitTestInfo hit = grdStaffList.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
                if (hit.RowIndex != -1)
                {
                    udfnEdit();
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void grdStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
         

        private void udfnexcel()
        {
            try
            {
                try
                {
                    if ((grdStaffList.Rows.Count > 0))
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
                         
                        foreach (DataGridViewColumn col in grdStaffList.Columns)
                        {
                            if (col.Name != "CLMSTAFFID")
                            {
                                cIndex += 1;
                                ExcelSheet.Cells[3, cIndex] = col.HeaderText;
                                ExcelSheet.Cells[3, cIndex].Interior.Color = Color.LightSlateGray;

                                if (col.Name == "clmdob")
                                {
                                    ExcelSheet.Columns[cIndex].NumberFormat = "@";
                                }
                                foreach (DataGridViewRow rowa in grdStaffList.Rows)
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

        private void tsbexport_Click_1(object sender, EventArgs e)
        {
            try
            {
                lblDNoRecordFound.Visible = false;
                picLoader.Visible = true;
                Application.DoEvents();
                udfnexcel();

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

        private void tspimport_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.objMR_StaffImport = new MR_StaffImport();
                MainForm.objMR_StaffImport.MdiParent = this.ParentForm;
                MainForm.objMR_StaffImport.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }

        private void grdStaffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
