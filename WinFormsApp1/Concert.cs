using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Concert : Form
    {
        string email;
        int selectedConcert;
        public Concert(string email_)
        {
            InitializeComponent();
            email = email_;
        }

        private void Concert_Load(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = null;
                Artist.SelectedIndex = -1;
                City.SelectedIndex = -1;
                Genre.SelectedIndex = -1;
                Date.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
                {
                    sqlCon.Open(); 


                    string query = "SELECT * FROM concert WHERE 1 = 1";
                    List<string> conditions = new List<string>();

                    // Check each ComboBox and add a condition if an item is selected
                    if (Artist.SelectedItem != null)
                        conditions.Add("Artist = @Artist");

                    if (City.SelectedItem != null)
                        conditions.Add("City = @City");

                    if (Genre.SelectedItem != null)
                        conditions.Add("Genre = @Genre");

                    if (Date.SelectedItem != null)
                        conditions.Add("ConcrtDate = @ConcrtDate");

                    // combine the conditions into the SQL query
                    if (conditions.Count > 0)
                    {
                        query += " AND " + string.Join(" AND ", conditions);
                    }



                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    if (Artist.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@Artist", Artist.SelectedItem.ToString());
                    if (City.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@City", City.SelectedItem.ToString());
                    if (Genre.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@Genre", Genre.SelectedItem.ToString());
                    if (Date.SelectedItem != null)
                        cmd.Parameters.AddWithValue("@ConcrtDate", Date.SelectedItem.ToString());

                    // Use SqlDataAdapter to fetch data and populate DataGridView
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reserve_Click(object sender, EventArgs e)
        {

            if (concert_id.Text != null && IsNumber(concert_id.Text))
            {
                selectedConcert = Convert.ToInt32(concert_id.Text);
                ticket form = new ticket(email, selectedConcert);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Input the concert_id as a number of the concert you want to attend", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Hide();
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

        private void clear_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                Artist.SelectedIndex = -1;
                City.SelectedIndex = -1;
                Genre.SelectedIndex = -1;
                Date.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string query = "SELECT * FROM concert WHERE Artist LIKE @Search OR City LIKE @Search OR Genre LIKE @Search";

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@Search", "%" + searchbar.Text + "%");


                    // Use SqlDataAdapter to fetch data and populate DataGridView
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            hp form = new hp(email);
            form.Show();
            this.Hide();
        }
    }
}
