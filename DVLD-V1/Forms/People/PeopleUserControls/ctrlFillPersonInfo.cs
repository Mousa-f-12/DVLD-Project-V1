using BusinessLayer;
using Guna.UI2.WinForms;
using PersentationLayer.Configurations;
using PersentationLayer.HelperClasses;
using PersentationLayer.Properties;
using System;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace Course_19_Project
{
    public partial class ctrlFillPersonInfo : UserControl
    {
        clsPerson _person;

        public ctrlFillPersonInfo()
        {
            InitializeComponent();
        }

        private void _LoadData()
        {
            cbCountry.DataSource = clsPerson.GetCountriesList();
            cbCountry.DisplayMember = "CountryName";
            cbCountry.ValueMember = "CountryID";

            dtDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        public void ShowPersonInfoOnScreen(clsPerson person)
        {
            _person = person;

            txtFirstName.Text       = person.FirstName;
            txtSecondName.Text      = person.SecondName;
            txtThirdName.Text       = person.ThirdName;
            txtLastName.Text        = person.LastName;
            txtEmail.Text           = person.Email;
            txtPhoneNumber.Text     = person.Phone;
            rtxtAddress.Text        = person.Address;
            txtNationalNumber.Text  = person.NationalNo;
            dtDateOfBirth.Value     = person.DateOfBirth.Date;
            cbCountry.SelectedValue = person.NationalityCountryID;

            if (person.Gender == 'M')
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            if (!string.IsNullOrWhiteSpace(person.ImagePath) && File.Exists(person.ImagePath))
                pbPersonalPhoto.ImageLocation = person.ImagePath;
        }

        public void LoadPersonInfo(int personID)
        {
            if (personID <= 0)
            {
                _person = new clsPerson();
                return;
            }
                
            if(clsPerson.IsPersonExists(personID))
            {
                _person = clsPerson.Find(personID);

                if (_person != null)
                {
                    ShowPersonInfoOnScreen(_person);
                    if (pbPersonalPhoto.ImageLocation != null)
                        lbRemoveImage.Enabled = true;
                }

                else
                {
                    MessageBox.Show("Person Not Found");
                }
            }
        }

        private bool ValidatePersonInfo()
        {
            if (string.IsNullOrWhiteSpace(rtxtAddress.Text))
                return false;

            if (rbFemale.Checked == false && rbMale.Checked == false)
                return false;

            if (cbCountry.SelectedIndex <= 0)
                return false;

            if (dtDateOfBirth.Value.Year > DateTime.Now.Year - 16)
                return false;

            return true;
        }

        private void ValidateTextBoxes(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox txt = (Guna2TextBox)sender;

            if (txt.Text == string.Empty)
            {
                e.Cancel = true;

                errorProvider1.SetError(txt, "This Field Is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, string.Empty);
            }

        }

        private void ValidateEmail(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (!txtEmail.Text.Contains("@") && txtEmail.Text != string.Empty)
            {
               e.Cancel = true;

               errorProvider1.SetError(txtEmail, "InValid Email");
            }

            else
            {
               e.Cancel = false;
               errorProvider1.SetError(txtEmail, string.Empty);
            }
        }

        private void ValidateNationalNumber(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(clsPerson.IsPersonExists(txtNationalNumber.Text))
            {
                e.Cancel = true;

                errorProvider1.SetError(txtNationalNumber, "This National Number Alrady Exists");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNationalNumber, string.Empty);
            }
        }

        private void ResetAllFields()
        {
            txtFirstName.Text = string.Empty;
            txtSecondName.Text = string.Empty;
            txtThirdName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            rtxtAddress.Text = string.Empty;
            txtNationalNumber.Text = string.Empty;
            dtDateOfBirth.Value = DateTime.Now.AddYears(-19);
            cbCountry.SelectedValue = -1;

            rbFemale.Checked = false;
            rbMale.Checked = false;
        }

        private void GetPersonInfo()
        {
            _person.FirstName = txtFirstName.Text;
            _person.SecondName = txtSecondName.Text;
            _person.ThirdName = txtThirdName.Text;
            _person.LastName = txtLastName.Text;
            _person.Email = txtEmail.Text;
            _person.Phone = txtPhoneNumber.Text;
            _person.Address = rtxtAddress.Text;
            _person.NationalNo = txtNationalNumber.Text;
            _person.DateOfBirth = dtDateOfBirth.Value;
            _person.NationalityCountryID = Convert.ToInt32(cbCountry.SelectedValue);
            if (rbFemale.Checked == true)
                _person.Gender = 'F';
            if (rbMale.Checked == true)
                _person.Gender = 'M';
        }

        private void ctrlFillPersonInfo_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        public event Action<int> OnSaveCompleted;

        private void rbDefaultImageChecked(object sender, EventArgs e)
        {
            if (pbPersonalPhoto.ImageLocation == null)
            {
                if (rbMale.Checked)
                {
                    pbPersonalPhoto.Image = Resources.office_man;

                }

                if (rbFemale.Checked)
                {
                    pbPersonalPhoto.Image = Resources.Woman;

                }   
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if(!ValidatePersonInfo())
            {
                MessageBox.Show("Enter Valid Data");
                
                return;
            }

            GetPersonInfo();
            if(!_HandlePeopleImagesInFolder())
            return;

           if (_person.Save())
            {
                MessageBox.Show("...Saved Successfuly...");
                OnSaveCompleted?.Invoke(_person.PersonID);
            }

           else
            {
                MessageBox.Show("Error...Not Saved...");
            }

        }

        private void btnResetAllFields_Click(object sender, EventArgs e)
        {
            ResetAllFields();
        }

        private bool _HandlePeopleImagesInFolder()
        {

            if (pbPersonalPhoto.ImageLocation != _person.ImagePath)
            {
                if(_person.ImagePath != null && _person.ImagePath != "")
                {
                    try
                    {
                        File.Delete(_person.ImagePath);
                    }

                    catch(IOException ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                    
                }
            }

            if (pbPersonalPhoto.ImageLocation == _person.ImagePath)
                return true;
            
            if(pbPersonalPhoto.ImageLocation != null)
            {
                try
                {
                    string sourceFile = pbPersonalPhoto.ImageLocation;

                    if (Utils.CopyImageToPeopleImagesFolder(ref sourceFile))
                    {
                        _person.ImagePath = sourceFile;
                        return true;
                    }
                    
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;

        }

        private void lbSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Select Person Image";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = fileDialog.FileName;

                pbPersonalPhoto.ImageLocation = selectedFile;

                lbRemoveImage.Enabled = true;
            }
        }

        private void lbRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            lbRemoveImage.Enabled = false;

            pbPersonalPhoto.ImageLocation = null;

            if (rbMale.Checked)
            {
                pbPersonalPhoto.Image = Resources.office_man;
            }
                
            else if (rbFemale.Checked)
            {
                pbPersonalPhoto.Image = Resources.Woman;
            }

            else
            {
                pbPersonalPhoto.Image = Resources.office_man;
            }
        }
    }
}
 