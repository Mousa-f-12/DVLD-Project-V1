using BusinessLayer.User;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace PersentationLayer.Forms.Users
{
    public partial class AddEditUserForm : Form
    {

        private enum _enFormMode { eAddNew, eUpdate }

        private _enFormMode _Mode = _enFormMode.eAddNew;

        private int _userID;
        private clsUser _user;
        private int _personID;
        public AddEditUserForm(int userID)
        {
            InitializeComponent();

            ctrlFindPerson1.OnFindClick += _GetPersonID;

            _Mode = userID > 0 ? _enFormMode.eUpdate : _enFormMode.eAddNew;
            _userID = userID;
        }

        private void DisplayPerosnInfoOnScreen(int personID)
        {
            ctrlFindPerson1.LoadPersonInfo(personID);
        }

        private void DisplayUserInfoOnScreen(clsUser user)
        {
            txtUserID.Text = user.UserID.ToString();
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            txtComfirmPassword.Enabled = false;
            cbStatus.SelectedIndex = user.IsActive ? 0 : 1;
            DisplayPerosnInfoOnScreen(user.PersonID);   
        }

        private void GetUserInfo()
        {
            _user.UserName = txtUserName.Text;
            _user.Password = txtPassword.Text;
            _user.IsActive = cbStatus.SelectedIndex == 0 ? true : false;
        }

        private void _GetPersonID(int personID)
        {
            _personID = personID;
        }

        private void _LoadData()
        {
            if(_Mode == _enFormMode.eAddNew)
            {
                this.Text = "Add New User";
                lbFormMode.Text = "Add New User";
                _user = new clsUser();
                return;
            }

            this.Text = "Edit User Info";
            lbFormMode.Text = "Edit User Info";

            if(clsUser.IsUserExists(_userID))
            {
                _user = clsUser.Find(_userID);

                if (_user != null)
                {
                    DisplayUserInfoOnScreen(_user);
                    return;
                }
            }
            MessageBox.Show("User Not Found");
        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnNextTap_Click(object sender, EventArgs e)
        {
            tcTakeUserInfo.SelectedTab = tpUserInfo;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcTakeUserInfo.SelectedTab = tpPersonInfo;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            GetUserInfo();

            if(clsUser.IsUserExistsByPersonID(_user.PersonID) && (_user.PersonID != _personID))
            {
                MessageBox.Show("This Person already user");
                return;
            }
            if(_user.Save())
            {
                MessageBox.Show("Saved Successfuly...");
                txtUserID.Text = _user.UserID.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Something Went Wrong");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtComfirmPassword.Enabled == false)
            {
                txtComfirmPassword.Enabled = true;
            }
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Are you Sure ?", "Stop Editing", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();
        }

        private void ValidateUserName(object sender, CancelEventArgs e)
        {
            string userName = txtUserName.Text;

            if (_Mode == _enFormMode.eUpdate && userName == _user.UserName)
                return;

            if (clsUser.IsUserExists(userName))
            {
                e.Cancel = true;
                epUserErorr.SetError(txtUserName, "User Name Already Exists Try Another One");
            }
            else
            {
                e.Cancel = false;
                epUserErorr.SetError(txtUserName,"");
            }
        }

        private void ValidateConfirmPassword(object sender, CancelEventArgs e)
        {
            string password = txtPassword.Text;
            string comfirmPassword = txtComfirmPassword.Text;


            if (comfirmPassword != password)
            {
                e.Cancel = true;
                epUserErorr.SetError(txtComfirmPassword, "Password Not Match");
            }
            else
            {
                e.Cancel = false;
                epUserErorr.SetError(txtComfirmPassword, "");
            }
        }
    }
}
