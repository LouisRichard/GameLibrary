using System.Collections.Generic;
using DatabaseManager;
using System.Data.SQLite;

namespace DataManager
{
    public class UserManager
    {
        static CryptoPassword crypto = new CryptoPassword();

        /// <summary>
        /// Tries to log in a user
        /// </summary>
        /// <param name="email">user email</param>
        /// <param name="password">user password</param>
        /// <returns></returns>
        public static bool LoginRequest(string email, string password)
        {
            if(email == "" || password == "")
            {
                throw new EmptyFieldException();
            }
            string testLoginQuery = @"SELECT [Password] FROM [users] WHERE [email] = '" + email + "'";
                try
                {
                    List<string> queryResult = new List<string>();
                    queryResult = ExecuteQuery.Select(testLoginQuery);
                    if (queryResult.Count == 1)
                    {
                        string hashedPassword = queryResult[0];

                        if (crypto.Verify(password, hashedPassword))
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
        /// Tries to register a new user in the database
        /// </summary>
        /// <param name="email">user email</param>
        /// <param name="password">user password</param>
        /// <param name="confirmPassword">user password confirmed</param>
        /// <returns>bool -> true if success</returns>
        public static bool RegisterRequest(string email, string password, string confirmPassword)
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            if (email == "" || password == "" || confirmPassword == "")
            {
                throw new EmptyFieldException();
            }
            else if (lib.ValidMail(email))
            {
                if (password == confirmPassword)
                {
                    string registerQuery = @"INSERT INTO [Users] (Email, Password) VALUES ('" + email + "', '" + crypto.Hash(password) + "')";
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
    }
}
