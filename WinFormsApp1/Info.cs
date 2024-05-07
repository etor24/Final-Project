using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Info : Form
    {
        private authenticate.User authenticateUser;
        private SqlCommand cmd;
        private SqlConnection cn;

        string Email = " ";


        public Info()
        {
            InitializeComponent();
        }
        public Info(authenticate.User user)
        {
            InitializeComponent();
            authenticateUser = user;
            Email = authenticateUser.Email;
            email.Text = Email;
        }
        public Info(string email_)
        {
            InitializeComponent();
            email.Text = email_;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("Select FirstName, LastName, PhoneNumber, DoB From contactInfo WHERE Email = @Email;", cn))
                {
                    cmd.Parameters.AddWithValue("@Email", Email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Check if a record was found
                        {

                            string firstName = reader["FirstName"].ToString();
                            string lastName = reader["LastName"].ToString();
                            string phoneNumber = reader["PhoneNumber"].ToString();
                            DateTime dob = (DateTime)reader["DoB"]; 

                            firstname.Text = firstName;
                            lastname.Text = lastName;
                            number.Text = phoneNumber;
                            dateTimePicker1.Value = dob;
                        }

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
            {
                cn.Open();
                //check if empty
                if (checkBox1.Checked && !string.IsNullOrEmpty(firstname.Text) && !string.IsNullOrEmpty(lastname.Text) && !string.IsNullOrEmpty(email.Text) && !string.IsNullOrEmpty(number.Text))
                {
                    //check if email exists
                    using (cmd = new SqlCommand("Select Contact_id From contactInfo WHERE Email = @Email;", cn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email.Text);
                        object result = cmd.ExecuteScalar();
                        //if yes uptade information where email = email
                        if (result != null)
                        {
                            using (cmd = new SqlCommand("UPDATE contactInfo SET FirstName = @FirstName,  LastName = @LastName,  PhoneNumber = @PhoneNumber, DoB = @DoB WHERE Contact_id = @Contact_id;", cn))

                            {
                                cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                                cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                                cmd.Parameters.AddWithValue("@PhoneNumber", number.Text);
                                cmd.Parameters.AddWithValue("@DoB", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@Contact_id", Convert.ToInt32(result));
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Your user information has been updated. You can continue.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Concert form = new Concert(Email);
                                form.Show();
                            }
                        }
                        //if no insert infromation
                        else
                        {
                            using (cmd = new SqlCommand("Select * From userInfo WHERE Email = @Email;", cn))
                            {
                                cmd.Parameters.AddWithValue("@Email", email.Text);
                                object result1 = cmd.ExecuteScalar();  
                                if (result1 == null)
                                {
                                    using (cmd = new SqlCommand("INSERT INTO userInfo(Email) VALUES(@Email)", cn))
                                        cmd.Parameters.AddWithValue("@Email", email.Text);
                                        cmd.ExecuteScalar();
                                }
                                using (cmd = new SqlCommand("INSERT INTO contactInfo (FirstName, LastName, PhoneNumber, DoB, Email) VALUES (@FirstName, @LastName, @PhoneNumber, @DoB, @Email)", cn))
                                {
                                    cmd.Parameters.AddWithValue("@FirstName", firstname.Text);
                                    cmd.Parameters.AddWithValue("@LastName", lastname.Text);
                                    cmd.Parameters.AddWithValue("@PhoneNumber", number.Text);
                                    cmd.Parameters.AddWithValue("@DoB", dateTimePicker1.Value);
                                    cmd.Parameters.AddWithValue("@Email", email.Text);
                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Your user information has been entered. You can continue.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Hide();
                                    Concert form = new Concert(email.Text);
                                    form.Show();
                                }
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields and check the box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCheckAge_Click(object sender, EventArgs e)
        {
            DateTime specificDate = DateTime.Today.AddYears(-18);
            DateTime birthDate = dateTimePicker1.Value;

            if (birthDate <= specificDate)
            {
                MessageBox.Show("You can continue, since you are at least 18 years old.", "Age Verification");
            }
            else
            {
                MessageBox.Show("Sorry, you must be at least 18 years old to proceed.", "Age Verification");
            }
        }

        private void number_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidPhone(number.Text) == false)
            {
                MessageBox.Show("Are you sure that's your phone number? Invalid phone number!", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                number.Focus();
                e.Cancel = true;
            }
        }
        public static bool IsValidPhone(string phoneNumber)
        {
            string phonePattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            Regex regex = new Regex(phonePattern);
            return regex.IsMatch(phoneNumber);
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.SelectAll();
                e.Cancel = true;
            }
        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, emailPattern);
        }

        private void firstname_Validating(object sender, CancelEventArgs e)
        {
            if (firstname.Text.Length <= 2)
            {
                MessageBox.Show("Username should be at least 2 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                firstname.Focus();
                e.Cancel = true;
            }

            string[] forbiddenWords = { "baby", "girl", "Eda" };
            foreach (string word in forbiddenWords)
            {
                if (firstname.Text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    MessageBox.Show("The username cannot contain the word '" + word + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    firstname.Focus();
                    e.Cancel = true; // Cancel the event to prevent the focus from changing
                    return; // Exit the event handler early since further checks are unnecessary
                }
            }
        }

        private void lastname_Validating(object sender, CancelEventArgs e)
        {
            if (lastname.Text.Length <= 2)
            {
                MessageBox.Show("Username should be at least 2 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastname.Focus();
                e.Cancel = true;
            }

            string[] forbiddenWords = { "baby", "girl", "Yavuz", "wdym", "leave" };
            foreach (string word in forbiddenWords)
            {
                if (lastname.Text.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    MessageBox.Show("The username cannot contain the word '" + word + "'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lastname.Focus();
                    e.Cancel = true; 
                    return; 
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Checkbox is checked!", "You agree to our terms and conditions stating that (in short) your information will stay in the database until you remove your information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Checkbox is unchecked!", "Just so you know, you won't be able to continue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
