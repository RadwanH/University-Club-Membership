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
    public partial class AdminUsers : Form
    {
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControlForm main = new ControlForm();
            main.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }


        private void usersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.usersBindingSource.EndEdit();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please Check Your Values");
            }
                this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet1);
            

        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet1.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.uni_club_membershipDataSet1.users);

        }
    }
}
