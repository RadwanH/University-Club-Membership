namespace UniversityClubDB
{
    partial class Budget
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budget));
            System.Windows.Forms.Label bgt_idLabel;
            System.Windows.Forms.Label issuedto_subidLabel;
            System.Windows.Forms.Label bgt_amntLabel;
            System.Windows.Forms.Label bgt_typeLabel;
            System.Windows.Forms.Label issued_dateLabel;
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.budgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.budgetTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            this.budgetBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.budgetBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.budgetDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgt_idTextBox = new System.Windows.Forms.TextBox();
            this.issuedto_subidTextBox = new System.Windows.Forms.TextBox();
            this.bgt_amntTextBox = new System.Windows.Forms.TextBox();
            this.bgt_typeTextBox = new System.Windows.Forms.TextBox();
            this.issued_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            bgt_idLabel = new System.Windows.Forms.Label();
            issuedto_subidLabel = new System.Windows.Forms.Label();
            bgt_amntLabel = new System.Windows.Forms.Label();
            bgt_typeLabel = new System.Windows.Forms.Label();
            issued_dateLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingNavigator)).BeginInit();
            this.budgetBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.memberTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(997, 164);
            this.panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::UniversityClubDB.Properties.Resources.admin_icon;
            this.pictureBox3.Location = new System.Drawing.Point(558, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(71, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::UniversityClubDB.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(894, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UniversityClubDB.Properties.Resources.home_icon2;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // memberTitle
            // 
            this.memberTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.memberTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.memberTitle.Location = new System.Drawing.Point(0, 0);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Padding = new System.Windows.Forms.Padding(6);
            this.memberTitle.Size = new System.Drawing.Size(997, 62);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Budgets";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(bgt_idLabel);
            this.panel1.Controls.Add(this.bgt_idTextBox);
            this.panel1.Controls.Add(issuedto_subidLabel);
            this.panel1.Controls.Add(this.issuedto_subidTextBox);
            this.panel1.Controls.Add(bgt_amntLabel);
            this.panel1.Controls.Add(this.bgt_amntTextBox);
            this.panel1.Controls.Add(bgt_typeLabel);
            this.panel1.Controls.Add(this.bgt_typeTextBox);
            this.panel1.Controls.Add(issued_dateLabel);
            this.panel1.Controls.Add(this.issued_dateDateTimePicker);
            this.panel1.Controls.Add(this.budgetBindingNavigator);
            this.panel1.Controls.Add(this.budgetDataGridView);
            this.panel1.Location = new System.Drawing.Point(58, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 445);
            this.panel1.TabIndex = 16;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetBindingSource
            // 
            this.budgetBindingSource.DataMember = "budget";
            this.budgetBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // budgetTableAdapter
            // 
            this.budgetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendeeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.budgetTableAdapter = this.budgetTableAdapter;
            this.tableAdapterManager.club_memberTableAdapter = null;
            this.tableAdapterManager.committee_memTableAdapter = null;
            this.tableAdapterManager.committeeTableAdapter = null;
            this.tableAdapterManager.event_organizer_subTableAdapter = null;
            this.tableAdapterManager.eventTableAdapter = null;
            this.tableAdapterManager.phonesTableAdapter = null;
            this.tableAdapterManager.sub_memTableAdapter = null;
            this.tableAdapterManager.sub_unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.workshop_memTableAdapter = null;
            this.tableAdapterManager.workshopTableAdapter = null;
            // 
            // budgetBindingNavigator
            // 
            this.budgetBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.budgetBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetBindingNavigator.AutoSize = false;
            this.budgetBindingNavigator.BindingSource = this.budgetBindingSource;
            this.budgetBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.budgetBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.budgetBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.budgetBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.budgetBindingNavigatorSaveItem});
            this.budgetBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.budgetBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.budgetBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.budgetBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.budgetBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.budgetBindingNavigator.Name = "budgetBindingNavigator";
            this.budgetBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.budgetBindingNavigator.Size = new System.Drawing.Size(881, 53);
            this.budgetBindingNavigator.TabIndex = 17;
            this.budgetBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 50);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 50);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 53);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 50);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 50);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 50);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 50);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 50);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // budgetBindingNavigatorSaveItem
            // 
            this.budgetBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.budgetBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.budgetBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.budgetBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("budgetBindingNavigatorSaveItem.Image")));
            this.budgetBindingNavigatorSaveItem.Name = "budgetBindingNavigatorSaveItem";
            this.budgetBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.budgetBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 50);
            this.budgetBindingNavigatorSaveItem.Text = "Save Data";
            this.budgetBindingNavigatorSaveItem.Click += new System.EventHandler(this.budgetBindingNavigatorSaveItem_Click);
            // 
            // budgetDataGridView
            // 
            this.budgetDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.budgetDataGridView.AutoGenerateColumns = false;
            this.budgetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.budgetDataGridView.DataSource = this.budgetBindingSource;
            this.budgetDataGridView.Location = new System.Drawing.Point(148, 196);
            this.budgetDataGridView.Name = "budgetDataGridView";
            this.budgetDataGridView.Size = new System.Drawing.Size(590, 220);
            this.budgetDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "bgt_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "bgt_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "issuedto_subid";
            this.dataGridViewTextBoxColumn2.HeaderText = "issuedto_subid";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "bgt_amnt";
            this.dataGridViewTextBoxColumn3.HeaderText = "bgt_amnt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "bgt_type";
            this.dataGridViewTextBoxColumn4.HeaderText = "bgt_type";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "issued_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "issued_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // bgt_idLabel
            // 
            bgt_idLabel.AutoSize = true;
            bgt_idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bgt_idLabel.Location = new System.Drawing.Point(122, 84);
            bgt_idLabel.Name = "bgt_idLabel";
            bgt_idLabel.Size = new System.Drawing.Size(58, 21);
            bgt_idLabel.TabIndex = 17;
            bgt_idLabel.Text = "bgt id:";
            // 
            // bgt_idTextBox
            // 
            this.bgt_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetBindingSource, "bgt_id", true));
            this.bgt_idTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgt_idTextBox.Location = new System.Drawing.Point(243, 81);
            this.bgt_idTextBox.Name = "bgt_idTextBox";
            this.bgt_idTextBox.Size = new System.Drawing.Size(224, 29);
            this.bgt_idTextBox.TabIndex = 18;
            this.bgt_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // issuedto_subidLabel
            // 
            issuedto_subidLabel.AutoSize = true;
            issuedto_subidLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issuedto_subidLabel.Location = new System.Drawing.Point(122, 110);
            issuedto_subidLabel.Name = "issuedto_subidLabel";
            issuedto_subidLabel.Size = new System.Drawing.Size(120, 21);
            issuedto_subidLabel.TabIndex = 19;
            issuedto_subidLabel.Text = "issuedto subid:";
            // 
            // issuedto_subidTextBox
            // 
            this.issuedto_subidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetBindingSource, "issuedto_subid", true));
            this.issuedto_subidTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuedto_subidTextBox.Location = new System.Drawing.Point(243, 107);
            this.issuedto_subidTextBox.MaxLength = 5;
            this.issuedto_subidTextBox.Name = "issuedto_subidTextBox";
            this.issuedto_subidTextBox.Size = new System.Drawing.Size(224, 29);
            this.issuedto_subidTextBox.TabIndex = 20;
            this.issuedto_subidTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bgt_amntLabel
            // 
            bgt_amntLabel.AutoSize = true;
            bgt_amntLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bgt_amntLabel.Location = new System.Drawing.Point(122, 136);
            bgt_amntLabel.Name = "bgt_amntLabel";
            bgt_amntLabel.Size = new System.Drawing.Size(81, 21);
            bgt_amntLabel.TabIndex = 21;
            bgt_amntLabel.Text = "bgt amnt:";
            // 
            // bgt_amntTextBox
            // 
            this.bgt_amntTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetBindingSource, "bgt_amnt", true));
            this.bgt_amntTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgt_amntTextBox.Location = new System.Drawing.Point(243, 133);
            this.bgt_amntTextBox.Name = "bgt_amntTextBox";
            this.bgt_amntTextBox.Size = new System.Drawing.Size(224, 29);
            this.bgt_amntTextBox.TabIndex = 22;
            this.bgt_amntTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bgt_typeLabel
            // 
            bgt_typeLabel.AutoSize = true;
            bgt_typeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bgt_typeLabel.Location = new System.Drawing.Point(480, 96);
            bgt_typeLabel.Name = "bgt_typeLabel";
            bgt_typeLabel.Size = new System.Drawing.Size(77, 21);
            bgt_typeLabel.TabIndex = 23;
            bgt_typeLabel.Text = "bgt type:";
            // 
            // bgt_typeTextBox
            // 
            this.bgt_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetBindingSource, "bgt_type", true));
            this.bgt_typeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bgt_typeTextBox.Location = new System.Drawing.Point(580, 93);
            this.bgt_typeTextBox.Name = "bgt_typeTextBox";
            this.bgt_typeTextBox.Size = new System.Drawing.Size(224, 29);
            this.bgt_typeTextBox.TabIndex = 24;
            this.bgt_typeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // issued_dateLabel
            // 
            issued_dateLabel.AutoSize = true;
            issued_dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            issued_dateLabel.Location = new System.Drawing.Point(480, 123);
            issued_dateLabel.Name = "issued_dateLabel";
            issued_dateLabel.Size = new System.Drawing.Size(97, 21);
            issued_dateLabel.TabIndex = 25;
            issued_dateLabel.Text = "issued date:";
            // 
            // issued_dateDateTimePicker
            // 
            this.issued_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.budgetBindingSource, "issued_date", true));
            this.issued_dateDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issued_dateDateTimePicker.Location = new System.Drawing.Point(580, 119);
            this.issued_dateDateTimePicker.Name = "issued_dateDateTimePicker";
            this.issued_dateDateTimePicker.Size = new System.Drawing.Size(224, 29);
            this.issued_dateDateTimePicker.TabIndex = 26;
            // 
            // Budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(997, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Budget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminBudget";
            this.Load += new System.EventHandler(this.Budget_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetBindingNavigator)).EndInit();
            this.budgetBindingNavigator.ResumeLayout(false);
            this.budgetBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label memberTitle;
        private System.Windows.Forms.Panel panel1;
        private uni_club_membershipDataSet uni_club_membershipDataSet;
        private System.Windows.Forms.BindingSource budgetBindingSource;
        private uni_club_membershipDataSetTableAdapters.budgetTableAdapter budgetTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator budgetBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton budgetBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView budgetDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox bgt_idTextBox;
        private System.Windows.Forms.TextBox issuedto_subidTextBox;
        private System.Windows.Forms.TextBox bgt_amntTextBox;
        private System.Windows.Forms.TextBox bgt_typeTextBox;
        private System.Windows.Forms.DateTimePicker issued_dateDateTimePicker;
    }
}