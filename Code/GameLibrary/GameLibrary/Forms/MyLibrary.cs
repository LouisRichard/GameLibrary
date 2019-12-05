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
    public partial class MyLibrary : Form
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

        public MyLibrary()
        {
            InitializeComponent();
        }

        #endregion formLoad
    }
}
