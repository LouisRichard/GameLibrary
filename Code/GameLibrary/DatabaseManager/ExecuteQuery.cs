using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace GameLibrary
{
    public class ExecuteQuery
    {
        /// <summary>
        /// Execute a Select query
        /// </summary>
        /// <param name="query">Select query to execute</param>
        /// <returns>Query result as an SQLiteDataReader</returns>
        public static SQLiteDataReader Select(string query)
        {
            SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection

            command.CommandText = query;
            System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
            _ = DbConnector.ConnectToDatabase(true); //close db connection  Using Ignore(_) as we don't care what it returns.
            return reader;
        }
    }
}
