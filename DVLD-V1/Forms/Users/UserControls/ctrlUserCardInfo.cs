using BusinessLayer.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersentationLayer.Forms.Users.UserControls
{
    public partial class ctrlUserCardInfo : UserControl
    {

        public clsUser user;

        public ctrlUserCardInfo()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int userID)
        {
            if (clsUser.IsUserExists(userID))
            {
                user = clsUser.Find(userID);

                if (user != null)
                    ctrlPersonCard1.LoadPersonInfo(user.PersonID);
            }

            lbUserID.Text = user.UserID.ToString();
            lbUserName.Text = user.UserName;
            lbIsActive.Text = user.IsActive ? "Yse" : "No";
        }
    }
}
