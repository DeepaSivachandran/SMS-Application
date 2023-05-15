namespace SMSApplication
{
    partial class MR_TemplateList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MR_TemplateList));
            this.grdSchemeList = new System.Windows.Forms.DataGridView();
            this.clmsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSchemeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDNoRecordFound = new System.Windows.Forms.Label();
            this.tspMenu = new System.Windows.Forms.ToolStrip();
            this.tspFormHeader = new System.Windows.Forms.ToolStripLabel();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.lblDcolumnIndex = new System.Windows.Forms.Label();
            this.picLoader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdSchemeList)).BeginInit();
            this.tspMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).BeginInit();
            this.SuspendLayout();
            // 
            // grdSchemeList
            // 
            this.grdSchemeList.AllowUserToAddRows = false;
            this.grdSchemeList.AllowUserToDeleteRows = false;
            this.grdSchemeList.AllowUserToResizeRows = false;
            this.grdSchemeList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdSchemeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdSchemeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grdSchemeList.ColumnHeadersHeight = 30;
            this.grdSchemeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdSchemeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmsno,
            this.clmSchemeName,
            this.Column1,
            this.Column2,
            this.clmShortName});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSchemeList.DefaultCellStyle = dataGridViewCellStyle16;
            this.grdSchemeList.EnableHeadersVisualStyles = false;
            this.grdSchemeList.GridColor = System.Drawing.Color.White;
            this.grdSchemeList.Location = new System.Drawing.Point(17, 28);
            this.grdSchemeList.Name = "grdSchemeList";
            this.grdSchemeList.ReadOnly = true;
            this.grdSchemeList.RowHeadersVisible = false;
            this.grdSchemeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdSchemeList.Size = new System.Drawing.Size(1325, 559);
            this.grdSchemeList.TabIndex = 18;
            this.grdSchemeList.DoubleClick += new System.EventHandler(this.grdSchemeList_DoubleClick);
            this.grdSchemeList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grdSchemeList_KeyDown);
            // 
            // clmsno
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmsno.DefaultCellStyle = dataGridViewCellStyle14;
            this.clmsno.HeaderText = "S.No.";
            this.clmsno.Name = "clmsno";
            this.clmsno.ReadOnly = true;
            this.clmsno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmsno.Width = 60;
            // 
            // clmSchemeName
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.clmSchemeName.DefaultCellStyle = dataGridViewCellStyle15;
            this.clmSchemeName.HeaderText = "Template Name";
            this.clmSchemeName.Name = "clmSchemeName";
            this.clmSchemeName.ReadOnly = true;
            this.clmSchemeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmSchemeName.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sender ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Content Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // clmShortName
            // 
            this.clmShortName.HeaderText = "Status";
            this.clmShortName.Name = "clmShortName";
            this.clmShortName.ReadOnly = true;
            this.clmShortName.Width = 150;
            // 
            // lblDNoRecordFound
            // 
            this.lblDNoRecordFound.AutoSize = true;
            this.lblDNoRecordFound.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNoRecordFound.Location = new System.Drawing.Point(619, 299);
            this.lblDNoRecordFound.Name = "lblDNoRecordFound";
            this.lblDNoRecordFound.Size = new System.Drawing.Size(121, 17);
            this.lblDNoRecordFound.TabIndex = 958721;
            this.lblDNoRecordFound.Text = "No Records Found";
            this.lblDNoRecordFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tspMenu
            // 
            this.tspMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tspMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspFormHeader,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbEdit,
            this.toolStripSeparator2,
            this.tsbNew});
            this.tspMenu.Location = new System.Drawing.Point(0, 0);
            this.tspMenu.Name = "tspMenu";
            this.tspMenu.Size = new System.Drawing.Size(1360, 31);
            this.tspMenu.TabIndex = 958722;
            this.tspMenu.Text = "toolStrip1";
            // 
            // tspFormHeader
            // 
            this.tspFormHeader.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspFormHeader.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspFormHeader.Margin = new System.Windows.Forms.Padding(15, 1, 0, 2);
            this.tspFormHeader.Name = "tspFormHeader";
            this.tspFormHeader.Size = new System.Drawing.Size(61, 28);
            this.tspFormHeader.Text = "Template";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDelete.Image = global::SMSApplication.Properties.Resources.delete16X16;
            this.tsbDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(65, 28);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEdit.Image = global::SMSApplication.Properties.Resources.edit__2_;
            this.tsbEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Margin = new System.Windows.Forms.Padding(0, 1, 15, 2);
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(50, 28);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // tsbNew
            // 
            this.tsbNew.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbNew.Image = global::SMSApplication.Properties.Resources.New;
            this.tsbNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(62, 28);
            this.tsbNew.Text = "New";
            this.tsbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // lblDcolumnIndex
            // 
            this.lblDcolumnIndex.AutoSize = true;
            this.lblDcolumnIndex.Location = new System.Drawing.Point(918, 0);
            this.lblDcolumnIndex.Name = "lblDcolumnIndex";
            this.lblDcolumnIndex.Size = new System.Drawing.Size(15, 17);
            this.lblDcolumnIndex.TabIndex = 958723;
            this.lblDcolumnIndex.Text = "0";
            this.lblDcolumnIndex.Visible = false;
            // 
            // picLoader
            // 
            this.picLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picLoader.ErrorImage = null;
            this.picLoader.Image = ((System.Drawing.Image)(resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = null;
            this.picLoader.Location = new System.Drawing.Point(17, 28);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(1325, 559);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 958787;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // MR_TemplateList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1360, 607);
            this.Controls.Add(this.lblDcolumnIndex);
            this.Controls.Add(this.tspMenu);
            this.Controls.Add(this.lblDNoRecordFound);
            this.Controls.Add(this.grdSchemeList);
            this.Controls.Add(this.picLoader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MR_TemplateList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CP_SchemeList";
            this.Load += new System.EventHandler(this.MR_TemplateList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdSchemeList)).EndInit();
            this.tspMenu.ResumeLayout(false);
            this.tspMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView grdSchemeList;
        private System.Windows.Forms.Label lblDNoRecordFound;
        private System.Windows.Forms.ToolStrip tspMenu;
        private System.Windows.Forms.ToolStripLabel tspFormHeader;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.Label lblDcolumnIndex;
        private System.Windows.Forms.PictureBox picLoader;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmsno;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSchemeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmShortName;
    }
}