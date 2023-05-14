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
                grdSchemeList.Columns.Cast<DataGridViewColumn>().ToList().ForEach(f => f.SortMode = DataGridViewColumnSortMode.NotSortable);
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
                grdSchemeList.Rows.Clear();
                SPDataService objDserv = new SPDataService();
                DataSet objDs;
                //*********** To call the function from SP ***********
             //   objDs = objDserv.udfn_MR_StaffList(MainForm.pbUserID,MainForm.pbIpAddress);
                objDserv.CloseConnection();
                             
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            finally
            {
                grdSchemeList.ClearSelection();
                picLoader.Visible = false;
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
                DataGridView.HitTestInfo hit = grdSchemeList.HitTest(((MouseEventArgs)e).X, ((MouseEventArgs)e).Y);
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
       
    }
}
