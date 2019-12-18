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
    /// <summary>
    /// This form is main form of the program past the login-register process.
    /// </summary>
    public partial class MyLibrary : Form
    {
        #region attributes

        /// <summary>
        /// The user inherited from the login-register.
        /// </summary>
        private User user;

        #endregion attributes

        #region accessors

        /// <summary>
        /// Contains the user information.
        /// </summary>
        public User User
        {
            set { user = value; }
        }

        #endregion accessors

        #region formLoad

        public MyLibrary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The loading of the form.
        /// </summary>
        private void MyLibrary_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{user.Username}";
        }

        #endregion formLoad
    }
}