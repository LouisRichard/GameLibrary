﻿using System;
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
        /// <summary>
        /// AddAGame form.
        /// </summary>
        private AddAGame addAGame = new AddAGame();

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
        public void MyLibrary_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{user.Username}";
        }

        #endregion formLoad

        /// <summary>
        /// This method launches the add a game form on top of the library.
        /// </summary>
        public void AddAGame(object sender, EventArgs e)
        {
            addAGame.ShowDialog(this);
        }
    }
}