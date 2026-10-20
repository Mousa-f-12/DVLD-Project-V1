using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Applicatoins.ApplicatoinTypeDataQuery
{
    public static class ApplicatoinTypeDataQuery
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static DataTable GetAllApplicatoinTypes()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            DataTable applicationTypesTable = new DataTable();
                
            string query = @"Select * From ApplicationTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    applicationTypesTable.Load(reader);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }

            return applicationTypesTable;
        }

        public static bool FindApplicationType(int applicationTypeID, ref string applicationTypeTitle, ref float applicationFees)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            bool isFound = false;

            string query = @"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    applicationFees = (float)((decimal)reader["ApplicationFees"]); 
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
