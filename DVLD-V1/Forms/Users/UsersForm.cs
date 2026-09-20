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
    public partial class UsersForm : Form
    {
        DataTable _usersList;
        DataView _usersView;

        enum _enFilterOption
        {
            None,
            UserID,
            UserName,
            PersonID,
            FullName,
            IsActive,
        }

        public UsersForm()
        {
            InitializeComponent();
        }

        private void _LoadUsersData()
        {
            _usersList = clsUser.GetUsersList();
            _usersView = _usersList.DefaultView;
        }

        private void _UpdateRecordsCount()
        {
            lbRecordsCount.Text = _usersView.Count.ToString();
        }

        private void RefreshUsersList()
        {
            _LoadUsersData();
            dgvUsersList.DataSource = _usersView;
            _UpdateRecordsCount();
        }
        
        private void _LoadData()
        {
            RefreshUsersList();

        }

        private string _GetColmnName()
        {
            return ((_enFilterOption)cbFilterOption.SelectedIndex).ToString();
        }

        private void txtFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string columnName = _GetColmnName();

            if (columnName == "PersonID" || columnName == "UserID")
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\'')
                {
                    e.Handled = true;
                }
            }
        }

        private void _ApplyFilter()
        {
            if (string.IsNullOrWhiteSpace(txtFilterSearch.Text))
            {
                _usersView.RowFilter = string.Empty;
                return;
            }
                
            string columnName = _GetColmnName(), filterValue = txtFilterSearch.Text;

            if(columnName == "PersonID" || columnName == "UserID")
            {
                int ID = Convert.ToInt32(filterValue);

                _usersView.RowFilter = $"{columnName} = {ID}";
                lbRecordsCount.Text = _usersView.Count.ToString();
                return;
            }

            _usersView.RowFilter = $"{columnName} = {filterValue}";
            lbRecordsCount.Text = _usersView.Count.ToString();

        }

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterOption.SelectedItem.ToString() != "None")
            {
                cbFilterStatus.Visible = false;
                txtFilterSearch.Visible = true;
                txtFilterSearch.Focus();

                if (cbFilterOption.SelectedItem.ToString() == "Is Active")
                {
                    txtFilterSearch.Visible = false;
                    cbFilterStatus.Visible = true;
                }
            }
            else
            {
                txtFilterSearch.Text = "";
                txtFilterSearch.Visible = false;


            }


            lbRecordsCount.Text = _usersView.Count.ToString();
        }

        private void cbFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = _GetColmnName();

            if (cbFilterStatus.SelectedItem == null)
                return;

            if (columnName == "IsActive")
            {
                switch(cbFilterStatus.SelectedIndex)

                { 
                    case 1:
                    {
                            _usersView.RowFilter = $"{columnName} = 0";
                            break;
                    }

                    case 2:
                    {
                            _usersView.RowFilter = $"{columnName} = 1";
                            break;
                    }
                    default:
                    {
                            _usersView.RowFilter = string.Empty;
                            break;
                    }
                }
            }
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm addEditUserForm = new AddEditUserForm(-1);

            addEditUserForm.ShowDialog();
        }

        private void csmShowDetails_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvUsersList.SelectedCells[0].Value);
            
            UserInfoForm userInfoForm = new UserInfoForm(userID);

            userInfoForm.ShowDialog();
        }

        private void cmAddNewUser_Click(object sender, EventArgs e)
        {
            AddEditUserForm addEditUserForm = new AddEditUserForm(-1);

            addEditUserForm.ShowDialog();
        }

        private void cmEditUser_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvUsersList.SelectedCells[0].Value);

            AddEditUserForm addEditUserForm = new AddEditUserForm(userID);

            addEditUserForm.ShowDialog();

            if(addEditUserForm.DialogResult == DialogResult.OK)
            {
                RefreshUsersList();
            }
        }

        private void cmDeleteUser_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(dgvUsersList.SelectedCells[0].Value);

            if(MessageBox.Show("Are you sure\nWant to delete this user?", "Confirmation message",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                clsUser.DeleteUser(userID);

                RefreshUsersList();
            }
        }


    }
}
