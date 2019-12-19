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


        #endregion attributes

        #region constructors

        /// <summary>
        /// Game with every fields filled constructor.
        /// </summary>
        /// <param name="title">the game title</param>
        /// <param name="platform">the game platform</param>
        public Game(string title, string platorm)
        {
            this.title = title;
            this.platform = platorm;
        }
    }
}
        #endregion