namespace UniversityClubDB
{
    partial class members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(members));
            this.panel1 = new System.Windows.Forms.Panel();
            this.club_memberBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.club_memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.club_memberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fillByMember_idToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMember_idToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByMemberLastNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMemberLastNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.fillByMemberNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.param2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByMemberNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.club_memberTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.club_memberTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.club_memberBindingNavigator)).BeginInit();
            this.club_memberBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.club_memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_memberDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.fillByMember_idToolStrip.SuspendLayout();
            this.fillByMemberLastNameToolStrip.SuspendLayout();
            this.fillByMemberNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.club_memberBindingNavigator);
            this.panel1.Controls.Add(this.club_memberDataGridView);
            this.panel1.Location = new System.Drawing.Point(68, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 377);
            this.panel1.TabIndex = 15;
            // 
            // club_memberBindingNavigator
            // 
            this.club_memberBindingNavigator.AddNewItem = null;
            this.club_memberBindingNavigator.AutoSize = false;
            this.club_memberBindingNavigator.BindingSource = this.club_memberBindingSource;
            this.club_memberBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.club_memberBindingNavigator.DeleteItem = null;
            this.club_memberBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.club_memberBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.club_memberBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.club_memberBindingNavigator.MoveFirstItem = null;
            this.club_memberBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.club_memberBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.club_memberBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.club_memberBindingNavigator.Name = "club_memberBindingNavigator";
            this.club_memberBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.club_memberBindingNavigator.Size = new System.Drawing.Size(684, 39);
            this.club_memberBindingNavigator.TabIndex = 17;
            this.club_memberBindingNavigator.Text = "bindingNavigator1";
            // 
            // club_memberBindingSource
            // 
            this.club_memberBindingSource.DataMember = "club_member";
            this.club_memberBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // club_memberDataGridView
            // 
            this.club_memberDataGridView.AllowUserToAddRows = false;
            this.club_memberDataGridView.AllowUserToDeleteRows = false;
            this.club_memberDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.club_memberDataGridView.AutoGenerateColumns = false;
            this.club_memberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.club_memberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.member_id,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn12});
            this.club_memberDataGridView.DataSource = this.club_memberBindingSource;
            this.club_memberDataGridView.Location = new System.Drawing.Point(0, 42);
            this.club_memberDataGridView.Name = "club_memberDataGridView";
            this.club_memberDataGridView.ReadOnly = true;
            this.club_memberDataGridView.Size = new System.Drawing.Size(684, 335);
            this.club_memberDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // member_id
            // 
            this.member_id.DataPropertyName = "member_id";
            this.member_id.HeaderText = "member_id";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "last_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "last_name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "faculty";
            this.dataGridViewTextBoxColumn7.HeaderText = "faculty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "department";
            this.dataGridViewTextBoxColumn8.HeaderText = "department";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "year";
            this.dataGridViewTextBoxColumn9.HeaderText = "year";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "membership_state";
            this.dataGridViewTextBoxColumn12.HeaderText = "membership_state";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.fillByMember_idToolStrip);
            this.panel2.Controls.Add(this.fillByMemberLastNameToolStrip);
            this.panel2.Controls.Add(this.fillByMemberNameToolStrip);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.memberTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 164);
            this.panel2.TabIndex = 16;
            // 
            // fillByMember_idToolStrip
            // 
            this.fillByMember_idToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByMember_idToolStrip.AutoSize = false;
            this.fillByMember_idToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByMember_idToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel1,
            this.param1ToolStripTextBox1,
            this.fillByMember_idToolStripButton});
            this.fillByMember_idToolStrip.Location = new System.Drawing.Point(68, 89);
            this.fillByMember_idToolStrip.Name = "fillByMember_idToolStrip";
            this.fillByMember_idToolStrip.Size = new System.Drawing.Size(220, 36);
            this.fillByMember_idToolStrip.TabIndex = 20;
            this.fillByMember_idToolStrip.Text = "fillByMember_idToolStrip";
            // 
            // param1ToolStripLabel1
            // 
            this.param1ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel1.Name = "param1ToolStripLabel1";
            this.param1ToolStripLabel1.Size = new System.Drawing.Size(32, 33);
            this.param1ToolStripLabel1.Text = "ID";
            // 
            // param1ToolStripTextBox1
            // 
            this.param1ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox1.MaxLength = 9;
            this.param1ToolStripTextBox1.Name = "param1ToolStripTextBox1";
            this.param1ToolStripTextBox1.Size = new System.Drawing.Size(100, 36);
            this.param1ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByMember_idToolStripButton
            // 
            this.fillByMember_idToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByMember_idToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByMember_idToolStripButton.Name = "fillByMember_idToolStripButton";
            this.fillByMember_idToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByMember_idToolStripButton.Size = new System.Drawing.Size(50, 33);
            this.fillByMember_idToolStripButton.Text = "FillByMember_id";
            this.fillByMember_idToolStripButton.Click += new System.EventHandler(this.fillByMember_idToolStripButton_Click);
            // 
            // fillByMemberLastNameToolStrip
            // 
            this.fillByMemberLastNameToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByMemberLastNameToolStrip.AutoSize = false;
            this.fillByMemberLastNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByMemberLastNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillByMemberLastNameToolStripButton,
            this.toolStripButton2});
            this.fillByMemberLastNameToolStrip.Location = new System.Drawing.Point(542, 89);
            this.fillByMemberLastNameToolStrip.Name = "fillByMemberLastNameToolStrip";
            this.fillByMemberLastNameToolStrip.Size = new System.Drawing.Size(341, 39);
            this.fillByMemberLastNameToolStrip.TabIndex = 20;
            this.fillByMemberLastNameToolStrip.Text = "fillByMemberLastNameToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(89, 36);
            this.param1ToolStripLabel.Text = "Surname";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 39);
            this.param1ToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByMemberLastNameToolStripButton
            // 
            this.fillByMemberLastNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByMemberLastNameToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByMemberLastNameToolStripButton.Name = "fillByMemberLastNameToolStripButton";
            this.fillByMemberLastNameToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByMemberLastNameToolStripButton.Size = new System.Drawing.Size(50, 36);
            this.fillByMemberLastNameToolStripButton.Text = "FillByMemberLastName";
            this.fillByMemberLastNameToolStripButton.Click += new System.EventHandler(this.fillByMemberLastNameToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::UniversityClubDB.Properties.Resources.clear;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.toolStripButton2.Size = new System.Drawing.Size(50, 36);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // fillByMemberNameToolStrip
            // 
            this.fillByMemberNameToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByMemberNameToolStrip.AutoSize = false;
            this.fillByMemberNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByMemberNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param2ToolStripLabel,
            this.param2ToolStripTextBox,
            this.fillByMemberNameToolStripButton});
            this.fillByMemberNameToolStrip.Location = new System.Drawing.Point(288, 89);
            this.fillByMemberNameToolStrip.Name = "fillByMemberNameToolStrip";
            this.fillByMemberNameToolStrip.Size = new System.Drawing.Size(254, 39);
            this.fillByMemberNameToolStrip.TabIndex = 18;
            this.fillByMemberNameToolStrip.Text = "fillByMemberNameToolStrip";
            // 
            // param2ToolStripLabel
            // 
            this.param2ToolStripLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param2ToolStripLabel.Name = "param2ToolStripLabel";
            this.param2ToolStripLabel.Size = new System.Drawing.Size(69, 36);
            this.param2ToolStripLabel.Text = "Name:";
            // 
            // param2ToolStripTextBox
            // 
            this.param2ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param2ToolStripTextBox.Name = "param2ToolStripTextBox";
            this.param2ToolStripTextBox.Size = new System.Drawing.Size(100, 39);
            this.param2ToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByMemberNameToolStripButton
            // 
            this.fillByMemberNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByMemberNameToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByMemberNameToolStripButton.Name = "fillByMemberNameToolStripButton";
            this.fillByMemberNameToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByMemberNameToolStripButton.Size = new System.Drawing.Size(50, 36);
            this.fillByMemberNameToolStripButton.Text = "FillByMemberName";
            this.fillByMemberNameToolStripButton.Click += new System.EventHandler(this.fillByMemberNameToolStripButton_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // memberTitle
            // 
            this.memberTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.memberTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.memberTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.memberTitle.Location = new System.Drawing.Point(0, 0);
            this.memberTitle.Name = "memberTitle";
            this.memberTitle.Padding = new System.Windows.Forms.Padding(6);
            this.memberTitle.Size = new System.Drawing.Size(957, 49);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Members";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // club_memberTableAdapter
            // 
            this.club_memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendeeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.budgetTableAdapter = null;
            this.tableAdapterManager.club_memberTableAdapter = this.club_memberTableAdapter;
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
            // members
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(957, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "members";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "members";
            this.Load += new System.EventHandler(this.members_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.club_memberBindingNavigator)).EndInit();
            this.club_memberBindingNavigator.ResumeLayout(false);
            this.club_memberBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.club_memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.club_memberDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.fillByMember_idToolStrip.ResumeLayout(false);
            this.fillByMember_idToolStrip.PerformLayout();
            this.fillByMemberLastNameToolStrip.ResumeLayout(false);
            this.fillByMemberLastNameToolStrip.PerformLayout();
            this.fillByMemberNameToolStrip.ResumeLayout(false);
            this.fillByMemberNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label memberTitle;
        private uni_club_membershipDataSet uni_club_membershipDataSet;
        private System.Windows.Forms.BindingSource club_memberBindingSource;
        private uni_club_membershipDataSetTableAdapters.club_memberTableAdapter club_memberTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator club_memberBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView club_memberDataGridView;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStrip fillByMemberNameToolStrip;
        private System.Windows.Forms.ToolStripLabel param2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByMemberNameToolStripButton;
        private System.Windows.Forms.ToolStrip fillByMemberLastNameToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByMemberLastNameToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.ToolStrip fillByMember_idToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByMember_idToolStripButton;
    }
}



