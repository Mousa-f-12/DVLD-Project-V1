using BusinessLayer;
using System;
using System.Windows.Forms;

namespace Course_19_Project
{
    public partial class AddEditPersonForm : Form
    {

        int _personID;

        private enum _enMode { eAddNewMode, eUpdateMode }

        private _enMode Mode = _enMode.eAddNewMode;

        public AddEditPersonForm(int personID)
        {
            InitializeComponent();
            
            if(personID > 0 )
            {
                _personID = personID;
                Mode = _enMode.eUpdateMode;
            }
        }

        private void _FormMode()
        {

            if(Mode == _enMode.eAddNewMode)
            {
                lbAddEditForm.Text = "Add New Person";
            }
            else
            {
                lbAddEditForm.Text = "Edit Person Info";
                lbPersonID.Text = _personID.ToString();
            }

            

            ctrlFillPersonInfo1.LoadPersonInfo(_personID);
        }

        private void GetPersonID(int personID)
        {
            _personID = personID;
            lbPersonID.Text = _personID.ToString();

            this.DialogResult = DialogResult.OK;
        }

        private void AddEditPersonForm_Load(object sender, EventArgs e)
        {
            ctrlFillPersonInfo1.OnSaveCompleted += GetPersonID;
            _FormMode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_personID == -1)
                this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
