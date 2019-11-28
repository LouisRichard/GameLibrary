using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace GameLibrary
{
    public class ExecuteQuery
    {
        /// <summary>
        /// Execute a Select query
        /// </summary>
        /// <param name="query">Select query to execute</param>
        /// <returns>Query result as an String List</returns>
        public static List<string> Select(string query)
        {
            SQLiteCommand command = DbConnector.ConnectToDatabase(false); //open db connection
            List<string> result = new List<string>();
            DataTable dt = new DataTable();
            command.CommandText = query;
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    result.Add(Convert.ToString(reader));
                }
            }
                _ = DbConnector.ConnectToDatabase(true); //close db connection  Using Ignore(_) as we don't care what it returns.
            return result;
        }
    }
}
