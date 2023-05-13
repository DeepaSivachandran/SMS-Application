using SMSApplication.ServiceClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMSApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            try
            {
                string varVersion = "v1.0.0";
                string varPath = Application.StartupPath + "\\Server Settings\\serversettings.txt";
                if (File.Exists(varPath))
                {
                    udfnInsertVersion(varVersion);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Authentication());
                }
                else { Application.Run(new ServerSettings()); }
            }
            catch (Exception ex)
            {
                DataError objerror = new DataError();
                objerror.WriteFile(ex);
            }
        }
        // Author : Deepa
        // Created Date: 2019-04-06 
        public static void udfnInsertVersion(string varVersion)
        {
            try
            {
                // Insert version details to release table
                SPDataService objDserv = new SPDataService();
                DataService objDser = new DataService();
                DataSet objGetRelease = objDser.GetDataset("select * from TRANS_Release where VersionNumber='" + varVersion + "'");
                if (objGetRelease.Tables[0].Rows.Count == 0)
                {
                    string varReleaseNo = objDser.displaydata("select isnull(max(ReleaseNumber),1)+1 from TRANS_Release");
                    objDserv.udfnExecuteQuery("Insert into TRANS_Release(ReleaseDate,ReleaseNumber,VersionNumber) values (GETDATE(),'" + varReleaseNo + "','" + varVersion + "') ");
                }
                objDserv.CloseConnection();
            }
            catch (Exception ex) { DataError objerror = new DataError(); objerror.WriteFile(ex); }
        }
    }
}
