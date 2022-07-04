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
    public partial class AdminSubClubMember : Form
    {
        public AdminSubClubMember()
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

        private void sub_memBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.sub_memBindingSource.EndEdit();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "No Duplication Allowed");
            }
            this.tableAdapterManager.UpdateAll(this.uni_club_membershipDataSet);

        }

        private void AdminSubClubMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uni_club_membershipDataSet.sub_mem' table. You can move, or remove it, as needed.
            this.sub_memTableAdapter.Fill(this.uni_club_membershipDataSet.sub_mem);

        }
    }
}
