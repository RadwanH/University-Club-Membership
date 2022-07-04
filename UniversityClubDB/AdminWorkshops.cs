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
    public partial class AdminWorkshops : Form
    {
        public AdminWorkshops()
        {
            InitializeComponent();
        }

        private void workshopBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.workshopBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please fill all the necessory fields");
            }

        }

        private void AdminWorkshops_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.workshop' table. You can move, or remove it, as needed.
            this.workshopTableAdapter.Fill(this.uni_club_membershipDataSet.workshop);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void w_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void w_nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void w_typeLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_typeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void w_start_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_start_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void w_end_dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_end_dateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void w_capacityLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_capacityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void org_sub_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tutorLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void w_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void org_sub_idLabel_Click(object sender, EventArgs e)
        {

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

        private void fillByWorkshopIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox1.Clear();
                this.workshopTableAdapter.FillByWorkshopID(this.uni_club_membershipDataSet.workshop, ((int)(System.Convert.ChangeType(param1ToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByWorkshopNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                param1ToolStripTextBox.Clear();
                this.workshopTableAdapter.FillByWorkshopName(this.uni_club_membershipDataSet.workshop, param1ToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AdminWorkshops_Load(sender, e);
            param1ToolStripTextBox.Clear();
            param1ToolStripTextBox1.Clear();
        }
    }
}
