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
    public partial class AdminClubs : Form
    {
        public AdminClubs()
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

        private void sub_unitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.sub_unitBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);
            } catch (Exception ex)
            {
              MessageBox.Show(ex.Message, "Please fill all necessory fields ");
            }
                

        }

        private void AdminClubs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.sub_unit' table. You can move, or remove it, as needed.
            this.sub_unitTableAdapter.Fill(this.uni_club_membershipDataSet.sub_unit);

        }

        private void fillByAdminClubIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.sub_unitTableAdapter.FillByAdminClubID(this.uni_club_membershipDataSet.sub_unit, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByAdminCLubNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                this.sub_unitTableAdapter.FillByAdminCLubName(this.uni_club_membershipDataSet.sub_unit, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            AdminClubs_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
        }
    }
}
