using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tests.TestType.TestTypeDataCommands
{
    public class TestTypeDataCommans
    {

        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static bool UpdateTestType(int testTypeID, string testTypeTitle, string testTypeDescription, float testTypeFees)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            int rowsAffected = 0;

            string query = @"UPDATE [dbo].[TestTypes]
                           SET [TestTypeTitle] = @TestTypeTitle
                              ,[TestTypeDescription] = @TestTypeDescription
                              ,[TestTypeFees] = @TestTypeFees
                         WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);
            command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
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
