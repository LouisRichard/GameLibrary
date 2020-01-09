using System;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    public partial class AddAGame : Form
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

        public AddAGame()
        {
            InitializeComponent();
        }

        #endregion formLoad

        #region confirm-cancel

        /// <summary>
        /// This method sends the game to DataManager
        /// </summary>
        public void Confirm(object sender, EventArgs e)
        {
            Game game = new Game(txtTitle.Text, cboPlatform.Text);
            GameManager.AddGameToLibrary(game, user);

            Cancel(sender, e);
        }

        /// <summary>
        /// This method closes the form without sending any data.
        /// </summary>
        public void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion confirm-cancel
    }
}
