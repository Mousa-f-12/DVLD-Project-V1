using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccessLayer.Applicatoins.LocalDrivingLicense.LocalDrivingLicenseDataCommands
{
    public static class LocalDrivingLicenseDataQueries
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            DataTable localDrivingLicenseApplicationsTable = new DataTable();

            string query = @"SELECT        LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LicenseClasses.ClassName, People.FirstName + ' ' + People.SecondName+ ' ' +  People.ThirdName+ ' ' +  People.LastName as 'Full Name', Applications.ApplicationDate, 
                         Applications.ApplicationStatus
                         FROM            LocalDrivingLicenseApplications INNER JOIN
                         LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN
                         Applications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                         People ON Applications.ApplicantPersonID = People.PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    localDrivingLicenseApplicationsTable.Load(reader);

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

            return localDrivingLicenseApplicationsTable;
        }

    }
}
