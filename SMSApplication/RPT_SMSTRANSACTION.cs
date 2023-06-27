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
    public partial class RPT_SMSTRANSACTION : Form
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

        public RPT_SMSTRANSACTION()
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

                udfnlist();
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
            udfnlist();
        }

        private void RPT_Persent_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        public void udfnlist()
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                grdsmstransaction.Rows.Clear();
                string studentleft = "0"; 
                objDs = objdserv.udfnsmstransaction("sms", dpFromDate.Text,MainForm.pbUserID);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdsmstransaction.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdsmstransaction.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdsmstransaction.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["general"].ToString(); 
                                item[2] = objDs.Tables[0].Rows[i]["contant"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["mobile"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["smscount"].ToString();
                                item[5] = objDs.Tables[0].Rows[i]["STATUS"].ToString();

                                listitem = new ListViewItem(item);
                                grdsmstransaction.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
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
                grdsmstransaction.ClearSelection();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            try
            {
                lblDNoRecordFound.Visible = false;
                picLoader.Visible = true;
                Application.DoEvents();
                excel();
                 
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
        public void excel()
        {

            try
            {
                try
                {
                    if ((grdsmstransaction.Rows.Count > 0))
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
                        ExcelSheet.Name = "smstransaction";
                        int cIndex = 0;
                        int count = 0;


                        foreach (DataGridViewColumn col in grdsmstransaction.Columns)
                        {
                            if (col.Name != "clmsno")
                            {
                                cIndex += 1;
                                ExcelSheet.Cells[3, cIndex] = col.HeaderText;
                                ExcelSheet.Cells[3, cIndex].Interior.Color = Color.LightSlateGray;
                                Excel.Range cell = ExcelSheet.Cells[3, cIndex];
                                cell.Font.Color = Excel.XlRgbColor.rgbWhite;

                                 
                                foreach (DataGridViewRow rowa in grdsmstransaction.Rows)
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

        private void dpFromDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnclassview.Focus();
            }
        }

        private void btnclassview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnExport.Focus();
            }
        }
    }
}
