using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer.Person.PersonCommands
{
    public static class PersonDataCommands
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionDVLD"].ConnectionString;

        static public int InsertPerson(string nationalNo,
           string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, char gender, string address,
            string phone, string email, int nationalityCountryID, string imagePath)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"Insert Into People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
            Values(@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)
            select SCOPE_IDENTITY();";

            int newID = -1;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

            if(gender == 'M')
                command.Parameters.AddWithValue("@Gender", 0);
            if (gender == 'F')
                command.Parameters.AddWithValue("@Gender", 1);

            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

            if (string.IsNullOrWhiteSpace(email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", email);

            if (string.IsNullOrWhiteSpace(thirdName))
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", thirdName);

            if (string.IsNullOrWhiteSpace(imagePath))
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", imagePath);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null) int.TryParse(result.ToString(), out newID);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return newID;
        }


        static public bool UpdatePerson(int personID, string nationalNo,
           string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, char gender, string address,
            string phone, string email, int nationalityCountryID, string imagePath)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"
                            UPDATE People

                               SET [NationalNo] = @NationalNo,
                                  [FirstName] = @FirstName,
                                  [SecondName] = @SecondName,
                                  [ThirdName] = @ThirdName,
                                  [LastName] = @LastName,
                                  [DateOfBirth] = @DateOfBirth,
                                  [Gender] = @Gender,
                                  [Address] = @Address,
                                  [Phone] = @Phone,
                                  [Email] = @Email,
                                  [NationalityCountryID] = @NationalityCountryID,
                                  [ImagePath] = @ImagePath

                             WHERE PersonID = @PersonID;";

            int rowsAffected = 0;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);
            command.Parameters.AddWithValue("@NationalNo", nationalNo);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

            if(gender == 'M')
                command.Parameters.AddWithValue("@Gender", 0);
            else
                command.Parameters.AddWithValue("@Gender", 1);

            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@NationalityCountryID", nationalityCountryID);

            if (string.IsNullOrWhiteSpace(email))
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@Email", email);
                
            if (string.IsNullOrWhiteSpace(thirdName))
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ThirdName", thirdName);

            if (string.IsNullOrWhiteSpace(imagePath))
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            else
                command.Parameters.AddWithValue("@ImagePath", imagePath);


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        static public bool DeletePerson(int personID)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"Delete From People Where PersonID = @PersonID";

            int rowAffected = 0;

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();

                rowAffected = command.ExecuteNonQuery();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            finally
            {
                connection.Close();
            }

            return (rowAffected > 0);
        }
    }
}
