using System.Collections.Generic;
using DatabaseManager;
using System.Data.SQLite;
using System;

namespace DataManager
{
    /// <summary>
    /// The class for the login and register requests.
    /// </summary>
    public class UserManager
    {
        #region attributes

        /// <summary>
        /// The encryptions methods.
        /// </summary>
        static CryptoPassword crypto = new CryptoPassword();

        #endregion attributes

        #region public methods
        
        /// <summary>
        /// Tries to login a new user in the database.
        /// </summary>
        /// <param name="user">the user structure, it containe email, password and rePassword</param>
        /// <returns>true if success</returns>
        public static bool LoginRequest(User user)
        {
            if(user.username == "" || user.password == "")
            {
                throw new EmptyFieldException();
            }
            string testLoginQuery = @"SELECT [Password] FROM [users] WHERE [email] = '" + user.username + "'";
                try
                {
                    List<string> queryResult = new List<string>();
                    queryResult = ExecuteQuery.Select(testLoginQuery);
                    if (queryResult.Count == 1)
                    {
                        string hashedPassword = queryResult[0];

                        if (crypto.Verify(user.password, hashedPassword))
                        {
                            return true;
                        }
                        throw new WrongPasswordException();
                    }
                    throw new UserDoesntExistException();
                }
                catch (SQLiteException)
                {
                    throw new FailedDatabaseConnectionException();
                }
        }
        
        /// <summary>
        /// Tries to register a new user in the database.
        /// </summary>
        /// <param name="user">the user structure, it containe email, password and rePassword</param>
        /// <returns>true if success</returns>
        public static bool RegisterRequest(User user)
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            if (user.username == "" || user.password == "" || user.rePassword == "")
            {
                throw new EmptyFieldException();
            }
            if (lib.ValidMail(user.username))
            {
                if (user.password == user.rePassword)
                {
                    string registerQuery = @"INSERT INTO [Users] (Email, Password) VALUES ('" + user.username + "', '" + crypto.Hash(user.password) + "')";
                    try
                    {

                        ExecuteQuery.Insert(registerQuery);
                        return true;
                    }
                    catch
                    {
                        throw new UserAldreadyExistsException();
                    }
                }
                throw new PasswordDontMatchException();
            }
            throw new NotValidEmailException();
        }

        /// <summary>
        /// Gets the user ID using his email
        /// </summary>
        /// <param name="email">User's email</param>
        /// <returns>int32 User ID</returns>
        public static int GetUserID(string email)
        {
            string getUserIdQuery = @"SELECT [idUser] FROM [Users] WHERE [Email] = '" + email + "'";
            List<string> userIDString = ExecuteQuery.Select(getUserIdQuery);
            return int.Parse(userIDString[0]);
        }

        #endregion public methods
    }
}
