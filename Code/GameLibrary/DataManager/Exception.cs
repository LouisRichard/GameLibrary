﻿using System;

namespace DataManager
{
    #region login-register

    /// <summary>
    /// LoginRegisterException is the master exception for all exceptions related to the login-register process.
    /// </summary>
    public class LoginRegisterException : Exception
    {
        public LoginRegisterException(string message) : base(message)
        {
        }
    }

    #region login

    /// <summary>
    /// This exception refers to a non existing user.
    /// </summary>
    public class UserDoesntExistException : LoginRegisterException
    {
        public UserDoesntExistException() : base("Your email/password dont match.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a wrong password.
    /// </summary>
    public class WrongPasswordException : LoginRegisterException
    {
        public WrongPasswordException() : base("Your email/password dont match.")
        {
        }
    }

    #endregion login

    #region register

    /// <summary>
    /// This exception refers to a user already existing.
    /// </summary>
    public class UserAldreadyExistsException : LoginRegisterException
    {
        public UserAldreadyExistsException() : base("This user already exists.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a register having two different passwords.
    /// </summary>
    public class PasswordDontMatchException : LoginRegisterException
    {
        public PasswordDontMatchException() : base("Your passwords don't match.")
        {
        }
    }

    #endregion register

    /// <summary>
    /// This exception refers to a badly formatted email.
    /// </summary>
    public class NotValidEmailException : LoginRegisterException
    {
        public NotValidEmailException() : base("Your email is badly formatted.")
        {
        }
    }

    /// <summary>
    /// This exception refers to a empty field.
    /// </summary>
    public class EmptyFieldException : LoginRegisterException
    {
        public EmptyFieldException() : base("You forgot to fill one or more fields.")
        {
        }
    }

    #endregion login-register
    
    #region database

    /// <summary>
    /// DbException is the master exception for all exceptions related to the db.
    /// </summary>
    public class DbException : Exception
    {
        public DbException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// This exception is used to inform that the database connection failed.
    /// </summary>
    public class FailedDatabaseConnectionException : DbException
    {
        public FailedDatabaseConnectionException() : base("The database connection miserably failed.")
        {
        }
    }

    #endregion database

    #region game

    /// <summary>
    /// GameException is the master exception for all exceptions related to games processes.
    /// </summary>
    public class GameException : Exception
    {
        public GameException(string message) : base(message)
        {
        }
    }

    /// <summary>
    /// This exception is used to inform the user that the game already exists in his library.
    /// </summary>
    public class GameAlreadyExistsException : GameException
    {
        public GameAlreadyExistsException() : base("This game already exists in your library.")
        {
        }
    }

    /// <summary>
    /// This exception is used to inform the user that he has to choose a platform from our list.
    /// </summary>
    public class PlatformDoesntExistsException : GameException
    {
        public PlatformDoesntExistsException() : base("This platform is not in the list.")
        {
        }
    }

    #endregion
}