using PersentationLayer.Forms.Applications.LocalDrivingLicenseApplication;
using PersentationLayer.Forms.Tests;
using PersentationLayer.Forms.Users;
using PersentationLayer.GlobalClasses;
using PersentationLayer.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Course_19_Project
{
    public partial class MainForm : Form
    {
        LogInForm _logIn;
        public MainForm(LogInForm logIn)
        {
            InitializeComponent();

            _logIn = logIn;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleForm frmPeople = new PeopleForm();

            frmPeople.MdiParent = this;

            frmPeople.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();

            usersForm.MdiParent = this;

            usersForm.Show();
        }
        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(clsGlobal.currentUser != null)
            {
                UserInfoForm userInfoForm = new UserInfoForm(clsGlobal.currentUser.UserID);
                userInfoForm.ShowDialog();
            }
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(clsGlobal.currentUser.UserID);

            changePasswordForm.ShowDialog();

        }

        private void signOuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.currentUser = null;
            _logIn.Show();
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsGlobal.currentUser = null;
            _logIn.Close();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageApplicationTypesForm manageApplicationTypesForm = new ManageApplicationTypesForm();

            manageApplicationTypesForm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesForm manageTestTypesForm = new ManageTestTypesForm();
            manageTestTypesForm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLocalDrivingLiceenseForm addLocalDrivingLiceenseForm = new AddLocalDrivingLiceenseForm();
            addLocalDrivingLiceenseForm.ShowDialog();
        }
    }
}
