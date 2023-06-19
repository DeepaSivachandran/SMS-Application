 
using SMSApplication.ServiceClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                SecurityController _security = new SecurityController();
                string varVersion = "v1.0.0";
                string varPath = Application.StartupPath + "\\Server Settings\\serversettings.txt";
                if (File.Exists(varPath))
                {
                    udfnInsertVersion(varVersion); string varSerialNumber = "";
                    DataValidation obj = new DataValidation();
                    varSerialNumber = obj.baseId();
                    string regkey = string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(varSerialNumber)).Select(s => s.ToString("x2"))); //GenerateMD5(processid + uniqueid);
                    string foldername = obj.Encrypt("Activation");
                    string path2 = Application.StartupPath + "\\" + foldername;
                    if (Directory.Exists(path2))
                    {
                        string encriptedtext = _security.Encrypt("Activation", regkey.ToUpper());
                        string[] files = Directory.GetFiles(path2);
                        string filename = "";
                        foreach (string file in files)
                            filename = (Path.GetFileName(file));
                        string decryptedfile = obj.Decrypt(filename.Replace(".sss", ""));
                        if (decryptedfile == "Activation")
                        {
                            path2 = path2 + "\\" + filename;
                            FileInfo info = new FileInfo(path2);
                            if (info.Exists)
                            {
                                var fileContents = System.IO.File.ReadAllText(path2);
                                string[] values = fileContents.Replace("\r", "").Split('\n');
                                if (values.Length > 1)
                                {
                                    ActivationService.ActivationService objActivationService = new ActivationService.ActivationService();
                                    ActivationService.ActivationService activser = new ActivationService.ActivationService();
                                    string rs = ""; string st = "";
                                    string key = obj.Decrypt(values[0]);
                                    string otp = obj.Decrypt(values[1]);
                                    string customername = obj.Decrypt(values[2]);
                                    string mobileno = obj.Decrypt(values[3]);
                                    string emailid = obj.Decrypt(values[4]);
                                    string address = obj.Decrypt(values[5]);
                                    rs = activser.udfnAuthenticate(customername, mobileno, emailid, address, key, "", otp, "29");                                  
                                    if (rs == "Success" || rs == "Activated")
                                    {
                                        st = "success";
                                    }
                                    else if (rs == "Blocked")
                                    {
                                        st = "error";
                                    }
                                    else { st = ""; rs = ""; }
                                    if (st == "error" || st == "")
                                    {
                                        Application.EnableVisualStyles();
                                        Application.SetCompatibleTextRenderingDefault(false);
                                         Application.Run(new Activation());
                                    }
                                    else
                                    {
                                        Application.EnableVisualStyles();
                                        Application.SetCompatibleTextRenderingDefault(false);
                                        //Application.Run(new Expandablegrd());


                                        Application.Run(new Authentication());
                                    }
                                }
                                else
                                {
                                    Application.EnableVisualStyles();
                                    Application.SetCompatibleTextRenderingDefault(false);
                                     Application.Run(new Activation());
                                }
                            }
                            else
                            {
                                Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                 Application.Run(new Activation());
                            }
                        }
                        else
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                             Application.Run(new Activation());
                        }
                    }
                    else
                    {
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                         Application.Run(new Activation());
                    }

                 

            }
                else { Application.Run(new ServerSettings()); }
            }
            catch (Exception ex)
            {
                DataError objerror = new DataError();
                objerror.WriteFile(ex);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 
        public static void udfnInsertVersion(string varVersion)
        {
            try
            {
                // Insert version details to release table
                SPDataService objDserv = new SPDataService();
                DataService objDser = new DataService();
                DataSet objGetRelease = objDser.GetDataset("select * from MR_Version where VS_VersionNumber='" + varVersion + "'");
                if (objGetRelease.Tables[0].Rows.Count == 0)
                {
                    string varReleaseNo = objDser.displaydata("select isnull(max(VS_Id),0)+1 from MR_Version");
                    objDserv.udfnExecuteQuery("Insert into MR_Version(VS_ReleaseDate,VS_Id,VS_VersionNumber) values (GETDATE(),'" + varReleaseNo + "','" + varVersion + "') ");
                }
                objDserv.CloseConnection();
            }
            catch (Exception ex) { DataError objerror = new DataError(); objerror.WriteFile(ex); }
        }
    }
}
