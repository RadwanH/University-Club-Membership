using System;
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
    public partial class AdminPhones : Form
    {
        public AdminPhones()
        {
            InitializeComponent();
        }

        private void phonesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phonesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void AdminPhones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.uni_club_membershipDataSet.phones);

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

        private void button1_Click(object sender, EventArgs e)
        {
            
            AdminMembers am = new AdminMembers();
            am.Show();
            this.Hide();
        }
    }
}
