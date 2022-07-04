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
    public partial class ControlForm : Form
    {
        public ControlForm()
        {
            InitializeComponent();
        }

        private void committeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminMembers mem = new AdminMembers();
            mem.Show();
            this.Hide();
        }

        private void committeesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AdminCommittees acom = new AdminCommittees();
            acom.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminClubs ac = new AdminClubs();
            ac.Show();
            this.Hide();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminEvents ae = new AdminEvents();
            ae.Show();
            this.Hide();
        }

        private void workshopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminWorkshops aws = new AdminWorkshops();
            aws.Show();
            this.Hide();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            AdminCommitteeMembers acm = new AdminCommitteeMembers();
            acm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            AdminSubClubMember asm = new AdminSubClubMember();
            asm.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            AdminWorkshopMembers awsh = new AdminWorkshopMembers();
            awsh.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            AdminEventAttendents eatn = new AdminEventAttendents();
            eatn.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Budget bgt = new Budget();
            bgt.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AdminUsers adusers = new AdminUsers();
            adusers.Show();
            this.Hide();
        }
    }
}
