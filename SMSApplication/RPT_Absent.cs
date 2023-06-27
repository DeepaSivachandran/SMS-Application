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
using System.IO;
using System.Text.RegularExpressions;

using Excel = Microsoft.Office.Interop.Excel;

namespace SMSApplication
{
    public partial class RPT_Absent : Form
    {
        // Author : Lavanya
        // Created Date: 01/06/2019

        //********* Object for Service Classed Initialisation ***********
        DataValidation objValidation = new DataValidation();
        DataError objError;
         
        //**************Tooltips Initialization ***************
        private ToolTip tpOldPwd = new ToolTip();
        private ToolTip tpNewPwd = new ToolTip();
        private ToolTip tpConfirmPwd = new ToolTip();

        private SecurityController _security = new SecurityController();

        //Declare public variable
        public int pbCharCount = 0;
        public string pbPwdType = "";

        public RPT_Absent()
        {
            InitializeComponent();
            //************ Form Resolution **************
            objValidation.resolutionsettingsForm(this);
        }
        // Author : Lavanya
        // Created Date: 01/06/2019
        private void MR_GeneralSettings_Load(object sender, EventArgs e)
        {
            try
            {
                //***************Load password settings details******************
                 
                DataSet objDs = new DataSet();
                DataService objDser = new DataService();
                objDs = objDser.GetDataset("SELECT TOP 1 [No.of.Chars], PasswordType FROM DEF_PasswordSettings WHERE StatusCode = 1 ORDER BY Autonum DESC");
                objDser.CloseConnection();
                if (objDs != null)
                {
                    if (objDs.Tables.Count > 0)
                    {
                        pbCharCount = Convert.ToInt16(objDs.Tables[0].Rows[0]["No.of.Chars"]);
                        pbPwdType = Convert.ToString(objDs.Tables[0].Rows[0]["PasswordType"]);
                    }
                }
            }
            catch(Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public void udfnstpresentlist()
        {

            try
            {
                DataSet ds = new DataSet();
                string data = "";
                int count = 0;
                SPDataService spservice = new SPDataService();

                ds = spservice.udfnpresent("student", dpstudentfrom.Text, MainForm.pbUserID, dpstudenttodate.Text);

                count = ds.Tables[0].Columns.Count;
                if (count != 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        string VarReportHead = "";

                        Microsoft.Office.Interop.Excel._Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook ExcelBook = ExcelObj.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel._Worksheet ExcelSheet = null;
                        ExcelObj.Visible = true;
                        ExcelSheet = ExcelBook.Sheets["Sheet1"];
                        ExcelSheet = ExcelBook.ActiveSheet;
                        ExcelSheet.Name = "present List";

                        VarReportHead = "Attendance Date " + dpstudentfrom.Text + " - " + dpstudenttodate.Text;
                    ExcelSheet.Cells[1, 1].Value = "STUDENT PRESENT REPORT";
                    ExcelSheet.Cells[2, 1].Value = VarReportHead;
                    ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Merge();
                    ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                    ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Interior.Color = Excel.XlRgbColor.rgbGray;
                    ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.Bold = true;
                    ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.color = Color.White;

                    ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Merge();
                    ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                    ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Font.color = Color.Black;
                    ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.color = Color.White;
                    ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Interior.Color = Excel.XlRgbColor.rgbSlateGray;

                    string[] varcolumnname = new string[ds.Tables[0].Columns.Count];
                    int k = 0;
                    foreach (DataColumn column in ds.Tables[0].Columns)
                    {
                        if (k < ds.Tables[0].Columns.Count)
                        {
                            ExcelSheet.Cells[3, k + 1] = column.ColumnName;
                            ExcelSheet.Cells[3, k + 1].font.Bold = true;
                        }
                        k++;
                    }
                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                        {
                            data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                            ExcelSheet.Cells[i + 4, j + 1] = data;
                        }
                    }
                    spservice.CloseConnection();
                    MessageBox.Show("Download Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            }
        }
        public void udfnstabsentlist()
        {
            try
            {
                DataSet ds = new DataSet();
                string data = "";
               
                int count = 0;  

                SPDataService spservice = new SPDataService();
               
                ds = spservice.udfnabsent("student",dpabsentstudent.Text,MainForm.pbUserID);

              
                count = ds.Tables[0].Columns.Count;

                if (count != 0) {

                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Microsoft.Office.Interop.Excel._Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook ExcelBook = ExcelObj.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel._Worksheet ExcelSheet = null;
                        ExcelObj.Visible = true;
                        ExcelSheet = ExcelBook.Sheets["Sheet1"];
                        ExcelSheet = ExcelBook.ActiveSheet;
                        ExcelSheet.Name = "Absent List";
                        string VarReportHead = "";
                        VarReportHead = "Absent Date " + dpabsentstudent.Text;
                        ExcelSheet.Cells[1, 1].Value = "STUDENT ABSENT REPORT";
                        ExcelSheet.Cells[2, 1].Value = VarReportHead;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Interior.Color = Excel.XlRgbColor.rgbGray;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.Bold = true;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.color = Color.White;

                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Font.color = Color.Black;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.color = Color.White;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Interior.Color = Excel.XlRgbColor.rgbSlateGray;

                        string[] varcolumnname = new string[ds.Tables[0].Columns.Count];
                        int k = 0;
                        foreach (DataColumn column in ds.Tables[0].Columns)
                        {
                            if (k < ds.Tables[0].Columns.Count)
                            {
                                ExcelSheet.Cells[3, k + 1] = column.ColumnName;
                                ExcelSheet.Cells[3, k + 1].font.Bold = true;
                            }
                            k++;
                        }
                        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                        {
                            for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                            {
                                data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                                ExcelSheet.Cells[i + 4, j + 1] = data;
                            }
                        }
                        spservice.CloseConnection();
                        MessageBox.Show("Download Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            }
        }
        public void udfnstaffpresentlist()
        {
            try
            {
                DataSet ds = new DataSet();
                string data = "";
               
                int count = 0;
                SPDataService spservice = new SPDataService();

                ds = spservice.udfnpresent("staff", dpstafffromdate.Text, MainForm.pbUserID, dpstafftodate.Text);

                count = ds.Tables[0].Columns.Count;

                if (count != 0) {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Microsoft.Office.Interop.Excel._Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook ExcelBook = ExcelObj.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel._Worksheet ExcelSheet = null;
                        ExcelObj.Visible = true;
                        ExcelSheet = ExcelBook.Sheets["Sheet1"];
                        ExcelSheet = ExcelBook.ActiveSheet;
                        ExcelSheet.Name = "present List";
                        string VarReportHead = "";
                        VarReportHead = "Attendance Date " + dpstafffromdate.Text + " - " + dpstafftodate.Text;
                        ExcelSheet.Cells[1, 1].Value = "STAFF PRESENT REPORT";
                        ExcelSheet.Cells[2, 1].Value = VarReportHead;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Interior.Color = Excel.XlRgbColor.rgbGray;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.Bold = true;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.color = Color.White;

                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Font.color = Color.Black;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.color = Color.White;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Interior.Color = Excel.XlRgbColor.rgbSlateGray;

                        string[] varcolumnname = new string[ds.Tables[0].Columns.Count];
                        int k = 0;
                        foreach (DataColumn column in ds.Tables[0].Columns)
                        {
                            if (k < ds.Tables[0].Columns.Count)
                            {
                                ExcelSheet.Cells[3, k + 1] = column.ColumnName;
                                ExcelSheet.Cells[3, k + 1].font.Bold = true;
                            }
                            k++;
                        }
                        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                        {
                            for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                            {
                                data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                                ExcelSheet.Cells[i + 4, j + 1] = data;
                            }
                        }
                        spservice.CloseConnection();
                        MessageBox.Show("Download Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            }
        }
        public void udfnstaffabsentlist()
        {

            try
            {
                DataSet ds = new DataSet();
                string data = "";
               
                int count = 0;

                SPDataService spservice = new SPDataService();

                ds = spservice.udfnabsent("staff", dpstaffabsent.Text, MainForm.pbUserID);


                count = ds.Tables[0].Columns.Count;
                if (count != 0) {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        Microsoft.Office.Interop.Excel._Application ExcelObj = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel._Workbook ExcelBook = ExcelObj.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel._Worksheet ExcelSheet = null;
                        ExcelObj.Visible = true;
                        ExcelSheet = ExcelBook.Sheets["Sheet1"];
                        ExcelSheet = ExcelBook.ActiveSheet;
                        ExcelSheet.Name = "Absent List";
                        string VarReportHead = "";
                        VarReportHead = "Absent Date " + dpstaffabsent.Text;
                        ExcelSheet.Cells[1, 1].Value = "STAFF ABSENT REPORT";
                        ExcelSheet.Cells[2, 1].Value = VarReportHead;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Interior.Color = Excel.XlRgbColor.rgbGray;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.Bold = true;
                        ExcelSheet.Range[ExcelSheet.Cells[1, 1], ExcelSheet.Cells[1, count]].Font.color = Color.White;

                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Merge();
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter;
                        ExcelSheet.Range[ExcelSheet.Cells[2, 1], ExcelSheet.Cells[2, count]].Font.color = Color.Black;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Font.color = Color.White;
                        ExcelSheet.Range[ExcelSheet.Cells[3, 1], ExcelSheet.Cells[3, count]].Interior.Color = Excel.XlRgbColor.rgbSlateGray;

                        string[] varcolumnname = new string[ds.Tables[0].Columns.Count];
                        int k = 0;
                        foreach (DataColumn column in ds.Tables[0].Columns)
                        {
                            if (k < ds.Tables[0].Columns.Count)
                            {
                                ExcelSheet.Cells[3, k + 1] = column.ColumnName;
                                ExcelSheet.Cells[3, k + 1].font.Bold = true;
                            }
                            k++;
                        }
                        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                        {
                            for (int j = 0; j <= ds.Tables[0].Columns.Count - 1; j++)
                            {
                                data = ds.Tables[0].Rows[i].ItemArray[j].ToString();
                                ExcelSheet.Cells[i + 4, j + 1] = data;
                            }
                        }
                        spservice.CloseConnection();
                        MessageBox.Show("Download Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Record Found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            }
        }
         

        private void MR_GeneralSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode==Keys.F5)
                { 
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
       
       
        
        private void MR_GeneralSettings_Leave(object sender, EventArgs e)
        {
            try
            {
                udfnclear();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }      
        }
        
       
        public void udfnclear()
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

        private void btnclassview_Click(object sender, EventArgs e)
        {
            
            try
            {
                picLoader.BringToFront();
                picLoader.Visible = true;
                Application.DoEvents();
                udfnstpresentlist();
                grpstaff.SendToBack();
                grpstudent.SendToBack();

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                picLoader.Visible = false;
                picLoader.SendToBack();

                grpstaff.BringToFront();
                grpstudent.BringToFront();
            }
        }

        private void RPT_Persent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void btnstaffpresent_Click(object sender, EventArgs e)
        {
            try
            {

                grpstaff.SendToBack();
                grpstudent.SendToBack();
                picLoader.Visible = true; 
                picLoader.BringToFront();
                Application.DoEvents();
                udfnstaffpresentlist();


            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                picLoader.Visible = false; 
                picLoader.SendToBack();
                grpstaff.BringToFront();
                grpstudent.BringToFront();
            }
        }

        private void btnstudentabsent_Click(object sender, EventArgs e)
        {
            try
            {

                grpstaff.SendToBack();
                grpstudent.SendToBack();
                picLoader.Visible = true; 
                picLoader.BringToFront();
                Application.DoEvents();
                udfnstabsentlist();

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
                grpstaff.BringToFront();
                grpstudent.BringToFront();
            }
            finally
            {
                picLoader.Visible = false; 
                picLoader.SendToBack();
            }
        }

        private void btnstaffabsent_Click(object sender, EventArgs e)
        {
            try
            {
                grpstaff.SendToBack();
                grpstudent.SendToBack();
                picLoader.Visible = true;
                picLoader.BringToFront();
                Application.DoEvents();
                udfnstaffabsentlist(); 

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                picLoader.Visible = false; 
                picLoader.SendToBack();
                grpstaff.BringToFront();
                grpstudent.BringToFront();
            }
        }

        private void dpstudentfrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dpstudenttodate.Focus();
            }
        }

        private void dpstudenttodate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnstudentpresent.Focus();
            }
        }

        private void dpabsentstudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnstudentabsent.Focus();
            }
        }

        private void dpstafffromdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dpstafftodate.Focus();
            }
        }

        private void dpstafftodate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnstaffpresent.Focus();
            }
        }

        private void dpstaffabsent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnstaffabsent.Focus();
            }
        }
    }
}
