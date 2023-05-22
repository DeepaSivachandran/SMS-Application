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
    public partial class MR_SenderIDList : Form
    {
        // Author : Deepa
        // Created Date: 2019-04-11
        // ********** Object for Service Classed Initialisation **********
        DataValidation objValidation = new DataValidation();
        DataError objError = new DataError();

        //*************** Declare the variable *******************
        public string pbflag = "0";
        public MR_SenderIDList()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
        }
        private void MR_SenderIDList_Load(object sender, EventArgs e)
        {
            try
            {
                udfnList();
             //   ((MainForm)ParentForm).statusStrip1.Visible = true;
                //*********** Disable sorting in grid ******
                grdsenderlist.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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

                if (grdsenderlist.SelectedRows.Count > 0)
                {
                    MainForm.objMR_SenderID = new MR_SenderID(); ;
                    MainForm.objMR_SenderID.senderid = grdsenderlist.SelectedRows[0].Cells["clmid"].Value.ToString();
                    MainForm.objMR_SenderID.ShowDialog();
                }

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
                ListViewItem listitem = new ListViewItem();
                grdsenderlist.Rows.Clear();
                objDs = objdserv.udfnsenderidmasterlist("List", "", MainForm.pbUserID);
                objdserv.CloseConnection();
                if (objDs != null)
                {
                    grdsenderlist.Rows.Clear();
                    if (objDs.Tables.Count != 0)
                    {
                        grdsenderlist.Rows.Clear();
                        if (objDs.Tables[0].Rows.Count != 0)
                        {
                            grdsenderlist.DataSource = null;
                            lblDNoRecordFound.Visible = false;
                            lblDNoRecordFound.SendToBack();
                            for (int i = 0; i < objDs.Tables[0].Rows.Count; i++)
                            {
                                item[0] = objDs.Tables[0].Rows[i]["sino"].ToString();
                                item[1] = objDs.Tables[0].Rows[i]["NAME"].ToString(); 
                                item[2] = objDs.Tables[0].Rows[i]["status"].ToString();
                                item[3] = objDs.Tables[0].Rows[i]["ID"].ToString();
                                listitem = new ListViewItem(item);
                                grdsenderlist.Rows.Add(item[0], item[1], item[2], item[3]);
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
                grdsenderlist.ClearSelection();
            }
        }



        //Author : Deepa
        //created Date :11/04/2019
        private void tsbNew_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.objMR_SenderID = new MR_SenderID();
                MainForm.objMR_SenderID.MdiParent = this.ParentForm;
                MainForm.objMR_SenderID.Show();
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        //Author : Deepa
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
        //Author : Deepa
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

        public void udfndelete()
        {

            try
            {
                if (grdsenderlist.SelectedRows.Count > 0)
                {
                    string result = "";
                    var delete = grdsenderlist.SelectedRows[0].Cells["clmid"].Value.ToString();
                    DialogResult dialogResult = MessageBox.Show("Do you want to delete ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        SPDataService objspdservice = new SPDataService();
                        result = objspdservice.udfnsenderidmaster("Delete", delete,"","", MainForm.pbUserID,"Sender Delete");


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
    
        //Author : Deepa
        //Created Date : 22/05/2023
        private void grdSchemeList_DoubleClick(object sender, EventArgs e)
        {
           try
            {
                //************ On Double Click Event ********
                DataGridView.HitTestInfo hit = grdsenderlist.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
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
       
    }
}
