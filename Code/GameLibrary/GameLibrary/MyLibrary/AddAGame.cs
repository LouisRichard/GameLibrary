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
        /// <summary>
        /// 
        /// </summary>
        private Game game;

        #endregion attributes

        #region accessors

        /// <summary>
        /// Contains the user information.
        /// </summary>
        public User User
        {
            set { user = value; }
        }

        public Game Game
        {
            get; set;
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
            bool success = false;

            Game game = new Game(txtTitle.Text, cboPlatform.Text);
            try { success = GameManager.AddGameToLibrary(game, user); }
            catch (DbException except) { lblError.Text = $"{except.Message}"; }
            catch (GameException except) { lblError.Text = $"{except.Message}"; }
            catch (EmptyFieldException except) { lblError.Text = $"{except.Message}"; }

            if (success) Cancel(sender, e);
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
