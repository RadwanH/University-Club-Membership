namespace UniversityClubDB
{
    partial class AdminCommittees
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
            System.Windows.Forms.Label com_idLabel;
            System.Windows.Forms.Label com_nameLabel;
            System.Windows.Forms.Label start_yearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCommittees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.com_idTextBox = new System.Windows.Forms.TextBox();
            this.com_nameTextBox = new System.Windows.Forms.TextBox();
            this.start_yearTextBox = new System.Windows.Forms.TextBox();
            this.committeeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.committeeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.committeeDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.fillByAdminComNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByAdminComNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.committeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committeeTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.committeeTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            this.fillByAdminComIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByAdminComIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            com_idLabel = new System.Windows.Forms.Label();
            com_nameLabel = new System.Windows.Forms.Label();
            start_yearLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingNavigator)).BeginInit();
            this.committeeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.fillByAdminComNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            this.fillByAdminComIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_idLabel
            // 
            com_idLabel.AutoSize = true;
            com_idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            com_idLabel.Location = new System.Drawing.Point(18, 77);
            com_idLabel.Name = "com_idLabel";
            com_idLabel.Size = new System.Drawing.Size(64, 21);
            com_idLabel.TabIndex = 19;
            com_idLabel.Text = "com id:";
            // 
            // com_nameLabel
            // 
            com_nameLabel.AutoSize = true;
            com_nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            com_nameLabel.Location = new System.Drawing.Point(18, 103);
            com_nameLabel.Name = "com_nameLabel";
            com_nameLabel.Size = new System.Drawing.Size(90, 21);
            com_nameLabel.TabIndex = 21;
            com_nameLabel.Text = "com name:";
            // 
            // start_yearLabel
            // 
            start_yearLabel.AutoSize = true;
            start_yearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start_yearLabel.Location = new System.Drawing.Point(18, 129);
            start_yearLabel.Name = "start_yearLabel";
            start_yearLabel.Size = new System.Drawing.Size(83, 21);
            start_yearLabel.TabIndex = 23;
            start_yearLabel.Text = "start year:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.fillByAdminComIDToolStrip);
            this.panel1.Controls.Add(this.fillByAdminComNameToolStrip);
            this.panel1.Controls.Add(com_idLabel);
            this.panel1.Controls.Add(this.com_idTextBox);
            this.panel1.Controls.Add(com_nameLabel);
            this.panel1.Controls.Add(this.com_nameTextBox);
            this.panel1.Controls.Add(start_yearLabel);
            this.panel1.Controls.Add(this.start_yearTextBox);
            this.panel1.Controls.Add(this.committeeBindingNavigator);
            this.panel1.Controls.Add(this.committeeDataGridView);
            this.panel1.Location = new System.Drawing.Point(68, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 519);
            this.panel1.TabIndex = 17;
            // 
            // com_idTextBox
            // 
            this.com_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.committeeBindingSource, "com_id", true));
            this.com_idTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_idTextBox.Location = new System.Drawing.Point(123, 80);
            this.com_idTextBox.MaxLength = 3;
            this.com_idTextBox.Name = "com_idTextBox";
            this.com_idTextBox.Size = new System.Drawing.Size(290, 29);
            this.com_idTextBox.TabIndex = 20;
            this.com_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // com_nameTextBox
            // 
            this.com_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.committeeBindingSource, "com_name", true));
            this.com_nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_nameTextBox.Location = new System.Drawing.Point(123, 106);
            this.com_nameTextBox.Name = "com_nameTextBox";
            this.com_nameTextBox.Size = new System.Drawing.Size(290, 29);
            this.com_nameTextBox.TabIndex = 22;
            this.com_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // start_yearTextBox
            // 
            this.start_yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.committeeBindingSource, "start_year", true));
            this.start_yearTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_yearTextBox.Location = new System.Drawing.Point(123, 132);
            this.start_yearTextBox.Name = "start_yearTextBox";
            this.start_yearTextBox.Size = new System.Drawing.Size(290, 29);
            this.start_yearTextBox.TabIndex = 24;
            this.start_yearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // committeeBindingNavigator
            // 
            this.committeeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.committeeBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.committeeBindingNavigator.AutoSize = false;
            this.committeeBindingNavigator.BindingSource = this.committeeBindingSource;
            this.committeeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.committeeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.committeeBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.committeeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.committeeBindingNavigatorSaveItem});
            this.committeeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.committeeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.committeeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.committeeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.committeeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.committeeBindingNavigator.Name = "committeeBindingNavigator";
            this.committeeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.committeeBindingNavigator.Size = new System.Drawing.Size(855, 63);
            this.committeeBindingNavigator.TabIndex = 19;
            this.committeeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorAddNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.bindingNavigatorAddNewItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 60);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 60);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.bindingNavigatorDeleteItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 60);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 60);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 60);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 63);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 60);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 60);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 63);
            // 
            // committeeBindingNavigatorSaveItem
            // 
            this.committeeBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.committeeBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.committeeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.committeeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("committeeBindingNavigatorSaveItem.Image")));
            this.committeeBindingNavigatorSaveItem.Name = "committeeBindingNavigatorSaveItem";
            this.committeeBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.committeeBindingNavigatorSaveItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.committeeBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 60);
            this.committeeBindingNavigatorSaveItem.Text = "Save Data";
            this.committeeBindingNavigatorSaveItem.Click += new System.EventHandler(this.committeeBindingNavigatorSaveItem_Click);
            // 
            // committeeDataGridView
            // 
            this.committeeDataGridView.AutoGenerateColumns = false;
            this.committeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.committeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.committeeDataGridView.DataSource = this.committeeBindingSource;
            this.committeeDataGridView.Location = new System.Drawing.Point(3, 211);
            this.committeeDataGridView.Name = "committeeDataGridView";
            this.committeeDataGridView.Size = new System.Drawing.Size(598, 228);
            this.committeeDataGridView.TabIndex = 0;
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
            this.panel2.Size = new System.Drawing.Size(977, 164);
            this.panel2.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::UniversityClubDB.Properties.Resources.admin_icon;
            this.pictureBox3.Location = new System.Drawing.Point(568, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::UniversityClubDB.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(874, 12);
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
            this.memberTitle.Size = new System.Drawing.Size(977, 49);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Committees";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fillByAdminComNameToolStrip
            // 
            this.fillByAdminComNameToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByAdminComNameToolStrip.AutoSize = false;
            this.fillByAdminComNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAdminComNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillByAdminComNameToolStripButton});
            this.fillByAdminComNameToolStrip.Location = new System.Drawing.Point(3, 164);
            this.fillByAdminComNameToolStrip.Name = "fillByAdminComNameToolStrip";
            this.fillByAdminComNameToolStrip.Size = new System.Drawing.Size(278, 44);
            this.fillByAdminComNameToolStrip.TabIndex = 19;
            this.fillByAdminComNameToolStrip.Text = "fillByAdminComNameToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(95, 41);
            this.param1ToolStripLabel.Text = "Com Name:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Finance Committee",
            "Fundraising Committee",
            "Programs Committee",
            "Public Relation Committee",
            "Management Committee"});
            this.param1ToolStripTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.param1ToolStripTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 44);
            // 
            // fillByAdminComNameToolStripButton
            // 
            this.fillByAdminComNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByAdminComNameToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByAdminComNameToolStripButton.Name = "fillByAdminComNameToolStripButton";
            this.fillByAdminComNameToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByAdminComNameToolStripButton.Size = new System.Drawing.Size(50, 41);
            this.fillByAdminComNameToolStripButton.Text = "FillByAdminComName";
            this.fillByAdminComNameToolStripButton.Click += new System.EventHandler(this.fillByAdminComNameToolStripButton_Click);
            // 
            // committeeBindingSource
            // 
            this.committeeBindingSource.DataMember = "committee";
            this.committeeBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "com_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "com_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "com_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "com_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "start_year";
            this.dataGridViewTextBoxColumn3.HeaderText = "start_year";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // committeeTableAdapter
            // 
            this.committeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendeeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.budgetTableAdapter = null;
            this.tableAdapterManager.club_memberTableAdapter = null;
            this.tableAdapterManager.committee_memTableAdapter = null;
            this.tableAdapterManager.committeeTableAdapter = this.committeeTableAdapter;
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
            // fillByAdminComIDToolStrip
            // 
            this.fillByAdminComIDToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByAdminComIDToolStrip.AutoSize = false;
            this.fillByAdminComIDToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAdminComIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel1,
            this.param1ToolStripTextBox1,
            this.fillByAdminComIDToolStripButton,
            this.toolStripButton1});
            this.fillByAdminComIDToolStrip.Location = new System.Drawing.Point(281, 164);
            this.fillByAdminComIDToolStrip.Name = "fillByAdminComIDToolStrip";
            this.fillByAdminComIDToolStrip.Size = new System.Drawing.Size(320, 44);
            this.fillByAdminComIDToolStrip.TabIndex = 0;
            this.fillByAdminComIDToolStrip.Text = "fillByAdminComIDToolStrip";
            // 
            // param1ToolStripLabel1
            // 
            this.param1ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel1.Name = "param1ToolStripLabel1";
            this.param1ToolStripLabel1.Size = new System.Drawing.Size(68, 41);
            this.param1ToolStripLabel1.Text = "Com ID:";
            // 
            // param1ToolStripTextBox1
            // 
            this.param1ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox1.MaxLength = 3;
            this.param1ToolStripTextBox1.Name = "param1ToolStripTextBox1";
            this.param1ToolStripTextBox1.Size = new System.Drawing.Size(100, 44);
            // 
            // fillByAdminComIDToolStripButton
            // 
            this.fillByAdminComIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByAdminComIDToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByAdminComIDToolStripButton.Name = "fillByAdminComIDToolStripButton";
            this.fillByAdminComIDToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByAdminComIDToolStripButton.Size = new System.Drawing.Size(50, 41);
            this.fillByAdminComIDToolStripButton.Text = "FillByAdminComID";
            this.fillByAdminComIDToolStripButton.Click += new System.EventHandler(this.fillByAdminComIDToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UniversityClubDB.Properties.Resources.clear;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.toolStripButton1.Size = new System.Drawing.Size(50, 41);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AdminCommittees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(977, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminCommittees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminCommittees";
            this.Load += new System.EventHandler(this.AdminCommittees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingNavigator)).EndInit();
            this.committeeBindingNavigator.ResumeLayout(false);
            this.committeeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.fillByAdminComNameToolStrip.ResumeLayout(false);
            this.fillByAdminComNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            this.fillByAdminComIDToolStrip.ResumeLayout(false);
            this.fillByAdminComIDToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label memberTitle;
        private System.Windows.Forms.PictureBox pictureBox3;
        private uni_club_membershipDataSet uni_club_membershipDataSet;
        private System.Windows.Forms.BindingSource committeeBindingSource;
        private uni_club_membershipDataSetTableAdapters.committeeTableAdapter committeeTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator committeeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton committeeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox com_idTextBox;
        private System.Windows.Forms.TextBox com_nameTextBox;
        private System.Windows.Forms.TextBox start_yearTextBox;
        private System.Windows.Forms.DataGridView committeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripButton fillByComIDToolStripButton;
        private System.Windows.Forms.ToolStrip fillByAdminComNameToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByAdminComNameToolStripButton;
        private System.Windows.Forms.ToolStrip fillByAdminComIDToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByAdminComIDToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}