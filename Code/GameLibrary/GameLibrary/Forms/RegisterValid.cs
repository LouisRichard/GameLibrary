using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    public partial class RegisterValid : Form
    {
        #region attributes

        private User user;
        private LoginRegisterLib lib;

        #endregion attributes

        #region accessors

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        public LoginRegisterLib Lib
        {
            get { return lib; }
            set { lib = value; }
        }

        #endregion accessors

        #region formLoad

        public RegisterValid()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion formLoad

        private void RegisterValid_Load(object sender, EventArgs e)
        {
            lblConfirm.Text = $"{user.Username}, you're now registered.";

        }
    }
}
