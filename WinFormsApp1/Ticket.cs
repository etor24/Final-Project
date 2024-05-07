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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class ticket : Form
    {
        private SqlConnection sqlConnection;
        string email;
        int concert_id;
        int booking_id;
        int totalprice = 0;
        public ticket(string email_, int concert_id_)
        {
            InitializeComponent();
            email = email_;
            concert_id = concert_id_;
            string connectionString = @"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;";
            sqlConnection = new SqlConnection(connectionString);
            LoadSeats();
        }
        private void LoadSeats()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Ticket_id, IsReserved FROM ticket WHERE Concert_id = @Concert_id", sqlConnection);
                cmd.Parameters.AddWithValue("@Concert_id", concert_id);
                SqlDataReader reader = cmd.ExecuteReader();

                int x = 10, y = 10; // Starting position for the buttons
                while (reader.Read())
                {
                    var btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Location = new Point(x, y);
                    btn.Text = reader["Ticket_id"].ToString();
                    btn.Tag = reader["IsReserved"].Equals(true) ? "Reserved" : "Available";

                    if (Convert.ToInt32(reader["IsReserved"]) == 1)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Green;
                    }

                    btn.Click += new EventHandler(Seat_Click);
                    panel1.Controls.Add(btn);

                    x += 50;
                    if (x > 200) // Move to next row
                    {
                        x = 10;
                        y += 50;
                    }
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Seat_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (btn.BackColor == Color.Green)
                {
                    btn.BackColor = Color.White; // Selected
                    sqlConnection.Open();
                    //add contact_id to booking
                    int seatId = Convert.ToInt32(btn.Text);
                    using (SqlCommand command = new SqlCommand("SELECT Price FROM ticket WHERE Ticket_id = @Ticket_id;", sqlConnection))
                    {
                       
                        command.Parameters.AddWithValue("@Ticket_id", seatId);
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalprice += Convert.ToInt32(result);
                        }
                        price.Text = totalprice.ToString();
                    }
                    sqlConnection.Close();

                }
                else if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Green; // Deselect
                    sqlConnection.Open();
                    int seatId = Convert.ToInt32(btn.Text);
                    using (SqlCommand command = new SqlCommand("SELECT Price FROM ticket WHERE Ticket_id = @Ticket_id;", sqlConnection))
                    {

                        command.Parameters.AddWithValue("@Ticket_id", seatId);
                        object result = command.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalprice -= Convert.ToInt32(result);
                        }
                        price.Text = totalprice.ToString();
                    }
                    sqlConnection.Close();
                }
                // Ignore if red
            }
        }

        //ticket resrvation
        private void button1_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            //add contact_id to booking
            using (SqlCommand command = new SqlCommand("INSERT INTO booking (Contact_id) SELECT Contact_id FROM contactInfo WHERE Email = @Email", sqlConnection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
            }

            using (SqlCommand command2 = new SqlCommand("SELECT Booking_id FROM booking WHERE Contact_id = (SELECT Contact_id FROM contactInfo WHERE Email = @Email)", sqlConnection))
            {
                command2.Parameters.AddWithValue("@Email", email);
                object result = command2.ExecuteScalar();
                booking_id = Convert.ToInt32(command2.ExecuteScalar());

                if (result != null)
                {

                    //add booking id to ticket
                    foreach (Button btn in panel1.Controls)
                    {
                        if (btn.BackColor == Color.White) // If selected
                        {
                            int seatId = Convert.ToInt32(btn.Text);
                            SqlCommand cmd = new SqlCommand("UPDATE ticket SET Booking_id = @Booking_id WHERE Ticket_id = @Ticket_id", sqlConnection);
                            cmd.Parameters.AddWithValue("@Booking_id", booking_id);
                            cmd.Parameters.AddWithValue("@Ticket_id", seatId);
                            cmd.ExecuteNonQuery();

                        }
                    }
                    Form8 form = new Form8(email, booking_id);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("error.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Concert form = new Concert(email);
            form.Show();
            this.Hide();
        }
    }
}
