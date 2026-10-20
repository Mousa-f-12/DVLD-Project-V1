using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace PersentationLayer.Forms.Applications.LocalDrivingLicenseApplication
{
    public partial class AddLocalDrivingLiceenseForm : Form
    {
        private int _personID;

        public AddLocalDrivingLiceenseForm()
        {
            InitializeComponent();
            ctrlFindPerson1.OnFindClick += _GetPersonID;
        }

        private void _GetPersonID(int personID)
        {
            _personID = personID;
        }
    }
}
