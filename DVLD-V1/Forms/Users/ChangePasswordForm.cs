using BusinessLayer.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.Forms.Users
{
    public partial class ChangePasswordForm : Form
    {
        private clsUser _user;
        public ChangePasswordForm(int userID)
        {
            InitializeComponent();

            ctrlUserCardInfo1.LoadUserInfo(userID);

            _user = ctrlUserCardInfo1.user;
        }

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtCurrentPassword.Text != _user.Password)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCurrentPassword, "Password Dose't Match");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCurrentPassword, "");

            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if(txtNewPassword.Text != txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Dose't Match");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            _user.Password = txtNewPassword.Text;

            if(_user.Save())
            {
                MessageBox.Show("Password Changed Successfuly");
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
