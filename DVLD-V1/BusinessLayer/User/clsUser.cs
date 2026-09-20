using System;
using System.Data;
using DataAccessLayer.Users.UserQueries;
using DataAccessLayer.Users.UserCommands;

namespace BusinessLayer.User
{
    public class clsUser
    {
        public int UserID { set; get; }
        public int PersonID { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
        private enum _enMode { eAddNew, eUpdate}

        private _enMode _Mode = _enMode.eAddNew;

        public clsUser()
        {
            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "Defualt Value";
            this.Password = "";
            this.IsActive = default;
            this._Mode = _enMode.eAddNew;
        }

        private clsUser(int userID, int personID, string userName, string password, bool isActive)
        {
            this.UserID = userID;
            this.PersonID = personID;
            this.UserName = userName;
            this.Password = password;
            this.IsActive = isActive;
            this._Mode = _enMode.eUpdate;
        }

        private bool _AddNewUser()
        {
            this.UserID = UserDataCommands.InsertUser(this.PersonID, this.UserName, this.Password, this.IsActive);
            return (this.UserID != -1);
        }

        private bool _UpdateUserInfo()
        {
            return UserDataCommands.UpdateUser(this.UserID, this.PersonID, this.UserName, this.Password, this.IsActive);
        }

        public static bool DeleteUser(int userID)
        {
            return UserDataCommands.DeleteUser(userID);
        }

        public static DataTable GetUsersList()
        {
            return UserDataQueries.GetAllUsers();
        }

        public static clsUser Find(int userID)
        {
            int personID = -1;
            string userName = "", password = "";
            bool isActive = default;

           if(UserDataQueries.FindUserByUserID(userID, ref personID, ref userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            return null;
        }

        public static clsUser Find(string userName)
        {
            int personID = -1, userID = -1;
            string password = "";
            bool isActive = default;

            if (UserDataQueries.FindUserByUserName(ref userID, ref personID, userName, ref password, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            return null;
        }

        public static bool IsUserExists(int userID)
        {
            return UserDataQueries.IsUserExists(userID);
        }

        public static bool IsUserExistsByPersonID(int personID)
        {
            return UserDataQueries.IsUserExistsByPersonID(personID);
        }

        public static clsUser FindUserByUserNameAndPassword(string userName, string password)
        {
            int personID = -1, userID = -1;
            bool isActive = default;

            if (UserDataQueries.FindUserByUserNameAndPassword(userName,  password, ref personID, ref userID, ref isActive))
            {
                return new clsUser(userID, personID, userName, password, isActive);
            }
            return null;
            
        }

        public static bool IsUserExists(string userName)
        {
            return UserDataQueries.IsUserExists(userName);
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case _enMode.eAddNew:
                    {
                        if(_AddNewUser())
                        {
                            _Mode = _enMode.eUpdate;
                            return true;
                        }
                        else
                            return false;
                    }
                case _enMode.eUpdate:
                    {
                        if(_UpdateUserInfo())
                        {
                            return true;
                        }
                        else
                            return false;
                    }
            }

            return true;
        }

    }
}
