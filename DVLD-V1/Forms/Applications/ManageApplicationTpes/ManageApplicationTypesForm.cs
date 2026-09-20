using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Application;
using PersentationLayer.Forms.Applications.ManageApplicationTpes;

namespace PersentationLayer.Forms.Tests
{
    public partial class ManageApplicationTypesForm : Form
    {

        private DataTable _applicationTypesTable;
        private DataView _applicationTypesView;
        public ManageApplicationTypesForm()
        {
            InitializeComponent();
        }

        private void LoadApplicationTypesList()
        {
            _applicationTypesTable = clsApplicationType.GetAllApplicationTypes();
            _applicationTypesView = _applicationTypesTable.DefaultView;
        }

        private void _UpdateRecordCount()
        {
            lbApplicationTypesListCount.Text = (_applicationTypesView.Count.ToString());
        }

        private void _RefreshApplicationTypesList()
        {
            LoadApplicationTypesList();
            dgvApplicationTypesList.DataSource = _applicationTypesView;
            
            if(_applicationTypesView.Count > 1)
                _UpdateRecordCount();
        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editApplicationTypeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int applicationTypeID = (int)(dgvApplicationTypesList.SelectedCells[0].Value);

            EditApplicationTypeForm editApplicationTypeForm = new EditApplicationTypeForm(applicationTypeID);
            editApplicationTypeForm.ShowDialog();
            if (editApplicationTypeForm.DialogResult == DialogResult.OK)
                _RefreshApplicationTypesList();
        }
    }
}
