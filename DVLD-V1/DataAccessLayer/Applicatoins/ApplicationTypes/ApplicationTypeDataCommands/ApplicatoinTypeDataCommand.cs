using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Applicatoins.ApplicatoinDataCommands
{
    public class ApplicatoinTypeDataCommand
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;
        
        public static bool UpdateApplicationType(int applicationTypeID, string applicationTypeTitle, float applicationFees)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            int rowsAffected = 0;

            string query = @"UPDATE [dbo].[ApplicationTypes]
                            SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                            ,[ApplicationFees] = @ApplicationFees
                                WHERE ApplicationTypeID = @ApplicationTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", applicationFees);

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
