namespace ExpenseReimbursementSystem
{
    partial class ExpenseClaimsReimbursement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.defaultTablePanel = new System.Windows.Forms.Panel();
            this.btnAddClaims = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.expenseClaimsDataTable = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.informationEntryPanel = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_claimId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewImageColumn();
            this.Approve = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.defaultTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseClaimsDataTable)).BeginInit();
            this.informationEntryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1279, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataMenu,
            this.saveDataMenu,
            this.exitApplicationMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadDataMenu
            // 
            this.loadDataMenu.Name = "loadDataMenu";
            this.loadDataMenu.Size = new System.Drawing.Size(112, 24);
            this.loadDataMenu.Text = "Load";
            this.loadDataMenu.Click += new System.EventHandler(this.loadDataMenu_Click);
            // 
            // saveDataMenu
            // 
            this.saveDataMenu.Name = "saveDataMenu";
            this.saveDataMenu.Size = new System.Drawing.Size(112, 24);
            this.saveDataMenu.Text = "Save";
            this.saveDataMenu.Click += new System.EventHandler(this.saveDataMenu_Click);
            // 
            // exitApplicationMenu
            // 
            this.exitApplicationMenu.Name = "exitApplicationMenu";
            this.exitApplicationMenu.Size = new System.Drawing.Size(112, 24);
            this.exitApplicationMenu.Text = "Exit";
            this.exitApplicationMenu.Click += new System.EventHandler(this.exitApplicationMenu_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contentPanel.Controls.Add(this.defaultTablePanel);
            this.contentPanel.Controls.Add(this.informationEntryPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 27);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1279, 537);
            this.contentPanel.TabIndex = 2;
            // 
            // defaultTablePanel
            // 
            this.defaultTablePanel.Controls.Add(this.label8);
            this.defaultTablePanel.Controls.Add(this.btnAddClaims);
            this.defaultTablePanel.Controls.Add(this.txt_search);
            this.defaultTablePanel.Controls.Add(this.expenseClaimsDataTable);
            this.defaultTablePanel.Controls.Add(this.btnSave);
            this.defaultTablePanel.Controls.Add(this.btnCancel);
            this.defaultTablePanel.Location = new System.Drawing.Point(12, 123);
            this.defaultTablePanel.Name = "defaultTablePanel";
            this.defaultTablePanel.Size = new System.Drawing.Size(1255, 405);
            this.defaultTablePanel.TabIndex = 8;
            // 
            // btnAddClaims
            // 
            this.btnAddClaims.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddClaims.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddClaims.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClaims.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClaims.Location = new System.Drawing.Point(1128, 13);
            this.btnAddClaims.Name = "btnAddClaims";
            this.btnAddClaims.Size = new System.Drawing.Size(110, 33);
            this.btnAddClaims.TabIndex = 8;
            this.btnAddClaims.Text = "Add Claims";
            this.btnAddClaims.UseVisualStyleBackColor = false;
            this.btnAddClaims.Click += new System.EventHandler(this.btnAddClaims_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(101, 13);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(340, 32);
            this.txt_search.TabIndex = 6;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // expenseClaimsDataTable
            // 
            this.expenseClaimsDataTable.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expenseClaimsDataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.expenseClaimsDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseClaimsDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Description,
            this.Category,
            this.Amount,
            this.Date,
            this.Status,
            this.View,
            this.Approve,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expenseClaimsDataTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.expenseClaimsDataTable.Location = new System.Drawing.Point(10, 57);
            this.expenseClaimsDataTable.Name = "expenseClaimsDataTable";
            this.expenseClaimsDataTable.RowHeadersVisible = false;
            this.expenseClaimsDataTable.Size = new System.Drawing.Size(1230, 344);
            this.expenseClaimsDataTable.TabIndex = 5;
            this.expenseClaimsDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expenseClaimsDataTable_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1128, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 33);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1012, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 33);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // informationEntryPanel
            // 
            this.informationEntryPanel.Controls.Add(this.cmb_status);
            this.informationEntryPanel.Controls.Add(this.dateTimePicker1);
            this.informationEntryPanel.Controls.Add(this.txt_amount);
            this.informationEntryPanel.Controls.Add(this.label7);
            this.informationEntryPanel.Controls.Add(this.label6);
            this.informationEntryPanel.Controls.Add(this.txt_category);
            this.informationEntryPanel.Controls.Add(this.label5);
            this.informationEntryPanel.Controls.Add(this.label4);
            this.informationEntryPanel.Controls.Add(this.txt_description);
            this.informationEntryPanel.Controls.Add(this.label3);
            this.informationEntryPanel.Controls.Add(this.txt_claimId);
            this.informationEntryPanel.Controls.Add(this.label1);
            this.informationEntryPanel.Location = new System.Drawing.Point(12, 13);
            this.informationEntryPanel.Name = "informationEntryPanel";
            this.informationEntryPanel.Size = new System.Drawing.Size(1255, 105);
            this.informationEntryPanel.TabIndex = 7;
            // 
            // cmb_status
            // 
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Approved",
            "Not Approve"});
            this.cmb_status.Location = new System.Drawing.Point(990, 63);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(234, 27);
            this.cmb_status.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(990, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(234, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(730, 12);
            this.txt_amount.MaxLength = 10;
            this.txt_amount.Multiline = true;
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(179, 32);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_amount_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(650, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Amount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(930, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status:";
            // 
            // txt_category
            // 
            this.txt_category.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_category.Location = new System.Drawing.Point(403, 11);
            this.txt_category.Multiline = true;
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(224, 32);
            this.txt_category.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(930, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date:";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(101, 61);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(526, 32);
            this.txt_description.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description:";
            // 
            // txt_claimId
            // 
            this.txt_claimId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_claimId.Location = new System.Drawing.Point(101, 11);
            this.txt_claimId.MaxLength = 10;
            this.txt_claimId.Multiline = true;
            this.txt_claimId.Name = "txt_claimId";
            this.txt_claimId.Size = new System.Drawing.Size(207, 32);
            this.txt_claimId.TabIndex = 1;
            this.txt_claimId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_claimId_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Claim Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(971, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "EXPENSE CLAIMS REIMBURSEMENT";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ExpenseReimbursementSystem.Properties.Resources.view_details;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::ExpenseReimbursementSystem.Properties.Resources.approved_stamp;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::ExpenseReimbursementSystem.Properties.Resources.edit;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "";
            this.dataGridViewImageColumn4.Image = global::ExpenseReimbursementSystem.Properties.Resources.delete;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Claim Id";
            this.Id.Name = "Id";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.Width = 390;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.Width = 155;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 145;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 120;
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.Image = global::ExpenseReimbursementSystem.Properties.Resources.view_details;
            this.View.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.View.Name = "View";
            this.View.Width = 50;
            // 
            // Approve
            // 
            this.Approve.HeaderText = "";
            this.Approve.Image = global::ExpenseReimbursementSystem.Properties.Resources.approved_stamp;
            this.Approve.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Approve.Name = "Approve";
            this.Approve.Width = 50;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Image = global::ExpenseReimbursementSystem.Properties.Resources.edit;
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::ExpenseReimbursementSystem.Properties.Resources.delete;
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Width = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(11, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Search:";
            // 
            // ExpenseClaimsReimbursement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 564);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseClaimsReimbursement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExpenseClaimsReimbursement";
            this.Load += new System.EventHandler(this.ExpenseClaimsReimbursement_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.defaultTablePanel.ResumeLayout(false);
            this.defaultTablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expenseClaimsDataTable)).EndInit();
            this.informationEntryPanel.ResumeLayout(false);
            this.informationEntryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataMenu;
        private System.Windows.Forms.ToolStripMenuItem saveDataMenu;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationMenu;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel defaultTablePanel;
        private System.Windows.Forms.Button btnAddClaims;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.DataGridView expenseClaimsDataTable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel informationEntryPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_claimId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn View;
        private System.Windows.Forms.DataGridViewImageColumn Approve;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label8;
    }
}