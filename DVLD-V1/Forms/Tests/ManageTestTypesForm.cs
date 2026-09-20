using BusinessLayer.Application;
using BusinessLayer.Test.TestType;
using PersentationLayer.Forms.Applications.ManageApplicationTpes;
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
    public partial class ManageTestTypesForm : Form
    {
        private DataTable _TestTypesTable;
        private DataView _TestTypesView;
        public ManageTestTypesForm()
        {
            InitializeComponent();
        }

        private void LoadTestTypesList()
        {
            _TestTypesTable = clsTestType.GetAllApplicationTypes();
            _TestTypesView = _TestTypesTable.DefaultView;
        }

        private void _UpdateRecordCount()
        {
            lbTestTypesListCount.Text = (_TestTypesView.Count.ToString());
        }

        private void _RefreshTestTypesList()
        {
            LoadTestTypesList();
            dgvTestTypesList.DataSource = _TestTypesView;

            if (_TestTypesView.Count > 1)
                _UpdateRecordCount();
        }

        private void ManageTestTypesForm_Load(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
        }

        private void editTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testTypeID = (int)(dgvTestTypesList.SelectedCells[0].Value);

            EditTestTypeForm editTestTypeForm = new EditTestTypeForm(testTypeID);
            editTestTypeForm.ShowDialog();
            if (editTestTypeForm.DialogResult == DialogResult.OK)
                _RefreshTestTypesList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
