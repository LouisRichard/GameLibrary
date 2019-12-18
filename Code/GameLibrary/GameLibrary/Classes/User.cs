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

        #endregion attributes

        #region constructors
        
        /// <summary>
        /// User empty constructor.
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// User with every fields filled constructor.
        /// </summary>
        /// <param name="username">the user's username.</param>
        /// <param name="password">the user's password.</param>
        /// <param name="rePassword">the user's password confirmed.</param>
        public User(string username, string password, string rePassword)
        {
            Username = username;
            Password = password;
            RePassword = rePassword;
        }

        #endregion constructors

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
        public string Password { get; set; }

        /// <summary>
        /// The password confirmed by the user.
        /// </summary>
        public string RePassword { get; set; }

        #endregion accessors
    }
}
