using System;
using System.Collections.Generic;
using DatabaseManager;

namespace DataManager
{
    /// <summary>
    /// The class for games requests.
    /// </summary>
    public class GameManager
    {
        #region public methods
        /// <summary>
        /// Returns the user's game library using his email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>List of game id's in his library (string)</sreturns>
        public static List<string> GetGameLibrary(string email)
        {
            int userID = UserManager.GetUserID(email);
            string getUserLibraryQuery = @"SELECT [idGame] FROM Library WHERE [idUser] = " + userID + "'";

            List<string> gameList = new List<string>();
            foreach (string gameID in ExecuteQuery.Select(getUserLibraryQuery))
            {
                string getGameTitleLibraryQuery = @"SELECT [title] FROM [games] WHERE [idGame] = " + Int32.Parse(gameID);
                gameList.Add(ExecuteQuery.Select(getGameTitleLibraryQuery)[0]);
            }

            return gameList;
        }

        /// <summary>
        /// Adds a game to the user's library
        /// </summary>
        /// <param name="game"></param>
        /// <param name="user"></param>
        /// <returns>True if operation is a success</returns>
        public static bool AddGameToLibrary(Game game, User user)
        {
            int userID = UserManager.GetUserID(user.username);
            int gameID;
            int platformID;

            try
            {
                gameID = GetGameID(game);
            }
            catch
            {
                AddGameToGameList(game);
                gameID = GetGameID(game);
            }

            try
            {
                string GetPlatformIDQuery = @"SELECT [idPlatform] FROM [Platforms] WHERE [Name] = '" + game.platform + "'";
                platformID = int.Parse(ExecuteQuery.Select(GetPlatformIDQuery)[0]);
                string getGamePlatformQuery = @"SELECT [idGame] FROM [GamesPlatforms] WHERE [idPlatform] = " + platformID;
                int platform = int.Parse(ExecuteQuery.Select(getGamePlatformQuery)[0]);
            }
            catch
            {
                AddGamePlatform(game);
                string GetPlatformIDQuery = @"SELECT [idPlatform] FROM [Platforms] WHERE [Name] = '" + game.platform + "'";
                platformID = int.Parse(ExecuteQuery.Select(GetPlatformIDQuery)[0]);
                string getGamePlatformQuery = @"SELECT [idGame] FROM [GamesPlatforms] WHERE [idPlatform] = " + platformID;
                int platform = int.Parse(ExecuteQuery.Select(getGamePlatformQuery)[0]);
            }
            string sqlFomattedDate = DateTime.Now.Date.ToString("yyyy-MM-dd");
            try
            {
                //Add to version 1.1 OR 1.0 (depending on time we've got left) : platform in the library
                string insertQuery = @"INSERT INTO [Library] (idUser, idGame, DateAdded) VALUES (" + userID + "," + gameID + ", "+sqlFomattedDate+")";

                ExecuteQuery.Insert(insertQuery);

                return true;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //GameAlreadyInLibraryException -> NEED TO BE WRITTEN
            //CannotAccessTheDatabaseException -> NEED TO BE WRITTEN
        }

        /// <summary>
        /// Get all the games in the database
        /// </summary>
        /// <returns>List of game title (string)</returns>
        public static List<string> GetGameList()
        {
            string getGameQuery = @"SELECT [title] FROM [Games]";
            List<string> queryResult = new List<string>();
            try
            {
                queryResult = ExecuteQuery.Select(getGameQuery);
                return queryResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                //TO IMPLEMENT throw new GameAlreadyExistExeption();
            }
        }

        /// <summary>
        /// Add a game to the list of games in the database
        /// If the game already exist, add a reference for the platoform
        /// </summary>
        /// <param name="game">the game object that contains the title and the platform name.</param>
        public static void AddGameToGameList(Game game)
        {
            if (game.title == "" || game.platform == "")
            {
                throw new EmptyFieldException();
            }
            

            string addNewGameQuery = @"INSERT INTO [Games](title) VALUES ('" + game.title + "')";
            try
            {
                ExecuteQuery.Insert(addNewGameQuery);
                AddGamePlatform(game);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                // TO IMPLEMENT throw new GameAlreadyExistExeption();
            }
        }

        /// <summary>
        /// Add a new relation between a game and a platform
        /// </summary>
        /// <param name="game"></param>
        public static void AddGamePlatform(Game game)
        {
            string getGameQuery = @"SELECT [idGame] FROM [Games] WHERE [title] = '" + game.title + "'";

            string getPlatformIdQuery = @"SELECT [idPlatform] FROM [Platforms] WHERE [Name] = '" + game.platform + "'";
            int gameID = int.Parse(ExecuteQuery.Select(getGameQuery)[0]);
            int platformID = int.Parse(ExecuteQuery.Select(getPlatformIdQuery)[0]);
            string insertGamePlatformQuery = @"INSERT INTO [GamesPlatforms] (idGame, idPlatform) VALUES (" + gameID + ", " + platformID + ")";
            ExecuteQuery.Insert(insertGamePlatformQuery);
        }

        /// <summary>
        /// Select the userID in the database.
        /// </summary>
        /// <param name="game"></param>
        /// <returns>the ID converted in int</returns>
        public static int GetGameID(Game game)
        {
            string getUserIdQuery = @"SELECT [idGame] FROM [Games] WHERE [Title] = '" + game.title + "'";
            List<string> userIDString = ExecuteQuery.Select(getUserIdQuery);
            return int.Parse(userIDString[0]);
        }
        #endregion
    }
}
