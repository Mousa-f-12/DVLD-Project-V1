using BusinessLayer;
using Course_19_Project;
using System;
using System.Text;
using System.Windows.Forms;

namespace PersentationLayer.Forms.People.PeopleUserControls
{
    public partial class ctrlFindPerson : UserControl
    {

        enum enFindOptoin { ePersonID = 1, eNationalNo = 2 }

        private enFindOptoin _Option;

        private int _personID;
        public int PersonID {
            get
            {
                return _personID;
            }}

        public ctrlFindPerson()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int personID)
        {
            ctrlPersonCard1.LoadPersonInfo(personID);
            _personID = ctrlPersonCard1.PersonID;
            OnFindClick.Invoke(PersonID);
        }

        private void cbFindPersonOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFindPersonOption.SelectedIndex > 0)
            {
                _Option = (enFindOptoin)cbFindPersonOption.SelectedIndex;
                ChangePlaceholderText(_Option);
            }


            if (cbFindPersonOption.SelectedItem.ToString() != "None")
            {
                txtFindPerson.Focus();
                txtFindPerson.Enabled = true;
            }
            else
            {
                txtFindPerson.Enabled = false;
            }
        }

        private void ChangePlaceholderText(enFindOptoin optoin)
        {
            if (optoin == enFindOptoin.ePersonID)
            {
                txtFindPerson.PlaceholderText = "Find By Person ID";
            }
            else
            {
                txtFindPerson.PlaceholderText = "Find By National Number";
            }
        }

        private void txtFindPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Option == enFindOptoin.ePersonID)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if (e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private void HandleFindOption(enFindOptoin optoin)
        {
            switch(optoin)
            {
                case enFindOptoin.ePersonID:
                {
                    int perosnID = Convert.ToInt32(txtFindPerson.Text);
                    ctrlPersonCard1.LoadPersonInfo(perosnID);
                    break;
                }
                case enFindOptoin.eNationalNo:
                {
                    string nationalno = (txtFindPerson.Text);
                    ctrlPersonCard1.LoadPersonInfo(nationalno);
                    break;
                }
            }

            _personID = ctrlPersonCard1.PersonID;
        }


        public Action<int> OnFindClick;

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            HandleFindOption(_Option);
            OnFindClick.Invoke(PersonID);
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonForm addEditPersonForm = new AddEditPersonForm(-1);
            addEditPersonForm.ShowDialog();
        }

    }
}
