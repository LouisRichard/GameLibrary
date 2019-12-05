using System;
using System.Collections.Generic;
using DatabaseManager;

namespace DataManager
{
    public class UserManager
    {
        /// <summary>
        /// Tries to log in a user
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool LoginRequest(string email, string password)
        {
            string testLoginQuery = @"SELECT * FROM [users] WHERE [email] = '" + email + "' AND PASSWORD = '" + password + "'"  ;
            try
            {
                if (ExecuteQuery.Select(testLoginQuery).Count == 1)
                {
                    return true;
                }
                throw new UserDoesntExistException();
            }
            catch
            {
                throw new FailedDatabaseConnectionException();
            }
        }


        /// <summary>
        /// Tries to register a new user in the database
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="confirmPassword"></param>
        /// <returns>bool -> true if success</returns>
        public static bool RegisterRequest(string email, string password, string confirmPassword)
        {
            LoginRegisterLib lib = new LoginRegisterLib();
            if(lib.ValidMail(email))
            {
                if (password == confirmPassword)
                {
                    string registerQuery = @"INSERT INTO [Users] (Email, Password) VALUES ('" + email + "', '" + password + "')";
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
