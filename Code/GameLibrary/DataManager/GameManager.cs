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
        /// <summary>
        /// Returns the user's game library using his email
        /// </summary>
        /// <param name="email"></param>
        /// <returns>List of game id's in his library (string)</returns>
        public List<string> GetGameLibrary(string email)
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

        public bool AddGameToLibrary(string title, string email)
        {
            throw new NotImplementedException();
            int userID = UserManager.GetUserID(email);

            //TOOD
            //GET USER ID - DONE
            //GET GAME ID
            //INSERT INTO LIBRARY THOSES TWO VALUES
            //IF SUCCESS -> RETURN TRUE
            //ELSE -> EXCEPTION : 
            //GameAlreadyInLibraryException -> NEED TO BE WRITTEN
            //CannotAccessTheDatabaseException -> NEED TO BE WRITTEN
        }

        /// <summary>
        /// Get all the games in the database
        /// </summary>
        /// <returns>List of game title (string)</returns>
        public List<string> GetGameList()
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
        /// <param name="gameTitle">Game title</param>
        /// <param name="platform">Platform name</param>
        public void AddGameToGameList(string gameTitle, string platform)
        {
            if (gameTitle == "" || platform == "")
            {
                throw new EmptyFieldException();
            }
            string getGameQuery = @"SELECT [idGame] FROM [Games] WHERE [title] = '" + gameTitle + "'";
            if (ExecuteQuery.Select(getGameQuery)[0] == null)
            {
                string addNewGameQuery = @"INSERT INTO [Games](title) VALUES ('" + gameTitle + "')";
                try
                {
                    ExecuteQuery.Insert(addNewGameQuery);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                    // TO IMPLEMENT throw new GameAlreadyExistExeption();

                }
            }
            try
            {
                string getPlatformIdQuery = @"SELECT [idPlatform] FROM [Platforms] WHERE [Name] = '" + platform + "'";
                int gameID = int.Parse(ExecuteQuery.Select(getGameQuery)[0]);
                int platformID = int.Parse(ExecuteQuery.Select(getPlatformIdQuery)[0]);
                string insertGamePlatformQuery = @"INSERT INTO [GamesPlatforms] (idGame, idPlatform) VALUES (" + gameID + ", " + platformID + ")";
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }
    }
}
