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
            if (password == confirmPassword)
            {
                string registerQuery = @"INSERT INTO [Users] (Email, Password) VALUES ('" + email + "', '" + password + "')";

                List<string> selectResult = new List<string>();

                ExecuteQuery.Insert(registerQuery);
                return true;

            }
            throw new Exception("The passwords aren't the same");
        }
    }
}
