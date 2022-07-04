namespace UniversityClubDB
{
    partial class Workshop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Workshop));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.workshopBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.workshopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.workshopDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workshopTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.workshopTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            this.fillByWorkshopIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByWorkshopIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByWorkshopNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByWorkshopNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workshopBindingNavigator)).BeginInit();
            this.workshopBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workshopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataGridView)).BeginInit();
            this.fillByWorkshopIDToolStrip.SuspendLayout();
            this.fillByWorkshopNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.memberTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 164);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::UniversityClubDB.Properties.Resources.logout;
            this.pictureBox2.Location = new System.Drawing.Point(854, 12);
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
            this.memberTitle.Size = new System.Drawing.Size(957, 62);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Workshops";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.fillByWorkshopNameToolStrip);
            this.panel1.Controls.Add(this.fillByWorkshopIDToolStrip);
            this.panel1.Controls.Add(this.workshopBindingNavigator);
            this.panel1.Controls.Add(this.workshopDataGridView);
            this.panel1.Location = new System.Drawing.Point(69, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 451);
            this.panel1.TabIndex = 18;
            // 
            // workshopBindingNavigator
            // 
            this.workshopBindingNavigator.AddNewItem = null;
            this.workshopBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workshopBindingNavigator.AutoSize = false;
            this.workshopBindingNavigator.BindingSource = this.workshopBindingSource;
            this.workshopBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.workshopBindingNavigator.DeleteItem = null;
            this.workshopBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.workshopBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.workshopBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workshopBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.workshopBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.workshopBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.workshopBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.workshopBindingNavigator.Name = "workshopBindingNavigator";
            this.workshopBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.workshopBindingNavigator.Size = new System.Drawing.Size(819, 63);
            this.workshopBindingNavigator.TabIndex = 19;
            this.workshopBindingNavigator.Text = "bindingNavigator1";
            // 
            // workshopBindingSource
            // 
            this.workshopBindingSource.DataMember = "workshop";
            this.workshopBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 60);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // workshopDataGridView
            // 
            this.workshopDataGridView.AllowUserToAddRows = false;
            this.workshopDataGridView.AllowUserToDeleteRows = false;
            this.workshopDataGridView.AutoGenerateColumns = false;
            this.workshopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workshopDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.workshopDataGridView.DataSource = this.workshopBindingSource;
            this.workshopDataGridView.Location = new System.Drawing.Point(0, 141);
            this.workshopDataGridView.Name = "workshopDataGridView";
            this.workshopDataGridView.ReadOnly = true;
            this.workshopDataGridView.Size = new System.Drawing.Size(819, 307);
            this.workshopDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "w_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "w_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "w_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "w_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "w_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "w_type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "w_start_date";
            this.dataGridViewTextBoxColumn4.HeaderText = "w_start_date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "w_end_date";
            this.dataGridViewTextBoxColumn5.HeaderText = "w_end_date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "w_capacity";
            this.dataGridViewTextBoxColumn6.HeaderText = "w_capacity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tutor";
            this.dataGridViewTextBoxColumn7.HeaderText = "tutor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn8.HeaderText = "time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "org_sub_id";
            this.dataGridViewTextBoxColumn9.HeaderText = "org_sub_id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // workshopTableAdapter
            // 
            this.workshopTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendeeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.budgetTableAdapter = null;
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
            this.tableAdapterManager.workshopTableAdapter = this.workshopTableAdapter;
            // 
            // fillByWorkshopIDToolStrip
            // 
            this.fillByWorkshopIDToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByWorkshopIDToolStrip.AutoSize = false;
            this.fillByWorkshopIDToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByWorkshopIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillByWorkshopIDToolStripButton});
            this.fillByWorkshopIDToolStrip.Location = new System.Drawing.Point(0, 90);
            this.fillByWorkshopIDToolStrip.Name = "fillByWorkshopIDToolStrip";
            this.fillByWorkshopIDToolStrip.Size = new System.Drawing.Size(274, 48);
            this.fillByWorkshopIDToolStrip.TabIndex = 19;
            this.fillByWorkshopIDToolStrip.Text = "fillByWorkshopIDToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(65, 45);
            this.param1ToolStripLabel.Text = "WSH ID:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 48);
            this.param1ToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByWorkshopIDToolStripButton
            // 
            this.fillByWorkshopIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByWorkshopIDToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByWorkshopIDToolStripButton.Name = "fillByWorkshopIDToolStripButton";
            this.fillByWorkshopIDToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByWorkshopIDToolStripButton.Size = new System.Drawing.Size(50, 45);
            this.fillByWorkshopIDToolStripButton.Text = "FillByWorkshopID";
            this.fillByWorkshopIDToolStripButton.Click += new System.EventHandler(this.fillByWorkshopIDToolStripButton_Click);
            // 
            // fillByWorkshopNameToolStrip
            // 
            this.fillByWorkshopNameToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByWorkshopNameToolStrip.AutoSize = false;
            this.fillByWorkshopNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByWorkshopNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel1,
            this.param1ToolStripTextBox1,
            this.fillByWorkshopNameToolStripButton,
            this.toolStripButton1});
            this.fillByWorkshopNameToolStrip.Location = new System.Drawing.Point(274, 90);
            this.fillByWorkshopNameToolStrip.Name = "fillByWorkshopNameToolStrip";
            this.fillByWorkshopNameToolStrip.Size = new System.Drawing.Size(545, 48);
            this.fillByWorkshopNameToolStrip.TabIndex = 19;
            this.fillByWorkshopNameToolStrip.Text = "fillByWorkshopNameToolStrip";
            // 
            // param1ToolStripLabel1
            // 
            this.param1ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel1.Name = "param1ToolStripLabel1";
            this.param1ToolStripLabel1.Size = new System.Drawing.Size(91, 45);
            this.param1ToolStripLabel1.Text = "WSH Name:";
            // 
            // param1ToolStripTextBox1
            // 
            this.param1ToolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.param1ToolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.param1ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox1.Name = "param1ToolStripTextBox1";
            this.param1ToolStripTextBox1.Size = new System.Drawing.Size(195, 48);
            this.param1ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByWorkshopNameToolStripButton
            // 
            this.fillByWorkshopNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByWorkshopNameToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByWorkshopNameToolStripButton.Name = "fillByWorkshopNameToolStripButton";
            this.fillByWorkshopNameToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByWorkshopNameToolStripButton.Size = new System.Drawing.Size(50, 45);
            this.fillByWorkshopNameToolStripButton.Text = "FillByWorkshopName";
            this.fillByWorkshopNameToolStripButton.Click += new System.EventHandler(this.fillByWorkshopNameToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UniversityClubDB.Properties.Resources.clear;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.toolStripButton1.Size = new System.Drawing.Size(50, 45);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Workshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(957, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workshop";
            this.Load += new System.EventHandler(this.Workshop_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workshopBindingNavigator)).EndInit();
            this.workshopBindingNavigator.ResumeLayout(false);
            this.workshopBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workshopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workshopDataGridView)).EndInit();
            this.fillByWorkshopIDToolStrip.ResumeLayout(false);
            this.fillByWorkshopIDToolStrip.PerformLayout();
            this.fillByWorkshopNameToolStrip.ResumeLayout(false);
            this.fillByWorkshopNameToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label memberTitle;
        private System.Windows.Forms.Panel panel1;
        private uni_club_membershipDataSet uni_club_membershipDataSet;
        private System.Windows.Forms.BindingSource workshopBindingSource;
        private uni_club_membershipDataSetTableAdapters.workshopTableAdapter workshopTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workshopBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView workshopDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.ToolStrip fillByWorkshopIDToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByWorkshopIDToolStripButton;
        private System.Windows.Forms.ToolStrip fillByWorkshopNameToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByWorkshopNameToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}