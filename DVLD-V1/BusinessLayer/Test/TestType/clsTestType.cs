using DataAccessLayer.Tests.TestType.TestTypeDataQueries;
using DataAccessLayer.Tests.TestType.TestTypeDataCommands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Test.TestType
{
    public class clsTestType
    {
        public int TestTypeID { set; get; }

        public string TestTypeTitle { set; get; }

        public string TestTypeDescription { set; get; }

        public float TestTypeFees { set; get; }

        private enum _enMode { eUpdate}

        private _enMode _Mode = _enMode.eUpdate;

        private clsTestType(int testTypeID, string testTypeTitle, string testTypeDescription,  float testTypeFees)
        {
            this.TestTypeID = testTypeID;
            this.TestTypeTitle = testTypeTitle;
            this.TestTypeDescription = testTypeDescription;
            this.TestTypeFees = testTypeFees;

            this._Mode = _enMode.eUpdate;
        }

        private bool _EditTestTypeInfo()
        {
            return TestTypeDataCommans.UpdateTestType(this.TestTypeID, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }

        public static DataTable GetAllApplicationTypes()
        {
            return TestTypeDataQueryies.GetAllTestTypes();
        }

        public static clsTestType Find(int testTypeID)
        {
            float testTypeFees = 0;
            string testTypeDescription = "", testTypeTitle = "";

            if (TestTypeDataQueryies.FindTestType(testTypeID, ref testTypeTitle, ref testTypeDescription, ref testTypeFees))
            {
                return new clsTestType(testTypeID, testTypeTitle, testTypeDescription, testTypeFees);
            }
            return null;
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case _enMode.eUpdate:
                    {
                        if (_EditTestTypeInfo())
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
