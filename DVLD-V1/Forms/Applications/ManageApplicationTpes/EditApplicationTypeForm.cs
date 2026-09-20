using BusinessLayer.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.Forms.Applications.ManageApplicationTpes
{
    public partial class EditApplicationTypeForm : Form
    {

        private int _applicationTypeID;

        private clsApplicationType _applicationType;

        public EditApplicationTypeForm(int applicationTypeID)
        {
            InitializeComponent();

            _applicationTypeID = applicationTypeID;
        }

        private void _GetUpdatedApplicationInfo()
        {
            _applicationType.ApplicationTypeTitle = txtApplicationTypeTitle.Text;
            _applicationType.ApplicationFees =      Convert.ToSingle(txtApplicationFee.Text);
        }

        private void ShowApplicationInfoOnScreen()
        {
            txtApplicationTypeTitle.Text = _applicationType.ApplicationTypeTitle;
            txtApplicationFee.Text = _applicationType.ApplicationFees.ToString();
            lbApplicationTypeID.Text = _applicationType.ApplicationTypeID.ToString();
        }

        private void EditApplicationTypeForm_Load(object sender, EventArgs e)
        {
            _applicationType = clsApplicationType.Find(_applicationTypeID);

            ShowApplicationInfoOnScreen();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _GetUpdatedApplicationInfo();

            if(_applicationType.Save())
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
