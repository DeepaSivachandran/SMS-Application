using SMSApplication.ServiceClass;
using System;
using System.Windows.Forms;

namespace SMSApplication
{
    public partial class Start : Form
    {
        DataValidation objValidation = new DataValidation();
        DataError objerror;
        public Start()
        {
            InitializeComponent();
            objValidation.resolutionsettingsForm(this);
            objValidation.setFontAndFontSize(this);
        //    objValidation.setFontSize_TotalLabel(this.lblUserName);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            try
            {
                // lblUserName.Text = "Welcome "+ MainForm.pbUserID;
                ((MainForm)ParentForm).tssTotalCount.Visible = false;
                ((MainForm)ParentForm).tsslable.Visible = false;
            }
            catch (Exception ex)
            {
                objerror = new DataError();
                objerror.WriteFile(ex);  }

        }
    }
}
