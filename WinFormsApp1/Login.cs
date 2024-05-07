using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WinFormsDemo.authenticate;
using WinFormsDemo;
using Microsoft.VisualBasic;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Login : Form
    {
        private authenticate.User authenticateUser;
        private SqlCommand cmd;
        private SqlConnection cn;
        public Login()
        {
            InitializeComponent();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user = email.Text;
            string pass = password.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                authenticate.User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {


                    using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
                    {
                        cn.Open();
                        using (cmd = new SqlCommand("Select Contact_id From contactInfo WHERE Email = @Email;", cn))
                        {
                            cmd.Parameters.AddWithValue("@Email", email.Text);
                            object result = cmd.ExecuteScalar();
                            //if yes uptade information where email = email
                            if (result != null)
                            {
                                hp inf = new hp(email.Text);
                                inf.Show();
                                this.Hide();
                            }
                            else
                            {
                                Info inf = new Info(authenticatedUser);
                                inf.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid email or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both email and password.");
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            Homepage inf = new Homepage();
            inf.Show();
            this.Hide();
        }
    }
}
