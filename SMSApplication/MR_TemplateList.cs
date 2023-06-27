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
    public partial class MR_TemplateList : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0";
        public MR_TemplateList()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void MR_TemplateList_Load(object sender, EventArgs e)
        {
            try
            {
                udfnList();
             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdTemplateList.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        } 
        public void udfnList()
        {
            try
            {
                DataSet objDs;
                //**** To call the function from SP ***************
                SPDataService objdserv = new SPDataService();
                string[] item = new string[30];
                ListViewItem listitem = new ListViewItem();
                grdTemplateList.Rows.Clear();
                objDs = objdserv.udfnTemplatemasterlist("List", "", MainForm.pbUserID);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdTemplateList.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdTemplateList.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdTemplateList.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["SINO"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["templatevalue"].ToString();
                                item[2] = objDs.Tables[0].Rows[i]["NAME"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["SENDER"].ToString();
                                item[4] = objDs.Tables[0].Rows[i]["CONTANTTYPE"].ToString();
                                item[5] = objDs.Tables[0].Rows[i]["content"].ToString();
                                item[6] = objDs.Tables[0].Rows[i]["STATUS"].ToString(); 
                                item[7] = objDs.Tables[0].Rows[i]["ID"].ToString(); 
                                    
                                 listitem = new ListViewItem(item);
                                grdTemplateList.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5], item[6], item[7]);
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
                grdTemplateList.ClearSelection();
            }
        }

        //Author : Lavanya
        //created Date :11/04/2019
        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.objMR_Template = new MR_Template(); 
                MainForm.objMR_Template.ShowDialog();
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

                if (grdTemplateList.SelectedRows.Count > 0)
                {
                    MainForm.objMR_Template = new MR_Template(); ;
                    MainForm.objMR_Template.vartemplateid = grdTemplateList.SelectedRows[0].Cells["clmid"].Value.ToString();
                    MainForm.objMR_Template.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }

        }

         

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

        public void udfndelete()
        {

            try
            {
                if (grdTemplateList.SelectedRows.Count > 0)
                {
                    string result = "";
                    var delete = grdTemplateList.SelectedRows[0].Cells["clmid"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        SPDataService objspdservice = new SPDataService();
                        result = objspdservice.udfntemplatemaster("Delete", delete,"","","","","","", MainForm.pbUserID, "Student Delete");


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
                DataGridView.HitTestInfo hit = grdTemplateList.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
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
       
    }
}
