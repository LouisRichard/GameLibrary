using System;
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

        /// <summary>
        /// Contains the user information
        /// </summary>
        public User User
        {
            get { return user; }
            set { user = value; }
        }

        /// <summary>
        /// Lib contains all the methods for the login-register process
        /// </summary>
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

        /// <summary>
        /// This method puts the username of the new user in the window
        /// </summary>
        private void RegisterValid_Load(object sender, EventArgs e)
        {
            lblConfirm.Text = $"{user.Username}, you're now registered.";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion formLoad
    }
}
