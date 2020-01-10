namespace DataManager
{
    /// <summary>
    /// This class represents a game.
    /// </summary>
    public class Game
    {
        #region attributes

        /// <summary>
        /// The game's title.
        /// </summary>
        internal string title;
        /// <summary>
        /// The game's platform
        /// </summary>
        internal string platform;

        #endregion attributes

        #region constructors

        /// <summary>
        /// Game with every fields filled constructor.
        /// </summary>
        /// <param name="title">the game's title</param>
        /// <param name="platform">the game's platform</param>
        public Game(string title, string platorm)
        {
            this.title = title;
            this.platform = platorm;
        }

        #endregion constructors
    }
}