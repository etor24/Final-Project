using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{

    public partial class Register : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;
        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("invalid email", "error", MessageBoxButtons.OKCancel);
                email.SelectAll();
                e.Cancel = true;
            }
        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void password_Validating(object sender, CancelEventArgs e)
        {
            if (!(password.Text.Length > 8 && password.Text.Any(char.IsUpper) && password.Text.Any(char.IsLower) && password.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                password.SelectAll();
                e.Cancel = true;
            }
        }

        private void registerr_Click(object sender, EventArgs e)
        {

            // Connecting to the database
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
            {
                cn.Open();

                // Checking if passwords match
                if (!string.IsNullOrEmpty(password.Text) && !string.IsNullOrEmpty(repassword.Text))
                {
                    if (password.Text == repassword.Text)
                    {
                        // Checking if the email already exists
                        using (cmd = new SqlCommand("SELECT email FROM userInfo WHERE Email = @email", cn))
                        {
                            cmd.Parameters.AddWithValue("@email", email.Text);
                            using (dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    MessageBox.Show("Account with email already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    dr.Close();

                                    // Inserting user information into the database
                                    using (cmd = new SqlCommand("INSERT INTO userInfo (Email, Password) VALUES (@email, @password)", cn))
                                    {
                                        cmd.Parameters.AddWithValue("@email", email.Text);
                                        cmd.Parameters.AddWithValue("@password", password.Text);
                                        cmd.ExecuteNonQuery();

                                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Hide();
                                        Login login = new Login();
                                        login.Show();
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

            length.Show();
            capital.Show();
            lowercase.Show();
            number.Show();

            if (password.Text.Any(char.IsUpper))
                capital.ForeColor = Color.Green;
            else
                capital.ForeColor = Color.Red;

            if (password.Text.Any(char.IsLower))
                lowercase.ForeColor = Color.Green;
            else
                lowercase.ForeColor = Color.Red;

            if (password.Text.Length > 8)
                length.ForeColor = Color.Green;
            else
                length.ForeColor = Color.Red;

            if (password.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Red;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage inf = new Homepage();
            inf.Show();
            this.Hide();
        }
    }
}
