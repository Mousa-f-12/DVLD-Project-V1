using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tests.TestType.TestTypeDataQueries
{
    public class TestTypeDataQueryies
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static DataTable GetAllTestTypes()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            DataTable TestTypesTable = new DataTable();

            string query = @"Select * From TestTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    TestTypesTable.Load(reader);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return TestTypesTable;
        }

        public static bool FindTestType(int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref float testTypeFees)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            bool isFound = false;

            string query = @"SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testTypeTitle = (string)reader["TestTypeTitle"];
                    testTypeDescription = (string)reader["TestTypeDescription"];
                    testTypeFees = (float)((decimal)reader["TestTypeFees"]);
                }


                isFound = true;
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

    }
}
