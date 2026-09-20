using System;
using BusinessLayer;
using System.Windows.Forms;

namespace Course_19_Project.Forms
{
    public partial class PersonInfoForm : Form
    {

        private int _personID;

        public PersonInfoForm()
        {
            InitializeComponent();
        }

        public PersonInfoForm(int personID)
        {
            InitializeComponent();

            _personID  = personID;
        }

        private void PrepareFormDefaultValues()
        {

        }

        private void _LoadPersonInfo()
        {
            PrepareFormDefaultValues();
            ctrlPersonCard1.LoadPersonInfo(_personID);


        }

        private void PersonInfoUpdated()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {
            _LoadPersonInfo();

            ctrlPersonCard1.OnPersonInfoUpdated += PersonInfoUpdated;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
