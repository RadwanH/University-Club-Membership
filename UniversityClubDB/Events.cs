﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityClubDB
{
    public partial class events : Form
    {
        public events()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage main = new HomePage();
            main.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void events_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet._event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.uni_club_membershipDataSet._event);

        }

        private void fillByEventIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.eventTableAdapter.FillByEventID(this.uni_club_membershipDataSet._event, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByeventNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                this.eventTableAdapter.FillByeventName(this.uni_club_membershipDataSet._event, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            events_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
        }
    }
}
