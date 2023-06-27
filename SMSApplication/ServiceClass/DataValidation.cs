﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Net;

namespace SMSApplication.ServiceClass
{
    class DataValidation
    {
        DataError objError;
        public bool blnFlag;
        public SecurityController _security;
        public DataValidation()
        {
            //' this is constructor
        }
        public string Encrypt(string text)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(text);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    text = Convert.ToBase64String(ms.ToArray());
                }
            }
            return text;
        }
        public string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public void screensettings(Form SSSExamCell)
        {
            int i = Screen.FromControl(SSSExamCell).Bounds.Width;
            int k = i / 2;
            int fw = SSSExamCell.Width;
            int s = fw / 2;
            SSSExamCell.Location = new System.Drawing.Point((k - s) - 5, 30);
        }
        public void screensettingsChild(Form SSSExamCell)
        {
            int i = Screen.FromControl(SSSExamCell).Bounds.Width;
            int k = i / 2;
            int fw = SSSExamCell.Width;
            int s = fw / 2;
            SSSExamCell.Location = new System.Drawing.Point(k - s, 80);
        }
        public void resolutionsettings(Panel mainpanel, Form SSSExamCell)
        {
            try
            {
                int pointx, pointy, screenwidth, screenheight, panelwidth, panelheight;
                panelwidth = mainpanel.Width;
                panelheight = mainpanel.Height;
                screenheight = Screen.PrimaryScreen.WorkingArea.Height;
                screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
                if (screenwidth > 1366)
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    mainpanel.Location = new Point(pointx, (pointy - 50));
                    SSSExamCell.Size = new Size(screenwidth - 5, screenheight - 127);
                }
                else
                {
                    mainpanel.BackColor = System.Drawing.Color.White;
                    SSSExamCell.BackColor = System.Drawing.SystemColors.ActiveBorder;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        
        public bool internetconnection()
        {

            try
            {
                string[] dnsAddresses = { "8.8.8.8", "208.67.222.222" }; // DNS servers to ping for internet connectivity

                foreach (string dnsAddress in dnsAddresses)
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send(dnsAddress);

                    if (reply.Status == IPStatus.Success)
                    {
                        IPHostEntry hostEntry = Dns.GetHostEntry("www.google.com");
                        if (hostEntry.AddressList.Length > 0)
                        {
                            return true; // Internet is available
                        }
                    }
                }
            }
            catch
            {
                // An exception occurred or internet is not available
            }

            return false; // Internet is not available


        }

        public void fullresolutionsettingsForm(Form SSSExamCell)
        {
            try
            {
                int screenwidth, screenheight, panelwidth, panelheight, pointx, pointy;
                panelwidth = SSSExamCell.Width;
                panelheight = SSSExamCell.Height;
                screenheight = Screen.PrimaryScreen.WorkingArea.Height;
                screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
                if (screenwidth > 1366)
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    SSSExamCell.Location = new Point(pointx, (pointy - 35));
                }
                else
                {
                    SSSExamCell.BackColor = System.Drawing.SystemColors.ActiveBorder;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public void resolutionsettingsForm(Form SSSExamCell)
        {
            try
            {
                int screenwidth, screenheight, panelwidth, panelheight, pointx, pointy;
                panelwidth = SSSExamCell.Width;
                panelheight = SSSExamCell.Height;
                screenheight = Screen.PrimaryScreen.WorkingArea.Height;
                screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
                if (screenwidth > 1366)
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    SSSExamCell.Location = new Point(pointx, (pointy - 35));
                    if (SSSExamCell.BackColor == SystemColors.AppWorkspace)
                    {
                        SSSExamCell.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    }
                    else
                    {
                        SSSExamCell.BackColor = System.Drawing.SystemColors.Window;
                    }

                }
                else
                {
                    if (SSSExamCell.BackColor == SystemColors.AppWorkspace)
                    {
                        SSSExamCell.BackColor = System.Drawing.SystemColors.AppWorkspace;
                    }
                    else
                    {
                        SSSExamCell.BackColor = System.Drawing.SystemColors.Window;
                    }
                }
                //else if (screenwidth == 1280)
                //{
                //    Accounts.StartPosition = FormStartPosition.Manual;
                //    //mainpanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
                //    //pointx = ((screenwidth / 2) - (panelwidth / 2));
                //    //pointy = ((screenheight / 2) - (panelheight / 2));
                //    //Accounts.Location = new Point(pointx-100, (pointy - 135));
                //    Accounts.BackColor = System.Drawing.Color.White;
                //    Accounts.Size = new Size(screenwidth - 15, screenheight - 120);
                //    Accounts.AutoScroll = true;
                //}
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public void ListResolutionFormCompany(Form SSSExamCell)
        {
            try
            {
                int screenwidth, screenheight, panelwidth, panelheight, pointx, pointy;
                panelwidth = SSSExamCell.Width;
                panelheight = SSSExamCell.Height;
                screenheight = Screen.PrimaryScreen.WorkingArea.Height;
                screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
                if (screenwidth > 1366)
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    SSSExamCell.Location = new Point(pointx + 100, (pointy));

                }
                else
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    SSSExamCell.Location = new Point(pointx + 100, (pointy - 20));
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
                throw ex;
            }
        }
        public bool FormatAlphbetic(string inputText)
        {

            try
            {
                if (Regex.IsMatch(inputText, "^[A-Za-z .]*$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public bool FormatSpecialCharacter(string inputText)
        {

            try
            {
                if (Regex.IsMatch(inputText, "[^0-9A-Za-z@()/ \b_-]+$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public bool FormatAlphbeticOnly(string inputText)
        {
            try
            {
                if (Regex.IsMatch(inputText, "^[A-Za-z ]*$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public string getcurrencyvalue(string varValue)
        {
            string varreturnvalue = "";
            try
            {
                decimal parsed = decimal.Parse(varValue, CultureInfo.InvariantCulture);
                CultureInfo hindi = new CultureInfo("hi-IN");
                string text = string.Format(hindi, "{0:c}", parsed);
                varreturnvalue = text.Substring(2, text.Length - 2);
                if (varreturnvalue.StartsWith(","))
                {
                    varreturnvalue = text.Substring(1, text.Length - 1);
                }
                if (double.Parse(varValue) != double.Parse(varreturnvalue))
                {
                    varreturnvalue = text.Substring(1, text.Length - 1);
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return varreturnvalue;
        }
        public string identifier(string wmiClass, string wmiProperty)
        {
            string result = "";
            System.Management.ManagementClass mc =
        new System.Management.ManagementClass(wmiClass);
            System.Management.ManagementObjectCollection moc = mc.GetInstances();
            foreach (System.Management.ManagementObject mo in moc)
            {
                if (result == "")
                {
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return result;
        }
        public string baseId()
        {
            return identifier("Win32_BaseBoard", "Model") + ","
            + identifier("Win32_BaseBoard", "Manufacturer") + ","
            + identifier("Win32_BaseBoard", "Name") + ","
            + identifier("Win32_BaseBoard", "SerialNumber");
        }
        public bool FormatEMail(string inputText)
        {
            try
            {
                if (Regex.IsMatch(inputText, "^([\\w-_]+\\.)*[\\w-_]+\\@([\\w-_]+\\.)+[a-zA-Z]{2,3}$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public bool FormatNumeric(string inputText)
        {

            try
            {
                double output = 0;
                if (double.TryParse(inputText, NumberStyles.Number, CultureInfo.InvariantCulture, out output) == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public void ListResolutionForm(Form SSSExamCell)
        {
            try
            {
                int screenwidth, screenheight, panelwidth, panelheight, pointx, pointy;
                panelwidth = SSSExamCell.Width;
                panelheight = SSSExamCell.Height;
                screenheight = Screen.PrimaryScreen.WorkingArea.Height;
                screenwidth = Screen.PrimaryScreen.WorkingArea.Width;
                if (screenwidth > 1366)
                {
                    pointx = ((screenwidth / 2) - (panelwidth / 2));
                    pointy = ((screenheight / 2) - (panelheight / 2));
                    SSSExamCell.Location = new Point(pointx + 100, (pointy - 35));
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
                throw ex;
            }
        }
        public void setFontAndFontSize(Form SSSExamCell)
        {
            try
            {
                GetAllControls(SSSExamCell, new List<Control>());
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }    
        private List<Control> GetAllControls(Control container, List<Control> list)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox) { list.Add(c);c.Font= new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is Label) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI",9.5F); }
                if (c is RadioButton) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is DataGrid) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is Button) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is CheckBox) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is GroupBox) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c is LinkLabel) { list.Add(c); c.Font = new System.Drawing.Font("Segoe UI", 9.5F); }
                if (c.Controls.Count > 0)
                    list = GetAllControls(c, list);
            }
            return list;
        }
        public void setFontSize_TotalLabel(Label lblTotal)
        {
            try
            {
                lblTotal.Font =new System.Drawing.Font("Segoe UI", 20F);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public void setFontSize_TotalTextBox(TextBox txtTotal)
        {
            try
            {
                txtTotal.Font = new System.Drawing.Font("Segoe UI", 20F);
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        public bool CheckSpecialCharacter(KeyPressEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9A-Za-z@().,#/' \b_-]+$"))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); return false; }
        }
        public bool CheckNumeric(KeyPressEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9 \b]+$"))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); return false; }
        }
        public bool FormatAlphbeticNumericAndSpecialchar(string inputText)
        {
            try
            {
                if (Regex.IsMatch(inputText, "^[A-Za-z0-9 ,.\"+*-/_()&@']*$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }

            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public bool CheckWithSpecialCharacter(KeyPressEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9A-Za-z@()'. /\b_-]+$"))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); return false; }
        }
        public bool FormatSpecialCharacterKey(KeyPressEventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "[^0-9A-Za-z@() /\b_-]+$"))
                {
                    return true;
                }
                else { return false; }
            }
            catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); return false; }
        }
        public bool FormatNumericOnly(string inputText)
        {
            try
            {
                if (Regex.IsMatch(inputText, "^[0-9]*$") == true)
                {
                    blnFlag = true;
                }
                else
                {
                    blnFlag = false;
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
            return blnFlag;
        }
        public void CrySqlConnection(ReportDocument objBillReport)
        {
            try
            {
                SPCall tmpspcall = new SPCall();
                SqlConnection objConn = new SqlConnection();
                //  SqlConnection objConn = new SqlConnection(ConfigurationManager.AppSettings["ConnStr"]);
                string connectstring = tmpspcall.connectionstring();
                objConn = new System.Data.SqlClient.SqlConnection(connectstring);

                TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
                TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
                ConnectionInfo crConnectionInfo = new ConnectionInfo();
                Tables CrTables = default(Tables);
                crConnectionInfo.ServerName = objConn.DataSource;
                crConnectionInfo.DatabaseName = objConn.Database;
                string path = Application.StartupPath + "\\Server Settings\\serversettings.txt";
                _security = new SecurityController();
                if (File.Exists(path))
                {
                    string lines = File.ReadAllText(path);
                    if (lines != null & lines != "")
                    {
                        string[] words = lines.Split(',');
                        crConnectionInfo.UserID = words[2];
                        // string pwd = Decrypt(words[3], "sblw-3hn8-sqoy19");
                        string pwd = _security.Decrypt(words[2], words[3]);
                        crConnectionInfo.Password = pwd;
                    }
                }
                // crConnectionInfo.Password = System.Configuration.ConfigurationManager.AppSettings["SqlPassword"];
                CrTables = objBillReport.Database.Tables;
                foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
                {
                    crtableLogoninfo = CrTable.LogOnInfo;
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                    CrTable.ApplyLogOnInfo(crtableLogoninfo);
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
