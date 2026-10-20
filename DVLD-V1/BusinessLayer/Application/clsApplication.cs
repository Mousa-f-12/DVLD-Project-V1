using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Applicatoins.ApplicatoinDataQueries;
namespace DataAccessLayer.Applicatoins.Applications
{
    public class clsApplication
    {
        public int ApplicationID { get; set; }

        public int PerosnID { get; set; }

        public int ApplicationTypeID { get; set; }

        public int CreatedByUserID { get; set; }

        public int ApplictionStatus { get; set; }

        public float PaidFees { get; set; }

        public DateTime ApplicationDate { get; set; }

        public DateTime LastStatsDate { get; set; }

        private enum _enMode { eAddNew, eUpdate}

        private _enMode _Mode = _enMode.eAddNew;

        private clsApplication(int applicationID, int perosnID, int applicationTypeID, int createdByUserID, int applictionStatus, float paidFees, DateTime applicationDate, DateTime lastStatsDate)
        {
            this.ApplicationID     = applicationID;
            this.PerosnID          = perosnID;
            this.ApplicationTypeID = ApplicationTypeID;
            this.CreatedByUserID   = createdByUserID;
            this.ApplictionStatus  = ApplictionStatus;
            this.PaidFees          = paidFees;
            this.ApplicationDate   = applicationDate;
            this.LastStatsDate     = lastStatsDate;
            this._Mode = _enMode.eUpdate;
        }

        public clsApplication()
        {
            this.ApplicationID = -1;
            this.PerosnID = -1;
            this.ApplicationTypeID = -1;
            this.CreatedByUserID = -1;
            this.ApplictionStatus = -1;
            this.PaidFees = 0;
            this.ApplicationDate = DateTime.Now.Date;
            this.LastStatsDate = DateTime.Now.Date;
            this._Mode = _enMode.eAddNew;
        }


        public static clsApplication Find(int applicationID)
        {
            int perosnID = -1;
            int applicationTypeID = -1;
            int createdByUserID = -1;
            int applictionStatus = -1;
            float paidFees = 0;
            DateTime applicationDate = DateTime.Now.Date;
            DateTime lastStatsDate = DateTime.Now.Date;

            if(ApplicatoinDataQueries.ApplicatoinDataQueries.GetApplictionByID(applicationID, ref perosnID, ref applicationTypeID, ref createdByUserID, ref applictionStatus, ref paidFees, ref applicationDate, ref lastStatsDate))
                return new clsApplication(applicationID,  perosnID,  applicationTypeID,  createdByUserID,  applictionStatus,  paidFees,  applicationDate,  lastStatsDate);

            return null;
        }

    }
}
