using BusinessLayer.Test.TestType;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.Forms.Tests
{
    public partial class EditTestTypeForm : Form
    {
        private clsTestType _testType;
        private int _testTypeID;

        public EditTestTypeForm(int testTypeID)
        {
            InitializeComponent();

            _testTypeID = testTypeID;
        }

        private void _DisplayTestTypeInfoOnTheScreen()
        {
            lbTestTypeID.Text = _testTypeID.ToString();
            txtTestTypeTitle.Text = _testType.TestTypeTitle;
            rtxtTestTypeDescription.Text = _testType.TestTypeDescription;
            txtTestTypeFee.Text = _testType.TestTypeFees.ToString();
        }

        private void EditTestTypeForm_Load(object sender, EventArgs e)
        {
            _testType = clsTestType.Find(_testTypeID);

            if(_testType == null)
            {
                MessageBox.Show("Test Type Dose not exists");
                this.Close();
                return;
            }
            else
            {
               _DisplayTestTypeInfoOnTheScreen();
            }
        }

        private void GetTestTypeEditedInfo()
        {
            _testTypeID = Convert.ToInt32(lbTestTypeID.Text);
            _testType.TestTypeTitle = txtTestTypeTitle.Text;
            _testType.TestTypeDescription = rtxtTestTypeDescription.Text;
            _testType.TestTypeFees = Convert.ToInt32(txtTestTypeFee.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GetTestTypeEditedInfo();

            if (_testType.Save())
            {
                MessageBox.Show("Information Edited Successfuly");
                this.DialogResult = DialogResult.OK;
                return;
            }
            MessageBox.Show("Something Went Wrong");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
