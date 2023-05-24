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
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0";
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
        //Author : Lavanya
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
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
               // udfndelete();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }
        //Author : Lavanya
        //created Date :11/04/2019
        private void TRN_SMS_Student_KeyDown(object sender, KeyEventArgs e)
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
                objDs = objdserv.udfnsmsstudentmasterlist("list", "", MainForm.pbUserID, msktxtto.Text,msktxtfrom.Text);
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
                                listitem = new ListViewItem(item);
                                grdsmsstudent.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
                            }
                            lblpresent.Text = objDs.Tables[1].Rows[0]["Present"].ToString();
                            lblAbsent.Text = objDs.Tables[1].Rows[0]["absent"].ToString();
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
    }
}
