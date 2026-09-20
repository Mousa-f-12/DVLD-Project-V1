using BusinessLayer.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.GlobalClasses
{
    internal class clsGlobal
    {
        public static clsUser currentUser;

        private static string _currentDirectory = Directory.GetCurrentDirectory();

        private static string _authFileSource = $@"{_currentDirectory}\Auth";

        private static string _delimiter = "/##/";

        public static bool RememberUserNameAndPassword(string userName, string password)
        {
            try
            {
                if (userName == "" && File.Exists(_authFileSource))
                {
                    File.Delete(_authFileSource);
                    return true;
                }

                string logInLine = userName + _delimiter + password;


                using (StreamWriter writer = new StreamWriter(_authFileSource, append: true))
                {
                    writer.WriteLine(logInLine);
                    return true;
                }  
            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }



        }

        public static bool GetStoredCredential(ref string userName, ref string password)
        {
            try
            {
                if(File.Exists(_authFileSource))
                {
                    using (StreamReader reader = new StreamReader(_authFileSource))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(new string[] { _delimiter }, StringSplitOptions.None);

                            userName = parts[0];
                            password = parts[1];                           
                        }
                        return true;
                    }

                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

    }
}
