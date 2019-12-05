using System;

namespace DataManager
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

    #region login-register

    #region login

    /// <summary>
    /// This exception refers to a non existing user
    /// </summary>
    public class UserDoesntExistException : GameException
    {
        public UserDoesntExistException() : base("Your email/password dont match.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a wrong password
    /// </summary>
    public class WrongPasswordException : GameException
    {
        public WrongPasswordException() : base("Your email/password dont match.")
        {
        }
    }

    #endregion login

    #region register

    /// <summary>
    /// This exception refers to a user already existing
    /// </summary>
    public class UserAldreadyExistsException : GameException
    {
        public UserAldreadyExistsException() : base("This user already exists.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a register having two different passwords
    /// </summary>
    public class PasswordDontMatchException : GameException
    {
        public PasswordDontMatchException() : base("Your passwords don't match.")
        {
        }
    }

    #endregion register

    /// <summary>
    /// This exception refers to a badly formatted email
    /// </summary>
    public class NotValidEmailException : GameException
    {
        public NotValidEmailException() : base("Your mail is badly formatted.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a empty field
    /// </summary>
    public class EmptyFieldException : GameException
    {
        public EmptyFieldException() : base("You forgot to fill one or more fields.")
        {
        }
    }

    #endregion login-register

    #region database

    public class FailedDatabaseConnectionException : GameException
    {
        public FailedDatabaseConnectionException() : base("The database connection miserably failed.")
        {
        }
    }

    #endregion database

}
