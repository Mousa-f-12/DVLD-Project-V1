using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Applicatoins.LocalDrivingLicense.LocalDrivingLicenseDataCommands
{
    internal class LocalDrivingLicenseDataCommands
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

    }
}
