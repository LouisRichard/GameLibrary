namespace GameLibrary
{
    /// <summary>
    /// This class represents a user.
    /// </summary>
    public class User
    {
        #region attributes

        /// <summary>
        /// The user's email.
        /// </summary>
        private string username;
        /// <summary>
        /// The user's password.
        /// </summary>
        private string password;
        /// <summary>
        /// The user's password confirmation.
        /// </summary>
        private string rePassword;

        #endregion attributes

        #region accessors

        /// <summary>
        /// The email of the user.
        /// </summary>
        public string Username
        {
            get { return username; }
            set { this.username = value.ToLower(); }
        }

        /// <summary>
        /// The password of the user.
        /// </summary>
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// The password confirmed by the user.
        /// </summary>
        public string RePassword
        {
            get
            {
                return rePassword;
            }
            set
            {
                this.rePassword = value;
            }
        }

        #endregion accessors
    }
}
