using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UniversityClubDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clrBtn(object sender, EventArgs e)
        {
            userName.Text = "";
            password.Clear();
            userName.Focus();
        }

        private void LoginBtn(object sender, EventArgs e)
        {

            /*if(userName.Text == "admin" && password.Text == "admin")
            {
                ControlForm cf = new ControlForm();
                cf.Show();
                this.Hide();
            } else if (userName.Text == "ali2022" && password.Text == "ali2022")
            {
                HomePage main = new HomePage();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check your username or password..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clrBtn(sender, e);
            }*/

            
            //to-do check login username and password
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\uni_club_membership.mdf;Integrated Security=True");
           
            SqlDataAdapter sda = new SqlDataAdapter(@"select * 
            FROM[uni_club_membership].users
            where username = '"+ userName.Text +"'and password ='"+ password.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                if (userName.Text == "admin")
                {
                    ControlForm cf = new ControlForm();
                    cf.Show();
                    this.Hide();
                }
              else
                {
                    HomePage main = new HomePage();
                    main.Show();
                    this.Hide();
                }
                
            } else
            {
                MessageBox.Show("Wrong username or password..!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error );
               
                clrBtn(sender, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
