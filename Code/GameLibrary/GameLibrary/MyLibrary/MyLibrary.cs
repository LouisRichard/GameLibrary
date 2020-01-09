using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void MyLibrary_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{user.Username}";
            List<string> gameTitles = GameManager.GetGameLibrary(user.Username);
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            foreach(string title in gameTitles)
            {
                dt.Rows.Add(title);
            }
            dgvLibrary.DataSource = dt;
        }

        #endregion formLoad

        #region actions

        /// <summary>
        /// This method launches the add a game form on top of the library.
        /// </summary>
        public void AddAGame(object sender, EventArgs e)
        {
            addAGame.User = user;
            addAGame.ShowDialog(this);
        }

        #endregion actions
    }
}