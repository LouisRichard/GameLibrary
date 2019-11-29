using System;

namespace GameLibrary
{
    public class UserManager
    {
        public static bool LoginRequest(string email, string password)
        {
            string testLoginQuery = @"SELECT * FROM [users] WHERE [email] = " + email + " AND PASSWORD = " + password;

            if(ExecuteQuery.Select(testLoginQuery) != null)
            {
                return true;
            }
            throw new Exception("User doesn't exist");
        }
    }
}
