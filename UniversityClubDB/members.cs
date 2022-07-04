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
    public partial class members : Form
    {

        public members()
        {
            InitializeComponent();
        }


        private void members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.club_member' table. You can move, or remove it, as needed.
            this.club_memberTableAdapter.Fill(this.uni_club_membershipDataSet.club_member);

        }

     
        private void club_memberDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void toolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void memberTitle_Click(object sender, EventArgs e)
        {

        }

        private void club_memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.club_memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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

        private void fillByMemberNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                param1ToolStripTextBox1.Clear();
                this.club_memberTableAdapter.FillByMemberName(this.uni_club_membershipDataSet.club_member, param2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void fillByMemberLastNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                param2ToolStripTextBox.Clear();
                this.club_memberTableAdapter.FillByMemberLastName(this.uni_club_membershipDataSet.club_member, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            members_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
            param2ToolStripTextBox.Clear();
        }

        private void fillByMemberIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.club_memberTableAdapter.FillByMemberID(this.uni_club_membershipDataSet.club_member);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByMember_idToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                param2ToolStripTextBox.Clear();
                this.club_memberTableAdapter.FillByMember_id(this.uni_club_membershipDataSet.club_member, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
