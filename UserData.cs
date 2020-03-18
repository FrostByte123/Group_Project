using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    class UserData
    {

        private String ConnectionString = string.Empty;

        public UserData()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        }

        
        public int InsertNewUser(User user)
        {


            //Create SQL QUERY FOR INSERTING A User

        string sqlQuery = String.Format("Insert into Users(Username,Firstname,Lastname,Email,Phonenumber,Password)Values('{0}','{1}','{2}','{3}','{4}','{5}');"
                        + "Select @@Identity",user.Username,user.Firstname, user.Lastname,user.Email, user.Phonenumber, user.Password);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            //Create a command object

            SqlCommand command = new SqlCommand(sqlQuery, connection);

            //Execute the command to sql server and return the newly created id

            int newUserID = Convert.ToInt32((decimal)command.ExecuteScalar());

            //Close and dispose

            command.Dispose();
            connection.Close();
            connection.Dispose();

            //Set return Value

            return newUserID;
        }

        public bool CheckingExistingUsername(String username)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select Username from Users Where Username = '{0}'", username);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            int row = command.ExecuteNonQuery();

            if (row == 0)
            {
                result = false;
            }
            else
            {
                result = true ;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }

        public bool CheckingExistingEmail(String email)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select Email from Users Where Email = '{0}'", email);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            int row = command.ExecuteNonQuery();

            if (row == 0) 
            {
                result = false;
            }
            else
            {
                result = true;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }
        //Logging in customer method
        public bool LoggingIn(String user,String pass) 
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from Users Where Username = '{0}' AND Passwords = '{1}'", user,pass);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result; 
        }

        //Logging in Admin method
        public bool AdminLoggingIn(String user, String pass)
        {
            bool result;

            //Create the SQL Query for deleting an article

            String SqlQuery = String.Format("Select * from AdminUsers Where Username = '{0}' AND Passwords = '{1}'", user, pass);

            //Create and open a connection to SQL Server

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            //Create a Command object

            SqlCommand command = new SqlCommand(SqlQuery, connection);

            //Execute the command

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            //Close and dispose 
            command.Dispose();
            connection.Close();
            connection.Dispose();
            return result;
        }

        //CHECKING IF  THE EMAIL ENTERED IS VALID
        public bool IsValidEmail(string email)
        {


            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
