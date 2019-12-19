namespace DataManager
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
        internal string username;
        /// <summary>
        /// 
        /// </summary>
        internal string password;
        /// <summary>
        /// 
        /// </summary>
        internal string rePassword;

        #endregion attributes

        #region constructors
        
        /// <summary>
        /// User with every fields filled constructor.
        /// </summary>
        /// <param name="username">the user's username.</param>
        /// <param name="password">the user's password.</param>
        /// <param name="rePassword">the user's password confirmed.</param>
        public User(string username, string password, string rePassword)
        {
            this.username = username.ToLower();
            this.password = password;
            this.rePassword = rePassword;
        }

        #endregion constructors

        #region accessors

        public string Username { get => username; }

        #endregion accessors
    }
}
