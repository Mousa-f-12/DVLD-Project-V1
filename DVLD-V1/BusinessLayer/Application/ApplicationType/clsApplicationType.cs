using System;
using System.ComponentModel;
using System.Data;
using DataAccessLayer.Applicatoins.ApplicatoinDataCommands;
using DataAccessLayer.Applicatoins.ApplicatoinTypeDataQuery;


namespace BusinessLayer.Application
{
    public class clsApplicationType
    {
        public int ApplicationTypeID { set; get; }

        public string ApplicationTypeTitle { set; get; }

        public  float ApplicationFees { set; get; }

        private enum _enMode {eUpdate}

        private _enMode Mode = _enMode.eUpdate;

        private clsApplicationType(int applicationTypeID, string applicationTypeTitle, float applicationFees)
        {
            this.ApplicationTypeID = applicationTypeID;
            this.ApplicationTypeTitle = applicationTypeTitle;
            this.ApplicationFees = applicationFees;

            this.Mode = _enMode.eUpdate;
        }

        private bool _EditApplicationTypeInfo()
        {
            return ApplicatoinTypeDataCommand.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return ApplicatoinTypeDataQuery.GetAllApplicatoinTypes();
        }

        public static clsApplicationType Find(int applicationTypeID)
        {
            float applicationFees = 0;
            string applicationTypeTitle = "";
            
            if (ApplicatoinTypeDataQuery.FindApplicationType(applicationTypeID, ref applicationTypeTitle, ref applicationFees))
            {
                return new clsApplicationType(applicationTypeID, applicationTypeTitle, applicationFees);
            }
            return null;
        }

        public bool Save()
        {

            switch(Mode)
            {
                case _enMode.eUpdate:
                    {
                        if (_EditApplicationTypeInfo())
                        {
                            return true;
                        }
                        break;
                    }
            }
            return default;
        }
    }
}   
    