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
    public partial class AdminEventOrganizers : Form
    {
        public AdminEventOrganizers()
        {
            InitializeComponent();
        }

        private void event_organizer_subBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.event_organizer_subBindingSource.EndEdit();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Please check your inputs");
            }
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void AdminEventOrganizers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.event_organizer_sub' table. You can move, or remove it, as needed.
            this.event_organizer_subTableAdapter.Fill(this.uni_club_membershipDataSet.event_organizer_sub);

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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminEvents adev = new AdminEvents();
            adev.Show();
            this.Hide();
        }
    }
}
