using System;
using BusinessLayer;
using System.Windows.Forms;
using Course_19_Project.Forms;
using System.IO;

namespace Course_19_Project.UesrControls
{
    public partial class ctrlPersonCard : UserControl
    {

        clsPerson _person;

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        private void _FillPersonCardWithValues(clsPerson person)
        {
            lbPersonID.Text = person.PersonID.ToString();
            lbName.Text = $"{person.FirstName} {person.SecondName} {person.ThirdName} {person.LastName}";
            lbDate.Text = person.DateOfBirth.ToString("yyyy/mm/dd");
            lbEmail.Text = person.Email;
            lbGender.Text = person.Gender.ToString();
            lbNationalNumber.Text = person.NationalNo;
            lbPhone.Text = person.Phone;
            lbAddress.Text = person.Address;
            lbCountry.Text = person.Country;
            if (!string.IsNullOrWhiteSpace(person.ImagePath) && File.Exists(person.ImagePath))
                pbPersonalPhoto.Load(person.ImagePath);
        }

        public void LoadPersonInfo(int personID)
        {
            if (personID <= 0)
                return;

            _person = clsPerson.Find(personID);

            if(_person != null)
            {
                _FillPersonCardWithValues(_person);
            }
            else
            {
                MessageBox.Show("Person Not Found");
            }

        }

        public event Action OnPersonInfoUpdated;

        private void lbEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm addEditPersonForm = new AddEditPersonForm(_person.PersonID);
            addEditPersonForm.ShowDialog();

            if(addEditPersonForm.DialogResult == DialogResult.OK)
            {
                OnPersonInfoUpdated?.Invoke();
            }
        }
    }
}
