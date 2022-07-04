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
    public partial class HomePage : Form
    {

        public HomePage()
        {
            InitializeComponent();
        }

      
        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            members mem = new members();
            mem.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void committeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Committees com = new Committees();
            com.Show();
            this.Hide();
        }

        private void clubsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clubs cl = new Clubs();
            cl.Show();
            this.Hide();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            events ev = new UniversityClubDB.events();
            ev.Show();
            this.Hide();
        }

        private void workshopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workshop ws = new Workshop();
            ws.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BudgetOfSubclubs bg = new BudgetOfSubclubs();
            bg.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MemberActivity ma = new MemberActivity();
            ma.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TotalActivities ac= new TotalActivities();
            ac.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            NumOfMeminSubclubs nc = new NumOfMeminSubclubs();
            nc.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Managers mn = new Managers();
            mn.Show();
            this.Hide();
        }
    }
}
