using PersentationLayer.Configurations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.HelperClasses
{
    internal class Utils
    {

        public static bool CreateImagesFolderIfNotExists(string folderPath)
        {
            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                return false;
            }
            return true;
        }

        public static string CreateNewGuid()
        {
            return Guid.NewGuid().ToString() ;
        }

        public static string ReplaceFileNameWithGuid(string sourceFile)
        {
            FileInfo fi = new FileInfo(sourceFile);

            string exten = fi.Extension;

            string newFileName = CreateNewGuid() + exten;

            return newFileName;
        }

        public static bool CopyImageToPeopleImagesFolder( ref string sourceFile)
        { 
            if (!CreateImagesFolderIfNotExists(AppSettings.DefaultPersonalPhotos))
            {
                return false;
            }

            string DestinationFile = AppSettings.DefaultPersonalPhotos + ReplaceFileNameWithGuid(sourceFile);

            try
            {
                File.Copy(sourceFile, DestinationFile);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            sourceFile = DestinationFile;

            return true;

        }



    }
}
