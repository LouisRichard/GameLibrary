namespace DataManager
{
    public class Game
    {
        #region attributes

        /// <summary>
        /// The user's email.
        /// </summary>
        internal string title;
        /// <summary>
        /// 
        /// </summary>
        internal string platform;
        /// <summary>
        /// 
        /// </summary>

        #endregion attributes

        #region constructors

        /// <summary>
        /// User with every fields filled constructor.
        /// </summary>
        /// <param name="username">the user's username.</param>
        /// <param name="password">the user's password.</param>
        /// <param name="rePassword">the user's password confirmed.</param>
        public Game(string title, string platorm)
        {
            this.title = title;
            this.platform = platorm;
        }
    }
}
        #endregion