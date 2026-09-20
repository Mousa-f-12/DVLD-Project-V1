using BusinessLayer.User;
using PersentationLayer.GlobalClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_19_Project
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }


        //private void _HandleLogInInfo(ref string userName, ref string password)
        //{
        //    string currentDirectory = Directory.GetCurrentDirectory();

        //    string authFileSource = $@"{currentDirectory}\Auth";

        //    string delimiter = "/##/";

        //    string logInLine = userName + delimiter + password;
            
        //    if(!File.Exists(authFileSource))
        //    {
        //        using(StreamWriter writer = new StreamWriter(authFileSource, append : true))
        //        {
        //            writer.WriteLine(logInLine);
        //        }
        //        return;
        //    }
        //    else
        //    {
        //        using(StreamReader reader = new StreamReader(authFileSource))
        //        {
        //            string line;

        //            while((line = reader.ReadLine()) != null)
        //            {
        //                int index = line.IndexOf(delimiter);

        //                userName = line.Substring(0, index);

        //                password = line.Substring(index + 4);
        //            }

        //            txtUserName.Text = userName;
        //            txtPassword.Text = password;
        //        }
        //    }



        //}

        private void LogInForm_Load(object sender, EventArgs e)
        {
            string userName = txtUserName.Text, password = txtPassword.Text;

            
            chkRememberMe.Checked = clsGlobal.GetStoredCredential(ref userName, ref password);

            if (chkRememberMe.Checked)
            {
                txtUserName.Text = userName;

                txtPassword.Text = password;
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName =  txtUserName.Text, password = txtPassword.Text;

            clsUser user = clsUser.FindUserByUserNameAndPassword(userName, password);

            if( user != null)
            {
                if (chkRememberMe.Checked)
                    clsGlobal.RememberUserNameAndPassword(userName, password);

                else
                    clsGlobal.RememberUserNameAndPassword("", "");

                if (!user.IsActive)
                {
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                clsGlobal.currentUser = user;
                this.Hide();
                MainForm mainForm = new MainForm(this);
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("User Name Or Password In Valid");
            }
        }
    }
}
