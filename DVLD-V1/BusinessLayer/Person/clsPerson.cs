using DataAccessLayer.Person.PersonQueries;
using DataAccessLayer.Person.PersonCommands;
using System;
using System.Data;
using System.Net;
using System.Security.Cryptography;
using System.Security.Policy;
namespace BusinessLayer
{
    public class clsPerson
    {
        public int PersonID { get; set; }

        public string NationalNo { set; get; }

        public string FirstName { set; get; }

        public string SecondName { set; get; }

        public string ThirdName { set; get; }

        public string LastName { set; get; }

        public string FullName { get { return $"{FirstName} {SecondName} {ThirdName} {LastName}"; } }

        public DateTime DateOfBirth { set; get; }

        public char Gender { set; get; }

        public string Address { set; get; }

        public string Phone { set; get; }

        public string Email { set; get; }

        public int NationalityCountryID { set; get; }

        public string  Country { set; get; }

        public string ImagePath { set; get; }

        private enum _enMode { eAddNewMode, eUpdateMode }

        private _enMode Mode;

        private enum _enGenderType { eMale, eFemale}

        private clsPerson(int personID, string nationalNo,
            string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, byte gender, string address, string phone, string email, string country, int nationalityCountryID, string imagePath)
        {
            this.PersonID = personID;
            this.NationalNo = nationalNo;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;

            if (gender == 0)
                this.Gender = 'M';
            else
                this.Gender = 'F';

            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Country = country;
            this.ImagePath = imagePath;
            this.NationalityCountryID = nationalityCountryID;
            this.Mode = _enMode.eUpdateMode;
        }

        public clsPerson()
        {
            this.PersonID = -1;
            this.NationalNo = "N-1";
            this.FirstName = "Jone";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "Doe";
            this.DateOfBirth = DateTime.Now.Date;
            this.Gender = 'F';
            this.Address = "Amman";
            this.Phone = "0000000000";
            this.Email = "Mousa@Gmail.com";
            this.Country = "";
            this.ImagePath = "";
            this.Mode = _enMode.eAddNewMode;
        }

        public static clsPerson Find(int id)
        {
            string nationalNo = "", firstName = "", secondName = "", thirdName = "", lastName = "",  address = "",  phone = "",  email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            byte gender = 0;
            string country = "";
            int nationalityCountryID = -1;

            if (PersonDataQueries.GetPersonInfoByID(id, ref nationalNo,
            ref firstName, ref secondName, ref thirdName,
            ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref country,ref nationalityCountryID, ref imagePath))
            {
                return new clsPerson(id, nationalNo,
            firstName, secondName, thirdName,
            lastName, dateOfBirth, gender, address, phone, email, country, nationalityCountryID, imagePath);
            }

            return null;
        }

        public static clsPerson Find(string nationalNo)
        {
            string firstName = "", secondName = "", thirdName = "", lastName = "", address = "", phone = "", email = "", imagePath = "";
            DateTime dateOfBirth = DateTime.Now;
            byte gender = 0;
            string country = "";
            int id = -1, nationalityCountryID = -1;

            if (PersonDataQueries.GetPersonInfoByNationalNo(ref id, nationalNo,
            ref firstName, ref secondName, ref thirdName,
            ref lastName, ref dateOfBirth, ref gender, ref address, ref phone, ref email, ref country, ref nationalityCountryID, ref imagePath))
            {
            return new clsPerson(id, nationalNo,
                                firstName, secondName, thirdName,
                                lastName, dateOfBirth, gender, address, phone, email, country, nationalityCountryID, imagePath);
            } 

            return null;
        }

        public static bool Delete(int personID)
        {
            return PersonDataCommands.DeletePerson(personID);
        }

        private bool _Edit()
        {
            return PersonDataCommands.UpdatePerson(this.PersonID,  this.NationalNo,
           this.FirstName, this.SecondName, this.ThirdName,
           this.LastName, this.DateOfBirth, this.Gender, this.Address,
           this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        private bool _Add()
        {
            this.PersonID = PersonDataCommands.InsertPerson(this.NationalNo,
            this.FirstName, this.SecondName, this.ThirdName,
            this.LastName, this.DateOfBirth, this.Gender, this.Address,
            this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
            return (this.PersonID != 1);
        }

        public bool Save()
        {
            switch(Mode)
            {
                case _enMode.eAddNewMode:
                    {
                        if(_Add())
                        {
                            this.Mode = _enMode.eUpdateMode;
                            return true;
                        }
                        return false;
                    }
                case _enMode.eUpdateMode:
                    {
                        return _Edit();
                    }
            }

            return false;
        }

        public static bool IsPersonExists(int personID)
        {
            return PersonDataQueries.IsExistsByPersonID(personID);
        }

        public static bool IsPersonExists(string nationalNo)
        {
            return PersonDataQueries.IsExistsByNationalNo(nationalNo);
        }

        public static DataTable GetPeopleList()
        {
            return PersonDataQueries.GetAllPeople();
        }

        public static DataTable GetCountriesList()
        {
            return PersonDataQueries.GetAllCountries();
        }

    }
}
