using System;
using System.Windows.Forms;
using DataManager;

namespace GameLibrary
{
    /// <summary>
    /// This form is used to add a game to your library.
    /// </summary>
    public partial class AddAGame : Form
    {
        #region attributes

        /// <summary>
        /// The user inherited from the login-register.
        /// </summary>
        private User user;
        /// <summary>
        /// The game coming from MyLibrary.
        /// </summary>
        private Game game;
        /// <summary>
        /// The mode of the view, Add or Edit.
        /// </summary>
        private string mode;

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

        public AddAGame(string mode)
        {
            InitializeComponent();

            this.mode = mode;
        }

        private void AddAGame_Load(object sender, EventArgs e)
        {
            if (mode == "Edit")
            {
                this.Text = "EditAGame";
                txtTitle.Text = game.Title;
                cboPlatform.Text = game.Platform;
            }
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

            if (success)
            {
                if (mode == "Edit")
                {
                    //Edit game
                }
                Cancel(sender, e);
            }
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
