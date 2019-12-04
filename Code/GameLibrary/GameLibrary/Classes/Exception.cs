using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    /// <summary>
    /// GameException is the master exception for all exceptions in our project
    /// </summary>
    public class GameException : Exception
    {
        public GameException(string message) : base(message)
        {
        }
    }

    public class UserAldreadyExistsException : GameException
    {
        public UserAldreadyExistsException() : base("This user already exists.")
        {
        }
    }

    public class FailedDatabaseConnectionException : GameException
    {
        public FailedDatabaseConnectionException() : base("The database connection miserably failed.")
        {
        }
    }

}
