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
    public partial class Budget : Form
    {
        public Budget()
        {
            InitializeComponent();
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

        private void budgetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.budgetBindingSource.EndEdit();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Duplications not allowed");
            }
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void Budget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.uni_club_membershipDataSet.budget);

        }
    }
}
