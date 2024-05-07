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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WinFormsApp1
{
    public partial class Form8 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        int booking_id;
        string email;

        public Form8(string email_, int booking)
        {
            InitializeComponent();
            email = email_;
            booking_id = booking;
        }
        private object getPaymentID()
        {
            using (cmd = new SqlCommand("Select Payment_id FROM payment WHERE CardholderName = @CardholderName AND CardNumber = @CardNumber AND CVC = @CVC AND ExpDate = @ExpDate;", cn))
            {
                cmd.Parameters.AddWithValue("@CardholderName", cardName.Text);
                cmd.Parameters.AddWithValue("@CardNumber", cardNumber.Text);
                cmd.Parameters.AddWithValue("@CVC", cvc.Text);
                cmd.Parameters.AddWithValue("@ExpDate", expDate.Text);
                object result = cmd.ExecuteScalar();
                return result;
            }
        }
        private void pay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cardName.Text) && !string.IsNullOrEmpty(cardNumber.Text) && !string.IsNullOrEmpty(cvc.Text) && !string.IsNullOrEmpty(expDate.Text))
            {
                using (cn = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
                {
                    cn.Open();
                    //check if the same payment info already exists
                    if (getPaymentID() == null)
                    {
                        using (cmd = new SqlCommand("INSERT INTO payment (CardholderName, CardNumber, CVC, ExpDate) VALUES (@CardholderName, @CardNumber, @CVC, @ExpDate)", cn))
                        {
                            cmd.Parameters.AddWithValue("@CardholderName", cardName.Text);
                            cmd.Parameters.AddWithValue("@CardNumber", cardNumber.Text);
                            cmd.Parameters.AddWithValue("@CVC", cvc.Text);
                            cmd.Parameters.AddWithValue("@ExpDate", expDate.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    //add values to database
                    using (cmd = new SqlCommand("UPDATE booking SET Payment_id = @Payment_id WHERE Booking_id = @Booking_id ", cn))
                    {
                        cmd.Parameters.AddWithValue("@Payment_id", getPaymentID());
                        cmd.Parameters.AddWithValue("@Booking_id", booking_id);
                        cmd.ExecuteScalar();
                    }

                    // mark tickets as reserved only after payment details have been entered
                    using (cmd = new SqlCommand("UPDATE ticket SET IsReserved = 1 WHERE Booking_id = @Booking_id ", cn))
                    {
                        cmd.Parameters.AddWithValue("@Booking_id", booking_id);
                        cmd.ExecuteScalar();
                    }


                    MessageBox.Show("Your user information has been entered. You can continue.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    //go back to main menu (Form 1)
                    hp form = new hp(email);
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Concert form = new Concert(email);
            form.Show();
            this.Hide();
        }

        private void cardName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void cardNumber_Validating(object sender, CancelEventArgs e)
        {
            if (IsNumber(cardNumber.Text) == false)
            {
                MessageBox.Show("incorrect format", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cardNumber.Focus();
                e.Cancel = true;
            }
        }

        private void cvc_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidcvc(cvc.Text) == false)
            {
                MessageBox.Show("incorrect format", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cvc.Focus();
                e.Cancel = true;
            }
        }

        private void expDate_Validating(object sender, CancelEventArgs e)
        {
            if (IsValidExpDate(expDate.Text) == false)
            {
                MessageBox.Show("incorrect format", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expDate.Focus();
                e.Cancel = true;
            }
        }

        public static bool IsNumber(string input)
        {
            if (int.TryParse(input, out _))
            {
                return true;
            }
            return false;
        }

        public static bool IsValidcvc(string phoneNumber)
        {
            string phonePattern = @"^[0-9]{3,4}$";

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            Regex regex = new Regex(phonePattern);
            return regex.IsMatch(phoneNumber);
        }

        public static bool IsValidExpDate(string phoneNumber)
        {
            string phonePattern = @"^\d\d/\d\d$";

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            Regex regex = new Regex(phonePattern);
            return regex.IsMatch(phoneNumber);
        }

    }
}

