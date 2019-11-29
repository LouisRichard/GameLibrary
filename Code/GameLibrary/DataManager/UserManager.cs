using System;
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
            string testLoginQuery = @"SELECT * FROM [users] WHERE [email] = " + email + " AND PASSWORD = " + password;
            if(ExecuteQuery.Select(testLoginQuery) != null)
            {
                return true;
            }
            throw new Exception("User doesn't exist");
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
            string registerQuery = @"INSERT INTO [users] VALUES " + email + "," + password;
            string selectUserQuery = @"SELECT * FROM [users] WHERE email = " + email;

            if (ExecuteQuery.Select(selectUserQuery) == null)
            {
                try
                {
                    ExecuteQuery.Insert(registerQuery);
                    return true;
                }
                catch
                {
                    Exception exception;
                    throw new Exception("An error occured while trying to register. Please try again.");
                }
            }
            else
            {
                throw new Exception("User already exists");
            }
        }
    }
}
