using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Applicatoins.ApplicatoinDataQueries
{
    public static class ApplicatoinDataQueries
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static bool GetApplictionByID(int applicationID, ref int perosnID, ref int applicationTypeID, ref int createdByUserID, ref int applictionStatus, ref float paidFees, ref DateTime applicationDate, ref DateTime lastStatsDate)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
                
            string query = @"Select * From Applications Where ApplicationID = @ApplicationID";

            bool isFound = false;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    perosnID = (int)reader["ApplicantPersonID"];
                    applicationTypeID = (int)reader["ApplicationTypeID"];
                    createdByUserID = (int)reader["CreatedByUserID"];
                    applictionStatus = (int)reader["ApplictionStatus"];
                    paidFees = (int)reader["PaidFees"];
                    applicationDate = (DateTime)reader["ApplicationDate"];
                    lastStatsDate = (DateTime)reader["LastStatsDate"];

                    isFound = true;
                }
                    

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

            return isFound;

        }
    }
}
