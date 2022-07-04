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
    public partial class AdminEvents : Form
    {
        public AdminEvents()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ControlForm cf = new ControlForm();
            cf.Show();
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
            try
            {
                this.Validate();
                this.eventBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please fill all the neccesoru feilds");
            }

        }

        private void AdminEvents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet._event' table. You can move, or remove it, as needed.
            this.eventTableAdapter.Fill(this.uni_club_membershipDataSet._event);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void fillByAdminEvent_idToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.eventTableAdapter.FillByAdminEvent_id(this.uni_club_membershipDataSet._event, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
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
            AdminEvents_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            AdminEventOrganizers evorg = new AdminEventOrganizers();
            evorg.Show();
            this.Hide();
        }
    }
}
