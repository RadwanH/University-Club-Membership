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
    public partial class Committees : Form
    {
        public Committees()
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
            HomePage main = new HomePage();
            main.Show();
            this.Hide();
        }

        private void committeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.committeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void Committees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.committee' table. You can move, or remove it, as needed.
            this.committeeTableAdapter.Fill(this.uni_club_membershipDataSet.committee);

        }

        private void fillByComIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.committeeTableAdapter.FillByComID(this.uni_club_membershipDataSet.committee, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByComNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                this.committeeTableAdapter.FillByComName(this.uni_club_membershipDataSet.committee, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            Committees_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
            
        }
    }
}
