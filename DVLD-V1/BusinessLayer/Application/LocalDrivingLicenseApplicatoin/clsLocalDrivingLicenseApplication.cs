using DataAccessLayer.Applicatoins.Applications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Application.clsApplication;

namespace BusinessLayer.Application.LocalDrivingLicenseApplicatoin
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public int L_D_L_AppID { set; get; }

        public string LicenseClassID { set; get; }

        public int ApplicationPersonID { set; get; }

        private enum _enMode { eAddnew, eUpdate}

        private _enMode _mode = _enMode.eAddnew;


        public clsLocalDrivingLicenseApplication()
        {
            this.L_D_L_AppID = -1;
            this.LicenseClassID = "";
            this.ApplicationPersonID = -1;

            _mode = _enMode.eAddnew;
        }

        private clsLocalDrivingLicenseApplication(int l_D_L_AppID, string licenseClassID, int applicationPersonID)
        {
            this.L_D_L_AppID = l_D_L_AppID;
            this.LicenseClassID = licenseClassID;
            this.ApplicationPersonID = applicationPersonID;

            _mode = _enMode.eUpdate;
        }

    }
}   
