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
    public partial class AdminCommittees : Form
    {
        public AdminCommittees()
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
            ControlForm cf = new ControlForm();
            cf.Show();
            this.Hide();
        }

        private void committeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.committeeBindingSource.EndEdit();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Please check your values");
            }
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void AdminCommittees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.committee' table. You can move, or remove it, as needed.
            this.committeeTableAdapter.Fill(this.uni_club_membershipDataSet.committee);

        }

        private void fillByAdminComNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.committeeTableAdapter.FillByAdminComName(this.uni_club_membershipDataSet.committee, param1ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAdminComIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                this.committeeTableAdapter.FillByAdminComID(this.uni_club_membershipDataSet.committee, ((int)(System.Convert.ChangeType(param1ToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AdminCommittees_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
        }
    }
}
