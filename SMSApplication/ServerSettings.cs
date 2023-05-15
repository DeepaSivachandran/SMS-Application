
using SMSApplication.ServiceClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SMSApplication
{
    public partial class ServerSettings : Form
    {
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840

        private SecurityController _security;
        // ********** Object for Service Classed Initialisation **********
        Authentication objauth = new Authentication();
        DataValidation objvalidation = new DataValidation();
        public DataError objError;
        DataBind objbind = new DataBind();

        // ********** Tooltips Initialisation **********
        private ToolTip tpServierName = new ToolTip();
        private ToolTip tpDBName = new ToolTip();
        private ToolTip tpDBUserName = new ToolTip();
        private ToolTip tpPassword = new ToolTip();
        private ToolTip tpWebServiceName = new ToolTip();
        public ServerSettings()
        {
            InitializeComponent();
            objvalidation.setFontAndFontSize(this);
            _security = new SecurityController();
        }
        // ********** String Encryption **********
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        public string GenerateMD5(string HashString)
        {
            return string.Join("", MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(HashString)).Select(s => s.ToString("x2")));
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // ********** Load Server Settings Details **********
                UdfnEdit();
            }
            catch (Exception EX)
            {
                objError = new DataError();objError.WriteFile(EX);
            }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        public void UdfnEdit() {
            try {
                string path = Application.StartupPath + "\\Server Settings\\serversettings.txt";
                if (File.Exists(path))
                {
                    string lines = File.ReadAllText(path);
                    if (lines != null & lines != "")
                    {
                        string[] words = lines.Split(',');
                        txtServerName.Text = words[0];
                        txtDataBase.Text = words[1];
                        txtDBUserName.Text = words[2];
                        SPCall objSpCall = new SPCall();
                        txtPassword.Text = _security.Decrypt(words[2], words[3]);
                        objSpCall.CloseConnection();
                        btnSave.Text = "Update";
                    }
                }
            } catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // ********** Validation **********
                bool errorflag = false;
                if (txtServerName.Text == "" || txtServerName.Text == null)
                {
                    errorProvider1.SetError(txtServerName, "Please enter server name.");
                    txtServerName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpServierName.Show("Please enter server name.", txtServerName, 5000);
                    errorflag = true;
                }
                else
                {
                    txtServerName.BackColor = Color.White;
                    tpServierName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtDataBase.Text == "" || txtDataBase.Text == null)
                {
                    errorProvider1.SetError(txtDataBase, "Please enter database name.");
                    txtDataBase.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpDBName.Show("Please enter database name.", txtDataBase, 5000);
                    errorflag = true;
                }
                else
                {
                    txtDataBase.BackColor = Color.White;
                    tpDBName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtDBUserName.Text == "" || txtDBUserName.Text == null)
                {
                    errorProvider1.SetError(txtDBUserName, "Please enter database user name.");
                    txtDBUserName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpDBUserName.Show("Please enter database user name.", txtDBUserName, 5000);
                    errorflag = true;
                }
                else
                {
                    txtDBUserName.BackColor = Color.White;
                    tpDBUserName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtPassword.Text == "" || txtPassword.Text == null)
                {
                    errorProvider1.SetError(txtPassword, "Please enter password.");
                    txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpPassword.Show("Please enter password.", txtPassword, 5000);
                    errorflag = true;
                }
                else
                {
                    txtPassword.BackColor = Color.White;
                    tpPassword.Active = false;
                    errorProvider1.Clear();
                }
                // ********** Saving Data **********
                if (errorflag == false)
                {
                    string name = System.Diagnostics.Process.GetCurrentProcess().ProcessName.Replace(".vshost", "");
                    string path = Application.StartupPath+"\\Server Settings";
                    // Check server settings folder exists
                    if (!Directory.Exists(path))
                    {  Directory.CreateDirectory(path); }
                    string filepath = Application.StartupPath + "\\Server Settings\\serversettings.txt";
                    // Check server settings file exists
                    if (File.Exists(filepath))
                    { File.Delete(filepath);}
                    File.Create(filepath).Close();
                    // Writing lines to text file
                    using (var tw = new StreamWriter(filepath, true))
                    {
                        //tw.WriteLine(txtServerName.Text+","+txtDataBase.Text+","+txtDBUserName.Text+","+Encrypt(txtPassword.Text, "sblw-3hn8-sqoy19") +","+txtWebServiceName.Text.Trim().Replace("\n", "").Replace("\r", "").Replace("http://", "").Replace("http:/", "").Replace("https://", "").Replace("https:/", ""));
                        tw.WriteLine(txtServerName.Text + "," + txtDataBase.Text + "," + txtDBUserName.Text + "," + _security.Encrypt(txtDBUserName.Text,txtPassword.Text));
                    }
                    MessageBox.Show("Server settings saved successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    if (lblformname.Text == "login")
                    {
                        Authentication au = new Authentication();
                        au.Show();
                    }
                    else if (lblformname.Text == "activation") { }
                    else
                    {
                        //Activation ac = new Activation();
                        //ac.Show();
                        Program.Main();
                        //  Application.Run(new Activation());
                    }
                    lblformname.Text = "";
                    //Form.ActiveForm.Refresh();
                }
            }
            catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        public static string Encrypt(string input, string key)
        {
            try
            {
                byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                return Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (Exception ex) { return ""; }
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        private void Form1_Leave(object sender, EventArgs e)
        {
            // ********** Deactivate all tooltips **********
            tpDBName.Active = false;
            tpDBUserName.Active = false;
            tpPassword.Active = false;
            tpServierName.Active = false;
            tpWebServiceName.Active = false;
        }
        // Author : Lavanya
        // Created Date: 2019-04-06 10:22:51.840
        private void btncancel_Click(object sender, EventArgs e)
        {
            try {
                // ********** Validations **********
                bool errorflag = false;
                if (txtServerName.Text == "" || txtServerName.Text == null)
                {
                    errorProvider1.SetError(txtServerName, "Please enter server name.");
                    txtServerName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpServierName.Show("Please enter server name.", txtServerName, 5000);
                    errorflag = true;
                }
                else
                {
                    txtServerName.BackColor = Color.White;
                    tpServierName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtDataBase.Text == "" || txtDataBase.Text == null)
                {
                    errorProvider1.SetError(txtDataBase, "Please enter database name.");
                    txtDataBase.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpDBName.Show("Please enter database name.", txtDataBase, 5000);
                    errorflag = true;
                }
                else
                {
                    txtDataBase.BackColor = Color.White;
                    tpDBName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtDBUserName.Text == "" || txtDBUserName.Text == null)
                {
                    errorProvider1.SetError(txtDBUserName, "Please enter database user name.");
                    txtDBUserName.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpDBUserName.Show("Please enter database user name.", txtDBUserName, 5000);
                    errorflag = true;
                }
                else
                {
                    txtDBUserName.BackColor = Color.White;
                    tpDBUserName.Active = false;
                    errorProvider1.Clear();
                }
                if (txtPassword.Text == "" || txtPassword.Text == null)
                {
                    errorProvider1.SetError(txtPassword, "Please enter password.");
                    txtPassword.BackColor = System.Drawing.ColorTranslator.FromHtml("#fabdbd");
                    tpPassword.Show("Please enter password.", txtPassword, 5000);
                    errorflag = true;
                }
                else
                {
                    txtPassword.BackColor = Color.White;
                    tpPassword.Active = false;
                    errorProvider1.Clear();
                }
                if (errorflag == false) {
                    // ********** DB connection checking **********
                    using (SqlConnection connection = new SqlConnection("Data Source='" + txtServerName.Text + "';Initial Catalog='" + txtDataBase.Text + "';User ID='" + txtDBUserName.Text + "';Password='" + txtPassword.Text + "'"))
                    {
                        connection.Open();
                        if (connection.State == ConnectionState.Open)
                        { MessageBox.Show("Database connected successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                        connection.Close();
                        btnSave.Enabled = true;
                    }
                }
            } catch (Exception ex) { btnSave.Enabled = false; MessageBox.Show("Please check database credentials!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1); }
        }
        private void txtservername_Enter(object sender, EventArgs e)
        {
            try { txtServerName.BackColor = Color.LemonChiffon; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtservername_Leave(object sender, EventArgs e)
        {
            try { txtServerName.BackColor = Color.White ; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtservername_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyCode == Keys.Enter) { txtDataBase.Focus(); } } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtdatabase_Enter(object sender, EventArgs e)
        {
            try { txtDataBase.BackColor = Color.LemonChiffon; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtdatabase_Leave(object sender, EventArgs e)
        {
            try { txtDataBase.BackColor = Color.White; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtdatabase_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyCode == Keys.Enter) { txtDBUserName.Focus(); } } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtusername_Leave(object sender, EventArgs e)
        {
            try { txtDBUserName.BackColor = Color.White; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtusername_Enter(object sender, EventArgs e)
        {
            try { txtDBUserName .BackColor = Color.LemonChiffon; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtusername_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyCode == Keys.Enter) { txtPassword.Focus(); } } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtpaswword_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyCode == Keys.Enter) { btnSave.Focus(); } } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtpaswword_Leave(object sender, EventArgs e)
        {
            try { txtPassword.BackColor = Color.White; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtpaswword_Enter(object sender, EventArgs e)
        {
            try { txtPassword.BackColor = Color.LemonChiffon; } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void txtwebservicename_KeyDown(object sender, KeyEventArgs e)
        {
            try { if (e.KeyCode == Keys.Enter) { btnSave.Focus(); } } catch (Exception ex) { objError = new DataError(); objError.WriteFile(ex); }
        }
        private void ServerSettings_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    DialogResult dialogResult = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                objError = new DataError();
                objError.WriteFile(ex);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            udfnclose();
        }
        public void udfnclose() {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                    // Redirecting corresponding forms
                    Authentication au = new Authentication();
                    au.Show();
                    lblformname.Text = "";
                }
            } catch (Exception ex) { objError = new DataError();objError.WriteFile(ex); }
        } 
    }
    }

