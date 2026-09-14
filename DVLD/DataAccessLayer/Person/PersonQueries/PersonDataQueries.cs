
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System;



namespace DataAccessLayer.Person.PersonQueries
{
    public static class PersonDataQueries
    {

        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        public static bool GetPersonInfoByID(int personID, ref string nationalNo,
           ref string firstName, ref string secondName, ref string thirdName,
            ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address,
            ref string phone, ref string email, ref string country, ref int nationalityCountryID, ref string imagePath)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"
           SELECT [NationalNo],
                  [FirstName],
                  [SecondName],
                  [ThirdName],
                  [LastName],
                  [DateOfBirth],
                  [Gender],
                  [Address],
                  [Phone],
                  [Email],
                  Countries.CountryName As Country,
                  NationalityCountryID,
                  [ImagePath]
FROM   [DVLD].[dbo].[People]
       INNER JOIN
       Countries
       ON People.NationalityCountryID = Countries.CountryID

        where PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nationalNo = (string)reader["NationalNo"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];

                    if (System.DBNull.Value != reader["ThirdName"])
                        thirdName = (string)reader["ThirdName"];
                    else
                        thirdName = "";

                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (byte)reader["Gender"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];

                    if (System.DBNull.Value != reader["Email"])
                        email = (string)reader["Email"];
                    else
                        email = "";

                    country = (string)reader["Country"];

                    nationalityCountryID = (int)reader["NationalityCountryID"];

                    if (System.DBNull.Value != reader["imagePath"])
                        imagePath = (string)reader["imagePath"];
                    else
                        imagePath = "";

                    isFound = true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(ref int personID, string nationalNo,
           ref string firstName, ref string secondName, ref string thirdName,
            ref string lastName, ref DateTime dateOfBirth, ref byte gender, ref string address,
            ref string phone, ref string email, ref string country, ref int nationalityCountryID, ref string imagePath)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            bool isFound = false;

            string query = @"
           SELECT [PersonID],
                  [FirstName],
                  [SecondName],
                  [ThirdName],
                  [LastName],
                  [DateOfBirth],
                  [Gender],
                  [Address],
                  [Phone],
                  [Email],
                  Countries.CountryName As Country,
                  NationalityCountryID,
                  [ImagePath]
FROM   [DVLD].[dbo].[People]
       INNER JOIN
       Countries
       ON People.NationalityCountryID = Countries.CountryID

        where NationalNo = @NationalNo;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    personID = (int)reader["PersonID"];
                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];

                    if (System.DBNull.Value != reader["ThirdName"])
                        thirdName = (string)reader["ThirdName"];
                    else
                        thirdName = "";

                    lastName = (string)reader["LastName"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (byte)reader["Gender"];
                    address = (string)reader["Address"];
                    phone = (string)reader["Phone"];

                    if (System.DBNull.Value != reader["Email"])
                        email = (string)reader["Email"];
                    else
                        email = "";

                    country = (string)reader["Country"];

                    nationalityCountryID = (int)reader["NationalityCountryID"];

                    if (System.DBNull.Value != reader["imagePath"])
                        imagePath = (string)reader["imagePath"];
                    else
                        imagePath = "";
                    
                    isFound = true;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsExistsByPersonID(int personID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Select Top 1 1 From People Where PersonID = @PersonID";

            bool isFound = false;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                isFound = (result != null);

            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsExistsByNationalNo(string nationalNo)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "Select Top 1 1 From People Where NationalNo = @NationalNo";

            bool isFound = false;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                isFound = (result != null);

            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable CountriesTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"Select * From Countries";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if(dataReader.HasRows)
                {
                    CountriesTable.Load(dataReader);
                }

                dataReader.Close();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return CountriesTable;
        }

        public static DataTable GetAllPeople()
        {
            DataTable peopleTable = new DataTable();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT  PersonID,
                  [NationalNo],
                  [FirstName],
                  [SecondName],
                  [ThirdName],
                  [LastName],
                  [DateOfBirth],
                  CASE WHEN Gender = 0 THEN 'M' WHEN Gender = 1 THEN 'F' ELSE 'Unknown' END AS Gender,
                  [Address],
                  [Phone],
                  [Email],
                  Countries.CountryName As Country
                  FROM   [DVLD].[dbo].[People]
       INNER JOIN
       Countries
       ON People.NationalityCountryID = Countries.CountryID;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    peopleTable.Load(dataReader);
                }
                dataReader.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine($"{Ex.Message}");
            }

            finally
            {
                connection.Close();
            }

            return peopleTable;
        }
    }
}
