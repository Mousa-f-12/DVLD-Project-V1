using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Users.UserCommands
{
    public static class UserDataCommands
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static int InsertUser(int personID, string userName, string password, bool isActive = true)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"
                            INSERT INTO [dbo].[Users]
                                       ([PersonID]
                                       ,[UserName]
                                       ,[Password]
                                       ,[IsActive])
                                 VALUES
                                       (@PersonID, @UserName, @Password, @IsActive);

                                 Select SCOPE_IDENTITY(); ";

            int userID = -1;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

               if(result != null)
                    int.TryParse(result.ToString(), out userID);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return userID;
        }

        public static bool UpdateUser(int userID, int personID, string userName, string password, bool isActive)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            int rowsAffected = 0;

            string query = @"UPDATE [dbo].[Users]
                           SET [PersonID] = @PersonID,
                               [UserName] = @UserName,
                               [Password] = @Password,
                               [IsActive] = @IsActive
                         WHERE UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);
            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int userID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            int rowsAffected = 0;

            string query = @"Delete From Users Where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

    }
}
