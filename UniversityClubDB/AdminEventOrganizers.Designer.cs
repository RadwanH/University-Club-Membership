namespace UniversityClubDB
{
    partial class AdminEventOrganizers
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
            System.Windows.Forms.Label organizer_sub_idLabel;
            System.Windows.Forms.Label organized_eventLabel;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEventOrganizers));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.memberTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.organizer_sub_idTextBox = new System.Windows.Forms.TextBox();
            this.event_organizer_subBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uni_club_membershipDataSet = new UniversityClubDB.uni_club_membershipDataSet();
            this.organized_eventTextBox = new System.Windows.Forms.TextBox();
            this.event_organizer_subBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.event_organizer_subBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.event_organizer_subDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.event_organizer_subTableAdapter = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.event_organizer_subTableAdapter();
            this.tableAdapterManager = new UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager();
            organizer_sub_idLabel = new System.Windows.Forms.Label();
            organized_eventLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subBindingNavigator)).BeginInit();
            this.event_organizer_subBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // organizer_sub_idLabel
            // 
            organizer_sub_idLabel.AutoSize = true;
            organizer_sub_idLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            organizer_sub_idLabel.Location = new System.Drawing.Point(337, 103);
            organizer_sub_idLabel.Name = "organizer_sub_idLabel";
            organizer_sub_idLabel.Size = new System.Drawing.Size(131, 21);
            organizer_sub_idLabel.TabIndex = 18;
            organizer_sub_idLabel.Text = "organizer sub id:";
            // 
            // organized_eventLabel
            // 
            organized_eventLabel.AutoSize = true;
            organized_eventLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            organized_eventLabel.Location = new System.Drawing.Point(337, 129);
            organized_eventLabel.Name = "organized_eventLabel";
            organized_eventLabel.Size = new System.Drawing.Size(132, 21);
            organized_eventLabel.TabIndex = 20;
            organized_eventLabel.Text = "organized event:";
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(695, 158);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(142, 23);
            label7.TabIndex = 28;
            label7.Text = "Events";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.Size = new System.Drawing.Size(1044, 164);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::UniversityClubDB.Properties.Resources.admin_icon;
            this.pictureBox3.Location = new System.Drawing.Point(629, 12);
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
            this.pictureBox2.Location = new System.Drawing.Point(941, 12);
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
            this.memberTitle.Size = new System.Drawing.Size(1044, 62);
            this.memberTitle.TabIndex = 2;
            this.memberTitle.Text = "Event Organizers";
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
            this.panel1.Controls.Add(organizer_sub_idLabel);
            this.panel1.Controls.Add(this.organizer_sub_idTextBox);
            this.panel1.Controls.Add(organized_eventLabel);
            this.panel1.Controls.Add(this.organized_eventTextBox);
            this.panel1.Controls.Add(this.event_organizer_subBindingNavigator);
            this.panel1.Controls.Add(this.event_organizer_subDataGridView);
            this.panel1.Location = new System.Drawing.Point(66, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 456);
            this.panel1.TabIndex = 17;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::UniversityClubDB.Properties.Resources.eventIcon;
            this.pictureBox4.Location = new System.Drawing.Point(713, 100);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 55);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // organizer_sub_idTextBox
            // 
            this.organizer_sub_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.event_organizer_subBindingSource, "organizer_sub_id", true));
            this.organizer_sub_idTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organizer_sub_idTextBox.Location = new System.Drawing.Point(475, 100);
            this.organizer_sub_idTextBox.MaxLength = 5;
            this.organizer_sub_idTextBox.Name = "organizer_sub_idTextBox";
            this.organizer_sub_idTextBox.Size = new System.Drawing.Size(115, 29);
            this.organizer_sub_idTextBox.TabIndex = 19;
            this.organizer_sub_idTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // event_organizer_subBindingSource
            // 
            this.event_organizer_subBindingSource.DataMember = "event_organizer_sub";
            this.event_organizer_subBindingSource.DataSource = this.uni_club_membershipDataSet;
            // 
            // uni_club_membershipDataSet
            // 
            this.uni_club_membershipDataSet.DataSetName = "uni_club_membershipDataSet";
            this.uni_club_membershipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organized_eventTextBox
            // 
            this.organized_eventTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.event_organizer_subBindingSource, "organized_event", true));
            this.organized_eventTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organized_eventTextBox.Location = new System.Drawing.Point(475, 126);
            this.organized_eventTextBox.Name = "organized_eventTextBox";
            this.organized_eventTextBox.Size = new System.Drawing.Size(115, 29);
            this.organized_eventTextBox.TabIndex = 21;
            this.organized_eventTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // event_organizer_subBindingNavigator
            // 
            this.event_organizer_subBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.event_organizer_subBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.event_organizer_subBindingNavigator.AutoSize = false;
            this.event_organizer_subBindingNavigator.BindingSource = this.event_organizer_subBindingSource;
            this.event_organizer_subBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.event_organizer_subBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.event_organizer_subBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.event_organizer_subBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.event_organizer_subBindingNavigatorSaveItem});
            this.event_organizer_subBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.event_organizer_subBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.event_organizer_subBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.event_organizer_subBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.event_organizer_subBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.event_organizer_subBindingNavigator.Name = "event_organizer_subBindingNavigator";
            this.event_organizer_subBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.event_organizer_subBindingNavigator.Size = new System.Drawing.Size(912, 54);
            this.event_organizer_subBindingNavigator.TabIndex = 18;
            this.event_organizer_subBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(50, 51);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 51);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(50, 51);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 54);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 51);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // event_organizer_subBindingNavigatorSaveItem
            // 
            this.event_organizer_subBindingNavigatorSaveItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.event_organizer_subBindingNavigatorSaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.event_organizer_subBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.event_organizer_subBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("event_organizer_subBindingNavigatorSaveItem.Image")));
            this.event_organizer_subBindingNavigatorSaveItem.Name = "event_organizer_subBindingNavigatorSaveItem";
            this.event_organizer_subBindingNavigatorSaveItem.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.event_organizer_subBindingNavigatorSaveItem.Size = new System.Drawing.Size(50, 51);
            this.event_organizer_subBindingNavigatorSaveItem.Text = "Save Data";
            this.event_organizer_subBindingNavigatorSaveItem.Click += new System.EventHandler(this.event_organizer_subBindingNavigatorSaveItem_Click);
            // 
            // event_organizer_subDataGridView
            // 
            this.event_organizer_subDataGridView.AutoGenerateColumns = false;
            this.event_organizer_subDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.event_organizer_subDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.event_organizer_subDataGridView.DataSource = this.event_organizer_subBindingSource;
            this.event_organizer_subDataGridView.Location = new System.Drawing.Point(352, 175);
            this.event_organizer_subDataGridView.Name = "event_organizer_subDataGridView";
            this.event_organizer_subDataGridView.Size = new System.Drawing.Size(241, 234);
            this.event_organizer_subDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "organizer_sub_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "organizer_sub_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "organized_event";
            this.dataGridViewTextBoxColumn2.HeaderText = "organized_event";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // event_organizer_subTableAdapter
            // 
            this.event_organizer_subTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendeeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.budgetTableAdapter = null;
            this.tableAdapterManager.club_memberTableAdapter = null;
            this.tableAdapterManager.committee_memTableAdapter = null;
            this.tableAdapterManager.committeeTableAdapter = null;
            this.tableAdapterManager.event_organizer_subTableAdapter = this.event_organizer_subTableAdapter;
            this.tableAdapterManager.eventTableAdapter = null;
            this.tableAdapterManager.phonesTableAdapter = null;
            this.tableAdapterManager.sub_memTableAdapter = null;
            this.tableAdapterManager.sub_unitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniversityClubDB.uni_club_membershipDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            this.tableAdapterManager.workshop_memTableAdapter = null;
            this.tableAdapterManager.workshopTableAdapter = null;
            // 
            // AdminEventOrganizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UniversityClubDB.Properties.Resources.paper;
            this.ClientSize = new System.Drawing.Size(1044, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminEventOrganizers";
            this.Text = "AdminEventOrganizers";
            this.Load += new System.EventHandler(this.AdminEventOrganizers_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_club_membershipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subBindingNavigator)).EndInit();
            this.event_organizer_subBindingNavigator.ResumeLayout(false);
            this.event_organizer_subBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.event_organizer_subDataGridView)).EndInit();
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
        private System.Windows.Forms.BindingSource event_organizer_subBindingSource;
        private uni_club_membershipDataSetTableAdapters.event_organizer_subTableAdapter event_organizer_subTableAdapter;
        private uni_club_membershipDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator event_organizer_subBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton event_organizer_subBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView event_organizer_subDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox organizer_sub_idTextBox;
        private System.Windows.Forms.TextBox organized_eventTextBox;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}