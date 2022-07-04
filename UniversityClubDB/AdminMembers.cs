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
    public partial class AdminMembers : Form
    {
        public AdminMembers()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControlForm main = new ControlForm();
            main.Show();
            this.Hide();
        }

        private void club_memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.club_memberBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please fill all the Necessory fields");
            }

        }

        private void AdminMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.club_member' table. You can move, or remove it, as needed.
            this.club_memberTableAdapter.Fill(this.uni_club_membershipDataSet.club_member);

        }

        private void club_memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByClubMemberIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                param1ToolStripTextBox2.Clear();
                this.club_memberTableAdapter.FillByClubMemberID(this.uni_club_membershipDataSet.club_member, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
            param1ToolStripTextBox2.Clear();
            AdminMembers_Load(sender,  e);
            //this.club_memberTableAdapter.Fill(this.uni_club_membershipDataSet.club_member);
        }

        private void fillByAdminMemberNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                param1ToolStripTextBox2.Clear();
                this.club_memberTableAdapter.FillByAdminMemberName(this.uni_club_membershipDataSet.club_member, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAdminLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                param1ToolStripTextBox1.Clear();
                this.club_memberTableAdapter.FillByAdminLastName(this.uni_club_membershipDataSet.club_member, param1ToolStripTextBox2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            AdminPhones Aph = new AdminPhones();
            Aph.Show();
            this.Hide();
        }
    }
}
