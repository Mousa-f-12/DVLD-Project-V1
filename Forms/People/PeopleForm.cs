using Course_19_Project.Forms;
using System;
using System.Data;
using BusinessLayer;

using System.Windows.Forms;

namespace Course_19_Project
{
    public partial class PeopleForm : Form
    {

        DataTable peopleTable;
        DataView peopleView;

        private enum _enFilterOption
        {
            None,
            PersonID,
            NationalNo,
            FirstName,
            SecondName,
            ThirdName,
            LastName,
            Country,
            Gender,
            Phone,
            Email,
        }

        public PeopleForm()
        {
            InitializeComponent();
        }

        private void RefreshPeopleList()
        {
            
            peopleTable = BusinessLayer.clsPerson.GetPeopleList();
            peopleView = peopleTable.DefaultView;
            dgvPeopleList.DataSource = peopleView;
            lbRecordsCount.Text = peopleView.Count.ToString();
        }

        private void _LoadData()
        {
            RefreshPeopleList();
        }

        private void PeopleForm_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void txtFilterSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            string columnName = _ColumnNameFilter();

            if (columnName == _enFilterOption.PersonID.ToString())
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }

            if(e.KeyChar == '\'')
            {
                e.Handled = true;
            }
        }

        private string _ColumnNameFilter()
        {
            if (cbFilterOption.SelectedIndex <= 0)
                return string.Empty;

            return ((_enFilterOption)cbFilterOption.SelectedIndex).ToString();
        }

        private void _ApplyFilter()
        {
            string columnName = _ColumnNameFilter();
            string filterValue = txtFilterSearch.Text.Trim();

           if(string.IsNullOrEmpty(columnName) || string.IsNullOrEmpty(filterValue))
            {
                peopleView.RowFilter = string.Empty;
                return;
            }
            
           if (columnName == "PersonID" && !string.IsNullOrEmpty(filterValue))
            {
                int personID = int.Parse(filterValue);
                peopleView.RowFilter = $"{columnName} = {personID}";
                lbRecordsCount.Text = peopleView.Count.ToString();
            }
            else
            {
                peopleView.RowFilter = $"{columnName} Like '{filterValue}%'";
            }

                lbRecordsCount.Text = peopleView.Count.ToString() ;
        }

        private void csmShowDetails_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);

            PersonInfoForm personInfoForm = new PersonInfoForm(PersonID);
            personInfoForm.ShowDialog();
            if (personInfoForm.DialogResult == DialogResult.OK)
            {
                RefreshPeopleList();
            }
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditPersonForm addEditPersonForm = new AddEditPersonForm(-1);
            addEditPersonForm.ShowDialog();
            if (addEditPersonForm.DialogResult == DialogResult.OK)
            {
                RefreshPeopleList();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterOption.SelectedItem.ToString() != "None")
            { 
                txtFilterSearch.Visible = true;
                txtFilterSearch.Focus();
            }
            else
            {
                txtFilterSearch.Text = "";
                txtFilterSearch.Visible = false;
            }
                

            lbRecordsCount.Text = peopleView.Count.ToString();
        }

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonForm addEditPersonForm = new AddEditPersonForm(-1);
            addEditPersonForm.ShowDialog();
            if (addEditPersonForm.DialogResult == DialogResult.OK)
            {
                RefreshPeopleList();
            }

        }

        private void SmEditPerson(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);

            AddEditPersonForm addEditPersonForm = new AddEditPersonForm(personID);
            addEditPersonForm.ShowDialog();

            if(addEditPersonForm.DialogResult == DialogResult.OK)
            {
                RefreshPeopleList();
            }

        }

        private void SmDeletePerosn(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(dgvPeopleList.CurrentRow.Cells[0].Value);
            
            if(clsPerson.Delete(personID))
            {
                RefreshPeopleList();
                MessageBox.Show("Deleted Successfuly...");
            }
            else
            {
                MessageBox.Show("Not Deleted Try Again...");
            }
        }
    }
}