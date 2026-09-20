using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Users.UserQueries
{
    public static class UserDataQueries
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static bool FindUserByUserID(int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    userName = (string)reader["UserName"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                    isFound = true;
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool FindUserByUserName(ref int userID, ref int personID, string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"SELECT * FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", userName);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userID = (int)reader["UserID"];
                    personID = (int)reader["PersonID"];
                    password = (string)reader["Password"];
                    isActive = (bool)reader["IsActive"];
                    isFound = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExists(int userID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"SELECT 1 FROM Users WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if(result == null)
                {
                    return false;
                }
                isFound = true;

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }


            return isFound;
        }

        public static bool IsUserExistsByPersonID(int personID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"SELECT 1 FROM Users WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if ((result) == null)
                    return false;

                isFound = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool FindUserByUserNameAndPassword(string userName, string password, ref int personID, ref int userID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"select * from Users Where UserName = @UserName and Password = @Password;";

            bool isFound = false;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    userID = (int)reader["UserID"];
                    isActive = (bool)reader["IsActive"];

                    isFound = true;
                }
                    
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsUserExists(string userName)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"SELECT 1 FROM Users WHERE UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", userName);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if ((result) == null)
                    return false;

                isFound = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllUsers()
        {
            DataTable usersTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT Users.UserID, Users.PersonID,
              Users.UserName,
              People.FirstName + ' ' + People.SecondName + ' ' + ISNULL(People.ThirdName + ' ', '') + People.LastName AS FullName,
              Users.IsActive
              FROM            Users INNER JOIN
                         People ON Users.PersonID = People.PersonID
                ORDER BY Users.UserName;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows)
                {
                    usersTable.Load(reader);
                }

                reader.Close();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return usersTable;
        }
    }
}
