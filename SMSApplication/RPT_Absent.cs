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

namespace SMSApplication
{
    public partial class RPT_Absent : Form
    {
        // Author : Lavanya
        // Created Date: 01/06/2019

        //********* Object for Service Classed Initialisation ***********
        DataValidation objValidation = new DataValidation();
        DataError objError;

        public CrystalDecisions.CrystalReports.Engine.ReportDocument objBillreport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
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
        public void udfnlist()
        {
        //    DataSet objds;
        //    SPDataService objspdservice = new SPDataService();
        //    if (rbStudent.Checked == true)
        //    {
        //        objds = objspdservice.udfnStockRawMaterialshoratgestock(Convert.ToInt32(cmbCompany.SelectedValue), Convert.ToInt32(lblGroupCode.Text), Convert.ToInt32(LblRawMaterialCode.Text), locationcode, MainForm.pbUserID, MainForm.pbIpAddress, varInstock, varzerostock, varNegativeStock, varall, varWIPStk, "0", mainlocation);

        //    }
        //    else
        //    {
        //        objds = objspdservice.udfnStockRawMaterialshoratgestock(Convert.ToInt32(cmbCompany.SelectedValue), Convert.ToInt32(lblGroupCode.Text), Convert.ToInt32(LblRawMaterialCode.Text), locationcode, MainForm.pbUserID, MainForm.pbIpAddress, varInstock, varzerostock, varNegativeStock, varall, varWIPStk, "0", mainlocation);
        //    }

        //    //objspdservice.CloseConnection();
        //    if (objds != null)
        //    {
        //        if (objds.Tables.Count > 0)
        //        {
        //            if (objds.Tables[0].Rows.Count > 0)
        //            {
        //                if (rbStudent.Checked == true)
        //                {
        //                    lblNorecordFound.Visible = false;
        //                    rptviewer.Visible = true;
        //                    rptviewer.ReuseParameterValuesOnRefresh = true;
        //                    rptviewer.RefreshReport();

        //                    objBillreport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //                    objBillreport.Load(Application.StartupPath + "\\Reports\\.rpt");
        //                    //objBillreport.SetParameterValue("", );
        //                    //objBillreport.SetParameterValue("paraNegativeStk", varNegativeStock); 
        //                    objValidation.CrySqlConnection(objBillreport);
        //                    rptviewer.ReportSource = objBillreport;
        //                    rptviewer.Refresh();
        //                }
        //                else
        //                {
        //                    lblNorecordFound.Visible = false;
        //                    rptviewer.Visible = true;
        //                    rptviewer.ReuseParameterValuesOnRefresh = true;
        //                    rptviewer.RefreshReport();

        //                    objBillreport = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
        //                    objBillreport.Load(Application.StartupPath + "\\Reports\\.rpt");
        //                    //objBillreport.SetParameterValue("", );
        //                    //objBillreport.SetParameterValue("paraNegativeStk", varNegativeStock); 
        //                    objValidation.CrySqlConnection(objBillreport);
        //                    rptviewer.ReportSource = objBillreport;
        //                    rptviewer.Refresh();
        //                }
        //            }
        //            else
        //            {
        //                lblNorecordFound.Visible = true;
        //                rptviewer.Visible = false;
        //            }
        //        }
        //        else
        //        {
        //            lblNorecordFound.Visible = true;
        //            rptviewer.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        lblNorecordFound.Visible = true;
        //        rptviewer.Visible = false;
        //    }
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
            if (this.rptviewer != null)
            {
                rptviewer.ReportSource = null;
                this.rptviewer.Dispose();
                objBillreport.Close();
                objBillreport.Dispose();
                objBillreport = null;
                GC.Collect();
            }
        }
    }
}
