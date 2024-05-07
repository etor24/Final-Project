using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDemo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace WinFormsDemo
{
    // Authentication class
    public class authenticate
    {

        public class User
        {
            public string Email { get; set; } // User's email property
        }

        public class DatabaseManager
        {

            public static User AuthenticateUser(string email, string password)
            {
                User user = RetrieveUserInformation(email, password);
                return user;
            }

            private static User RetrieveUserInformation(string email, string password)
            {

                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-JR9UHT4\SQLEXPRESS; Initial Catalog=concerts; Integrated Security=True;"))
                {
                    sqlCon.Open(); 

                    string loginQuery = "SELECT COUNT(1) FROM userInfo WHERE Email=@email AND Password=@password";

                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {

                        loginCmd.CommandType = CommandType.Text;

                        loginCmd.Parameters.AddWithValue("@email", email);
                        loginCmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                        if (count == 1)
                        {
                            return new User { Email = email };
                        }

                        return null; // Return null if no user is found with the specified email and password

                    }
                }
            }
        }

    }
}

