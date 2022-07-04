namespace UniversityClubDB
{
    partial class AdminEvents
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
            System.Windows.Forms.Label ev_idLabel;
            System.Windows.Forms.Label ev_nameLabel;
            System.Windows.Forms.Label ev_dateLabel;
            System.Windows.Forms.Label timeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEvents));
            System.Windows.Forms.Label label7;
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.fillByeventNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.fillByeventNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fillByAdminEvent_idToolStrip = new System.Windows.Forms.ToolStrip();
            this.param1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.param1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByAdminEvent_idToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ev_idTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.ev_nameTextBox = new System.Windows.Forms.TextBox();
            this.ev_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.eventDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.eventTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            ev_idLabel = new System.Windows.Forms.Label();
            ev_nameLabel = new System.Windows.Forms.Label();
            ev_dateLabel = new System.Windows.Forms.Label();
            timeLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.fillByeventNameToolStrip.SuspendLayout();
            this.fillByAdminEvent_idToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).BeginInit();
            this.eventBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ev_idLabel
            // 
            ev_idLabel.AutoSize = true;
            ev_idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ev_idLabel.Location = new System.Drawing.Point(14, 85);
            ev_idLabel.Name = "ev_idLabel";
            ev_idLabel.Size = new System.Drawing.Size(49, 21);
            ev_idLabel.TabIndex = 17;
            ev_idLabel.Text = "ev id:";
            // 
            // ev_nameLabel
            // 
            ev_nameLabel.AutoSize = true;
            ev_nameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ev_nameLabel.Location = new System.Drawing.Point(14, 111);
            ev_nameLabel.Name = "ev_nameLabel";
            ev_nameLabel.Size = new System.Drawing.Size(75, 21);
            ev_nameLabel.TabIndex = 19;
            ev_nameLabel.Text = "ev name:";
            // 
            // ev_dateLabel
            // 
            ev_dateLabel.AutoSize = true;
            ev_dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ev_dateLabel.Location = new System.Drawing.Point(367, 86);
            ev_dateLabel.Name = "ev_dateLabel";
            ev_dateLabel.Size = new System.Drawing.Size(68, 21);
            ev_dateLabel.TabIndex = 21;
            ev_dateLabel.Text = "ev date:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            timeLabel.Location = new System.Drawing.Point(367, 111);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new System.Drawing.Size(47, 21);
            timeLabel.TabIndex = 23;
            timeLabel.Text = "time:";
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
            this.panel2.TabIndex = 15;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::UniversityClubDB.Properties.Resources.admin_icon;
            this.pictureBox3.Location = new System.Drawing.Point(548, 8);
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
            this.memberTitle.Size = new System.Drawing.Size(977, 62);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Events";
            this.memberTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.fillByeventNameToolStrip);
            this.panel1.Controls.Add(this.fillByAdminEvent_idToolStrip);
            this.panel1.Controls.Add(ev_idLabel);
            this.panel1.Controls.Add(this.ev_idTextBox);
            this.panel1.Controls.Add(ev_nameLabel);
            this.panel1.Controls.Add(this.ev_nameTextBox);
            this.panel1.Controls.Add(ev_dateLabel);
            this.panel1.Controls.Add(this.ev_dateDateTimePicker);
            this.panel1.Controls.Add(timeLabel);
            this.panel1.Controls.Add(this.timeTextBox);
            this.panel1.Controls.Add(this.eventBindingNavigator);
            this.panel1.Controls.Add(this.eventDataGridView);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(65, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 492);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::UniversityClubDB.Properties.Resources.eventOrganizer;
            this.pictureBox4.Location = new System.Drawing.Point(723, 82);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // fillByeventNameToolStrip
            // 
            this.fillByeventNameToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByeventNameToolStrip.AutoSize = false;
            this.fillByeventNameToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByeventNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel1,
            this.param1ToolStripTextBox1,
            this.fillByeventNameToolStripButton,
            this.toolStripButton1});
            this.fillByeventNameToolStrip.Location = new System.Drawing.Point(257, 177);
            this.fillByeventNameToolStrip.Name = "fillByeventNameToolStrip";
            this.fillByeventNameToolStrip.Size = new System.Drawing.Size(433, 35);
            this.fillByeventNameToolStrip.TabIndex = 17;
            this.fillByeventNameToolStrip.Text = "fillByeventNameToolStrip";
            // 
            // param1ToolStripLabel1
            // 
            this.param1ToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel1.Name = "param1ToolStripLabel1";
            this.param1ToolStripLabel1.Size = new System.Drawing.Size(96, 32);
            this.param1ToolStripLabel1.Text = "event Name:";
            // 
            // param1ToolStripTextBox1
            // 
            this.param1ToolStripTextBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Cultural day",
            "music day",
            "Keep our streats clean",
            "Hat day"});
            this.param1ToolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.param1ToolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.param1ToolStripTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox1.Name = "param1ToolStripTextBox1";
            this.param1ToolStripTextBox1.Size = new System.Drawing.Size(195, 35);
            this.param1ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByeventNameToolStripButton
            // 
            this.fillByeventNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByeventNameToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByeventNameToolStripButton.Name = "fillByeventNameToolStripButton";
            this.fillByeventNameToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByeventNameToolStripButton.Size = new System.Drawing.Size(50, 32);
            this.fillByeventNameToolStripButton.Text = "FillByeventName";
            this.fillByeventNameToolStripButton.Click += new System.EventHandler(this.fillByeventNameToolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::UniversityClubDB.Properties.Resources.clear;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.toolStripButton1.Size = new System.Drawing.Size(50, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fillByAdminEvent_idToolStrip
            // 
            this.fillByAdminEvent_idToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillByAdminEvent_idToolStrip.AutoSize = false;
            this.fillByAdminEvent_idToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByAdminEvent_idToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.param1ToolStripLabel,
            this.param1ToolStripTextBox,
            this.fillByAdminEvent_idToolStripButton});
            this.fillByAdminEvent_idToolStrip.Location = new System.Drawing.Point(0, 177);
            this.fillByAdminEvent_idToolStrip.Name = "fillByAdminEvent_idToolStrip";
            this.fillByAdminEvent_idToolStrip.Size = new System.Drawing.Size(257, 35);
            this.fillByAdminEvent_idToolStrip.TabIndex = 17;
            this.fillByAdminEvent_idToolStrip.Text = "fillByAdminEvent_idToolStrip";
            // 
            // param1ToolStripLabel
            // 
            this.param1ToolStripLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripLabel.Name = "param1ToolStripLabel";
            this.param1ToolStripLabel.Size = new System.Drawing.Size(74, 32);
            this.param1ToolStripLabel.Text = "Event ID:";
            // 
            // param1ToolStripTextBox
            // 
            this.param1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.param1ToolStripTextBox.MaxLength = 5;
            this.param1ToolStripTextBox.Name = "param1ToolStripTextBox";
            this.param1ToolStripTextBox.Size = new System.Drawing.Size(100, 35);
            this.param1ToolStripTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fillByAdminEvent_idToolStripButton
            // 
            this.fillByAdminEvent_idToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillByAdminEvent_idToolStripButton.Image = global::UniversityClubDB.Properties.Resources.find_icon_20;
            this.fillByAdminEvent_idToolStripButton.Name = "fillByAdminEvent_idToolStripButton";
            this.fillByAdminEvent_idToolStripButton.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.fillByAdminEvent_idToolStripButton.Size = new System.Drawing.Size(50, 32);
            this.fillByAdminEvent_idToolStripButton.Text = "FillByAdminEvent_id";
            this.fillByAdminEvent_idToolStripButton.Click += new System.EventHandler(this.fillByAdminEvent_idToolStripButton_Click);
            // 
            // ev_idTextBox
            // 
            this.ev_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "ev_id", true));
            this.ev_idTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ev_idTextBox.Location = new System.Drawing.Point(98, 82);
            this.ev_idTextBox.MaxLength = 5;
            this.ev_idTextBox.Name = "ev_idTextBox";
            this.ev_idTextBox.Size = new System.Drawing.Size(250, 29);
            this.ev_idTextBox.TabIndex = 18;
            this.ev_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "event";
            this.eventBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ev_nameTextBox
            // 
            this.ev_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "ev_name", true));
            this.ev_nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ev_nameTextBox.Location = new System.Drawing.Point(98, 108);
            this.ev_nameTextBox.Name = "ev_nameTextBox";
            this.ev_nameTextBox.Size = new System.Drawing.Size(250, 29);
            this.ev_nameTextBox.TabIndex = 20;
            this.ev_nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ev_dateDateTimePicker
            // 
            this.ev_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "ev_date", true));
            this.ev_dateDateTimePicker.Location = new System.Drawing.Point(451, 82);
            this.ev_dateDateTimePicker.Name = "ev_dateDateTimePicker";
            this.ev_dateDateTimePicker.Size = new System.Drawing.Size(250, 29);
            this.ev_dateDateTimePicker.TabIndex = 22;
            // 
            // timeTextBox
            // 
            this.timeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "time", true));
            this.timeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTextBox.Location = new System.Drawing.Point(451, 108);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(250, 29);
            this.timeTextBox.TabIndex = 24;
            this.timeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eventBindingNavigator
            // 
            this.eventBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventBindingNavigator.AutoSize = false;
            this.eventBindingNavigator.BindingSource = this.eventBindingSource;
            this.eventBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.eventBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventBindingNavigatorSaveItem});
            this.eventBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventBindingNavigator.Name = "eventBindingNavigator";
            this.eventBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventBindingNavigator.Size = new System.Drawing.Size(847, 55);
            this.eventBindingNavigator.TabIndex = 17;
            this.eventBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 52);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 52);
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
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 52);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 52);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 52);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 55);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 52);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 52);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // eventBindingNavigatorSaveItem
            // 
            this.eventBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.eventBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.eventBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventBindingNavigatorSaveItem.Image")));
            this.eventBindingNavigatorSaveItem.Name = "eventBindingNavigatorSaveItem";
            this.eventBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.eventBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 52);
            this.eventBindingNavigatorSaveItem.Text = "Save Data";
            this.eventBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventBindingNavigatorSaveItem_Click);
            // 
            // eventDataGridView
            // 
            this.eventDataGridView.AllowUserToAddRows = false;
            this.eventDataGridView.AllowUserToDeleteRows = false;
            this.eventDataGridView.AutoGenerateColumns = false;
            this.eventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.eventDataGridView.DataSource = this.eventBindingSource;
            this.eventDataGridView.Location = new System.Drawing.Point(0, 215);
            this.eventDataGridView.Name = "eventDataGridView";
            this.eventDataGridView.ReadOnly = true;
            this.eventDataGridView.Size = new System.Drawing.Size(690, 274);
            this.eventDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ev_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ev_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ev_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "ev_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ev_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "ev_date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn4.HeaderText = "time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.eventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.phonesTableAdapter = null;
            this.tableAdapterManager.sub_memTableAdapter = null;
            this.tableAdapterManager.sub_unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.workshop_memTableAdapter = null;
            this.tableAdapterManager.workshopTableAdapter = null;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(705, 140);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 23);
            label7.TabIndex = 26;
            label7.Text = "Event Organizer";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(977, 625);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminEvents";
            this.Load += new System.EventHandler(this.AdminEvents_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.fillByeventNameToolStrip.ResumeLayout(false);
            this.fillByeventNameToolStrip.PerformLayout();
            this.fillByAdminEvent_idToolStrip.ResumeLayout(false);
            this.fillByAdminEvent_idToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingNavigator)).EndInit();
            this.eventBindingNavigator.ResumeLayout(false);
            this.eventBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource eventBindingSource;
        private uni_club_membershipDataSetTableAdapters.eventTableAdapter eventTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView eventDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox ev_idTextBox;
        private System.Windows.Forms.TextBox ev_nameTextBox;
        private System.Windows.Forms.DateTimePicker ev_dateDateTimePicker;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.ToolStrip fillByAdminEvent_idToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByAdminEvent_idToolStripButton;
        private System.Windows.Forms.ToolStrip fillByeventNameToolStrip;
        private System.Windows.Forms.ToolStripLabel param1ToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox param1ToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton fillByeventNameToolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}